using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoNetworkInterfaceInfo", DoNotGenerateAcw=true)]
	public partial class VidyoNetworkInterfaceInfo : global::Java.Lang.Object {


		static IntPtr address_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo']/field[@name='address']"
		[Register ("address")]
		public string Address {
			get {
				if (address_jfieldId == IntPtr.Zero)
					address_jfieldId = JNIEnv.GetFieldID (class_ref, "address", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, address_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (address_jfieldId == IntPtr.Zero)
					address_jfieldId = JNIEnv.GetFieldID (class_ref, "address", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, address_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr state_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo']/field[@name='state']"
		[Register ("state")]
		public global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState State {
			get {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, state_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, state_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo']/field[@name='type']"
		[Register ("type")]
		public global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoNetworkInterfaceState : global::Java.Lang.Enum {


			static IntPtr VIDYO_NETWORKINTERFACESTATE_Down_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState']/field[@name='VIDYO_NETWORKINTERFACESTATE_Down']"
			[Register ("VIDYO_NETWORKINTERFACESTATE_Down")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState VIDYONETWORKINTERFACESTATEDown {
				get {
					if (VIDYO_NETWORKINTERFACESTATE_Down_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACESTATE_Down_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACESTATE_Down", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACESTATE_Down_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACESTATE_Unknown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState']/field[@name='VIDYO_NETWORKINTERFACESTATE_Unknown']"
			[Register ("VIDYO_NETWORKINTERFACESTATE_Unknown")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState VIDYONETWORKINTERFACESTATEUnknown {
				get {
					if (VIDYO_NETWORKINTERFACESTATE_Unknown_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACESTATE_Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACESTATE_Unknown", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACESTATE_Unknown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACESTATE_Up_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState']/field[@name='VIDYO_NETWORKINTERFACESTATE_Up']"
			[Register ("VIDYO_NETWORKINTERFACESTATE_Up")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState VIDYONETWORKINTERFACESTATEUp {
				get {
					if (VIDYO_NETWORKINTERFACESTATE_Up_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACESTATE_Up_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACESTATE_Up", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACESTATE_Up_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceState;");
				try {
					return (global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceTransportType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoNetworkInterfaceTransportType : global::Java.Lang.Enum {


			static IntPtr VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType']/field[@name='VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data']"
			[Register ("VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType VIDYONETWORKINTERFACETRANSPORTTYPEData {
				get {
					if (VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceTransportType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETRANSPORTTYPE_Data_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType']/field[@name='VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media']"
			[Register ("VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType VIDYONETWORKINTERFACETRANSPORTTYPEMedia {
				get {
					if (VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceTransportType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETRANSPORTTYPE_Media_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType']/field[@name='VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling']"
			[Register ("VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType VIDYONETWORKINTERFACETRANSPORTTYPESignaling {
				get {
					if (VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceTransportType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETRANSPORTTYPE_Signaling_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceTransportType", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceTransportType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceTransportType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceTransportType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceTransportType;");
				try {
					return (global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceTransportType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoNetworkInterfaceType : global::Java.Lang.Enum {


			static IntPtr VIDYO_NETWORKINTERFACETYPE_Loopback_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_Loopback']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_Loopback")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPELoopback {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_Loopback_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_Loopback_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_Loopback", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_Loopback_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_NotApplicable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_NotApplicable']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_NotApplicable")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPENotApplicable {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_NotApplicable_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_NotApplicable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_NotApplicable", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_NotApplicable_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_Other_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_Other']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_Other")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPEOther {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_Other_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_Other_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_Other", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_Other_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_Tunneled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_Tunneled']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_Tunneled")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPETunneled {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_Tunneled_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_Tunneled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_Tunneled", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_Tunneled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_WiFi_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_WiFi']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_WiFi")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPEWiFi {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_WiFi_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_WiFi_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_WiFi", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_WiFi_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_Wired_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_Wired']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_Wired")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPEWired {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_Wired_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_Wired_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_Wired", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_Wired_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_NETWORKINTERFACETYPE_Wwan_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType']/field[@name='VIDYO_NETWORKINTERFACETYPE_Wwan']"
			[Register ("VIDYO_NETWORKINTERFACETYPE_Wwan")]
			public static global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType VIDYONETWORKINTERFACETYPEWwan {
				get {
					if (VIDYO_NETWORKINTERFACETYPE_Wwan_jfieldId == IntPtr.Zero)
						VIDYO_NETWORKINTERFACETYPE_Wwan_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_NETWORKINTERFACETYPE_Wwan", "Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_NETWORKINTERFACETYPE_Wwan_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/VidyoNetworkInterfaceInfo$VidyoNetworkInterfaceType;");
				try {
					return (global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.VidyoNetworkInterfaceInfo.VidyoNetworkInterfaceType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoNetworkInterfaceInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoNetworkInterfaceInfo); }
		}

		protected VidyoNetworkInterfaceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoNetworkInterfaceInfo']/constructor[@name='VidyoNetworkInterfaceInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoNetworkInterfaceInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoNetworkInterfaceInfo)) {
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
