using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoChatMessage", DoNotGenerateAcw=true)]
	public partial class VidyoChatMessage : global::Java.Lang.Object {


		static IntPtr body_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage']/field[@name='body']"
		[Register ("body")]
		public string Body {
			get {
				if (body_jfieldId == IntPtr.Zero)
					body_jfieldId = JNIEnv.GetFieldID (class_ref, "body", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, body_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (body_jfieldId == IntPtr.Zero)
					body_jfieldId = JNIEnv.GetFieldID (class_ref, "body", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, body_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage']/field[@name='id']"
		[Register ("id")]
		public long Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr senderType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage']/field[@name='senderType']"
		[Register ("senderType")]
		public global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType SenderType {
			get {
				if (senderType_jfieldId == IntPtr.Zero)
					senderType_jfieldId = JNIEnv.GetFieldID (class_ref, "senderType", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, senderType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (senderType_jfieldId == IntPtr.Zero)
					senderType_jfieldId = JNIEnv.GetFieldID (class_ref, "senderType", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, senderType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage']/field[@name='timestamp']"
		[Register ("timestamp")]
		public long Timestamp {
			get {
				if (timestamp_jfieldId == IntPtr.Zero)
					timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId);
			}
			set {
				if (timestamp_jfieldId == IntPtr.Zero)
					timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage']/field[@name='type']"
		[Register ("type")]
		public global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr userId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage']/field[@name='userId']"
		[Register ("userId")]
		public string UserId {
			get {
				if (userId_jfieldId == IntPtr.Zero)
					userId_jfieldId = JNIEnv.GetFieldID (class_ref, "userId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, userId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (userId_jfieldId == IntPtr.Zero)
					userId_jfieldId = JNIEnv.GetFieldID (class_ref, "userId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, userId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageSenderType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoChatMessageSenderType : global::Java.Lang.Enum {


			static IntPtr VIDYO_CHATMESSAGESENDERTYPE_None_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageSenderType']/field[@name='VIDYO_CHATMESSAGESENDERTYPE_None']"
			[Register ("VIDYO_CHATMESSAGESENDERTYPE_None")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType VIDYOCHATMESSAGESENDERTYPENone {
				get {
					if (VIDYO_CHATMESSAGESENDERTYPE_None_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGESENDERTYPE_None_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGESENDERTYPE_None", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGESENDERTYPE_None_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CHATMESSAGESENDERTYPE_Room_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageSenderType']/field[@name='VIDYO_CHATMESSAGESENDERTYPE_Room']"
			[Register ("VIDYO_CHATMESSAGESENDERTYPE_Room")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType VIDYOCHATMESSAGESENDERTYPERoom {
				get {
					if (VIDYO_CHATMESSAGESENDERTYPE_Room_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGESENDERTYPE_Room_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGESENDERTYPE_Room", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGESENDERTYPE_Room_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CHATMESSAGESENDERTYPE_System_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageSenderType']/field[@name='VIDYO_CHATMESSAGESENDERTYPE_System']"
			[Register ("VIDYO_CHATMESSAGESENDERTYPE_System")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType VIDYOCHATMESSAGESENDERTYPESystem {
				get {
					if (VIDYO_CHATMESSAGESENDERTYPE_System_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGESENDERTYPE_System_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGESENDERTYPE_System", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGESENDERTYPE_System_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CHATMESSAGESENDERTYPE_User_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageSenderType']/field[@name='VIDYO_CHATMESSAGESENDERTYPE_User']"
			[Register ("VIDYO_CHATMESSAGESENDERTYPE_User")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType VIDYOCHATMESSAGESENDERTYPEUser {
				get {
					if (VIDYO_CHATMESSAGESENDERTYPE_User_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGESENDERTYPE_User_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGESENDERTYPE_User", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGESENDERTYPE_User_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoChatMessageSenderType); }
			}

			internal VidyoChatMessageSenderType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageSenderType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageSenderType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageSenderType;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageSenderType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoChatMessageType : global::Java.Lang.Enum {


			static IntPtr VIDYO_CHATMESSAGETYPE_Chat_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageType']/field[@name='VIDYO_CHATMESSAGETYPE_Chat']"
			[Register ("VIDYO_CHATMESSAGETYPE_Chat")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType VIDYOCHATMESSAGETYPEChat {
				get {
					if (VIDYO_CHATMESSAGETYPE_Chat_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGETYPE_Chat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGETYPE_Chat", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGETYPE_Chat_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CHATMESSAGETYPE_MediaStart_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageType']/field[@name='VIDYO_CHATMESSAGETYPE_MediaStart']"
			[Register ("VIDYO_CHATMESSAGETYPE_MediaStart")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType VIDYOCHATMESSAGETYPEMediaStart {
				get {
					if (VIDYO_CHATMESSAGETYPE_MediaStart_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGETYPE_MediaStart_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGETYPE_MediaStart", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGETYPE_MediaStart_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CHATMESSAGETYPE_MediaStop_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageType']/field[@name='VIDYO_CHATMESSAGETYPE_MediaStop']"
			[Register ("VIDYO_CHATMESSAGETYPE_MediaStop")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType VIDYOCHATMESSAGETYPEMediaStop {
				get {
					if (VIDYO_CHATMESSAGETYPE_MediaStop_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGETYPE_MediaStop_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGETYPE_MediaStop", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGETYPE_MediaStop_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoChatMessageType); }
			}

			internal VidyoChatMessageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageType;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageTypingIndication']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication", DoNotGenerateAcw=true)]
		public sealed partial class VidyoChatMessageTypingIndication : global::Java.Lang.Enum {


			static IntPtr VIDYO_CHATMESSAGETYPINGINDICATION_Active_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageTypingIndication']/field[@name='VIDYO_CHATMESSAGETYPINGINDICATION_Active']"
			[Register ("VIDYO_CHATMESSAGETYPINGINDICATION_Active")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication VIDYOCHATMESSAGETYPINGINDICATIONActive {
				get {
					if (VIDYO_CHATMESSAGETYPINGINDICATION_Active_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGETYPINGINDICATION_Active_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGETYPINGINDICATION_Active", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGETYPINGINDICATION_Active_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CHATMESSAGETYPINGINDICATION_Composing_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageTypingIndication']/field[@name='VIDYO_CHATMESSAGETYPINGINDICATION_Composing']"
			[Register ("VIDYO_CHATMESSAGETYPINGINDICATION_Composing")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication VIDYOCHATMESSAGETYPINGINDICATIONComposing {
				get {
					if (VIDYO_CHATMESSAGETYPINGINDICATION_Composing_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGETYPINGINDICATION_Composing_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGETYPINGINDICATION_Composing", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGETYPINGINDICATION_Composing_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CHATMESSAGETYPINGINDICATION_Gone_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageTypingIndication']/field[@name='VIDYO_CHATMESSAGETYPINGINDICATION_Gone']"
			[Register ("VIDYO_CHATMESSAGETYPINGINDICATION_Gone")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication VIDYOCHATMESSAGETYPINGINDICATIONGone {
				get {
					if (VIDYO_CHATMESSAGETYPINGINDICATION_Gone_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGETYPINGINDICATION_Gone_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGETYPINGINDICATION_Gone", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGETYPINGINDICATION_Gone_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CHATMESSAGETYPINGINDICATION_Inactive_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageTypingIndication']/field[@name='VIDYO_CHATMESSAGETYPINGINDICATION_Inactive']"
			[Register ("VIDYO_CHATMESSAGETYPINGINDICATION_Inactive")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication VIDYOCHATMESSAGETYPINGINDICATIONInactive {
				get {
					if (VIDYO_CHATMESSAGETYPINGINDICATION_Inactive_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGETYPINGINDICATION_Inactive_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGETYPINGINDICATION_Inactive", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGETYPINGINDICATION_Inactive_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CHATMESSAGETYPINGINDICATION_None_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageTypingIndication']/field[@name='VIDYO_CHATMESSAGETYPINGINDICATION_None']"
			[Register ("VIDYO_CHATMESSAGETYPINGINDICATION_None")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication VIDYOCHATMESSAGETYPINGINDICATIONNone {
				get {
					if (VIDYO_CHATMESSAGETYPINGINDICATION_None_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGETYPINGINDICATION_None_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGETYPINGINDICATION_None", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGETYPINGINDICATION_None_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CHATMESSAGETYPINGINDICATION_Paused_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageTypingIndication']/field[@name='VIDYO_CHATMESSAGETYPINGINDICATION_Paused']"
			[Register ("VIDYO_CHATMESSAGETYPINGINDICATION_Paused")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication VIDYOCHATMESSAGETYPINGINDICATIONPaused {
				get {
					if (VIDYO_CHATMESSAGETYPINGINDICATION_Paused_jfieldId == IntPtr.Zero)
						VIDYO_CHATMESSAGETYPINGINDICATION_Paused_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CHATMESSAGETYPINGINDICATION_Paused", "Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CHATMESSAGETYPINGINDICATION_Paused_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoChatMessageTypingIndication); }
			}

			internal VidyoChatMessageTypingIndication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageTypingIndication']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage.VidyoChatMessageTypingIndication']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoChatMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoChatMessage); }
		}

		protected VidyoChatMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoChatMessage']/constructor[@name='VidyoChatMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoChatMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoChatMessage)) {
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
