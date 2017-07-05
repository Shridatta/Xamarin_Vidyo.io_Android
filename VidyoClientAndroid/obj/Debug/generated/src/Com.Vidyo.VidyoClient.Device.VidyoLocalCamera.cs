using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoLocalCamera", DoNotGenerateAcw=true)]
	public partial class VidyoLocalCamera : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera.VidyoLocalCameraPosition']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition", DoNotGenerateAcw=true)]
		public sealed partial class VidyoLocalCameraPosition : global::Java.Lang.Enum {


			static IntPtr VIDYO_LOCALCAMERAPOSITION_Back_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera.VidyoLocalCameraPosition']/field[@name='VIDYO_LOCALCAMERAPOSITION_Back']"
			[Register ("VIDYO_LOCALCAMERAPOSITION_Back")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition VIDYOLOCALCAMERAPOSITIONBack {
				get {
					if (VIDYO_LOCALCAMERAPOSITION_Back_jfieldId == IntPtr.Zero)
						VIDYO_LOCALCAMERAPOSITION_Back_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOCALCAMERAPOSITION_Back", "Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOCALCAMERAPOSITION_Back_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOCALCAMERAPOSITION_Front_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera.VidyoLocalCameraPosition']/field[@name='VIDYO_LOCALCAMERAPOSITION_Front']"
			[Register ("VIDYO_LOCALCAMERAPOSITION_Front")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition VIDYOLOCALCAMERAPOSITIONFront {
				get {
					if (VIDYO_LOCALCAMERAPOSITION_Front_jfieldId == IntPtr.Zero)
						VIDYO_LOCALCAMERAPOSITION_Front_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOCALCAMERAPOSITION_Front", "Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOCALCAMERAPOSITION_Front_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOCALCAMERAPOSITION_Unknown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera.VidyoLocalCameraPosition']/field[@name='VIDYO_LOCALCAMERAPOSITION_Unknown']"
			[Register ("VIDYO_LOCALCAMERAPOSITION_Unknown")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition VIDYOLOCALCAMERAPOSITIONUnknown {
				get {
					if (VIDYO_LOCALCAMERAPOSITION_Unknown_jfieldId == IntPtr.Zero)
						VIDYO_LOCALCAMERAPOSITION_Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOCALCAMERAPOSITION_Unknown", "Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOCALCAMERAPOSITION_Unknown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoLocalCameraPosition); }
			}

			internal VidyoLocalCameraPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera.VidyoLocalCameraPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera.VidyoLocalCameraPosition']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition;");
				try {
					return (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoLocalCamera", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoLocalCamera); }
		}

		protected VidyoLocalCamera (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/constructor[@name='VidyoLocalCamera' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoLocalCamera (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoLocalCamera)) {
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='GetId' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_IsPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='IsPaused' and count(parameter)=0]"
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

		static Delegate cb_IsSuspended;
#pragma warning disable 0169
		static Delegate GetIsSuspendedHandler ()
		{
			if (cb_IsSuspended == null)
				cb_IsSuspended = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuspended);
			return cb_IsSuspended;
		}

		static bool n_IsSuspended (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuspended;
		}
#pragma warning restore 0169

		static IntPtr id_IsSuspended;
		public virtual unsafe bool IsSuspended {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='IsSuspended' and count(parameter)=0]"
			[Register ("IsSuspended", "()Z", "GetIsSuspendedHandler")]
			get {
				if (id_IsSuspended == IntPtr.Zero)
					id_IsSuspended = JNIEnv.GetMethodID (class_ref, "IsSuspended", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsSuspended);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsSuspended", "()Z"));
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_GetName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='GetName' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='GetObjectPtr' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static IntPtr id_GetPosition;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='GetPosition' and count(parameter)=0]"
			[Register ("GetPosition", "()Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition;", "GetGetPositionHandler")]
			get {
				if (id_GetPosition == IntPtr.Zero)
					id_GetPosition = JNIEnv.GetMethodID (class_ref, "GetPosition", "()Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetPosition), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera.VidyoLocalCameraPosition> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPosition", "()Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera$VidyoLocalCameraPosition;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetPreviewLabel;
#pragma warning disable 0169
		static Delegate GetGetPreviewLabelHandler ()
		{
			if (cb_GetPreviewLabel == null)
				cb_GetPreviewLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreviewLabel);
			return cb_GetPreviewLabel;
		}

		static IntPtr n_GetPreviewLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PreviewLabel);
		}
#pragma warning restore 0169

		static IntPtr id_GetPreviewLabel;
		public virtual unsafe string PreviewLabel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='GetPreviewLabel' and count(parameter)=0]"
			[Register ("GetPreviewLabel", "()Ljava/lang/String;", "GetGetPreviewLabelHandler")]
			get {
				if (id_GetPreviewLabel == IntPtr.Zero)
					id_GetPreviewLabel = JNIEnv.GetMethodID (class_ref, "GetPreviewLabel", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetPreviewLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPreviewLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
		static Delegate GetAddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
		{
			if (cb_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
				cb_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
			return cb_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		}

		static long n_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.AddToLocalRenderer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='AddToLocalRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
		[Register ("AddToLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)J", "GetAddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler")]
		public virtual unsafe long AddToLocalRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
		{
			if (id_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
				id_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "AddToLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddToLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_;
#pragma warning disable 0169
		static Delegate GetAddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Handler ()
		{
			if (cb_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_ == null)
				cb_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_);
			return cb_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_;
		}

		static bool n_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddToRemoteRenderer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='AddToRemoteRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteRenderer']]"
		[Register ("AddToRemoteRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;)Z", "GetAddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Handler")]
		public virtual unsafe bool AddToRemoteRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0)
		{
			if (id_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_ == IntPtr.Zero)
				id_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_ = JNIEnv.GetMethodID (class_ref, "AddToRemoteRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddToRemoteRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_AllowRemoteCameraControl_Z;
#pragma warning disable 0169
		static Delegate GetAllowRemoteCameraControl_ZHandler ()
		{
			if (cb_AllowRemoteCameraControl_Z == null)
				cb_AllowRemoteCameraControl_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_AllowRemoteCameraControl_Z);
			return cb_AllowRemoteCameraControl_Z;
		}

		static bool n_AllowRemoteCameraControl_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowRemoteCameraControl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_AllowRemoteCameraControl_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='AllowRemoteCameraControl' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("AllowRemoteCameraControl", "(Z)Z", "GetAllowRemoteCameraControl_ZHandler")]
		public virtual unsafe bool AllowRemoteCameraControl (bool p0)
		{
			if (id_AllowRemoteCameraControl_Z == IntPtr.Zero)
				id_AllowRemoteCameraControl_Z = JNIEnv.GetMethodID (class_ref, "AllowRemoteCameraControl", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AllowRemoteCameraControl_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AllowRemoteCameraControl", "(Z)Z"), __args);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ControlPTZ (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_ControlPTZ_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='ControlPTZ' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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

		static Delegate cb_GetVideoCapabilities_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetVideoCapabilities_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetVideoCapabilities_Ljava_util_ArrayList_ == null)
				cb_GetVideoCapabilities_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetVideoCapabilities_Ljava_util_ArrayList_);
			return cb_GetVideoCapabilities_Ljava_util_ArrayList_;
		}

		static bool n_GetVideoCapabilities_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetVideoCapabilities (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetVideoCapabilities_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='GetVideoCapabilities' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoVideoCapability&gt;']]"
		[Register ("GetVideoCapabilities", "(Ljava/util/ArrayList;)Z", "GetGetVideoCapabilities_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool GetVideoCapabilities (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability> p0)
		{
			if (id_GetVideoCapabilities_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetVideoCapabilities_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetVideoCapabilities", "(Ljava/util/ArrayList;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetVideoCapabilities_Ljava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetVideoCapabilities", "(Ljava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFromLocalRenderer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='RemoveFromLocalRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
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

		static Delegate cb_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_;
#pragma warning disable 0169
		static Delegate GetRemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Handler ()
		{
			if (cb_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_ == null)
				cb_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_);
			return cb_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_;
		}

		static bool n_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFromRemoteRenderer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='RemoveFromRemoteRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteRenderer']]"
		[Register ("RemoveFromRemoteRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;)Z", "GetRemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Handler")]
		public virtual unsafe bool RemoveFromRemoteRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0)
		{
			if (id_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_ == IntPtr.Zero)
				id_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_ = JNIEnv.GetMethodID (class_ref, "RemoveFromRemoteRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveFromRemoteRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;)Z"), __args);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_Resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='Resume' and count(parameter)=0]"
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

		static Delegate cb_SetAspectRatioConstraint_II;
#pragma warning disable 0169
		static Delegate GetSetAspectRatioConstraint_IIHandler ()
		{
			if (cb_SetAspectRatioConstraint_II == null)
				cb_SetAspectRatioConstraint_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_SetAspectRatioConstraint_II);
			return cb_SetAspectRatioConstraint_II;
		}

		static bool n_SetAspectRatioConstraint_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetAspectRatioConstraint (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_SetAspectRatioConstraint_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='SetAspectRatioConstraint' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("SetAspectRatioConstraint", "(II)Z", "GetSetAspectRatioConstraint_IIHandler")]
		public virtual unsafe bool SetAspectRatioConstraint (int p0, int p1)
		{
			if (id_SetAspectRatioConstraint_II == IntPtr.Zero)
				id_SetAspectRatioConstraint_II = JNIEnv.GetMethodID (class_ref, "SetAspectRatioConstraint", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetAspectRatioConstraint_II, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetAspectRatioConstraint", "(II)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetBoundsConstraint_IIIIJJIII;
#pragma warning disable 0169
		static Delegate GetSetBoundsConstraint_IIIIJJIIIHandler ()
		{
			if (cb_SetBoundsConstraint_IIIIJJIII == null)
				cb_SetBoundsConstraint_IIIIJJIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, long, long, int, int, int, bool>) n_SetBoundsConstraint_IIIIJJIII);
			return cb_SetBoundsConstraint_IIIIJJIII;
		}

		static bool n_SetBoundsConstraint_IIIIJJIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, long p4, long p5, int p6, int p7, int p8)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetBoundsConstraint (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		static IntPtr id_SetBoundsConstraint_IIIIJJIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='SetBoundsConstraint' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("SetBoundsConstraint", "(IIIIJJIII)Z", "GetSetBoundsConstraint_IIIIJJIIIHandler")]
		public virtual unsafe bool SetBoundsConstraint (int p0, int p1, int p2, int p3, long p4, long p5, int p6, int p7, int p8)
		{
			if (id_SetBoundsConstraint_IIIIJJIII == IntPtr.Zero)
				id_SetBoundsConstraint_IIIIJJIII = JNIEnv.GetMethodID (class_ref, "SetBoundsConstraint", "(IIIIJJIII)Z");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetBoundsConstraint_IIIIJJIII, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetBoundsConstraint", "(IIIIJJIII)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetCapabilitiesConstraint_Ljava_util_ArrayList_I;
#pragma warning disable 0169
		static Delegate GetSetCapabilitiesConstraint_Ljava_util_ArrayList_IHandler ()
		{
			if (cb_SetCapabilitiesConstraint_Ljava_util_ArrayList_I == null)
				cb_SetCapabilitiesConstraint_Ljava_util_ArrayList_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_SetCapabilitiesConstraint_Ljava_util_ArrayList_I);
			return cb_SetCapabilitiesConstraint_Ljava_util_ArrayList_I;
		}

		static bool n_SetCapabilitiesConstraint_Ljava_util_ArrayList_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetCapabilitiesConstraint (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetCapabilitiesConstraint_Ljava_util_ArrayList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='SetCapabilitiesConstraint' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoVideoCapability&gt;'] and parameter[2][@type='int']]"
		[Register ("SetCapabilitiesConstraint", "(Ljava/util/ArrayList;I)Z", "GetSetCapabilitiesConstraint_Ljava_util_ArrayList_IHandler")]
		public virtual unsafe bool SetCapabilitiesConstraint (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability> p0, int p1)
		{
			if (id_SetCapabilitiesConstraint_Ljava_util_ArrayList_I == IntPtr.Zero)
				id_SetCapabilitiesConstraint_Ljava_util_ArrayList_I = JNIEnv.GetMethodID (class_ref, "SetCapabilitiesConstraint", "(Ljava/util/ArrayList;I)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetCapabilitiesConstraint_Ljava_util_ArrayList_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCapabilitiesConstraint", "(Ljava/util/ArrayList;I)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SetConstraints_IIIIIIIIILjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetConstraints_IIIIIIIIILjava_util_ArrayList_Handler ()
		{
			if (cb_SetConstraints_IIIIIIIIILjava_util_ArrayList_ == null)
				cb_SetConstraints_IIIIIIIIILjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, int, int, int, int, IntPtr, bool>) n_SetConstraints_IIIIIIIIILjava_util_ArrayList_);
			return cb_SetConstraints_IIIIIIIIILjava_util_ArrayList_;
		}

		static bool n_SetConstraints_IIIIIIIIILjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, IntPtr native_p9)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p9 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability>.FromJniHandle (native_p9, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetConstraints (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetConstraints_IIIIIIIIILjava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='SetConstraints' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoVideoCapability&gt;']]"
		[Register ("SetConstraints", "(IIIIIIIIILjava/util/ArrayList;)Z", "GetSetConstraints_IIIIIIIIILjava_util_ArrayList_Handler")]
		public virtual unsafe bool SetConstraints (int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability> p9)
		{
			if (id_SetConstraints_IIIIIIIIILjava_util_ArrayList_ == IntPtr.Zero)
				id_SetConstraints_IIIIIIIIILjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "SetConstraints", "(IIIIIIIIILjava/util/ArrayList;)Z");
			IntPtr native_p9 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability>.ToLocalJniHandle (p9);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (native_p9);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetConstraints_IIIIIIIIILjava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetConstraints", "(IIIIIIIIILjava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p9);
			}
		}

		static Delegate cb_SetMaxConstraint_IIJ;
#pragma warning disable 0169
		static Delegate GetSetMaxConstraint_IIJHandler ()
		{
			if (cb_SetMaxConstraint_IIJ == null)
				cb_SetMaxConstraint_IIJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, long, bool>) n_SetMaxConstraint_IIJ);
			return cb_SetMaxConstraint_IIJ;
		}

		static bool n_SetMaxConstraint_IIJ (IntPtr jnienv, IntPtr native__this, int p0, int p1, long p2)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetMaxConstraint (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_SetMaxConstraint_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='SetMaxConstraint' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("SetMaxConstraint", "(IIJ)Z", "GetSetMaxConstraint_IIJHandler")]
		public virtual unsafe bool SetMaxConstraint (int p0, int p1, long p2)
		{
			if (id_SetMaxConstraint_IIJ == IntPtr.Zero)
				id_SetMaxConstraint_IIJ = JNIEnv.GetMethodID (class_ref, "SetMaxConstraint", "(IIJ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetMaxConstraint_IIJ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMaxConstraint", "(IIJ)Z"), __args);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetPositionInLocalRenderer (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetPositionInLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_IIIIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='SetPositionInLocalRenderer' and count(parameter)=6 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='long']]"
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

		static Delegate cb_SetPreviewLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPreviewLabel_Ljava_lang_String_Handler ()
		{
			if (cb_SetPreviewLabel_Ljava_lang_String_ == null)
				cb_SetPreviewLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetPreviewLabel_Ljava_lang_String_);
			return cb_SetPreviewLabel_Ljava_lang_String_;
		}

		static bool n_SetPreviewLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetPreviewLabel (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetPreviewLabel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='SetPreviewLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetPreviewLabel", "(Ljava/lang/String;)Z", "GetSetPreviewLabel_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetPreviewLabel (string p0)
		{
			if (id_SetPreviewLabel_Ljava_lang_String_ == IntPtr.Zero)
				id_SetPreviewLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetPreviewLabel", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetPreviewLabel_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPreviewLabel", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowCameraControl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_ShowCameraControl_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='ShowCameraControl' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalCamera']/method[@name='dispose' and count(parameter)=0]"
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
