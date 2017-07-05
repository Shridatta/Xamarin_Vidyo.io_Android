using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoRemoteCamera", DoNotGenerateAcw=true)]
	public partial class VidyoRemoteCamera : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraMode']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRemoteCameraMode : global::Java.Lang.Enum {


			static IntPtr VIDYO_REMOTECAMERAMODE_Dynamic_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraMode']/field[@name='VIDYO_REMOTECAMERAMODE_Dynamic']"
			[Register ("VIDYO_REMOTECAMERAMODE_Dynamic")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode VIDYOREMOTECAMERAMODEDynamic {
				get {
					if (VIDYO_REMOTECAMERAMODE_Dynamic_jfieldId == IntPtr.Zero)
						VIDYO_REMOTECAMERAMODE_Dynamic_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_REMOTECAMERAMODE_Dynamic", "Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_REMOTECAMERAMODE_Dynamic_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_REMOTECAMERAMODE_Static_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraMode']/field[@name='VIDYO_REMOTECAMERAMODE_Static']"
			[Register ("VIDYO_REMOTECAMERAMODE_Static")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode VIDYOREMOTECAMERAMODEStatic {
				get {
					if (VIDYO_REMOTECAMERAMODE_Static_jfieldId == IntPtr.Zero)
						VIDYO_REMOTECAMERAMODE_Static_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_REMOTECAMERAMODE_Static", "Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_REMOTECAMERAMODE_Static_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRemoteCameraMode); }
			}

			internal VidyoRemoteCameraMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode;");
				try {
					return (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraPosition']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRemoteCameraPosition : global::Java.Lang.Enum {


			static IntPtr VIDYO_REMOTECAMERAPOSITION_Back_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraPosition']/field[@name='VIDYO_REMOTECAMERAPOSITION_Back']"
			[Register ("VIDYO_REMOTECAMERAPOSITION_Back")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition VIDYOREMOTECAMERAPOSITIONBack {
				get {
					if (VIDYO_REMOTECAMERAPOSITION_Back_jfieldId == IntPtr.Zero)
						VIDYO_REMOTECAMERAPOSITION_Back_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_REMOTECAMERAPOSITION_Back", "Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_REMOTECAMERAPOSITION_Back_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_REMOTECAMERAPOSITION_Front_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraPosition']/field[@name='VIDYO_REMOTECAMERAPOSITION_Front']"
			[Register ("VIDYO_REMOTECAMERAPOSITION_Front")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition VIDYOREMOTECAMERAPOSITIONFront {
				get {
					if (VIDYO_REMOTECAMERAPOSITION_Front_jfieldId == IntPtr.Zero)
						VIDYO_REMOTECAMERAPOSITION_Front_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_REMOTECAMERAPOSITION_Front", "Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_REMOTECAMERAPOSITION_Front_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_REMOTECAMERAPOSITION_Unknown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraPosition']/field[@name='VIDYO_REMOTECAMERAPOSITION_Unknown']"
			[Register ("VIDYO_REMOTECAMERAPOSITION_Unknown")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition VIDYOREMOTECAMERAPOSITIONUnknown {
				get {
					if (VIDYO_REMOTECAMERAPOSITION_Unknown_jfieldId == IntPtr.Zero)
						VIDYO_REMOTECAMERAPOSITION_Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_REMOTECAMERAPOSITION_Unknown", "Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_REMOTECAMERAPOSITION_Unknown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRemoteCameraPosition); }
			}

			internal VidyoRemoteCameraPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera.VidyoRemoteCameraPosition']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition;");
				try {
					return (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoRemoteCamera", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoRemoteCamera); }
		}

		protected VidyoRemoteCamera (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/constructor[@name='VidyoRemoteCamera' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoRemoteCamera (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoRemoteCamera)) {
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
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='GetId' and count(parameter)=0]"
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

		static Delegate cb_IsControllable;
#pragma warning disable 0169
		static Delegate GetIsControllableHandler ()
		{
			if (cb_IsControllable == null)
				cb_IsControllable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsControllable);
			return cb_IsControllable;
		}

		static bool n_IsControllable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsControllable;
		}
#pragma warning restore 0169

		static IntPtr id_IsControllable;
		public virtual unsafe bool IsControllable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='IsControllable' and count(parameter)=0]"
			[Register ("IsControllable", "()Z", "GetIsControllableHandler")]
			get {
				if (id_IsControllable == IntPtr.Zero)
					id_IsControllable = JNIEnv.GetMethodID (class_ref, "IsControllable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsControllable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsControllable", "()Z"));
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
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_GetName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='GetName' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_GetPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_GetPosition == null)
				cb_GetPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_GetPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static IntPtr id_GetPosition;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='GetPosition' and count(parameter)=0]"
			[Register ("GetPosition", "()Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition;", "GetGetPositionHandler")]
			get {
				if (id_GetPosition == IntPtr.Zero)
					id_GetPosition = JNIEnv.GetMethodID (class_ref, "GetPosition", "()Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetPosition), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraPosition> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPosition", "()Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraPosition;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_;
#pragma warning disable 0169
		static Delegate GetAddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_Handler ()
		{
			if (cb_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_ == null)
				cb_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_);
			return cb_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_;
		}

		static long n_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode> (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.AddToLocalRenderer (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='AddToLocalRenderer' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode']]"
		[Register ("AddToLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode;)J", "GetAddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_Handler")]
		public virtual unsafe long AddToLocalRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0, global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera.VidyoRemoteCameraMode p1)
		{
			if (id_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_ == IntPtr.Zero)
				id_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_ = JNIEnv.GetMethodID (class_ref, "AddToLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode;)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_VidyoRemoteCameraMode_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddToLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera$VidyoRemoteCameraMode;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_ControlPTZ_III;
#pragma warning disable 0169
		static Delegate GetControlPTZ_IIIHandler ()
		{
			if (cb_ControlPTZ_III == null)
				cb_ControlPTZ_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, bool>) n_ControlPTZ_III);
			return cb_ControlPTZ_III;
		}

		static bool n_ControlPTZ_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ControlPTZ (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_ControlPTZ_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='ControlPTZ' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ControlPTZ", "(III)Z", "GetControlPTZ_IIIHandler")]
		public virtual unsafe bool ControlPTZ (int p0, int p1, int p2)
		{
			if (id_ControlPTZ_III == IntPtr.Zero)
				id_ControlPTZ_III = JNIEnv.GetMethodID (class_ref, "ControlPTZ", "(III)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_ControlPTZ_III, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ControlPTZ", "(III)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_GetLocalRenderingStreamId_I;
#pragma warning disable 0169
		static Delegate GetGetLocalRenderingStreamId_IHandler ()
		{
			if (cb_GetLocalRenderingStreamId_I == null)
				cb_GetLocalRenderingStreamId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetLocalRenderingStreamId_I);
			return cb_GetLocalRenderingStreamId_I;
		}

		static long n_GetLocalRenderingStreamId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLocalRenderingStreamId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetLocalRenderingStreamId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='GetLocalRenderingStreamId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetLocalRenderingStreamId", "(I)J", "GetGetLocalRenderingStreamId_IHandler")]
		public virtual unsafe long GetLocalRenderingStreamId (int p0)
		{
			if (id_GetLocalRenderingStreamId_I == IntPtr.Zero)
				id_GetLocalRenderingStreamId_I = JNIEnv.GetMethodID (class_ref, "GetLocalRenderingStreamId", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_GetLocalRenderingStreamId_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetLocalRenderingStreamId", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
		static Delegate GetRemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
		{
			if (cb_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
				cb_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
			return cb_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		}

		static bool n_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFromLocalRenderer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='RemoveFromLocalRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
		[Register ("RemoveFromLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)Z", "GetRemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler")]
		public virtual unsafe bool RemoveFromLocalRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
		{
			if (id_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
				id_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "RemoveFromLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveFromLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ;
#pragma warning disable 0169
		static Delegate GetSetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJHandler ()
		{
			if (cb_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ == null)
				cb_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, long, bool>) n_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ);
			return cb_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ;
		}

		static bool n_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, long p5)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetPositionInLocalRenderer (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='SetPositionInLocalRenderer' and count(parameter)=6 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='long']]"
		[Register ("SetPositionInLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;IIIIJ)Z", "GetSetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJHandler")]
		public virtual unsafe bool SetPositionInLocalRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0, int p1, int p2, int p3, int p4, long p5)
		{
			if (id_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ == IntPtr.Zero)
				id_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ = JNIEnv.GetMethodID (class_ref, "SetPositionInLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;IIIIJ)Z");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPositionInLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;IIIIJ)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_ShowCameraControl_Z;
#pragma warning disable 0169
		static Delegate GetShowCameraControl_ZHandler ()
		{
			if (cb_ShowCameraControl_Z == null)
				cb_ShowCameraControl_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_ShowCameraControl_Z);
			return cb_ShowCameraControl_Z;
		}

		static bool n_ShowCameraControl_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowCameraControl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_ShowCameraControl_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='ShowCameraControl' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("ShowCameraControl", "(Z)Z", "GetShowCameraControl_ZHandler")]
		public virtual unsafe bool ShowCameraControl (bool p0)
		{
			if (id_ShowCameraControl_Z == IntPtr.Zero)
				id_ShowCameraControl_Z = JNIEnv.GetMethodID (class_ref, "ShowCameraControl", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_ShowCameraControl_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowCameraControl", "(Z)Z"), __args);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoRemoteCamera']/method[@name='dispose' and count(parameter)=0]"
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
