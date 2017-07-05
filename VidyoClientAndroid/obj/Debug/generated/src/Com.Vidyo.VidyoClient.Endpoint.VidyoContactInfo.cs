using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoContactInfo", DoNotGenerateAcw=true)]
	public partial class VidyoContactInfo : global::Java.Lang.Object {


		static IntPtr emails_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']/field[@name='emails']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']/field[@name='groups']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']/field[@name='handle']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']/field[@name='id']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']/field[@name='name']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']/field[@name='nickname']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']/field[@name='photo']"
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

		static IntPtr telephones_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']/field[@name='telephones']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']/field[@name='timestamp']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo.VidyoContactInfoProperty']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoContactInfo$VidyoContactInfoProperty", DoNotGenerateAcw=true)]
		public partial class VidyoContactInfoProperty : global::Java.Lang.Object {


			static IntPtr types_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo.VidyoContactInfoProperty']/field[@name='types']"
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

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo.VidyoContactInfoProperty']/field[@name='value']"
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
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoContactInfo$VidyoContactInfoProperty", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoContactInfoProperty); }
			}

			protected VidyoContactInfoProperty (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoContactInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo.VidyoContactInfoProperty']/constructor[@name='VidyoContactInfo.VidyoContactInfoProperty' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoContactInfo']]"
			[Register (".ctor", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContactInfo;)V", "")]
			public unsafe VidyoContactInfoProperty (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (VidyoContactInfoProperty)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoContactInfo_ == IntPtr.Zero)
						id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoContactInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContactInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoContactInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoContactInfo_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoContactInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoContactInfo); }
		}

		protected VidyoContactInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoContactInfo']/constructor[@name='VidyoContactInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoContactInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoContactInfo)) {
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
