using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarCreateResult']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarManager/VidyoCalendarCreateResult", DoNotGenerateAcw=true)]
	public sealed partial class VidyoCalendarCreateResult : global::Java.Lang.Enum {


		static IntPtr VIDYO_CALENDARCREATERESULT_InvalidConnParams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarCreateResult']/field[@name='VIDYO_CALENDARCREATERESULT_InvalidConnParams']"
		[Register ("VIDYO_CALENDARCREATERESULT_InvalidConnParams")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult VIDYOCALENDARCREATERESULTInvalidConnParams {
			get {
				if (VIDYO_CALENDARCREATERESULT_InvalidConnParams_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARCREATERESULT_InvalidConnParams_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARCREATERESULT_InvalidConnParams", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarCreateResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARCREATERESULT_InvalidConnParams_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARCREATERESULT_InvalidType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarCreateResult']/field[@name='VIDYO_CALENDARCREATERESULT_InvalidType']"
		[Register ("VIDYO_CALENDARCREATERESULT_InvalidType")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult VIDYOCALENDARCREATERESULTInvalidType {
			get {
				if (VIDYO_CALENDARCREATERESULT_InvalidType_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARCREATERESULT_InvalidType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARCREATERESULT_InvalidType", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarCreateResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARCREATERESULT_InvalidType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARCREATERESULT_Ok_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarCreateResult']/field[@name='VIDYO_CALENDARCREATERESULT_Ok']"
		[Register ("VIDYO_CALENDARCREATERESULT_Ok")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult VIDYOCALENDARCREATERESULTOk {
			get {
				if (VIDYO_CALENDARCREATERESULT_Ok_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARCREATERESULT_Ok_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARCREATERESULT_Ok", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarCreateResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARCREATERESULT_Ok_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarManager/VidyoCalendarCreateResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoCalendarCreateResult); }
		}

		internal VidyoCalendarCreateResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarCreateResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarCreateResult;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarCreateResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarCreateResult']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarCreateResult;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarCreateResult;");
			try {
				return (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarCreateResult));
			} finally {
			}
		}

	}
}
