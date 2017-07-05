using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.LmiDeviceManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerManager']"
	[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiVideoCapturerManager", DoNotGenerateAcw=true)]
	public partial class LmiVideoCapturerManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiVideoCapturerManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LmiVideoCapturerManager); }
		}

		protected LmiVideoCapturerManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_GetCapturerManager_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerManager']/method[@name='GetCapturerManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("GetCapturerManager", "(Landroid/content/Context;J)Lcom/vidyo/LmiDeviceManager/LmiVideoCapturerManager;", "")]
		public static unsafe global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerManager GetCapturerManager (global::Android.Content.Context p0, long p1)
		{
			if (id_GetCapturerManager_Landroid_content_Context_J == IntPtr.Zero)
				id_GetCapturerManager_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "GetCapturerManager", "(Landroid/content/Context;J)Lcom/vidyo/LmiDeviceManager/LmiVideoCapturerManager;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerManager __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_GetCapturerManager_Landroid_content_Context_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getDevices;
#pragma warning disable 0169
		static Delegate GetGetDevicesHandler ()
		{
			if (cb_getDevices == null)
				cb_getDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDevices);
			return cb_getDevices;
		}

		static IntPtr n_GetDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDevices ());
		}
#pragma warning restore 0169

		static IntPtr id_getDevices;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerManager']/method[@name='getDevices' and count(parameter)=0]"
		[Register ("getDevices", "()[Ljava/lang/String;", "GetGetDevicesHandler")]
		public virtual unsafe string[] GetDevices ()
		{
			if (id_getDevices == IntPtr.Zero)
				id_getDevices = JNIEnv.GetMethodID (class_ref, "getDevices", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDevices), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDevices", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_startDeviceDetector;
#pragma warning disable 0169
		static Delegate GetStartDeviceDetectorHandler ()
		{
			if (cb_startDeviceDetector == null)
				cb_startDeviceDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartDeviceDetector);
			return cb_startDeviceDetector;
		}

		static bool n_StartDeviceDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartDeviceDetector ();
		}
#pragma warning restore 0169

		static IntPtr id_startDeviceDetector;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerManager']/method[@name='startDeviceDetector' and count(parameter)=0]"
		[Register ("startDeviceDetector", "()Z", "GetStartDeviceDetectorHandler")]
		public virtual unsafe bool StartDeviceDetector ()
		{
			if (id_startDeviceDetector == IntPtr.Zero)
				id_startDeviceDetector = JNIEnv.GetMethodID (class_ref, "startDeviceDetector", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startDeviceDetector);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDeviceDetector", "()Z"));
			} finally {
			}
		}

		static Delegate cb_stopDeviceDetector;
#pragma warning disable 0169
		static Delegate GetStopDeviceDetectorHandler ()
		{
			if (cb_stopDeviceDetector == null)
				cb_stopDeviceDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopDeviceDetector);
			return cb_stopDeviceDetector;
		}

		static bool n_StopDeviceDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopDeviceDetector ();
		}
#pragma warning restore 0169

		static IntPtr id_stopDeviceDetector;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerManager']/method[@name='stopDeviceDetector' and count(parameter)=0]"
		[Register ("stopDeviceDetector", "()Z", "GetStopDeviceDetectorHandler")]
		public virtual unsafe bool StopDeviceDetector ()
		{
			if (id_stopDeviceDetector == IntPtr.Zero)
				id_stopDeviceDetector = JNIEnv.GetMethodID (class_ref, "stopDeviceDetector", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_stopDeviceDetector);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopDeviceDetector", "()Z"));
			} finally {
			}
		}

	}
}
