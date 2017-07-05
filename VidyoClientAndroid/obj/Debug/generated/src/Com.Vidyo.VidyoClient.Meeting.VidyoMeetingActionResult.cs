using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Meeting {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingActionResult']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult", DoNotGenerateAcw=true)]
	public sealed partial class VidyoMeetingActionResult : global::Java.Lang.Enum {


		static IntPtr VIDYO_MEETINGACTIONRESULT_MiscLocalError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingActionResult']/field[@name='VIDYO_MEETINGACTIONRESULT_MiscLocalError']"
		[Register ("VIDYO_MEETINGACTIONRESULT_MiscLocalError")]
		public static global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult VIDYOMEETINGACTIONRESULTMiscLocalError {
			get {
				if (VIDYO_MEETINGACTIONRESULT_MiscLocalError_jfieldId == IntPtr.Zero)
					VIDYO_MEETINGACTIONRESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_MEETINGACTIONRESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_MEETINGACTIONRESULT_MiscLocalError_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_MEETINGACTIONRESULT_MiscRemoteError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingActionResult']/field[@name='VIDYO_MEETINGACTIONRESULT_MiscRemoteError']"
		[Register ("VIDYO_MEETINGACTIONRESULT_MiscRemoteError")]
		public static global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult VIDYOMEETINGACTIONRESULTMiscRemoteError {
			get {
				if (VIDYO_MEETINGACTIONRESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
					VIDYO_MEETINGACTIONRESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_MEETINGACTIONRESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_MEETINGACTIONRESULT_MiscRemoteError_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_MEETINGACTIONRESULT_NoResponse_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingActionResult']/field[@name='VIDYO_MEETINGACTIONRESULT_NoResponse']"
		[Register ("VIDYO_MEETINGACTIONRESULT_NoResponse")]
		public static global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult VIDYOMEETINGACTIONRESULTNoResponse {
			get {
				if (VIDYO_MEETINGACTIONRESULT_NoResponse_jfieldId == IntPtr.Zero)
					VIDYO_MEETINGACTIONRESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_MEETINGACTIONRESULT_NoResponse", "Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_MEETINGACTIONRESULT_NoResponse_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_MEETINGACTIONRESULT_OK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingActionResult']/field[@name='VIDYO_MEETINGACTIONRESULT_OK']"
		[Register ("VIDYO_MEETINGACTIONRESULT_OK")]
		public static global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult VidyoMeetingactionresultOk {
			get {
				if (VIDYO_MEETINGACTIONRESULT_OK_jfieldId == IntPtr.Zero)
					VIDYO_MEETINGACTIONRESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_MEETINGACTIONRESULT_OK", "Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_MEETINGACTIONRESULT_OK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_MEETINGACTIONRESULT_RemovedByLocalUser_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingActionResult']/field[@name='VIDYO_MEETINGACTIONRESULT_RemovedByLocalUser']"
		[Register ("VIDYO_MEETINGACTIONRESULT_RemovedByLocalUser")]
		public static global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult VIDYOMEETINGACTIONRESULTRemovedByLocalUser {
			get {
				if (VIDYO_MEETINGACTIONRESULT_RemovedByLocalUser_jfieldId == IntPtr.Zero)
					VIDYO_MEETINGACTIONRESULT_RemovedByLocalUser_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_MEETINGACTIONRESULT_RemovedByLocalUser", "Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_MEETINGACTIONRESULT_RemovedByLocalUser_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_MEETINGACTIONRESULT_RemovedByRemoteUser_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingActionResult']/field[@name='VIDYO_MEETINGACTIONRESULT_RemovedByRemoteUser']"
		[Register ("VIDYO_MEETINGACTIONRESULT_RemovedByRemoteUser")]
		public static global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult VIDYOMEETINGACTIONRESULTRemovedByRemoteUser {
			get {
				if (VIDYO_MEETINGACTIONRESULT_RemovedByRemoteUser_jfieldId == IntPtr.Zero)
					VIDYO_MEETINGACTIONRESULT_RemovedByRemoteUser_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_MEETINGACTIONRESULT_RemovedByRemoteUser", "Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_MEETINGACTIONRESULT_RemovedByRemoteUser_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_MEETINGACTIONRESULT_Unauthorized_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingActionResult']/field[@name='VIDYO_MEETINGACTIONRESULT_Unauthorized']"
		[Register ("VIDYO_MEETINGACTIONRESULT_Unauthorized")]
		public static global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult VIDYOMEETINGACTIONRESULTUnauthorized {
			get {
				if (VIDYO_MEETINGACTIONRESULT_Unauthorized_jfieldId == IntPtr.Zero)
					VIDYO_MEETINGACTIONRESULT_Unauthorized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_MEETINGACTIONRESULT_Unauthorized", "Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_MEETINGACTIONRESULT_Unauthorized_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoMeetingActionResult); }
		}

		internal VidyoMeetingActionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingActionResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeetingActionResult']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;");
			try {
				return (global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult));
			} finally {
			}
		}

	}
}
