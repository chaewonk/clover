
/*******************************************************************************
* This file was generated by UI Builder.
* This file will be auto-generated each and everytime you save your project.
* Do not hand edit this file.
********************************************************************************/

#ifndef UIB_VIEWS_H_
#define UIB_VIEWS_H_

#include "g_inc_uib.h"

#define	KEY_VIEW_CONTEXT	"uib,view,context"
#define	KEY_VIEW_CREATE		"uib,view,create"
#define	KEY_VIEW_DESTROY	"uib,view,destroy"
#define	KEY_VIEW_VC_SAVE	"uib,view,vc_save"
#define	KEY_WM_ROTATION_CHANGED	"wm,rotation,changed"

#define	VIEWS_CONFIG_NAME_NONE	"none"

typedef struct {
	Evas_Object * win;
	Evas_Object * bg;
	Evas_Object * conformant;	// This object can be box type in tv profile
	Evas_Object * app_naviframe;
	Eext_Circle_Surface * circle_surface;
} window_obj;

typedef struct _uib_view_context {
	Evas_Object* 	parent;
	Evas_Object* 	root_container;
	const char*  	view_name;
	int             indicator_state;
	bool            is_user_view;
} uib_view_context;

typedef struct _uib_user_views_st {
	const char*  	view_name;
	void (*draw_user_view_cb)(window_obj* win_obj, uib_view_context* vc);
} uib_user_views_st;

typedef uib_view_context uib_popup_context;

typedef struct {
	bool is_init;

	void (*uib_view_target_config_portrait)();
	void (*uib_view_target_config_landscape)();

	void (*set_startup_view_name)(const char* startup_view_name);
	uib_view_context* (*create_startup_view)();
	uib_view_context* (*create_user_view)(char*);

	void (*set_targeted_view)(uib_view_context* vc);
	int (*add_user_views) (char* user_view_name, void (*draw_user_view_cb)(window_obj* win_obj, uib_view_context* vc));
	int (*get_total_hit_num)(uib_view_context* vc);
	int (*find_user_view_idx)(char* view_name);

	void (*uib_views_orientation_handler)(int);
	void (*uib_views_current_view_redraw) ();
	char* (*get_current_config_name) ();
	window_obj* (*create_window_obj)();
	window_obj* (*get_window_obj)();
	Evas_Object* (*get_window)();
	Evas_Object* (*get_conformant)();
	void (*destroy_window_obj)();
} uib_views_st;

/**
 * Set the member using strdup() or malloc() because it will be deleted by free().
 */
 typedef struct _uib_genlist_item
{
	char * label;
	char * sub_label;
	char * icon_path;
	char * icon_standard;
	char * end_icon_path;
	char * end_icon_standard;
} uib_genlist_item;

/**
* @brief Call a callback on view creation
* @param[in] vc view context
* @param[in] obj The root container widget of this view
* @param[in] event_info pointer to an event specific struct or information to pass to the callback functions registered on this event
*/
void uib_views_create_callback(void* vc, Evas* e, Evas_Object* obj, void* event_info) ;

/**
* @brief Call a callback on view termination
* @param[in] vc view context
* @param[in] obj The root container widget of this view
* @param[in] event_info pointer to an event specific struct or information to pass to the callback functions registered on this event
*/
void uib_views_destroy_callback(void* vc, Evas* e, Evas_Object* obj, void* event_info) ;


/**
* @brief Ctxpopup will be dismissed and deleted when the back key event occurs
* @param[in] data user data
* @param[in] obj target object
* @param[in] event_info event information
*/
void uib_ctxpopup_back_callback(void *data, Evas_Object *obj, void *event_info) ;

void win_destroy(window_obj *win_obj);

Evas_Object* get_window();
Evas_Object* get_conformant();

uib_views_st* uib_views_get_instance();

/**
 * @brief Create Item for genlist
 * @param[in]   genlist            item container
 * @param[in]   style              item style
 * @param[in]   label              item label
 * @param[in]   sub_label          item sub label
 * @param[in]   icon_path          resource path such as location of the image
 * @param[in]   icon_standard      standard icon name
 * @param[in]   end_icon_path      resource path such as location of the image
 * @param[in]   end_icon_standard  standard icon name
 * @param[in]   parent             parent item used in tree item type
 * @param[in]   type               item type: tree, group, none
 * @param[in]   func               callback function to be called when item is selected
 * @param[in]   data               data to be transferred to the callback function
 * @returns created item
 */
Elm_Object_Item* create_genlist_item(Evas_Object* genlist, const char* style, const char* label, const char* sub_label, const char* icon_path, const char* icon_standard, const char* end_icon_path, const char* end_icon_standard, Elm_Object_Item* parent, Elm_Genlist_Item_Type type, Evas_Smart_Cb func, void* data);




#endif /* UIB_VIEWS_H_ */


