using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.LmiUi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']"
	[global::Android.Runtime.Register ("com/vidyo/LmiUi/LmiWindow", DoNotGenerateAcw=true)]
	public partial class LmiWindow : global::Android.Views.TextureView, global::Android.Views.TextureView.ISurfaceTextureListener, global::Android.Views.View.IOnKeyListener, global::Android.Views.View.IOnLayoutChangeListener, global::Android.Views.View.IOnTouchListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/LmiUi/LmiWindow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LmiWindow); }
		}

		protected LmiWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/constructor[@name='LmiWindow' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Landroid/content/Context;J)V", "")]
		public unsafe LmiWindow (global::Android.Content.Context p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (LmiWindow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;J)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_J == IntPtr.Zero)
					id_ctor_Landroid_content_Context_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_J, __args);
			} finally {
			}
		}

		static IntPtr id_addViewOnUiThread_Landroid_app_Activity_Landroid_view_ViewGroup_Landroid_view_View_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='addViewOnUiThread' and count(parameter)=7 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.ViewGroup'] and parameter[3][@type='android.view.View'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("addViewOnUiThread", "(Landroid/app/Activity;Landroid/view/ViewGroup;Landroid/view/View;IIII)V", "")]
		public static unsafe void AddViewOnUiThread (global::Android.App.Activity p0, global::Android.Views.ViewGroup p1, global::Android.Views.View p2, int p3, int p4, int p5, int p6)
		{
			if (id_addViewOnUiThread_Landroid_app_Activity_Landroid_view_ViewGroup_Landroid_view_View_IIII == IntPtr.Zero)
				id_addViewOnUiThread_Landroid_app_Activity_Landroid_view_ViewGroup_Landroid_view_View_IIII = JNIEnv.GetStaticMethodID (class_ref, "addViewOnUiThread", "(Landroid/app/Activity;Landroid/view/ViewGroup;Landroid/view/View;IIII)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addViewOnUiThread_Landroid_app_Activity_Landroid_view_ViewGroup_Landroid_view_View_IIII, __args);
			} finally {
			}
		}

		static Delegate cb_notifyLayoutChanged_IIII;
#pragma warning disable 0169
		static Delegate GetNotifyLayoutChanged_IIIIHandler ()
		{
			if (cb_notifyLayoutChanged_IIII == null)
				cb_notifyLayoutChanged_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_NotifyLayoutChanged_IIII);
			return cb_notifyLayoutChanged_IIII;
		}

		static void n_NotifyLayoutChanged_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyLayoutChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_notifyLayoutChanged_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='notifyLayoutChanged' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("notifyLayoutChanged", "(IIII)V", "GetNotifyLayoutChanged_IIIIHandler")]
		public virtual unsafe void NotifyLayoutChanged (int p0, int p1, int p2, int p3)
		{
			if (id_notifyLayoutChanged_IIII == IntPtr.Zero)
				id_notifyLayoutChanged_IIII = JNIEnv.GetMethodID (class_ref, "notifyLayoutChanged", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyLayoutChanged_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyLayoutChanged", "(IIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifySurfaceTextureAvailable_II;
#pragma warning disable 0169
		static Delegate GetNotifySurfaceTextureAvailable_IIHandler ()
		{
			if (cb_notifySurfaceTextureAvailable_II == null)
				cb_notifySurfaceTextureAvailable_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_NotifySurfaceTextureAvailable_II);
			return cb_notifySurfaceTextureAvailable_II;
		}

		static void n_NotifySurfaceTextureAvailable_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifySurfaceTextureAvailable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifySurfaceTextureAvailable_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='notifySurfaceTextureAvailable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("notifySurfaceTextureAvailable", "(II)V", "GetNotifySurfaceTextureAvailable_IIHandler")]
		public virtual unsafe void NotifySurfaceTextureAvailable (int p0, int p1)
		{
			if (id_notifySurfaceTextureAvailable_II == IntPtr.Zero)
				id_notifySurfaceTextureAvailable_II = JNIEnv.GetMethodID (class_ref, "notifySurfaceTextureAvailable", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifySurfaceTextureAvailable_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifySurfaceTextureAvailable", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifySurfaceTextureDestroyed;
#pragma warning disable 0169
		static Delegate GetNotifySurfaceTextureDestroyedHandler ()
		{
			if (cb_notifySurfaceTextureDestroyed == null)
				cb_notifySurfaceTextureDestroyed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifySurfaceTextureDestroyed);
			return cb_notifySurfaceTextureDestroyed;
		}

		static void n_NotifySurfaceTextureDestroyed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifySurfaceTextureDestroyed ();
		}
#pragma warning restore 0169

		static IntPtr id_notifySurfaceTextureDestroyed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='notifySurfaceTextureDestroyed' and count(parameter)=0]"
		[Register ("notifySurfaceTextureDestroyed", "()V", "GetNotifySurfaceTextureDestroyedHandler")]
		public virtual unsafe void NotifySurfaceTextureDestroyed ()
		{
			if (id_notifySurfaceTextureDestroyed == IntPtr.Zero)
				id_notifySurfaceTextureDestroyed = JNIEnv.GetMethodID (class_ref, "notifySurfaceTextureDestroyed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifySurfaceTextureDestroyed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifySurfaceTextureDestroyed", "()V"));
			} finally {
			}
		}

		static Delegate cb_notifySurfaceTextureSizeChanged_II;
