#include "app_main.h"
#include "uib_app_manager.h"
#include "uib_views.h"
#include "uib_views_inc.h"
#include <device/haptic.h>

app_data * ad;
uib_app_manager_st* app_manager;
int count;

#define DB_Threshold -25

typedef struct
{
	recorder_audio_codec_e *codec_list;
	int len;
} supported_encoder_data;

static bool _recorder_is_recording(app_data *ad);
static void send_audio(app_data *data);
void record_start();
void record_stop();
/* app event callbacks */
static bool _on_create_cb(void *user_data);
static void _on_terminate_cb(void *user_data);
static void _on_app_control_cb(app_control_h app_control, void *user_data);
static void _on_resume_cb(void *user_data);
static void _on_pause_cb(void *user_data);
static void _on_low_memory_cb(app_event_info_h event_info, void *user_data);
static void _on_low_battery_cb(app_event_info_h event_info, void *user_data);
static void _on_device_orientation_cb(app_event_info_h event_info, void *user_data);
static void _on_language_changed_cb(app_event_info_h event_info, void *user_data);
static void _on_region_format_changed_cb(app_event_info_h event_info, void *user_data);

Eina_Bool
ecore_timer_cb2()
{
	dlog_print(DLOG_INFO,"USR_TAG","ecore_timer_cb2!!");
	uib_view2_view_context* vc = app_manager->find_view_context("view2");
	char *resource_path = NULL;
	uib_util_rm_get_resource_path(-1, "detecting.png", &resource_path);
	elm_image_file_set(vc->image2, resource_path, NULL);

	record_start();
	ad->timer2 = NULL ;
	return ECORE_CALLBACK_CANCEL;
}

Eina_Bool
ecore_timer_cb()
{
	dlog_print(DLOG_INFO,"USR_TAG","timer start!");
	double db=-300;
	count++;

	if(recorder_get_audio_level(ad->recorder,&db) == RECORDER_ERROR_NONE)
	{
		dlog_print(DLOG_INFO,"USR_TAG","db:%f",db);

			if((ad->max_db < db)&&(count > 20))
			{
				ad->max_db = db;
			}
		dlog_print(DLOG_INFO,"USR_TAG","%s%f","max_db:",ad->max_db);
	}


	//When a loud sound is detected
	if(((int)ad->max_db > DB_Threshold) && !(ad->db_flag))
	{
		ad->db_flag = true;
		dlog_print(DLOG_INFO,"USR_TAG","loud sound is detected!");

		// change the image : detecting.img -> loud_sound.img
		uib_view2_view_context* vc = app_manager->find_view_context("view2");
		char *resource_path = NULL;
		uib_util_rm_get_resource_path(-1, "loud_sound.png", &resource_path);
		elm_image_file_set(vc->image2, resource_path, NULL);

		//discard previous sounds and start new 3 second's recording for a loud sound.
		recorder_cancel(ad->recorder);
		if(!_recorder_is_recording(ad))
		{
			recorder_unprepare(ad->recorder);
		}

		ad->time_limit = 2; //3 seconds recording for a loud sound,and then time_limit_cb function execute!
		record_start();
		ad->timer = NULL;
		return ECORE_CALLBACK_CANCEL;
	}
}

//Check is recording
static bool
_recorder_is_recording(app_data *ad)
{
	recorder_state_e state = RECORDER_STATE_NONE;
	recorder_get_state(ad->recorder, &state);
	return state == RECORDER_STATE_RECORDING;
}

