using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='Endpoint']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/Endpoint", DoNotGenerateAcw=true)]
	public partial class Endpoint : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/Endpoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Endpoint); }
		}

		protected Endpoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='Endpoint']/constructor[@name='Endpoint' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Endpoint ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Endpoint)) {
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

		static IntPtr id_GetBuildTag;
		public static unsafe string BuildTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='Endpoint']/method[@name='GetBuildTag' and count(parameter)=0]"
			[Register ("GetBuildTag", "()Ljava/lang/String;", "GetGetBuildTagHandler")]
			get {
				if (id_GetBuildTag == IntPtr.Zero)
					id_GetBuildTag = JNIEnv.GetStaticMethodID (class_ref, "GetBuildTag", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_GetBuildTag), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_GetVersion;
		public static unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='Endpoint']/method[@name='GetVersion' and count(parameter)=0]"
			[Register ("GetVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_GetVersion == IntPtr.Zero)
					id_GetVersion = JNIEnv.GetStaticMethodID (class_ref, "GetVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_GetVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_Initialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='Endpoint']/method[@name='Initialize' and count(parameter)=0]"
		[Register ("Initialize", "()Z", "")]
		public static unsafe bool Initialize ()
		{
			if (id_Initialize == IntPtr.Zero)
				id_Initialize = JNIEnv.GetStaticMethodID (class_ref, "Initialize", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_Initialize);
			} finally {
			}
		}

		static IntPtr id_SetApplicationUIContext_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='Endpoint']/method[@name='SetApplicationUIContext' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("SetApplicationUIContext", "(Landroid/app/Activity;)V", "")]
		public static unsafe void SetApplicationUIContext (global::Android.App.Activity p0)
		{
			if (id_SetApplicationUIContext_Landroid_app_Activity_ == IntPtr.Zero)
				id_SetApplicationUIContext_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "SetApplicationUIContext", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SetApplicationUIContext_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_SetExperimentalOptions_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='Endpoint']/method[@name='SetExperimentalOptions' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetExperimentalOptions", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool SetExperimentalOptions (string p0)
		{
			if (id_SetExperimentalOptions_Ljava_lang_String_ == IntPtr.Zero)
				id_SetExperimentalOptions_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SetExperimentalOptions", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_SetExperimentalOptions_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_Uninitialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='Endpoint']/method[@name='Uninitialize' and count(parameter)=0]"
		[Register ("Uninitialize", "()V", "")]
		public static unsafe void Uninitialize ()
		{
			if (id_Uninitialize == IntPtr.Zero)
				id_Uninitialize = JNIEnv.GetStaticMethodID (class_ref, "Uninitialize", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Uninitialize);
			} finally {
			}
		}

	}
}
