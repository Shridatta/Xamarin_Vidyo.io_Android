using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.LmiDeviceManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']"
	[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiScreenManager", DoNotGenerateAcw=true)]
	public partial class LmiScreenManager : global::Android.Views.OrientationEventListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiScreenManager.LmiScreenManagerListener']"
		[Register ("com/vidyo/LmiDeviceManager/LmiScreenManager$LmiScreenManagerListener", "", "Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker")]
		public partial interface ILmiScreenManagerListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiScreenManager.LmiScreenManagerListener']/method[@name='getDisplays' and count(parameter)=0]"
			[Register ("getDisplays", "()[Landroid/view/Display;", "GetGetDisplaysHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid")]
			global::Android.Views.Display[] GetDisplays ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiScreenManager.LmiScreenManagerListener']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getName", "(I)Ljava/lang/String;", "GetGetName_IHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid")]
			string GetName (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiScreenManager.LmiScreenManagerListener']/method[@name='getRealHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRealHeight", "(I)I", "GetGetRealHeight_IHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid")]
			int GetRealHeight (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiScreenManager.LmiScreenManagerListener']/method[@name='getRealWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRealWidth", "(I)I", "GetGetRealWidth_IHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid")]
			int GetRealWidth (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiScreenManager.LmiScreenManagerListener']/method[@name='start' and count(parameter)=0]"
			[Register ("start", "()Z", "GetStartHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid")]
			bool Start ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiScreenManager.LmiScreenManagerListener']/method[@name='stop' and count(parameter)=0]"
			[Register ("stop", "()V", "GetStopHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid")]
			void Stop ();

		}

		[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiScreenManager$LmiScreenManagerListener", DoNotGenerateAcw=true)]
		internal class ILmiScreenManagerListenerInvoker : global::Java.Lang.Object, ILmiScreenManagerListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiScreenManager$LmiScreenManagerListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ILmiScreenManagerListenerInvoker); }
			}

			IntPtr class_ref;

			public static ILmiScreenManagerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILmiScreenManagerListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.LmiDeviceManager.LmiScreenManager.LmiScreenManagerListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILmiScreenManagerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetDisplays ());
			}
#pragma warning restore 0169

			IntPtr id_getDisplays;
			public unsafe global::Android.Views.Display[] GetDisplays ()
			{
				if (id_getDisplays == IntPtr.Zero)
					id_getDisplays = JNIEnv.GetMethodID (class_ref, "getDisplays", "()[Landroid/view/Display;");
				return (global::Android.Views.Display[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplays), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Views.Display));
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
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.GetName (p0));
			}