static void setSoundImage(char* buf){
	char siren[]= "siren";
	char car[] ="car";
	char gun[] ="gun";
	char dog[] = "dog";

	uib_view2_view_context* vc = app_manager->find_view_context("view2");

	if(!strcmp(siren,buf)){
		char *resource_path = NULL;
		uib_util_rm_get_resource_path(-1, "siren.png", &resource_path);
		elm_image_file_set(vc->image2, resource_path, NULL);
	}else if(!strcmp(car,buf)){
		char *resource_path = NULL;
		uib_util_rm_get_resource_path(-1, "car.png", &resource_path);
		elm_image_file_set(vc->image2, resource_path, NULL);
	}else if(!strcmp(gun,buf)){
		char *resource_path = NULL;
		uib_util_rm_get_resource_path(-1, "gun.png", &resource_path);
		elm_image_file_set(vc->image2, resource_path, NULL);
	}else if(!strcmp(dog,buf)){
		char *resource_path = NULL;
		uib_util_rm_get_resource_path(-1, "dog.png", &resource_path);
		elm_image_file_set(vc->image2, resource_path, NULL);
	}else{
		return;
	}

	device_haptic_vibrate(ad->handle,2000,100,ad->effect_handle);
}
static void
send_audio(app_data *data){

	FILE *fp;
	struct sockaddr_in address;
	char buf_size[50];
	char buff_audio[1024];
	char buff_rcv[1024];
	unsigned int file_size;
	int sendBytes;

	struct timeval recv_limit_time;
	recv_limit_time.tv_sec = 3;
	recv_limit_time.tv_usec = 0;

	fp = fopen(ad->file_path,"rb");
	if(fp == NULL)
	{
		dlog_print(DLOG_ERROR,"USR_TAG","FILE Pointer ERROR");
	}

	fseek(fp, 0L, SEEK_END);
	file_size = ftell(fp);
	fseek(fp, 0L, SEEK_SET);

	//int SendNum = file_size/sizeof(buff_audio)+1;
	snprintf(buf_size, sizeof(buf_size), "%d/", file_size);

	memset(&address,0,sizeof(address));
	address.sin_family = AF_INET;
	address.sin_addr.s_addr = 274187880;
	//address.sin_addr.s_addr = 167845548;
	address.sin_port = htons(8001);

	int sockfd = socket(AF_INET, SOCK_STREAM, 0);

	if(sockfd == -1) {
		dlog_print(DLOG_INFO,"USR_TAG","socket create fail");
		return;
	}

	setsockopt(sockfd, SOL_SOCKET, SO_RCVTIMEO, (char *)&recv_limit_time, sizeof(recv_limit_time));
	setsockopt(sockfd, SOL_SOCKET, SO_SNDTIMEO, (char *)&recv_limit_time, sizeof(recv_limit_time));

	alarm(1);
	if(connect(sockfd, (struct sockaddr*)&address, sizeof(address)) == -1){
		dlog_print(DLOG_INFO,"USR_TAG","socket connection fail");
		return;
	}
	alarm(0);

	//send Start Message
	char start[1024] = "TIZEN";
	if(send(sockfd,start,1024,MSG_NOSIGNAL)<=0){
		dlog_print(DLOG_INFO,"USR_TAG","write 1 error");
	}
	if(send(sockfd,buf_size,sizeof(buf_size),0)<=0){
		dlog_print(DLOG_INFO,"USR_TAG","write 2 error");
	}

	//file send
	while((sendBytes = fread(buff_audio,sizeof(char),sizeof(buff_audio),fp))>0){
			send(sockfd,buff_audio,sendBytes,0);
	}

	//recv mesg
	memset(buff_rcv, 0x00, 1024);
	if(recv(sockfd,buff_rcv,sizeof(buff_rcv)-1,MSG_NOSIGNAL)==-1){
		dlog_print(DLOG_INFO,"USR_TAG","read 1 error");
	}
	dlog_print(DLOG_INFO,"USR_TAG","******************");
	dlog_print(DLOG_INFO,"USR_TAG","recv:%s",buff_rcv);
	dlog_print(DLOG_INFO,"USR_TAG","******************");

	setSoundImage(buff_rcv);
	close(sockfd);
}
void
program_stop()
{
	if(ad->recorder)
		{
			if(ad->timer){
				ecore_timer_del(ad->timer);
				ad->timer = NULL;
			}
			if(ad->timer2){
				ecore_timer_del(ad->timer2);
				ad->timer2 = NULL;
			}
			recorder_cancel(ad->recorder);
			//Check is recording
			if(!_recorder_is_recording(ad))
			{
				recorder_unprepare(ad->recorder);
			}

			ad->db_flag = false;
			ad->time_limit = 0;
		}
}
//Stop recording
void
record_stop()
{
	dlog_print(DLOG_INFO,"USR_TAG","record_stop");

	if(ad->recorder)
	{
		recorder_commit(ad->recorder);
		//Check is recording
		if(!_recorder_is_recording(ad))
		{
			recorder_unprepare(ad->recorder);
		}

		send_audio(ad);
		ad->db_flag = false;
		ad->time_limit = 0;
	}

}

