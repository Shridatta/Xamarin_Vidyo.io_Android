using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Meeting {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Meeting/VidyoMeeting", DoNotGenerateAcw=true)]
	public partial class VidyoMeeting : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting.VidyoMeetingFeedback']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Meeting/VidyoMeeting$VidyoMeetingFeedback", DoNotGenerateAcw=true)]
		public abstract partial class VidyoMeetingFeedback : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Meeting/VidyoMeeting$VidyoMeetingFeedback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoMeetingFeedback); }
			}

			protected VidyoMeetingFeedback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting.VidyoMeetingFeedback']/constructor[@name='VidyoMeeting.VidyoMeetingFeedback' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting']]"
			[Register (".ctor", "(Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;)V", "")]
			public unsafe VidyoMeetingFeedback (global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (VidyoMeetingFeedback)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_ == IntPtr.Zero)
						id_ctor_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_, __args);
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
				global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting.VidyoMeetingFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting.VidyoMeetingFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ObjectPtr;
			}
#pragma warning restore 0169

			static IntPtr id_GetObjectPtr;
			public virtual unsafe long ObjectPtr {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting.VidyoMeetingFeedback']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

			static Delegate cb_MeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
#pragma warning disable 0169
			static Delegate GetMeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler ()
			{
				if (cb_MeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ == null)
					cb_MeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_);
				return cb_MeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
			}

			static void n_MeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting.VidyoMeetingFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting.VidyoMeetingFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.MeetingAttendeeAdded (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting.VidyoMeetingFeedback']/method[@name='MeetingAttendeeAdded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee']]"
			[Register ("MeetingAttendeeAdded", "(Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)V", "GetMeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler")]
			public abstract void MeetingAttendeeAdded (global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p0, global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p1);

			static Delegate cb_MeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
#pragma warning disable 0169
			static Delegate GetMeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler ()
			{
				if (cb_MeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ == null)
					cb_MeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_);
				return cb_MeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
			}

			static void n_MeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting.VidyoMeetingFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting.VidyoMeetingFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.MeetingAttendeeRemoved (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting.VidyoMeetingFeedback']/method[@name='MeetingAttendeeRemoved' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee']]"
			[Register ("MeetingAttendeeRemoved", "(Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)V", "GetMeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler")]
			public abstract void MeetingAttendeeRemoved (global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p0, global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p1);

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
				global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting.VidyoMeetingFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting.VidyoMeetingFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Dispose ();
			}
#pragma warning restore 0169

			static IntPtr id_dispose;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting.VidyoMeetingFeedback']/method[@name='dispose' and count(parameter)=0]"
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

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Meeting/VidyoMeeting$VidyoMeetingFeedback", DoNotGenerateAcw=true)]
		internal partial class VidyoMeetingFeedbackInvoker : VidyoMeetingFeedback {

			public VidyoMeetingFeedbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoMeetingFeedbackInvoker); }
			}

			static IntPtr id_MeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting.VidyoMeetingFeedback']/method[@name='MeetingAttendeeAdded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee']]"
			[Register ("MeetingAttendeeAdded", "(Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)V", "GetMeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler")]
			public override unsafe void MeetingAttendeeAdded (global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p0, global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p1)
			{
				if (id_MeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ == IntPtr.Zero)
					id_MeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ = JNIEnv.GetMethodID (class_ref, "MeetingAttendeeAdded", "(Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_MeetingAttendeeAdded_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_, __args);
				} finally {
				}
			}

			static IntPtr id_MeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting.VidyoMeetingFeedback']/method[@name='MeetingAttendeeRemoved' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee']]"
			[Register ("MeetingAttendeeRemoved", "(Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)V", "GetMeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler")]
			public override unsafe void MeetingAttendeeRemoved (global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p0, global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p1)
			{
				if (id_MeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ == IntPtr.Zero)
					id_MeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ = JNIEnv.GetMethodID (class_ref, "MeetingAttendeeRemoved", "(Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_MeetingAttendeeRemoved_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_, __args);
				} finally {
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Meeting/VidyoMeeting", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoMeeting); }
		}

		protected VidyoMeeting (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/constructor[@name='VidyoMeeting' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoMeeting (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoMeeting)) {
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

		static Delegate cb_GetBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_GetBody == null)
				cb_GetBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_GetBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Body);
		}
#pragma warning restore 0169

		static IntPtr id_GetBody;
		public virtual unsafe string Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetBody' and count(parameter)=0]"
			[Register ("GetBody", "()Ljava/lang/String;", "GetGetBodyHandler")]
			get {
				if (id_GetBody == IntPtr.Zero)
					id_GetBody = JNIEnv.GetMethodID (class_ref, "GetBody", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetBody), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetBody", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetEndDateTime;
#pragma warning disable 0169
		static Delegate GetGetEndDateTimeHandler ()
		{
			if (cb_GetEndDateTime == null)
				cb_GetEndDateTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndDateTime);
			return cb_GetEndDateTime;
		}

		static IntPtr n_GetEndDateTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndDateTime);
		}
