using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoRemoteMicrophone", DoNotGenerateAcw=true)]
	public partial class VidyoRemoteMicrophone : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRemoteMicrophoneMode : global::Java.Lang.Enum {


			static IntPtr VIDYO_REMOTEMICROPHONEMODE_Dynamic_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode']/field[@name='VIDYO_REMOTEMICROPHONEMODE_Dynamic']"
			[Register ("VIDYO_REMOTEMICROPHONEMODE_Dynamic")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode VIDYOREMOTEMICROPHONEMODEDynamic {
				get {
					if (VIDYO_REMOTEMICROPHONEMODE_Dynamic_jfieldId == IntPtr.Zero)
						VIDYO_REMOTEMICROPHONEMODE_Dynamic_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_REMOTEMICROPHONEMODE_Dynamic", "Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_REMOTEMICROPHONEMODE_Dynamic_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_REMOTEMICROPHONEMODE_Static_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode']/field[@name='VIDYO_REMOTEMICROPHONEMODE_Static']"
			[Register ("VIDYO_REMOTEMICROPHONEMODE_Static")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode VIDYOREMOTEMICROPHONEMODEStatic {
				get {
					if (VIDYO_REMOTEMICROPHONEMODE_Static_jfieldId == IntPtr.Zero)
						VIDYO_REMOTEMICROPHONEMODE_Static_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_REMOTEMICROPHONEMODE_Static", "Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_REMOTEMICROPHONEMODE_Static_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRemoteMicrophoneMode); }
			}

			internal VidyoRemoteMicrophoneMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode;");
				try {
					return (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoRemoteMicrophone", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoRemoteMicrophone); }
		}

		protected VidyoRemoteMicrophone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone']/constructor[@name='VidyoRemoteMicrophone' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoRemoteMicrophone (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoRemoteMicrophone)) {
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
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone']/method[@name='GetId' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_GetName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone']/method[@name='GetName' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone']/method[@name='GetObjectPtr' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SignalType);
		}
#pragma warning restore 0169

		static IntPtr id_GetSignalType;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceAudioSignalType SignalType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone']/method[@name='GetSignalType' and count(parameter)=0]"
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

		static Delegate cb_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_;
#pragma warning disable 0169
		static Delegate GetAddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_Handler ()
		{
			if (cb_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_ == null)
				cb_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_);
			return cb_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_;
		}

		static bool n_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddToLocalSpeaker (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone']/method[@name='AddToLocalSpeaker' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode']]"
		[Register ("AddToLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode;)Z", "GetAddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_Handler")]
		public virtual unsafe bool AddToLocalSpeaker (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone.VidyoRemoteMicrophoneMode p1)
		{
			if (id_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_ == IntPtr.Zero)
				id_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_ = JNIEnv.GetMethodID (class_ref, "AddToLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AddToLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_VidyoRemoteMicrophoneMode_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddToLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone$VidyoRemoteMicrophoneMode;)Z"), __args);
				return __ret;
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
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFromLocalSpeaker (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveFromLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone']/method[@name='RemoveFromLocalSpeaker' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteMicrophone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteMicrophone']/method[@name='dispose' and count(parameter)=0]"
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
