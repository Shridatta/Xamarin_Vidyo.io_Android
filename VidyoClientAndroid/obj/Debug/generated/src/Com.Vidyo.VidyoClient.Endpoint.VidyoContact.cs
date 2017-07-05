using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoContact", DoNotGenerateAcw=true)]
	public partial class VidyoContact : global::Java.Lang.Object {


		static IntPtr emails_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='emails']"
		[Register ("emails")]
		public global::System.Collections.IList Emails {
			get {
				if (emails_jfieldId == IntPtr.Zero)
					emails_jfieldId = JNIEnv.GetFieldID (class_ref, "emails", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, emails_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (emails_jfieldId == IntPtr.Zero)
					emails_jfieldId = JNIEnv.GetFieldID (class_ref, "emails", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, emails_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr groups_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='groups']"
		[Register ("groups")]
		public global::System.Collections.IList Groups {
			get {
				if (groups_jfieldId == IntPtr.Zero)
					groups_jfieldId = JNIEnv.GetFieldID (class_ref, "groups", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, groups_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (groups_jfieldId == IntPtr.Zero)
					groups_jfieldId = JNIEnv.GetFieldID (class_ref, "groups", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, groups_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr handle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='handle']"
		[Register ("handle")]
		public string Handle {
			get {
				if (handle_jfieldId == IntPtr.Zero)
					handle_jfieldId = JNIEnv.GetFieldID (class_ref, "handle", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, handle_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (handle_jfieldId == IntPtr.Zero)
					handle_jfieldId = JNIEnv.GetFieldID (class_ref, "handle", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, handle_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='name']"
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

		static IntPtr nickname_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='nickname']"
		[Register ("nickname")]
		public string Nickname {
			get {
				if (nickname_jfieldId == IntPtr.Zero)
					nickname_jfieldId = JNIEnv.GetFieldID (class_ref, "nickname", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, nickname_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (nickname_jfieldId == IntPtr.Zero)
					nickname_jfieldId = JNIEnv.GetFieldID (class_ref, "nickname", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nickname_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr photo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='photo']"
		[Register ("photo")]
		public string Photo {
			get {
				if (photo_jfieldId == IntPtr.Zero)
					photo_jfieldId = JNIEnv.GetFieldID (class_ref, "photo", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, photo_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (photo_jfieldId == IntPtr.Zero)
					photo_jfieldId = JNIEnv.GetFieldID (class_ref, "photo", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, photo_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr presenceState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='presenceState']"
		[Register ("presenceState")]
		public global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState PresenceState {
			get {
				if (presenceState_jfieldId == IntPtr.Zero)
					presenceState_jfieldId = JNIEnv.GetFieldID (class_ref, "presenceState", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, presenceState_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (presenceState_jfieldId == IntPtr.Zero)
					presenceState_jfieldId = JNIEnv.GetFieldID (class_ref, "presenceState", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, presenceState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr presenceStatus_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='presenceStatus']"
		[Register ("presenceStatus")]
		public string PresenceStatus {
			get {
				if (presenceStatus_jfieldId == IntPtr.Zero)
					presenceStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "presenceStatus", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, presenceStatus_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (presenceStatus_jfieldId == IntPtr.Zero)
					presenceStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "presenceStatus", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, presenceStatus_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr publicationState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='publicationState']"
		[Register ("publicationState")]
		public global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState PublicationState {
			get {
				if (publicationState_jfieldId == IntPtr.Zero)
					publicationState_jfieldId = JNIEnv.GetFieldID (class_ref, "publicationState", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, publicationState_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (publicationState_jfieldId == IntPtr.Zero)
					publicationState_jfieldId = JNIEnv.GetFieldID (class_ref, "publicationState", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, publicationState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr subscriptionState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='subscriptionState']"
		[Register ("subscriptionState")]
		public global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState SubscriptionState {
			get {
				if (subscriptionState_jfieldId == IntPtr.Zero)
					subscriptionState_jfieldId = JNIEnv.GetFieldID (class_ref, "subscriptionState", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, subscriptionState_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (subscriptionState_jfieldId == IntPtr.Zero)
					subscriptionState_jfieldId = JNIEnv.GetFieldID (class_ref, "subscriptionState", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, subscriptionState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr telephones_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='telephones']"
		[Register ("telephones")]
		public global::System.Collections.IList Telephones {
			get {
				if (telephones_jfieldId == IntPtr.Zero)
					telephones_jfieldId = JNIEnv.GetFieldID (class_ref, "telephones", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, telephones_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (telephones_jfieldId == IntPtr.Zero)
					telephones_jfieldId = JNIEnv.GetFieldID (class_ref, "telephones", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, telephones_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/field[@name='timestamp']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactPresenceState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoContactPresenceState : global::Java.Lang.Enum {


			static IntPtr VIDYO_CONTACTPRESENCESTATE_Available_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactPresenceState']/field[@name='VIDYO_CONTACTPRESENCESTATE_Available']"
			[Register ("VIDYO_CONTACTPRESENCESTATE_Available")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState VIDYOCONTACTPRESENCESTATEAvailable {
				get {
					if (VIDYO_CONTACTPRESENCESTATE_Available_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTPRESENCESTATE_Available_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTPRESENCESTATE_Available", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTPRESENCESTATE_Available_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONTACTPRESENCESTATE_Away_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactPresenceState']/field[@name='VIDYO_CONTACTPRESENCESTATE_Away']"
			[Register ("VIDYO_CONTACTPRESENCESTATE_Away")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState VIDYOCONTACTPRESENCESTATEAway {
				get {
					if (VIDYO_CONTACTPRESENCESTATE_Away_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTPRESENCESTATE_Away_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTPRESENCESTATE_Away", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTPRESENCESTATE_Away_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONTACTPRESENCESTATE_DoNotDisturb_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactPresenceState']/field[@name='VIDYO_CONTACTPRESENCESTATE_DoNotDisturb']"
			[Register ("VIDYO_CONTACTPRESENCESTATE_DoNotDisturb")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState VIDYOCONTACTPRESENCESTATEDoNotDisturb {
				get {
					if (VIDYO_CONTACTPRESENCESTATE_DoNotDisturb_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTPRESENCESTATE_DoNotDisturb_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTPRESENCESTATE_DoNotDisturb", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTPRESENCESTATE_DoNotDisturb_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONTACTPRESENCESTATE_ExtendedAway_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactPresenceState']/field[@name='VIDYO_CONTACTPRESENCESTATE_ExtendedAway']"
			[Register ("VIDYO_CONTACTPRESENCESTATE_ExtendedAway")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState VIDYOCONTACTPRESENCESTATEExtendedAway {
				get {
					if (VIDYO_CONTACTPRESENCESTATE_ExtendedAway_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTPRESENCESTATE_ExtendedAway_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTPRESENCESTATE_ExtendedAway", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTPRESENCESTATE_ExtendedAway_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONTACTPRESENCESTATE_InterestedInChat_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactPresenceState']/field[@name='VIDYO_CONTACTPRESENCESTATE_InterestedInChat']"
			[Register ("VIDYO_CONTACTPRESENCESTATE_InterestedInChat")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState VIDYOCONTACTPRESENCESTATEInterestedInChat {
				get {
					if (VIDYO_CONTACTPRESENCESTATE_InterestedInChat_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTPRESENCESTATE_InterestedInChat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTPRESENCESTATE_InterestedInChat", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTPRESENCESTATE_InterestedInChat_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONTACTPRESENCESTATE_Unavailable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactPresenceState']/field[@name='VIDYO_CONTACTPRESENCESTATE_Unavailable']"
			[Register ("VIDYO_CONTACTPRESENCESTATE_Unavailable")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState VIDYOCONTACTPRESENCESTATEUnavailable {
				get {
					if (VIDYO_CONTACTPRESENCESTATE_Unavailable_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTPRESENCESTATE_Unavailable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTPRESENCESTATE_Unavailable", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTPRESENCESTATE_Unavailable_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoContactPresenceState); }
			}

			internal VidyoContactPresenceState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactPresenceState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactPresenceState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactProperty']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactProperty", DoNotGenerateAcw=true)]
		public partial class VidyoContactProperty : global::Java.Lang.Object {


			static IntPtr types_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactProperty']/field[@name='types']"
			[Register ("types")]
			public global::System.Collections.IList Types {
				get {
					if (types_jfieldId == IntPtr.Zero)
						types_jfieldId = JNIEnv.GetFieldID (class_ref, "types", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, types_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (types_jfieldId == IntPtr.Zero)
						types_jfieldId = JNIEnv.GetFieldID (class_ref, "types", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, types_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactProperty']/field[@name='value']"
			[Register ("value")]
			public string Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactProperty", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoContactProperty); }
			}

			protected VidyoContactProperty (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactProperty']/constructor[@name='VidyoContact.VidyoContactProperty' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact']]"
			[Register (".ctor", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V", "")]
			public unsafe VidyoContactProperty (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (VidyoContactProperty)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == IntPtr.Zero)
						id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactSubscriptionState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoContactSubscriptionState : global::Java.Lang.Enum {


			static IntPtr VIDYO_CONTACTSUBSCRIPTIONSTATE_AwaitingApproval_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactSubscriptionState']/field[@name='VIDYO_CONTACTSUBSCRIPTIONSTATE_AwaitingApproval']"
			[Register ("VIDYO_CONTACTSUBSCRIPTIONSTATE_AwaitingApproval")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState VIDYOCONTACTSUBSCRIPTIONSTATEAwaitingApproval {
				get {
					if (VIDYO_CONTACTSUBSCRIPTIONSTATE_AwaitingApproval_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTSUBSCRIPTIONSTATE_AwaitingApproval_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTSUBSCRIPTIONSTATE_AwaitingApproval", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTSUBSCRIPTIONSTATE_AwaitingApproval_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONTACTSUBSCRIPTIONSTATE_NotSubscribed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactSubscriptionState']/field[@name='VIDYO_CONTACTSUBSCRIPTIONSTATE_NotSubscribed']"
			[Register ("VIDYO_CONTACTSUBSCRIPTIONSTATE_NotSubscribed")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState VIDYOCONTACTSUBSCRIPTIONSTATENotSubscribed {
				get {
					if (VIDYO_CONTACTSUBSCRIPTIONSTATE_NotSubscribed_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTSUBSCRIPTIONSTATE_NotSubscribed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTSUBSCRIPTIONSTATE_NotSubscribed", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTSUBSCRIPTIONSTATE_NotSubscribed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONTACTSUBSCRIPTIONSTATE_Preapproved_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactSubscriptionState']/field[@name='VIDYO_CONTACTSUBSCRIPTIONSTATE_Preapproved']"
			[Register ("VIDYO_CONTACTSUBSCRIPTIONSTATE_Preapproved")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState VIDYOCONTACTSUBSCRIPTIONSTATEPreapproved {
				get {
					if (VIDYO_CONTACTSUBSCRIPTIONSTATE_Preapproved_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTSUBSCRIPTIONSTATE_Preapproved_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTSUBSCRIPTIONSTATE_Preapproved", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTSUBSCRIPTIONSTATE_Preapproved_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONTACTSUBSCRIPTIONSTATE_Subscribed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactSubscriptionState']/field[@name='VIDYO_CONTACTSUBSCRIPTIONSTATE_Subscribed']"
			[Register ("VIDYO_CONTACTSUBSCRIPTIONSTATE_Subscribed")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState VIDYOCONTACTSUBSCRIPTIONSTATESubscribed {
				get {
					if (VIDYO_CONTACTSUBSCRIPTIONSTATE_Subscribed_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTSUBSCRIPTIONSTATE_Subscribed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTSUBSCRIPTIONSTATE_Subscribed", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTSUBSCRIPTIONSTATE_Subscribed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONTACTSUBSCRIPTIONSTATE_Unavailable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactSubscriptionState']/field[@name='VIDYO_CONTACTSUBSCRIPTIONSTATE_Unavailable']"
			[Register ("VIDYO_CONTACTSUBSCRIPTIONSTATE_Unavailable")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState VIDYOCONTACTSUBSCRIPTIONSTATEUnavailable {
				get {
					if (VIDYO_CONTACTSUBSCRIPTIONSTATE_Unavailable_jfieldId == IntPtr.Zero)
						VIDYO_CONTACTSUBSCRIPTIONSTATE_Unavailable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONTACTSUBSCRIPTIONSTATE_Unavailable", "Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONTACTSUBSCRIPTIONSTATE_Unavailable_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoContactSubscriptionState); }
			}

			internal VidyoContactSubscriptionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactSubscriptionState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact.VidyoContactSubscriptionState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactSubscriptionState;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactSubscriptionState));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoContact", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoContact); }
		}

		protected VidyoContact (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContact']/constructor[@name='VidyoContact' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoContact ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoContact)) {
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