#pragma warning restore 0169

		static IntPtr id_GetEndDateTime;
		public virtual unsafe string EndDateTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetEndDateTime' and count(parameter)=0]"
			[Register ("GetEndDateTime", "()Ljava/lang/String;", "GetGetEndDateTimeHandler")]
			get {
				if (id_GetEndDateTime == IntPtr.Zero)
					id_GetEndDateTime = JNIEnv.GetMethodID (class_ref, "GetEndDateTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetEndDateTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetEndDateTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetId' and count(parameter)=0]"
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

		static Delegate cb_GetLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_GetLocation == null)
				cb_GetLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_GetLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Location);
		}
#pragma warning restore 0169

		static IntPtr id_GetLocation;
		public virtual unsafe string Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetLocation' and count(parameter)=0]"
			[Register ("GetLocation", "()Ljava/lang/String;", "GetGetLocationHandler")]
			get {
				if (id_GetLocation == IntPtr.Zero)
					id_GetLocation = JNIEnv.GetMethodID (class_ref, "GetLocation", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetLocation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetLocation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_GetOwnerEmail;
#pragma warning disable 0169
		static Delegate GetGetOwnerEmailHandler ()
		{
			if (cb_GetOwnerEmail == null)
				cb_GetOwnerEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwnerEmail);
			return cb_GetOwnerEmail;
		}

		static IntPtr n_GetOwnerEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OwnerEmail);
		}
#pragma warning restore 0169

		static IntPtr id_GetOwnerEmail;
		public virtual unsafe string OwnerEmail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetOwnerEmail' and count(parameter)=0]"
			[Register ("GetOwnerEmail", "()Ljava/lang/String;", "GetGetOwnerEmailHandler")]
			get {
				if (id_GetOwnerEmail == IntPtr.Zero)
					id_GetOwnerEmail = JNIEnv.GetMethodID (class_ref, "GetOwnerEmail", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetOwnerEmail), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetOwnerEmail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetOwnerName;
#pragma warning disable 0169
		static Delegate GetGetOwnerNameHandler ()
		{
			if (cb_GetOwnerName == null)
				cb_GetOwnerName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwnerName);
			return cb_GetOwnerName;
		}

		static IntPtr n_GetOwnerName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OwnerName);
		}
#pragma warning restore 0169

		static IntPtr id_GetOwnerName;
		public virtual unsafe string OwnerName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetOwnerName' and count(parameter)=0]"
			[Register ("GetOwnerName", "()Ljava/lang/String;", "GetGetOwnerNameHandler")]
			get {
				if (id_GetOwnerName == IntPtr.Zero)
					id_GetOwnerName = JNIEnv.GetMethodID (class_ref, "GetOwnerName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetOwnerName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetOwnerName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetStartDateTime;
#pragma warning disable 0169
		static Delegate GetGetStartDateTimeHandler ()
		{
			if (cb_GetStartDateTime == null)
				cb_GetStartDateTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartDateTime);
			return cb_GetStartDateTime;
		}

		static IntPtr n_GetStartDateTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StartDateTime);
		}
#pragma warning restore 0169

		static IntPtr id_GetStartDateTime;
		public virtual unsafe string StartDateTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetStartDateTime' and count(parameter)=0]"
			[Register ("GetStartDateTime", "()Ljava/lang/String;", "GetGetStartDateTimeHandler")]
			get {
				if (id_GetStartDateTime == IntPtr.Zero)
					id_GetStartDateTime = JNIEnv.GetMethodID (class_ref, "GetStartDateTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetStartDateTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetStartDateTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetSubject;
#pragma warning disable 0169
		static Delegate GetGetSubjectHandler ()
		{
			if (cb_GetSubject == null)
				cb_GetSubject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubject);
			return cb_GetSubject;
		}

		static IntPtr n_GetSubject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Subject);
		}
#pragma warning restore 0169

		static IntPtr id_GetSubject;
		public virtual unsafe string Subject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetSubject' and count(parameter)=0]"
			[Register ("GetSubject", "()Ljava/lang/String;", "GetGetSubjectHandler")]
			get {
				if (id_GetSubject == IntPtr.Zero)
					id_GetSubject = JNIEnv.GetMethodID (class_ref, "GetSubject", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetSubject), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSubject", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_GetType == null)
				cb_GetType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_GetType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_GetType;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetType' and count(parameter)=0]"
			[Register ("GetType", "()Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingType;", "GetGetTypeHandler")]
			get {
				if (id_GetType == IntPtr.Zero)
					id_GetType = JNIEnv.GetMethodID (class_ref, "GetType", "()Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetType", "()Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetVidyoMeetingRoomId;
#pragma warning disable 0169
		static Delegate GetGetVidyoMeetingRoomIdHandler ()
		{
			if (cb_GetVidyoMeetingRoomId == null)
				cb_GetVidyoMeetingRoomId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVidyoMeetingRoomId);
			return cb_GetVidyoMeetingRoomId;
		}

		static IntPtr n_GetVidyoMeetingRoomId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VidyoMeetingRoomId);
		}
