using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoLocalMicrophone", DoNotGenerateAcw=true)]
	public partial class VidyoLocalMicrophone : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoLocalMicrophone", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoLocalMicrophone); }
		}

		protected VidyoLocalMicrophone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/constructor[@name='VidyoLocalMicrophone' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoLocalMicrophone (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoLocalMicrophone)) {
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

		static Delegate cb_GetAutoGain;
#pragma warning disable 0169
		static Delegate GetGetAutoGainHandler ()
		{
			if (cb_GetAutoGain == null)
				cb_GetAutoGain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutoGain);
			return cb_GetAutoGain;
		}

		static bool n_GetAutoGain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoGain;
		}
#pragma warning restore 0169

		static IntPtr id_GetAutoGain;
		public virtual unsafe bool AutoGain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='GetAutoGain' and count(parameter)=0]"
			[Register ("GetAutoGain", "()Z", "GetGetAutoGainHandler")]
			get {
				if (id_GetAutoGain == IntPtr.Zero)
					id_GetAutoGain = JNIEnv.GetMethodID (class_ref, "GetAutoGain", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetAutoGain);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAutoGain", "()Z"));
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='GetId' and count(parameter)=0]"
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

		static Delegate cb_IsDebugRecordingEnabled;
#pragma warning disable 0169
		static Delegate GetIsDebugRecordingEnabledHandler ()
		{
			if (cb_IsDebugRecordingEnabled == null)
				cb_IsDebugRecordingEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDebugRecordingEnabled);
			return cb_IsDebugRecordingEnabled;
		}

		static bool n_IsDebugRecordingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDebugRecordingEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_IsDebugRecordingEnabled;
		public virtual unsafe bool IsDebugRecordingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='IsDebugRecordingEnabled' and count(parameter)=0]"
			[Register ("IsDebugRecordingEnabled", "()Z", "GetIsDebugRecordingEnabledHandler")]
			get {
				if (id_IsDebugRecordingEnabled == IntPtr.Zero)
					id_IsDebugRecordingEnabled = JNIEnv.GetMethodID (class_ref, "IsDebugRecordingEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsDebugRecordingEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsDebugRecordingEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_IsPaused;
#pragma warning disable 0169
		static Delegate GetIsPausedHandler ()
		{
			if (cb_IsPaused == null)
				cb_IsPaused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPaused);
			return cb_IsPaused;
		}

		static bool n_IsPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_IsPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='IsPaused' and count(parameter)=0]"
			[Register ("IsPaused", "()Z", "GetIsPausedHandler")]
			get {
				if (id_IsPaused == IntPtr.Zero)
					id_IsPaused = JNIEnv.GetMethodID (class_ref, "IsPaused", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsPaused);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsPaused", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_GetName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_GetName == null)
				cb_GetName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_GetName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_GetName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='GetName' and count(parameter)=0]"
			[Register ("GetName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_GetName == IntPtr.Zero)
					id_GetName = JNIEnv.GetMethodID (class_ref, "GetName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_GetSignalType;
#pragma warning disable 0169
		static Delegate GetGetSignalTypeHandler ()
		{
			if (cb_GetSignalType == null)
				cb_GetSignalType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignalType);
			return cb_GetSignalType;
		}

		static IntPtr n_GetSignalType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SignalType);
		}
#pragma warning restore 0169

		static IntPtr id_GetSignalType;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType SignalType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='GetSignalType' and count(parameter)=0]"
			[Register ("GetSignalType", "()Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;", "GetGetSignalTypeHandler")]
			get {
				if (id_GetSignalType == IntPtr.Zero)
					id_GetSignalType = JNIEnv.GetMethodID (class_ref, "GetSignalType", "()Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetSignalType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSignalType", "()Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetVoiceProcessing;
#pragma warning disable 0169
		static Delegate GetGetVoiceProcessingHandler ()
		{
			if (cb_GetVoiceProcessing == null)
				cb_GetVoiceProcessing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetVoiceProcessing);
			return cb_GetVoiceProcessing;
		}

		static bool n_GetVoiceProcessing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VoiceProcessing;
		}
