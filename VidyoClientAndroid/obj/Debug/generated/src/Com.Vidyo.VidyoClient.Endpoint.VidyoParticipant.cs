using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoParticipant", DoNotGenerateAcw=true)]
	public partial class VidyoParticipant : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoParticipant", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoParticipant); }
		}

		protected VidyoParticipant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/constructor[@name='VidyoParticipant' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoParticipant (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoParticipant)) {
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/method[@name='GetId' and count(parameter)=0]"
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

		static Delegate cb_IsHidden;
#pragma warning disable 0169
		static Delegate GetIsHiddenHandler ()
		{
			if (cb_IsHidden == null)
				cb_IsHidden = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHidden);
			return cb_IsHidden;
		}

		static bool n_IsHidden (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHidden;
		}
#pragma warning restore 0169

		static IntPtr id_IsHidden;
		public virtual unsafe bool IsHidden {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/method[@name='IsHidden' and count(parameter)=0]"
			[Register ("IsHidden", "()Z", "GetIsHiddenHandler")]
			get {
				if (id_IsHidden == IntPtr.Zero)
					id_IsHidden = JNIEnv.GetMethodID (class_ref, "IsHidden", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsHidden);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsHidden", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_IsLocal;
#pragma warning disable 0169
		static Delegate GetIsLocalHandler ()
		{
			if (cb_IsLocal == null)
				cb_IsLocal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocal);
			return cb_IsLocal;
		}

		static bool n_IsLocal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocal;
		}
#pragma warning restore 0169

		static IntPtr id_IsLocal;
		public virtual unsafe bool IsLocal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/method[@name='IsLocal' and count(parameter)=0]"
			[Register ("IsLocal", "()Z", "GetIsLocalHandler")]
			get {
				if (id_IsLocal == IntPtr.Zero)
					id_IsLocal = JNIEnv.GetMethodID (class_ref, "IsLocal", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsLocal);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsLocal", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_IsRecording;
#pragma warning disable 0169
		static Delegate GetIsRecordingHandler ()
		{
			if (cb_IsRecording == null)
				cb_IsRecording = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRecording);
			return cb_IsRecording;
		}

		static bool n_IsRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRecording;
		}
#pragma warning restore 0169

		static IntPtr id_IsRecording;
		public virtual unsafe bool IsRecording {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/method[@name='IsRecording' and count(parameter)=0]"
			[Register ("IsRecording", "()Z", "GetIsRecordingHandler")]
			get {
				if (id_IsRecording == IntPtr.Zero)
					id_IsRecording = JNIEnv.GetMethodID (class_ref, "IsRecording", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsRecording);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsRecording", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_IsSelectable;
#pragma warning disable 0169
		static Delegate GetIsSelectableHandler ()
		{
			if (cb_IsSelectable == null)
				cb_IsSelectable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSelectable);
			return cb_IsSelectable;
		}

		static bool n_IsSelectable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelectable;
		}
#pragma warning restore 0169

		static IntPtr id_IsSelectable;
		public virtual unsafe bool IsSelectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/method[@name='IsSelectable' and count(parameter)=0]"
			[Register ("IsSelectable", "()Z", "GetIsSelectableHandler")]
			get {
				if (id_IsSelectable == IntPtr.Zero)
					id_IsSelectable = JNIEnv.GetMethodID (class_ref, "IsSelectable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsSelectable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsSelectable", "()Z"));
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_GetName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/method[@name='GetName' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_GetUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_GetUserId == null)
				cb_GetUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_GetUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		static IntPtr id_GetUserId;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/method[@name='GetUserId' and count(parameter)=0]"
			[Register ("GetUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				if (id_GetUserId == IntPtr.Zero)
					id_GetUserId = JNIEnv.GetMethodID (class_ref, "GetUserId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetUserId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetUserId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
#pragma warning disable 0169
		static Delegate GetGetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler ()
		{
			if (cb_GetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == null)
				cb_GetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_);
			return cb_GetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
		}

		static IntPtr n_GetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetContact (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/method[@name='GetContact' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact']]"
		[Register ("GetContact", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;", "GetGetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler")]
		public virtual unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact GetContact (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0)
		{
			if (id_GetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == IntPtr.Zero)
				id_GetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNIEnv.GetMethodID (class_ref, "GetContact", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetContact", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoParticipant']/method[@name='dispose' and count(parameter)=0]"
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
