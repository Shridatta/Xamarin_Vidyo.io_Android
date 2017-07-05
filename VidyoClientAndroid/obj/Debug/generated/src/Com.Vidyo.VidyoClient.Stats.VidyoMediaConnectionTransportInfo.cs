using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoMediaConnectionTransportInfo", DoNotGenerateAcw=true)]
	public partial class VidyoMediaConnectionTransportInfo : global::Java.Lang.Object {


		static IntPtr addressType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='addressType']"
		[Register ("addressType")]
		public string AddressType {
			get {
				if (addressType_jfieldId == IntPtr.Zero)
					addressType_jfieldId = JNIEnv.GetFieldID (class_ref, "addressType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, addressType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (addressType_jfieldId == IntPtr.Zero)
					addressType_jfieldId = JNIEnv.GetFieldID (class_ref, "addressType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, addressType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr componentType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='componentType']"
		[Register ("componentType")]
		public string ComponentType {
			get {
				if (componentType_jfieldId == IntPtr.Zero)
					componentType_jfieldId = JNIEnv.GetFieldID (class_ref, "componentType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, componentType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (componentType_jfieldId == IntPtr.Zero)
					componentType_jfieldId = JNIEnv.GetFieldID (class_ref, "componentType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, componentType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr connectionId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='connectionId']"
		[Register ("connectionId")]
		public int ConnectionId {
			get {
				if (connectionId_jfieldId == IntPtr.Zero)
					connectionId_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, connectionId_jfieldId);
			}
			set {
				if (connectionId_jfieldId == IntPtr.Zero)
					connectionId_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connectionId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr connectionType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='connectionType']"
		[Register ("connectionType")]
		public string ConnectionType {
			get {
				if (connectionType_jfieldId == IntPtr.Zero)
					connectionType_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, connectionType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (connectionType_jfieldId == IntPtr.Zero)
					connectionType_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connectionType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr externalLocalAddr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='externalLocalAddr']"
		[Register ("externalLocalAddr")]
		public string ExternalLocalAddr {
			get {
				if (externalLocalAddr_jfieldId == IntPtr.Zero)
					externalLocalAddr_jfieldId = JNIEnv.GetFieldID (class_ref, "externalLocalAddr", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, externalLocalAddr_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (externalLocalAddr_jfieldId == IntPtr.Zero)
					externalLocalAddr_jfieldId = JNIEnv.GetFieldID (class_ref, "externalLocalAddr", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, externalLocalAddr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr externalRemoteAddr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='externalRemoteAddr']"
		[Register ("externalRemoteAddr")]
		public string ExternalRemoteAddr {
			get {
				if (externalRemoteAddr_jfieldId == IntPtr.Zero)
					externalRemoteAddr_jfieldId = JNIEnv.GetFieldID (class_ref, "externalRemoteAddr", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, externalRemoteAddr_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (externalRemoteAddr_jfieldId == IntPtr.Zero)
					externalRemoteAddr_jfieldId = JNIEnv.GetFieldID (class_ref, "externalRemoteAddr", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, externalRemoteAddr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr interfaceName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='interfaceName']"
		[Register ("interfaceName")]
		public string InterfaceName {
			get {
				if (interfaceName_jfieldId == IntPtr.Zero)
					interfaceName_jfieldId = JNIEnv.GetFieldID (class_ref, "interfaceName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, interfaceName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (interfaceName_jfieldId == IntPtr.Zero)
					interfaceName_jfieldId = JNIEnv.GetFieldID (class_ref, "interfaceName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, interfaceName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr interfaceType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='interfaceType']"
		[Register ("interfaceType")]
		public string InterfaceType {
			get {
				if (interfaceType_jfieldId == IntPtr.Zero)
					interfaceType_jfieldId = JNIEnv.GetFieldID (class_ref, "interfaceType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, interfaceType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (interfaceType_jfieldId == IntPtr.Zero)
					interfaceType_jfieldId = JNIEnv.GetFieldID (class_ref, "interfaceType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, interfaceType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr internalLocalAddr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='internalLocalAddr']"
		[Register ("internalLocalAddr")]
		public string InternalLocalAddr {
			get {
				if (internalLocalAddr_jfieldId == IntPtr.Zero)
					internalLocalAddr_jfieldId = JNIEnv.GetFieldID (class_ref, "internalLocalAddr", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, internalLocalAddr_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (internalLocalAddr_jfieldId == IntPtr.Zero)
					internalLocalAddr_jfieldId = JNIEnv.GetFieldID (class_ref, "internalLocalAddr", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, internalLocalAddr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr internalRemoteAddr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='internalRemoteAddr']"
		[Register ("internalRemoteAddr")]
		public string InternalRemoteAddr {
			get {
				if (internalRemoteAddr_jfieldId == IntPtr.Zero)
					internalRemoteAddr_jfieldId = JNIEnv.GetFieldID (class_ref, "internalRemoteAddr", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, internalRemoteAddr_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (internalRemoteAddr_jfieldId == IntPtr.Zero)
					internalRemoteAddr_jfieldId = JNIEnv.GetFieldID (class_ref, "internalRemoteAddr", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, internalRemoteAddr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr transportPlugIn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/field[@name='transportPlugIn']"
		[Register ("transportPlugIn")]
		public string TransportPlugIn {
			get {
				if (transportPlugIn_jfieldId == IntPtr.Zero)
					transportPlugIn_jfieldId = JNIEnv.GetFieldID (class_ref, "transportPlugIn", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, transportPlugIn_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (transportPlugIn_jfieldId == IntPtr.Zero)
					transportPlugIn_jfieldId = JNIEnv.GetFieldID (class_ref, "transportPlugIn", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, transportPlugIn_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoMediaConnectionTransportInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoMediaConnectionTransportInfo); }
		}

		protected VidyoMediaConnectionTransportInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoMediaConnectionTransportInfo']/constructor[@name='VidyoMediaConnectionTransportInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoMediaConnectionTransportInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoMediaConnectionTransportInfo)) {
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
