/*******************************************************************************
* This file was generated by UI Builder.
* User should hand edit this file.
********************************************************************************/

#include "app_main.h"
#include "uib_views.h"
#include "uib_views_inc.h"

typedef struct _uib_view2_control_context {
 /* add your variables here */

} uib_view2_control_context;


void view2_button2_onclicked(uib_view2_view_context *vc, Evas_Object *obj, void *event_info) {
	//Invoked at the start of wrapper function view2_connection_view2_button2_onclicked
	program_stop();
}

void view2_button2_onclicked_post(void* param, uib_view2_view_context *vc, Evas_Object *obj, void *event_info) {
	//Invoked post wrapper function view2_connection_view2_button2_onclicked
		char *resource_path = NULL;
		uib_util_rm_get_resource_path(-1, "detecting.png", &resource_path);
		elm_image_file_set(vc->image2, resource_path, NULL);
}
