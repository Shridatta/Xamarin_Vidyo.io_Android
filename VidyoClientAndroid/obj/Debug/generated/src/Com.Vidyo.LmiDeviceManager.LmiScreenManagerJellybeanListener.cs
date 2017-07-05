using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.LmiDeviceManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener']"
	[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiScreenManagerJellybeanListener", DoNotGenerateAcw=true)]
	public partial class LmiScreenManagerJellybeanListener : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']"
		[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiScreenManagerJellybeanListener$LmiJellyBeanMR1Listener", DoNotGenerateAcw=true)]
		public partial class LmiJellyBeanMR1Listener : global::Java.Lang.Object, global::Android.Hardware.Display.DisplayManager.IDisplayListener, global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiScreenManagerJellybeanListener$LmiJellyBeanMR1Listener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LmiJellyBeanMR1Listener); }
			}

			protected LmiJellyBeanMR1Listener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Ljava_nio_ByteBuffer_Lcom_vidyo_LmiDeviceManager_LmiScreenManager_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']/constructor[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='com.vidyo.LmiDeviceManager.LmiScreenManager']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/nio/ByteBuffer;Lcom/vidyo/LmiDeviceManager/LmiScreenManager;)V", "")]
			public unsafe LmiJellyBeanMR1Listener (global::Android.Content.Context p0, global::Java.Nio.ByteBuffer p1, global::Com.Vidyo.LmiDeviceManager.LmiScreenManager p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (((object) this).GetType () != typeof (LmiJellyBeanMR1Listener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/nio/ByteBuffer;Lcom/vidyo/LmiDeviceManager/LmiScreenManager;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/nio/ByteBuffer;Lcom/vidyo/LmiDeviceManager/LmiScreenManager;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_Ljava_nio_ByteBuffer_Lcom_vidyo_LmiDeviceManager_LmiScreenManager_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_Ljava_nio_ByteBuffer_Lcom_vidyo_LmiDeviceManager_LmiScreenManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/nio/ByteBuffer;Lcom/vidyo/LmiDeviceManager/LmiScreenManager;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_nio_ByteBuffer_Lcom_vidyo_LmiDeviceManager_LmiScreenManager_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_nio_ByteBuffer_Lcom_vidyo_LmiDeviceManager_LmiScreenManager_, __args);
				} finally {
				}
			}

			static Delegate cb_getDisplays;
#pragma warning disable 0169
			static Delegate GetGetDisplaysHandler ()
			{
				if (cb_getDisplays == null)
					cb_getDisplays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplays);
				return cb_getDisplays;
			}

			static IntPtr n_GetDisplays (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetDisplays ());
			}
#pragma warning restore 0169

			static IntPtr id_getDisplays;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']/method[@name='getDisplays' and count(parameter)=0]"
			[Register ("getDisplays", "()[Landroid/view/Display;", "GetGetDisplaysHandler")]
			public virtual unsafe global::Android.Views.Display[] GetDisplays ()
			{
				if (id_getDisplays == IntPtr.Zero)
					id_getDisplays = JNIEnv.GetMethodID (class_ref, "getDisplays", "()[Landroid/view/Display;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (global::Android.Views.Display[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplays), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Views.Display));
					else
						return (global::Android.Views.Display[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplays", "()[Landroid/view/Display;")), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Views.Display));
				} finally {
				}
			}

			static Delegate cb_getName_I;
#pragma warning disable 0169
			static Delegate GetGetName_IHandler ()
			{
				if (cb_getName_I == null)
					cb_getName_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetName_I);
				return cb_getName_I;
			}

			static IntPtr n_GetName_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.GetName (p0));
			}