#pragma warning restore 0169

		static IntPtr id_GetVoiceProcessing;
		public virtual unsafe bool VoiceProcessing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='GetVoiceProcessing' and count(parameter)=0]"
			[Register ("GetVoiceProcessing", "()Z", "GetGetVoiceProcessingHandler")]
			get {
				if (id_GetVoiceProcessing == IntPtr.Zero)
					id_GetVoiceProcessing = JNIEnv.GetMethodID (class_ref, "GetVoiceProcessing", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetVoiceProcessing);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetVoiceProcessing", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_GetVolume;
#pragma warning disable 0169
		static Delegate GetGetVolumeHandler ()
		{
			if (cb_GetVolume == null)
				cb_GetVolume = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVolume);
			return cb_GetVolume;
		}

		static int n_GetVolume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Volume;
		}
#pragma warning restore 0169

		static Delegate cb_SetVolume_I;
#pragma warning disable 0169
		static Delegate GetSetVolume_IHandler ()
		{
			if (cb_SetVolume_I == null)
				cb_SetVolume_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetVolume_I);
			return cb_SetVolume_I;
		}

		static void n_SetVolume_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Volume = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetVolume;
		static IntPtr id_SetVolume_I;
		public virtual unsafe int Volume {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='GetVolume' and count(parameter)=0]"
			[Register ("GetVolume", "()I", "GetGetVolumeHandler")]
			get {
				if (id_GetVolume == IntPtr.Zero)
					id_GetVolume = JNIEnv.GetMethodID (class_ref, "GetVolume", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetVolume);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetVolume", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='SetVolume' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetVolume", "(I)V", "GetSetVolume_IHandler")]
			set {
				if (id_SetVolume_I == IntPtr.Zero)
					id_SetVolume_I = JNIEnv.GetMethodID (class_ref, "SetVolume", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetVolume_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetVolume", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
		static Delegate GetAddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
		{
			if (cb_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
				cb_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
			return cb_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		}

		static bool n_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddToLocalSpeaker (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='AddToLocalSpeaker' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
		[Register ("AddToLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)Z", "GetAddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler")]
		public virtual unsafe bool AddToLocalSpeaker (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
		{
			if (id_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
				id_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "AddToLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddToLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_AddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_;
#pragma warning disable 0169
		static Delegate GetAddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Handler ()
		{
			if (cb_AddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_ == null)
				cb_AddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_);
			return cb_AddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_;
		}

		static bool n_AddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddToRemoteSpeaker (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='AddToRemoteSpeaker' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker']]"
		[Register ("AddToRemoteSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;)Z", "GetAddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Handler")]
		public virtual unsafe bool AddToRemoteSpeaker (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0)
		{
			if (id_AddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_ == IntPtr.Zero)
				id_AddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_ = JNIEnv.GetMethodID (class_ref, "AddToRemoteSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AddToRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddToRemoteSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_DisableDebugRecording;
#pragma warning disable 0169
		static Delegate GetDisableDebugRecordingHandler ()
		{
			if (cb_DisableDebugRecording == null)
				cb_DisableDebugRecording = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DisableDebugRecording);
			return cb_DisableDebugRecording;
		}

		static bool n_DisableDebugRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisableDebugRecording ();
		}
#pragma warning restore 0169

		static IntPtr id_DisableDebugRecording;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='DisableDebugRecording' and count(parameter)=0]"
		[Register ("DisableDebugRecording", "()Z", "GetDisableDebugRecordingHandler")]
		public virtual unsafe bool DisableDebugRecording ()
		{
			if (id_DisableDebugRecording == IntPtr.Zero)
				id_DisableDebugRecording = JNIEnv.GetMethodID (class_ref, "DisableDebugRecording", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_DisableDebugRecording);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DisableDebugRecording", "()Z"));
			} finally {
			}
		}

		static Delegate cb_EnableDebugRecording_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnableDebugRecording_Ljava_lang_String_Handler ()
		{
			if (cb_EnableDebugRecording_Ljava_lang_String_ == null)
				cb_EnableDebugRecording_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_EnableDebugRecording_Ljava_lang_String_);
			return cb_EnableDebugRecording_Ljava_lang_String_;
		}

		static bool n_EnableDebugRecording_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EnableDebugRecording (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_EnableDebugRecording_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='EnableDebugRecording' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("EnableDebugRecording", "(Ljava/lang/String;)Z", "GetEnableDebugRecording_Ljava_lang_String_Handler")]
		public virtual unsafe bool EnableDebugRecording (string p0)
		{
			if (id_EnableDebugRecording_Ljava_lang_String_ == IntPtr.Zero)
				id_EnableDebugRecording_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "EnableDebugRecording", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_EnableDebugRecording_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "EnableDebugRecording", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_HideDebugDialog;
#pragma warning disable 0169
		static Delegate GetHideDebugDialogHandler ()
		{
			if (cb_HideDebugDialog == null)
				cb_HideDebugDialog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideDebugDialog);
			return cb_HideDebugDialog;
		}

		static void n_HideDebugDialog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideDebugDialog ();
		}
#pragma warning restore 0169

		static IntPtr id_HideDebugDialog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='HideDebugDialog' and count(parameter)=0]"
		[Register ("HideDebugDialog", "()V", "GetHideDebugDialogHandler")]
		public virtual unsafe void HideDebugDialog ()
		{
			if (id_HideDebugDialog == IntPtr.Zero)
				id_HideDebugDialog = JNIEnv.GetMethodID (class_ref, "HideDebugDialog", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_HideDebugDialog);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "HideDebugDialog", "()V"));
			} finally {
			}
		}

		static Delegate cb_Pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_Pause == null)
				cb_Pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_Pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_Pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='Pause' and count(parameter)=0]"
		[Register ("Pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_Pause == IntPtr.Zero)
				id_Pause = JNIEnv.GetMethodID (class_ref, "Pause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Pause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_PlayTone_C;
#pragma warning disable 0169
		static Delegate GetPlayTone_CHandler ()
		{
			if (cb_PlayTone_C == null)
				cb_PlayTone_C = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char>) n_PlayTone_C);
			return cb_PlayTone_C;
		}

		static void n_PlayTone_C (IntPtr jnienv, IntPtr native__this, char p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlayTone (p0);
		}
#pragma warning restore 0169

		static IntPtr id_PlayTone_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='PlayTone' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("PlayTone", "(C)V", "GetPlayTone_CHandler")]
		public virtual unsafe void PlayTone (char p0)
		{
			if (id_PlayTone_C == IntPtr.Zero)
				id_PlayTone_C = JNIEnv.GetMethodID (class_ref, "PlayTone", "(C)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PlayTone_C, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "PlayTone", "(C)V"), __args);
			} finally {
			}
		}

		static Delegate cb_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
		static Delegate GetRemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
		{
			if (cb_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
				cb_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
			return cb_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		}

		static bool n_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFromLocalSpeaker (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='RemoveFromLocalSpeaker' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
		[Register ("RemoveFromLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)Z", "GetRemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler")]
		public virtual unsafe bool RemoveFromLocalSpeaker (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
		{
			if (id_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
				id_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "RemoveFromLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveFromLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_;
#pragma warning disable 0169
		static Delegate GetRemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Handler ()
		{
			if (cb_RemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_ == null)
				cb_RemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_);
			return cb_RemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_;
		}

		static bool n_RemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFromRemoteSpeaker (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='RemoveFromRemoteSpeaker' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker']]"
		[Register ("RemoveFromRemoteSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;)Z", "GetRemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Handler")]
		public virtual unsafe bool RemoveFromRemoteSpeaker (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0)
		{
			if (id_RemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_ == IntPtr.Zero)
				id_RemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_ = JNIEnv.GetMethodID (class_ref, "RemoveFromRemoteSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RemoveFromRemoteSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveFromRemoteSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_Resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_Resume == null)
				cb_Resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_Resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_Resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='Resume' and count(parameter)=0]"
		[Register ("Resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_Resume == IntPtr.Zero)
				id_Resume = JNIEnv.GetMethodID (class_ref, "Resume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Resume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Resume", "()V"));
			} finally {
			}
		}

		static Delegate cb_SetAutoGain_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoGain_ZHandler ()
		{
			if (cb_SetAutoGain_Z == null)
				cb_SetAutoGain_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetAutoGain_Z);
			return cb_SetAutoGain_Z;
		}

		static bool n_SetAutoGain_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetAutoGain (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetAutoGain_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='SetAutoGain' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetAutoGain", "(Z)Z", "GetSetAutoGain_ZHandler")]
		public virtual unsafe bool SetAutoGain (bool p0)
		{
			if (id_SetAutoGain_Z == IntPtr.Zero)
				id_SetAutoGain_Z = JNIEnv.GetMethodID (class_ref, "SetAutoGain", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetAutoGain_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetAutoGain", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Z;
#pragma warning disable 0169
		static Delegate GetSetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZHandler ()
		{
			if (cb_SetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Z == null)
				cb_SetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_SetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Z);
			return cb_SetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Z;
		}

		static bool n_SetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetEchoCancellation (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='SetEchoCancellation' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker'] and parameter[2][@type='boolean']]"
		[Register ("SetEchoCancellation", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Z)Z", "GetSetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZHandler")]
		public virtual unsafe bool SetEchoCancellation (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, bool p1)
		{
			if (id_SetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Z == IntPtr.Zero)
				id_SetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Z = JNIEnv.GetMethodID (class_ref, "SetEchoCancellation", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Z)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetEchoCancellation_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetEchoCancellation", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Z)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_;
#pragma warning disable 0169
		static Delegate GetSetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_Handler ()
		{
			if (cb_SetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_ == null)
				cb_SetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_);
			return cb_SetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_;
		}

		static bool n_SetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSignalType (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='SetSignalType' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType']]"
		[Register ("SetSignalType", "(Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;)Z", "GetSetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_Handler")]
		public virtual unsafe bool SetSignalType (global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType p0)
		{
			if (id_SetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_ == IntPtr.Zero)
				id_SetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_ = JNIEnv.GetMethodID (class_ref, "SetSignalType", "(Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetSignalType_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceAudioSignalType_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSignalType", "(Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceAudioSignalType;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetVoiceProcessing_Z;
#pragma warning disable 0169
		static Delegate GetSetVoiceProcessing_ZHandler ()
		{
			if (cb_SetVoiceProcessing_Z == null)
				cb_SetVoiceProcessing_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetVoiceProcessing_Z);
			return cb_SetVoiceProcessing_Z;
		}

		static bool n_SetVoiceProcessing_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetVoiceProcessing (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetVoiceProcessing_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='SetVoiceProcessing' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetVoiceProcessing", "(Z)Z", "GetSetVoiceProcessing_ZHandler")]
		public virtual unsafe bool SetVoiceProcessing (bool p0)
		{
			if (id_SetVoiceProcessing_Z == IntPtr.Zero)
				id_SetVoiceProcessing_Z = JNIEnv.GetMethodID (class_ref, "SetVoiceProcessing", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetVoiceProcessing_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetVoiceProcessing", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_ShowDebugDialog;
#pragma warning disable 0169
		static Delegate GetShowDebugDialogHandler ()
		{
			if (cb_ShowDebugDialog == null)
				cb_ShowDebugDialog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowDebugDialog);
			return cb_ShowDebugDialog;
		}

		static void n_ShowDebugDialog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowDebugDialog ();
		}
#pragma warning restore 0169

		static IntPtr id_ShowDebugDialog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='ShowDebugDialog' and count(parameter)=0]"
		[Register ("ShowDebugDialog", "()V", "GetShowDebugDialogHandler")]
		public virtual unsafe void ShowDebugDialog ()
		{
			if (id_ShowDebugDialog == IntPtr.Zero)
				id_ShowDebugDialog = JNIEnv.GetMethodID (class_ref, "ShowDebugDialog", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ShowDebugDialog);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowDebugDialog", "()V"));
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMicrophone']/method[@name='dispose' and count(parameter)=0]"
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
