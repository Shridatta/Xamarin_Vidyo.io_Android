using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoDevice", DoNotGenerateAcw=true)]
	public partial class VidyoDevice : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceAudioSignalType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoDeviceAudioSignalType : global::Java.Lang.Enum {


			static IntPtr VIDYO_DEVICEAUDIOSIGNALTYPE_Unprocessed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceAudioSignalType']/field[@name='VIDYO_DEVICEAUDIOSIGNALTYPE_Unprocessed']"
			[Register ("VIDYO_DEVICEAUDIOSIGNALTYPE_Unprocessed")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType VIDYODEVICEAUDIOSIGNALTYPEUnprocessed {
				get {
					if (VIDYO_DEVICEAUDIOSIGNALTYPE_Unprocessed_jfieldId == IntPtr.Zero)
						VIDYO_DEVICEAUDIOSIGNALTYPE_Unprocessed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICEAUDIOSIGNALTYPE_Unprocessed", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICEAUDIOSIGNALTYPE_Unprocessed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICEAUDIOSIGNALTYPE_Voice_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceAudioSignalType']/field[@name='VIDYO_DEVICEAUDIOSIGNALTYPE_Voice']"
			[Register ("VIDYO_DEVICEAUDIOSIGNALTYPE_Voice")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType VIDYODEVICEAUDIOSIGNALTYPEVoice {
				get {
					if (VIDYO_DEVICEAUDIOSIGNALTYPE_Voice_jfieldId == IntPtr.Zero)
						VIDYO_DEVICEAUDIOSIGNALTYPE_Voice_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICEAUDIOSIGNALTYPE_Voice", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICEAUDIOSIGNALTYPE_Voice_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoDeviceAudioSignalType); }
			}

			internal VidyoDeviceAudioSignalType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceAudioSignalType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceAudioSignalType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;");
				try {
					return (global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoDeviceState : global::Java.Lang.Enum {


			static IntPtr VIDYO_DEVICESTATE_Added_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Added']"
			[Register ("VIDYO_DEVICESTATE_Added")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEAdded {
				get {
					if (VIDYO_DEVICESTATE_Added_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Added_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Added", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Added_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_Available_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Available']"
			[Register ("VIDYO_DEVICESTATE_Available")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEAvailable {
				get {
					if (VIDYO_DEVICESTATE_Available_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Available_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Available", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Available_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_ConfigureError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_ConfigureError']"
			[Register ("VIDYO_DEVICESTATE_ConfigureError")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEConfigureError {
				get {
					if (VIDYO_DEVICESTATE_ConfigureError_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_ConfigureError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_ConfigureError", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_ConfigureError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_ConfigureSuccess_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_ConfigureSuccess']"
			[Register ("VIDYO_DEVICESTATE_ConfigureSuccess")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEConfigureSuccess {
				get {
					if (VIDYO_DEVICESTATE_ConfigureSuccess_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_ConfigureSuccess_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_ConfigureSuccess", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_ConfigureSuccess_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_Controllable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Controllable']"
			[Register ("VIDYO_DEVICESTATE_Controllable")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEControllable {
				get {
					if (VIDYO_DEVICESTATE_Controllable_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Controllable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Controllable", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Controllable_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_DefaultChanged_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_DefaultChanged']"
			[Register ("VIDYO_DEVICESTATE_DefaultChanged")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEDefaultChanged {
				get {
					if (VIDYO_DEVICESTATE_DefaultChanged_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_DefaultChanged_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_DefaultChanged", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_DefaultChanged_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_Error_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Error']"
			[Register ("VIDYO_DEVICESTATE_Error")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEError {
				get {
					if (VIDYO_DEVICESTATE_Error_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Error", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Error_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_InUse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_InUse']"
			[Register ("VIDYO_DEVICESTATE_InUse")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEInUse {
				get {
					if (VIDYO_DEVICESTATE_InUse_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_InUse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_InUse", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_InUse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_NotControllable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_NotControllable']"
			[Register ("VIDYO_DEVICESTATE_NotControllable")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATENotControllable {
				get {
					if (VIDYO_DEVICESTATE_NotControllable_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_NotControllable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_NotControllable", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_NotControllable_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_Paused_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Paused']"
			[Register ("VIDYO_DEVICESTATE_Paused")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEPaused {
				get {
					if (VIDYO_DEVICESTATE_Paused_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Paused_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Paused", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Paused_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_Removed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Removed']"
			[Register ("VIDYO_DEVICESTATE_Removed")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATERemoved {
				get {
					if (VIDYO_DEVICESTATE_Removed_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Removed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Removed", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Removed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_Resumed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Resumed']"
			[Register ("VIDYO_DEVICESTATE_Resumed")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEResumed {
				get {
					if (VIDYO_DEVICESTATE_Resumed_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Resumed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Resumed", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Resumed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_Started_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Started']"
			[Register ("VIDYO_DEVICESTATE_Started")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEStarted {
				get {
					if (VIDYO_DEVICESTATE_Started_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Started_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Started", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Started_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_Stopped_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Stopped']"
			[Register ("VIDYO_DEVICESTATE_Stopped")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEStopped {
				get {
					if (VIDYO_DEVICESTATE_Stopped_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Stopped_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Stopped", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Stopped_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_Suspended_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Suspended']"
			[Register ("VIDYO_DEVICESTATE_Suspended")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATESuspended {
				get {
					if (VIDYO_DEVICESTATE_Suspended_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Suspended_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Suspended", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Suspended_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICESTATE_Unsuspended_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/field[@name='VIDYO_DEVICESTATE_Unsuspended']"
			[Register ("VIDYO_DEVICESTATE_Unsuspended")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState VIDYODEVICESTATEUnsuspended {
				get {
					if (VIDYO_DEVICESTATE_Unsuspended_jfieldId == IntPtr.Zero)
						VIDYO_DEVICESTATE_Unsuspended_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICESTATE_Unsuspended", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICESTATE_Unsuspended_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoDeviceState); }
			}

			internal VidyoDeviceState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;");
				try {
					return (global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoDeviceType : global::Java.Lang.Enum {


			static IntPtr VIDYO_DEVICETYPE_LocalCamera_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_LocalCamera']"
			[Register ("VIDYO_DEVICETYPE_LocalCamera")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPELocalCamera {
				get {
					if (VIDYO_DEVICETYPE_LocalCamera_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_LocalCamera_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_LocalCamera", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_LocalCamera_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICETYPE_LocalMicrophone_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_LocalMicrophone']"
			[Register ("VIDYO_DEVICETYPE_LocalMicrophone")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPELocalMicrophone {
				get {
					if (VIDYO_DEVICETYPE_LocalMicrophone_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_LocalMicrophone_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_LocalMicrophone", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_LocalMicrophone_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICETYPE_LocalMonitor_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_LocalMonitor']"
			[Register ("VIDYO_DEVICETYPE_LocalMonitor")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPELocalMonitor {
				get {
					if (VIDYO_DEVICETYPE_LocalMonitor_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_LocalMonitor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_LocalMonitor", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_LocalMonitor_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICETYPE_LocalRenderer_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_LocalRenderer']"
			[Register ("VIDYO_DEVICETYPE_LocalRenderer")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPELocalRenderer {
				get {
					if (VIDYO_DEVICETYPE_LocalRenderer_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_LocalRenderer_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_LocalRenderer", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_LocalRenderer_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICETYPE_LocalSpeaker_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_LocalSpeaker']"
			[Register ("VIDYO_DEVICETYPE_LocalSpeaker")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPELocalSpeaker {
				get {
					if (VIDYO_DEVICETYPE_LocalSpeaker_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_LocalSpeaker_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_LocalSpeaker", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_LocalSpeaker_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICETYPE_LocalWindowShare_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_LocalWindowShare']"
			[Register ("VIDYO_DEVICETYPE_LocalWindowShare")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPELocalWindowShare {
				get {
					if (VIDYO_DEVICETYPE_LocalWindowShare_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_LocalWindowShare_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_LocalWindowShare", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_LocalWindowShare_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICETYPE_RemoteCamera_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_RemoteCamera']"
			[Register ("VIDYO_DEVICETYPE_RemoteCamera")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPERemoteCamera {
				get {
					if (VIDYO_DEVICETYPE_RemoteCamera_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_RemoteCamera_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_RemoteCamera", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_RemoteCamera_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICETYPE_RemoteMicrophone_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_RemoteMicrophone']"
			[Register ("VIDYO_DEVICETYPE_RemoteMicrophone")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPERemoteMicrophone {
				get {
					if (VIDYO_DEVICETYPE_RemoteMicrophone_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_RemoteMicrophone_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_RemoteMicrophone", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_RemoteMicrophone_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICETYPE_RemoteRenderer_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_RemoteRenderer']"
			[Register ("VIDYO_DEVICETYPE_RemoteRenderer")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPERemoteRenderer {
				get {
					if (VIDYO_DEVICETYPE_RemoteRenderer_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_RemoteRenderer_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_RemoteRenderer", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_RemoteRenderer_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICETYPE_RemoteSpeaker_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_RemoteSpeaker']"
			[Register ("VIDYO_DEVICETYPE_RemoteSpeaker")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPERemoteSpeaker {
				get {
					if (VIDYO_DEVICETYPE_RemoteSpeaker_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_RemoteSpeaker_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_RemoteSpeaker", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_RemoteSpeaker_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_DEVICETYPE_RemoteWindowShare_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/field[@name='VIDYO_DEVICETYPE_RemoteWindowShare']"
			[Register ("VIDYO_DEVICETYPE_RemoteWindowShare")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType VIDYODEVICETYPERemoteWindowShare {
				get {
					if (VIDYO_DEVICETYPE_RemoteWindowShare_jfieldId == IntPtr.Zero)
						VIDYO_DEVICETYPE_RemoteWindowShare_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_DEVICETYPE_RemoteWindowShare", "Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_DEVICETYPE_RemoteWindowShare_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoDeviceType); }
			}

			internal VidyoDeviceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice.VidyoDeviceType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
				try {
					return (global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoDevice", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoDevice); }
		}

		protected VidyoDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice']/constructor[@name='VidyoDevice' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoDevice (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoDevice)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_GetId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_GetId == null)
				cb_GetId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_GetId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice']/method[@name='GetId' and count(parameter)=0]"
			[Register ("GetId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_GetId == IntPtr.Zero)
					id_GetId = JNIEnv.GetMethodID (class_ref, "GetId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_GetName == null)
				cb_GetName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_GetName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_GetName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice']/method[@name='GetName' and count(parameter)=0]"
			[Register ("GetName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_GetName == IntPtr.Zero)
					id_GetName = JNIEnv.GetMethodID (class_ref, "GetName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetObjectPtr;
#pragma warning disable 0169
		static Delegate GetGetObjectPtrHandler ()
		{
			if (cb_GetObjectPtr == null)
				cb_GetObjectPtr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetObjectPtr);
			return cb_GetObjectPtr;
		}

		static long n_GetObjectPtr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice']/method[@name='GetObjectPtr' and count(parameter)=0]"
			[Register ("GetObjectPtr", "()J", "GetGetObjectPtrHandler")]
			get {
				if (id_GetObjectPtr == IntPtr.Zero)
					id_GetObjectPtr = JNIEnv.GetMethodID (class_ref, "GetObjectPtr", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_GetObjectPtr);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetObjectPtr", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_GetType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_GetType == null)
				cb_GetType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_GetType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_GetType;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice']/method[@name='GetType' and count(parameter)=0]"
			[Register ("GetType", "()Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;", "GetGetTypeHandler")]
			get {
				if (id_GetType == IntPtr.Zero)
					id_GetType = JNIEnv.GetMethodID (class_ref, "GetType", "()Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetType", "()Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_Assign;
#pragma warning disable 0169
		static Delegate GetAssignHandler ()
		{
			if (cb_Assign == null)
				cb_Assign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Assign);
			return cb_Assign;
		}

		static IntPtr n_Assign (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Assign ());
		}
#pragma warning restore 0169

		static IntPtr id_Assign;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice']/method[@name='Assign' and count(parameter)=0]"
		[Register ("Assign", "()Lcom/vidyo/VidyoClient/Device/VidyoDevice;", "GetAssignHandler")]
		public virtual unsafe global::Com.Vidyo.VidyoClient.Device.VidyoDevice Assign ()
		{
			if (id_Assign == IntPtr.Zero)
				id_Assign = JNIEnv.GetMethodID (class_ref, "Assign", "()Lcom/vidyo/VidyoClient/Device/VidyoDevice;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_Assign), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Assign", "()Lcom/vidyo/VidyoClient/Device/VidyoDevice;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_DerivedEqual;
#pragma warning disable 0169
		static Delegate GetDerivedEqualHandler ()
		{
			if (cb_DerivedEqual == null)
				cb_DerivedEqual = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DerivedEqual);
			return cb_DerivedEqual;
		}

		static bool n_DerivedEqual (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DerivedEqual ();
		}
#pragma warning restore 0169

		static IntPtr id_DerivedEqual;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice']/method[@name='DerivedEqual' and count(parameter)=0]"
		[Register ("DerivedEqual", "()Z", "GetDerivedEqualHandler")]
		public virtual unsafe bool DerivedEqual ()
		{
			if (id_DerivedEqual == IntPtr.Zero)
				id_DerivedEqual = JNIEnv.GetMethodID (class_ref, "DerivedEqual", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_DerivedEqual);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DerivedEqual", "()Z"));
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoDevice']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		protected virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

	}
}
