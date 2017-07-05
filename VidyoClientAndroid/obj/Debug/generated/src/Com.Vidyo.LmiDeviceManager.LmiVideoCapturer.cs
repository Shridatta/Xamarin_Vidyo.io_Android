using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.LmiDeviceManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']"
	[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiVideoCapturer", DoNotGenerateAcw=true)]
	public abstract partial class LmiVideoCapturer : global::Java.Lang.Object {


		static IntPtr LMI_VIDEOCAPTURER_POSITION_Back_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/field[@name='LMI_VIDEOCAPTURER_POSITION_Back']"
		[Register ("LMI_VIDEOCAPTURER_POSITION_Back")]
		public int LMIVIDEOCAPTURERPOSITIONBack {
			get {
				if (LMI_VIDEOCAPTURER_POSITION_Back_jfieldId == IntPtr.Zero)
					LMI_VIDEOCAPTURER_POSITION_Back_jfieldId = JNIEnv.GetFieldID (class_ref, "LMI_VIDEOCAPTURER_POSITION_Back", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, LMI_VIDEOCAPTURER_POSITION_Back_jfieldId);
			}
			set {
				if (LMI_VIDEOCAPTURER_POSITION_Back_jfieldId == IntPtr.Zero)
					LMI_VIDEOCAPTURER_POSITION_Back_jfieldId = JNIEnv.GetFieldID (class_ref, "LMI_VIDEOCAPTURER_POSITION_Back", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, LMI_VIDEOCAPTURER_POSITION_Back_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr LMI_VIDEOCAPTURER_POSITION_Front_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/field[@name='LMI_VIDEOCAPTURER_POSITION_Front']"
		[Register ("LMI_VIDEOCAPTURER_POSITION_Front")]
		public int LMIVIDEOCAPTURERPOSITIONFront {
			get {
				if (LMI_VIDEOCAPTURER_POSITION_Front_jfieldId == IntPtr.Zero)
					LMI_VIDEOCAPTURER_POSITION_Front_jfieldId = JNIEnv.GetFieldID (class_ref, "LMI_VIDEOCAPTURER_POSITION_Front", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, LMI_VIDEOCAPTURER_POSITION_Front_jfieldId);
			}
			set {
				if (LMI_VIDEOCAPTURER_POSITION_Front_jfieldId == IntPtr.Zero)
					LMI_VIDEOCAPTURER_POSITION_Front_jfieldId = JNIEnv.GetFieldID (class_ref, "LMI_VIDEOCAPTURER_POSITION_Front", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, LMI_VIDEOCAPTURER_POSITION_Front_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer.CameraNotSupportedException']"
		[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiVideoCapturer$CameraNotSupportedException", DoNotGenerateAcw=true)]
		public partial class CameraNotSupportedException : global::Java.Lang.Exception {

			protected CameraNotSupportedException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiVideoCapturer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LmiVideoCapturer); }
		}

		protected LmiVideoCapturer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getFacing;
#pragma warning disable 0169
		static Delegate GetGetFacingHandler ()
		{
			if (cb_getFacing == null)
				cb_getFacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFacing);
			return cb_getFacing;
		}

		static int n_GetFacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Facing;
		}
#pragma warning restore 0169

		public abstract int Facing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getFacing' and count(parameter)=0]"
			[Register ("getFacing", "()I", "GetGetFacingHandler")] get;
		}

		static Delegate cb_getMirrored;
#pragma warning disable 0169
		static Delegate GetGetMirroredHandler ()
		{
			if (cb_getMirrored == null)
				cb_getMirrored = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetMirrored);
			return cb_getMirrored;
		}

		static bool n_GetMirrored (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mirrored;
		}
#pragma warning restore 0169

		public abstract bool Mirrored {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getMirrored' and count(parameter)=0]"
			[Register ("getMirrored", "()Z", "GetGetMirroredHandler")] get;
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")] get;
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		public abstract int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")] get;
		}

		static IntPtr id_GetCapturer_Landroid_content_Context_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='GetCapturer' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("GetCapturer", "(Landroid/content/Context;Ljava/lang/String;J)Lcom/vidyo/LmiDeviceManager/LmiVideoCapturer;", "")]
		public static unsafe global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer GetCapturer (global::Android.Content.Context p0, string p1, long p2)
		{
			if (id_GetCapturer_Landroid_content_Context_Ljava_lang_String_J == IntPtr.Zero)
				id_GetCapturer_Landroid_content_Context_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "GetCapturer", "(Landroid/content/Context;Ljava/lang/String;J)Lcom/vidyo/LmiDeviceManager/LmiVideoCapturer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_GetCapturer_Landroid_content_Context_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getCapabilities;
#pragma warning disable 0169
		static Delegate GetGetCapabilitiesHandler ()
		{
			if (cb_getCapabilities == null)
				cb_getCapabilities = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCapabilities);
			return cb_getCapabilities;
		}

		static IntPtr n_GetCapabilities (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCapabilities ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getCapabilities' and count(parameter)=0]"
		[Register ("getCapabilities", "()[Lcom/vidyo/LmiDeviceManager/LmiVideoCapturerCapability;", "GetGetCapabilitiesHandler")]
		public abstract global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability[] GetCapabilities ();

		static Delegate cb_getCapabilities_Z;
#pragma warning disable 0169
		static Delegate GetGetCapabilities_ZHandler ()
		{
			if (cb_getCapabilities_Z == null)
				cb_getCapabilities_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_GetCapabilities_Z);
			return cb_getCapabilities_Z;
		}

		static IntPtr n_GetCapabilities_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCapabilities (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getCapabilities_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getCapabilities' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getCapabilities", "(Z)[Lcom/vidyo/LmiDeviceManager/LmiVideoCapturerCapability;", "GetGetCapabilities_ZHandler")]
		public virtual unsafe global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability[] GetCapabilities (bool p0)
		{
			if (id_getCapabilities_Z == IntPtr.Zero)
				id_getCapabilities_Z = JNIEnv.GetMethodID (class_ref, "getCapabilities", "(Z)[Lcom/vidyo/LmiDeviceManager/LmiVideoCapturerCapability;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCapabilities_Z, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability));
				else
					return (global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCapabilities", "(Z)[Lcom/vidyo/LmiDeviceManager/LmiVideoCapturerCapability;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability));
			} finally {
			}
		}

		static Delegate cb_releaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_;
#pragma warning disable 0169
		static Delegate GetReleaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_Handler ()
		{
			if (cb_releaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_ == null)
				cb_releaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReleaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_);
			return cb_releaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_;
		}

		static void n_ReleaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseFrame (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='releaseFrame' and count(parameter)=1 and parameter[1][@type='com.vidyo.LmiDeviceManager.LmiVideoFrame']]"
		[Register ("releaseFrame", "(Lcom/vidyo/LmiDeviceManager/LmiVideoFrame;)V", "GetReleaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_Handler")]
		public abstract void ReleaseFrame (global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame p0);

		static Delegate cb_start_Ljava_lang_String_IIJ;
#pragma warning disable 0169
		static Delegate GetStart_Ljava_lang_String_IIJHandler ()
		{
			if (cb_start_Ljava_lang_String_IIJ == null)
				cb_start_Ljava_lang_String_IIJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, long, bool>) n_Start_Ljava_lang_String_IIJ);
			return cb_start_Ljava_lang_String_IIJ;
		}

		static bool n_Start_Ljava_lang_String_IIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, long p3)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Start (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_start_Ljava_lang_String_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='start' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("start", "(Ljava/lang/String;IIJ)Z", "GetStart_Ljava_lang_String_IIJHandler")]
		public virtual unsafe bool Start (string p0, int p1, int p2, long p3)
		{
			if (id_start_Ljava_lang_String_IIJ == IntPtr.Zero)
				id_start_Ljava_lang_String_IIJ = JNIEnv.GetMethodID (class_ref, "start", "(Ljava/lang/String;IIJ)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_start_Ljava_lang_String_IIJ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(Ljava/lang/String;IIJ)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startInternal_Ljava_lang_String_IIJ;
#pragma warning disable 0169
		static Delegate GetStartInternal_Ljava_lang_String_IIJHandler ()
		{
			if (cb_startInternal_Ljava_lang_String_IIJ == null)
				cb_startInternal_Ljava_lang_String_IIJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, long, bool>) n_StartInternal_Ljava_lang_String_IIJ);
			return cb_startInternal_Ljava_lang_String_IIJ;
		}

		static bool n_StartInternal_Ljava_lang_String_IIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, long p3)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartInternal (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='startInternal' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("startInternal", "(Ljava/lang/String;IIJ)Z", "GetStartInternal_Ljava_lang_String_IIJHandler")]
		public abstract bool StartInternal (string p0, int p1, int p2, long p3);

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
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='stop' and count(parameter)=0]"
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

		static Delegate cb_stopInternal;
