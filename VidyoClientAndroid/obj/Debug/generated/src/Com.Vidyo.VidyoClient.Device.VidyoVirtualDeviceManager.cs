using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualDeviceManager']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoVirtualDeviceManager", DoNotGenerateAcw=true)]
	public partial class VidyoVirtualDeviceManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoVirtualDeviceManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoVirtualDeviceManager); }
		}

		protected VidyoVirtualDeviceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualDeviceManager']/constructor[@name='VidyoVirtualDeviceManager' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoVirtualDeviceManager (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoVirtualDeviceManager)) {
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
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualDeviceManager']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_LocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetLocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_LocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_LocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_LocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_LocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static bool n_LocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LocalCameraEvent (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualDeviceManager']/method[@name='LocalCameraEvent' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("LocalCameraEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z", "GetLocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe bool LocalCameraEvent (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
		{
			if (id_LocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_LocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "LocalCameraEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LocalCameraEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalCameraEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_LocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetLocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_LocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_LocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_LocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_LocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static bool n_LocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LocalMicrophoneEvent (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualDeviceManager']/method[@name='LocalMicrophoneEvent' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("LocalMicrophoneEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z", "GetLocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe bool LocalMicrophoneEvent (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
		{
			if (id_LocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_LocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "LocalMicrophoneEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LocalMicrophoneEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalMicrophoneEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_LocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetLocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_LocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_LocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_LocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_LocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static bool n_LocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LocalSpeakerEvent (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualDeviceManager']/method[@name='LocalSpeakerEvent' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("LocalSpeakerEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z", "GetLocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe bool LocalSpeakerEvent (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
		{
			if (id_LocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_LocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "LocalSpeakerEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LocalSpeakerEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalSpeakerEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_;
#pragma warning disable 0169
		static Delegate GetMediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Handler ()
		{
			if (cb_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ == null)
				cb_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_);
			return cb_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_;
		}

		static bool n_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MediaFailedEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualDeviceManager']/method[@name='MediaFailedEvent' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint']]"
		[Register ("MediaFailedEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;)Z", "GetMediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Handler")]
		public virtual unsafe bool MediaFailedEvent (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0)
		{
			if (id_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ == IntPtr.Zero)
				id_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ = JNIEnv.GetMethodID (class_ref, "MediaFailedEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "MediaFailedEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;)Z"), __args);
				return __ret;
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
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualDeviceManager']/method[@name='dispose' and count(parameter)=0]"
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
