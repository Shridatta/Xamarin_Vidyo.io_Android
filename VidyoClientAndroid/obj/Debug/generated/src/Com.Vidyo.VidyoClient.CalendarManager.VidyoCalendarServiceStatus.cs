using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus", DoNotGenerateAcw=true)]
	public sealed partial class VidyoCalendarServiceStatus : global::Java.Lang.Enum {


		static IntPtr VIDYO_CALENDARSERVICESTATUS_ApiProcError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/field[@name='VIDYO_CALENDARSERVICESTATUS_ApiProcError']"
		[Register ("VIDYO_CALENDARSERVICESTATUS_ApiProcError")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus VIDYOCALENDARSERVICESTATUSApiProcError {
			get {
				if (VIDYO_CALENDARSERVICESTATUS_ApiProcError_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSERVICESTATUS_ApiProcError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSERVICESTATUS_ApiProcError", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSERVICESTATUS_ApiProcError_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSERVICESTATUS_Available_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/field[@name='VIDYO_CALENDARSERVICESTATUS_Available']"
		[Register ("VIDYO_CALENDARSERVICESTATUS_Available")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus VIDYOCALENDARSERVICESTATUSAvailable {
			get {
				if (VIDYO_CALENDARSERVICESTATUS_Available_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSERVICESTATUS_Available_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSERVICESTATUS_Available", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSERVICESTATUS_Available_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSERVICESTATUS_DllNotFound_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/field[@name='VIDYO_CALENDARSERVICESTATUS_DllNotFound']"
		[Register ("VIDYO_CALENDARSERVICESTATUS_DllNotFound")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus VIDYOCALENDARSERVICESTATUSDllNotFound {
			get {
				if (VIDYO_CALENDARSERVICESTATUS_DllNotFound_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSERVICESTATUS_DllNotFound_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSERVICESTATUS_DllNotFound", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSERVICESTATUS_DllNotFound_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSERVICESTATUS_Init_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/field[@name='VIDYO_CALENDARSERVICESTATUS_Init']"
		[Register ("VIDYO_CALENDARSERVICESTATUS_Init")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus VIDYOCALENDARSERVICESTATUSInit {
			get {
				if (VIDYO_CALENDARSERVICESTATUS_Init_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSERVICESTATUS_Init_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSERVICESTATUS_Init", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSERVICESTATUS_Init_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSERVICESTATUS_LoadError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/field[@name='VIDYO_CALENDARSERVICESTATUS_LoadError']"
		[Register ("VIDYO_CALENDARSERVICESTATUS_LoadError")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus VIDYOCALENDARSERVICESTATUSLoadError {
			get {
				if (VIDYO_CALENDARSERVICESTATUS_LoadError_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSERVICESTATUS_LoadError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSERVICESTATUS_LoadError", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSERVICESTATUS_LoadError_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSERVICESTATUS_Loaded_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/field[@name='VIDYO_CALENDARSERVICESTATUS_Loaded']"
		[Register ("VIDYO_CALENDARSERVICESTATUS_Loaded")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus VIDYOCALENDARSERVICESTATUSLoaded {
			get {
				if (VIDYO_CALENDARSERVICESTATUS_Loaded_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSERVICESTATUS_Loaded_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSERVICESTATUS_Loaded", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSERVICESTATUS_Loaded_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSERVICESTATUS_PluginSvcAuthRequired_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/field[@name='VIDYO_CALENDARSERVICESTATUS_PluginSvcAuthRequired']"
		[Register ("VIDYO_CALENDARSERVICESTATUS_PluginSvcAuthRequired")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus VIDYOCALENDARSERVICESTATUSPluginSvcAuthRequired {
			get {
				if (VIDYO_CALENDARSERVICESTATUS_PluginSvcAuthRequired_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSERVICESTATUS_PluginSvcAuthRequired_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSERVICESTATUS_PluginSvcAuthRequired", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSERVICESTATUS_PluginSvcAuthRequired_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSERVICESTATUS_PluginSvcNotActive_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/field[@name='VIDYO_CALENDARSERVICESTATUS_PluginSvcNotActive']"
		[Register ("VIDYO_CALENDARSERVICESTATUS_PluginSvcNotActive")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus VIDYOCALENDARSERVICESTATUSPluginSvcNotActive {
			get {
				if (VIDYO_CALENDARSERVICESTATUS_PluginSvcNotActive_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSERVICESTATUS_PluginSvcNotActive_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSERVICESTATUS_PluginSvcNotActive", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSERVICESTATUS_PluginSvcNotActive_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSERVICESTATUS_PluginSvcNotInstalled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/field[@name='VIDYO_CALENDARSERVICESTATUS_PluginSvcNotInstalled']"
		[Register ("VIDYO_CALENDARSERVICESTATUS_PluginSvcNotInstalled")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus VIDYOCALENDARSERVICESTATUSPluginSvcNotInstalled {
			get {
				if (VIDYO_CALENDARSERVICESTATUS_PluginSvcNotInstalled_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSERVICESTATUS_PluginSvcNotInstalled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSERVICESTATUS_PluginSvcNotInstalled", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSERVICESTATUS_PluginSvcNotInstalled_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDYO_CALENDARSERVICESTATUS_Unloaded_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/field[@name='VIDYO_CALENDARSERVICESTATUS_Unloaded']"
		[Register ("VIDYO_CALENDARSERVICESTATUS_Unloaded")]
		public static global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus VIDYOCALENDARSERVICESTATUSUnloaded {
			get {
				if (VIDYO_CALENDARSERVICESTATUS_Unloaded_jfieldId == IntPtr.Zero)
					VIDYO_CALENDARSERVICESTATUS_Unloaded_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARSERVICESTATUS_Unloaded", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARSERVICESTATUS_Unloaded_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoCalendarServiceStatus); }
		}

		internal VidyoCalendarServiceStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarServiceStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;", "")]
		public static unsafe global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;");
			try {
				return (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus));
			} finally {
			}
		}

	}
}