#pragma warning disable 0169
		static Delegate GetStopInternalHandler ()
		{
			if (cb_stopInternal == null)
				cb_stopInternal = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopInternal);
			return cb_stopInternal;
		}

		static void n_StopInternal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopInternal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='stopInternal' and count(parameter)=0]"
		[Register ("stopInternal", "()V", "GetStopInternalHandler")]
		public abstract void StopInternal ();

	}

	[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiVideoCapturer", DoNotGenerateAcw=true)]
	internal partial class LmiVideoCapturerInvoker : LmiVideoCapturer {

		public LmiVideoCapturerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LmiVideoCapturerInvoker); }
		}

		static IntPtr id_getFacing;
		public override unsafe int Facing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getFacing' and count(parameter)=0]"
			[Register ("getFacing", "()I", "GetGetFacingHandler")]
			get {
				if (id_getFacing == IntPtr.Zero)
					id_getFacing = JNIEnv.GetMethodID (class_ref, "getFacing", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFacing);
				} finally {
				}
			}
		}

		static IntPtr id_getMirrored;
		public override unsafe bool Mirrored {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getMirrored' and count(parameter)=0]"
			[Register ("getMirrored", "()Z", "GetGetMirroredHandler")]
			get {
				if (id_getMirrored == IntPtr.Zero)
					id_getMirrored = JNIEnv.GetMethodID (class_ref, "getMirrored", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getMirrored);
				} finally {
				}
			}
		}

		static IntPtr id_getName;
		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getOrientation;
		public override unsafe int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrientation);
				} finally {
				}
			}
		}

		static IntPtr id_getCapabilities;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='getCapabilities' and count(parameter)=0]"
		[Register ("getCapabilities", "()[Lcom/vidyo/LmiDeviceManager/LmiVideoCapturerCapability;", "GetGetCapabilitiesHandler")]
		public override unsafe global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability[] GetCapabilities ()
		{
			if (id_getCapabilities == IntPtr.Zero)
				id_getCapabilities = JNIEnv.GetMethodID (class_ref, "getCapabilities", "()[Lcom/vidyo/LmiDeviceManager/LmiVideoCapturerCapability;");
			try {
				return (global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCapabilities), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability));
			} finally {
			}
		}

		static IntPtr id_releaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='releaseFrame' and count(parameter)=1 and parameter[1][@type='com.vidyo.LmiDeviceManager.LmiVideoFrame']]"
		[Register ("releaseFrame", "(Lcom/vidyo/LmiDeviceManager/LmiVideoFrame;)V", "GetReleaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_Handler")]
		public override unsafe void ReleaseFrame (global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame p0)
		{
			if (id_releaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_ == IntPtr.Zero)
				id_releaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_ = JNIEnv.GetMethodID (class_ref, "releaseFrame", "(Lcom/vidyo/LmiDeviceManager/LmiVideoFrame;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseFrame_Lcom_vidyo_LmiDeviceManager_LmiVideoFrame_, __args);
			} finally {
			}
		}

		static IntPtr id_startInternal_Ljava_lang_String_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='startInternal' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("startInternal", "(Ljava/lang/String;IIJ)Z", "GetStartInternal_Ljava_lang_String_IIJHandler")]
		public override unsafe bool StartInternal (string p0, int p1, int p2, long p3)
		{
			if (id_startInternal_Ljava_lang_String_IIJ == IntPtr.Zero)
				id_startInternal_Ljava_lang_String_IIJ = JNIEnv.GetMethodID (class_ref, "startInternal", "(Ljava/lang/String;IIJ)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startInternal_Ljava_lang_String_IIJ, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_stopInternal;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturer']/method[@name='stopInternal' and count(parameter)=0]"
		[Register ("stopInternal", "()V", "GetStopInternalHandler")]
		public override unsafe void StopInternal ()
		{
			if (id_stopInternal == IntPtr.Zero)
				id_stopInternal = JNIEnv.GetMethodID (class_ref, "stopInternal", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopInternal);
			} finally {
			}
		}

	}

}
