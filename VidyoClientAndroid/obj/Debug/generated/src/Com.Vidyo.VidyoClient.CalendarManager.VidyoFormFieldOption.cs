using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldOption']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarManager/VidyoFormFieldOption", DoNotGenerateAcw=true)]
	public partial class VidyoFormFieldOption : global::Java.Lang.Object {


		static IntPtr selected_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldOption']/field[@name='selected']"
		[Register ("selected")]
		public bool Selected {
			get {
				if (selected_jfieldId == IntPtr.Zero)
					selected_jfieldId = JNIEnv.GetFieldID (class_ref, "selected", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, selected_jfieldId);
			}
			set {
				if (selected_jfieldId == IntPtr.Zero)
					selected_jfieldId = JNIEnv.GetFieldID (class_ref, "selected", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, selected_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr value_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldOption']/field[@name='value']"
		[Register ("value")]
		public string Value {
			get {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarManager/VidyoFormFieldOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoFormFieldOption); }
		}

		protected VidyoFormFieldOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldOption']/constructor[@name='VidyoFormFieldOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoFormFieldOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoFormFieldOption)) {
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

	}
}