#pragma warning restore 0169

			static IntPtr id_getName_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getName", "(I)Ljava/lang/String;", "GetGetName_IHandler")]
			public virtual unsafe string GetName (int p0)
			{
				if (id_getName_I == IntPtr.Zero)
					id_getName_I = JNIEnv.GetMethodID (class_ref, "getName", "(I)Ljava/lang/String;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_getRealHeight_I;
#pragma warning disable 0169
			static Delegate GetGetRealHeight_IHandler ()
			{
				if (cb_getRealHeight_I == null)
					cb_getRealHeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetRealHeight_I);
				return cb_getRealHeight_I;
			}

			static int n_GetRealHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetRealHeight (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getRealHeight_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']/method[@name='getRealHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRealHeight", "(I)I", "GetGetRealHeight_IHandler")]
			public virtual unsafe int GetRealHeight (int p0)
			{
				if (id_getRealHeight_I == IntPtr.Zero)
					id_getRealHeight_I = JNIEnv.GetMethodID (class_ref, "getRealHeight", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRealHeight_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRealHeight", "(I)I"), __args);
				} finally {
				}
			}

			static Delegate cb_getRealWidth_I;
#pragma warning disable 0169
			static Delegate GetGetRealWidth_IHandler ()
			{
				if (cb_getRealWidth_I == null)
					cb_getRealWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetRealWidth_I);
				return cb_getRealWidth_I;
			}

			static int n_GetRealWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetRealWidth (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getRealWidth_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']/method[@name='getRealWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRealWidth", "(I)I", "GetGetRealWidth_IHandler")]
			public virtual unsafe int GetRealWidth (int p0)
			{
				if (id_getRealWidth_I == IntPtr.Zero)
					id_getRealWidth_I = JNIEnv.GetMethodID (class_ref, "getRealWidth", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRealWidth_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRealWidth", "(I)I"), __args);
				} finally {
				}
			}

			static Delegate cb_onDisplayAdded_I;
#pragma warning disable 0169
			static Delegate GetOnDisplayAdded_IHandler ()
			{
				if (cb_onDisplayAdded_I == null)
					cb_onDisplayAdded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDisplayAdded_I);
				return cb_onDisplayAdded_I;
			}

			static void n_OnDisplayAdded_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDisplayAdded (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onDisplayAdded_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']/method[@name='onDisplayAdded' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onDisplayAdded", "(I)V", "GetOnDisplayAdded_IHandler")]
			public virtual unsafe void OnDisplayAdded (int p0)
			{
				if (id_onDisplayAdded_I == IntPtr.Zero)
					id_onDisplayAdded_I = JNIEnv.GetMethodID (class_ref, "onDisplayAdded", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisplayAdded_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisplayAdded", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onDisplayChanged_I;
#pragma warning disable 0169
			static Delegate GetOnDisplayChanged_IHandler ()
			{
				if (cb_onDisplayChanged_I == null)
					cb_onDisplayChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDisplayChanged_I);
				return cb_onDisplayChanged_I;
			}

			static void n_OnDisplayChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDisplayChanged (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onDisplayChanged_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']/method[@name='onDisplayChanged' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onDisplayChanged", "(I)V", "GetOnDisplayChanged_IHandler")]
			public virtual unsafe void OnDisplayChanged (int p0)
			{
				if (id_onDisplayChanged_I == IntPtr.Zero)
					id_onDisplayChanged_I = JNIEnv.GetMethodID (class_ref, "onDisplayChanged", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisplayChanged_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisplayChanged", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onDisplayRemoved_I;
#pragma warning disable 0169
			static Delegate GetOnDisplayRemoved_IHandler ()
			{
				if (cb_onDisplayRemoved_I == null)
					cb_onDisplayRemoved_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDisplayRemoved_I);
				return cb_onDisplayRemoved_I;
			}

			static void n_OnDisplayRemoved_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDisplayRemoved (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onDisplayRemoved_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']/method[@name='onDisplayRemoved' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onDisplayRemoved", "(I)V", "GetOnDisplayRemoved_IHandler")]
			public virtual unsafe void OnDisplayRemoved (int p0)
			{
				if (id_onDisplayRemoved_I == IntPtr.Zero)
					id_onDisplayRemoved_I = JNIEnv.GetMethodID (class_ref, "onDisplayRemoved", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisplayRemoved_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisplayRemoved", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_start;
#pragma warning disable 0169
			static Delegate GetStartHandler ()
			{
				if (cb_start == null)
					cb_start = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Start);
				return cb_start;
			}

			static bool n_Start (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Start ();
			}
#pragma warning restore 0169

			static IntPtr id_start;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']/method[@name='start' and count(parameter)=0]"
			[Register ("start", "()Z", "GetStartHandler")]
			public virtual unsafe bool Start ()
			{
				if (id_start == IntPtr.Zero)
					id_start = JNIEnv.GetMethodID (class_ref, "start", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_start);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()Z"));
				} finally {
				}
			}

			static Delegate cb_stop;
#pragma warning disable 0169
			static Delegate GetStopHandler ()
			{
				if (cb_stop == null)
					cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
				return cb_stop;
			}

			static void n_Stop (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Stop ();
			}
#pragma warning restore 0169

			static IntPtr id_stop;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener.LmiJellyBeanMR1Listener']/method[@name='stop' and count(parameter)=0]"
			[Register ("stop", "()V", "GetStopHandler")]
			public virtual unsafe void Stop ()
			{
				if (id_stop == IntPtr.Zero)
					id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiScreenManagerJellybeanListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LmiScreenManagerJellybeanListener); }
		}

		protected LmiScreenManagerJellybeanListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener']/constructor[@name='LmiScreenManagerJellybeanListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LmiScreenManagerJellybeanListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LmiScreenManagerJellybeanListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_newInstance_Landroid_content_Context_Ljava_nio_ByteBuffer_Lcom_vidyo_LmiDeviceManager_LmiScreenManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManagerJellybeanListener']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='com.vidyo.LmiDeviceManager.LmiScreenManager']]"
		[Register ("newInstance", "(Landroid/content/Context;Ljava/nio/ByteBuffer;Lcom/vidyo/LmiDeviceManager/LmiScreenManager;)Lcom/vidyo/LmiDeviceManager/LmiScreenManager$LmiScreenManagerListener;", "")]
		public static unsafe global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener NewInstance (global::Android.Content.Context p0, global::Java.Nio.ByteBuffer p1, global::Com.Vidyo.LmiDeviceManager.LmiScreenManager p2)
		{
			if (id_newInstance_Landroid_content_Context_Ljava_nio_ByteBuffer_Lcom_vidyo_LmiDeviceManager_LmiScreenManager_ == IntPtr.Zero)
				id_newInstance_Landroid_content_Context_Ljava_nio_ByteBuffer_Lcom_vidyo_LmiDeviceManager_LmiScreenManager_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Landroid/content/Context;Ljava/nio/ByteBuffer;Lcom/vidyo/LmiDeviceManager/LmiScreenManager;)Lcom/vidyo/LmiDeviceManager/LmiScreenManager$LmiScreenManagerListener;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Landroid_content_Context_Ljava_nio_ByteBuffer_Lcom_vidyo_LmiDeviceManager_LmiScreenManager_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