//Maximum recording time event callback function
static void
_on_recording_limit_reached_cb(recorder_recording_limit_type_e type, void *user_data)
{
	app_data *ad = user_data;
	if(type == RECORDER_RECORDING_LIMIT_TIME)
		record_stop(); //STOP recording
		ad->timer2 = ecore_timer_add(5,ecore_timer_cb2,NULL);
		//record_start(); //START recording
}

//Create recorder
static void
_recorder_create(app_data *ad)
{
	int num;
	device_haptic_get_count(&num);

	if(num >=1){
		dlog_print(DLOG_INFO,"USR_TAG","num:%d",num);
		device_haptic_open(0,&ad->handle);
	}
	if(recorder_create_audiorecorder(&ad->recorder) == RECORDER_ERROR_NONE)
	{
		//Set maximum recording time event callback function
		recorder_set_recording_limit_reached_cb(ad->recorder,_on_recording_limit_reached_cb,ad);
		recorder_attr_set_audio_channel(ad->recorder,1);
		recorder_attr_set_audio_device(ad->recorder, RECORDER_AUDIO_DEVICE_MIC);
	}
}


static bool
_recorder_supported_audio_encoder_cb(recorder_audio_codec_e codec, void *user_data)
{
	bool result = false;
	supported_encoder_data *data = user_data;

	if(data&&codec != RECORDER_AUDIO_CODEC_DISABLE)
	{
		data->codec_list = realloc(data->codec_list, sizeof(supported_encoder_data)*(data->len+1));
		data->codec_list[data->len] = codec;
		++(data->len);
		result = true;
	}
	return result;
}

recorder_audio_codec_e*
audio_recorder_get_supported_encoder(recorder_h recorder, int *list_length)
{
	supported_encoder_data data = {0};
	data.codec_list = NULL;
	data.len = 0;

	int res = recorder_foreach_supported_audio_encoder(recorder,_recorder_supported_audio_encoder_cb,&data);

	if(res && list_length){
		*list_length = data.len;
	}

	return data.codec_list;
}

const char*
get_file_format_by_codec(app_data* ad)
{
	switch(ad->codec)
	{
	case RECORDER_AUDIO_CODEC_AMR:
		ad->file_formamt = RECORDER_FILE_FORMAT_AMR;
		return "AMR";
		break;
	case RECORDER_AUDIO_CODEC_AAC:
		ad->file_formamt = RECORDER_FILE_FORMAT_MP4;
		return "MP4";
		break;
	case RECORDER_AUDIO_CODEC_VORBIS:
		ad->file_formamt = RECORDER_FILE_FORMAT_OGG;
		return "OGG";
		break;
	}

	ad->file_formamt = RECORDER_FILE_FORMAT_WAV;
	return "WAV";
}

static void
_codec_set(app_data *ad){
	char file_name[NAME_MAX] = {'\0'};
	const char *file_ext = get_file_format_by_codec(ad);

	char *data_path = app_get_data_path();
	snprintf(file_name,NAME_MAX,"record.%s",file_ext);
	snprintf(ad->file_path, PATH_MAX, "%s%s", data_path, file_name);
	free(data_path);
}

//Apply settings to recorder
static void _recorder_apply_settings(app_data * ad)
{
	if(ad->recorder)
	{
		// Set record file name
		recorder_set_filename(ad->recorder, ad ->file_path);
		// Set record file format
		recorder_set_file_format(ad->recorder, ad->file_formamt);
		// Set record codec
		recorder_set_audio_encoder(ad->recorder, ad->codec);
	}
}

