using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint", DoNotGenerateAcw=true)]
	public partial class VidyoEndpoint : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.ICompressLogs']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$ICompressLogs", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/ICompressLogsInvoker")]
		public partial interface ICompressLogs : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.ICompressLogs']/method[@name='OnLogCompressionComplete' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult']]"
			[Register ("OnLogCompressionComplete", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;)V", "GetOnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/ICompressLogsInvoker, VidyoClientAndroid")]
			void OnLogCompressionComplete (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$ICompressLogs", DoNotGenerateAcw=true)]
		internal class ICompressLogsInvoker : global::Java.Lang.Object, ICompressLogs {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$ICompressLogs");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICompressLogsInvoker); }
			}

			IntPtr class_ref;

			public static ICompressLogs GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICompressLogs> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.ICompressLogs"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICompressLogsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_;
#pragma warning disable 0169
			static Delegate GetOnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_Handler ()
			{
				if (cb_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_ == null)
					cb_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_);
				return cb_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_;
			}

			static void n_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.ICompressLogs __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.ICompressLogs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnLogCompressionComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_;
			public unsafe void OnLogCompressionComplete (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult p1)
			{
				if (id_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_ == IntPtr.Zero)
					id_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_ = JNIEnv.GetMethodID (class_ref, "OnLogCompressionComplete", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalCameraEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalCameraEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalCameraEventListenerInvoker")]
		public partial interface IRegisterLocalCameraEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalCameraEventListener']/method[@name='OnLocalCameraAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
			[Register ("OnLocalCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetOnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalCameraEventListener']/method[@name='OnLocalCameraRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
			[Register ("OnLocalCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetOnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalCameraEventListener']/method[@name='OnLocalCameraSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
			[Register ("OnLocalCameraSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetOnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalCameraSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalCameraEventListener']/method[@name='OnLocalCameraStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalCameraEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalCameraEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalCameraEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalCameraEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener"));
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalCameraEventListenerImplementor")]
		internal sealed partial class IRegisterLocalCameraEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalCameraEventListener {

			object sender;

			public IRegisterLocalCameraEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalCameraEventListenerImplementor", "()V"),
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalMicrophoneEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMicrophoneEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMicrophoneEventListenerInvoker")]
		public partial interface IRegisterLocalMicrophoneEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalMicrophoneEventListener']/method[@name='OnLocalMicrophoneAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
			[Register ("OnLocalMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetOnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalMicrophoneEventListener']/method[@name='OnLocalMicrophoneRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
			[Register ("OnLocalMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetOnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalMicrophoneEventListener']/method[@name='OnLocalMicrophoneSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
			[Register ("OnLocalMicrophoneSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetOnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMicrophoneSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalMicrophoneEventListener']/method[@name='OnLocalMicrophoneStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMicrophoneEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalMicrophoneEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalMicrophoneEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMicrophoneEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener"));
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalMicrophoneEventListenerImplementor")]
		internal sealed partial class IRegisterLocalMicrophoneEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalMicrophoneEventListener {

			object sender;

			public IRegisterLocalMicrophoneEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalMicrophoneEventListenerImplementor", "()V"),
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalMonitorEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMonitorEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMonitorEventListenerInvoker")]
		public partial interface IRegisterLocalMonitorEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalMonitorEventListener']/method[@name='OnLocalMonitorAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
			[Register ("OnLocalMonitorAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetOnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMonitorAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalMonitorEventListener']/method[@name='OnLocalMonitorRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
			[Register ("OnLocalMonitorRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetOnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMonitorRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalMonitorEventListener']/method[@name='OnLocalMonitorSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
			[Register ("OnLocalMonitorSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetOnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMonitorSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalMonitorEventListener']/method[@name='OnLocalMonitorStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalMonitorStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalMonitorStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMonitorEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalMonitorEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalMonitorEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMonitorEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener"));
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalMonitorEventListenerImplementor")]
		internal sealed partial class IRegisterLocalMonitorEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalMonitorEventListener {

			object sender;

			public IRegisterLocalMonitorEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalMonitorEventListenerImplementor", "()V"),
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalRendererEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalRendererEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalRendererEventListenerInvoker")]
		public partial interface IRegisterLocalRendererEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalRendererEventListener']/method[@name='OnLocalRendererAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
			[Register ("OnLocalRendererAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V", "GetOnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalRendererEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalRendererAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalRendererEventListener']/method[@name='OnLocalRendererRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
			[Register ("OnLocalRendererRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V", "GetOnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalRendererEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalRendererRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalRendererEventListener']/method[@name='OnLocalRendererSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
			[Register ("OnLocalRendererSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V", "GetOnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalRendererEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalRendererSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalRendererEventListener']/method[@name='OnLocalRendererStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalRendererStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalRendererEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalRendererStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalRendererEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalRendererEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalRendererEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalRendererEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterLocalRendererEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterLocalRendererEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterLocalRendererEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterLocalRendererEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
			static Delegate GetOnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
			{
				if (cb_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
					cb_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
				return cb_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
			}

			static void n_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalRendererAdded (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
			public unsafe void OnLocalRendererAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
			{
				if (id_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
					id_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "OnLocalRendererAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
			}

			static Delegate cb_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
			static Delegate GetOnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
			{
				if (cb_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
					cb_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
				return cb_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
			}

			static void n_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalRendererRemoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
			public unsafe void OnLocalRendererRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
			{
				if (id_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
					id_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "OnLocalRendererRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
			}

			static Delegate cb_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
			static Delegate GetOnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
			{
				if (cb_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
					cb_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
				return cb_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
			}

			static void n_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalRendererSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
			public unsafe void OnLocalRendererSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
			{
				if (id_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
					id_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "OnLocalRendererSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
			}

			static Delegate cb_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnLocalRendererStateUpdated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnLocalRendererStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				if (id_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalRendererStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class LocalRendererAddedEventArgs : global::System.EventArgs {

			public LocalRendererAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer P0 {
				get { return p0; }
			}
		}

		public partial class LocalRendererRemovedEventArgs : global::System.EventArgs {

			public LocalRendererRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer P0 {
				get { return p0; }
			}
		}

		public partial class LocalRendererSelectedEventArgs : global::System.EventArgs {

			public LocalRendererSelectedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer P0 {
				get { return p0; }
			}
		}

		public partial class LocalRendererStateUpdatedEventArgs : global::System.EventArgs {

			public LocalRendererStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalRendererEventListenerImplementor")]
		internal sealed partial class IRegisterLocalRendererEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalRendererEventListener {

			object sender;

			public IRegisterLocalRendererEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalRendererEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<LocalRendererAddedEventArgs> OnLocalRendererAddedHandler;
#pragma warning restore 0649

			public void OnLocalRendererAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
			{
				var __h = OnLocalRendererAddedHandler;
				if (__h != null)
					__h (sender, new LocalRendererAddedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalRendererRemovedEventArgs> OnLocalRendererRemovedHandler;
#pragma warning restore 0649

			public void OnLocalRendererRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
			{
				var __h = OnLocalRendererRemovedHandler;
				if (__h != null)
					__h (sender, new LocalRendererRemovedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalRendererSelectedEventArgs> OnLocalRendererSelectedHandler;
#pragma warning restore 0649

			public void OnLocalRendererSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
			{
				var __h = OnLocalRendererSelectedHandler;
				if (__h != null)
					__h (sender, new LocalRendererSelectedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocalRendererStateUpdatedEventArgs> OnLocalRendererStateUpdatedHandler;
#pragma warning restore 0649

			public void OnLocalRendererStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
			{
				var __h = OnLocalRendererStateUpdatedHandler;
				if (__h != null)
					__h (sender, new LocalRendererStateUpdatedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRegisterLocalRendererEventListenerImplementor value)
			{
				return value.OnLocalRendererAddedHandler == null && value.OnLocalRendererRemovedHandler == null && value.OnLocalRendererSelectedHandler == null && value.OnLocalRendererStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalSpeakerEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalSpeakerEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalSpeakerEventListenerInvoker")]
		public partial interface IRegisterLocalSpeakerEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalSpeakerEventListener']/method[@name='OnLocalSpeakerAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
			[Register ("OnLocalSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetOnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalSpeakerAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalSpeakerEventListener']/method[@name='OnLocalSpeakerRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
			[Register ("OnLocalSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetOnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalSpeakerRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalSpeakerEventListener']/method[@name='OnLocalSpeakerSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
			[Register ("OnLocalSpeakerSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetOnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalSpeakerSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalSpeakerEventListener']/method[@name='OnLocalSpeakerStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalSpeakerStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalSpeakerStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalSpeakerEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalSpeakerEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalSpeakerEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalSpeakerEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener"));
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalSpeakerEventListenerImplementor")]
		internal sealed partial class IRegisterLocalSpeakerEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalSpeakerEventListener {

			object sender;

			public IRegisterLocalSpeakerEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalSpeakerEventListenerImplementor", "()V"),
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalWindowShareEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalWindowShareEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalWindowShareEventListenerInvoker")]
		public partial interface IRegisterLocalWindowShareEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalWindowShareEventListener']/method[@name='OnLocalWindowShareAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
			[Register ("OnLocalWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetOnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalWindowShareEventListener']/method[@name='OnLocalWindowShareRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
			[Register ("OnLocalWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetOnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalWindowShareEventListener']/method[@name='OnLocalWindowShareSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
			[Register ("OnLocalWindowShareSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetOnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalWindowShareSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLocalWindowShareEventListener']/method[@name='OnLocalWindowShareStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnLocalWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnLocalWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalWindowShareEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLocalWindowShareEventListenerInvoker : global::Java.Lang.Object, IRegisterLocalWindowShareEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalWindowShareEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener"));
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalWindowShareEventListenerImplementor")]
		internal sealed partial class IRegisterLocalWindowShareEventListenerImplementor : global::Java.Lang.Object, IRegisterLocalWindowShareEventListener {

			object sender;

			public IRegisterLocalWindowShareEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLocalWindowShareEventListenerImplementor", "()V"),
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLogEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLogEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLogEventListenerInvoker")]
		public partial interface IRegisterLogEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterLogEventListener']/method[@name='OnLog' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoLogRecord']]"
			[Register ("OnLog", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord;)V", "GetOnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLogEventListenerInvoker, VidyoClientAndroid")]
			void OnLog (global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLogEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLogEventListenerInvoker : global::Java.Lang.Object, IRegisterLogEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLogEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLogEventListener"));
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLogEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLogEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLogEventListenerImplementor")]
		internal sealed partial class IRegisterLogEventListenerImplementor : global::Java.Lang.Object, IRegisterLogEventListener {

			object sender;

			public IRegisterLogEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterLogEventListenerImplementor", "()V"),
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterNetworkInterfaceEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterNetworkInterfaceEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterNetworkInterfaceEventListenerInvoker")]
		public partial interface IRegisterNetworkInterfaceEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterNetworkInterfaceEventListener']/method[@name='OnNetworkInterfaceAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
			[Register ("OnNetworkInterfaceAdded", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V", "GetOnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid")]
			void OnNetworkInterfaceAdded (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterNetworkInterfaceEventListener']/method[@name='OnNetworkInterfaceRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
			[Register ("OnNetworkInterfaceRemoved", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V", "GetOnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid")]
			void OnNetworkInterfaceRemoved (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterNetworkInterfaceEventListener']/method[@name='OnNetworkInterfaceSelected' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType']]"
			[Register ("OnNetworkInterfaceSelected", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;)V", "GetOnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid")]
			void OnNetworkInterfaceSelected (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterNetworkInterfaceEventListener']/method[@name='OnNetworkInterfaceStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState']]"
			[Register ("OnNetworkInterfaceStateUpdated", "(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;)V", "GetOnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid")]
			void OnNetworkInterfaceStateUpdated (global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0, global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterNetworkInterfaceEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterNetworkInterfaceEventListenerInvoker : global::Java.Lang.Object, IRegisterNetworkInterfaceEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterNetworkInterfaceEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener"));
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterNetworkInterfaceEventListenerImplementor")]
		internal sealed partial class IRegisterNetworkInterfaceEventListenerImplementor : global::Java.Lang.Object, IRegisterNetworkInterfaceEventListener {

			object sender;

			public IRegisterNetworkInterfaceEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterNetworkInterfaceEventListenerImplementor", "()V"),
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteCameraEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteCameraEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteCameraEventListenerInvoker")]
		public partial interface IRegisterRemoteCameraEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteCameraEventListener']/method[@name='OnRemoteCameraAdded' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteCameraEventListener']/method[@name='OnRemoteCameraRemoved' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteCameraEventListener']/method[@name='OnRemoteCameraStateUpdated' and count(parameter)=6 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[6][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnRemoteCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteCameraEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRemoteCameraEventListenerInvoker : global::Java.Lang.Object, IRegisterRemoteCameraEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteCameraEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener"));
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

			static Delegate cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteCameraAdded (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				if (id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteCameraRemoved (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				if (id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p5, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteCameraStateUpdated (p0, p1, p2, p3, p4, p5);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnRemoteCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
			{
				if (id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class RemoteCameraAddedEventArgs : global::System.EventArgs {

			public RemoteCameraAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P4 {
				get { return p4; }
			}
		}

		public partial class RemoteCameraRemovedEventArgs : global::System.EventArgs {

			public RemoteCameraRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P4 {
				get { return p4; }
			}
		}

		public partial class RemoteCameraStateUpdatedEventArgs : global::System.EventArgs {

			public RemoteCameraStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
				this.p5 = p5;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P4 {
				get { return p4; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P5 {
				get { return p5; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterRemoteCameraEventListenerImplementor")]
		internal sealed partial class IRegisterRemoteCameraEventListenerImplementor : global::Java.Lang.Object, IRegisterRemoteCameraEventListener {

			object sender;

			public IRegisterRemoteCameraEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterRemoteCameraEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoteCameraAddedEventArgs> OnRemoteCameraAddedHandler;
#pragma warning restore 0649

			public void OnRemoteCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				var __h = OnRemoteCameraAddedHandler;
				if (__h != null)
					__h (sender, new RemoteCameraAddedEventArgs (p0, p1, p2, p3, p4));
			}
#pragma warning disable 0649
			public EventHandler<RemoteCameraRemovedEventArgs> OnRemoteCameraRemovedHandler;
#pragma warning restore 0649

			public void OnRemoteCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				var __h = OnRemoteCameraRemovedHandler;
				if (__h != null)
					__h (sender, new RemoteCameraRemovedEventArgs (p0, p1, p2, p3, p4));
			}
#pragma warning disable 0649
			public EventHandler<RemoteCameraStateUpdatedEventArgs> OnRemoteCameraStateUpdatedHandler;
#pragma warning restore 0649

			public void OnRemoteCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
			{
				var __h = OnRemoteCameraStateUpdatedHandler;
				if (__h != null)
					__h (sender, new RemoteCameraStateUpdatedEventArgs (p0, p1, p2, p3, p4, p5));
			}

			internal static bool __IsEmpty (IRegisterRemoteCameraEventListenerImplementor value)
			{
				return value.OnRemoteCameraAddedHandler == null && value.OnRemoteCameraRemovedHandler == null && value.OnRemoteCameraStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteMicrophoneEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteMicrophoneEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteMicrophoneEventListenerInvoker")]
		public partial interface IRegisterRemoteMicrophoneEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteMicrophoneEventListener']/method[@name='OnRemoteMicrophoneAdded' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteMicrophoneEventListener']/method[@name='OnRemoteMicrophoneRemoved' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteMicrophoneEventListener']/method[@name='OnRemoteMicrophoneStateUpdated' and count(parameter)=6 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[6][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnRemoteMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteMicrophoneEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteMicrophoneEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRemoteMicrophoneEventListenerInvoker : global::Java.Lang.Object, IRegisterRemoteMicrophoneEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteMicrophoneEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener"));
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

			static Delegate cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteMicrophoneAdded (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				if (id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteMicrophoneRemoved (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				if (id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p5, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteMicrophoneStateUpdated (p0, p1, p2, p3, p4, p5);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnRemoteMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
			{
				if (id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class RemoteMicrophoneAddedEventArgs : global::System.EventArgs {

			public RemoteMicrophoneAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P4 {
				get { return p4; }
			}
		}

		public partial class RemoteMicrophoneRemovedEventArgs : global::System.EventArgs {

			public RemoteMicrophoneRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P4 {
				get { return p4; }
			}
		}

		public partial class RemoteMicrophoneStateUpdatedEventArgs : global::System.EventArgs {

			public RemoteMicrophoneStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
				this.p5 = p5;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P4 {
				get { return p4; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P5 {
				get { return p5; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterRemoteMicrophoneEventListenerImplementor")]
		internal sealed partial class IRegisterRemoteMicrophoneEventListenerImplementor : global::Java.Lang.Object, IRegisterRemoteMicrophoneEventListener {

			object sender;

			public IRegisterRemoteMicrophoneEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterRemoteMicrophoneEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoteMicrophoneAddedEventArgs> OnRemoteMicrophoneAddedHandler;
#pragma warning restore 0649

			public void OnRemoteMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				var __h = OnRemoteMicrophoneAddedHandler;
				if (__h != null)
					__h (sender, new RemoteMicrophoneAddedEventArgs (p0, p1, p2, p3, p4));
			}
#pragma warning disable 0649
			public EventHandler<RemoteMicrophoneRemovedEventArgs> OnRemoteMicrophoneRemovedHandler;
#pragma warning restore 0649

			public void OnRemoteMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				var __h = OnRemoteMicrophoneRemovedHandler;
				if (__h != null)
					__h (sender, new RemoteMicrophoneRemovedEventArgs (p0, p1, p2, p3, p4));
			}
#pragma warning disable 0649
			public EventHandler<RemoteMicrophoneStateUpdatedEventArgs> OnRemoteMicrophoneStateUpdatedHandler;
#pragma warning restore 0649

			public void OnRemoteMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
			{
				var __h = OnRemoteMicrophoneStateUpdatedHandler;
				if (__h != null)
					__h (sender, new RemoteMicrophoneStateUpdatedEventArgs (p0, p1, p2, p3, p4, p5));
			}

			internal static bool __IsEmpty (IRegisterRemoteMicrophoneEventListenerImplementor value)
			{
				return value.OnRemoteMicrophoneAddedHandler == null && value.OnRemoteMicrophoneRemovedHandler == null && value.OnRemoteMicrophoneStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteRendererEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteRendererEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteRendererEventListenerInvoker")]
		public partial interface IRegisterRemoteRendererEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteRendererEventListener']/method[@name='OnRemoteRendererAdded' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteRenderer'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom']]"
			[Register ("OnRemoteRendererAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V", "GetOnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteRendererEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteRendererAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteRendererEventListener']/method[@name='OnRemoteRendererRemoved' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteRenderer'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom']]"
			[Register ("OnRemoteRendererRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V", "GetOnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteRendererEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteRendererRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteRendererEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRemoteRendererEventListenerInvoker : global::Java.Lang.Object, IRegisterRemoteRendererEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteRendererEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterRemoteRendererEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterRemoteRendererEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterRemoteRendererEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterRemoteRendererEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
#pragma warning disable 0169
			static Delegate GetOnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler ()
			{
				if (cb_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == null)
					cb_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_);
				return cb_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
			}

			static void n_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteRendererAdded (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
			public unsafe void OnRemoteRendererAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				if (id_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == IntPtr.Zero)
					id_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNIEnv.GetMethodID (class_ref, "OnRemoteRendererAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args);
			}

			static Delegate cb_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
#pragma warning disable 0169
			static Delegate GetOnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler ()
			{
				if (cb_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == null)
					cb_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_);
				return cb_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
			}

			static void n_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteRendererRemoved (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
			public unsafe void OnRemoteRendererRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				if (id_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == IntPtr.Zero)
					id_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNIEnv.GetMethodID (class_ref, "OnRemoteRendererRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args);
			}

		}

		public partial class RemoteRendererAddedEventArgs : global::System.EventArgs {

			public RemoteRendererAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}
		}

		public partial class RemoteRendererRemovedEventArgs : global::System.EventArgs {

			public RemoteRendererRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterRemoteRendererEventListenerImplementor")]
		internal sealed partial class IRegisterRemoteRendererEventListenerImplementor : global::Java.Lang.Object, IRegisterRemoteRendererEventListener {

			object sender;

			public IRegisterRemoteRendererEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterRemoteRendererEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoteRendererAddedEventArgs> OnRemoteRendererAddedHandler;
#pragma warning restore 0649

			public void OnRemoteRendererAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				var __h = OnRemoteRendererAddedHandler;
				if (__h != null)
					__h (sender, new RemoteRendererAddedEventArgs (p0, p1, p2, p3));
			}
#pragma warning disable 0649
			public EventHandler<RemoteRendererRemovedEventArgs> OnRemoteRendererRemovedHandler;
#pragma warning restore 0649

			public void OnRemoteRendererRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				var __h = OnRemoteRendererRemovedHandler;
				if (__h != null)
					__h (sender, new RemoteRendererRemovedEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IRegisterRemoteRendererEventListenerImplementor value)
			{
				return value.OnRemoteRendererAddedHandler == null && value.OnRemoteRendererRemovedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteSpeakerEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteSpeakerEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteSpeakerEventListenerInvoker")]
		public partial interface IRegisterRemoteSpeakerEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteSpeakerEventListener']/method[@name='OnRemoteSpeakerAdded' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom']]"
			[Register ("OnRemoteSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V", "GetOnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteSpeakerEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteSpeakerAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteSpeakerEventListener']/method[@name='OnRemoteSpeakerRemoved' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom']]"
			[Register ("OnRemoteSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V", "GetOnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteSpeakerEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteSpeakerRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteSpeakerEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRemoteSpeakerEventListenerInvoker : global::Java.Lang.Object, IRegisterRemoteSpeakerEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteSpeakerEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterRemoteSpeakerEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterRemoteSpeakerEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterRemoteSpeakerEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterRemoteSpeakerEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
#pragma warning disable 0169
			static Delegate GetOnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler ()
			{
				if (cb_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == null)
					cb_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_);
				return cb_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
			}

			static void n_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteSpeakerAdded (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
			public unsafe void OnRemoteSpeakerAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				if (id_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == IntPtr.Zero)
					id_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNIEnv.GetMethodID (class_ref, "OnRemoteSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args);
			}

			static Delegate cb_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
#pragma warning disable 0169
			static Delegate GetOnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler ()
			{
				if (cb_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == null)
					cb_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_);
				return cb_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
			}

			static void n_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteSpeakerRemoved (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
			public unsafe void OnRemoteSpeakerRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				if (id_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == IntPtr.Zero)
					id_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNIEnv.GetMethodID (class_ref, "OnRemoteSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args);
			}

		}

		public partial class RemoteSpeakerAddedEventArgs : global::System.EventArgs {

			public RemoteSpeakerAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}
		}

		public partial class RemoteSpeakerRemovedEventArgs : global::System.EventArgs {

			public RemoteSpeakerRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterRemoteSpeakerEventListenerImplementor")]
		internal sealed partial class IRegisterRemoteSpeakerEventListenerImplementor : global::Java.Lang.Object, IRegisterRemoteSpeakerEventListener {

			object sender;

			public IRegisterRemoteSpeakerEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterRemoteSpeakerEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoteSpeakerAddedEventArgs> OnRemoteSpeakerAddedHandler;
#pragma warning restore 0649

			public void OnRemoteSpeakerAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				var __h = OnRemoteSpeakerAddedHandler;
				if (__h != null)
					__h (sender, new RemoteSpeakerAddedEventArgs (p0, p1, p2, p3));
			}
#pragma warning disable 0649
			public EventHandler<RemoteSpeakerRemovedEventArgs> OnRemoteSpeakerRemovedHandler;
#pragma warning restore 0649

			public void OnRemoteSpeakerRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
			{
				var __h = OnRemoteSpeakerRemovedHandler;
				if (__h != null)
					__h (sender, new RemoteSpeakerRemovedEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IRegisterRemoteSpeakerEventListenerImplementor value)
			{
				return value.OnRemoteSpeakerAddedHandler == null && value.OnRemoteSpeakerRemovedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteWindowShareEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteWindowShareEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteWindowShareEventListenerInvoker")]
		public partial interface IRegisterRemoteWindowShareEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteWindowShareEventListener']/method[@name='OnRemoteWindowShareAdded' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteWindowShareEventListener']/method[@name='OnRemoteWindowShareRemoved' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnRemoteWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoEndpoint.IRegisterRemoteWindowShareEventListener']/method[@name='OnRemoteWindowShareStateUpdated' and count(parameter)=6 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[6][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
			[Register ("OnRemoteWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteWindowShareEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoteWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteWindowShareEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRemoteWindowShareEventListenerInvoker : global::Java.Lang.Object, IRegisterRemoteWindowShareEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteWindowShareEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener"));
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

			static Delegate cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteWindowShareAdded (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				if (id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteWindowShareRemoved (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnRemoteWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				if (id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
			static Delegate GetOnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
			{
				if (cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
					cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
				return cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			}

			static void n_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p5, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoteWindowShareStateUpdated (p0, p1, p2, p3, p4, p5);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
			public unsafe void OnRemoteWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
			{
				if (id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
					id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
			}

		}

		public partial class RemoteWindowShareAddedEventArgs : global::System.EventArgs {

			public RemoteWindowShareAddedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P4 {
				get { return p4; }
			}
		}

		public partial class RemoteWindowShareRemovedEventArgs : global::System.EventArgs {

			public RemoteWindowShareRemovedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P4 {
				get { return p4; }
			}
		}

		public partial class RemoteWindowShareStateUpdatedEventArgs : global::System.EventArgs {

			public RemoteWindowShareStateUpdatedEventArgs (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
				this.p5 = p5;
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0;
			public global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser P1 {
				get { return p1; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P2 {
				get { return p2; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P3 {
				get { return p3; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P4 {
				get { return p4; }
			}

			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5;
			public global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState P5 {
				get { return p5; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterRemoteWindowShareEventListenerImplementor")]
		internal sealed partial class IRegisterRemoteWindowShareEventListenerImplementor : global::Java.Lang.Object, IRegisterRemoteWindowShareEventListener {

			object sender;

			public IRegisterRemoteWindowShareEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoEndpoint_IRegisterRemoteWindowShareEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoteWindowShareAddedEventArgs> OnRemoteWindowShareAddedHandler;
#pragma warning restore 0649

			public void OnRemoteWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				var __h = OnRemoteWindowShareAddedHandler;
				if (__h != null)
					__h (sender, new RemoteWindowShareAddedEventArgs (p0, p1, p2, p3, p4));
			}
#pragma warning disable 0649
			public EventHandler<RemoteWindowShareRemovedEventArgs> OnRemoteWindowShareRemovedHandler;
#pragma warning restore 0649

			public void OnRemoteWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
			{
				var __h = OnRemoteWindowShareRemovedHandler;
				if (__h != null)
					__h (sender, new RemoteWindowShareRemovedEventArgs (p0, p1, p2, p3, p4));
			}
#pragma warning disable 0649
			public EventHandler<RemoteWindowShareStateUpdatedEventArgs> OnRemoteWindowShareStateUpdatedHandler;
#pragma warning restore 0649

			public void OnRemoteWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
			{
				var __h = OnRemoteWindowShareStateUpdatedHandler;
				if (__h != null)
					__h (sender, new RemoteWindowShareStateUpdatedEventArgs (p0, p1, p2, p3, p4, p5));
			}

			internal static bool __IsEmpty (IRegisterRemoteWindowShareEventListenerImplementor value)
			{
				return value.OnRemoteWindowShareAddedHandler == null && value.OnRemoteWindowShareRemovedHandler == null && value.OnRemoteWindowShareStateUpdatedHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointLogCompressionResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoEndpointLogCompressionResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_MiscError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointLogCompressionResult']/field[@name='VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_MiscError']"
			[Register ("VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_MiscError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult VIDYOENDPOINTLOGCOMPRESSIONRESULTMiscError {
				get {
					if (VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_MiscError_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_MiscError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_MiscError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_MiscError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_Success_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointLogCompressionResult']/field[@name='VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_Success']"
			[Register ("VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_Success")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult VIDYOENDPOINTLOGCOMPRESSIONRESULTSuccess {
				get {
					if (VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_Success_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_Success_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_Success", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTLOGCOMPRESSIONRESULT_Success_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoEndpointLogCompressionResult); }
			}

			internal VidyoEndpointLogCompressionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointLogCompressionResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointLogCompressionResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMediaState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMediaState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoEndpointMediaState : global::Java.Lang.Enum {


			static IntPtr VIDYO_ENDPOINTMEDIASTATE_GreenRoom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMediaState']/field[@name='VIDYO_ENDPOINTMEDIASTATE_GreenRoom']"
			[Register ("VIDYO_ENDPOINTMEDIASTATE_GreenRoom")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState VIDYOENDPOINTMEDIASTATEGreenRoom {
				get {
					if (VIDYO_ENDPOINTMEDIASTATE_GreenRoom_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTMEDIASTATE_GreenRoom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTMEDIASTATE_GreenRoom", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMediaState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTMEDIASTATE_GreenRoom_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ENDPOINTMEDIASTATE_Idle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMediaState']/field[@name='VIDYO_ENDPOINTMEDIASTATE_Idle']"
			[Register ("VIDYO_ENDPOINTMEDIASTATE_Idle")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState VIDYOENDPOINTMEDIASTATEIdle {
				get {
					if (VIDYO_ENDPOINTMEDIASTATE_Idle_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTMEDIASTATE_Idle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTMEDIASTATE_Idle", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMediaState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTMEDIASTATE_Idle_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ENDPOINTMEDIASTATE_Live_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMediaState']/field[@name='VIDYO_ENDPOINTMEDIASTATE_Live']"
			[Register ("VIDYO_ENDPOINTMEDIASTATE_Live")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState VIDYOENDPOINTMEDIASTATELive {
				get {
					if (VIDYO_ENDPOINTMEDIASTATE_Live_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTMEDIASTATE_Live_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTMEDIASTATE_Live", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMediaState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTMEDIASTATE_Live_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMediaState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoEndpointMediaState); }
			}

			internal VidyoEndpointMediaState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMediaState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMediaState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMediaState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMediaState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMediaState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMediaState;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMediaState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMode']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode", DoNotGenerateAcw=true)]
		public sealed partial class VidyoEndpointMode : global::Java.Lang.Enum {


			static IntPtr VIDYO_ENDPOINTMODE_Background_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMode']/field[@name='VIDYO_ENDPOINTMODE_Background']"
			[Register ("VIDYO_ENDPOINTMODE_Background")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode VIDYOENDPOINTMODEBackground {
				get {
					if (VIDYO_ENDPOINTMODE_Background_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTMODE_Background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTMODE_Background", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTMODE_Background_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ENDPOINTMODE_Default_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMode']/field[@name='VIDYO_ENDPOINTMODE_Default']"
			[Register ("VIDYO_ENDPOINTMODE_Default")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode VIDYOENDPOINTMODEDefault {
				get {
					if (VIDYO_ENDPOINTMODE_Default_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTMODE_Default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTMODE_Default", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTMODE_Default_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ENDPOINTMODE_Foreground_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMode']/field[@name='VIDYO_ENDPOINTMODE_Foreground']"
			[Register ("VIDYO_ENDPOINTMODE_Foreground")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode VIDYOENDPOINTMODEForeground {
				get {
					if (VIDYO_ENDPOINTMODE_Foreground_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTMODE_Foreground_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTMODE_Foreground", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTMODE_Foreground_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoEndpointMode); }
			}

			internal VidyoEndpointMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointTone']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone", DoNotGenerateAcw=true)]
		public sealed partial class VidyoEndpointTone : global::Java.Lang.Enum {


			static IntPtr VIDYO_ENDPOINTTONE_Join_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointTone']/field[@name='VIDYO_ENDPOINTTONE_Join']"
			[Register ("VIDYO_ENDPOINTTONE_Join")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone VIDYOENDPOINTTONEJoin {
				get {
					if (VIDYO_ENDPOINTTONE_Join_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTTONE_Join_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTTONE_Join", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTTONE_Join_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ENDPOINTTONE_Leave_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointTone']/field[@name='VIDYO_ENDPOINTTONE_Leave']"
			[Register ("VIDYO_ENDPOINTTONE_Leave")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone VIDYOENDPOINTTONELeave {
				get {
					if (VIDYO_ENDPOINTTONE_Leave_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTTONE_Leave_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTTONE_Leave", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTTONE_Leave_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ENDPOINTTONE_Max_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointTone']/field[@name='VIDYO_ENDPOINTTONE_Max']"
			[Register ("VIDYO_ENDPOINTTONE_Max")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone VIDYOENDPOINTTONEMax {
				get {
					if (VIDYO_ENDPOINTTONE_Max_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTTONE_Max_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTTONE_Max", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTTONE_Max_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ENDPOINTTONE_MsgRecv_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointTone']/field[@name='VIDYO_ENDPOINTTONE_MsgRecv']"
			[Register ("VIDYO_ENDPOINTTONE_MsgRecv")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone VIDYOENDPOINTTONEMsgRecv {
				get {
					if (VIDYO_ENDPOINTTONE_MsgRecv_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTTONE_MsgRecv_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTTONE_MsgRecv", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTTONE_MsgRecv_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ENDPOINTTONE_MsgSend_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointTone']/field[@name='VIDYO_ENDPOINTTONE_MsgSend']"
			[Register ("VIDYO_ENDPOINTTONE_MsgSend")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone VIDYOENDPOINTTONEMsgSend {
				get {
					if (VIDYO_ENDPOINTTONE_MsgSend_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTTONE_MsgSend_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTTONE_MsgSend", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTTONE_MsgSend_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ENDPOINTTONE_Ring_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointTone']/field[@name='VIDYO_ENDPOINTTONE_Ring']"
			[Register ("VIDYO_ENDPOINTTONE_Ring")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone VIDYOENDPOINTTONERing {
				get {
					if (VIDYO_ENDPOINTTONE_Ring_jfieldId == IntPtr.Zero)
						VIDYO_ENDPOINTTONE_Ring_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ENDPOINTTONE_Ring", "Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ENDPOINTTONE_Ring_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoEndpointTone); }
			}

			internal VidyoEndpointTone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointTone']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint.VidyoEndpointTone']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointTone;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointTone));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoEndpoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoEndpoint); }
		}

		protected VidyoEndpoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/constructor[@name='VidyoEndpoint' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoEndpoint (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoEndpoint)) {
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

		static IntPtr id_ctor_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/constructor[@name='VidyoEndpoint' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe VidyoEndpoint (global::Java.Lang.Object p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle p1, int p2, string p3, string p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				if (((object) this).GetType () != typeof (VidyoEndpoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_GetApplicationTag;
#pragma warning disable 0169
		static Delegate GetGetApplicationTagHandler ()
		{
			if (cb_GetApplicationTag == null)
				cb_GetApplicationTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationTag);
			return cb_GetApplicationTag;
		}

		static IntPtr n_GetApplicationTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationTag);
		}
#pragma warning restore 0169

		static IntPtr id_GetApplicationTag;
		public virtual unsafe string ApplicationTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='GetApplicationTag' and count(parameter)=0]"
			[Register ("GetApplicationTag", "()Ljava/lang/String;", "GetGetApplicationTagHandler")]
			get {
				if (id_GetApplicationTag == IntPtr.Zero)
					id_GetApplicationTag = JNIEnv.GetMethodID (class_ref, "GetApplicationTag", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetApplicationTag), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetApplicationTag", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='GetId' and count(parameter)=0]"
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

		static Delegate cb_IsDebugEnabled;
#pragma warning disable 0169
		static Delegate GetIsDebugEnabledHandler ()
		{
			if (cb_IsDebugEnabled == null)
				cb_IsDebugEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDebugEnabled);
			return cb_IsDebugEnabled;
		}

		static bool n_IsDebugEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDebugEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_IsDebugEnabled;
		public virtual unsafe bool IsDebugEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='IsDebugEnabled' and count(parameter)=0]"
			[Register ("IsDebugEnabled", "()Z", "GetIsDebugEnabledHandler")]
			get {
				if (id_IsDebugEnabled == IntPtr.Zero)
					id_IsDebugEnabled = JNIEnv.GetMethodID (class_ref, "IsDebugEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsDebugEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsDebugEnabled", "()Z"));
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_GetStats;
#pragma warning disable 0169
		static Delegate GetGetStatsHandler ()
		{
			if (cb_GetStats == null)
				cb_GetStats = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStats);
			return cb_GetStats;
		}

		static IntPtr n_GetStats (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Stats);
		}
#pragma warning restore 0169

		static IntPtr id_GetStats;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Stats.VidyoEndpointStats Stats {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='GetStats' and count(parameter)=0]"
			[Register ("GetStats", "()Lcom/vidyo/VidyoClient/Stats/VidyoEndpointStats;", "GetGetStatsHandler")]
			get {
				if (id_GetStats == IntPtr.Zero)
					id_GetStats = JNIEnv.GetMethodID (class_ref, "GetStats", "()Lcom/vidyo/VidyoClient/Stats/VidyoEndpointStats;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Stats.VidyoEndpointStats> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetStats), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Stats.VidyoEndpointStats> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetStats", "()Lcom/vidyo/VidyoClient/Stats/VidyoEndpointStats;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StatsJson);
		}
#pragma warning restore 0169

		static IntPtr id_GetStatsJson;
		public virtual unsafe string StatsJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='GetStatsJson' and count(parameter)=0]"
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

		static Delegate cb_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_I;
#pragma warning disable 0169
		static Delegate GetAssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_IHandler ()
		{
			if (cb_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_I == null)
				cb_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_I);
			return cb_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_I;
		}

		static bool n_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AssignViewToCompositeRenderer (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='AssignViewToCompositeRenderer' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle'] and parameter[3][@type='int']]"
		[Register ("AssignViewToCompositeRenderer", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;I)Z", "GetAssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_IHandler")]
		public virtual unsafe bool AssignViewToCompositeRenderer (global::Java.Lang.Object p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle p1, int p2)
		{
			if (id_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_I == IntPtr.Zero)
				id_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_I = JNIEnv.GetMethodID (class_ref, "AssignViewToCompositeRenderer", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;I)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AssignViewToCompositeRenderer_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_VidyoLocalRendererViewStyle_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AssignViewToCompositeRenderer", "(Ljava/lang/Object;Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;I)Z"), __args);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AssignViewToLocalCamera (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AssignViewToLocalCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='AssignViewToLocalCamera' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AssignViewToRemoteCamera (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AssignViewToRemoteCamera_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='AssignViewToRemoteCamera' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AssignViewToRemoteWindowShare (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AssignViewToRemoteWindowShare_Ljava_lang_Object_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='AssignViewToRemoteWindowShare' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
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

		static Delegate cb_CompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_;
#pragma warning disable 0169
		static Delegate GetCompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_Handler ()
		{
			if (cb_CompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_ == null)
				cb_CompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_);
			return cb_CompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_;
		}

		static bool n_CompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.ICompressLogs p1 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.ICompressLogs)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.ICompressLogs> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CompressLogs (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='CompressLogs' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.ICompressLogs']]"
		[Register ("CompressLogs", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$ICompressLogs;)Z", "GetCompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_Handler")]
		public virtual unsafe bool CompressLogs (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.ICompressLogs p1)
		{
			if (id_CompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_ == IntPtr.Zero)
				id_CompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_ = JNIEnv.GetMethodID (class_ref, "CompressLogs", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$ICompressLogs;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CompressLogs_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ICompressLogs_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CompressLogs", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$ICompressLogs;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_CreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_II;
#pragma warning disable 0169
		static Delegate GetCreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IIHandler ()
		{
			if (cb_CreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_II == null)
				cb_CreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_CreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_II);
			return cb_CreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_II;
		}

		static bool n_CreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CreateRenderer (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='CreateRenderer' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("CreateRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;II)Z", "GetCreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IIHandler")]
		public virtual unsafe bool CreateRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0, int p1, int p2)
		{
			if (id_CreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_II == IntPtr.Zero)
				id_CreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_II = JNIEnv.GetMethodID (class_ref, "CreateRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;II)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CreateRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;II)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_CreateRendererFromViewId_Ljava_lang_Object_IIII;
#pragma warning disable 0169
		static Delegate GetCreateRendererFromViewId_Ljava_lang_Object_IIIIHandler ()
		{
			if (cb_CreateRendererFromViewId_Ljava_lang_Object_IIII == null)
				cb_CreateRendererFromViewId_Ljava_lang_Object_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, bool>) n_CreateRendererFromViewId_Ljava_lang_Object_IIII);
			return cb_CreateRendererFromViewId_Ljava_lang_Object_IIII;
		}

		static bool n_CreateRendererFromViewId_Ljava_lang_Object_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CreateRendererFromViewId (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CreateRendererFromViewId_Ljava_lang_Object_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='CreateRendererFromViewId' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("CreateRendererFromViewId", "(Ljava/lang/Object;IIII)Z", "GetCreateRendererFromViewId_Ljava_lang_Object_IIIIHandler")]
		public virtual unsafe bool CreateRendererFromViewId (global::Java.Lang.Object p0, int p1, int p2, int p3, int p4)
		{
			if (id_CreateRendererFromViewId_Ljava_lang_Object_IIII == IntPtr.Zero)
				id_CreateRendererFromViewId_Ljava_lang_Object_IIII = JNIEnv.GetMethodID (class_ref, "CreateRendererFromViewId", "(Ljava/lang/Object;IIII)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CreateRendererFromViewId_Ljava_lang_Object_IIII, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateRendererFromViewId", "(Ljava/lang/Object;IIII)Z"), __args);
				return __ret;
			} finally {
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CycleCamera ();
		}
#pragma warning restore 0169

		static IntPtr id_CycleCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='CycleCamera' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CycleMicrophone ();
		}
#pragma warning restore 0169

		static IntPtr id_CycleMicrophone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='CycleMicrophone' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CycleSpeaker ();
		}
#pragma warning restore 0169

		static IntPtr id_CycleSpeaker;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='CycleSpeaker' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		static IntPtr id_Disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='Disable' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableDebug ();
		}
#pragma warning restore 0169

		static IntPtr id_DisableDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='DisableDebug' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EnableDebug (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_EnableDebug_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='EnableDebug' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_EnableFileLogger_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnableFileLogger_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_EnableFileLogger_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_EnableFileLogger_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_EnableFileLogger_Ljava_lang_String_Ljava_lang_String_);
			return cb_EnableFileLogger_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_EnableFileLogger_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EnableFileLogger (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_EnableFileLogger_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='EnableFileLogger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("EnableFileLogger", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetEnableFileLogger_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool EnableFileLogger (string p0, string p1)
		{
			if (id_EnableFileLogger_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_EnableFileLogger_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "EnableFileLogger", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_EnableFileLogger_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "EnableFileLogger", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_GenerateLicenseKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateLicenseKey_Ljava_lang_String_Handler ()
		{
			if (cb_GenerateLicenseKey_Ljava_lang_String_ == null)
				cb_GenerateLicenseKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GenerateLicenseKey_Ljava_lang_String_);
			return cb_GenerateLicenseKey_Ljava_lang_String_;
		}

		static bool n_GenerateLicenseKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GenerateLicenseKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GenerateLicenseKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='GenerateLicenseKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("GenerateLicenseKey", "(Ljava/lang/String;)Z", "GetGenerateLicenseKey_Ljava_lang_String_Handler")]
		public virtual unsafe bool GenerateLicenseKey (string p0)
		{
			if (id_GenerateLicenseKey_Ljava_lang_String_ == IntPtr.Zero)
				id_GenerateLicenseKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GenerateLicenseKey", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GenerateLicenseKey_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GenerateLicenseKey", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HideView (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_HideView_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='HideView' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_LocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
#pragma warning disable 0169
		static Delegate GetLocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler ()
		{
			if (cb_LocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == null)
				cb_LocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_);
			return cb_LocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		}

		static void n_LocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalCameraSelectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalCameraSelectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
		[Register ("LocalCameraSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetLocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler")]
		public virtual unsafe void LocalCameraSelectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
		{
			if (id_LocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == IntPtr.Zero)
				id_LocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNIEnv.GetMethodID (class_ref, "LocalCameraSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalCameraSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalCameraSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
#pragma warning disable 0169
		static Delegate GetLocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler ()
		{
			if (cb_LocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == null)
				cb_LocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_);
			return cb_LocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		}

		static void n_LocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalCameraUnselectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalCameraUnselectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
		[Register ("LocalCameraUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetLocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler")]
		public virtual unsafe void LocalCameraUnselectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
		{
			if (id_LocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == IntPtr.Zero)
				id_LocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNIEnv.GetMethodID (class_ref, "LocalCameraUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalCameraUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalCameraUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Z;
#pragma warning disable 0169
		static Delegate GetLocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZHandler ()
		{
			if (cb_LocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Z == null)
				cb_LocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_LocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Z);
			return cb_LocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Z;
		}

		static void n_LocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalMicrophoneSelectAdvanced (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_LocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalMicrophoneSelectAdvanced' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone'] and parameter[2][@type='boolean']]"
		[Register ("LocalMicrophoneSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Z)V", "GetLocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZHandler")]
		public virtual unsafe void LocalMicrophoneSelectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0, bool p1)
		{
			if (id_LocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Z == IntPtr.Zero)
				id_LocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Z = JNIEnv.GetMethodID (class_ref, "LocalMicrophoneSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalMicrophoneSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalMicrophoneSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
#pragma warning disable 0169
		static Delegate GetLocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler ()
		{
			if (cb_LocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == null)
				cb_LocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_);
			return cb_LocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		}

		static void n_LocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalMicrophoneUnselectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalMicrophoneUnselectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
		[Register ("LocalMicrophoneUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetLocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler")]
		public virtual unsafe void LocalMicrophoneUnselectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
		{
			if (id_LocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == IntPtr.Zero)
				id_LocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNIEnv.GetMethodID (class_ref, "LocalMicrophoneUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalMicrophoneUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalMicrophoneUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
#pragma warning disable 0169
		static Delegate GetLocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler ()
		{
			if (cb_LocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == null)
				cb_LocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_);
			return cb_LocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		}

		static void n_LocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalMonitorSelectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalMonitorSelectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
		[Register ("LocalMonitorSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetLocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler")]
		public virtual unsafe void LocalMonitorSelectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
		{
			if (id_LocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == IntPtr.Zero)
				id_LocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNIEnv.GetMethodID (class_ref, "LocalMonitorSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalMonitorSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalMonitorSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
#pragma warning disable 0169
		static Delegate GetLocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler ()
		{
			if (cb_LocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == null)
				cb_LocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_);
			return cb_LocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		}

		static void n_LocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalMonitorUnselectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalMonitorUnselectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
		[Register ("LocalMonitorUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetLocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler")]
		public virtual unsafe void LocalMonitorUnselectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
		{
			if (id_LocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == IntPtr.Zero)
				id_LocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNIEnv.GetMethodID (class_ref, "LocalMonitorUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalMonitorUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalMonitorUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
		static Delegate GetLocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
		{
			if (cb_LocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
				cb_LocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
			return cb_LocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		}

		static void n_LocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalRendererSelectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalRendererSelectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
		[Register ("LocalRendererSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V", "GetLocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler")]
		public virtual unsafe void LocalRendererSelectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
		{
			if (id_LocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
				id_LocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "LocalRendererSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalRendererSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalRendererSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
		static Delegate GetLocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
		{
			if (cb_LocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
				cb_LocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
			return cb_LocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		}

		static void n_LocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalRendererUnselectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalRendererUnselectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
		[Register ("LocalRendererUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V", "GetLocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler")]
		public virtual unsafe void LocalRendererUnselectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
		{
			if (id_LocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
				id_LocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "LocalRendererUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalRendererUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalRendererUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
		static Delegate GetLocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
		{
			if (cb_LocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
				cb_LocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
			return cb_LocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		}

		static void n_LocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalSpeakerSelectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalSpeakerSelectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
		[Register ("LocalSpeakerSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetLocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler")]
		public virtual unsafe void LocalSpeakerSelectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
		{
			if (id_LocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
				id_LocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "LocalSpeakerSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalSpeakerSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalSpeakerSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
		static Delegate GetLocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
		{
			if (cb_LocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
				cb_LocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
			return cb_LocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		}

		static void n_LocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalSpeakerUnselectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalSpeakerUnselectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
		[Register ("LocalSpeakerUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetLocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler")]
		public virtual unsafe void LocalSpeakerUnselectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
		{
			if (id_LocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
				id_LocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "LocalSpeakerUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalSpeakerUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalSpeakerUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
		static Delegate GetLocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
		{
			if (cb_LocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
				cb_LocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
			return cb_LocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		}

		static void n_LocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalWindowShareSelectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalWindowShareSelectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
		[Register ("LocalWindowShareSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetLocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler")]
		public virtual unsafe void LocalWindowShareSelectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
		{
			if (id_LocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
				id_LocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "LocalWindowShareSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalWindowShareSelectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalWindowShareSelectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_LocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
		static Delegate GetLocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
		{
			if (cb_LocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
				cb_LocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
			return cb_LocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		}

		static void n_LocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalWindowShareUnselectAdvanced (p0);
		}
#pragma warning restore 0169

		static IntPtr id_LocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='LocalWindowShareUnselectAdvanced' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
		[Register ("LocalWindowShareUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetLocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler")]
		public virtual unsafe void LocalWindowShareUnselectAdvanced (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
		{
			if (id_LocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
				id_LocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "LocalWindowShareUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_LocalWindowShareUnselectAdvanced_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalWindowShareUnselectAdvanced", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V"), __args);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalCameraAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalCameraAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalCameraRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalCameraRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalCameraSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalCameraSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalCameraStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalCameraStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMicrophoneAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalMicrophoneAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMicrophoneRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalMicrophoneRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMicrophoneSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalMicrophoneSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMicrophoneStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalMicrophoneStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMonitorAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalMonitorAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMonitorRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalMonitorRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMonitorSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalMonitorSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalMonitorStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalMonitorStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
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

		static Delegate cb_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
		static Delegate GetOnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
		{
			if (cb_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
				cb_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
			return cb_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		}

		static void n_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalRendererAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalRendererAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
		[Register ("OnLocalRendererAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V", "GetOnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler")]
		public virtual unsafe void OnLocalRendererAdded (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
		{
			if (id_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
				id_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "OnLocalRendererAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalRendererAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
		static Delegate GetOnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
		{
			if (cb_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
				cb_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
			return cb_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		}

		static void n_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalRendererRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalRendererRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
		[Register ("OnLocalRendererRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V", "GetOnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler")]
		public virtual unsafe void OnLocalRendererRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
		{
			if (id_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
				id_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "OnLocalRendererRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalRendererRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
		static Delegate GetOnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
		{
			if (cb_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
				cb_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
			return cb_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		}

		static void n_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalRendererSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalRendererSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
		[Register ("OnLocalRendererSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V", "GetOnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler")]
		public virtual unsafe void OnLocalRendererSelected (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
		{
			if (id_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
				id_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "OnLocalRendererSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalRendererSelected", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalRendererStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalRendererStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnLocalRendererStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnLocalRendererStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
		{
			if (id_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnLocalRendererStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLocalRendererStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalSpeakerAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalSpeakerAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalSpeakerRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalSpeakerRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalSpeakerSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalSpeakerSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalSpeakerStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalSpeakerStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalWindowShareAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalWindowShareAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalWindowShareRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalWindowShareRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalWindowShareSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalWindowShareSelected' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalWindowShareStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLocalWindowShareStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLog (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLog' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoLogRecord']]"
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

		static Delegate cb_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_;
#pragma warning disable 0169
		static Delegate GetOnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_Handler ()
		{
			if (cb_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_ == null)
				cb_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_);
			return cb_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_;
		}

		static void n_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLogCompressionComplete (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnLogCompressionComplete' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult']]"
		[Register ("OnLogCompressionComplete", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;)V", "GetOnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_Handler")]
		public virtual unsafe void OnLogCompressionComplete (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointLogCompressionResult p1)
		{
			if (id_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_ == IntPtr.Zero)
				id_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_ = JNIEnv.GetMethodID (class_ref, "OnLogCompressionComplete", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLogCompressionComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointLogCompressionResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLogCompressionComplete", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointLogCompressionResult;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInterfaceAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnNetworkInterfaceAdded' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInterfaceRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnNetworkInterfaceRemoved' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInterfaceSelected (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnNetworkInterfaceSelected' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInterfaceStateUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnNetworkInterfaceStateUpdated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState']]"
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

		static Delegate cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteCameraAdded (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteCameraAdded' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteCameraAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
		{
			if (id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteCameraAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteCameraRemoved (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteCameraRemoved' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteCameraRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
		{
			if (id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteCameraRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteCameraStateUpdated (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteCameraStateUpdated' and count(parameter)=6 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[6][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnRemoteCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnRemoteCameraStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
		{
			if (id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteCameraStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteMicrophoneAdded (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteMicrophoneAdded' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteMicrophoneAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
		{
			if (id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteMicrophoneAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteMicrophoneRemoved (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteMicrophoneRemoved' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteMicrophoneRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
		{
			if (id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteMicrophoneRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteMicrophoneStateUpdated (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteMicrophoneStateUpdated' and count(parameter)=6 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[6][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnRemoteMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnRemoteMicrophoneStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
		{
			if (id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteMicrophoneStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
#pragma warning disable 0169
		static Delegate GetOnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler ()
		{
			if (cb_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == null)
				cb_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_);
			return cb_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
		}

		static void n_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteRendererAdded (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteRendererAdded' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteRenderer'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom']]"
		[Register ("OnRemoteRendererAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V", "GetOnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler")]
		public virtual unsafe void OnRemoteRendererAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
		{
			if (id_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == IntPtr.Zero)
				id_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNIEnv.GetMethodID (class_ref, "OnRemoteRendererAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteRendererAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
#pragma warning disable 0169
		static Delegate GetOnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler ()
		{
			if (cb_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == null)
				cb_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_);
			return cb_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
		}

		static void n_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteRendererRemoved (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteRendererRemoved' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteRenderer'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom']]"
		[Register ("OnRemoteRendererRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V", "GetOnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler")]
		public virtual unsafe void OnRemoteRendererRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
		{
			if (id_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == IntPtr.Zero)
				id_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNIEnv.GetMethodID (class_ref, "OnRemoteRendererRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteRendererRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
#pragma warning disable 0169
		static Delegate GetOnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler ()
		{
			if (cb_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == null)
				cb_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_);
			return cb_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
		}

		static void n_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteSpeakerAdded (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteSpeakerAdded' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom']]"
		[Register ("OnRemoteSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V", "GetOnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler")]
		public virtual unsafe void OnRemoteSpeakerAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
		{
			if (id_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == IntPtr.Zero)
				id_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNIEnv.GetMethodID (class_ref, "OnRemoteSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteSpeakerAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
#pragma warning disable 0169
		static Delegate GetOnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler ()
		{
			if (cb_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == null)
				cb_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_);
			return cb_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
		}

		static void n_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteSpeakerRemoved (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteSpeakerRemoved' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom']]"
		[Register ("OnRemoteSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V", "GetOnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler")]
		public virtual unsafe void OnRemoteSpeakerRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3)
		{
			if (id_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == IntPtr.Zero)
				id_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNIEnv.GetMethodID (class_ref, "OnRemoteSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteSpeakerRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteWindowShareAdded (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteWindowShareAdded' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteWindowShareAdded (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
		{
			if (id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteWindowShareAdded", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteWindowShareRemoved (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteWindowShareRemoved' and count(parameter)=5 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnRemoteWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnRemoteWindowShareRemoved (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
		{
			if (id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteWindowShareRemoved", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetOnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static void n_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteWindowShareStateUpdated (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='OnRemoteWindowShareStateUpdated' and count(parameter)=6 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[6][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("OnRemoteWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V", "GetOnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe void OnRemoteWindowShareStateUpdated (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p4, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
		{
			if (id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "OnRemoteWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoteWindowShareStateUpdated", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_Handler ()
		{
			if (cb_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_ == null)
				cb_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_);
			return cb_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_;
		}

		static bool n_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalCameraEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterLocalCameraEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener']]"
		[Register ("RegisterLocalCameraEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalCameraEventListener;)Z", "GetRegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_Handler")]
		public virtual unsafe bool RegisterLocalCameraEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalCameraEventListener p0)
		{
			if (id_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_ == IntPtr.Zero)
				id_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalCameraEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalCameraEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalCameraEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalCameraEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalCameraEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_Handler ()
		{
			if (cb_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_ == null)
				cb_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_);
			return cb_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_;
		}

		static bool n_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalMicrophoneEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterLocalMicrophoneEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener']]"
		[Register ("RegisterLocalMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMicrophoneEventListener;)Z", "GetRegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_Handler")]
		public virtual unsafe bool RegisterLocalMicrophoneEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMicrophoneEventListener p0)
		{
			if (id_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_ == IntPtr.Zero)
				id_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMicrophoneEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMicrophoneEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMicrophoneEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_Handler ()
		{
			if (cb_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_ == null)
				cb_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_);
			return cb_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_;
		}

		static bool n_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalMonitorEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterLocalMonitorEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener']]"
		[Register ("RegisterLocalMonitorEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMonitorEventListener;)Z", "GetRegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_Handler")]
		public virtual unsafe bool RegisterLocalMonitorEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener p0)
		{
			if (id_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_ == IntPtr.Zero)
				id_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalMonitorEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMonitorEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalMonitorEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalMonitorEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalMonitorEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalMonitorEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_Handler ()
		{
			if (cb_RegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_ == null)
				cb_RegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_);
			return cb_RegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_;
		}

		static bool n_RegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalRendererEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterLocalRendererEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener']]"
		[Register ("RegisterLocalRendererEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalRendererEventListener;)Z", "GetRegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_Handler")]
		public virtual unsafe bool RegisterLocalRendererEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener p0)
		{
			if (id_RegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_ == IntPtr.Zero)
				id_RegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalRendererEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalRendererEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalRendererEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalRendererEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalRendererEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_Handler ()
		{
			if (cb_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_ == null)
				cb_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_);
			return cb_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_;
		}

		static bool n_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalSpeakerEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterLocalSpeakerEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener']]"
		[Register ("RegisterLocalSpeakerEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalSpeakerEventListener;)Z", "GetRegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_Handler")]
		public virtual unsafe bool RegisterLocalSpeakerEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalSpeakerEventListener p0)
		{
			if (id_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_ == IntPtr.Zero)
				id_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalSpeakerEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalSpeakerEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalSpeakerEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalSpeakerEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalSpeakerEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_Handler ()
		{
			if (cb_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_ == null)
				cb_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_);
			return cb_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_;
		}

		static bool n_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLocalWindowShareEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterLocalWindowShareEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener']]"
		[Register ("RegisterLocalWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalWindowShareEventListener;)Z", "GetRegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_Handler")]
		public virtual unsafe bool RegisterLocalWindowShareEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalWindowShareEventListener p0)
		{
			if (id_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_ == IntPtr.Zero)
				id_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLocalWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalWindowShareEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLocalWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLocalWindowShareEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLocalWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLocalWindowShareEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_Handler ()
		{
			if (cb_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_ == null)
				cb_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_);
			return cb_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_;
		}

		static bool n_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLogEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLogEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLogEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLogEventListener (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterLogEventListener' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLogEventListener'] and parameter[2][@type='java.lang.String']]"
		[Register ("RegisterLogEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLogEventListener;Ljava/lang/String;)Z", "GetRegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_Handler")]
		public virtual unsafe bool RegisterLogEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLogEventListener p0, string p1)
		{
			if (id_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_ == IntPtr.Zero)
				id_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "RegisterLogEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLogEventListener;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLogEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterLogEventListener_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLogEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterLogEventListener;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_Handler ()
		{
			if (cb_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_ == null)
				cb_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_);
			return cb_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_;
		}

		static bool n_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterNetworkInterfaceEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterNetworkInterfaceEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener']]"
		[Register ("RegisterNetworkInterfaceEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterNetworkInterfaceEventListener;)Z", "GetRegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_Handler")]
		public virtual unsafe bool RegisterNetworkInterfaceEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener p0)
		{
			if (id_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_ == IntPtr.Zero)
				id_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterNetworkInterfaceEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterNetworkInterfaceEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterNetworkInterfaceEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterNetworkInterfaceEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterNetworkInterfaceEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterNetworkInterfaceEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_Handler ()
		{
			if (cb_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_ == null)
				cb_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_);
			return cb_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_;
		}

		static bool n_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRemoteCameraEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterRemoteCameraEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener']]"
		[Register ("RegisterRemoteCameraEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteCameraEventListener;)Z", "GetRegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_Handler")]
		public virtual unsafe bool RegisterRemoteCameraEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener p0)
		{
			if (id_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_ == IntPtr.Zero)
				id_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRemoteCameraEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteCameraEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRemoteCameraEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteCameraEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRemoteCameraEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteCameraEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_Handler ()
		{
			if (cb_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_ == null)
				cb_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_);
			return cb_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_;
		}

		static bool n_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRemoteMicrophoneEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterRemoteMicrophoneEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener']]"
		[Register ("RegisterRemoteMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteMicrophoneEventListener;)Z", "GetRegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_Handler")]
		public virtual unsafe bool RegisterRemoteMicrophoneEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteMicrophoneEventListener p0)
		{
			if (id_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_ == IntPtr.Zero)
				id_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRemoteMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteMicrophoneEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRemoteMicrophoneEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteMicrophoneEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRemoteMicrophoneEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteMicrophoneEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_Handler ()
		{
			if (cb_RegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_ == null)
				cb_RegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_);
			return cb_RegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_;
		}

		static bool n_RegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRemoteRendererEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterRemoteRendererEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener']]"
		[Register ("RegisterRemoteRendererEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteRendererEventListener;)Z", "GetRegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_Handler")]
		public virtual unsafe bool RegisterRemoteRendererEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener p0)
		{
			if (id_RegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_ == IntPtr.Zero)
				id_RegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRemoteRendererEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteRendererEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRemoteRendererEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteRendererEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRemoteRendererEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteRendererEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_Handler ()
		{
			if (cb_RegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_ == null)
				cb_RegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_);
			return cb_RegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_;
		}

		static bool n_RegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRemoteSpeakerEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterRemoteSpeakerEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener']]"
		[Register ("RegisterRemoteSpeakerEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteSpeakerEventListener;)Z", "GetRegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_Handler")]
		public virtual unsafe bool RegisterRemoteSpeakerEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener p0)
		{
			if (id_RegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_ == IntPtr.Zero)
				id_RegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRemoteSpeakerEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteSpeakerEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRemoteSpeakerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteSpeakerEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRemoteSpeakerEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteSpeakerEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_Handler ()
		{
			if (cb_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_ == null)
				cb_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_);
			return cb_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_;
		}

		static bool n_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRemoteWindowShareEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RegisterRemoteWindowShareEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener']]"
		[Register ("RegisterRemoteWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteWindowShareEventListener;)Z", "GetRegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_Handler")]
		public virtual unsafe bool RegisterRemoteWindowShareEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteWindowShareEventListener p0)
		{
			if (id_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_ == IntPtr.Zero)
				id_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRemoteWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteWindowShareEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRemoteWindowShareEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_IRegisterRemoteWindowShareEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRemoteWindowShareEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$IRegisterRemoteWindowShareEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
		static Delegate GetRemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
		{
			if (cb_RemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
				cb_RemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
			return cb_RemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		}

		static void n_RemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='RemoveRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
		[Register ("RemoveRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V", "GetRemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler")]
		public virtual unsafe void RemoveRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
		{
			if (id_RemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
				id_RemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "RemoveRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RemoveRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V"), __args);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectDefaultCamera ();
		}
#pragma warning restore 0169

		static IntPtr id_SelectDefaultCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectDefaultCamera' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectDefaultMicrophone ();
		}
#pragma warning restore 0169

		static IntPtr id_SelectDefaultMicrophone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectDefaultMicrophone' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectDefaultNetworkInterfaceForMedia ();
		}
#pragma warning restore 0169

		static IntPtr id_SelectDefaultNetworkInterfaceForMedia;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectDefaultNetworkInterfaceForMedia' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectDefaultNetworkInterfaceForSignaling ();
		}
#pragma warning restore 0169

		static IntPtr id_SelectDefaultNetworkInterfaceForSignaling;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectDefaultNetworkInterfaceForSignaling' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectDefaultSpeaker ();
		}
#pragma warning restore 0169

		static IntPtr id_SelectDefaultSpeaker;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectDefaultSpeaker' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectLocalCamera (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectLocalCamera' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectLocalMicrophone (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectLocalMicrophone' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectLocalMonitor (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectLocalMonitor' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectLocalSpeaker (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectLocalSpeaker' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectLocalWindowShare (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectLocalWindowShare' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectNetworkInterfaceForMedia (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectNetworkInterfaceForMedia_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectNetworkInterfaceForMedia' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoNetworkInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoNetworkInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SelectNetworkInterfaceForSignaling (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectNetworkInterfaceForSignaling_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SelectNetworkInterfaceForSignaling' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoNetworkInterface']]"
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

		static Delegate cb_SetApplicationTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationTag_Ljava_lang_String_Handler ()
		{
			if (cb_SetApplicationTag_Ljava_lang_String_ == null)
				cb_SetApplicationTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetApplicationTag_Ljava_lang_String_);
			return cb_SetApplicationTag_Ljava_lang_String_;
		}

		static bool n_SetApplicationTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetApplicationTag (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetApplicationTag_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetApplicationTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetApplicationTag", "(Ljava/lang/String;)Z", "GetSetApplicationTag_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetApplicationTag (string p0)
		{
			if (id_SetApplicationTag_Ljava_lang_String_ == IntPtr.Zero)
				id_SetApplicationTag_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetApplicationTag", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetApplicationTag_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetApplicationTag", "(Ljava/lang/String;)Z"), __args);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetCameraPrivacy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetCameraPrivacy_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetCameraPrivacy' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_SetConsoleLoggerFilter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConsoleLoggerFilter_Ljava_lang_String_Handler ()
		{
			if (cb_SetConsoleLoggerFilter_Ljava_lang_String_ == null)
				cb_SetConsoleLoggerFilter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetConsoleLoggerFilter_Ljava_lang_String_);
			return cb_SetConsoleLoggerFilter_Ljava_lang_String_;
		}

		static bool n_SetConsoleLoggerFilter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetConsoleLoggerFilter (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetConsoleLoggerFilter_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetConsoleLoggerFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetConsoleLoggerFilter", "(Ljava/lang/String;)Z", "GetSetConsoleLoggerFilter_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetConsoleLoggerFilter (string p0)
		{
			if (id_SetConsoleLoggerFilter_Ljava_lang_String_ == IntPtr.Zero)
				id_SetConsoleLoggerFilter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetConsoleLoggerFilter", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetConsoleLoggerFilter_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetConsoleLoggerFilter", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_SetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_SetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_SetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_SetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static bool n_SetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetConsoleLoggerLevelAndCategory (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetConsoleLoggerLevelAndCategory' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("SetConsoleLoggerLevelAndCategory", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "GetSetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe bool SetConsoleLoggerLevelAndCategory (string p0, string p1, bool p2)
		{
			if (id_SetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_SetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "SetConsoleLoggerLevelAndCategory", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetConsoleLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetConsoleLoggerLevelAndCategory", "(Ljava/lang/String;Ljava/lang/String;Z)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_SetDebugFilter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDebugFilter_Ljava_lang_String_Handler ()
		{
			if (cb_SetDebugFilter_Ljava_lang_String_ == null)
				cb_SetDebugFilter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetDebugFilter_Ljava_lang_String_);
			return cb_SetDebugFilter_Ljava_lang_String_;
		}

		static bool n_SetDebugFilter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetDebugFilter (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetDebugFilter_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetDebugFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetDebugFilter", "(Ljava/lang/String;)Z", "GetSetDebugFilter_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetDebugFilter (string p0)
		{
			if (id_SetDebugFilter_Ljava_lang_String_ == IntPtr.Zero)
				id_SetDebugFilter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetDebugFilter", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetDebugFilter_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetDebugFilter", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SetFileLoggerFilter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFileLoggerFilter_Ljava_lang_String_Handler ()
		{
			if (cb_SetFileLoggerFilter_Ljava_lang_String_ == null)
				cb_SetFileLoggerFilter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetFileLoggerFilter_Ljava_lang_String_);
			return cb_SetFileLoggerFilter_Ljava_lang_String_;
		}

		static bool n_SetFileLoggerFilter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetFileLoggerFilter (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetFileLoggerFilter_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetFileLoggerFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetFileLoggerFilter", "(Ljava/lang/String;)Z", "GetSetFileLoggerFilter_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetFileLoggerFilter (string p0)
		{
			if (id_SetFileLoggerFilter_Ljava_lang_String_ == IntPtr.Zero)
				id_SetFileLoggerFilter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetFileLoggerFilter", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetFileLoggerFilter_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetFileLoggerFilter", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_SetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_SetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_SetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_SetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static bool n_SetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetFileLoggerLevelAndCategory (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetFileLoggerLevelAndCategory' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("SetFileLoggerLevelAndCategory", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "GetSetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe bool SetFileLoggerLevelAndCategory (string p0, string p1, bool p2)
		{
			if (id_SetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_SetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "SetFileLoggerLevelAndCategory", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetFileLoggerLevelAndCategory_Ljava_lang_String_Ljava_lang_String_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetFileLoggerLevelAndCategory", "(Ljava/lang/String;Ljava/lang/String;Z)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetLocation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_SetLocation_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetLocation' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetMicrophonePrivacy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetMicrophonePrivacy_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetMicrophonePrivacy' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_SetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_;
#pragma warning disable 0169
		static Delegate GetSetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_Handler ()
		{
			if (cb_SetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_ == null)
				cb_SetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_);
			return cb_SetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_;
		}

		static bool n_SetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetMode (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetMode' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode']]"
		[Register ("SetMode", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode;)Z", "GetSetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_Handler")]
		public virtual unsafe bool SetMode (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint.VidyoEndpointMode p0)
		{
			if (id_SetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_ == IntPtr.Zero)
				id_SetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_ = JNIEnv.GetMethodID (class_ref, "SetMode", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetMode_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_VidyoEndpointMode_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMode", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint$VidyoEndpointMode;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetPoolId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPoolId_Ljava_lang_String_Handler ()
		{
			if (cb_SetPoolId_Ljava_lang_String_ == null)
				cb_SetPoolId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetPoolId_Ljava_lang_String_);
			return cb_SetPoolId_Ljava_lang_String_;
		}

		static bool n_SetPoolId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetPoolId (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetPoolId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetPoolId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetPoolId", "(Ljava/lang/String;)Z", "GetSetPoolId_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetPoolId (string p0)
		{
			if (id_SetPoolId_Ljava_lang_String_ == IntPtr.Zero)
				id_SetPoolId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetPoolId", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetPoolId_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPoolId", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SetPreview_Z;
#pragma warning disable 0169
		static Delegate GetSetPreview_ZHandler ()
		{
			if (cb_SetPreview_Z == null)
				cb_SetPreview_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetPreview_Z);
			return cb_SetPreview_Z;
		}

		static bool n_SetPreview_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetPreview (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetPreview_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetPreview' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetPreview", "(Z)Z", "GetSetPreview_ZHandler")]
		public virtual unsafe bool SetPreview (bool p0)
		{
			if (id_SetPreview_Z == IntPtr.Zero)
				id_SetPreview_Z = JNIEnv.GetMethodID (class_ref, "SetPreview", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetPreview_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPreview", "(Z)Z"), __args);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSpeakerPrivacy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetSpeakerPrivacy_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetSpeakerPrivacy' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetViewAnimationSpeed (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetViewAnimationSpeed_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetViewAnimationSpeed' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetViewBackgroundColor (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetViewBackgroundColor_Ljava_lang_Object_BBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='SetViewBackgroundColor' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowAudioMeters (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ShowAudioMeters_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='ShowAudioMeters' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowPreview (p0);
		}
#pragma warning restore 0169

		static IntPtr id_ShowPreview_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='ShowPreview' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowViewAt (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ShowViewAt_Ljava_lang_Object_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='ShowViewAt' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowViewLabel (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ShowViewLabel_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='ShowViewLabel' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean']]"
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

		static Delegate cb_StartLocalCameraDetection;
#pragma warning disable 0169
		static Delegate GetStartLocalCameraDetectionHandler ()
		{
			if (cb_StartLocalCameraDetection == null)
				cb_StartLocalCameraDetection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartLocalCameraDetection);
			return cb_StartLocalCameraDetection;
		}

		static bool n_StartLocalCameraDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartLocalCameraDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StartLocalCameraDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StartLocalCameraDetection' and count(parameter)=0]"
		[Register ("StartLocalCameraDetection", "()Z", "GetStartLocalCameraDetectionHandler")]
		public virtual unsafe bool StartLocalCameraDetection ()
		{
			if (id_StartLocalCameraDetection == IntPtr.Zero)
				id_StartLocalCameraDetection = JNIEnv.GetMethodID (class_ref, "StartLocalCameraDetection", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_StartLocalCameraDetection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StartLocalCameraDetection", "()Z"));
			} finally {
			}
		}

		static Delegate cb_StartLocalMicrophoneDetection;
#pragma warning disable 0169
		static Delegate GetStartLocalMicrophoneDetectionHandler ()
		{
			if (cb_StartLocalMicrophoneDetection == null)
				cb_StartLocalMicrophoneDetection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartLocalMicrophoneDetection);
			return cb_StartLocalMicrophoneDetection;
		}

		static bool n_StartLocalMicrophoneDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartLocalMicrophoneDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StartLocalMicrophoneDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StartLocalMicrophoneDetection' and count(parameter)=0]"
		[Register ("StartLocalMicrophoneDetection", "()Z", "GetStartLocalMicrophoneDetectionHandler")]
		public virtual unsafe bool StartLocalMicrophoneDetection ()
		{
			if (id_StartLocalMicrophoneDetection == IntPtr.Zero)
				id_StartLocalMicrophoneDetection = JNIEnv.GetMethodID (class_ref, "StartLocalMicrophoneDetection", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_StartLocalMicrophoneDetection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StartLocalMicrophoneDetection", "()Z"));
			} finally {
			}
		}

		static Delegate cb_StartLocalMonitorDetection;
#pragma warning disable 0169
		static Delegate GetStartLocalMonitorDetectionHandler ()
		{
			if (cb_StartLocalMonitorDetection == null)
				cb_StartLocalMonitorDetection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartLocalMonitorDetection);
			return cb_StartLocalMonitorDetection;
		}

		static bool n_StartLocalMonitorDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartLocalMonitorDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StartLocalMonitorDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StartLocalMonitorDetection' and count(parameter)=0]"
		[Register ("StartLocalMonitorDetection", "()Z", "GetStartLocalMonitorDetectionHandler")]
		public virtual unsafe bool StartLocalMonitorDetection ()
		{
			if (id_StartLocalMonitorDetection == IntPtr.Zero)
				id_StartLocalMonitorDetection = JNIEnv.GetMethodID (class_ref, "StartLocalMonitorDetection", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_StartLocalMonitorDetection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StartLocalMonitorDetection", "()Z"));
			} finally {
			}
		}

		static Delegate cb_StartLocalSpeakerDetection;
#pragma warning disable 0169
		static Delegate GetStartLocalSpeakerDetectionHandler ()
		{
			if (cb_StartLocalSpeakerDetection == null)
				cb_StartLocalSpeakerDetection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartLocalSpeakerDetection);
			return cb_StartLocalSpeakerDetection;
		}

		static bool n_StartLocalSpeakerDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartLocalSpeakerDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StartLocalSpeakerDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StartLocalSpeakerDetection' and count(parameter)=0]"
		[Register ("StartLocalSpeakerDetection", "()Z", "GetStartLocalSpeakerDetectionHandler")]
		public virtual unsafe bool StartLocalSpeakerDetection ()
		{
			if (id_StartLocalSpeakerDetection == IntPtr.Zero)
				id_StartLocalSpeakerDetection = JNIEnv.GetMethodID (class_ref, "StartLocalSpeakerDetection", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_StartLocalSpeakerDetection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StartLocalSpeakerDetection", "()Z"));
			} finally {
			}
		}

		static Delegate cb_StartLocalWindowShareDetection;
#pragma warning disable 0169
		static Delegate GetStartLocalWindowShareDetectionHandler ()
		{
			if (cb_StartLocalWindowShareDetection == null)
				cb_StartLocalWindowShareDetection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartLocalWindowShareDetection);
			return cb_StartLocalWindowShareDetection;
		}

		static bool n_StartLocalWindowShareDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartLocalWindowShareDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StartLocalWindowShareDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StartLocalWindowShareDetection' and count(parameter)=0]"
		[Register ("StartLocalWindowShareDetection", "()Z", "GetStartLocalWindowShareDetectionHandler")]
		public virtual unsafe bool StartLocalWindowShareDetection ()
		{
			if (id_StartLocalWindowShareDetection == IntPtr.Zero)
				id_StartLocalWindowShareDetection = JNIEnv.GetMethodID (class_ref, "StartLocalWindowShareDetection", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_StartLocalWindowShareDetection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StartLocalWindowShareDetection", "()Z"));
			} finally {
			}
		}

		static Delegate cb_StartLocationDetection;
#pragma warning disable 0169
		static Delegate GetStartLocationDetectionHandler ()
		{
			if (cb_StartLocationDetection == null)
				cb_StartLocationDetection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartLocationDetection);
			return cb_StartLocationDetection;
		}

		static bool n_StartLocationDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartLocationDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StartLocationDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StartLocationDetection' and count(parameter)=0]"
		[Register ("StartLocationDetection", "()Z", "GetStartLocationDetectionHandler")]
		public virtual unsafe bool StartLocationDetection ()
		{
			if (id_StartLocationDetection == IntPtr.Zero)
				id_StartLocationDetection = JNIEnv.GetMethodID (class_ref, "StartLocationDetection", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_StartLocationDetection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StartLocationDetection", "()Z"));
			} finally {
			}
		}

		static Delegate cb_StopLocalCameraDetection;
#pragma warning disable 0169
		static Delegate GetStopLocalCameraDetectionHandler ()
		{
			if (cb_StopLocalCameraDetection == null)
				cb_StopLocalCameraDetection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLocalCameraDetection);
			return cb_StopLocalCameraDetection;
		}

		static void n_StopLocalCameraDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocalCameraDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StopLocalCameraDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StopLocalCameraDetection' and count(parameter)=0]"
		[Register ("StopLocalCameraDetection", "()V", "GetStopLocalCameraDetectionHandler")]
		public virtual unsafe void StopLocalCameraDetection ()
		{
			if (id_StopLocalCameraDetection == IntPtr.Zero)
				id_StopLocalCameraDetection = JNIEnv.GetMethodID (class_ref, "StopLocalCameraDetection", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_StopLocalCameraDetection);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StopLocalCameraDetection", "()V"));
			} finally {
			}
		}

		static Delegate cb_StopLocalMicrophoneDetection;
#pragma warning disable 0169
		static Delegate GetStopLocalMicrophoneDetectionHandler ()
		{
			if (cb_StopLocalMicrophoneDetection == null)
				cb_StopLocalMicrophoneDetection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLocalMicrophoneDetection);
			return cb_StopLocalMicrophoneDetection;
		}

		static void n_StopLocalMicrophoneDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocalMicrophoneDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StopLocalMicrophoneDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StopLocalMicrophoneDetection' and count(parameter)=0]"
		[Register ("StopLocalMicrophoneDetection", "()V", "GetStopLocalMicrophoneDetectionHandler")]
		public virtual unsafe void StopLocalMicrophoneDetection ()
		{
			if (id_StopLocalMicrophoneDetection == IntPtr.Zero)
				id_StopLocalMicrophoneDetection = JNIEnv.GetMethodID (class_ref, "StopLocalMicrophoneDetection", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_StopLocalMicrophoneDetection);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StopLocalMicrophoneDetection", "()V"));
			} finally {
			}
		}

		static Delegate cb_StopLocalMonitorDetection;
#pragma warning disable 0169
		static Delegate GetStopLocalMonitorDetectionHandler ()
		{
			if (cb_StopLocalMonitorDetection == null)
				cb_StopLocalMonitorDetection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLocalMonitorDetection);
			return cb_StopLocalMonitorDetection;
		}

		static void n_StopLocalMonitorDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocalMonitorDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StopLocalMonitorDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StopLocalMonitorDetection' and count(parameter)=0]"
		[Register ("StopLocalMonitorDetection", "()V", "GetStopLocalMonitorDetectionHandler")]
		public virtual unsafe void StopLocalMonitorDetection ()
		{
			if (id_StopLocalMonitorDetection == IntPtr.Zero)
				id_StopLocalMonitorDetection = JNIEnv.GetMethodID (class_ref, "StopLocalMonitorDetection", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_StopLocalMonitorDetection);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StopLocalMonitorDetection", "()V"));
			} finally {
			}
		}

		static Delegate cb_StopLocalSpeakerDetection;
#pragma warning disable 0169
		static Delegate GetStopLocalSpeakerDetectionHandler ()
		{
			if (cb_StopLocalSpeakerDetection == null)
				cb_StopLocalSpeakerDetection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLocalSpeakerDetection);
			return cb_StopLocalSpeakerDetection;
		}

		static void n_StopLocalSpeakerDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocalSpeakerDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StopLocalSpeakerDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StopLocalSpeakerDetection' and count(parameter)=0]"
		[Register ("StopLocalSpeakerDetection", "()V", "GetStopLocalSpeakerDetectionHandler")]
		public virtual unsafe void StopLocalSpeakerDetection ()
		{
			if (id_StopLocalSpeakerDetection == IntPtr.Zero)
				id_StopLocalSpeakerDetection = JNIEnv.GetMethodID (class_ref, "StopLocalSpeakerDetection", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_StopLocalSpeakerDetection);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StopLocalSpeakerDetection", "()V"));
			} finally {
			}
		}

		static Delegate cb_StopLocalWindowShareDetection;
#pragma warning disable 0169
		static Delegate GetStopLocalWindowShareDetectionHandler ()
		{
			if (cb_StopLocalWindowShareDetection == null)
				cb_StopLocalWindowShareDetection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLocalWindowShareDetection);
			return cb_StopLocalWindowShareDetection;
		}

		static void n_StopLocalWindowShareDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocalWindowShareDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StopLocalWindowShareDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StopLocalWindowShareDetection' and count(parameter)=0]"
		[Register ("StopLocalWindowShareDetection", "()V", "GetStopLocalWindowShareDetectionHandler")]
		public virtual unsafe void StopLocalWindowShareDetection ()
		{
			if (id_StopLocalWindowShareDetection == IntPtr.Zero)
				id_StopLocalWindowShareDetection = JNIEnv.GetMethodID (class_ref, "StopLocalWindowShareDetection", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_StopLocalWindowShareDetection);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StopLocalWindowShareDetection", "()V"));
			} finally {
			}
		}

		static Delegate cb_StopLocationDetection;
#pragma warning disable 0169
		static Delegate GetStopLocationDetectionHandler ()
		{
			if (cb_StopLocationDetection == null)
				cb_StopLocationDetection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLocationDetection);
			return cb_StopLocationDetection;
		}

		static void n_StopLocationDetection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocationDetection ();
		}
#pragma warning restore 0169

		static IntPtr id_StopLocationDetection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='StopLocationDetection' and count(parameter)=0]"
		[Register ("StopLocationDetection", "()V", "GetStopLocationDetectionHandler")]
		public virtual unsafe void StopLocationDetection ()
		{
			if (id_StopLocationDetection == IntPtr.Zero)
				id_StopLocationDetection = JNIEnv.GetMethodID (class_ref, "StopLocationDetection", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_StopLocationDetection);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StopLocationDetection", "()V"));
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalCameraEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalCameraEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterLocalCameraEventListener' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalMicrophoneEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalMicrophoneEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterLocalMicrophoneEventListener' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalMonitorEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalMonitorEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterLocalMonitorEventListener' and count(parameter)=0]"
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

		static Delegate cb_UnregisterLocalRendererEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterLocalRendererEventListenerHandler ()
		{
			if (cb_UnregisterLocalRendererEventListener == null)
				cb_UnregisterLocalRendererEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterLocalRendererEventListener);
			return cb_UnregisterLocalRendererEventListener;
		}

		static bool n_UnregisterLocalRendererEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalRendererEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalRendererEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterLocalRendererEventListener' and count(parameter)=0]"
		[Register ("UnregisterLocalRendererEventListener", "()Z", "GetUnregisterLocalRendererEventListenerHandler")]
		public virtual unsafe bool UnregisterLocalRendererEventListener ()
		{
			if (id_UnregisterLocalRendererEventListener == IntPtr.Zero)
				id_UnregisterLocalRendererEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterLocalRendererEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterLocalRendererEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterLocalRendererEventListener", "()Z"));
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalSpeakerEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalSpeakerEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterLocalSpeakerEventListener' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLocalWindowShareEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLocalWindowShareEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterLocalWindowShareEventListener' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLogEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLogEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterLogEventListener' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterNetworkInterfaceEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterNetworkInterfaceEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterNetworkInterfaceEventListener' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRemoteCameraEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRemoteCameraEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterRemoteCameraEventListener' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRemoteMicrophoneEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRemoteMicrophoneEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterRemoteMicrophoneEventListener' and count(parameter)=0]"
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

		static Delegate cb_UnregisterRemoteRendererEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterRemoteRendererEventListenerHandler ()
		{
			if (cb_UnregisterRemoteRendererEventListener == null)
				cb_UnregisterRemoteRendererEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterRemoteRendererEventListener);
			return cb_UnregisterRemoteRendererEventListener;
		}

		static bool n_UnregisterRemoteRendererEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRemoteRendererEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRemoteRendererEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterRemoteRendererEventListener' and count(parameter)=0]"
		[Register ("UnregisterRemoteRendererEventListener", "()Z", "GetUnregisterRemoteRendererEventListenerHandler")]
		public virtual unsafe bool UnregisterRemoteRendererEventListener ()
		{
			if (id_UnregisterRemoteRendererEventListener == IntPtr.Zero)
				id_UnregisterRemoteRendererEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterRemoteRendererEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterRemoteRendererEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterRemoteRendererEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterRemoteSpeakerEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterRemoteSpeakerEventListenerHandler ()
		{
			if (cb_UnregisterRemoteSpeakerEventListener == null)
				cb_UnregisterRemoteSpeakerEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterRemoteSpeakerEventListener);
			return cb_UnregisterRemoteSpeakerEventListener;
		}

		static bool n_UnregisterRemoteSpeakerEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRemoteSpeakerEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRemoteSpeakerEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterRemoteSpeakerEventListener' and count(parameter)=0]"
		[Register ("UnregisterRemoteSpeakerEventListener", "()Z", "GetUnregisterRemoteSpeakerEventListenerHandler")]
		public virtual unsafe bool UnregisterRemoteSpeakerEventListener ()
		{
			if (id_UnregisterRemoteSpeakerEventListener == IntPtr.Zero)
				id_UnregisterRemoteSpeakerEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterRemoteSpeakerEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterRemoteSpeakerEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterRemoteSpeakerEventListener", "()Z"));
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRemoteWindowShareEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRemoteWindowShareEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='UnregisterRemoteWindowShareEventListener' and count(parameter)=0]"
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

		static Delegate cb_ValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_Handler ()
		{
			if (cb_ValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_ == null)
				cb_ValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_);
			return cb_ValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_;
		}

		static bool n_ValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ValidateLicenseKey (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='ValidateLicenseKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("ValidateLicenseKey", "(Ljava/lang/String;Ljava/lang/Boolean;)Z", "GetValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_Handler")]
		public virtual unsafe bool ValidateLicenseKey (string p0, global::Java.Lang.Boolean p1)
		{
			if (id_ValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_ValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "ValidateLicenseKey", "(Ljava/lang/String;Ljava/lang/Boolean;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_ValidateLicenseKey_Ljava_lang_String_Ljava_lang_Boolean_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ValidateLicenseKey", "(Ljava/lang/String;Ljava/lang/Boolean;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoEndpoint']/method[@name='dispose' and count(parameter)=0]"
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
