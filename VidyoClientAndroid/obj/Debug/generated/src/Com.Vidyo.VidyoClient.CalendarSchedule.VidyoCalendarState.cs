using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarSchedule {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarState']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState", DoNotGenerateAcw=true)]
	public sealed partial class VidyoCalendarState : global::Java.Lang.Enum {


		static IntPtr VIDYO_CALENDARSTATE_Connected_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarState']/field[@name='VIDYO_CALENDARSTATE_Connected']"
		[Register ("VIDYO_CALENDARSTATE_Connected")]
		public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState VIDYOCALENDARSTATEConnected {
			get {
				if (VIDYO_CALENDARSTATE_Connected_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSTATE_Connected_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSTATE_Connected", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSTATE_Connected_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSTATE_Connecting_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarState']/field[@name='VIDYO_CALENDARSTATE_Connecting']"
		[Register ("VIDYO_CALENDARSTATE_Connecting")]
		public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState VIDYOCALENDARSTATEConnecting {
			get {
				if (VIDYO_CALENDARSTATE_Connecting_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSTATE_Connecting_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSTATE_Connecting", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSTATE_Connecting_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSTATE_Disconnected_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarState']/field[@name='VIDYO_CALENDARSTATE_Disconnected']"
		[Register ("VIDYO_CALENDARSTATE_Disconnected")]
		public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState VIDYOCALENDARSTATEDisconnected {
			get {
				if (VIDYO_CALENDARSTATE_Disconnected_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSTATE_Disconnected_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSTATE_Disconnected", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSTATE_Disconnected_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSTATE_Disconnecting_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarState']/field[@name='VIDYO_CALENDARSTATE_Disconnecting']"
		[Register ("VIDYO_CALENDARSTATE_Disconnecting")]
		public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState VIDYOCALENDARSTATEDisconnecting {
			get {
				if (VIDYO_CALENDARSTATE_Disconnecting_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSTATE_Disconnecting_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSTATE_Disconnecting", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSTATE_Disconnecting_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSTATE_Initialized_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarState']/field[@name='VIDYO_CALENDARSTATE_Initialized']"
		[Register ("VIDYO_CALENDARSTATE_Initialized")]
		public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState VIDYOCALENDARSTATEInitialized {
			get {
				if (VIDYO_CALENDARSTATE_Initialized_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSTATE_Initialized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSTATE_Initialized", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSTATE_Initialized_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSTATE_Unavailable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarState']/field[@name='VIDYO_CALENDARSTATE_Unavailable']"
		[Register ("VIDYO_CALENDARSTATE_Unavailable")]
		public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState VIDYOCALENDARSTATEUnavailable {
			get {
				if (VIDYO_CALENDARSTATE_Unavailable_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSTATE_Unavailable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSTATE_Unavailable", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSTATE_Unavailable_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoCalendarState); }
		}

		internal VidyoCalendarState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;");
			try {
				return (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState));
			} finally {
			}
		}

	}
}