//Start recording
void record_start()
{

	dlog_print(DLOG_INFO,"USR_TAG","record_start");

	if(ad->recorder)
	{

		//Apply settings to recorder
		recorder_attr_set_time_limit(ad->recorder,ad->time_limit); //time limit is 3's when a loud sound is detected
																   //when detecting a loud sound, this time limit is 0 (0 means no time limit)
		_recorder_apply_settings(ad);
		recorder_prepare(ad->recorder);
		recorder_start(ad->recorder);

		//when recording 3 seconds for a loud sound, this part not executes.
		//This part execute to detect a loud sound.
		if(ad->db_flag == false)
		{
			count = 0;
			ad->max_db = -300; //init max_db
			ad->timer = ecore_timer_add(0.1,ecore_timer_cb,NULL);
		}
	}
}

void
nf_hw_back_cb(void* param, Evas_Object * evas_obj, void* event_info)
{
	//TODO : user define code
	evas_obj = uib_views_get_instance()->get_window_obj()->app_naviframe;
	elm_naviframe_item_pop(evas_obj);
}

void
win_del_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

Eina_Bool
nf_root_it_pop_cb(void* elm_win, Elm_Object_Item *it)
{
	elm_win_lower(elm_win);
	return EINA_FALSE;
}

app_data *uib_app_create()
{
	return calloc(1, sizeof(app_data));
}

void uib_app_destroy(app_data *user_data)
{
	uib_app_manager_get_instance()->free_all_view_context();
	free(user_data);
}

int uib_app_run(app_data *user_data, int argc, char **argv)
{
	ui_app_lifecycle_callback_s cbs =
	{
		.create = _on_create_cb,
		.terminate = _on_terminate_cb,
		.pause = _on_pause_cb,
		.resume = _on_resume_cb,
		.app_control = _on_app_control_cb,
	};

	app_event_handler_h handlers[5] =
	{NULL, };

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, _on_low_battery_cb, user_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, _on_low_memory_cb, user_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, _on_device_orientation_cb, user_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, _on_language_changed_cb, user_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, _on_region_format_changed_cb, user_data);

	return ui_app_main(argc, argv, &cbs, user_data);
}

void
app_get_resource(const char *res_file_in, char *res_path_out, int res_path_max)
{
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(res_path_out, res_path_max, "%s%s", res_path, res_file_in);
		free(res_path);
	}
}


static bool _on_create_cb(void *user_data)
{
	/*
	 * This area will be auto-generated when you add or delete user_view
	 * Please do not hand edit this area. The code may be lost.
	 */
	ad = user_data;

	app_manager = uib_app_manager_get_instance();

	app_manager->initialize();

	_recorder_create(ad);
	ad->codec_list = audio_recorder_get_supported_encoder(ad->recorder, &ad->codec_list_len);
	ad->codec = ad->codec_list_len ? ad->codec_list[0] : RECORDER_AUDIO_CODEC_PCM;
	_codec_set(user_data);
	/*
	 * End of area
	 */
	return true;
}

static void _on_terminate_cb(void *user_data)
{
	uib_views_get_instance()->destroy_window_obj();
	ui_app_exit();
}

static void _on_resume_cb(void *user_data)
{
	/* Take necessary actions when application becomes visible. */
}

static void _on_pause_cb(void *user_data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void _on_app_control_cb(app_control_h app_control, void *user_data)
{
	/* Handle the launch request. */
}

static void _on_low_memory_cb(app_event_info_h event_info, void *user_data)
{
	/* Take necessary actions when the system runs low on memory. */
}

static void _on_low_battery_cb(app_event_info_h event_info, void *user_data)
{
	/* Take necessary actions when the battery is low. */
}

static void _on_device_orientation_cb(app_event_info_h event_info, void *user_data)
{
	/* deprecated APIs */
}

static void _on_language_changed_cb(app_event_info_h event_info, void *user_data)
{
	/* Take necessary actions is called when language setting changes. */
	uib_views_get_instance()->uib_views_current_view_redraw();
}

static void _on_region_format_changed_cb(app_event_info_h event_info, void *user_data)
{
	/* Take necessary actions when region format setting changes. */
}

