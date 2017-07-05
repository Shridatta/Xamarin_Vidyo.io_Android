using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoomInfo", DoNotGenerateAcw=true)]
	public partial class VidyoRoomInfo : global::Java.Lang.Object {


		static IntPtr IsFavorite_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='IsFavorite']"
		[Register ("IsFavorite")]
		public bool IsFavorite {
			get {
				if (IsFavorite_jfieldId == IntPtr.Zero)
					IsFavorite_jfieldId = JNIEnv.GetFieldID (class_ref, "IsFavorite", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, IsFavorite_jfieldId);
			}
			set {
				if (IsFavorite_jfieldId == IntPtr.Zero)
					IsFavorite_jfieldId = JNIEnv.GetFieldID (class_ref, "IsFavorite", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, IsFavorite_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr IsPublic_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='IsPublic']"
		[Register ("IsPublic")]
		public bool IsPublic {
			get {
				if (IsPublic_jfieldId == IntPtr.Zero)
					IsPublic_jfieldId = JNIEnv.GetFieldID (class_ref, "IsPublic", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, IsPublic_jfieldId);
			}
			set {
				if (IsPublic_jfieldId == IntPtr.Zero)
					IsPublic_jfieldId = JNIEnv.GetFieldID (class_ref, "IsPublic", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, IsPublic_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr creationTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='creationTime']"
		[Register ("creationTime")]
		public long CreationTime {
			get {
				if (creationTime_jfieldId == IntPtr.Zero)
					creationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "creationTime", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, creationTime_jfieldId);
			}
			set {
				if (creationTime_jfieldId == IntPtr.Zero)
					creationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "creationTime", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, creationTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr description_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='description']"
		[Register ("description")]
		public string Description {
			get {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, description_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, description_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='id']"
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

		static IntPtr language_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='language']"
		[Register ("language")]
		public string Language {
			get {
				if (language_jfieldId == IntPtr.Zero)
					language_jfieldId = JNIEnv.GetFieldID (class_ref, "language", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, language_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (language_jfieldId == IntPtr.Zero)
					language_jfieldId = JNIEnv.GetFieldID (class_ref, "language", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, language_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr messageList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='messageList']"
		[Register ("messageList")]
		public global::System.Collections.IList MessageList {
			get {
				if (messageList_jfieldId == IntPtr.Zero)
					messageList_jfieldId = JNIEnv.GetFieldID (class_ref, "messageList", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, messageList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (messageList_jfieldId == IntPtr.Zero)
					messageList_jfieldId = JNIEnv.GetFieldID (class_ref, "messageList", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, messageList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='name']"
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

		static IntPtr numUsers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='numUsers']"
		[Register ("numUsers")]
		public int NumUsers {
			get {
				if (numUsers_jfieldId == IntPtr.Zero)
					numUsers_jfieldId = JNIEnv.GetFieldID (class_ref, "numUsers", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, numUsers_jfieldId);
			}
			set {
				if (numUsers_jfieldId == IntPtr.Zero)
					numUsers_jfieldId = JNIEnv.GetFieldID (class_ref, "numUsers", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, numUsers_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ownerList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='ownerList']"
		[Register ("ownerList")]
		public global::System.Collections.IList OwnerList {
			get {
				if (ownerList_jfieldId == IntPtr.Zero)
					ownerList_jfieldId = JNIEnv.GetFieldID (class_ref, "ownerList", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ownerList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ownerList_jfieldId == IntPtr.Zero)
					ownerList_jfieldId = JNIEnv.GetFieldID (class_ref, "ownerList", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ownerList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='type']"
		[Register ("type")]
		public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr userList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/field[@name='userList']"
		[Register ("userList")]
		public global::System.Collections.IList UserList {
			get {
				if (userList_jfieldId == IntPtr.Zero)
					userList_jfieldId = JNIEnv.GetFieldID (class_ref, "userList", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, userList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (userList_jfieldId == IntPtr.Zero)
					userList_jfieldId = JNIEnv.GetFieldID (class_ref, "userList", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, userList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoomInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoRoomInfo); }
		}

		protected VidyoRoomInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoomInfo']/constructor[@name='VidyoRoomInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoRoomInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoRoomInfo)) {
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
