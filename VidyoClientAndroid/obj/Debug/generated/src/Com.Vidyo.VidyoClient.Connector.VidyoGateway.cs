using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Connector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoGateway", DoNotGenerateAcw=true)]
	public partial class VidyoGateway : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoGateway.IConnect']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoGateway$IConnect", "", "Com.Vidyo.VidyoClient.Connector.VidyoGateway/IConnectInvoker")]
		public partial interface IConnect : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoGateway.IConnect']/method[@name='OnDisconnected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason']]"
			[Register ("OnDisconnected", "(Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;)V", "GetOnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_Handler:Com.Vidyo.VidyoClient.Connector.VidyoGateway/IConnectInvoker, VidyoClientAndroid")]
			void OnDisconnected (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoGateway.IConnect']/method[@name='OnFailure' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason']]"
			[Register ("OnFailure", "(Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;)V", "GetOnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_Handler:Com.Vidyo.VidyoClient.Connector.VidyoGateway/IConnectInvoker, VidyoClientAndroid")]
			void OnFailure (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoGateway.IConnect']/method[@name='OnSuccess' and count(parameter)=0]"
			[Register ("OnSuccess", "()V", "GetOnSuccessHandler:Com.Vidyo.VidyoClient.Connector.VidyoGateway/IConnectInvoker, VidyoClientAndroid")]
			void OnSuccess ();

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoGateway$IConnect", DoNotGenerateAcw=true)]
		internal class IConnectInvoker : global::Java.Lang.Object, IConnect {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoGateway$IConnect");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IConnectInvoker); }
			}

			IntPtr class_ref;

			public static IConnect GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IConnect> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoGateway.IConnect"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IConnectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_;
#pragma warning disable 0169
			static Delegate GetOnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_Handler ()
			{
				if (cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_ == null)
					cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_);
				return cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_;
			}

			static void n_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.IConnect __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.IConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDisconnected (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_;
			public unsafe void OnDisconnected (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason p0)
			{
				if (id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_ == IntPtr.Zero)
					id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_ = JNIEnv.GetMethodID (class_ref, "OnDisconnected", "(Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_, __args);
			}

			static Delegate cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_Handler ()
			{
				if (cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_ == null)
					cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_);
				return cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_;
			}

			static void n_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.IConnect __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.IConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_;
			public unsafe void OnFailure (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason p0)
			{
				if (id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_ == IntPtr.Zero)
					id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_ = JNIEnv.GetMethodID (class_ref, "OnFailure", "(Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_, __args);
			}

			static Delegate cb_OnSuccess;
#pragma warning disable 0169
			static Delegate GetOnSuccessHandler ()
			{
				if (cb_OnSuccess == null)
					cb_OnSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
				return cb_OnSuccess;
			}

			static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.IConnect __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.IConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess ();
			}
#pragma warning restore 0169

			IntPtr id_OnSuccess;
			public unsafe void OnSuccess ()
			{
				if (id_OnSuccess == IntPtr.Zero)
					id_OnSuccess = JNIEnv.GetMethodID (class_ref, "OnSuccess", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnSuccess);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason", DoNotGenerateAcw=true)]
		public sealed partial class VidyoGatewayDisconnectReason : global::Java.Lang.Enum {


			static IntPtr VIDYO_GATEWAYDISCONNECTREASON_ConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']/field[@name='VIDYO_GATEWAYDISCONNECTREASON_ConnectionLost']"
			[Register ("VIDYO_GATEWAYDISCONNECTREASON_ConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason VIDYOGATEWAYDISCONNECTREASONConnectionLost {
				get {
					if (VIDYO_GATEWAYDISCONNECTREASON_ConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYDISCONNECTREASON_ConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYDISCONNECTREASON_ConnectionLost", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYDISCONNECTREASON_ConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYDISCONNECTREASON_ConnectionTimeout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']/field[@name='VIDYO_GATEWAYDISCONNECTREASON_ConnectionTimeout']"
			[Register ("VIDYO_GATEWAYDISCONNECTREASON_ConnectionTimeout")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason VIDYOGATEWAYDISCONNECTREASONConnectionTimeout {
				get {
					if (VIDYO_GATEWAYDISCONNECTREASON_ConnectionTimeout_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYDISCONNECTREASON_ConnectionTimeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYDISCONNECTREASON_ConnectionTimeout", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYDISCONNECTREASON_ConnectionTimeout_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYDISCONNECTREASON_Disconnected_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']/field[@name='VIDYO_GATEWAYDISCONNECTREASON_Disconnected']"
			[Register ("VIDYO_GATEWAYDISCONNECTREASON_Disconnected")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason VIDYOGATEWAYDISCONNECTREASONDisconnected {
				get {
					if (VIDYO_GATEWAYDISCONNECTREASON_Disconnected_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYDISCONNECTREASON_Disconnected_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYDISCONNECTREASON_Disconnected", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYDISCONNECTREASON_Disconnected_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYDISCONNECTREASON_MiscError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']/field[@name='VIDYO_GATEWAYDISCONNECTREASON_MiscError']"
			[Register ("VIDYO_GATEWAYDISCONNECTREASON_MiscError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason VIDYOGATEWAYDISCONNECTREASONMiscError {
				get {
					if (VIDYO_GATEWAYDISCONNECTREASON_MiscError_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYDISCONNECTREASON_MiscError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYDISCONNECTREASON_MiscError", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYDISCONNECTREASON_MiscError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYDISCONNECTREASON_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']/field[@name='VIDYO_GATEWAYDISCONNECTREASON_MiscLocalError']"
			[Register ("VIDYO_GATEWAYDISCONNECTREASON_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason VIDYOGATEWAYDISCONNECTREASONMiscLocalError {
				get {
					if (VIDYO_GATEWAYDISCONNECTREASON_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYDISCONNECTREASON_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYDISCONNECTREASON_MiscLocalError", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYDISCONNECTREASON_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYDISCONNECTREASON_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']/field[@name='VIDYO_GATEWAYDISCONNECTREASON_MiscRemoteError']"
			[Register ("VIDYO_GATEWAYDISCONNECTREASON_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason VIDYOGATEWAYDISCONNECTREASONMiscRemoteError {
				get {
					if (VIDYO_GATEWAYDISCONNECTREASON_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYDISCONNECTREASON_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYDISCONNECTREASON_MiscRemoteError", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYDISCONNECTREASON_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYDISCONNECTREASON_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']/field[@name='VIDYO_GATEWAYDISCONNECTREASON_NoResponse']"
			[Register ("VIDYO_GATEWAYDISCONNECTREASON_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason VIDYOGATEWAYDISCONNECTREASONNoResponse {
				get {
					if (VIDYO_GATEWAYDISCONNECTREASON_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYDISCONNECTREASON_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYDISCONNECTREASON_NoResponse", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYDISCONNECTREASON_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYDISCONNECTREASON_Terminated_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']/field[@name='VIDYO_GATEWAYDISCONNECTREASON_Terminated']"
			[Register ("VIDYO_GATEWAYDISCONNECTREASON_Terminated")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason VIDYOGATEWAYDISCONNECTREASONTerminated {
				get {
					if (VIDYO_GATEWAYDISCONNECTREASON_Terminated_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYDISCONNECTREASON_Terminated_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYDISCONNECTREASON_Terminated", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYDISCONNECTREASON_Terminated_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoGatewayDisconnectReason); }
			}

			internal VidyoGatewayDisconnectReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayDisconnectReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;");
				try {
					return (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason", DoNotGenerateAcw=true)]
		public sealed partial class VidyoGatewayFailReason : global::Java.Lang.Enum {


			static IntPtr VIDYO_GATEWAYFAILREASON_Banned_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_Banned']"
			[Register ("VIDYO_GATEWAYFAILREASON_Banned")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONBanned {
				get {
					if (VIDYO_GATEWAYFAILREASON_Banned_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_Banned_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_Banned", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_Banned_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_ConnectionFailed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_ConnectionFailed']"
			[Register ("VIDYO_GATEWAYFAILREASON_ConnectionFailed")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONConnectionFailed {
				get {
					if (VIDYO_GATEWAYFAILREASON_ConnectionFailed_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_ConnectionFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_ConnectionFailed", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_ConnectionFailed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_ConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_ConnectionLost']"
			[Register ("VIDYO_GATEWAYFAILREASON_ConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONConnectionLost {
				get {
					if (VIDYO_GATEWAYFAILREASON_ConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_ConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_ConnectionLost", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_ConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_ConnectionTimeout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_ConnectionTimeout']"
			[Register ("VIDYO_GATEWAYFAILREASON_ConnectionTimeout")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONConnectionTimeout {
				get {
					if (VIDYO_GATEWAYFAILREASON_ConnectionTimeout_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_ConnectionTimeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_ConnectionTimeout", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_ConnectionTimeout_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_InvalidResourceId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_InvalidResourceId']"
			[Register ("VIDYO_GATEWAYFAILREASON_InvalidResourceId")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONInvalidResourceId {
				get {
					if (VIDYO_GATEWAYFAILREASON_InvalidResourceId_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_InvalidResourceId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_InvalidResourceId", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_InvalidResourceId_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_InvalidToken_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_InvalidToken']"
			[Register ("VIDYO_GATEWAYFAILREASON_InvalidToken")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONInvalidToken {
				get {
					if (VIDYO_GATEWAYFAILREASON_InvalidToken_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_InvalidToken_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_InvalidToken", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_InvalidToken_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_MediaFailed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_MediaFailed']"
			[Register ("VIDYO_GATEWAYFAILREASON_MediaFailed")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONMediaFailed {
				get {
					if (VIDYO_GATEWAYFAILREASON_MediaFailed_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_MediaFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_MediaFailed", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_MediaFailed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_MediaNotEnabled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_MediaNotEnabled']"
			[Register ("VIDYO_GATEWAYFAILREASON_MediaNotEnabled")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONMediaNotEnabled {
				get {
					if (VIDYO_GATEWAYFAILREASON_MediaNotEnabled_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_MediaNotEnabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_MediaNotEnabled", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_MediaNotEnabled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_MiscError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_MiscError']"
			[Register ("VIDYO_GATEWAYFAILREASON_MiscError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONMiscError {
				get {
					if (VIDYO_GATEWAYFAILREASON_MiscError_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_MiscError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_MiscError", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_MiscError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_MiscLocalError']"
			[Register ("VIDYO_GATEWAYFAILREASON_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONMiscLocalError {
				get {
					if (VIDYO_GATEWAYFAILREASON_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_MiscLocalError", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_MiscRemoteError']"
			[Register ("VIDYO_GATEWAYFAILREASON_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONMiscRemoteError {
				get {
					if (VIDYO_GATEWAYFAILREASON_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_MiscRemoteError", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_NoResponse']"
			[Register ("VIDYO_GATEWAYFAILREASON_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONNoResponse {
				get {
					if (VIDYO_GATEWAYFAILREASON_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_NoResponse", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_NoResponseFromResource_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_NoResponseFromResource']"
			[Register ("VIDYO_GATEWAYFAILREASON_NoResponseFromResource")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONNoResponseFromResource {
				get {
					if (VIDYO_GATEWAYFAILREASON_NoResponseFromResource_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_NoResponseFromResource_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_NoResponseFromResource", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_NoResponseFromResource_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_NotMember_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_NotMember']"
			[Register ("VIDYO_GATEWAYFAILREASON_NotMember")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONNotMember {
				get {
					if (VIDYO_GATEWAYFAILREASON_NotMember_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_NotMember_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_NotMember", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_NotMember_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_ResourceFull_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_ResourceFull']"
			[Register ("VIDYO_GATEWAYFAILREASON_ResourceFull")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONResourceFull {
				get {
					if (VIDYO_GATEWAYFAILREASON_ResourceFull_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_ResourceFull_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_ResourceFull", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_ResourceFull_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_Terminated_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_Terminated']"
			[Register ("VIDYO_GATEWAYFAILREASON_Terminated")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONTerminated {
				get {
					if (VIDYO_GATEWAYFAILREASON_Terminated_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_Terminated_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_Terminated", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_Terminated_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYFAILREASON_UnableToCreateResource_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/field[@name='VIDYO_GATEWAYFAILREASON_UnableToCreateResource']"
			[Register ("VIDYO_GATEWAYFAILREASON_UnableToCreateResource")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason VIDYOGATEWAYFAILREASONUnableToCreateResource {
				get {
					if (VIDYO_GATEWAYFAILREASON_UnableToCreateResource_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYFAILREASON_UnableToCreateResource_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYFAILREASON_UnableToCreateResource", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYFAILREASON_UnableToCreateResource_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoGatewayFailReason); }
			}

			internal VidyoGatewayFailReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayFailReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;");
				try {
					return (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoGatewayState : global::Java.Lang.Enum {


			static IntPtr VIDYO_GATEWAYSTATE_Connected_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayState']/field[@name='VIDYO_GATEWAYSTATE_Connected']"
			[Register ("VIDYO_GATEWAYSTATE_Connected")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState VIDYOGATEWAYSTATEConnected {
				get {
					if (VIDYO_GATEWAYSTATE_Connected_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYSTATE_Connected_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYSTATE_Connected", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYSTATE_Connected_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYSTATE_ConnectingToResource_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayState']/field[@name='VIDYO_GATEWAYSTATE_ConnectingToResource']"
			[Register ("VIDYO_GATEWAYSTATE_ConnectingToResource")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState VIDYOGATEWAYSTATEConnectingToResource {
				get {
					if (VIDYO_GATEWAYSTATE_ConnectingToResource_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYSTATE_ConnectingToResource_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYSTATE_ConnectingToResource", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYSTATE_ConnectingToResource_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYSTATE_EnablingMedia_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayState']/field[@name='VIDYO_GATEWAYSTATE_EnablingMedia']"
			[Register ("VIDYO_GATEWAYSTATE_EnablingMedia")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState VIDYOGATEWAYSTATEEnablingMedia {
				get {
					if (VIDYO_GATEWAYSTATE_EnablingMedia_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYSTATE_EnablingMedia_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYSTATE_EnablingMedia", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYSTATE_EnablingMedia_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYSTATE_EstablishingConnection_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayState']/field[@name='VIDYO_GATEWAYSTATE_EstablishingConnection']"
			[Register ("VIDYO_GATEWAYSTATE_EstablishingConnection")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState VIDYOGATEWAYSTATEEstablishingConnection {
				get {
					if (VIDYO_GATEWAYSTATE_EstablishingConnection_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYSTATE_EstablishingConnection_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYSTATE_EstablishingConnection", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYSTATE_EstablishingConnection_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYSTATE_FindingResource_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayState']/field[@name='VIDYO_GATEWAYSTATE_FindingResource']"
			[Register ("VIDYO_GATEWAYSTATE_FindingResource")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState VIDYOGATEWAYSTATEFindingResource {
				get {
					if (VIDYO_GATEWAYSTATE_FindingResource_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYSTATE_FindingResource_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYSTATE_FindingResource", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYSTATE_FindingResource_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_GATEWAYSTATE_Idle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayState']/field[@name='VIDYO_GATEWAYSTATE_Idle']"
			[Register ("VIDYO_GATEWAYSTATE_Idle")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState VIDYOGATEWAYSTATEIdle {
				get {
					if (VIDYO_GATEWAYSTATE_Idle_jfieldId == IntPtr.Zero)
						VIDYO_GATEWAYSTATE_Idle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_GATEWAYSTATE_Idle", "Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_GATEWAYSTATE_Idle_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoGatewayState); }
			}

			internal VidyoGatewayState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway.VidyoGatewayState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayState;");
				try {
					return (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayState));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoGateway", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoGateway); }
		}

		protected VidyoGateway (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway']/constructor[@name='VidyoGateway' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoGateway (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoGateway)) {
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
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway']/method[@name='GetObjectPtr' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Assign ());
		}
#pragma warning restore 0169

		static IntPtr id_Assign;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway']/method[@name='Assign' and count(parameter)=0]"
		[Register ("Assign", "()Lcom/vidyo/VidyoClient/Connector/VidyoGateway;", "GetAssignHandler")]
		public virtual unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoGateway Assign ()
		{
			if (id_Assign == IntPtr.Zero)
				id_Assign = JNIEnv.GetMethodID (class_ref, "Assign", "()Lcom/vidyo/VidyoClient/Connector/VidyoGateway;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_Assign), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Assign", "()Lcom/vidyo/VidyoClient/Connector/VidyoGateway;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_Handler ()
		{
			if (cb_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_ == null)
				cb_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_);
			return cb_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_;
		}

		static bool n_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.IConnect p4 = (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.IConnect)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.IConnect> (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Connect (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway']/method[@name='Connect' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.vidyo.VidyoClient.Connector.VidyoGateway.IConnect']]"
		[Register ("Connect", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Connector/VidyoGateway$IConnect;)Z", "GetConnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_Handler")]
		public virtual unsafe bool Connect (string p0, string p1, string p2, string p3, global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.IConnect p4)
		{
			if (id_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_ == IntPtr.Zero)
				id_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_ = JNIEnv.GetMethodID (class_ref, "Connect", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Connector/VidyoGateway$IConnect;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_IConnect_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Connect", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Connector/VidyoGateway$IConnect;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_Disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_Disconnect == null)
				cb_Disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_Disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_Disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway']/method[@name='Disconnect' and count(parameter)=0]"
		[Register ("Disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			if (id_Disconnect == IntPtr.Zero)
				id_Disconnect = JNIEnv.GetMethodID (class_ref, "Disconnect", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Disconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Disconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_;
#pragma warning disable 0169
		static Delegate GetOnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_Handler ()
		{
			if (cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_ == null)
				cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_);
			return cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_;
		}

		static void n_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway']/method[@name='OnDisconnected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason']]"
		[Register ("OnDisconnected", "(Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;)V", "GetOnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_Handler")]
		public virtual unsafe void OnDisconnected (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayDisconnectReason p0)
		{
			if (id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_ == IntPtr.Zero)
				id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_ = JNIEnv.GetMethodID (class_ref, "OnDisconnected", "(Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayDisconnectReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnDisconnected", "(Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayDisconnectReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_Handler ()
		{
			if (cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_ == null)
				cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_);
			return cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_;
		}

		static void n_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway']/method[@name='OnFailure' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason']]"
		[Register ("OnFailure", "(Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;)V", "GetOnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_Handler")]
		public virtual unsafe void OnFailure (global::Com.Vidyo.VidyoClient.Connector.VidyoGateway.VidyoGatewayFailReason p0)
		{
			if (id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_ == IntPtr.Zero)
				id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_ = JNIEnv.GetMethodID (class_ref, "OnFailure", "(Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoGateway_VidyoGatewayFailReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnFailure", "(Lcom/vidyo/VidyoClient/Connector/VidyoGateway$VidyoGatewayFailReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_OnSuccess == null)
				cb_OnSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
			return cb_OnSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		static IntPtr id_OnSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway']/method[@name='OnSuccess' and count(parameter)=0]"
		[Register ("OnSuccess", "()V", "GetOnSuccessHandler")]
		public virtual unsafe void OnSuccess ()
		{
			if (id_OnSuccess == IntPtr.Zero)
				id_OnSuccess = JNIEnv.GetMethodID (class_ref, "OnSuccess", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnSuccess);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnSuccess", "()V"));
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
			global::Com.Vidyo.VidyoClient.Connector.VidyoGateway __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoGateway> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoGateway']/method[@name='dispose' and count(parameter)=0]"
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
