using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoLocalSpeaker", DoNotGenerateAcw=true)]
	public partial class VidyoLocalSpeaker : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoLocalSpeaker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoLocalSpeaker); }
		}

		protected VidyoLocalSpeaker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/constructor[@name='VidyoLocalSpeaker' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoLocalSpeaker (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoLocalSpeaker)) {
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='GetId' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_IsPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='IsPaused' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_GetName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='GetName' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='GetObjectPtr' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Volume = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetVolume;
		static IntPtr id_SetVolume_I;
		public virtual unsafe int Volume {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='GetVolume' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='SetVolume' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_Pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='Pause' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlayTone (p0);
		}
#pragma warning restore 0169

		static IntPtr id_PlayTone_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='PlayTone' and count(parameter)=1 and parameter[1][@type='char']]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_Resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='Resume' and count(parameter)=0]"
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

		static Delegate cb_StopSound;
#pragma warning disable 0169
		static Delegate GetStopSoundHandler ()
		{
			if (cb_StopSound == null)
				cb_StopSound = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopSound);
			return cb_StopSound;
		}

		static void n_StopSound (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSound ();
		}
#pragma warning restore 0169

		static IntPtr id_StopSound;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='StopSound' and count(parameter)=0]"
		[Register ("StopSound", "()V", "GetStopSoundHandler")]
		public virtual unsafe void StopSound ()
		{
			if (id_StopSound == IntPtr.Zero)
				id_StopSound = JNIEnv.GetMethodID (class_ref, "StopSound", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_StopSound);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StopSound", "()V"));
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalSpeaker']/method[@name='dispose' and count(parameter)=0]"
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
