using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Connector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='Connector']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/Connector", DoNotGenerateAcw=true)]
	public partial class Connector : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/Connector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Connector); }
		}

		protected Connector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='Connector']/constructor[@name='Connector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Connector ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Connector)) {
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

		static IntPtr id_Initialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='Connector']/method[@name='Initialize' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='Connector']/method[@name='SetApplicationUIContext' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='Connector']/method[@name='SetExperimentalOptions' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='Connector']/method[@name='Uninitialize' and count(parameter)=0]"
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
