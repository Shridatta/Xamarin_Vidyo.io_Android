using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Meeting {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingType']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Meeting/VidyoMeetingType", DoNotGenerateAcw=true)]
	public sealed partial class VidyoMeetingType : global::Java.Lang.Enum {


		static IntPtr VIDYO_MEETINGTYPE_Standard_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingType']/field[@name='VIDYO_MEETINGTYPE_Standard']"
		[Register ("VIDYO_MEETINGTYPE_Standard")]
		public static global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType VIDYOMEETINGTYPEStandard {
			get {
				if (VIDYO_MEETINGTYPE_Standard_jfieldId == IntPtr.Zero)
					VIDYO_MEETINGTYPE_Standard_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_MEETINGTYPE_Standard", "Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_MEETINGTYPE_Standard_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_MEETINGTYPE_Vidyo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingType']/field[@name='VIDYO_MEETINGTYPE_Vidyo']"
		[Register ("VIDYO_MEETINGTYPE_Vidyo")]
		public static global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType VIDYOMEETINGTYPEVidyo {
			get {
				if (VIDYO_MEETINGTYPE_Vidyo_jfieldId == IntPtr.Zero)
					VIDYO_MEETINGTYPE_Vidyo_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_MEETINGTYPE_Vidyo", "Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_MEETINGTYPE_Vidyo_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Meeting/VidyoMeetingType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoMeetingType); }
		}

		internal VidyoMeetingType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingType;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingType;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingType;");
			try {
				return (global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType));
			} finally {
			}
		}

	}
}