#pragma warning restore 0169

			IntPtr id_getName_I;
			public unsafe string GetName (int p0)
			{
				if (id_getName_I == IntPtr.Zero)
					id_getName_I = JNIEnv.GetMethodID (class_ref, "getName", "(I)Ljava/lang/String;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName_I, __args), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetRealHeight (p0);
			}
#pragma warning restore 0169

			IntPtr id_getRealHeight_I;
			public unsafe int GetRealHeight (int p0)
			{
				if (id_getRealHeight_I == IntPtr.Zero)
					id_getRealHeight_I = JNIEnv.GetMethodID (class_ref, "getRealHeight", "(I)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRealHeight_I, __args);
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
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetRealWidth (p0);
			}
#pragma warning restore 0169

			IntPtr id_getRealWidth_I;
			public unsafe int GetRealWidth (int p0)
			{
				if (id_getRealWidth_I == IntPtr.Zero)
					id_getRealWidth_I = JNIEnv.GetMethodID (class_ref, "getRealWidth", "(I)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRealWidth_I, __args);
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
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Start ();
			}
#pragma warning restore 0169

			IntPtr id_start;
			public unsafe bool Start ()
			{
				if (id_start == IntPtr.Zero)
					id_start = JNIEnv.GetMethodID (class_ref, "start", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_start);
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
				global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager.ILmiScreenManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Stop ();
			}
#pragma warning restore 0169

			IntPtr id_stop;
			public unsafe void Stop ()
			{
				if (id_stop == IntPtr.Zero)
					id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
			}

		}

		public delegate global::Android.Views.Display[] LmiScreenManagerGetDisplaysHandler ();

		public delegate string LmiScreenManagerGetNameHandler (int p0);

		public delegate int LmiScreenManagerGetRealHeightHandler (int p0);

		public delegate int LmiScreenManagerGetRealWidthHandler (int p0);

		public partial class StartEventArgs : global::System.EventArgs {

			public StartEventArgs (bool handled)
			{
				this.handled = handled;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/LmiDeviceManager/LmiScreenManager_LmiScreenManagerListenerImplementor")]
		internal sealed partial class ILmiScreenManagerListenerImplementor : global::Java.Lang.Object, ILmiScreenManagerListener {

			object sender;

			public ILmiScreenManagerListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/LmiDeviceManager/LmiScreenManager_LmiScreenManagerListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public LmiScreenManagerGetDisplaysHandler GetDisplaysHandler;
#pragma warning restore 0649

			public Android.Views.Display[] GetDisplays ()
			{
				var __h = GetDisplaysHandler;
				return __h != null ? __h () : default (global::Android.Views.Display[]);
			}
#pragma warning disable 0649
			public LmiScreenManagerGetNameHandler GetNameHandler;
#pragma warning restore 0649

			public string GetName (int p0)
			{
				var __h = GetNameHandler;
				return __h != null ? __h (p0) : default (string);
			}
#pragma warning disable 0649
			public LmiScreenManagerGetRealHeightHandler GetRealHeightHandler;
#pragma warning restore 0649

			public int GetRealHeight (int p0)
			{
				var __h = GetRealHeightHandler;
				return __h != null ? __h (p0) : default (int);
			}
#pragma warning disable 0649
			public LmiScreenManagerGetRealWidthHandler GetRealWidthHandler;
#pragma warning restore 0649

			public int GetRealWidth (int p0)
			{
				var __h = GetRealWidthHandler;
				return __h != null ? __h (p0) : default (int);
			}
#pragma warning disable 0649
			public EventHandler<StartEventArgs> StartHandler;
#pragma warning restore 0649

			public bool Start ()
			{
				var __h = StartHandler;
				if (__h == null)
					return false;
				var __e = new StartEventArgs (true);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler StopHandler;
#pragma warning restore 0649

			public void Stop ()
			{
				var __h = StopHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (ILmiScreenManagerListenerImplementor value)
			{
				return value.GetDisplaysHandler == null && value.GetNameHandler == null && value.GetRealHeightHandler == null && value.GetRealWidthHandler == null && value.StartHandler == null && value.StopHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiScreenManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LmiScreenManager); }
		}

		protected LmiScreenManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/constructor[@name='LmiScreenManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/nio/ByteBuffer;)V", "")]
		public unsafe LmiScreenManager (global::Android.Content.Context p0, global::Java.Nio.ByteBuffer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (LmiScreenManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static Delegate cb_displayAdded_ILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetDisplayAdded_ILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_displayAdded_ILjava_nio_ByteBuffer_ == null)
				cb_displayAdded_ILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_DisplayAdded_ILjava_nio_ByteBuffer_);
			return cb_displayAdded_ILjava_nio_ByteBuffer_;
		}

		static void n_DisplayAdded_ILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DisplayAdded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_displayAdded_ILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='displayAdded' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("displayAdded", "(ILjava/nio/ByteBuffer;)V", "GetDisplayAdded_ILjava_nio_ByteBuffer_Handler")]
		public virtual unsafe void DisplayAdded (int p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_displayAdded_ILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_displayAdded_ILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "displayAdded", "(ILjava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_displayAdded_ILjava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayAdded", "(ILjava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_displayChanged_ILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetDisplayChanged_ILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_displayChanged_ILjava_nio_ByteBuffer_ == null)
				cb_displayChanged_ILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_DisplayChanged_ILjava_nio_ByteBuffer_);
			return cb_displayChanged_ILjava_nio_ByteBuffer_;
		}

		static void n_DisplayChanged_ILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DisplayChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_displayChanged_ILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='displayChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("displayChanged", "(ILjava/nio/ByteBuffer;)V", "GetDisplayChanged_ILjava_nio_ByteBuffer_Handler")]
		public virtual unsafe void DisplayChanged (int p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_displayChanged_ILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_displayChanged_ILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "displayChanged", "(ILjava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_displayChanged_ILjava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayChanged", "(ILjava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_displayRemoved_ILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetDisplayRemoved_ILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_displayRemoved_ILjava_nio_ByteBuffer_ == null)
				cb_displayRemoved_ILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_DisplayRemoved_ILjava_nio_ByteBuffer_);
			return cb_displayRemoved_ILjava_nio_ByteBuffer_;
		}

		static void n_DisplayRemoved_ILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DisplayRemoved (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_displayRemoved_ILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='displayRemoved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("displayRemoved", "(ILjava/nio/ByteBuffer;)V", "GetDisplayRemoved_ILjava_nio_ByteBuffer_Handler")]
		public virtual unsafe void DisplayRemoved (int p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_displayRemoved_ILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_displayRemoved_ILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "displayRemoved", "(ILjava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_displayRemoved_ILjava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayRemoved", "(ILjava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getDisplay_I;
#pragma warning disable 0169
		static Delegate GetGetDisplay_IHandler ()
		{
			if (cb_getDisplay_I == null)
				cb_getDisplay_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDisplay_I);
			return cb_getDisplay_I;
		}

		static IntPtr n_GetDisplay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDisplay (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getDisplay_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getDisplay' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDisplay", "(I)Landroid/view/Display;", "GetGetDisplay_IHandler")]
		public virtual unsafe global::Android.Views.Display GetDisplay (int p0)
		{
			if (id_getDisplay_I == IntPtr.Zero)
				id_getDisplay_I = JNIEnv.GetMethodID (class_ref, "getDisplay", "(I)Landroid/view/Display;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.Display> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplay_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.Display> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplay", "(I)Landroid/view/Display;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDisplayIds;
#pragma warning disable 0169
		static Delegate GetGetDisplayIdsHandler ()
		{
			if (cb_getDisplayIds == null)
				cb_getDisplayIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayIds);
			return cb_getDisplayIds;
		}

		static IntPtr n_GetDisplayIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDisplayIds ());
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayIds;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getDisplayIds' and count(parameter)=0]"
		[Register ("getDisplayIds", "()[I", "GetGetDisplayIdsHandler")]
		public virtual unsafe int[] GetDisplayIds ()
		{
			if (id_getDisplayIds == IntPtr.Zero)
				id_getDisplayIds = JNIEnv.GetMethodID (class_ref, "getDisplayIds", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayIds), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayIds", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getDisplays;
#pragma warning disable 0169
		static Delegate GetGetDisplaysHandler ()
		{
			if (cb_getDisplays == null)
				cb_getDisplays = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetDisplays);
			return cb_getDisplays;
		}

		static void n_GetDisplays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetDisplays ();
		}
#pragma warning restore 0169

		static IntPtr id_getDisplays;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getDisplays' and count(parameter)=0]"
		[Register ("getDisplays", "()V", "GetGetDisplaysHandler")]
		public virtual unsafe void GetDisplays ()
		{
			if (id_getDisplays == IntPtr.Zero)
				id_getDisplays = JNIEnv.GetMethodID (class_ref, "getDisplays", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getDisplays);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplays", "()V"));
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
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetName (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRealHeight (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getRealHeight_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getRealHeight' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRealWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getRealWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getRealWidth' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getRotation_I;
#pragma warning disable 0169
		static Delegate GetGetRotation_IHandler ()
		{
			if (cb_getRotation_I == null)
				cb_getRotation_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetRotation_I);
			return cb_getRotation_I;
		}

		static int n_GetRotation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRotation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getRotation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getRotation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRotation", "(I)I", "GetGetRotation_IHandler")]
		public virtual unsafe int GetRotation (int p0)
		{
			if (id_getRotation_I == IntPtr.Zero)
				id_getRotation_I = JNIEnv.GetMethodID (class_ref, "getRotation", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRotation_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotation", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getWorkAreaHeight_I;
#pragma warning disable 0169
		static Delegate GetGetWorkAreaHeight_IHandler ()
		{
			if (cb_getWorkAreaHeight_I == null)
				cb_getWorkAreaHeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetWorkAreaHeight_I);
			return cb_getWorkAreaHeight_I;
		}

		static int n_GetWorkAreaHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetWorkAreaHeight (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getWorkAreaHeight_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getWorkAreaHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getWorkAreaHeight", "(I)I", "GetGetWorkAreaHeight_IHandler")]
		public virtual unsafe int GetWorkAreaHeight (int p0)
		{
			if (id_getWorkAreaHeight_I == IntPtr.Zero)
				id_getWorkAreaHeight_I = JNIEnv.GetMethodID (class_ref, "getWorkAreaHeight", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWorkAreaHeight_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWorkAreaHeight", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getWorkAreaWidth_I;
#pragma warning disable 0169
		static Delegate GetGetWorkAreaWidth_IHandler ()
		{
			if (cb_getWorkAreaWidth_I == null)
				cb_getWorkAreaWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetWorkAreaWidth_I);
			return cb_getWorkAreaWidth_I;
		}

		static int n_GetWorkAreaWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetWorkAreaWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getWorkAreaWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getWorkAreaWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getWorkAreaWidth", "(I)I", "GetGetWorkAreaWidth_IHandler")]
		public virtual unsafe int GetWorkAreaWidth (int p0)
		{
			if (id_getWorkAreaWidth_I == IntPtr.Zero)
				id_getWorkAreaWidth_I = JNIEnv.GetMethodID (class_ref, "getWorkAreaWidth", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWorkAreaWidth_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWorkAreaWidth", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getXdpi_I;
#pragma warning disable 0169
		static Delegate GetGetXdpi_IHandler ()
		{
			if (cb_getXdpi_I == null)
				cb_getXdpi_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetXdpi_I);
			return cb_getXdpi_I;
		}

		static int n_GetXdpi_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetXdpi (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getXdpi_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getXdpi' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getXdpi", "(I)I", "GetGetXdpi_IHandler")]
		public virtual unsafe int GetXdpi (int p0)
		{
			if (id_getXdpi_I == IntPtr.Zero)
				id_getXdpi_I = JNIEnv.GetMethodID (class_ref, "getXdpi", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getXdpi_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXdpi", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getYdpi_I;
#pragma warning disable 0169
		static Delegate GetGetYdpi_IHandler ()
		{
			if (cb_getYdpi_I == null)
				cb_getYdpi_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetYdpi_I);
			return cb_getYdpi_I;
		}

		static int n_GetYdpi_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetYdpi (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getYdpi_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='getYdpi' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getYdpi", "(I)I", "GetGetYdpi_IHandler")]
		public virtual unsafe int GetYdpi (int p0)
		{
			if (id_getYdpi_I == IntPtr.Zero)
				id_getYdpi_I = JNIEnv.GetMethodID (class_ref, "getYdpi", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYdpi_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYdpi", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_isDefaultDisplay_I;
#pragma warning disable 0169
		static Delegate GetIsDefaultDisplay_IHandler ()
		{
			if (cb_isDefaultDisplay_I == null)
				cb_isDefaultDisplay_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsDefaultDisplay_I);
			return cb_isDefaultDisplay_I;
		}

		static bool n_IsDefaultDisplay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDefaultDisplay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isDefaultDisplay_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='isDefaultDisplay' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isDefaultDisplay", "(I)Z", "GetIsDefaultDisplay_IHandler")]
		public virtual unsafe bool IsDefaultDisplay (int p0)
		{
			if (id_isDefaultDisplay_I == IntPtr.Zero)
				id_isDefaultDisplay_I = JNIEnv.GetMethodID (class_ref, "isDefaultDisplay", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDefaultDisplay_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDefaultDisplay", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_onOrientationChanged_I;
#pragma warning disable 0169
		static Delegate GetOnOrientationChanged_IHandler ()
		{
			if (cb_onOrientationChanged_I == null)
				cb_onOrientationChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnOrientationChanged_I);
			return cb_onOrientationChanged_I;
		}

		static void n_OnOrientationChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnOrientationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onOrientationChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='onOrientationChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onOrientationChanged", "(I)V", "GetOnOrientationChanged_IHandler")]
		public override unsafe void OnOrientationChanged (int p0)
		{
			if (id_onOrientationChanged_I == IntPtr.Zero)
				id_onOrientationChanged_I = JNIEnv.GetMethodID (class_ref, "onOrientationChanged", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOrientationChanged_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOrientationChanged", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_rotationChanged_ILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetRotationChanged_ILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_rotationChanged_ILjava_nio_ByteBuffer_ == null)
				cb_rotationChanged_ILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RotationChanged_ILjava_nio_ByteBuffer_);
			return cb_rotationChanged_ILjava_nio_ByteBuffer_;
		}

		static void n_RotationChanged_ILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RotationChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_rotationChanged_ILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='rotationChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("rotationChanged", "(ILjava/nio/ByteBuffer;)V", "GetRotationChanged_ILjava_nio_ByteBuffer_Handler")]
		public virtual unsafe void RotationChanged (int p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_rotationChanged_ILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_rotationChanged_ILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "rotationChanged", "(ILjava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_rotationChanged_ILjava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotationChanged", "(ILjava/nio/ByteBuffer;)V"), __args);
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
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='start' and count(parameter)=0]"
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
			global::Com.Vidyo.LmiDeviceManager.LmiScreenManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiScreenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiScreenManager']/method[@name='stop' and count(parameter)=0]"
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
}
