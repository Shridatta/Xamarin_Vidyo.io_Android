using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoLocalMonitor", DoNotGenerateAcw=true)]
	public partial class VidyoLocalMonitor : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/interface[@name='VidyoLocalMonitor.IGetPreviewFrameDataUriAsync']"
		[Register ("com/vidyo/VidyoClient/Device/VidyoLocalMonitor$IGetPreviewFrameDataUriAsync", "", "Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor/IGetPreviewFrameDataUriAsyncInvoker")]
		public partial interface IGetPreviewFrameDataUriAsync : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/interface[@name='VidyoLocalMonitor.IGetPreviewFrameDataUriAsync']/method[@name='OnPreviewDataUriComplete' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState']]"
			[Register ("OnPreviewDataUriComplete", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;)V", "GetOnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_Handler:Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor/IGetPreviewFrameDataUriAsyncInvoker, VidyoClientAndroid")]
			void OnPreviewDataUriComplete (string p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoLocalMonitor$IGetPreviewFrameDataUriAsync", DoNotGenerateAcw=true)]
		internal class IGetPreviewFrameDataUriAsyncInvoker : global::Java.Lang.Object, IGetPreviewFrameDataUriAsync {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoLocalMonitor$IGetPreviewFrameDataUriAsync");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGetPreviewFrameDataUriAsyncInvoker); }
			}

			IntPtr class_ref;

			public static IGetPreviewFrameDataUriAsync GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGetPreviewFrameDataUriAsync> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Device.VidyoLocalMonitor.IGetPreviewFrameDataUriAsync"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGetPreviewFrameDataUriAsyncInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_;
#pragma warning disable 0169
			static Delegate GetOnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_Handler ()
			{
				if (cb_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_ == null)
					cb_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_);
				return cb_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_;
			}

			static void n_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.IGetPreviewFrameDataUriAsync __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.IGetPreviewFrameDataUriAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnPreviewDataUriComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_;
			public unsafe void OnPreviewDataUriComplete (string p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState p1)
			{
				if (id_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_ == IntPtr.Zero)
					id_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_ = JNIEnv.GetMethodID (class_ref, "OnPreviewDataUriComplete", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor.VidyoLocalMonitorState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoLocalMonitorState : global::Java.Lang.Enum {


			static IntPtr VIDYO_LOCALMONITORSTATE_MiscError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor.VidyoLocalMonitorState']/field[@name='VIDYO_LOCALMONITORSTATE_MiscError']"
			[Register ("VIDYO_LOCALMONITORSTATE_MiscError")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState VIDYOLOCALMONITORSTATEMiscError {
				get {
					if (VIDYO_LOCALMONITORSTATE_MiscError_jfieldId == IntPtr.Zero)
						VIDYO_LOCALMONITORSTATE_MiscError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOCALMONITORSTATE_MiscError", "Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOCALMONITORSTATE_MiscError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOCALMONITORSTATE_NotVisible_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor.VidyoLocalMonitorState']/field[@name='VIDYO_LOCALMONITORSTATE_NotVisible']"
			[Register ("VIDYO_LOCALMONITORSTATE_NotVisible")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState VIDYOLOCALMONITORSTATENotVisible {
				get {
					if (VIDYO_LOCALMONITORSTATE_NotVisible_jfieldId == IntPtr.Zero)
						VIDYO_LOCALMONITORSTATE_NotVisible_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOCALMONITORSTATE_NotVisible", "Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOCALMONITORSTATE_NotVisible_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOCALMONITORSTATE_Ok_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor.VidyoLocalMonitorState']/field[@name='VIDYO_LOCALMONITORSTATE_Ok']"
			[Register ("VIDYO_LOCALMONITORSTATE_Ok")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState VIDYOLOCALMONITORSTATEOk {
				get {
					if (VIDYO_LOCALMONITORSTATE_Ok_jfieldId == IntPtr.Zero)
						VIDYO_LOCALMONITORSTATE_Ok_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOCALMONITORSTATE_Ok", "Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOCALMONITORSTATE_Ok_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoLocalMonitorState); }
			}

			internal VidyoLocalMonitorState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor.VidyoLocalMonitorState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor.VidyoLocalMonitorState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;");
				try {
					return (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoLocalMonitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoLocalMonitor); }
		}

		protected VidyoLocalMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/constructor[@name='VidyoLocalMonitor' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoLocalMonitor (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoLocalMonitor)) {
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='GetId' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_GetName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='GetName' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='GetObjectPtr' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.AddToLocalRenderer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddToLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='AddToLocalRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddToRemoteRenderer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddToRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='AddToRemoteRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteRenderer']]"
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

		static Delegate cb_ClearConstraints;
#pragma warning disable 0169
		static Delegate GetClearConstraintsHandler ()
		{
			if (cb_ClearConstraints == null)
				cb_ClearConstraints = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearConstraints);
			return cb_ClearConstraints;
		}

		static void n_ClearConstraints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearConstraints ();
		}
#pragma warning restore 0169

		static IntPtr id_ClearConstraints;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='ClearConstraints' and count(parameter)=0]"
		[Register ("ClearConstraints", "()V", "GetClearConstraintsHandler")]
		public virtual unsafe void ClearConstraints ()
		{
			if (id_ClearConstraints == IntPtr.Zero)
				id_ClearConstraints = JNIEnv.GetMethodID (class_ref, "ClearConstraints", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ClearConstraints);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ClearConstraints", "()V"));
			} finally {
			}
		}

		static Delegate cb_GetPreviewFrameDataUri_JJLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPreviewFrameDataUri_JJLjava_lang_String_Handler ()
		{
			if (cb_GetPreviewFrameDataUri_JJLjava_lang_String_ == null)
				cb_GetPreviewFrameDataUri_JJLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr, IntPtr>) n_GetPreviewFrameDataUri_JJLjava_lang_String_);
			return cb_GetPreviewFrameDataUri_JJLjava_lang_String_;
		}

		static IntPtr n_GetPreviewFrameDataUri_JJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPreviewFrameDataUri (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetPreviewFrameDataUri_JJLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='GetPreviewFrameDataUri' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
		[Register ("GetPreviewFrameDataUri", "(JJLjava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;", "GetGetPreviewFrameDataUri_JJLjava_lang_String_Handler")]
		public virtual unsafe global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState GetPreviewFrameDataUri (long p0, long p1, string p2)
		{
			if (id_GetPreviewFrameDataUri_JJLjava_lang_String_ == IntPtr.Zero)
				id_GetPreviewFrameDataUri_JJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetPreviewFrameDataUri", "(JJLjava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetPreviewFrameDataUri_JJLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPreviewFrameDataUri", "(JJLjava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_GetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_;
#pragma warning disable 0169
		static Delegate GetGetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_Handler ()
		{
			if (cb_GetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_ == null)
				cb_GetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr, bool>) n_GetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_);
			return cb_GetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_;
		}

		static bool n_GetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.IGetPreviewFrameDataUriAsync p2 = (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.IGetPreviewFrameDataUriAsync)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.IGetPreviewFrameDataUriAsync> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetPreviewFrameDataUriAsync (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='GetPreviewFrameDataUriAsync' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor.IGetPreviewFrameDataUriAsync']]"
		[Register ("GetPreviewFrameDataUriAsync", "(JJLcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$IGetPreviewFrameDataUriAsync;)Z", "GetGetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_Handler")]
		public virtual unsafe bool GetPreviewFrameDataUriAsync (long p0, long p1, global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.IGetPreviewFrameDataUriAsync p2)
		{
			if (id_GetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_ == IntPtr.Zero)
				id_GetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_ = JNIEnv.GetMethodID (class_ref, "GetPreviewFrameDataUriAsync", "(JJLcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$IGetPreviewFrameDataUriAsync;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetPreviewFrameDataUriAsync_JJLcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_IGetPreviewFrameDataUriAsync_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPreviewFrameDataUriAsync", "(JJLcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$IGetPreviewFrameDataUriAsync;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_;
#pragma warning disable 0169
		static Delegate GetOnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_Handler ()
		{
			if (cb_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_ == null)
				cb_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_);
			return cb_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_;
		}

		static void n_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPreviewDataUriComplete (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='OnPreviewDataUriComplete' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState']]"
		[Register ("OnPreviewDataUriComplete", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;)V", "GetOnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_Handler")]
		public virtual unsafe void OnPreviewDataUriComplete (string p0, global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor.VidyoLocalMonitorState p1)
		{
			if (id_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_ == IntPtr.Zero)
				id_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_ = JNIEnv.GetMethodID (class_ref, "OnPreviewDataUriComplete", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnPreviewDataUriComplete_Ljava_lang_String_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_VidyoLocalMonitorState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPreviewDataUriComplete", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor$VidyoLocalMonitorState;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_PrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
		static Delegate GetPrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
		{
			if (cb_PrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
				cb_PrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
			return cb_PrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		}

		static void n_PrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrecludeWindow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_PrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='PrecludeWindow' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
		[Register ("PrecludeWindow", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetPrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler")]
		public virtual unsafe void PrecludeWindow (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
		{
			if (id_PrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
				id_PrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "PrecludeWindow", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PrecludeWindow_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "PrecludeWindow", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V"), __args);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFromLocalRenderer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveFromLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='RemoveFromLocalRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFromRemoteRenderer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveFromRemoteRenderer_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='RemoveFromRemoteRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoRemoteRenderer']]"
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

		static Delegate cb_SetBoundsConstraints_JJIIII;
#pragma warning disable 0169
		static Delegate GetSetBoundsConstraints_JJIIIIHandler ()
		{
			if (cb_SetBoundsConstraints_JJIIII == null)
				cb_SetBoundsConstraints_JJIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, int, int, int, int, bool>) n_SetBoundsConstraints_JJIIII);
			return cb_SetBoundsConstraints_JJIIII;
		}

		static bool n_SetBoundsConstraints_JJIIII (IntPtr jnienv, IntPtr native__this, long p0, long p1, int p2, int p3, int p4, int p5)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetBoundsConstraints (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_SetBoundsConstraints_JJIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='SetBoundsConstraints' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("SetBoundsConstraints", "(JJIIII)Z", "GetSetBoundsConstraints_JJIIIIHandler")]
		public virtual unsafe bool SetBoundsConstraints (long p0, long p1, int p2, int p3, int p4, int p5)
		{
			if (id_SetBoundsConstraints_JJIIII == IntPtr.Zero)
				id_SetBoundsConstraints_JJIIII = JNIEnv.GetMethodID (class_ref, "SetBoundsConstraints", "(JJIIII)Z");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetBoundsConstraints_JJIIII, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetBoundsConstraints", "(JJIIII)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetCaptureInterval_J;
#pragma warning disable 0169
		static Delegate GetSetCaptureInterval_JHandler ()
		{
			if (cb_SetCaptureInterval_J == null)
				cb_SetCaptureInterval_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_SetCaptureInterval_J);
			return cb_SetCaptureInterval_J;
		}

		static bool n_SetCaptureInterval_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetCaptureInterval (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetCaptureInterval_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='SetCaptureInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("SetCaptureInterval", "(J)Z", "GetSetCaptureInterval_JHandler")]
		public virtual unsafe bool SetCaptureInterval (long p0)
		{
			if (id_SetCaptureInterval_J == IntPtr.Zero)
				id_SetCaptureInterval_J = JNIEnv.GetMethodID (class_ref, "SetCaptureInterval", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetCaptureInterval_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCaptureInterval", "(J)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetDiscrerteConstraints_JJIIF;
#pragma warning disable 0169
		static Delegate GetSetDiscrerteConstraints_JJIIFHandler ()
		{
			if (cb_SetDiscrerteConstraints_JJIIF == null)
				cb_SetDiscrerteConstraints_JJIIF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, int, int, float, bool>) n_SetDiscrerteConstraints_JJIIF);
			return cb_SetDiscrerteConstraints_JJIIF;
		}

		static bool n_SetDiscrerteConstraints_JJIIF (IntPtr jnienv, IntPtr native__this, long p0, long p1, int p2, int p3, float p4)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetDiscrerteConstraints (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_SetDiscrerteConstraints_JJIIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='SetDiscrerteConstraints' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float']]"
		[Register ("SetDiscrerteConstraints", "(JJIIF)Z", "GetSetDiscrerteConstraints_JJIIFHandler")]
		public virtual unsafe bool SetDiscrerteConstraints (long p0, long p1, int p2, int p3, float p4)
		{
			if (id_SetDiscrerteConstraints_JJIIF == IntPtr.Zero)
				id_SetDiscrerteConstraints_JJIIF = JNIEnv.GetMethodID (class_ref, "SetDiscrerteConstraints", "(JJIIF)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetDiscrerteConstraints_JJIIF, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetDiscrerteConstraints", "(JJIIF)Z"), __args);
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
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalMonitor']/method[@name='dispose' and count(parameter)=0]"
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
