using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualShareManager']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoVirtualShareManager", DoNotGenerateAcw=true)]
	public partial class VidyoVirtualShareManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoVirtualShareManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoVirtualShareManager); }
		}

		protected VidyoVirtualShareManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualShareManager']/constructor[@name='VidyoVirtualShareManager' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoVirtualShareManager (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoVirtualShareManager)) {
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
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualShareManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualShareManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualShareManager']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_LocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetLocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_LocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_LocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_LocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_LocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static bool n_LocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualShareManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualShareManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LocalMonitorEvent (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualShareManager']/method[@name='LocalMonitorEvent' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("LocalMonitorEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z", "GetLocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe bool LocalMonitorEvent (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
		{
			if (id_LocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_LocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "LocalMonitorEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LocalMonitorEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalMonitorEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_LocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
#pragma warning disable 0169
		static Delegate GetLocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler ()
		{
			if (cb_LocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == null)
				cb_LocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_LocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_);
			return cb_LocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		}

		static bool n_LocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualShareManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualShareManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LocalWindowShareEvent (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualShareManager']/method[@name='LocalWindowShareEvent' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState']]"
		[Register ("LocalWindowShareEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z", "GetLocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler")]
		public virtual unsafe bool LocalWindowShareEvent (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p1, global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
		{
			if (id_LocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ == IntPtr.Zero)
				id_LocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_ = JNIEnv.GetMethodID (class_ref, "LocalWindowShareEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LocalWindowShareEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocalWindowShareEvent", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)Z"), __args);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualShareManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualShareManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MediaFailedEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_MediaFailedEvent_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualShareManager']/method[@name='MediaFailedEvent' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint']]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoVirtualShareManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVirtualShareManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVirtualShareManager']/method[@name='dispose' and count(parameter)=0]"
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
