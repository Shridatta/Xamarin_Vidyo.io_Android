using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldType']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType", DoNotGenerateAcw=true)]
	public sealed partial class VidyoFormFieldType : global::Java.Lang.Enum {


		static IntPtr VIDYO_FORMFIELDTYPE_Checkbox_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldType']/field[@name='VIDYO_FORMFIELDTYPE_Checkbox']"
		[Register ("VIDYO_FORMFIELDTYPE_Checkbox")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType VIDYOFORMFIELDTYPECheckbox {
			get {
				if (VIDYO_FORMFIELDTYPE_Checkbox_jfieldId == IntPtr.Zero)
					VIDYO_FORMFIELDTYPE_Checkbox_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_FORMFIELDTYPE_Checkbox", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_FORMFIELDTYPE_Checkbox_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_FORMFIELDTYPE_Password_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldType']/field[@name='VIDYO_FORMFIELDTYPE_Password']"
		[Register ("VIDYO_FORMFIELDTYPE_Password")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType VIDYOFORMFIELDTYPEPassword {
			get {
				if (VIDYO_FORMFIELDTYPE_Password_jfieldId == IntPtr.Zero)
					VIDYO_FORMFIELDTYPE_Password_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_FORMFIELDTYPE_Password", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_FORMFIELDTYPE_Password_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_FORMFIELDTYPE_Radio_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldType']/field[@name='VIDYO_FORMFIELDTYPE_Radio']"
		[Register ("VIDYO_FORMFIELDTYPE_Radio")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType VIDYOFORMFIELDTYPERadio {
			get {
				if (VIDYO_FORMFIELDTYPE_Radio_jfieldId == IntPtr.Zero)
					VIDYO_FORMFIELDTYPE_Radio_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_FORMFIELDTYPE_Radio", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_FORMFIELDTYPE_Radio_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_FORMFIELDTYPE_Select_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldType']/field[@name='VIDYO_FORMFIELDTYPE_Select']"
		[Register ("VIDYO_FORMFIELDTYPE_Select")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType VIDYOFORMFIELDTYPESelect {
			get {
				if (VIDYO_FORMFIELDTYPE_Select_jfieldId == IntPtr.Zero)
					VIDYO_FORMFIELDTYPE_Select_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_FORMFIELDTYPE_Select", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_FORMFIELDTYPE_Select_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_FORMFIELDTYPE_Text_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldType']/field[@name='VIDYO_FORMFIELDTYPE_Text']"
		[Register ("VIDYO_FORMFIELDTYPE_Text")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType VIDYOFORMFIELDTYPEText {
			get {
				if (VIDYO_FORMFIELDTYPE_Text_jfieldId == IntPtr.Zero)
					VIDYO_FORMFIELDTYPE_Text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_FORMFIELDTYPE_Text", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_FORMFIELDTYPE_Text_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_FORMFIELDTYPE_TextArea_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldType']/field[@name='VIDYO_FORMFIELDTYPE_TextArea']"
		[Register ("VIDYO_FORMFIELDTYPE_TextArea")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType VIDYOFORMFIELDTYPETextArea {
			get {
				if (VIDYO_FORMFIELDTYPE_TextArea_jfieldId == IntPtr.Zero)
					VIDYO_FORMFIELDTYPE_TextArea_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_FORMFIELDTYPE_TextArea", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_FORMFIELDTYPE_TextArea_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoFormFieldType); }
		}

		internal VidyoFormFieldType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormFieldType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;");
			try {
				return (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType));
			} finally {
			}
		}

	}
}
