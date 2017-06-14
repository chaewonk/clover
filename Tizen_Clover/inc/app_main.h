#ifndef __APP_MAIN_H__
#define __APP_MAIN_H__

#define ENABLE_UIB_DELOG

#include "g_inc_uib.h"
#include "uib_views.h"
#include <recorder.h>
#include <device/haptic.h>

/**
 * @brief Forward declaration of model
 */
typedef struct {
	Ecore_Timer *timer;
	Ecore_Timer *timer2;
	double max_db;
	int db_flag;
	int time_limit;

	Evas_Object *btn_rec, *btn_recstop;

	haptic_device_h handle;
	haptic_effect_h effect_handle;
	int timer_count;

	recorder_h recorder;
	recorder_audio_codec_e *codec_list;
	int codec_list_len;
	char file_path[PATH_MAX];
	recorder_audio_codec_e codec;
	recorder_file_format_e file_formamt;
	FILE *fp;
} app_data;

/*
typedef struct {
	bool _is_init;
	bool (*initialize)();
	void (*prepare)();
	void (*finalize)();
	const uib_device_info_st* (*get_uib_device_info)();
	int (*add_view_context)(uib_view_context*);
	uib_view_context* (*find_view_context)(char*);
	void (*free_all_view_context)();
} uib_app_manager_st;

uib_app_manager_st* uib_app_manager_get_instance();*/

static bool _recorder_is_recording(app_data *ad);
static void send_audio(app_data *data);
void record_start();
void record_stop();
void program_stop();
/**< H/W Back Key Event */
/**
 * @brief Add (register) a callback function for H/W Back Key Event to a given evas object.
 * @param[in]   pv_param     The void pointer to be passed to this func.
 * @param[in]   p_evas_obj    evas object (naviframe)
 */
void
nf_hw_back_cb(void* param, Evas_Object * evas_obj, void* event_info);

void
win_del_request_cb(void *data, Evas_Object *obj, void *event_info);

Eina_Bool
nf_root_it_pop_cb(void* elm_win, Elm_Object_Item *it);

/**
 * @brief Create application instance
 * @return Application instance on success, otherwise NULL
 */
app_data *uib_app_create();

/**
 * @brief Destroy application instance
 * @param[in]   app     Application instance
 */
void uib_app_destroy(app_data *app);

/**
 * @brief Run Tizen application
 * @param[in]   app     Application instance
 * @param[in]   argc    argc paremeter received in main
 * @param[in]   argv    argv parameter received in main
 */
int uib_app_run(app_data *app, int argc, char **argv);

void app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max);

#endif /* __APP_MAIN_H__ */

