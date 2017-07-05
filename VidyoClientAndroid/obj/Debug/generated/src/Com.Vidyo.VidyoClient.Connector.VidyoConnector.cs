using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Connector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector", DoNotGenerateAcw=true)]
	public partial class VidyoConnector : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IConnect']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IConnect", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IConnectInvoker")]
		public partial interface IConnect : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IConnect']/method[@name='OnDisconnected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason']]"
			[Register ("OnDisconnected", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;)V", "GetOnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IConnectInvoker, VidyoClientAndroid")]
			void OnDisconnected (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IConnect']/method[@name='OnFailure' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason']]"
			[Register ("OnFailure", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;)V", "GetOnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IConnectInvoker, VidyoClientAndroid")]
			void OnFailure (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IConnect']/method[@name='OnSuccess' and count(parameter)=0]"
			[Register ("OnSuccess", "()V", "GetOnSuccessHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IConnectInvoker, VidyoClientAndroid")]
			void OnSuccess ();

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IConnect", DoNotGenerateAcw=true)]
		internal class IConnectInvoker : global::Java.Lang.Object, IConnect {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IConnect");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IConnect"));
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

			static Delegate cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_;
#pragma warning disable 0169
			static Delegate GetOnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_Handler ()
			{
				if (cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_ == null)
					cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_);
				return cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_;
			}

			static void n_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IConnect __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDisconnected (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_;
			public unsafe void OnDisconnected (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason p0)
			{
				if (id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_ == IntPtr.Zero)
					id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_ = JNIEnv.GetMethodID (class_ref, "OnDisconnected", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_, __args);
			}

			static Delegate cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_Handler ()
			{
				if (cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_ == null)
					cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_);
				return cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_;
			}

			static void n_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IConnect __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_;
			public unsafe void OnFailure (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason p0)
			{
				if (id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_ == IntPtr.Zero)
					id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_ = JNIEnv.GetMethodID (class_ref, "OnFailure", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_, __args);
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
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IConnect __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalCameraEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalCameraEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalCameraEventListenerInvoker")]
		public partial interface IRegisterLocalCameraEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalCameraEventListener']/method[@name='OnLocalCameraAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
			[Register ("OnLocalCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetOnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalCameraEventListener']/method[@name='OnLocalCameraRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
			[Register ("OnLocalCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetOnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalCameraEventListener']/method[@name='OnLocalCameraSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
			[Register ("OnLocalCameraSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetOnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalCameraSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalCameraEventListener']/method[@name='OnLocalCameraStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalCameraEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalCameraEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalCameraEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalCameraEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterLocalCameraEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterLocalCameraEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterLocalCameraEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterLocalCameraEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
#pragma warning disable 0169
			static Delegate GetOnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler ()
			{
				if (cb_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == null)
					cb_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_);
				return cb_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
			}

			static void n_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalCameraAdded (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
			public unsafe void OnLocalCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
			{
				if (id_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == IntPtr.Zero)
					id_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNIEnv.GetMethodID (class_ref, "OnLocalCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_, __args);
			}

			static Delegate cb_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
#pragma warning disable 0169
			static Delegate GetOnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler ()
			{
				if (cb_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == null)
					cb_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_);
				return cb_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
			}

			static void n_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalCameraRemoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
			public unsafe void OnLocalCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
			{
				if (id_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == IntPtr.Zero)
					id_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNIEnv.GetMethodID (class_ref, "OnLocalCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_, __args);
			}

			static Delegate cb_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
#pragma warning disable 0169
			static Delegate GetOnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler ()
			{
				if (cb_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == null)
					cb_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_);
				return cb_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
			}

			static void n_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalCameraSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
			public unsafe void OnLocalCameraSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
			{
				if (id_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == IntPtr.Zero)
					id_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNIEnv.GetMethodID (class_ref, "OnLocalCameraSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_, __args);
			}

			static Delegate cb_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalCameraStateUpdated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnLocalCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				if (id_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class LocalCameraAddedEventArgs : global::System.EventArgs {

			public LocalCameraAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera P0 {
				get { return p0; }
			}
		}

		public partial class LocalCameraRemovedEventArgs : global::System.EventArgs {

			public LocalCameraRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera P0 {
				get { return p0; }
			}
		}

		public partial class LocalCameraSelectedEventArgs : global::System.EventArgs {

			public LocalCameraSelectedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera P0 {
				get { return p0; }
			}
		}

		public partial class LocalCameraStateUpdatedEventArgs : global::System.EventArgs {

			public LocalCameraStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLocalCameraEventListenerImplementor")]
		internal sealed partial class IRegisterLocalCameraEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalCameraEventListener {

			object sender;

			public IRegisterLocalCameraEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLocalCameraEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<LocalCameraAddedEventArgs> OnLocalCameraAddedHandler;
#pragma warning restore 0649

			public void OnLocalCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
			{
				var __h = OnLocalCameraAddedHandler;
				if (__h != null)
					__h (sender, new LocalCameraAddedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalCameraRemovedEventArgs> OnLocalCameraRemovedHandler;
#pragma warning restore 0649

			public void OnLocalCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
			{
				var __h = OnLocalCameraRemovedHandler;
				if (__h != null)
					__h (sender, new LocalCameraRemovedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalCameraSelectedEventArgs> OnLocalCameraSelectedHandler;
#pragma warning restore 0649

			public void OnLocalCameraSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
			{
				var __h = OnLocalCameraSelectedHandler;
				if (__h != null)
					__h (sender, new LocalCameraSelectedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalCameraStateUpdatedEventArgs> OnLocalCameraStateUpdatedHandler;
#pragma warning restore 0649

			public void OnLocalCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				var __h = OnLocalCameraStateUpdatedHandler;
				if (__h != null)
					__h (sender, new LocalCameraStateUpdatedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRegisterLocalCameraEventListenerImplementor value)
			{
				return value.OnLocalCameraAddedHandler == null && value.OnLocalCameraRemovedHandler == null && value.OnLocalCameraSelectedHandler == null && value.OnLocalCameraStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalMicrophoneEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMicrophoneEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMicrophoneEventListenerInvoker")]
		public partial interface IRegisterLocalMicrophoneEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalMicrophoneEventListener']/method[@name='OnLocalMicrophoneAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
			[Register ("OnLocalMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetOnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalMicrophoneEventListener']/method[@name='OnLocalMicrophoneRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
			[Register ("OnLocalMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetOnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalMicrophoneEventListener']/method[@name='OnLocalMicrophoneSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
			[Register ("OnLocalMicrophoneSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetOnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMicrophoneSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalMicrophoneEventListener']/method[@name='OnLocalMicrophoneStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMicrophoneEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalMicrophoneEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalMicrophoneEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMicrophoneEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterLocalMicrophoneEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterLocalMicrophoneEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterLocalMicrophoneEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterLocalMicrophoneEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
#pragma warning disable 0169
			static Delegate GetOnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler ()
			{
				if (cb_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == null)
					cb_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_);
				return cb_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
			}

			static void n_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalMicrophoneAdded (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
			public unsafe void OnLocalMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
			{
				if (id_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == IntPtr.Zero)
					id_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNIEnv.GetMethodID (class_ref, "OnLocalMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_, __args);
			}

			static Delegate cb_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
#pragma warning disable 0169
			static Delegate GetOnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler ()
			{
				if (cb_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == null)
					cb_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_);
				return cb_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
			}

			static void n_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalMicrophoneRemoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
			public unsafe void OnLocalMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
			{
				if (id_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == IntPtr.Zero)
					id_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNIEnv.GetMethodID (class_ref, "OnLocalMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_, __args);
			}

			static Delegate cb_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
#pragma warning disable 0169
			static Delegate GetOnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler ()
			{
				if (cb_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == null)
					cb_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_);
				return cb_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
			}

			static void n_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalMicrophoneSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
			public unsafe void OnLocalMicrophoneSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
			{
				if (id_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == IntPtr.Zero)
					id_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNIEnv.GetMethodID (class_ref, "OnLocalMicrophoneSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_, __args);
			}

			static Delegate cb_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalMicrophoneStateUpdated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnLocalMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				if (id_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class LocalMicrophoneAddedEventArgs : global::System.EventArgs {

			public LocalMicrophoneAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone P0 {
				get { return p0; }
			}
		}

		public partial class LocalMicrophoneRemovedEventArgs : global::System.EventArgs {

			public LocalMicrophoneRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone P0 {
				get { return p0; }
			}
		}

		public partial class LocalMicrophoneSelectedEventArgs : global::System.EventArgs {

			public LocalMicrophoneSelectedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone P0 {
				get { return p0; }
			}
		}

		public partial class LocalMicrophoneStateUpdatedEventArgs : global::System.EventArgs {

			public LocalMicrophoneStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLocalMicrophoneEventListenerImplementor")]
		internal sealed partial class IRegisterLocalMicrophoneEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalMicrophoneEventListener {

			object sender;

			public IRegisterLocalMicrophoneEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLocalMicrophoneEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<LocalMicrophoneAddedEventArgs> OnLocalMicrophoneAddedHandler;
#pragma warning restore 0649

			public void OnLocalMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
			{
				var __h = OnLocalMicrophoneAddedHandler;
				if (__h != null)
					__h (sender, new LocalMicrophoneAddedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalMicrophoneRemovedEventArgs> OnLocalMicrophoneRemovedHandler;
#pragma warning restore 0649

			public void OnLocalMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
			{
				var __h = OnLocalMicrophoneRemovedHandler;
				if (__h != null)
					__h (sender, new LocalMicrophoneRemovedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalMicrophoneSelectedEventArgs> OnLocalMicrophoneSelectedHandler;
#pragma warning restore 0649

			public void OnLocalMicrophoneSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
			{
				var __h = OnLocalMicrophoneSelectedHandler;
				if (__h != null)
					__h (sender, new LocalMicrophoneSelectedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalMicrophoneStateUpdatedEventArgs> OnLocalMicrophoneStateUpdatedHandler;
#pragma warning restore 0649

			public void OnLocalMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				var __h = OnLocalMicrophoneStateUpdatedHandler;
				if (__h != null)
					__h (sender, new LocalMicrophoneStateUpdatedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRegisterLocalMicrophoneEventListenerImplementor value)
			{
				return value.OnLocalMicrophoneAddedHandler == null && value.OnLocalMicrophoneRemovedHandler == null && value.OnLocalMicrophoneSelectedHandler == null && value.OnLocalMicrophoneStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalMonitorEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMonitorEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMonitorEventListenerInvoker")]
		public partial interface IRegisterLocalMonitorEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalMonitorEventListener']/method[@name='OnLocalMonitorAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
			[Register ("OnLocalMonitorAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetOnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMonitorAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalMonitorEventListener']/method[@name='OnLocalMonitorRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
			[Register ("OnLocalMonitorRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetOnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMonitorRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalMonitorEventListener']/method[@name='OnLocalMonitorSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
			[Register ("OnLocalMonitorSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetOnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMonitorSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalMonitorEventListener']/method[@name='OnLocalMonitorStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalMonitorStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMonitorStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMonitorEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalMonitorEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalMonitorEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMonitorEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterLocalMonitorEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterLocalMonitorEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterLocalMonitorEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterLocalMonitorEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
#pragma warning disable 0169
			static Delegate GetOnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler ()
			{
				if (cb_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == null)
					cb_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_);
				return cb_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
			}

			static void n_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalMonitorAdded (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
			public unsafe void OnLocalMonitorAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
			{
				if (id_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == IntPtr.Zero)
					id_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNIEnv.GetMethodID (class_ref, "OnLocalMonitorAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_, __args);
			}

			static Delegate cb_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
#pragma warning disable 0169
			static Delegate GetOnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler ()
			{
				if (cb_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == null)
					cb_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_);
				return cb_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
			}

			static void n_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalMonitorRemoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
			public unsafe void OnLocalMonitorRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
			{
				if (id_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == IntPtr.Zero)
					id_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNIEnv.GetMethodID (class_ref, "OnLocalMonitorRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_, __args);
			}

			static Delegate cb_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
#pragma warning disable 0169
			static Delegate GetOnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler ()
			{
				if (cb_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == null)
					cb_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_);
				return cb_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
			}

			static void n_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalMonitorSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
			public unsafe void OnLocalMonitorSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
			{
				if (id_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == IntPtr.Zero)
					id_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNIEnv.GetMethodID (class_ref, "OnLocalMonitorSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_, __args);
			}

			static Delegate cb_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalMonitorStateUpdated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnLocalMonitorStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				if (id_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalMonitorStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class LocalMonitorAddedEventArgs : global::System.EventArgs {

			public LocalMonitorAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor P0 {
				get { return p0; }
			}
		}

		public partial class LocalMonitorRemovedEventArgs : global::System.EventArgs {

			public LocalMonitorRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor P0 {
				get { return p0; }
			}
		}

		public partial class LocalMonitorSelectedEventArgs : global::System.EventArgs {

			public LocalMonitorSelectedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor P0 {
				get { return p0; }
			}
		}

		public partial class LocalMonitorStateUpdatedEventArgs : global::System.EventArgs {

			public LocalMonitorStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLocalMonitorEventListenerImplementor")]
		internal sealed partial class IRegisterLocalMonitorEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalMonitorEventListener {

			object sender;

			public IRegisterLocalMonitorEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLocalMonitorEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<LocalMonitorAddedEventArgs> OnLocalMonitorAddedHandler;
#pragma warning restore 0649

			public void OnLocalMonitorAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
			{
				var __h = OnLocalMonitorAddedHandler;
				if (__h != null)
					__h (sender, new LocalMonitorAddedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalMonitorRemovedEventArgs> OnLocalMonitorRemovedHandler;
#pragma warning restore 0649

			public void OnLocalMonitorRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
			{
				var __h = OnLocalMonitorRemovedHandler;
				if (__h != null)
					__h (sender, new LocalMonitorRemovedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalMonitorSelectedEventArgs> OnLocalMonitorSelectedHandler;
#pragma warning restore 0649

			public void OnLocalMonitorSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
			{
				var __h = OnLocalMonitorSelectedHandler;
				if (__h != null)
					__h (sender, new LocalMonitorSelectedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalMonitorStateUpdatedEventArgs> OnLocalMonitorStateUpdatedHandler;
#pragma warning restore 0649

			public void OnLocalMonitorStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				var __h = OnLocalMonitorStateUpdatedHandler;
				if (__h != null)
					__h (sender, new LocalMonitorStateUpdatedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRegisterLocalMonitorEventListenerImplementor value)
			{
				return value.OnLocalMonitorAddedHandler == null && value.OnLocalMonitorRemovedHandler == null && value.OnLocalMonitorSelectedHandler == null && value.OnLocalMonitorStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalSpeakerEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalSpeakerEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalSpeakerEventListenerInvoker")]
		public partial interface IRegisterLocalSpeakerEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalSpeakerEventListener']/method[@name='OnLocalSpeakerAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
			[Register ("OnLocalSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetOnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalSpeakerAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalSpeakerEventListener']/method[@name='OnLocalSpeakerRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
			[Register ("OnLocalSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetOnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalSpeakerRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalSpeakerEventListener']/method[@name='OnLocalSpeakerSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
			[Register ("OnLocalSpeakerSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetOnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalSpeakerSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalSpeakerEventListener']/method[@name='OnLocalSpeakerStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalSpeakerStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalSpeakerStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalSpeakerEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalSpeakerEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalSpeakerEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalSpeakerEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterLocalSpeakerEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterLocalSpeakerEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterLocalSpeakerEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterLocalSpeakerEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
			static Delegate GetOnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
			{
				if (cb_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
					cb_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
				return cb_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
			}

			static void n_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalSpeakerAdded (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
			public unsafe void OnLocalSpeakerAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
			{
				if (id_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
					id_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "OnLocalSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
			}

			static Delegate cb_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
			static Delegate GetOnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
			{
				if (cb_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
					cb_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
				return cb_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
			}

			static void n_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalSpeakerRemoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
			public unsafe void OnLocalSpeakerRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
			{
				if (id_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
					id_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "OnLocalSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
			}

			static Delegate cb_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
			static Delegate GetOnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
			{
				if (cb_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
					cb_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
				return cb_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
			}

			static void n_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalSpeakerSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
			public unsafe void OnLocalSpeakerSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
			{
				if (id_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
					id_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "OnLocalSpeakerSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
			}

			static Delegate cb_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalSpeakerStateUpdated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnLocalSpeakerStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				if (id_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalSpeakerStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class LocalSpeakerAddedEventArgs : global::System.EventArgs {

			public LocalSpeakerAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker P0 {
				get { return p0; }
			}
		}

		public partial class LocalSpeakerRemovedEventArgs : global::System.EventArgs {

			public LocalSpeakerRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker P0 {
				get { return p0; }
			}
		}

		public partial class LocalSpeakerSelectedEventArgs : global::System.EventArgs {

			public LocalSpeakerSelectedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker P0 {
				get { return p0; }
			}
		}

		public partial class LocalSpeakerStateUpdatedEventArgs : global::System.EventArgs {

			public LocalSpeakerStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLocalSpeakerEventListenerImplementor")]
		internal sealed partial class IRegisterLocalSpeakerEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalSpeakerEventListener {

			object sender;

			public IRegisterLocalSpeakerEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLocalSpeakerEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<LocalSpeakerAddedEventArgs> OnLocalSpeakerAddedHandler;
#pragma warning restore 0649

			public void OnLocalSpeakerAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
			{
				var __h = OnLocalSpeakerAddedHandler;
				if (__h != null)
					__h (sender, new LocalSpeakerAddedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalSpeakerRemovedEventArgs> OnLocalSpeakerRemovedHandler;
#pragma warning restore 0649

			public void OnLocalSpeakerRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
			{
				var __h = OnLocalSpeakerRemovedHandler;
				if (__h != null)
					__h (sender, new LocalSpeakerRemovedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalSpeakerSelectedEventArgs> OnLocalSpeakerSelectedHandler;
#pragma warning restore 0649

			public void OnLocalSpeakerSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
			{
				var __h = OnLocalSpeakerSelectedHandler;
				if (__h != null)
					__h (sender, new LocalSpeakerSelectedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalSpeakerStateUpdatedEventArgs> OnLocalSpeakerStateUpdatedHandler;
#pragma warning restore 0649

			public void OnLocalSpeakerStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				var __h = OnLocalSpeakerStateUpdatedHandler;
				if (__h != null)
					__h (sender, new LocalSpeakerStateUpdatedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRegisterLocalSpeakerEventListenerImplementor value)
			{
				return value.OnLocalSpeakerAddedHandler == null && value.OnLocalSpeakerRemovedHandler == null && value.OnLocalSpeakerSelectedHandler == null && value.OnLocalSpeakerStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalWindowShareEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalWindowShareEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalWindowShareEventListenerInvoker")]
		public partial interface IRegisterLocalWindowShareEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalWindowShareEventListener']/method[@name='OnLocalWindowShareAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
			[Register ("OnLocalWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetOnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalWindowShareEventListener']/method[@name='OnLocalWindowShareRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
			[Register ("OnLocalWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetOnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalWindowShareEventListener']/method[@name='OnLocalWindowShareSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
			[Register ("OnLocalWindowShareSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetOnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalWindowShareSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLocalWindowShareEventListener']/method[@name='OnLocalWindowShareStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalWindowShareEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalWindowShareEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalWindowShareEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalWindowShareEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterLocalWindowShareEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterLocalWindowShareEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterLocalWindowShareEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterLocalWindowShareEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
			static Delegate GetOnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
			{
				if (cb_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
					cb_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
				return cb_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
			}

			static void n_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalWindowShareAdded (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
			public unsafe void OnLocalWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
			{
				if (id_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
					id_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "OnLocalWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
			}

			static Delegate cb_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
			static Delegate GetOnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
			{
				if (cb_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
					cb_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
				return cb_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
			}

			static void n_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalWindowShareRemoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
			public unsafe void OnLocalWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
			{
				if (id_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
					id_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "OnLocalWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
			}

			static Delegate cb_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
			static Delegate GetOnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
			{
				if (cb_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
					cb_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
				return cb_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
			}

			static void n_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalWindowShareSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
			public unsafe void OnLocalWindowShareSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
			{
				if (id_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
					id_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "OnLocalWindowShareSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
			}

			static Delegate cb_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalWindowShareStateUpdated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnLocalWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				if (id_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class LocalWindowShareAddedEventArgs : global::System.EventArgs {

			public LocalWindowShareAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare P0 {
				get { return p0; }
			}
		}

		public partial class LocalWindowShareRemovedEventArgs : global::System.EventArgs {

			public LocalWindowShareRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare P0 {
				get { return p0; }
			}
		}

		public partial class LocalWindowShareSelectedEventArgs : global::System.EventArgs {

			public LocalWindowShareSelectedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare P0 {
				get { return p0; }
			}
		}

		public partial class LocalWindowShareStateUpdatedEventArgs : global::System.EventArgs {

			public LocalWindowShareStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLocalWindowShareEventListenerImplementor")]
		internal sealed partial class IRegisterLocalWindowShareEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalWindowShareEventListener {

			object sender;

			public IRegisterLocalWindowShareEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLocalWindowShareEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<LocalWindowShareAddedEventArgs> OnLocalWindowShareAddedHandler;
#pragma warning restore 0649

			public void OnLocalWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
			{
				var __h = OnLocalWindowShareAddedHandler;
				if (__h != null)
					__h (sender, new LocalWindowShareAddedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalWindowShareRemovedEventArgs> OnLocalWindowShareRemovedHandler;
#pragma warning restore 0649

			public void OnLocalWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
			{
				var __h = OnLocalWindowShareRemovedHandler;
				if (__h != null)
					__h (sender, new LocalWindowShareRemovedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalWindowShareSelectedEventArgs> OnLocalWindowShareSelectedHandler;
#pragma warning restore 0649

			public void OnLocalWindowShareSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
			{
				var __h = OnLocalWindowShareSelectedHandler;
				if (__h != null)
					__h (sender, new LocalWindowShareSelectedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalWindowShareStateUpdatedEventArgs> OnLocalWindowShareStateUpdatedHandler;
#pragma warning restore 0649

			public void OnLocalWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				var __h = OnLocalWindowShareStateUpdatedHandler;
				if (__h != null)
					__h (sender, new LocalWindowShareStateUpdatedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRegisterLocalWindowShareEventListenerImplementor value)
			{
				return value.OnLocalWindowShareAddedHandler == null && value.OnLocalWindowShareRemovedHandler == null && value.OnLocalWindowShareSelectedHandler == null && value.OnLocalWindowShareStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLogEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLogEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLogEventListenerInvoker")]
		public partial interface IRegisterLogEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterLogEventListener']/method[@name='OnLog' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoLogRecord']]"
			[Register ("OnLog", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord;)V", "GetOnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLogEventListenerInvoker, VidyoClientAndroid")]
			void OnLog (global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLogEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLogEventListenerInvoker : global::Java.Lang.Object, IRegisterLogEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLogEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterLogEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterLogEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterLogEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLogEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterLogEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_;
#pragma warning disable 0169
			static Delegate GetOnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_Handler ()
			{
				if (cb_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_ == null)
					cb_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_);
				return cb_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_;
			}

			static void n_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLogEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLogEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLog (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_;
			public unsafe void OnLog (global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord p0)
			{
				if (id_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_ == IntPtr.Zero)
					id_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_ = JNIEnv.GetMethodID (class_ref, "OnLog", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_, __args);
			}

		}

		public partial class RegisterLogEventEventArgs : global::System.EventArgs {

			public RegisterLogEventEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLogEventListenerImplementor")]
		internal sealed partial class IRegisterLogEventListenerImplementor : global::Java.Lang.Object, IRegisterLogEventListener {

			object sender;

			public IRegisterLogEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterLogEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RegisterLogEventEventArgs> Handler;
#pragma warning restore 0649

			public void OnLog (global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RegisterLogEventEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterLogEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterMessageEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterMessageEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterMessageEventListenerInvoker")]
		public partial interface IRegisterMessageEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterMessageEventListener']/method[@name='OnChatMessageReceived' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage']]"
			[Register ("OnChatMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V", "GetOnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterMessageEventListenerInvoker, VidyoClientAndroid")]
			void OnChatMessageReceived (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterMessageEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterMessageEventListenerInvoker : global::Java.Lang.Object, IRegisterMessageEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterMessageEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterMessageEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterMessageEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterMessageEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterMessageEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterMessageEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
#pragma warning disable 0169
			static Delegate GetOnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler ()
			{
				if (cb_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == null)
					cb_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_);
				return cb_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
			}

			static void n_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterMessageEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterMessageEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnChatMessageReceived (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
			public unsafe void OnChatMessageReceived (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1)
			{
				if (id_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == IntPtr.Zero)
					id_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNIEnv.GetMethodID (class_ref, "OnChatMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_, __args);
			}

		}

		public partial class RegisterMessageEventEventArgs : global::System.EventArgs {

			public RegisterMessageEventEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterMessageEventListenerImplementor")]
		internal sealed partial class IRegisterMessageEventListenerImplementor : global::Java.Lang.Object, IRegisterMessageEventListener {

			object sender;

			public IRegisterMessageEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterMessageEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RegisterMessageEventEventArgs> Handler;
#pragma warning restore 0649

			public void OnChatMessageReceived (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RegisterMessageEventEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRegisterMessageEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterNetworkInterfaceEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterNetworkInterfaceEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterNetworkInterfaceEventListenerInvoker")]
		public partial interface IRegisterNetworkInterfaceEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterNetworkInterfaceEventListener']/method[@name='OnNetworkInterfaceAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
			[Register ("OnNetworkInterfaceAdded", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V", "GetOnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid")]
			void OnNetworkInterfaceAdded (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterNetworkInterfaceEventListener']/method[@name='OnNetworkInterfaceRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
			[Register ("OnNetworkInterfaceRemoved", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V", "GetOnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid")]
			void OnNetworkInterfaceRemoved (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterNetworkInterfaceEventListener']/method[@name='OnNetworkInterfaceSelected' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType']]"
			[Register ("OnNetworkInterfaceSelected", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;)V", "GetOnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid")]
			void OnNetworkInterfaceSelected (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterNetworkInterfaceEventListener']/method[@name='OnNetworkInterfaceStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState']]"
			[Register ("OnNetworkInterfaceStateUpdated", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;)V", "GetOnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid")]
			void OnNetworkInterfaceStateUpdated (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterNetworkInterfaceEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterNetworkInterfaceEventListenerInvoker : global::Java.Lang.Object, IRegisterNetworkInterfaceEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterNetworkInterfaceEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterNetworkInterfaceEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterNetworkInterfaceEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterNetworkInterfaceEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterNetworkInterfaceEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
#pragma warning disable 0169
			static Delegate GetOnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler ()
			{
				if (cb_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == null)
					cb_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_);
				return cb_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
			}

			static void n_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkInterfaceAdded (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
			public unsafe void OnNetworkInterfaceAdded (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0)
			{
				if (id_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == IntPtr.Zero)
					id_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNIEnv.GetMethodID (class_ref, "OnNetworkInterfaceAdded", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_, __args);
			}

			static Delegate cb_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
#pragma warning disable 0169
			static Delegate GetOnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler ()
			{
				if (cb_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == null)
					cb_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_);
				return cb_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
			}

			static void n_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkInterfaceRemoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
			public unsafe void OnNetworkInterfaceRemoved (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0)
			{
				if (id_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == IntPtr.Zero)
					id_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNIEnv.GetMethodID (class_ref, "OnNetworkInterfaceRemoved", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_, __args);
			}

			static Delegate cb_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_;
#pragma warning disable 0169
			static Delegate GetOnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_Handler ()
			{
				if (cb_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_ == null)
					cb_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_);
				return cb_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_;
			}

			static void n_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkInterfaceSelected (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_;
			public unsafe void OnNetworkInterfaceSelected (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1)
			{
				if (id_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_ == IntPtr.Zero)
					id_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_ = JNIEnv.GetMethodID (class_ref, "OnNetworkInterfaceSelected", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_, __args);
			}

			static Delegate cb_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_;
#pragma warning disable 0169
			static Delegate GetOnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_Handler ()
			{
				if (cb_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_ == null)
					cb_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_);
				return cb_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_;
			}

			static void n_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkInterfaceStateUpdated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_;
			public unsafe void OnNetworkInterfaceStateUpdated (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1)
			{
				if (id_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_ == IntPtr.Zero)
					id_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_ = JNIEnv.GetMethodID (class_ref, "OnNetworkInterfaceStateUpdated", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_, __args);
			}

		}

		public partial class NetworkInterfaceAddedEventArgs : global::System.EventArgs {

			public NetworkInterfaceAddedEventArgs (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0;
			public global::Com.Vidyo.VidyoClient.VidyoNetworkInterface P0 {
				get { return p0; }
			}
		}

		public partial class NetworkInterfaceRemovedEventArgs : global::System.EventArgs {

			public NetworkInterfaceRemovedEventArgs (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0;
			public global::Com.Vidyo.VidyoClient.VidyoNetworkInterface P0 {
				get { return p0; }
			}
		}

		public partial class NetworkInterfaceSelectedEventArgs : global::System.EventArgs {

			public NetworkInterfaceSelectedEventArgs (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0;
			public global::Com.Vidyo.VidyoClient.VidyoNetworkInterface P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1;
			public global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType P1 {
				get { return p1; }
			}
		}

		public partial class NetworkInterfaceStateUpdatedEventArgs : global::System.EventArgs {

			public NetworkInterfaceStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0;
			public global::Com.Vidyo.VidyoClient.VidyoNetworkInterface P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1;
			public global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterNetworkInterfaceEventListenerImplementor")]
		internal sealed partial class IRegisterNetworkInterfaceEventListenerImplementor : global::Java.Lang.Object, IRegisterNetworkInterfaceEventListener {

			object sender;

			public IRegisterNetworkInterfaceEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterNetworkInterfaceEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NetworkInterfaceAddedEventArgs> OnNetworkInterfaceAddedHandler;
#pragma warning restore 0649

			public void OnNetworkInterfaceAdded (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0)
			{
				var __h = OnNetworkInterfaceAddedHandler;
				if (__h != null)
					__h (sender, new NetworkInterfaceAddedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<NetworkInterfaceRemovedEventArgs> OnNetworkInterfaceRemovedHandler;
#pragma warning restore 0649

			public void OnNetworkInterfaceRemoved (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0)
			{
				var __h = OnNetworkInterfaceRemovedHandler;
				if (__h != null)
					__h (sender, new NetworkInterfaceRemovedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<NetworkInterfaceSelectedEventArgs> OnNetworkInterfaceSelectedHandler;
#pragma warning restore 0649

			public void OnNetworkInterfaceSelected (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1)
			{
				var __h = OnNetworkInterfaceSelectedHandler;
				if (__h != null)
					__h (sender, new NetworkInterfaceSelectedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<NetworkInterfaceStateUpdatedEventArgs> OnNetworkInterfaceStateUpdatedHandler;
#pragma warning restore 0649

			public void OnNetworkInterfaceStateUpdated (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1)
			{
				var __h = OnNetworkInterfaceStateUpdatedHandler;
				if (__h != null)
					__h (sender, new NetworkInterfaceStateUpdatedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRegisterNetworkInterfaceEventListenerImplementor value)
			{
				return value.OnNetworkInterfaceAddedHandler == null && value.OnNetworkInterfaceRemovedHandler == null && value.OnNetworkInterfaceSelectedHandler == null && value.OnNetworkInterfaceStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterParticipantEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterParticipantEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterParticipantEventListenerInvoker")]
		public partial interface IRegisterParticipantEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterParticipantEventListener']/method[@name='OnDynamicParticipantChanged' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoParticipant&gt;'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoRemoteCamera&gt;']]"
			[Register ("OnDynamicParticipantChanged", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", "GetOnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid")]
			void OnDynamicParticipantChanged (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterParticipantEventListener']/method[@name='OnLoudestParticipantChanged' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='boolean']]"
			[Register ("OnLoudestParticipantChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V", "GetOnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ZHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid")]
			void OnLoudestParticipantChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, bool p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterParticipantEventListener']/method[@name='OnParticipantJoined' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnParticipantJoined", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid")]
			void OnParticipantJoined (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterParticipantEventListener']/method[@name='OnParticipantLeft' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnParticipantLeft", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid")]
			void OnParticipantLeft (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterParticipantEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterParticipantEventListenerInvoker : global::Java.Lang.Object, IRegisterParticipantEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterParticipantEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterParticipantEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterParticipantEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterParticipantEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterParticipantEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetOnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
			{
				if (cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
					cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_);
				return cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
			}

			static void n_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDynamicParticipantChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
			public unsafe void OnDynamicParticipantChanged (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1)
			{
				if (id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "OnDynamicParticipantChanged", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant>.ToLocalJniHandle (p0);
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera>.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
#pragma warning disable 0169
			static Delegate GetOnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ZHandler ()
			{
				if (cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z == null)
					cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z);
				return cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
			}

			static void n_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoudestParticipantChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
			public unsafe void OnLoudestParticipantChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, bool p1)
			{
				if (id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z == IntPtr.Zero)
					id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z = JNIEnv.GetMethodID (class_ref, "OnLoudestParticipantChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z, __args);
			}

			static Delegate cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnParticipantJoined (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnParticipantJoined (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				if (id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnParticipantJoined", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnParticipantLeft (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnParticipantLeft (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				if (id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnParticipantLeft", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

		}

		public partial class DynamicParticipantChangedEventArgs : global::System.EventArgs {

			public DynamicParticipantChangedEventArgs (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0;
			public global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> P0 {
				get { return p0; }
			}

			global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1;
			public global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> P1 {
				get { return p1; }
			}
		}

		public partial class LoudestParticipantChangedEventArgs : global::System.EventArgs {

			public LoudestParticipantChangedEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, bool p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P0 {
				get { return p0; }
			}

			bool p1;
			public bool P1 {
				get { return p1; }
			}
		}

		public partial class ParticipantJoinedEventArgs : global::System.EventArgs {

			public ParticipantJoinedEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P0 {
				get { return p0; }
			}
		}

		public partial class ParticipantLeftEventArgs : global::System.EventArgs {

			public ParticipantLeftEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterParticipantEventListenerImplementor")]
		internal sealed partial class IRegisterParticipantEventListenerImplementor : global::Java.Lang.Object, IRegisterParticipantEventListener {

			object sender;

			public IRegisterParticipantEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterParticipantEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DynamicParticipantChangedEventArgs> OnDynamicParticipantChangedHandler;
#pragma warning restore 0649

			public void OnDynamicParticipantChanged (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1)
			{
				var __h = OnDynamicParticipantChangedHandler;
				if (__h != null)
					__h (sender, new DynamicParticipantChangedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<LoudestParticipantChangedEventArgs> OnLoudestParticipantChangedHandler;
#pragma warning restore 0649

			public void OnLoudestParticipantChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, bool p1)
			{
				var __h = OnLoudestParticipantChangedHandler;
				if (__h != null)
					__h (sender, new LoudestParticipantChangedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<ParticipantJoinedEventArgs> OnParticipantJoinedHandler;
#pragma warning restore 0649

			public void OnParticipantJoined (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				var __h = OnParticipantJoinedHandler;
				if (__h != null)
					__h (sender, new ParticipantJoinedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ParticipantLeftEventArgs> OnParticipantLeftHandler;
#pragma warning restore 0649

			public void OnParticipantLeft (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				var __h = OnParticipantLeftHandler;
				if (__h != null)
					__h (sender, new ParticipantLeftEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterParticipantEventListenerImplementor value)
			{
				return value.OnDynamicParticipantChangedHandler == null && value.OnLoudestParticipantChangedHandler == null && value.OnParticipantJoinedHandler == null && value.OnParticipantLeftHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRecoderInCallEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRecoderInCallEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRecoderInCallEventListenerInvoker")]
		public partial interface IRegisterRecoderInCallEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRecoderInCallEventListener']/method[@name='RecorderInCall' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("RecorderInCall", "(Z)V", "GetRecorderInCall_ZHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRecoderInCallEventListenerInvoker, VidyoClientAndroid")]
			void RecorderInCall (bool p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRecoderInCallEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRecoderInCallEventListenerInvoker : global::Java.Lang.Object, IRegisterRecoderInCallEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRecoderInCallEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterRecoderInCallEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterRecoderInCallEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterRecoderInCallEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRecoderInCallEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterRecoderInCallEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_RecorderInCall_Z;
#pragma warning disable 0169
			static Delegate GetRecorderInCall_ZHandler ()
			{
				if (cb_RecorderInCall_Z == null)
					cb_RecorderInCall_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_RecorderInCall_Z);
				return cb_RecorderInCall_Z;
			}

			static void n_RecorderInCall_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRecoderInCallEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRecoderInCallEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.RecorderInCall (p0);
			}
#pragma warning restore 0169

			IntPtr id_RecorderInCall_Z;
			public unsafe void RecorderInCall (bool p0)
			{
				if (id_RecorderInCall_Z == IntPtr.Zero)
					id_RecorderInCall_Z = JNIEnv.GetMethodID (class_ref, "RecorderInCall", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RecorderInCall_Z, __args);
			}

		}

		public partial class RegisterRecoderInCallEventEventArgs : global::System.EventArgs {

			public RegisterRecoderInCallEventEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterRecoderInCallEventListenerImplementor")]
		internal sealed partial class IRegisterRecoderInCallEventListenerImplementor : global::Java.Lang.Object, IRegisterRecoderInCallEventListener {

			object sender;

			public IRegisterRecoderInCallEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterRecoderInCallEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RegisterRecoderInCallEventEventArgs> Handler;
#pragma warning restore 0649

			public void RecorderInCall (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RegisterRecoderInCallEventEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterRecoderInCallEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteCameraEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteCameraEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteCameraEventListenerInvoker")]
		public partial interface IRegisterRemoteCameraEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteCameraEventListener']/method[@name='OnRemoteCameraAdded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteCameraEventListener']/method[@name='OnRemoteCameraRemoved' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteCameraEventListener']/method[@name='OnRemoteCameraStateUpdated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnRemoteCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteCameraEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRemoteCameraEventListenerInvoker : global::Java.Lang.Object, IRegisterRemoteCameraEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteCameraEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterRemoteCameraEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterRemoteCameraEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterRemoteCameraEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterRemoteCameraEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteCameraAdded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				if (id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteCameraRemoved (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				if (id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteCameraStateUpdated (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnRemoteCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
			{
				if (id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class RemoteCameraAddedEventArgs : global::System.EventArgs {

			public RemoteCameraAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P1 {
				get { return p1; }
			}
		}

		public partial class RemoteCameraRemovedEventArgs : global::System.EventArgs {

			public RemoteCameraRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P1 {
				get { return p1; }
			}
		}

		public partial class RemoteCameraStateUpdatedEventArgs : global::System.EventArgs {

			public RemoteCameraStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterRemoteCameraEventListenerImplementor")]
		internal sealed partial class IRegisterRemoteCameraEventListenerImplementor : global::Java.Lang.Object, IRegisterRemoteCameraEventListener {

			object sender;

			public IRegisterRemoteCameraEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterRemoteCameraEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoteCameraAddedEventArgs> OnRemoteCameraAddedHandler;
#pragma warning restore 0649

			public void OnRemoteCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				var __h = OnRemoteCameraAddedHandler;
				if (__h != null)
					__h (sender, new RemoteCameraAddedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<RemoteCameraRemovedEventArgs> OnRemoteCameraRemovedHandler;
#pragma warning restore 0649

			public void OnRemoteCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				var __h = OnRemoteCameraRemovedHandler;
				if (__h != null)
					__h (sender, new RemoteCameraRemovedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<RemoteCameraStateUpdatedEventArgs> OnRemoteCameraStateUpdatedHandler;
#pragma warning restore 0649

			public void OnRemoteCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
			{
				var __h = OnRemoteCameraStateUpdatedHandler;
				if (__h != null)
					__h (sender, new RemoteCameraStateUpdatedEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IRegisterRemoteCameraEventListenerImplementor value)
			{
				return value.OnRemoteCameraAddedHandler == null && value.OnRemoteCameraRemovedHandler == null && value.OnRemoteCameraStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteMicrophoneEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteMicrophoneEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteMicrophoneEventListenerInvoker")]
		public partial interface IRegisterRemoteMicrophoneEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteMicrophoneEventListener']/method[@name='OnRemoteMicrophoneAdded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteMicrophoneEventListener']/method[@name='OnRemoteMicrophoneRemoved' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteMicrophoneEventListener']/method[@name='OnRemoteMicrophoneStateUpdated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnRemoteMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteMicrophoneEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRemoteMicrophoneEventListenerInvoker : global::Java.Lang.Object, IRegisterRemoteMicrophoneEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteMicrophoneEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterRemoteMicrophoneEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterRemoteMicrophoneEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterRemoteMicrophoneEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterRemoteMicrophoneEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteMicrophoneAdded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				if (id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteMicrophoneRemoved (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				if (id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteMicrophoneStateUpdated (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnRemoteMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
			{
				if (id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class RemoteMicrophoneAddedEventArgs : global::System.EventArgs {

			public RemoteMicrophoneAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P1 {
				get { return p1; }
			}
		}

		public partial class RemoteMicrophoneRemovedEventArgs : global::System.EventArgs {

			public RemoteMicrophoneRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P1 {
				get { return p1; }
			}
		}

		public partial class RemoteMicrophoneStateUpdatedEventArgs : global::System.EventArgs {

			public RemoteMicrophoneStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterRemoteMicrophoneEventListenerImplementor")]
		internal sealed partial class IRegisterRemoteMicrophoneEventListenerImplementor : global::Java.Lang.Object, IRegisterRemoteMicrophoneEventListener {

			object sender;

			public IRegisterRemoteMicrophoneEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterRemoteMicrophoneEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoteMicrophoneAddedEventArgs> OnRemoteMicrophoneAddedHandler;
#pragma warning restore 0649

			public void OnRemoteMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				var __h = OnRemoteMicrophoneAddedHandler;
				if (__h != null)
					__h (sender, new RemoteMicrophoneAddedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<RemoteMicrophoneRemovedEventArgs> OnRemoteMicrophoneRemovedHandler;
#pragma warning restore 0649

			public void OnRemoteMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				var __h = OnRemoteMicrophoneRemovedHandler;
				if (__h != null)
					__h (sender, new RemoteMicrophoneRemovedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<RemoteMicrophoneStateUpdatedEventArgs> OnRemoteMicrophoneStateUpdatedHandler;
#pragma warning restore 0649

			public void OnRemoteMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
			{
				var __h = OnRemoteMicrophoneStateUpdatedHandler;
				if (__h != null)
					__h (sender, new RemoteMicrophoneStateUpdatedEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IRegisterRemoteMicrophoneEventListenerImplementor value)
			{
				return value.OnRemoteMicrophoneAddedHandler == null && value.OnRemoteMicrophoneRemovedHandler == null && value.OnRemoteMicrophoneStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteWindowShareEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteWindowShareEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteWindowShareEventListenerInvoker")]
		public partial interface IRegisterRemoteWindowShareEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteWindowShareEventListener']/method[@name='OnRemoteWindowShareAdded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteWindowShareEventListener']/method[@name='OnRemoteWindowShareRemoved' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterRemoteWindowShareEventListener']/method[@name='OnRemoteWindowShareStateUpdated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnRemoteWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteWindowShareEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRemoteWindowShareEventListenerInvoker : global::Java.Lang.Object, IRegisterRemoteWindowShareEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteWindowShareEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterRemoteWindowShareEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterRemoteWindowShareEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterRemoteWindowShareEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterRemoteWindowShareEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteWindowShareAdded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				if (id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteWindowShareRemoved (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				if (id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteWindowShareStateUpdated (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnRemoteWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
			{
				if (id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class RemoteWindowShareAddedEventArgs : global::System.EventArgs {

			public RemoteWindowShareAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P1 {
				get { return p1; }
			}
		}

		public partial class RemoteWindowShareRemovedEventArgs : global::System.EventArgs {

			public RemoteWindowShareRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P1 {
				get { return p1; }
			}
		}

		public partial class RemoteWindowShareStateUpdatedEventArgs : global::System.EventArgs {

			public RemoteWindowShareStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterRemoteWindowShareEventListenerImplementor")]
		internal sealed partial class IRegisterRemoteWindowShareEventListenerImplementor : global::Java.Lang.Object, IRegisterRemoteWindowShareEventListener {

			object sender;

			public IRegisterRemoteWindowShareEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterRemoteWindowShareEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoteWindowShareAddedEventArgs> OnRemoteWindowShareAddedHandler;
#pragma warning restore 0649

			public void OnRemoteWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				var __h = OnRemoteWindowShareAddedHandler;
				if (__h != null)
					__h (sender, new RemoteWindowShareAddedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<RemoteWindowShareRemovedEventArgs> OnRemoteWindowShareRemovedHandler;
#pragma warning restore 0649

			public void OnRemoteWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				var __h = OnRemoteWindowShareRemovedHandler;
				if (__h != null)
					__h (sender, new RemoteWindowShareRemovedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<RemoteWindowShareStateUpdatedEventArgs> OnRemoteWindowShareStateUpdatedHandler;
#pragma warning restore 0649

			public void OnRemoteWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
			{
				var __h = OnRemoteWindowShareStateUpdatedHandler;
				if (__h != null)
					__h (sender, new RemoteWindowShareStateUpdatedEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IRegisterRemoteWindowShareEventListenerImplementor value)
			{
				return value.OnRemoteWindowShareAddedHandler == null && value.OnRemoteWindowShareRemovedHandler == null && value.OnRemoteWindowShareStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterResourceManagerEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterResourceManagerEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterResourceManagerEventListenerInvoker")]
		public partial interface IRegisterResourceManagerEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterResourceManagerEventListener']/method[@name='OnAvailableResourcesChanged' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("OnAvailableResourcesChanged", "(IIII)V", "GetOnAvailableResourcesChanged_IIIIHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterResourceManagerEventListenerInvoker, VidyoClientAndroid")]
			void OnAvailableResourcesChanged (int p0, int p1, int p2, int p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterResourceManagerEventListener']/method[@name='OnMaxRemoteSourcesChanged' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("OnMaxRemoteSourcesChanged", "(I)V", "GetOnMaxRemoteSourcesChanged_IHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterResourceManagerEventListenerInvoker, VidyoClientAndroid")]
			void OnMaxRemoteSourcesChanged (int p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterResourceManagerEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterResourceManagerEventListenerInvoker : global::Java.Lang.Object, IRegisterResourceManagerEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterResourceManagerEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterResourceManagerEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterResourceManagerEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterResourceManagerEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterResourceManagerEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnAvailableResourcesChanged_IIII;
#pragma warning disable 0169
			static Delegate GetOnAvailableResourcesChanged_IIIIHandler ()
			{
				if (cb_OnAvailableResourcesChanged_IIII == null)
					cb_OnAvailableResourcesChanged_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_OnAvailableResourcesChanged_IIII);
				return cb_OnAvailableResourcesChanged_IIII;
			}

			static void n_OnAvailableResourcesChanged_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAvailableResourcesChanged (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnAvailableResourcesChanged_IIII;
			public unsafe void OnAvailableResourcesChanged (int p0, int p1, int p2, int p3)
			{
				if (id_OnAvailableResourcesChanged_IIII == IntPtr.Zero)
					id_OnAvailableResourcesChanged_IIII = JNIEnv.GetMethodID (class_ref, "OnAvailableResourcesChanged", "(IIII)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnAvailableResourcesChanged_IIII, __args);
			}

			static Delegate cb_OnMaxRemoteSourcesChanged_I;
#pragma warning disable 0169
			static Delegate GetOnMaxRemoteSourcesChanged_IHandler ()
			{
				if (cb_OnMaxRemoteSourcesChanged_I == null)
					cb_OnMaxRemoteSourcesChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnMaxRemoteSourcesChanged_I);
				return cb_OnMaxRemoteSourcesChanged_I;
			}

			static void n_OnMaxRemoteSourcesChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMaxRemoteSourcesChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnMaxRemoteSourcesChanged_I;
			public unsafe void OnMaxRemoteSourcesChanged (int p0)
			{
				if (id_OnMaxRemoteSourcesChanged_I == IntPtr.Zero)
					id_OnMaxRemoteSourcesChanged_I = JNIEnv.GetMethodID (class_ref, "OnMaxRemoteSourcesChanged", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMaxRemoteSourcesChanged_I, __args);
			}

		}

		public partial class AvailableResourcesChangedEventArgs : global::System.EventArgs {

			public AvailableResourcesChangedEventArgs (int p0, int p1, int p2, int p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}
		}

		public partial class MaxRemoteSourcesChangedEventArgs : global::System.EventArgs {

			public MaxRemoteSourcesChangedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterResourceManagerEventListenerImplementor")]
		internal sealed partial class IRegisterResourceManagerEventListenerImplementor : global::Java.Lang.Object, IRegisterResourceManagerEventListener {

			object sender;

			public IRegisterResourceManagerEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterResourceManagerEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AvailableResourcesChangedEventArgs> OnAvailableResourcesChangedHandler;
#pragma warning restore 0649

			public void OnAvailableResourcesChanged (int p0, int p1, int p2, int p3)
			{
				var __h = OnAvailableResourcesChangedHandler;
				if (__h != null)
					__h (sender, new AvailableResourcesChangedEventArgs (p0, p1, p2, p3));
			}
#pragma warning disable 0649
			public EventHandler<MaxRemoteSourcesChangedEventArgs> OnMaxRemoteSourcesChangedHandler;
#pragma warning restore 0649

			public void OnMaxRemoteSourcesChanged (int p0)
			{
				var __h = OnMaxRemoteSourcesChangedHandler;
				if (__h != null)
					__h (sender, new MaxRemoteSourcesChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterResourceManagerEventListenerImplementor value)
			{
				return value.OnAvailableResourcesChangedHandler == null && value.OnMaxRemoteSourcesChangedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterWebProxyEventListener']"
		[Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterWebProxyEventListener", "", "Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterWebProxyEventListenerInvoker")]
		public partial interface IRegisterWebProxyEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/interface[@name='VidyoConnector.IRegisterWebProxyEventListener']/method[@name='OnWebProxyCredentialsRequest' and count(parameter)=0]"
			[Register ("OnWebProxyCredentialsRequest", "()V", "GetOnWebProxyCredentialsRequestHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterWebProxyEventListenerInvoker, VidyoClientAndroid")]
			void OnWebProxyCredentialsRequest ();

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterWebProxyEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterWebProxyEventListenerInvoker : global::Java.Lang.Object, IRegisterWebProxyEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterWebProxyEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterWebProxyEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterWebProxyEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterWebProxyEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterWebProxyEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterWebProxyEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnWebProxyCredentialsRequest;
#pragma warning disable 0169
			static Delegate GetOnWebProxyCredentialsRequestHandler ()
			{
				if (cb_OnWebProxyCredentialsRequest == null)
					cb_OnWebProxyCredentialsRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebProxyCredentialsRequest);
				return cb_OnWebProxyCredentialsRequest;
			}

			static void n_OnWebProxyCredentialsRequest (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterWebProxyEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterWebProxyEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWebProxyCredentialsRequest ();
			}
#pragma warning restore 0169

			IntPtr id_OnWebProxyCredentialsRequest;
			public unsafe void OnWebProxyCredentialsRequest ()
			{
				if (id_OnWebProxyCredentialsRequest == IntPtr.Zero)
					id_OnWebProxyCredentialsRequest = JNIEnv.GetMethodID (class_ref, "OnWebProxyCredentialsRequest", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnWebProxyCredentialsRequest);
			}

		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterWebProxyEventListenerImplementor")]
		internal sealed partial class IRegisterWebProxyEventListenerImplementor : global::Java.Lang.Object, IRegisterWebProxyEventListener {

			object sender;

			public IRegisterWebProxyEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Connector/VidyoConnector_IRegisterWebProxyEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnWebProxyCredentialsRequest ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IRegisterWebProxyEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason", DoNotGenerateAcw=true)]
		public sealed partial class VidyoConnectorDisconnectReason : global::Java.Lang.Enum {


			static IntPtr VIDYO_CONNECTORDISCONNECTREASON_ConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']/field[@name='VIDYO_CONNECTORDISCONNECTREASON_ConnectionLost']"
			[Register ("VIDYO_CONNECTORDISCONNECTREASON_ConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason VIDYOCONNECTORDISCONNECTREASONConnectionLost {
				get {
					if (VIDYO_CONNECTORDISCONNECTREASON_ConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORDISCONNECTREASON_ConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORDISCONNECTREASON_ConnectionLost", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORDISCONNECTREASON_ConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORDISCONNECTREASON_ConnectionTimeout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']/field[@name='VIDYO_CONNECTORDISCONNECTREASON_ConnectionTimeout']"
			[Register ("VIDYO_CONNECTORDISCONNECTREASON_ConnectionTimeout")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason VIDYOCONNECTORDISCONNECTREASONConnectionTimeout {
				get {
					if (VIDYO_CONNECTORDISCONNECTREASON_ConnectionTimeout_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORDISCONNECTREASON_ConnectionTimeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORDISCONNECTREASON_ConnectionTimeout", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORDISCONNECTREASON_ConnectionTimeout_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORDISCONNECTREASON_Disconnected_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']/field[@name='VIDYO_CONNECTORDISCONNECTREASON_Disconnected']"
			[Register ("VIDYO_CONNECTORDISCONNECTREASON_Disconnected")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason VIDYOCONNECTORDISCONNECTREASONDisconnected {
				get {
					if (VIDYO_CONNECTORDISCONNECTREASON_Disconnected_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORDISCONNECTREASON_Disconnected_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORDISCONNECTREASON_Disconnected", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORDISCONNECTREASON_Disconnected_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORDISCONNECTREASON_MiscError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']/field[@name='VIDYO_CONNECTORDISCONNECTREASON_MiscError']"
			[Register ("VIDYO_CONNECTORDISCONNECTREASON_MiscError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason VIDYOCONNECTORDISCONNECTREASONMiscError {
				get {
					if (VIDYO_CONNECTORDISCONNECTREASON_MiscError_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORDISCONNECTREASON_MiscError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORDISCONNECTREASON_MiscError", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORDISCONNECTREASON_MiscError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORDISCONNECTREASON_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']/field[@name='VIDYO_CONNECTORDISCONNECTREASON_MiscLocalError']"
			[Register ("VIDYO_CONNECTORDISCONNECTREASON_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason VIDYOCONNECTORDISCONNECTREASONMiscLocalError {
				get {
					if (VIDYO_CONNECTORDISCONNECTREASON_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORDISCONNECTREASON_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORDISCONNECTREASON_MiscLocalError", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORDISCONNECTREASON_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORDISCONNECTREASON_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']/field[@name='VIDYO_CONNECTORDISCONNECTREASON_MiscRemoteError']"
			[Register ("VIDYO_CONNECTORDISCONNECTREASON_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason VIDYOCONNECTORDISCONNECTREASONMiscRemoteError {
				get {
					if (VIDYO_CONNECTORDISCONNECTREASON_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORDISCONNECTREASON_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORDISCONNECTREASON_MiscRemoteError", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORDISCONNECTREASON_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORDISCONNECTREASON_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']/field[@name='VIDYO_CONNECTORDISCONNECTREASON_NoResponse']"
			[Register ("VIDYO_CONNECTORDISCONNECTREASON_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason VIDYOCONNECTORDISCONNECTREASONNoResponse {
				get {
					if (VIDYO_CONNECTORDISCONNECTREASON_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORDISCONNECTREASON_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORDISCONNECTREASON_NoResponse", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORDISCONNECTREASON_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORDISCONNECTREASON_Terminated_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']/field[@name='VIDYO_CONNECTORDISCONNECTREASON_Terminated']"
			[Register ("VIDYO_CONNECTORDISCONNECTREASON_Terminated")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason VIDYOCONNECTORDISCONNECTREASONTerminated {
				get {
					if (VIDYO_CONNECTORDISCONNECTREASON_Terminated_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORDISCONNECTREASON_Terminated_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORDISCONNECTREASON_Terminated", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORDISCONNECTREASON_Terminated_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoConnectorDisconnectReason); }
			}

			internal VidyoConnectorDisconnectReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorDisconnectReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;");
				try {
					return (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason", DoNotGenerateAcw=true)]
		public sealed partial class VidyoConnectorFailReason : global::Java.Lang.Enum {


			static IntPtr VIDYO_CONNECTORFAILREASON_Banned_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_Banned']"
			[Register ("VIDYO_CONNECTORFAILREASON_Banned")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONBanned {
				get {
					if (VIDYO_CONNECTORFAILREASON_Banned_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_Banned_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_Banned", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_Banned_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_ConnectionFailed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_ConnectionFailed']"
			[Register ("VIDYO_CONNECTORFAILREASON_ConnectionFailed")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONConnectionFailed {
				get {
					if (VIDYO_CONNECTORFAILREASON_ConnectionFailed_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_ConnectionFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_ConnectionFailed", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_ConnectionFailed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_ConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_ConnectionLost']"
			[Register ("VIDYO_CONNECTORFAILREASON_ConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONConnectionLost {
				get {
					if (VIDYO_CONNECTORFAILREASON_ConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_ConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_ConnectionLost", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_ConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_ConnectionTimeout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_ConnectionTimeout']"
			[Register ("VIDYO_CONNECTORFAILREASON_ConnectionTimeout")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONConnectionTimeout {
				get {
					if (VIDYO_CONNECTORFAILREASON_ConnectionTimeout_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_ConnectionTimeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_ConnectionTimeout", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_ConnectionTimeout_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_InvalidResourceId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_InvalidResourceId']"
			[Register ("VIDYO_CONNECTORFAILREASON_InvalidResourceId")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONInvalidResourceId {
				get {
					if (VIDYO_CONNECTORFAILREASON_InvalidResourceId_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_InvalidResourceId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_InvalidResourceId", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_InvalidResourceId_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_InvalidToken_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_InvalidToken']"
			[Register ("VIDYO_CONNECTORFAILREASON_InvalidToken")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONInvalidToken {
				get {
					if (VIDYO_CONNECTORFAILREASON_InvalidToken_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_InvalidToken_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_InvalidToken", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_InvalidToken_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_MediaFailed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_MediaFailed']"
			[Register ("VIDYO_CONNECTORFAILREASON_MediaFailed")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONMediaFailed {
				get {
					if (VIDYO_CONNECTORFAILREASON_MediaFailed_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_MediaFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_MediaFailed", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_MediaFailed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_MediaNotEnabled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_MediaNotEnabled']"
			[Register ("VIDYO_CONNECTORFAILREASON_MediaNotEnabled")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONMediaNotEnabled {
				get {
					if (VIDYO_CONNECTORFAILREASON_MediaNotEnabled_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_MediaNotEnabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_MediaNotEnabled", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_MediaNotEnabled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_MiscError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_MiscError']"
			[Register ("VIDYO_CONNECTORFAILREASON_MiscError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONMiscError {
				get {
					if (VIDYO_CONNECTORFAILREASON_MiscError_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_MiscError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_MiscError", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_MiscError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_MiscLocalError']"
			[Register ("VIDYO_CONNECTORFAILREASON_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONMiscLocalError {
				get {
					if (VIDYO_CONNECTORFAILREASON_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_MiscLocalError", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_MiscRemoteError']"
			[Register ("VIDYO_CONNECTORFAILREASON_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONMiscRemoteError {
				get {
					if (VIDYO_CONNECTORFAILREASON_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_MiscRemoteError", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_NoResponse']"
			[Register ("VIDYO_CONNECTORFAILREASON_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONNoResponse {
				get {
					if (VIDYO_CONNECTORFAILREASON_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_NoResponse", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_NoResponseFromResource_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_NoResponseFromResource']"
			[Register ("VIDYO_CONNECTORFAILREASON_NoResponseFromResource")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONNoResponseFromResource {
				get {
					if (VIDYO_CONNECTORFAILREASON_NoResponseFromResource_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_NoResponseFromResource_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_NoResponseFromResource", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_NoResponseFromResource_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_NotMember_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_NotMember']"
			[Register ("VIDYO_CONNECTORFAILREASON_NotMember")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONNotMember {
				get {
					if (VIDYO_CONNECTORFAILREASON_NotMember_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_NotMember_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_NotMember", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_NotMember_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_ResourceFull_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_ResourceFull']"
			[Register ("VIDYO_CONNECTORFAILREASON_ResourceFull")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONResourceFull {
				get {
					if (VIDYO_CONNECTORFAILREASON_ResourceFull_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_ResourceFull_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_ResourceFull", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_ResourceFull_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_Terminated_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_Terminated']"
			[Register ("VIDYO_CONNECTORFAILREASON_Terminated")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONTerminated {
				get {
					if (VIDYO_CONNECTORFAILREASON_Terminated_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_Terminated_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_Terminated", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_Terminated_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORFAILREASON_UnableToCreateResource_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/field[@name='VIDYO_CONNECTORFAILREASON_UnableToCreateResource']"
			[Register ("VIDYO_CONNECTORFAILREASON_UnableToCreateResource")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason VIDYOCONNECTORFAILREASONUnableToCreateResource {
				get {
					if (VIDYO_CONNECTORFAILREASON_UnableToCreateResource_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORFAILREASON_UnableToCreateResource_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORFAILREASON_UnableToCreateResource", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORFAILREASON_UnableToCreateResource_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoConnectorFailReason); }
			}

			internal VidyoConnectorFailReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorFailReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;");
				try {
					return (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorMode']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode", DoNotGenerateAcw=true)]
		public sealed partial class VidyoConnectorMode : global::Java.Lang.Enum {


			static IntPtr VIDYO_CONNECTORMODE_Background_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorMode']/field[@name='VIDYO_CONNECTORMODE_Background']"
			[Register ("VIDYO_CONNECTORMODE_Background")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode VIDYOCONNECTORMODEBackground {
				get {
					if (VIDYO_CONNECTORMODE_Background_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORMODE_Background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORMODE_Background", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORMODE_Background_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORMODE_Default_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorMode']/field[@name='VIDYO_CONNECTORMODE_Default']"
			[Register ("VIDYO_CONNECTORMODE_Default")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode VIDYOCONNECTORMODEDefault {
				get {
					if (VIDYO_CONNECTORMODE_Default_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORMODE_Default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORMODE_Default", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORMODE_Default_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORMODE_Foreground_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorMode']/field[@name='VIDYO_CONNECTORMODE_Foreground']"
			[Register ("VIDYO_CONNECTORMODE_Foreground")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode VIDYOCONNECTORMODEForeground {
				get {
					if (VIDYO_CONNECTORMODE_Foreground_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORMODE_Foreground_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORMODE_Foreground", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORMODE_Foreground_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoConnectorMode); }
			}

			internal VidyoConnectorMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode;");
				try {
					return (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoConnectorState : global::Java.Lang.Enum {


			static IntPtr VIDYO_CONNECTORSTATE_Connected_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorState']/field[@name='VIDYO_CONNECTORSTATE_Connected']"
			[Register ("VIDYO_CONNECTORSTATE_Connected")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState VIDYOCONNECTORSTATEConnected {
				get {
					if (VIDYO_CONNECTORSTATE_Connected_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORSTATE_Connected_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORSTATE_Connected", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORSTATE_Connected_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORSTATE_ConnectingToResource_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorState']/field[@name='VIDYO_CONNECTORSTATE_ConnectingToResource']"
			[Register ("VIDYO_CONNECTORSTATE_ConnectingToResource")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState VIDYOCONNECTORSTATEConnectingToResource {
				get {
					if (VIDYO_CONNECTORSTATE_ConnectingToResource_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORSTATE_ConnectingToResource_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORSTATE_ConnectingToResource", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORSTATE_ConnectingToResource_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORSTATE_EnablingMedia_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorState']/field[@name='VIDYO_CONNECTORSTATE_EnablingMedia']"
			[Register ("VIDYO_CONNECTORSTATE_EnablingMedia")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState VIDYOCONNECTORSTATEEnablingMedia {
				get {
					if (VIDYO_CONNECTORSTATE_EnablingMedia_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORSTATE_EnablingMedia_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORSTATE_EnablingMedia", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORSTATE_EnablingMedia_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORSTATE_EstablishingConnection_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorState']/field[@name='VIDYO_CONNECTORSTATE_EstablishingConnection']"
			[Register ("VIDYO_CONNECTORSTATE_EstablishingConnection")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState VIDYOCONNECTORSTATEEstablishingConnection {
				get {
					if (VIDYO_CONNECTORSTATE_EstablishingConnection_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORSTATE_EstablishingConnection_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORSTATE_EstablishingConnection", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORSTATE_EstablishingConnection_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORSTATE_FindingResource_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorState']/field[@name='VIDYO_CONNECTORSTATE_FindingResource']"
			[Register ("VIDYO_CONNECTORSTATE_FindingResource")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState VIDYOCONNECTORSTATEFindingResource {
				get {
					if (VIDYO_CONNECTORSTATE_FindingResource_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORSTATE_FindingResource_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORSTATE_FindingResource", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORSTATE_FindingResource_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORSTATE_Idle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorState']/field[@name='VIDYO_CONNECTORSTATE_Idle']"
			[Register ("VIDYO_CONNECTORSTATE_Idle")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState VIDYOCONNECTORSTATEIdle {
				get {
					if (VIDYO_CONNECTORSTATE_Idle_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORSTATE_Idle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORSTATE_Idle", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORSTATE_Idle_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORSTATE_Ready_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorState']/field[@name='VIDYO_CONNECTORSTATE_Ready']"
			[Register ("VIDYO_CONNECTORSTATE_Ready")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState VIDYOCONNECTORSTATEReady {
				get {
					if (VIDYO_CONNECTORSTATE_Ready_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORSTATE_Ready_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORSTATE_Ready", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORSTATE_Ready_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoConnectorState); }
			}

			internal VidyoConnectorState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;");
				try {
					return (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorViewStyle']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle", DoNotGenerateAcw=true)]
		public sealed partial class VidyoConnectorViewStyle : global::Java.Lang.Enum {


			static IntPtr VIDYO_CONNECTORVIEWSTYLE_Default_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorViewStyle']/field[@name='VIDYO_CONNECTORVIEWSTYLE_Default']"
			[Register ("VIDYO_CONNECTORVIEWSTYLE_Default")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle VIDYOCONNECTORVIEWSTYLEDefault {
				get {
					if (VIDYO_CONNECTORVIEWSTYLE_Default_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORVIEWSTYLE_Default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORVIEWSTYLE_Default", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORVIEWSTYLE_Default_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CONNECTORVIEWSTYLE_Tiles_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorViewStyle']/field[@name='VIDYO_CONNECTORVIEWSTYLE_Tiles']"
			[Register ("VIDYO_CONNECTORVIEWSTYLE_Tiles")]
			public static global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle VIDYOCONNECTORVIEWSTYLETiles {
				get {
					if (VIDYO_CONNECTORVIEWSTYLE_Tiles_jfieldId == IntPtr.Zero)
						VIDYO_CONNECTORVIEWSTYLE_Tiles_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CONNECTORVIEWSTYLE_Tiles", "Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CONNECTORVIEWSTYLE_Tiles_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoConnectorViewStyle); }
			}

			internal VidyoConnectorViewStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorViewStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector.VidyoConnectorViewStyle']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;");
				try {
					return (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Connector/VidyoConnector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoConnector); }
		}

		protected VidyoConnector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_ILjava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/constructor[@name='VidyoConnector' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='long']]"
		[Register (".ctor", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;ILjava/lang/String;Ljava/lang/String;J)V", "")]
		public unsafe VidyoConnector (global::Java.Lang.Object p0, global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle p1, int p2, string p3, string p4, long p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (VidyoConnector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;ILjava/lang/String;Ljava/lang/String;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;ILjava/lang/String;Ljava/lang/String;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_ILjava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_ILjava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;ILjava/lang/String;Ljava/lang/String;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_ILjava_lang_String_Ljava_lang_String_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_ILjava_lang_String_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/constructor[@name='VidyoConnector' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoConnector (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoConnector)) {
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
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='GetObjectPtr' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_GetState;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='GetState' and count(parameter)=0]"
			[Register ("GetState", "()Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;", "GetGetStateHandler")]
			get {
				if (id_GetState == IntPtr.Zero)
					id_GetState = JNIEnv.GetMethodID (class_ref, "GetState", "()Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetState", "()Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorState;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetStatsJson;
#pragma warning disable 0169
		static Delegate GetGetStatsJsonHandler ()
		{
			if (cb_GetStatsJson == null)
				cb_GetStatsJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatsJson);
			return cb_GetStatsJson;
		}

		static IntPtr n_GetStatsJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StatsJson);
		}
#pragma warning restore 0169

		static IntPtr id_GetStatsJson;
		public virtual unsafe string StatsJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='GetStatsJson' and count(parameter)=0]"
			[Register ("GetStatsJson", "()Ljava/lang/String;", "GetGetStatsJsonHandler")]
			get {
				if (id_GetStatsJson == IntPtr.Zero)
					id_GetStatsJson = JNIEnv.GetMethodID (class_ref, "GetStatsJson", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetStatsJson), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetStatsJson", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_GetVersion == null)
				cb_GetVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_GetVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_GetVersion;
		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='GetVersion' and count(parameter)=0]"
			[Register ("GetVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_GetVersion == IntPtr.Zero)
					id_GetVersion = JNIEnv.GetMethodID (class_ref, "GetVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Assign ());
		}
#pragma warning restore 0169

		static IntPtr id_Assign;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='Assign' and count(parameter)=0]"
		[Register ("Assign", "()Lcom/vidyo/VidyoClient/Connector/VidyoConnector;", "GetAssignHandler")]
		public virtual unsafe global::Com.Vidyo.VidyoClient.Connector.VidyoConnector Assign ()
		{
			if (id_Assign == IntPtr.Zero)
				id_Assign = JNIEnv.GetMethodID (class_ref, "Assign", "()Lcom/vidyo/VidyoClient/Connector/VidyoConnector;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_Assign), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Assign", "()Lcom/vidyo/VidyoClient/Connector/VidyoConnector;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_I;
#pragma warning disable 0169
		static Delegate GetAssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_IHandler ()
		{
			if (cb_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_I == null)
				cb_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_I);
			return cb_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_I;
		}

		static bool n_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AssignViewToCompositeRenderer (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='AssignViewToCompositeRenderer' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle'] and parameter[3][@type='int']]"
		[Register ("AssignViewToCompositeRenderer", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;I)Z", "GetAssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_IHandler")]
		public virtual unsafe bool AssignViewToCompositeRenderer (global::Java.Lang.Object p0, global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorViewStyle p1, int p2)
		{
			if (id_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_I == IntPtr.Zero)
				id_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_I = JNIEnv.GetMethodID (class_ref, "AssignViewToCompositeRenderer", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;I)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorViewStyle_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AssignViewToCompositeRenderer", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorViewStyle;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ;
#pragma warning disable 0169
		static Delegate GetAssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZHandler ()
		{
			if (cb_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ == null)
				cb_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, bool>) n_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ);
			return cb_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ;
		}

		static bool n_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, bool p3)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AssignViewToLocalCamera (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='AssignViewToLocalCamera' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("AssignViewToLocalCamera", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;ZZ)Z", "GetAssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZHandler")]
		public virtual unsafe bool AssignViewToLocalCamera (global::Java.Lang.Object p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p1, bool p2, bool p3)
		{
			if (id_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ == IntPtr.Zero)
				id_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ = JNIEnv.GetMethodID (class_ref, "AssignViewToLocalCamera", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;ZZ)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AssignViewToLocalCamera", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;ZZ)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ;
#pragma warning disable 0169
		static Delegate GetAssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZHandler ()
		{
			if (cb_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ == null)
				cb_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, bool>) n_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ);
			return cb_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ;
		}

		static bool n_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, bool p3)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AssignViewToRemoteCamera (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='AssignViewToRemoteCamera' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("AssignViewToRemoteCamera", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;ZZ)Z", "GetAssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZHandler")]
		public virtual unsafe bool AssignViewToRemoteCamera (global::Java.Lang.Object p0, global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p1, bool p2, bool p3)
		{
			if (id_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ == IntPtr.Zero)
				id_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ = JNIEnv.GetMethodID (class_ref, "AssignViewToRemoteCamera", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;ZZ)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AssignViewToRemoteCamera", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;ZZ)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ;
#pragma warning disable 0169
		static Delegate GetAssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZHandler ()
		{
			if (cb_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ == null)
				cb_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, bool>) n_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ);
			return cb_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ;
		}

		static bool n_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, bool p3)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AssignViewToRemoteWindowShare (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='AssignViewToRemoteWindowShare' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("AssignViewToRemoteWindowShare", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;ZZ)Z", "GetAssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZHandler")]
		public virtual unsafe bool AssignViewToRemoteWindowShare (global::Java.Lang.Object p0, global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p1, bool p2, bool p3)
		{
			if (id_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ == IntPtr.Zero)
				id_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ = JNIEnv.GetMethodID (class_ref, "AssignViewToRemoteWindowShare", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;ZZ)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AssignViewToRemoteWindowShare", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;ZZ)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_Handler ()
		{
			if (cb_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_ == null)
				cb_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_);
			return cb_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_;
		}

		static bool n_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IConnect p4 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IConnect)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IConnect> (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Connect (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='Connect' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IConnect']]"
		[Register ("Connect", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IConnect;)Z", "GetConnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_Handler")]
		public virtual unsafe bool Connect (string p0, string p1, string p2, string p3, global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IConnect p4)
		{
			if (id_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_ == IntPtr.Zero)
				id_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_ = JNIEnv.GetMethodID (class_ref, "Connect", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IConnect;)Z");
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
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Connect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IConnect_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Connect", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IConnect;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_CycleCamera;
#pragma warning disable 0169
		static Delegate GetCycleCameraHandler ()
		{
			if (cb_CycleCamera == null)
				cb_CycleCamera = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CycleCamera);
			return cb_CycleCamera;
		}

		static bool n_CycleCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CycleCamera ();
		}
#pragma warning restore 0169

		static IntPtr id_CycleCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='CycleCamera' and count(parameter)=0]"
		[Register ("CycleCamera", "()Z", "GetCycleCameraHandler")]
		public virtual unsafe bool CycleCamera ()
		{
			if (id_CycleCamera == IntPtr.Zero)
				id_CycleCamera = JNIEnv.GetMethodID (class_ref, "CycleCamera", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CycleCamera);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CycleCamera", "()Z"));
			} finally {
			}
		}

		static Delegate cb_CycleMicrophone;
#pragma warning disable 0169
		static Delegate GetCycleMicrophoneHandler ()
		{
			if (cb_CycleMicrophone == null)
				cb_CycleMicrophone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CycleMicrophone);
			return cb_CycleMicrophone;
		}

		static bool n_CycleMicrophone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CycleMicrophone ();
		}
#pragma warning restore 0169

		static IntPtr id_CycleMicrophone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='CycleMicrophone' and count(parameter)=0]"
		[Register ("CycleMicrophone", "()Z", "GetCycleMicrophoneHandler")]
		public virtual unsafe bool CycleMicrophone ()
		{
			if (id_CycleMicrophone == IntPtr.Zero)
				id_CycleMicrophone = JNIEnv.GetMethodID (class_ref, "CycleMicrophone", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CycleMicrophone);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CycleMicrophone", "()Z"));
			} finally {
			}
		}

		static Delegate cb_CycleSpeaker;
#pragma warning disable 0169
		static Delegate GetCycleSpeakerHandler ()
		{
			if (cb_CycleSpeaker == null)
				cb_CycleSpeaker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CycleSpeaker);
			return cb_CycleSpeaker;
		}

		static bool n_CycleSpeaker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CycleSpeaker ();
		}
#pragma warning restore 0169

		static IntPtr id_CycleSpeaker;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='CycleSpeaker' and count(parameter)=0]"
		[Register ("CycleSpeaker", "()Z", "GetCycleSpeakerHandler")]
		public virtual unsafe bool CycleSpeaker ()
		{
			if (id_CycleSpeaker == IntPtr.Zero)
				id_CycleSpeaker = JNIEnv.GetMethodID (class_ref, "CycleSpeaker", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CycleSpeaker);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CycleSpeaker", "()Z"));
			} finally {
			}
		}

		static Delegate cb_Disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_Disable == null)
				cb_Disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
			return cb_Disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		static IntPtr id_Disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='Disable' and count(parameter)=0]"
		[Register ("Disable", "()V", "GetDisableHandler")]
		public virtual unsafe void Disable ()
		{
			if (id_Disable == IntPtr.Zero)
				id_Disable = JNIEnv.GetMethodID (class_ref, "Disable", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Disable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Disable", "()V"));
			} finally {
			}
		}

		static Delegate cb_DisableDebug;
#pragma warning disable 0169
		static Delegate GetDisableDebugHandler ()
		{
			if (cb_DisableDebug == null)
				cb_DisableDebug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableDebug);
			return cb_DisableDebug;
		}

		static void n_DisableDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableDebug ();
		}
#pragma warning restore 0169

		static IntPtr id_DisableDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='DisableDebug' and count(parameter)=0]"
		[Register ("DisableDebug", "()V", "GetDisableDebugHandler")]
		public virtual unsafe void DisableDebug ()
		{
			if (id_DisableDebug == IntPtr.Zero)
				id_DisableDebug = JNIEnv.GetMethodID (class_ref, "DisableDebug", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_DisableDebug);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DisableDebug", "()V"));
			} finally {
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
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_Disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='Disconnect' and count(parameter)=0]"
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

		static Delegate cb_EnableDebug_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnableDebug_ILjava_lang_String_Handler ()
		{
			if (cb_EnableDebug_ILjava_lang_String_ == null)
				cb_EnableDebug_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_EnableDebug_ILjava_lang_String_);
			return cb_EnableDebug_ILjava_lang_String_;
		}

		static bool n_EnableDebug_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EnableDebug (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_EnableDebug_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='EnableDebug' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("EnableDebug", "(ILjava/lang/String;)Z", "GetEnableDebug_ILjava_lang_String_Handler")]
		public virtual unsafe bool EnableDebug (int p0, string p1)
		{
			if (id_EnableDebug_ILjava_lang_String_ == IntPtr.Zero)
				id_EnableDebug_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "EnableDebug", "(ILjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_EnableDebug_ILjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "EnableDebug", "(ILjava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_HideView_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetHideView_Ljava_lang_Object_Handler ()
		{
			if (cb_HideView_Ljava_lang_Object_ == null)
				cb_HideView_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HideView_Ljava_lang_Object_);
			return cb_HideView_Ljava_lang_Object_;
		}

		static bool n_HideView_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HideView (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_HideView_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='HideView' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("HideView", "(Ljava/lang/Object;)Z", "GetHideView_Ljava_lang_Object_Handler")]
		public virtual unsafe bool HideView (global::Java.Lang.Object p0)
		{
			if (id_HideView_Ljava_lang_Object_ == IntPtr.Zero)
				id_HideView_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "HideView", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_HideView_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "HideView", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_OnAvailableResourcesChanged_IIII;
#pragma warning disable 0169
		static Delegate GetOnAvailableResourcesChanged_IIIIHandler ()
		{
			if (cb_OnAvailableResourcesChanged_IIII == null)
				cb_OnAvailableResourcesChanged_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_OnAvailableResourcesChanged_IIII);
			return cb_OnAvailableResourcesChanged_IIII;
		}

		static void n_OnAvailableResourcesChanged_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAvailableResourcesChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_OnAvailableResourcesChanged_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnAvailableResourcesChanged' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("OnAvailableResourcesChanged", "(IIII)V", "GetOnAvailableResourcesChanged_IIIIHandler")]
		public virtual unsafe void OnAvailableResourcesChanged (int p0, int p1, int p2, int p3)
		{
			if (id_OnAvailableResourcesChanged_IIII == IntPtr.Zero)
				id_OnAvailableResourcesChanged_IIII = JNIEnv.GetMethodID (class_ref, "OnAvailableResourcesChanged", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnAvailableResourcesChanged_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnAvailableResourcesChanged", "(IIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
#pragma warning disable 0169
		static Delegate GetOnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler ()
		{
			if (cb_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == null)
				cb_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_);
			return cb_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
		}

		static void n_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnChatMessageReceived (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnChatMessageReceived' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage']]"
		[Register ("OnChatMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V", "GetOnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler")]
		public virtual unsafe void OnChatMessageReceived (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1)
		{
			if (id_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == IntPtr.Zero)
				id_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNIEnv.GetMethodID (class_ref, "OnChatMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnChatMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_;
#pragma warning disable 0169
		static Delegate GetOnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_Handler ()
		{
			if (cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_ == null)
				cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_);
			return cb_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_;
		}

		static void n_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnDisconnected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason']]"
		[Register ("OnDisconnected", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;)V", "GetOnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_Handler")]
		public virtual unsafe void OnDisconnected (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason p0)
		{
			if (id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_ == IntPtr.Zero)
				id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_ = JNIEnv.GetMethodID (class_ref, "OnDisconnected", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnDisconnected", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetOnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
		{
			if (cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
				cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_);
			return cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		}

		static void n_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDynamicParticipantChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnDynamicParticipantChanged' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoParticipant&gt;'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoRemoteCamera&gt;']]"
		[Register ("OnDynamicParticipantChanged", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", "GetOnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void OnDynamicParticipantChanged (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1)
		{
			if (id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "OnDynamicParticipantChanged", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnDynamicParticipantChanged", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_Handler ()
		{
			if (cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_ == null)
				cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_);
			return cb_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_;
		}

		static void n_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnFailure' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason']]"
		[Register ("OnFailure", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;)V", "GetOnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_Handler")]
		public virtual unsafe void OnFailure (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason p0)
		{
			if (id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_ == IntPtr.Zero)
				id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_ = JNIEnv.GetMethodID (class_ref, "OnFailure", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnFailure", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
#pragma warning disable 0169
		static Delegate GetOnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler ()
		{
			if (cb_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == null)
				cb_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_);
			return cb_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		}

		static void n_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalCameraAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalCameraAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
		[Register ("OnLocalCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetOnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler")]
		public virtual unsafe void OnLocalCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
		{
			if (id_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == IntPtr.Zero)
				id_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNIEnv.GetMethodID (class_ref, "OnLocalCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
#pragma warning disable 0169
		static Delegate GetOnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler ()
		{
			if (cb_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == null)
				cb_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_);
			return cb_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		}

		static void n_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalCameraRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalCameraRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
		[Register ("OnLocalCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetOnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler")]
		public virtual unsafe void OnLocalCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
		{
			if (id_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == IntPtr.Zero)
				id_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNIEnv.GetMethodID (class_ref, "OnLocalCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
#pragma warning disable 0169
		static Delegate GetOnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler ()
		{
			if (cb_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == null)
				cb_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_);
			return cb_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		}

		static void n_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalCameraSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalCameraSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
		[Register ("OnLocalCameraSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetOnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler")]
		public virtual unsafe void OnLocalCameraSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
		{
			if (id_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == IntPtr.Zero)
				id_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNIEnv.GetMethodID (class_ref, "OnLocalCameraSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalCameraSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalCameraStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalCameraStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnLocalCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnLocalCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
		{
			if (id_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
#pragma warning disable 0169
		static Delegate GetOnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler ()
		{
			if (cb_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == null)
				cb_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_);
			return cb_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		}

		static void n_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMicrophoneAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalMicrophoneAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
		[Register ("OnLocalMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetOnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler")]
		public virtual unsafe void OnLocalMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
		{
			if (id_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == IntPtr.Zero)
				id_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNIEnv.GetMethodID (class_ref, "OnLocalMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
#pragma warning disable 0169
		static Delegate GetOnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler ()
		{
			if (cb_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == null)
				cb_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_);
			return cb_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		}

		static void n_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMicrophoneRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalMicrophoneRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
		[Register ("OnLocalMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetOnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler")]
		public virtual unsafe void OnLocalMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
		{
			if (id_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == IntPtr.Zero)
				id_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNIEnv.GetMethodID (class_ref, "OnLocalMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
#pragma warning disable 0169
		static Delegate GetOnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler ()
		{
			if (cb_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == null)
				cb_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_);
			return cb_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		}

		static void n_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMicrophoneSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalMicrophoneSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
		[Register ("OnLocalMicrophoneSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetOnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler")]
		public virtual unsafe void OnLocalMicrophoneSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
		{
			if (id_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == IntPtr.Zero)
				id_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNIEnv.GetMethodID (class_ref, "OnLocalMicrophoneSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalMicrophoneSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMicrophoneStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalMicrophoneStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnLocalMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnLocalMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
		{
			if (id_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
#pragma warning disable 0169
		static Delegate GetOnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler ()
		{
			if (cb_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == null)
				cb_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_);
			return cb_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		}

		static void n_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMonitorAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalMonitorAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
		[Register ("OnLocalMonitorAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetOnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler")]
		public virtual unsafe void OnLocalMonitorAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
		{
			if (id_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == IntPtr.Zero)
				id_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNIEnv.GetMethodID (class_ref, "OnLocalMonitorAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalMonitorAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
#pragma warning disable 0169
		static Delegate GetOnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler ()
		{
			if (cb_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == null)
				cb_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_);
			return cb_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		}

		static void n_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMonitorRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalMonitorRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
		[Register ("OnLocalMonitorRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetOnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler")]
		public virtual unsafe void OnLocalMonitorRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
		{
			if (id_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == IntPtr.Zero)
				id_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNIEnv.GetMethodID (class_ref, "OnLocalMonitorRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalMonitorRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
#pragma warning disable 0169
		static Delegate GetOnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler ()
		{
			if (cb_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == null)
				cb_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_);
			return cb_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		}

		static void n_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMonitorSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalMonitorSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
		[Register ("OnLocalMonitorSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetOnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler")]
		public virtual unsafe void OnLocalMonitorSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
		{
			if (id_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == IntPtr.Zero)
				id_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNIEnv.GetMethodID (class_ref, "OnLocalMonitorSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalMonitorSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMonitorStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalMonitorStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnLocalMonitorStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnLocalMonitorStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
		{
			if (id_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalMonitorStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalMonitorStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
		static Delegate GetOnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
		{
			if (cb_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
				cb_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
			return cb_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		}

		static void n_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalSpeakerAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalSpeakerAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
		[Register ("OnLocalSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetOnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler")]
		public virtual unsafe void OnLocalSpeakerAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
		{
			if (id_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
				id_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "OnLocalSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
		static Delegate GetOnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
		{
			if (cb_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
				cb_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
			return cb_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		}

		static void n_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalSpeakerRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalSpeakerRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
		[Register ("OnLocalSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetOnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler")]
		public virtual unsafe void OnLocalSpeakerRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
		{
			if (id_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
				id_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "OnLocalSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
		static Delegate GetOnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
		{
			if (cb_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
				cb_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
			return cb_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		}

		static void n_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalSpeakerSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalSpeakerSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
		[Register ("OnLocalSpeakerSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetOnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler")]
		public virtual unsafe void OnLocalSpeakerSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
		{
			if (id_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
				id_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "OnLocalSpeakerSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalSpeakerSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalSpeakerStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalSpeakerStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnLocalSpeakerStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnLocalSpeakerStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
		{
			if (id_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalSpeakerStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalSpeakerStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
		static Delegate GetOnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
		{
			if (cb_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
				cb_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
			return cb_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		}

		static void n_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalWindowShareAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalWindowShareAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
		[Register ("OnLocalWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetOnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler")]
		public virtual unsafe void OnLocalWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
		{
			if (id_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
				id_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "OnLocalWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
		static Delegate GetOnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
		{
			if (cb_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
				cb_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
			return cb_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		}

		static void n_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalWindowShareRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalWindowShareRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
		[Register ("OnLocalWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetOnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler")]
		public virtual unsafe void OnLocalWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
		{
			if (id_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
				id_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "OnLocalWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
		static Delegate GetOnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
		{
			if (cb_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
				cb_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
			return cb_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		}

		static void n_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalWindowShareSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalWindowShareSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
		[Register ("OnLocalWindowShareSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetOnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler")]
		public virtual unsafe void OnLocalWindowShareSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
		{
			if (id_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
				id_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "OnLocalWindowShareSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalWindowShareSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalWindowShareStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLocalWindowShareStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnLocalWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnLocalWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
		{
			if (id_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_;
#pragma warning disable 0169
		static Delegate GetOnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_Handler ()
		{
			if (cb_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_ == null)
				cb_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_);
			return cb_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_;
		}

		static void n_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLog (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLog' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoLogRecord']]"
		[Register ("OnLog", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord;)V", "GetOnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_Handler")]
		public virtual unsafe void OnLog (global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord p0)
		{
			if (id_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_ == IntPtr.Zero)
				id_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_ = JNIEnv.GetMethodID (class_ref, "OnLog", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLog", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
#pragma warning disable 0169
		static Delegate GetOnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ZHandler ()
		{
			if (cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z == null)
				cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z);
			return cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
		}

		static void n_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoudestParticipantChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnLoudestParticipantChanged' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='boolean']]"
		[Register ("OnLoudestParticipantChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V", "GetOnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ZHandler")]
		public virtual unsafe void OnLoudestParticipantChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, bool p1)
		{
			if (id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z == IntPtr.Zero)
				id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z = JNIEnv.GetMethodID (class_ref, "OnLoudestParticipantChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLoudestParticipantChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnMaxRemoteSourcesChanged_I;
#pragma warning disable 0169
		static Delegate GetOnMaxRemoteSourcesChanged_IHandler ()
		{
			if (cb_OnMaxRemoteSourcesChanged_I == null)
				cb_OnMaxRemoteSourcesChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnMaxRemoteSourcesChanged_I);
			return cb_OnMaxRemoteSourcesChanged_I;
		}

		static void n_OnMaxRemoteSourcesChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMaxRemoteSourcesChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnMaxRemoteSourcesChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnMaxRemoteSourcesChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("OnMaxRemoteSourcesChanged", "(I)V", "GetOnMaxRemoteSourcesChanged_IHandler")]
		public virtual unsafe void OnMaxRemoteSourcesChanged (int p0)
		{
			if (id_OnMaxRemoteSourcesChanged_I == IntPtr.Zero)
				id_OnMaxRemoteSourcesChanged_I = JNIEnv.GetMethodID (class_ref, "OnMaxRemoteSourcesChanged", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMaxRemoteSourcesChanged_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMaxRemoteSourcesChanged", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
#pragma warning disable 0169
		static Delegate GetOnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler ()
		{
			if (cb_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == null)
				cb_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_);
			return cb_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		}

		static void n_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInterfaceAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnNetworkInterfaceAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
		[Register ("OnNetworkInterfaceAdded", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V", "GetOnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler")]
		public virtual unsafe void OnNetworkInterfaceAdded (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0)
		{
			if (id_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == IntPtr.Zero)
				id_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNIEnv.GetMethodID (class_ref, "OnNetworkInterfaceAdded", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnNetworkInterfaceAdded", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
#pragma warning disable 0169
		static Delegate GetOnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler ()
		{
			if (cb_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == null)
				cb_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_);
			return cb_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		}

		static void n_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInterfaceRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnNetworkInterfaceRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
		[Register ("OnNetworkInterfaceRemoved", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V", "GetOnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler")]
		public virtual unsafe void OnNetworkInterfaceRemoved (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0)
		{
			if (id_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == IntPtr.Zero)
				id_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNIEnv.GetMethodID (class_ref, "OnNetworkInterfaceRemoved", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnNetworkInterfaceRemoved", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_;
#pragma warning disable 0169
		static Delegate GetOnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_Handler ()
		{
			if (cb_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_ == null)
				cb_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_);
			return cb_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_;
		}

		static void n_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInterfaceSelected (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnNetworkInterfaceSelected' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType']]"
		[Register ("OnNetworkInterfaceSelected", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;)V", "GetOnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_Handler")]
		public virtual unsafe void OnNetworkInterfaceSelected (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1)
		{
			if (id_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_ == IntPtr.Zero)
				id_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_ = JNIEnv.GetMethodID (class_ref, "OnNetworkInterfaceSelected", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnNetworkInterfaceSelected", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_;
#pragma warning disable 0169
		static Delegate GetOnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_Handler ()
		{
			if (cb_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_ == null)
				cb_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_);
			return cb_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_;
		}

		static void n_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInterfaceStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnNetworkInterfaceStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState']]"
		[Register ("OnNetworkInterfaceStateUpdated", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;)V", "GetOnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_Handler")]
		public virtual unsafe void OnNetworkInterfaceStateUpdated (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1)
		{
			if (id_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_ == IntPtr.Zero)
				id_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_ = JNIEnv.GetMethodID (class_ref, "OnNetworkInterfaceStateUpdated", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnNetworkInterfaceStateUpdated", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnParticipantJoined (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnParticipantJoined' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnParticipantJoined", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnParticipantJoined (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
		{
			if (id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnParticipantJoined", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnParticipantJoined", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnParticipantLeft (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnParticipantLeft' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnParticipantLeft", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnParticipantLeft (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
		{
			if (id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnParticipantLeft", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnParticipantLeft", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteCameraAdded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnRemoteCameraAdded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
		{
			if (id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteCameraRemoved (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnRemoteCameraRemoved' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
		{
			if (id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteCameraStateUpdated (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnRemoteCameraStateUpdated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnRemoteCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnRemoteCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
		{
			if (id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteMicrophoneAdded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnRemoteMicrophoneAdded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
		{
			if (id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteMicrophoneRemoved (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnRemoteMicrophoneRemoved' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
		{
			if (id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteMicrophoneStateUpdated (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnRemoteMicrophoneStateUpdated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnRemoteMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnRemoteMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
		{
			if (id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteWindowShareAdded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnRemoteWindowShareAdded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
		{
			if (id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteWindowShareRemoved (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnRemoteWindowShareRemoved' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
		{
			if (id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteWindowShareStateUpdated (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnRemoteWindowShareStateUpdated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnRemoteWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnRemoteWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
		{
			if (id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
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
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		static IntPtr id_OnSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnSuccess' and count(parameter)=0]"
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

		static Delegate cb_OnWebProxyCredentialsRequest;
#pragma warning disable 0169
		static Delegate GetOnWebProxyCredentialsRequestHandler ()
		{
			if (cb_OnWebProxyCredentialsRequest == null)
				cb_OnWebProxyCredentialsRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebProxyCredentialsRequest);
			return cb_OnWebProxyCredentialsRequest;
		}

		static void n_OnWebProxyCredentialsRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWebProxyCredentialsRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_OnWebProxyCredentialsRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='OnWebProxyCredentialsRequest' and count(parameter)=0]"
		[Register ("OnWebProxyCredentialsRequest", "()V", "GetOnWebProxyCredentialsRequestHandler")]
		public virtual unsafe void OnWebProxyCredentialsRequest ()
		{
			if (id_OnWebProxyCredentialsRequest == IntPtr.Zero)
				id_OnWebProxyCredentialsRequest = JNIEnv.GetMethodID (class_ref, "OnWebProxyCredentialsRequest", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnWebProxyCredentialsRequest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnWebProxyCredentialsRequest", "()V"));
			} finally {
			}
		}

		static Delegate cb_RecorderInCall_Z;
#pragma warning disable 0169
		static Delegate GetRecorderInCall_ZHandler ()
		{
			if (cb_RecorderInCall_Z == null)
				cb_RecorderInCall_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_RecorderInCall_Z);
			return cb_RecorderInCall_Z;
		}

		static void n_RecorderInCall_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecorderInCall (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RecorderInCall_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RecorderInCall' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("RecorderInCall", "(Z)V", "GetRecorderInCall_ZHandler")]
		public virtual unsafe void RecorderInCall (bool p0)
		{
			if (id_RecorderInCall_Z == IntPtr.Zero)
				id_RecorderInCall_Z = JNIEnv.GetMethodID (class_ref, "RecorderInCall", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RecorderInCall_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RecorderInCall", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_Handler ()
		{
			if (cb_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_ == null)
				cb_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_);
			return cb_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_;
		}

		static bool n_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalCameraEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterLocalCameraEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener']]"
		[Register ("RegisterLocalCameraEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalCameraEventListener;)Z", "GetRegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_Handler")]
		public virtual unsafe bool RegisterLocalCameraEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener p0)
		{
			if (id_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_ == IntPtr.Zero)
				id_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalCameraEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalCameraEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalCameraEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalCameraEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalCameraEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_Handler ()
		{
			if (cb_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_ == null)
				cb_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_);
			return cb_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_;
		}

		static bool n_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalMicrophoneEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterLocalMicrophoneEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener']]"
		[Register ("RegisterLocalMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMicrophoneEventListener;)Z", "GetRegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_Handler")]
		public virtual unsafe bool RegisterLocalMicrophoneEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener p0)
		{
			if (id_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_ == IntPtr.Zero)
				id_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMicrophoneEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMicrophoneEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMicrophoneEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_Handler ()
		{
			if (cb_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_ == null)
				cb_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_);
			return cb_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_;
		}

		static bool n_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalMonitorEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterLocalMonitorEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener']]"
		[Register ("RegisterLocalMonitorEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMonitorEventListener;)Z", "GetRegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_Handler")]
		public virtual unsafe bool RegisterLocalMonitorEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMonitorEventListener p0)
		{
			if (id_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_ == IntPtr.Zero)
				id_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalMonitorEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMonitorEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalMonitorEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalMonitorEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalMonitorEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_Handler ()
		{
			if (cb_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_ == null)
				cb_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_);
			return cb_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_;
		}

		static bool n_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalSpeakerEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterLocalSpeakerEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener']]"
		[Register ("RegisterLocalSpeakerEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalSpeakerEventListener;)Z", "GetRegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_Handler")]
		public virtual unsafe bool RegisterLocalSpeakerEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener p0)
		{
			if (id_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_ == IntPtr.Zero)
				id_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalSpeakerEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalSpeakerEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalSpeakerEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalSpeakerEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalSpeakerEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_Handler ()
		{
			if (cb_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_ == null)
				cb_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_);
			return cb_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_;
		}

		static bool n_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalWindowShareEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterLocalWindowShareEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener']]"
		[Register ("RegisterLocalWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalWindowShareEventListener;)Z", "GetRegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_Handler")]
		public virtual unsafe bool RegisterLocalWindowShareEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener p0)
		{
			if (id_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_ == IntPtr.Zero)
				id_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalWindowShareEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLocalWindowShareEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLocalWindowShareEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_Handler ()
		{
			if (cb_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_ == null)
				cb_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_);
			return cb_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_;
		}

		static bool n_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLogEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLogEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLogEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLogEventListener (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterLogEventListener' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLogEventListener'] and parameter[2][@type='java.lang.String']]"
		[Register ("RegisterLogEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLogEventListener;Ljava/lang/String;)Z", "GetRegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_Handler")]
		public virtual unsafe bool RegisterLogEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLogEventListener p0, string p1)
		{
			if (id_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_ == IntPtr.Zero)
				id_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "RegisterLogEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLogEventListener;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterLogEventListener_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLogEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterLogEventListener;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_Handler ()
		{
			if (cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_ == null)
				cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_);
			return cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_;
		}

		static bool n_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterMessageEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterMessageEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterMessageEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterMessageEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterMessageEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterMessageEventListener']]"
		[Register ("RegisterMessageEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterMessageEventListener;)Z", "GetRegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_Handler")]
		public virtual unsafe bool RegisterMessageEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterMessageEventListener p0)
		{
			if (id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_ == IntPtr.Zero)
				id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterMessageEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterMessageEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterMessageEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterMessageEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterMessageEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_Handler ()
		{
			if (cb_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_ == null)
				cb_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_);
			return cb_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_;
		}

		static bool n_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterNetworkInterfaceEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterNetworkInterfaceEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener']]"
		[Register ("RegisterNetworkInterfaceEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterNetworkInterfaceEventListener;)Z", "GetRegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_Handler")]
		public virtual unsafe bool RegisterNetworkInterfaceEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterNetworkInterfaceEventListener p0)
		{
			if (id_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_ == IntPtr.Zero)
				id_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterNetworkInterfaceEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterNetworkInterfaceEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterNetworkInterfaceEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterNetworkInterfaceEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterNetworkInterfaceEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_Handler ()
		{
			if (cb_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_ == null)
				cb_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_);
			return cb_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_;
		}

		static bool n_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterParticipantEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterParticipantEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener']]"
		[Register ("RegisterParticipantEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterParticipantEventListener;)Z", "GetRegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_Handler")]
		public virtual unsafe bool RegisterParticipantEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterParticipantEventListener p0)
		{
			if (id_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_ == IntPtr.Zero)
				id_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterParticipantEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterParticipantEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterParticipantEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterParticipantEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterParticipantEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_Handler ()
		{
			if (cb_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_ == null)
				cb_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_);
			return cb_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_;
		}

		static bool n_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRecoderInCallEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRecoderInCallEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRecoderInCallEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRecoderInCallEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterRecoderInCallEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRecoderInCallEventListener']]"
		[Register ("RegisterRecoderInCallEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRecoderInCallEventListener;)Z", "GetRegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_Handler")]
		public virtual unsafe bool RegisterRecoderInCallEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRecoderInCallEventListener p0)
		{
			if (id_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_ == IntPtr.Zero)
				id_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRecoderInCallEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRecoderInCallEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRecoderInCallEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRecoderInCallEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRecoderInCallEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_Handler ()
		{
			if (cb_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_ == null)
				cb_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_);
			return cb_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_;
		}

		static bool n_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRemoteCameraEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterRemoteCameraEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener']]"
		[Register ("RegisterRemoteCameraEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteCameraEventListener;)Z", "GetRegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_Handler")]
		public virtual unsafe bool RegisterRemoteCameraEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener p0)
		{
			if (id_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_ == IntPtr.Zero)
				id_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRemoteCameraEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteCameraEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteCameraEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRemoteCameraEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteCameraEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_Handler ()
		{
			if (cb_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_ == null)
				cb_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_);
			return cb_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_;
		}

		static bool n_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRemoteMicrophoneEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterRemoteMicrophoneEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener']]"
		[Register ("RegisterRemoteMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteMicrophoneEventListener;)Z", "GetRegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_Handler")]
		public virtual unsafe bool RegisterRemoteMicrophoneEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener p0)
		{
			if (id_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_ == IntPtr.Zero)
				id_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRemoteMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteMicrophoneEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteMicrophoneEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRemoteMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteMicrophoneEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_Handler ()
		{
			if (cb_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_ == null)
				cb_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_);
			return cb_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_;
		}

		static bool n_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRemoteWindowShareEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterRemoteWindowShareEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener']]"
		[Register ("RegisterRemoteWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteWindowShareEventListener;)Z", "GetRegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_Handler")]
		public virtual unsafe bool RegisterRemoteWindowShareEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener p0)
		{
			if (id_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_ == IntPtr.Zero)
				id_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRemoteWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteWindowShareEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterRemoteWindowShareEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRemoteWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterRemoteWindowShareEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_Handler ()
		{
			if (cb_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_ == null)
				cb_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_);
			return cb_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_;
		}

		static bool n_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterResourceManagerEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterResourceManagerEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener']]"
		[Register ("RegisterResourceManagerEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterResourceManagerEventListener;)Z", "GetRegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_Handler")]
		public virtual unsafe bool RegisterResourceManagerEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener p0)
		{
			if (id_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_ == IntPtr.Zero)
				id_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterResourceManagerEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterResourceManagerEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterResourceManagerEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterResourceManagerEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterResourceManagerEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_Handler ()
		{
			if (cb_RegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_ == null)
				cb_RegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_);
			return cb_RegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_;
		}

		static bool n_RegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterWebProxyEventListener p0 = (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterWebProxyEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterWebProxyEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterWebProxyEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='RegisterWebProxyEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterWebProxyEventListener']]"
		[Register ("RegisterWebProxyEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterWebProxyEventListener;)Z", "GetRegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_Handler")]
		public virtual unsafe bool RegisterWebProxyEventListener (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.IRegisterWebProxyEventListener p0)
		{
			if (id_RegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_ == IntPtr.Zero)
				id_RegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterWebProxyEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterWebProxyEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterWebProxyEventListener_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_IRegisterWebProxyEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterWebProxyEventListener", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$IRegisterWebProxyEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SelectDefaultCamera;
#pragma warning disable 0169
		static Delegate GetSelectDefaultCameraHandler ()
		{
			if (cb_SelectDefaultCamera == null)
				cb_SelectDefaultCamera = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SelectDefaultCamera);
			return cb_SelectDefaultCamera;
		}

		static bool n_SelectDefaultCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectDefaultCamera ();
		}
#pragma warning restore 0169

		static IntPtr id_SelectDefaultCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectDefaultCamera' and count(parameter)=0]"
		[Register ("SelectDefaultCamera", "()Z", "GetSelectDefaultCameraHandler")]
		public virtual unsafe bool SelectDefaultCamera ()
		{
			if (id_SelectDefaultCamera == IntPtr.Zero)
				id_SelectDefaultCamera = JNIEnv.GetMethodID (class_ref, "SelectDefaultCamera", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectDefaultCamera);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectDefaultCamera", "()Z"));
			} finally {
			}
		}

		static Delegate cb_SelectDefaultMicrophone;
#pragma warning disable 0169
		static Delegate GetSelectDefaultMicrophoneHandler ()
		{
			if (cb_SelectDefaultMicrophone == null)
				cb_SelectDefaultMicrophone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SelectDefaultMicrophone);
			return cb_SelectDefaultMicrophone;
		}

		static bool n_SelectDefaultMicrophone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectDefaultMicrophone ();
		}
#pragma warning restore 0169

		static IntPtr id_SelectDefaultMicrophone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectDefaultMicrophone' and count(parameter)=0]"
		[Register ("SelectDefaultMicrophone", "()Z", "GetSelectDefaultMicrophoneHandler")]
		public virtual unsafe bool SelectDefaultMicrophone ()
		{
			if (id_SelectDefaultMicrophone == IntPtr.Zero)
				id_SelectDefaultMicrophone = JNIEnv.GetMethodID (class_ref, "SelectDefaultMicrophone", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectDefaultMicrophone);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectDefaultMicrophone", "()Z"));
			} finally {
			}
		}

		static Delegate cb_SelectDefaultNetworkInterfaceForMedia;
#pragma warning disable 0169
		static Delegate GetSelectDefaultNetworkInterfaceForMediaHandler ()
		{
			if (cb_SelectDefaultNetworkInterfaceForMedia == null)
				cb_SelectDefaultNetworkInterfaceForMedia = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SelectDefaultNetworkInterfaceForMedia);
			return cb_SelectDefaultNetworkInterfaceForMedia;
		}

		static bool n_SelectDefaultNetworkInterfaceForMedia (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectDefaultNetworkInterfaceForMedia ();
		}
#pragma warning restore 0169

		static IntPtr id_SelectDefaultNetworkInterfaceForMedia;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectDefaultNetworkInterfaceForMedia' and count(parameter)=0]"
		[Register ("SelectDefaultNetworkInterfaceForMedia", "()Z", "GetSelectDefaultNetworkInterfaceForMediaHandler")]
		public virtual unsafe bool SelectDefaultNetworkInterfaceForMedia ()
		{
			if (id_SelectDefaultNetworkInterfaceForMedia == IntPtr.Zero)
				id_SelectDefaultNetworkInterfaceForMedia = JNIEnv.GetMethodID (class_ref, "SelectDefaultNetworkInterfaceForMedia", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectDefaultNetworkInterfaceForMedia);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectDefaultNetworkInterfaceForMedia", "()Z"));
			} finally {
			}
		}

		static Delegate cb_SelectDefaultNetworkInterfaceForSignaling;
#pragma warning disable 0169
		static Delegate GetSelectDefaultNetworkInterfaceForSignalingHandler ()
		{
			if (cb_SelectDefaultNetworkInterfaceForSignaling == null)
				cb_SelectDefaultNetworkInterfaceForSignaling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SelectDefaultNetworkInterfaceForSignaling);
			return cb_SelectDefaultNetworkInterfaceForSignaling;
		}

		static bool n_SelectDefaultNetworkInterfaceForSignaling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectDefaultNetworkInterfaceForSignaling ();
		}
#pragma warning restore 0169

		static IntPtr id_SelectDefaultNetworkInterfaceForSignaling;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectDefaultNetworkInterfaceForSignaling' and count(parameter)=0]"
		[Register ("SelectDefaultNetworkInterfaceForSignaling", "()Z", "GetSelectDefaultNetworkInterfaceForSignalingHandler")]
		public virtual unsafe bool SelectDefaultNetworkInterfaceForSignaling ()
		{
			if (id_SelectDefaultNetworkInterfaceForSignaling == IntPtr.Zero)
				id_SelectDefaultNetworkInterfaceForSignaling = JNIEnv.GetMethodID (class_ref, "SelectDefaultNetworkInterfaceForSignaling", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectDefaultNetworkInterfaceForSignaling);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectDefaultNetworkInterfaceForSignaling", "()Z"));
			} finally {
			}
		}

		static Delegate cb_SelectDefaultSpeaker;
#pragma warning disable 0169
		static Delegate GetSelectDefaultSpeakerHandler ()
		{
			if (cb_SelectDefaultSpeaker == null)
				cb_SelectDefaultSpeaker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SelectDefaultSpeaker);
			return cb_SelectDefaultSpeaker;
		}

		static bool n_SelectDefaultSpeaker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectDefaultSpeaker ();
		}
#pragma warning restore 0169

		static IntPtr id_SelectDefaultSpeaker;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectDefaultSpeaker' and count(parameter)=0]"
		[Register ("SelectDefaultSpeaker", "()Z", "GetSelectDefaultSpeakerHandler")]
		public virtual unsafe bool SelectDefaultSpeaker ()
		{
			if (id_SelectDefaultSpeaker == IntPtr.Zero)
				id_SelectDefaultSpeaker = JNIEnv.GetMethodID (class_ref, "SelectDefaultSpeaker", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectDefaultSpeaker);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectDefaultSpeaker", "()Z"));
			} finally {
			}
		}

		static Delegate cb_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
#pragma warning disable 0169
		static Delegate GetSelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler ()
		{
			if (cb_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == null)
				cb_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_);
			return cb_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		}

		static bool n_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectLocalCamera (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectLocalCamera' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
		[Register ("SelectLocalCamera", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)Z", "GetSelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler")]
		public virtual unsafe bool SelectLocalCamera (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
		{
			if (id_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == IntPtr.Zero)
				id_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNIEnv.GetMethodID (class_ref, "SelectLocalCamera", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectLocalCamera", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
#pragma warning disable 0169
		static Delegate GetSelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler ()
		{
			if (cb_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == null)
				cb_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_);
			return cb_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		}

		static bool n_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectLocalMicrophone (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectLocalMicrophone' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
		[Register ("SelectLocalMicrophone", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)Z", "GetSelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler")]
		public virtual unsafe bool SelectLocalMicrophone (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
		{
			if (id_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == IntPtr.Zero)
				id_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNIEnv.GetMethodID (class_ref, "SelectLocalMicrophone", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectLocalMicrophone", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
#pragma warning disable 0169
		static Delegate GetSelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler ()
		{
			if (cb_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == null)
				cb_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_);
			return cb_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		}

		static bool n_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectLocalMonitor (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectLocalMonitor' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
		[Register ("SelectLocalMonitor", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)Z", "GetSelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler")]
		public virtual unsafe bool SelectLocalMonitor (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
		{
			if (id_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == IntPtr.Zero)
				id_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNIEnv.GetMethodID (class_ref, "SelectLocalMonitor", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectLocalMonitor", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
		static Delegate GetSelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
		{
			if (cb_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
				cb_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
			return cb_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		}

		static bool n_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectLocalSpeaker (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectLocalSpeaker' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
		[Register ("SelectLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)Z", "GetSelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler")]
		public virtual unsafe bool SelectLocalSpeaker (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
		{
			if (id_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
				id_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "SelectLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
		static Delegate GetSelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
		{
			if (cb_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
				cb_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
			return cb_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		}

		static bool n_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectLocalWindowShare (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectLocalWindowShare' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
		[Register ("SelectLocalWindowShare", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)Z", "GetSelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler")]
		public virtual unsafe bool SelectLocalWindowShare (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
		{
			if (id_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
				id_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "SelectLocalWindowShare", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectLocalWindowShare", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
#pragma warning disable 0169
		static Delegate GetSelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler ()
		{
			if (cb_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == null)
				cb_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_);
			return cb_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		}

		static bool n_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectNetworkInterfaceForMedia (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectNetworkInterfaceForMedia' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
		[Register ("SelectNetworkInterfaceForMedia", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)Z", "GetSelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler")]
		public virtual unsafe bool SelectNetworkInterfaceForMedia (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0)
		{
			if (id_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == IntPtr.Zero)
				id_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNIEnv.GetMethodID (class_ref, "SelectNetworkInterfaceForMedia", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectNetworkInterfaceForMedia", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
#pragma warning disable 0169
		static Delegate GetSelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler ()
		{
			if (cb_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == null)
				cb_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_);
			return cb_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		}

		static bool n_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectNetworkInterfaceForSignaling (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SelectNetworkInterfaceForSignaling' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
		[Register ("SelectNetworkInterfaceForSignaling", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)Z", "GetSelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler")]
		public virtual unsafe bool SelectNetworkInterfaceForSignaling (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0)
		{
			if (id_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ == IntPtr.Zero)
				id_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_ = JNIEnv.GetMethodID (class_ref, "SelectNetworkInterfaceForSignaling", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectNetworkInterfaceForSignaling", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SendChatMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendChatMessage_Ljava_lang_String_Handler ()
		{
			if (cb_SendChatMessage_Ljava_lang_String_ == null)
				cb_SendChatMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendChatMessage_Ljava_lang_String_);
			return cb_SendChatMessage_Ljava_lang_String_;
		}

		static bool n_SendChatMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendChatMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SendChatMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SendChatMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SendChatMessage", "(Ljava/lang/String;)Z", "GetSendChatMessage_Ljava_lang_String_Handler")]
		public virtual unsafe bool SendChatMessage (string p0)
		{
			if (id_SendChatMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_SendChatMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SendChatMessage", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SendChatMessage_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SendChatMessage", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SetCameraPrivacy_Z;
#pragma warning disable 0169
		static Delegate GetSetCameraPrivacy_ZHandler ()
		{
			if (cb_SetCameraPrivacy_Z == null)
				cb_SetCameraPrivacy_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetCameraPrivacy_Z);
			return cb_SetCameraPrivacy_Z;
		}

		static bool n_SetCameraPrivacy_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetCameraPrivacy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetCameraPrivacy_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SetCameraPrivacy' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetCameraPrivacy", "(Z)Z", "GetSetCameraPrivacy_ZHandler")]
		public virtual unsafe bool SetCameraPrivacy (bool p0)
		{
			if (id_SetCameraPrivacy_Z == IntPtr.Zero)
				id_SetCameraPrivacy_Z = JNIEnv.GetMethodID (class_ref, "SetCameraPrivacy", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetCameraPrivacy_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCameraPrivacy", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetCertificateAuthorityList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCertificateAuthorityList_Ljava_lang_String_Handler ()
		{
			if (cb_SetCertificateAuthorityList_Ljava_lang_String_ == null)
				cb_SetCertificateAuthorityList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCertificateAuthorityList_Ljava_lang_String_);
			return cb_SetCertificateAuthorityList_Ljava_lang_String_;
		}

		static void n_SetCertificateAuthorityList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCertificateAuthorityList (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetCertificateAuthorityList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SetCertificateAuthorityList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetCertificateAuthorityList", "(Ljava/lang/String;)V", "GetSetCertificateAuthorityList_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCertificateAuthorityList (string p0)
		{
			if (id_SetCertificateAuthorityList_Ljava_lang_String_ == IntPtr.Zero)
				id_SetCertificateAuthorityList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetCertificateAuthorityList", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetCertificateAuthorityList_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCertificateAuthorityList", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SetLocation_DD;
#pragma warning disable 0169
		static Delegate GetSetLocation_DDHandler ()
		{
			if (cb_SetLocation_DD == null)
				cb_SetLocation_DD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, bool>) n_SetLocation_DD);
			return cb_SetLocation_DD;
		}

		static bool n_SetLocation_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetLocation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_SetLocation_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SetLocation' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("SetLocation", "(DD)Z", "GetSetLocation_DDHandler")]
		public virtual unsafe bool SetLocation (double p0, double p1)
		{
			if (id_SetLocation_DD == IntPtr.Zero)
				id_SetLocation_DD = JNIEnv.GetMethodID (class_ref, "SetLocation", "(DD)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetLocation_DD, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetLocation", "(DD)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetMicrophonePrivacy_Z;
#pragma warning disable 0169
		static Delegate GetSetMicrophonePrivacy_ZHandler ()
		{
			if (cb_SetMicrophonePrivacy_Z == null)
				cb_SetMicrophonePrivacy_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetMicrophonePrivacy_Z);
			return cb_SetMicrophonePrivacy_Z;
		}

		static bool n_SetMicrophonePrivacy_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetMicrophonePrivacy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetMicrophonePrivacy_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SetMicrophonePrivacy' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetMicrophonePrivacy", "(Z)Z", "GetSetMicrophonePrivacy_ZHandler")]
		public virtual unsafe bool SetMicrophonePrivacy (bool p0)
		{
			if (id_SetMicrophonePrivacy_Z == IntPtr.Zero)
				id_SetMicrophonePrivacy_Z = JNIEnv.GetMethodID (class_ref, "SetMicrophonePrivacy", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetMicrophonePrivacy_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMicrophonePrivacy", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_;
#pragma warning disable 0169
		static Delegate GetSetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_Handler ()
		{
			if (cb_SetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_ == null)
				cb_SetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_);
			return cb_SetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_;
		}

		static bool n_SetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetMode (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SetMode' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode']]"
		[Register ("SetMode", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode;)Z", "GetSetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_Handler")]
		public virtual unsafe bool SetMode (global::Com.Vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorMode p0)
		{
			if (id_SetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_ == IntPtr.Zero)
				id_SetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_ = JNIEnv.GetMethodID (class_ref, "SetMode", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetMode_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorMode_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMode", "(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorMode;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetSpeakerPrivacy_Z;
#pragma warning disable 0169
		static Delegate GetSetSpeakerPrivacy_ZHandler ()
		{
			if (cb_SetSpeakerPrivacy_Z == null)
				cb_SetSpeakerPrivacy_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetSpeakerPrivacy_Z);
			return cb_SetSpeakerPrivacy_Z;
		}

		static bool n_SetSpeakerPrivacy_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSpeakerPrivacy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetSpeakerPrivacy_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SetSpeakerPrivacy' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetSpeakerPrivacy", "(Z)Z", "GetSetSpeakerPrivacy_ZHandler")]
		public virtual unsafe bool SetSpeakerPrivacy (bool p0)
		{
			if (id_SetSpeakerPrivacy_Z == IntPtr.Zero)
				id_SetSpeakerPrivacy_Z = JNIEnv.GetMethodID (class_ref, "SetSpeakerPrivacy", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetSpeakerPrivacy_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSpeakerPrivacy", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetViewAnimationSpeed_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetSetViewAnimationSpeed_Ljava_lang_Object_IHandler ()
		{
			if (cb_SetViewAnimationSpeed_Ljava_lang_Object_I == null)
				cb_SetViewAnimationSpeed_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_SetViewAnimationSpeed_Ljava_lang_Object_I);
			return cb_SetViewAnimationSpeed_Ljava_lang_Object_I;
		}

		static bool n_SetViewAnimationSpeed_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetViewAnimationSpeed (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetViewAnimationSpeed_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SetViewAnimationSpeed' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("SetViewAnimationSpeed", "(Ljava/lang/Object;I)Z", "GetSetViewAnimationSpeed_Ljava_lang_Object_IHandler")]
		public virtual unsafe bool SetViewAnimationSpeed (global::Java.Lang.Object p0, int p1)
		{
			if (id_SetViewAnimationSpeed_Ljava_lang_Object_I == IntPtr.Zero)
				id_SetViewAnimationSpeed_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "SetViewAnimationSpeed", "(Ljava/lang/Object;I)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetViewAnimationSpeed_Ljava_lang_Object_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetViewAnimationSpeed", "(Ljava/lang/Object;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetViewBackgroundColor_Ljava_lang_Object_BBB;
#pragma warning disable 0169
		static Delegate GetSetViewBackgroundColor_Ljava_lang_Object_BBBHandler ()
		{
			if (cb_SetViewBackgroundColor_Ljava_lang_Object_BBB == null)
				cb_SetViewBackgroundColor_Ljava_lang_Object_BBB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, sbyte, sbyte, sbyte, bool>) n_SetViewBackgroundColor_Ljava_lang_Object_BBB);
			return cb_SetViewBackgroundColor_Ljava_lang_Object_BBB;
		}

		static bool n_SetViewBackgroundColor_Ljava_lang_Object_BBB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, sbyte p1, sbyte p2, sbyte p3)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetViewBackgroundColor (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetViewBackgroundColor_Ljava_lang_Object_BBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SetViewBackgroundColor' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte']]"
		[Register ("SetViewBackgroundColor", "(Ljava/lang/Object;BBB)Z", "GetSetViewBackgroundColor_Ljava_lang_Object_BBBHandler")]
		public virtual unsafe bool SetViewBackgroundColor (global::Java.Lang.Object p0, sbyte p1, sbyte p2, sbyte p3)
		{
			if (id_SetViewBackgroundColor_Ljava_lang_Object_BBB == IntPtr.Zero)
				id_SetViewBackgroundColor_Ljava_lang_Object_BBB = JNIEnv.GetMethodID (class_ref, "SetViewBackgroundColor", "(Ljava/lang/Object;BBB)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetViewBackgroundColor_Ljava_lang_Object_BBB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetViewBackgroundColor", "(Ljava/lang/Object;BBB)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetWebProxyAddressCredentials (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='SetWebProxyAddressCredentials' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("SetWebProxyAddressCredentials", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetWebProxyAddressCredentials (string p0, string p1, string p2)
		{
			if (id_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetWebProxyAddressCredentials", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetWebProxyAddressCredentials", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_ShowAudioMeters_Ljava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetShowAudioMeters_Ljava_lang_Object_ZHandler ()
		{
			if (cb_ShowAudioMeters_Ljava_lang_Object_Z == null)
				cb_ShowAudioMeters_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_ShowAudioMeters_Ljava_lang_Object_Z);
			return cb_ShowAudioMeters_Ljava_lang_Object_Z;
		}

		static bool n_ShowAudioMeters_Ljava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowAudioMeters (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ShowAudioMeters_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='ShowAudioMeters' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean']]"
		[Register ("ShowAudioMeters", "(Ljava/lang/Object;Z)Z", "GetShowAudioMeters_Ljava_lang_Object_ZHandler")]
		public virtual unsafe bool ShowAudioMeters (global::Java.Lang.Object p0, bool p1)
		{
			if (id_ShowAudioMeters_Ljava_lang_Object_Z == IntPtr.Zero)
				id_ShowAudioMeters_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "ShowAudioMeters", "(Ljava/lang/Object;Z)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_ShowAudioMeters_Ljava_lang_Object_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowAudioMeters", "(Ljava/lang/Object;Z)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_ShowPreview_Z;
#pragma warning disable 0169
		static Delegate GetShowPreview_ZHandler ()
		{
			if (cb_ShowPreview_Z == null)
				cb_ShowPreview_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_ShowPreview_Z);
			return cb_ShowPreview_Z;
		}

		static bool n_ShowPreview_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowPreview (p0);
		}
#pragma warning restore 0169

		static IntPtr id_ShowPreview_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='ShowPreview' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("ShowPreview", "(Z)Z", "GetShowPreview_ZHandler")]
		public virtual unsafe bool ShowPreview (bool p0)
		{
			if (id_ShowPreview_Z == IntPtr.Zero)
				id_ShowPreview_Z = JNIEnv.GetMethodID (class_ref, "ShowPreview", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_ShowPreview_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowPreview", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_ShowViewAt_Ljava_lang_Object_IIII;
#pragma warning disable 0169
		static Delegate GetShowViewAt_Ljava_lang_Object_IIIIHandler ()
		{
			if (cb_ShowViewAt_Ljava_lang_Object_IIII == null)
				cb_ShowViewAt_Ljava_lang_Object_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, bool>) n_ShowViewAt_Ljava_lang_Object_IIII);
			return cb_ShowViewAt_Ljava_lang_Object_IIII;
		}

		static bool n_ShowViewAt_Ljava_lang_Object_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowViewAt (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ShowViewAt_Ljava_lang_Object_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='ShowViewAt' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("ShowViewAt", "(Ljava/lang/Object;IIII)Z", "GetShowViewAt_Ljava_lang_Object_IIIIHandler")]
		public virtual unsafe bool ShowViewAt (global::Java.Lang.Object p0, int p1, int p2, int p3, int p4)
		{
			if (id_ShowViewAt_Ljava_lang_Object_IIII == IntPtr.Zero)
				id_ShowViewAt_Ljava_lang_Object_IIII = JNIEnv.GetMethodID (class_ref, "ShowViewAt", "(Ljava/lang/Object;IIII)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_ShowViewAt_Ljava_lang_Object_IIII, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowViewAt", "(Ljava/lang/Object;IIII)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_ShowViewLabel_Ljava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetShowViewLabel_Ljava_lang_Object_ZHandler ()
		{
			if (cb_ShowViewLabel_Ljava_lang_Object_Z == null)
				cb_ShowViewLabel_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_ShowViewLabel_Ljava_lang_Object_Z);
			return cb_ShowViewLabel_Ljava_lang_Object_Z;
		}

		static bool n_ShowViewLabel_Ljava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowViewLabel (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ShowViewLabel_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='ShowViewLabel' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean']]"
		[Register ("ShowViewLabel", "(Ljava/lang/Object;Z)Z", "GetShowViewLabel_Ljava_lang_Object_ZHandler")]
		public virtual unsafe bool ShowViewLabel (global::Java.Lang.Object p0, bool p1)
		{
			if (id_ShowViewLabel_Ljava_lang_Object_Z == IntPtr.Zero)
				id_ShowViewLabel_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "ShowViewLabel", "(Ljava/lang/Object;Z)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_ShowViewLabel_Ljava_lang_Object_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowViewLabel", "(Ljava/lang/Object;Z)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_UnregisterLocalCameraEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterLocalCameraEventListenerHandler ()
		{
			if (cb_UnregisterLocalCameraEventListener == null)
				cb_UnregisterLocalCameraEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterLocalCameraEventListener);
			return cb_UnregisterLocalCameraEventListener;
		}

		static bool n_UnregisterLocalCameraEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalCameraEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalCameraEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterLocalCameraEventListener' and count(parameter)=0]"
		[Register ("UnregisterLocalCameraEventListener", "()Z", "GetUnregisterLocalCameraEventListenerHandler")]
		public virtual unsafe bool UnregisterLocalCameraEventListener ()
		{
			if (id_UnregisterLocalCameraEventListener == IntPtr.Zero)
				id_UnregisterLocalCameraEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterLocalCameraEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterLocalCameraEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterLocalCameraEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterLocalMicrophoneEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterLocalMicrophoneEventListenerHandler ()
		{
			if (cb_UnregisterLocalMicrophoneEventListener == null)
				cb_UnregisterLocalMicrophoneEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterLocalMicrophoneEventListener);
			return cb_UnregisterLocalMicrophoneEventListener;
		}

		static bool n_UnregisterLocalMicrophoneEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalMicrophoneEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalMicrophoneEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterLocalMicrophoneEventListener' and count(parameter)=0]"
		[Register ("UnregisterLocalMicrophoneEventListener", "()Z", "GetUnregisterLocalMicrophoneEventListenerHandler")]
		public virtual unsafe bool UnregisterLocalMicrophoneEventListener ()
		{
			if (id_UnregisterLocalMicrophoneEventListener == IntPtr.Zero)
				id_UnregisterLocalMicrophoneEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterLocalMicrophoneEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterLocalMicrophoneEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterLocalMicrophoneEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterLocalMonitorEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterLocalMonitorEventListenerHandler ()
		{
			if (cb_UnregisterLocalMonitorEventListener == null)
				cb_UnregisterLocalMonitorEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterLocalMonitorEventListener);
			return cb_UnregisterLocalMonitorEventListener;
		}

		static bool n_UnregisterLocalMonitorEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalMonitorEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalMonitorEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterLocalMonitorEventListener' and count(parameter)=0]"
		[Register ("UnregisterLocalMonitorEventListener", "()Z", "GetUnregisterLocalMonitorEventListenerHandler")]
		public virtual unsafe bool UnregisterLocalMonitorEventListener ()
		{
			if (id_UnregisterLocalMonitorEventListener == IntPtr.Zero)
				id_UnregisterLocalMonitorEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterLocalMonitorEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterLocalMonitorEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterLocalMonitorEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterLocalSpeakerEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterLocalSpeakerEventListenerHandler ()
		{
			if (cb_UnregisterLocalSpeakerEventListener == null)
				cb_UnregisterLocalSpeakerEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterLocalSpeakerEventListener);
			return cb_UnregisterLocalSpeakerEventListener;
		}

		static bool n_UnregisterLocalSpeakerEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalSpeakerEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalSpeakerEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterLocalSpeakerEventListener' and count(parameter)=0]"
		[Register ("UnregisterLocalSpeakerEventListener", "()Z", "GetUnregisterLocalSpeakerEventListenerHandler")]
		public virtual unsafe bool UnregisterLocalSpeakerEventListener ()
		{
			if (id_UnregisterLocalSpeakerEventListener == IntPtr.Zero)
				id_UnregisterLocalSpeakerEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterLocalSpeakerEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterLocalSpeakerEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterLocalSpeakerEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterLocalWindowShareEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterLocalWindowShareEventListenerHandler ()
		{
			if (cb_UnregisterLocalWindowShareEventListener == null)
				cb_UnregisterLocalWindowShareEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterLocalWindowShareEventListener);
			return cb_UnregisterLocalWindowShareEventListener;
		}

		static bool n_UnregisterLocalWindowShareEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalWindowShareEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalWindowShareEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterLocalWindowShareEventListener' and count(parameter)=0]"
		[Register ("UnregisterLocalWindowShareEventListener", "()Z", "GetUnregisterLocalWindowShareEventListenerHandler")]
		public virtual unsafe bool UnregisterLocalWindowShareEventListener ()
		{
			if (id_UnregisterLocalWindowShareEventListener == IntPtr.Zero)
				id_UnregisterLocalWindowShareEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterLocalWindowShareEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterLocalWindowShareEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterLocalWindowShareEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterLogEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterLogEventListenerHandler ()
		{
			if (cb_UnregisterLogEventListener == null)
				cb_UnregisterLogEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterLogEventListener);
			return cb_UnregisterLogEventListener;
		}

		static bool n_UnregisterLogEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLogEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLogEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterLogEventListener' and count(parameter)=0]"
		[Register ("UnregisterLogEventListener", "()Z", "GetUnregisterLogEventListenerHandler")]
		public virtual unsafe bool UnregisterLogEventListener ()
		{
			if (id_UnregisterLogEventListener == IntPtr.Zero)
				id_UnregisterLogEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterLogEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterLogEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterLogEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterMessageEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterMessageEventListenerHandler ()
		{
			if (cb_UnregisterMessageEventListener == null)
				cb_UnregisterMessageEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterMessageEventListener);
			return cb_UnregisterMessageEventListener;
		}

		static bool n_UnregisterMessageEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterMessageEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterMessageEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterMessageEventListener' and count(parameter)=0]"
		[Register ("UnregisterMessageEventListener", "()Z", "GetUnregisterMessageEventListenerHandler")]
		public virtual unsafe bool UnregisterMessageEventListener ()
		{
			if (id_UnregisterMessageEventListener == IntPtr.Zero)
				id_UnregisterMessageEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterMessageEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterMessageEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterMessageEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterNetworkInterfaceEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterNetworkInterfaceEventListenerHandler ()
		{
			if (cb_UnregisterNetworkInterfaceEventListener == null)
				cb_UnregisterNetworkInterfaceEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterNetworkInterfaceEventListener);
			return cb_UnregisterNetworkInterfaceEventListener;
		}

		static bool n_UnregisterNetworkInterfaceEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterNetworkInterfaceEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterNetworkInterfaceEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterNetworkInterfaceEventListener' and count(parameter)=0]"
		[Register ("UnregisterNetworkInterfaceEventListener", "()Z", "GetUnregisterNetworkInterfaceEventListenerHandler")]
		public virtual unsafe bool UnregisterNetworkInterfaceEventListener ()
		{
			if (id_UnregisterNetworkInterfaceEventListener == IntPtr.Zero)
				id_UnregisterNetworkInterfaceEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterNetworkInterfaceEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterNetworkInterfaceEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterNetworkInterfaceEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterParticipantEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterParticipantEventListenerHandler ()
		{
			if (cb_UnregisterParticipantEventListener == null)
				cb_UnregisterParticipantEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterParticipantEventListener);
			return cb_UnregisterParticipantEventListener;
		}

		static bool n_UnregisterParticipantEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterParticipantEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterParticipantEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterParticipantEventListener' and count(parameter)=0]"
		[Register ("UnregisterParticipantEventListener", "()Z", "GetUnregisterParticipantEventListenerHandler")]
		public virtual unsafe bool UnregisterParticipantEventListener ()
		{
			if (id_UnregisterParticipantEventListener == IntPtr.Zero)
				id_UnregisterParticipantEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterParticipantEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterParticipantEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterParticipantEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterRecoderInCallEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterRecoderInCallEventListenerHandler ()
		{
			if (cb_UnregisterRecoderInCallEventListener == null)
				cb_UnregisterRecoderInCallEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterRecoderInCallEventListener);
			return cb_UnregisterRecoderInCallEventListener;
		}

		static bool n_UnregisterRecoderInCallEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRecoderInCallEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRecoderInCallEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterRecoderInCallEventListener' and count(parameter)=0]"
		[Register ("UnregisterRecoderInCallEventListener", "()Z", "GetUnregisterRecoderInCallEventListenerHandler")]
		public virtual unsafe bool UnregisterRecoderInCallEventListener ()
		{
			if (id_UnregisterRecoderInCallEventListener == IntPtr.Zero)
				id_UnregisterRecoderInCallEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterRecoderInCallEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterRecoderInCallEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterRecoderInCallEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterRemoteCameraEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterRemoteCameraEventListenerHandler ()
		{
			if (cb_UnregisterRemoteCameraEventListener == null)
				cb_UnregisterRemoteCameraEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterRemoteCameraEventListener);
			return cb_UnregisterRemoteCameraEventListener;
		}

		static bool n_UnregisterRemoteCameraEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRemoteCameraEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRemoteCameraEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterRemoteCameraEventListener' and count(parameter)=0]"
		[Register ("UnregisterRemoteCameraEventListener", "()Z", "GetUnregisterRemoteCameraEventListenerHandler")]
		public virtual unsafe bool UnregisterRemoteCameraEventListener ()
		{
			if (id_UnregisterRemoteCameraEventListener == IntPtr.Zero)
				id_UnregisterRemoteCameraEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterRemoteCameraEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterRemoteCameraEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterRemoteCameraEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterRemoteMicrophoneEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterRemoteMicrophoneEventListenerHandler ()
		{
			if (cb_UnregisterRemoteMicrophoneEventListener == null)
				cb_UnregisterRemoteMicrophoneEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterRemoteMicrophoneEventListener);
			return cb_UnregisterRemoteMicrophoneEventListener;
		}

		static bool n_UnregisterRemoteMicrophoneEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRemoteMicrophoneEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRemoteMicrophoneEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterRemoteMicrophoneEventListener' and count(parameter)=0]"
		[Register ("UnregisterRemoteMicrophoneEventListener", "()Z", "GetUnregisterRemoteMicrophoneEventListenerHandler")]
		public virtual unsafe bool UnregisterRemoteMicrophoneEventListener ()
		{
			if (id_UnregisterRemoteMicrophoneEventListener == IntPtr.Zero)
				id_UnregisterRemoteMicrophoneEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterRemoteMicrophoneEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterRemoteMicrophoneEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterRemoteMicrophoneEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterRemoteWindowShareEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterRemoteWindowShareEventListenerHandler ()
		{
			if (cb_UnregisterRemoteWindowShareEventListener == null)
				cb_UnregisterRemoteWindowShareEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterRemoteWindowShareEventListener);
			return cb_UnregisterRemoteWindowShareEventListener;
		}

		static bool n_UnregisterRemoteWindowShareEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRemoteWindowShareEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRemoteWindowShareEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterRemoteWindowShareEventListener' and count(parameter)=0]"
		[Register ("UnregisterRemoteWindowShareEventListener", "()Z", "GetUnregisterRemoteWindowShareEventListenerHandler")]
		public virtual unsafe bool UnregisterRemoteWindowShareEventListener ()
		{
			if (id_UnregisterRemoteWindowShareEventListener == IntPtr.Zero)
				id_UnregisterRemoteWindowShareEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterRemoteWindowShareEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterRemoteWindowShareEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterRemoteWindowShareEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterResourceManagerEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterResourceManagerEventListenerHandler ()
		{
			if (cb_UnregisterResourceManagerEventListener == null)
				cb_UnregisterResourceManagerEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterResourceManagerEventListener);
			return cb_UnregisterResourceManagerEventListener;
		}

		static bool n_UnregisterResourceManagerEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterResourceManagerEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterResourceManagerEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterResourceManagerEventListener' and count(parameter)=0]"
		[Register ("UnregisterResourceManagerEventListener", "()Z", "GetUnregisterResourceManagerEventListenerHandler")]
		public virtual unsafe bool UnregisterResourceManagerEventListener ()
		{
			if (id_UnregisterResourceManagerEventListener == IntPtr.Zero)
				id_UnregisterResourceManagerEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterResourceManagerEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterResourceManagerEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterResourceManagerEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterWebProxyEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterWebProxyEventListenerHandler ()
		{
			if (cb_UnregisterWebProxyEventListener == null)
				cb_UnregisterWebProxyEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterWebProxyEventListener);
			return cb_UnregisterWebProxyEventListener;
		}

		static bool n_UnregisterWebProxyEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterWebProxyEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterWebProxyEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='UnregisterWebProxyEventListener' and count(parameter)=0]"
		[Register ("UnregisterWebProxyEventListener", "()Z", "GetUnregisterWebProxyEventListenerHandler")]
		public virtual unsafe bool UnregisterWebProxyEventListener ()
		{
			if (id_UnregisterWebProxyEventListener == IntPtr.Zero)
				id_UnregisterWebProxyEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterWebProxyEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterWebProxyEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterWebProxyEventListener", "()Z"));
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
			global::Com.Vidyo.VidyoClient.Connector.VidyoConnector __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Connector.VidyoConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Connector']/class[@name='VidyoConnector']/method[@name='dispose' and count(parameter)=0]"
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