#pragma warning disable 0169
		static Delegate GetNotifySurfaceTextureSizeChanged_IIHandler ()
		{
			if (cb_notifySurfaceTextureSizeChanged_II == null)
				cb_notifySurfaceTextureSizeChanged_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_NotifySurfaceTextureSizeChanged_II);
			return cb_notifySurfaceTextureSizeChanged_II;
		}

		static void n_NotifySurfaceTextureSizeChanged_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifySurfaceTextureSizeChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifySurfaceTextureSizeChanged_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='notifySurfaceTextureSizeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("notifySurfaceTextureSizeChanged", "(II)V", "GetNotifySurfaceTextureSizeChanged_IIHandler")]
		public virtual unsafe void NotifySurfaceTextureSizeChanged (int p0, int p1)
		{
			if (id_notifySurfaceTextureSizeChanged_II == IntPtr.Zero)
				id_notifySurfaceTextureSizeChanged_II = JNIEnv.GetMethodID (class_ref, "notifySurfaceTextureSizeChanged", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifySurfaceTextureSizeChanged_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifySurfaceTextureSizeChanged", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyTouchEvent_IIII;
#pragma warning disable 0169
		static Delegate GetNotifyTouchEvent_IIIIHandler ()
		{
			if (cb_notifyTouchEvent_IIII == null)
				cb_notifyTouchEvent_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_NotifyTouchEvent_IIII);
			return cb_notifyTouchEvent_IIII;
		}

		static void n_NotifyTouchEvent_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyTouchEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_notifyTouchEvent_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='notifyTouchEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("notifyTouchEvent", "(IIII)V", "GetNotifyTouchEvent_IIIIHandler")]
		public virtual unsafe void NotifyTouchEvent (int p0, int p1, int p2, int p3)
		{
			if (id_notifyTouchEvent_IIII == IntPtr.Zero)
				id_notifyTouchEvent_IIII = JNIEnv.GetMethodID (class_ref, "notifyTouchEvent", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyTouchEvent_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyTouchEvent", "(IIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onKey_Landroid_view_View_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKey_Landroid_view_View_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKey_Landroid_view_View_ILandroid_view_KeyEvent_ == null)
				cb_onKey_Landroid_view_View_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnKey_Landroid_view_View_ILandroid_view_KeyEvent_);
			return cb_onKey_Landroid_view_View_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKey_Landroid_view_View_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Keycode p1 = (global::Android.Views.Keycode) native_p1;
			global::Android.Views.KeyEvent p2 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKey (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKey_Landroid_view_View_ILandroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='onKey' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.view.KeyEvent']]"
		[Register ("onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z", "GetOnKey_Landroid_view_View_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnKey (global::Android.Views.View p0, [global::Android.Runtime.GeneratedEnum] global::Android.Views.Keycode p1, global::Android.Views.KeyEvent p2)
		{
			if (id_onKey_Landroid_view_View_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_onKey_Landroid_view_View_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onKey_Landroid_view_View_ILandroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onLayoutChange_Landroid_view_View_IIIIIIII;
#pragma warning disable 0169
		static Delegate GetOnLayoutChange_Landroid_view_View_IIIIIIIIHandler ()
		{
			if (cb_onLayoutChange_Landroid_view_View_IIIIIIII == null)
				cb_onLayoutChange_Landroid_view_View_IIIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int, int>) n_OnLayoutChange_Landroid_view_View_IIIIIIII);
			return cb_onLayoutChange_Landroid_view_View_IIIIIIII;
		}

		static void n_OnLayoutChange_Landroid_view_View_IIIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLayoutChange (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		static IntPtr id_onLayoutChange_Landroid_view_View_IIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='onLayoutChange' and count(parameter)=9 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("onLayoutChange", "(Landroid/view/View;IIIIIIII)V", "GetOnLayoutChange_Landroid_view_View_IIIIIIIIHandler")]
		public virtual unsafe void OnLayoutChange (global::Android.Views.View p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8)
		{
			if (id_onLayoutChange_Landroid_view_View_IIIIIIII == IntPtr.Zero)
				id_onLayoutChange_Landroid_view_View_IIIIIIII = JNIEnv.GetMethodID (class_ref, "onLayoutChange", "(Landroid/view/View;IIIIIIII)V");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLayoutChange_Landroid_view_View_IIIIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayoutChange", "(Landroid/view/View;IIIIIIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II == null)
				cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II);
			return cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureAvailable (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='onSurfaceTextureAvailable' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnSurfaceTextureAvailable (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			if (id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II == IntPtr.Zero)
				id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ == null)
				cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_);
			return cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
		}

		static bool n_OnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSurfaceTextureDestroyed (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='onSurfaceTextureDestroyed' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z", "GetOnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe bool OnSurfaceTextureDestroyed (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II == null)
				cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II);
			return cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureSizeChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='onSurfaceTextureSizeChanged' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnSurfaceTextureSizeChanged (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			if (id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II == IntPtr.Zero)
				id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ == null)
				cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_);
			return cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureUpdated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='onSurfaceTextureUpdated' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V", "GetOnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void OnSurfaceTextureUpdated (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
		{
			if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_removeViewOnUiThread_Landroid_app_Activity_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='removeViewOnUiThread' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.View']]"
		[Register ("removeViewOnUiThread", "(Landroid/app/Activity;Landroid/view/View;)V", "")]
		public static unsafe void RemoveViewOnUiThread (global::Android.App.Activity p0, global::Android.Views.View p1)
		{
			if (id_removeViewOnUiThread_Landroid_app_Activity_Landroid_view_View_ == IntPtr.Zero)
				id_removeViewOnUiThread_Landroid_app_Activity_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "removeViewOnUiThread", "(Landroid/app/Activity;Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeViewOnUiThread_Landroid_app_Activity_Landroid_view_View_, __args);
			} finally {
			}
		}

		static IntPtr id_setContentViewOnUiThread_Landroid_app_Activity_Landroid_view_View_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='setContentViewOnUiThread' and count(parameter)=6 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("setContentViewOnUiThread", "(Landroid/app/Activity;Landroid/view/View;IIII)V", "")]
		public static unsafe void SetContentViewOnUiThread (global::Android.App.Activity p0, global::Android.Views.View p1, int p2, int p3, int p4, int p5)
		{
			if (id_setContentViewOnUiThread_Landroid_app_Activity_Landroid_view_View_IIII == IntPtr.Zero)
				id_setContentViewOnUiThread_Landroid_app_Activity_Landroid_view_View_IIII = JNIEnv.GetStaticMethodID (class_ref, "setContentViewOnUiThread", "(Landroid/app/Activity;Landroid/view/View;IIII)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setContentViewOnUiThread_Landroid_app_Activity_Landroid_view_View_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_setPositionOnUiThread_Landroid_app_Activity_Landroid_view_View_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='setPositionOnUiThread' and count(parameter)=6 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("setPositionOnUiThread", "(Landroid/app/Activity;Landroid/view/View;IIII)V", "")]
		public static unsafe void SetPositionOnUiThread (global::Android.App.Activity p0, global::Android.Views.View p1, int p2, int p3, int p4, int p5)
		{
			if (id_setPositionOnUiThread_Landroid_app_Activity_Landroid_view_View_IIII == IntPtr.Zero)
				id_setPositionOnUiThread_Landroid_app_Activity_Landroid_view_View_IIII = JNIEnv.GetStaticMethodID (class_ref, "setPositionOnUiThread", "(Landroid/app/Activity;Landroid/view/View;IIII)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPositionOnUiThread_Landroid_app_Activity_Landroid_view_View_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_setVisibilityOnUiThread_Landroid_app_Activity_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='setVisibilityOnUiThread' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
		[Register ("setVisibilityOnUiThread", "(Landroid/app/Activity;Landroid/view/View;I)V", "")]
		public static unsafe void SetVisibilityOnUiThread (global::Android.App.Activity p0, global::Android.Views.View p1, int p2)
		{
			if (id_setVisibilityOnUiThread_Landroid_app_Activity_Landroid_view_View_I == IntPtr.Zero)
				id_setVisibilityOnUiThread_Landroid_app_Activity_Landroid_view_View_I = JNIEnv.GetStaticMethodID (class_ref, "setVisibilityOnUiThread", "(Landroid/app/Activity;Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setVisibilityOnUiThread_Landroid_app_Activity_Landroid_view_View_I, __args);
			} finally {
			}
		}

		static Delegate cb_stopCallbacks;
#pragma warning disable 0169
		static Delegate GetStopCallbacksHandler ()
		{
			if (cb_stopCallbacks == null)
				cb_stopCallbacks = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopCallbacks);
			return cb_stopCallbacks;
		}

		static void n_StopCallbacks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiUi.LmiWindow __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiUi.LmiWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopCallbacks ();
		}
#pragma warning restore 0169

		static IntPtr id_stopCallbacks;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiUi']/class[@name='LmiWindow']/method[@name='stopCallbacks' and count(parameter)=0]"
		[Register ("stopCallbacks", "()V", "GetStopCallbacksHandler")]
		public virtual unsafe void StopCallbacks ()
		{
			if (id_stopCallbacks == IntPtr.Zero)
				id_stopCallbacks = JNIEnv.GetMethodID (class_ref, "stopCallbacks", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopCallbacks);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopCallbacks", "()V"));
			} finally {
			}
		}

	}
}
