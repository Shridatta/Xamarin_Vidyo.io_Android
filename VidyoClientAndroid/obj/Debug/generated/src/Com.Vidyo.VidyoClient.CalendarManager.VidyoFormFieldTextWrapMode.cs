using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldTextWrapMode']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode", DoNotGenerateAcw=true)]
	public sealed partial class VidyoFormFieldTextWrapMode : global::Java.Lang.Enum {


		static IntPtr VIDYO_FORMFIELDTEXTWRAPMODE_Off_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldTextWrapMode']/field[@name='VIDYO_FORMFIELDTEXTWRAPMODE_Off']"
		[Register ("VIDYO_FORMFIELDTEXTWRAPMODE_Off")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode VIDYOFORMFIELDTEXTWRAPMODEOff {
			get {
				if (VIDYO_FORMFIELDTEXTWRAPMODE_Off_jfieldId == IntPtr.Zero)
					VIDYO_FORMFIELDTEXTWRAPMODE_Off_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_FORMFIELDTEXTWRAPMODE_Off", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_FORMFIELDTEXTWRAPMODE_Off_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_FORMFIELDTEXTWRAPMODE_Physical_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldTextWrapMode']/field[@name='VIDYO_FORMFIELDTEXTWRAPMODE_Physical']"
		[Register ("VIDYO_FORMFIELDTEXTWRAPMODE_Physical")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode VIDYOFORMFIELDTEXTWRAPMODEPhysical {
			get {
				if (VIDYO_FORMFIELDTEXTWRAPMODE_Physical_jfieldId == IntPtr.Zero)
					VIDYO_FORMFIELDTEXTWRAPMODE_Physical_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_FORMFIELDTEXTWRAPMODE_Physical", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_FORMFIELDTEXTWRAPMODE_Physical_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_FORMFIELDTEXTWRAPMODE_Virtual_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldTextWrapMode']/field[@name='VIDYO_FORMFIELDTEXTWRAPMODE_Virtual']"
		[Register ("VIDYO_FORMFIELDTEXTWRAPMODE_Virtual")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode VIDYOFORMFIELDTEXTWRAPMODEVirtual {
			get {
				if (VIDYO_FORMFIELDTEXTWRAPMODE_Virtual_jfieldId == IntPtr.Zero)
					VIDYO_FORMFIELDTEXTWRAPMODE_Virtual_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_FORMFIELDTEXTWRAPMODE_Virtual", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_FORMFIELDTEXTWRAPMODE_Virtual_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoFormFieldTextWrapMode); }
		}

		internal VidyoFormFieldTextWrapMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldTextWrapMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldTextWrapMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode;");
			try {
				return (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode));
			} finally {
			}
		}

	}
}