#pragma warning restore 0169

		static IntPtr id_GetVidyoMeetingRoomId;
		public virtual unsafe string VidyoMeetingRoomId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetVidyoMeetingRoomId' and count(parameter)=0]"
			[Register ("GetVidyoMeetingRoomId", "()Ljava/lang/String;", "GetGetVidyoMeetingRoomIdHandler")]
			get {
				if (id_GetVidyoMeetingRoomId == IntPtr.Zero)
					id_GetVidyoMeetingRoomId = JNIEnv.GetMethodID (class_ref, "GetVidyoMeetingRoomId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetVidyoMeetingRoomId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetVidyoMeetingRoomId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_AddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
#pragma warning disable 0169
		static Delegate GetAddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler ()
		{
			if (cb_AddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ == null)
				cb_AddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_);
			return cb_AddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
		}

		static bool n_AddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAttendee (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='AddAttendee' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee']]"
		[Register ("AddAttendee", "(Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)Z", "GetAddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler")]
		public virtual unsafe bool AddAttendee (global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p0)
		{
			if (id_AddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ == IntPtr.Zero)
				id_AddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ = JNIEnv.GetMethodID (class_ref, "AddAttendee", "(Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AddAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAttendee", "(Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetAttendees_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetAttendees_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetAttendees_Ljava_util_ArrayList_ == null)
				cb_GetAttendees_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetAttendees_Ljava_util_ArrayList_);
			return cb_GetAttendees_Ljava_util_ArrayList_;
		}

		static bool n_GetAttendees_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetAttendees (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetAttendees_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetAttendees' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.VidyoMeetingAttendee&gt;']]"
		[Register ("GetAttendees", "(Ljava/util/ArrayList;)Z", "GetGetAttendees_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool GetAttendees (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee> p0)
		{
			if (id_GetAttendees_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetAttendees_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetAttendees", "(Ljava/util/ArrayList;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetAttendees_Ljava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAttendees", "(Ljava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_;
#pragma warning disable 0169
		static Delegate GetGetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_Handler ()
		{
			if (cb_GetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_ == null)
				cb_GetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_GetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_);
			return cb_GetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_;
		}

		static bool n_GetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetAttendeesByRole (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='GetAttendeesByRole' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.VidyoMeetingAttendee&gt;'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole']]"
		[Register ("GetAttendeesByRole", "(Ljava/util/ArrayList;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;)Z", "GetGetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_Handler")]
		public virtual unsafe bool GetAttendeesByRole (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee> p0, global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole p1)
		{
			if (id_GetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_ == IntPtr.Zero)
				id_GetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_ = JNIEnv.GetMethodID (class_ref, "GetAttendeesByRole", "(Ljava/util/ArrayList;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetAttendeesByRole_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationRole_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAttendeesByRole", "(Ljava/util/ArrayList;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_RemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
#pragma warning disable 0169
		static Delegate GetRemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler ()
		{
			if (cb_RemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ == null)
				cb_RemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_);
			return cb_RemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
		}

		static bool n_RemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAttendee (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='RemoveAttendee' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee']]"
		[Register ("RemoveAttendee", "(Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)Z", "GetRemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler")]
		public virtual unsafe bool RemoveAttendee (global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p0)
		{
			if (id_RemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ == IntPtr.Zero)
				id_RemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ = JNIEnv.GetMethodID (class_ref, "RemoveAttendee", "(Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RemoveAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveAttendee", "(Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_;
#pragma warning disable 0169
		static Delegate GetRespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_Handler ()
		{
			if (cb_RespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_ == null)
				cb_RespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_);
			return cb_RespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_;
		}

		static bool n_RespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RespondToInvite (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='RespondToInvite' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee'] and parameter[2][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']]"
		[Register ("RespondToInvite", "(Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;)Z", "GetRespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_Handler")]
		public virtual unsafe bool RespondToInvite (global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p0, global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus p1)
		{
			if (id_RespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_ == IntPtr.Zero)
				id_RespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_ = JNIEnv.GetMethodID (class_ref, "RespondToInvite", "(Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RespondToInvite_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_VidyoAttendeeParticipationStatus_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RespondToInvite", "(Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RetrieveBody;
#pragma warning disable 0169
		static Delegate GetRetrieveBodyHandler ()
		{
			if (cb_RetrieveBody == null)
				cb_RetrieveBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RetrieveBody);
			return cb_RetrieveBody;
		}

		static IntPtr n_RetrieveBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RetrieveBody ());
		}
#pragma warning restore 0169

		static IntPtr id_RetrieveBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='RetrieveBody' and count(parameter)=0]"
		[Register ("RetrieveBody", "()Ljava/lang/String;", "GetRetrieveBodyHandler")]
		public virtual unsafe string RetrieveBody ()
		{
			if (id_RetrieveBody == IntPtr.Zero)
				id_RetrieveBody = JNIEnv.GetMethodID (class_ref, "RetrieveBody", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_RetrieveBody), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RetrieveBody", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Meeting']/class[@name='VidyoMeeting']/method[@name='dispose' and count(parameter)=0]"
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
