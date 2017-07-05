using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoNetworkInterface", DoNotGenerateAcw=true)]
	public partial class VidyoNetworkInterface : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceFamily']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily", DoNotGenerateAcw=true)]
		public sealed partial class VidyoNetworkInterfaceFamily : global::Java.Lang.Enum {


			static IntPtr VIDYO_NETWORKINTERFACEFAMILY_IPV4_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceFamily']/field[@name='VIDYO_NETWORKINTERFACEFAMILY_IPV4']"
			[Register ("VIDYO_NETWORKINTERFACEFAMILY_IPV4")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily VidyoNetworkinterfacefamilyIpv4 {
				get {
					if (VIDYO_NETWORKINTERFACEFAMILY_IPV4_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACEFAMILY_IPV4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACEFAMILY_IPV4", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACEFAMILY_IPV4_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACEFAMILY_IPV6_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceFamily']/field[@name='VIDYO_NETWORKINTERFACEFAMILY_IPV6']"
			[Register ("VIDYO_NETWORKINTERFACEFAMILY_IPV6")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily VidyoNetworkinterfacefamilyIpv6 {
				get {
					if (VIDYO_NETWORKINTERFACEFAMILY_IPV6_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACEFAMILY_IPV6_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACEFAMILY_IPV6", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACEFAMILY_IPV6_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACEFAMILY_Unspecified_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceFamily']/field[@name='VIDYO_NETWORKINTERFACEFAMILY_Unspecified']"
			[Register ("VIDYO_NETWORKINTERFACEFAMILY_Unspecified")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily VIDYONETWORKINTERFACEFAMILYUnspecified {
				get {
					if (VIDYO_NETWORKINTERFACEFAMILY_Unspecified_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACEFAMILY_Unspecified_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACEFAMILY_Unspecified", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACEFAMILY_Unspecified_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoNetworkInterfaceFamily); }
			}

			internal VidyoNetworkInterfaceFamily (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceFamily']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceFamily']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily;");
				try {
					return (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoNetworkInterfaceState : global::Java.Lang.Enum {


			static IntPtr VIDYO_NETWORKINTERFACESTATE_Down_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceState']/field[@name='VIDYO_NETWORKINTERFACESTATE_Down']"
			[Register ("VIDYO_NETWORKINTERFACESTATE_Down")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState VIDYONETWORKINTERFACESTATEDown {
				get {
					if (VIDYO_NETWORKINTERFACESTATE_Down_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACESTATE_Down_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACESTATE_Down", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACESTATE_Down_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACESTATE_Unknown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceState']/field[@name='VIDYO_NETWORKINTERFACESTATE_Unknown']"
			[Register ("VIDYO_NETWORKINTERFACESTATE_Unknown")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState VIDYONETWORKINTERFACESTATEUnknown {
				get {
					if (VIDYO_NETWORKINTERFACESTATE_Unknown_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACESTATE_Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACESTATE_Unknown", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACESTATE_Unknown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACESTATE_Up_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceState']/field[@name='VIDYO_NETWORKINTERFACESTATE_Up']"
			[Register ("VIDYO_NETWORKINTERFACESTATE_Up")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState VIDYONETWORKINTERFACESTATEUp {
				get {
					if (VIDYO_NETWORKINTERFACESTATE_Up_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACESTATE_Up_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACESTATE_Up", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACESTATE_Up_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoNetworkInterfaceState); }
			}

			internal VidyoNetworkInterfaceState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;");
				try {
					return (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceTransportType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoNetworkInterfaceTransportType : global::Java.Lang.Enum {


			static IntPtr VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceTransportType']/field[@name='VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data']"
			[Register ("VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType VIDYONETWORKINTERFACETRANSPORTTYPEData {
				get {
					if (VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceTransportType']/field[@name='VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media']"
			[Register ("VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType VIDYONETWORKINTERFACETRANSPORTTYPEMedia {
				get {
					if (VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceTransportType']/field[@name='VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling']"
			[Register ("VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType VIDYONETWORKINTERFACETRANSPORTTYPESignaling {
				get {
					if (VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoNetworkInterfaceTransportType); }
			}

			internal VidyoNetworkInterfaceTransportType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceTransportType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceTransportType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;");
				try {
					return (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoNetworkInterfaceType : global::Java.Lang.Enum {


			static IntPtr VIDYO_NETWORKINTERFACETYPE_Loopback_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_Loopback']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_Loopback")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPELoopback {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_Loopback_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_Loopback_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_Loopback", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_Loopback_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_NotApplicable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_NotApplicable']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_NotApplicable")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPENotApplicable {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_NotApplicable_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_NotApplicable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_NotApplicable", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_NotApplicable_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_Other_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_Other']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_Other")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPEOther {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_Other_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_Other_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_Other", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_Other_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_Tunneled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_Tunneled']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_Tunneled")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPETunneled {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_Tunneled_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_Tunneled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_Tunneled", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_Tunneled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_WiFi_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_WiFi']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_WiFi")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPEWiFi {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_WiFi_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_WiFi_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_WiFi", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_WiFi_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_Wired_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_Wired']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_Wired")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPEWired {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_Wired_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_Wired_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_Wired", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_Wired_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_Wwan_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_Wwan']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_Wwan")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPEWwan {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_Wwan_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_Wwan_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_Wwan", "Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_Wwan_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoNetworkInterfaceType); }
			}

			internal VidyoNetworkInterfaceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface.VidyoNetworkInterfaceType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;");
				try {
					return (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoNetworkInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoNetworkInterface); }
		}

		protected VidyoNetworkInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface']/constructor[@name='VidyoNetworkInterface' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoNetworkInterface (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoNetworkInterface)) {
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

		static Delegate cb_GetAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_GetAddress == null)
				cb_GetAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_GetAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static IntPtr id_GetAddress;
		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface']/method[@name='GetAddress' and count(parameter)=0]"
			[Register ("GetAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				if (id_GetAddress == IntPtr.Zero)
					id_GetAddress = JNIEnv.GetMethodID (class_ref, "GetAddress", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetFamily;
#pragma warning disable 0169
		static Delegate GetGetFamilyHandler ()
		{
			if (cb_GetFamily == null)
				cb_GetFamily = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFamily);
			return cb_GetFamily;
		}

		static IntPtr n_GetFamily (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Family);
		}
#pragma warning restore 0169

		static IntPtr id_GetFamily;
		public virtual unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily Family {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface']/method[@name='GetFamily' and count(parameter)=0]"
			[Register ("GetFamily", "()Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily;", "GetGetFamilyHandler")]
			get {
				if (id_GetFamily == IntPtr.Zero)
					id_GetFamily = JNIEnv.GetMethodID (class_ref, "GetFamily", "()Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetFamily), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceFamily> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFamily", "()Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceFamily;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_GetName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface']/method[@name='GetName' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_GetState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_GetState == null)
				cb_GetState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_GetState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_GetState;
		public virtual unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface']/method[@name='GetState' and count(parameter)=0]"
			[Register ("GetState", "()Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;", "GetGetStateHandler")]
			get {
				if (id_GetState == IntPtr.Zero)
					id_GetState = JNIEnv.GetMethodID (class_ref, "GetState", "()Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetState", "()Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_GetType;
		public virtual unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface']/method[@name='GetType' and count(parameter)=0]"
			[Register ("GetType", "()Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;", "GetGetTypeHandler")]
			get {
				if (id_GetType == IntPtr.Zero)
					id_GetType = JNIEnv.GetMethodID (class_ref, "GetType", "()Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetType", "()Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterface']/method[@name='dispose' and count(parameter)=0]"
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
