
/*******************************************************************************
* This file was generated by UI Builder.
* This file will be auto-generated each and everytime you save your project.
* Do not hand edit this file.
********************************************************************************/
		#include "g_inc_uib.h"
#include "uib_views.h"
#include "uib_views_inc.h"
#include "uib_app_manager.h"

/* event handler declarations */
void connection_view2_button2_onclicked(uib_view2_view_context*, Evas_Object*, void*);

uib_view_context* uib_view_view2_create(Evas_Object* parent, void* create_callback_param) {
	uib_view2_view_context* vc = calloc(1, sizeof(uib_view2_view_context));
	vc->parent = parent;
	vc->view_name = "view2";
	vc->indicator_state = ELM_WIN_INDICATOR_SHOW;
	vc->is_user_view = false;
	uib_app_manager_get_instance()->add_view_context((uib_view_context*)vc);
	if (!vc->grid2) {
		vc->grid2= elm_grid_add(parent);
		vc->root_container = vc->grid2;
	}
	uib_views_get_instance()->set_targeted_view((uib_view_context*)vc);

	//bind event handler
	evas_object_smart_callback_add(vc->button2, "clicked", (Evas_Smart_Cb)connection_view2_button2_onclicked, vc);


	evas_object_data_set(vc->root_container, KEY_VIEW_CONTEXT, vc);
	uib_views_create_callback(vc, evas_object_evas_get(vc->root_container), vc->root_container, create_callback_param);
	evas_object_event_callback_add(vc->root_container, EVAS_CALLBACK_DEL, (Evas_Object_Event_Cb)uib_views_destroy_callback, vc);

	return (uib_view_context*)vc;
}
void uib_view2_config_CIRCLE_360x360_portrait() {
	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view2_view_context* vc = (uib_view2_view_context*)uib_app_manager->find_view_context("view2");
	if(!vc) {
		return;
	}
	if(vc->grid2) {
		elm_grid_clear(vc->grid2, EINA_FALSE);
		evas_object_size_hint_align_set(vc->grid2, -1.0, -1.0);		evas_object_size_hint_weight_set(vc->grid2, 1.0, 1.0);		elm_grid_size_set(vc->grid2, 1000, 1000);
		if (!vc->bg2) {
			vc->bg2 = elm_bg_add(vc->grid2);
		}
		if(vc->bg2) {
			evas_object_size_hint_align_set(vc->bg2, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->bg2, 1.0, 1.0);			elm_bg_option_set(vc->bg2, (Elm_Bg_Option)ELM_BG_OPTION_SCALE);
			int hexValue = strtol("#ffffff"+1, NULL, 16);
			int r = (hexValue&0xFF0000)>>16;
			int g = (hexValue&0xFF00)>>8;
			int b = (hexValue&0xFF);
			elm_bg_color_set(vc->bg2, r, g, b);
			evas_object_show(vc->bg2);
		}
		if (!vc->button2) {
			vc->button2 = elm_button_add(vc->grid2);
		}
		if (vc->button2) {
			evas_object_size_hint_align_set(vc->button2, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->button2, 1.0, 1.0);			elm_object_text_set(vc->button2,_UIB_LOCALE("STOP"));
			elm_object_style_set(vc->button2,"bottom");
			evas_object_show(vc->button2);
		}
		if (!vc->image2) {
			vc->image2 = elm_image_add(vc->grid2);
		}
		if(vc->image2) {
			char *resource_path = NULL;
			uib_util_rm_get_resource_path(-1, "detecting.png", &resource_path);
			elm_image_file_set(vc->image2, resource_path, NULL);
			if(resource_path) {
				free(resource_path);
			}
			elm_image_smooth_set(vc->image2, EINA_TRUE);
			elm_image_no_scale_set(vc->image2, EINA_FALSE);
			elm_image_resizable_set(vc->image2, EINA_TRUE, EINA_TRUE);
			elm_image_aspect_fixed_set(vc->image2, EINA_TRUE);
			elm_image_fill_outside_set(vc->image2, EINA_FALSE);
			elm_image_editable_set(vc->image2, EINA_FALSE);
			evas_object_size_hint_align_set(vc->image2, -1.0, -1.0);
			evas_object_size_hint_weight_set(vc->image2, 1.0, 1.0);
			evas_object_show(vc->image2);
		}
		elm_grid_pack(vc->grid2, vc->bg2, 0, 0, 1005, 1003);		elm_grid_pack(vc->grid2, vc->button2, 371, 700, 270, 361);		elm_grid_pack(vc->grid2, vc->image2, 201, 134, 604, 569);		evas_object_show(vc->grid2);
	}
}

