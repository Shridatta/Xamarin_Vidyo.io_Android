using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarSchedule {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback", DoNotGenerateAcw=true)]
	public abstract partial class VidyoCalendarFeedback : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoCalendarFeedback); }
		}

		protected VidyoCalendarFeedback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/constructor[@name='VidyoCalendarFeedback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoCalendarFeedback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoCalendarFeedback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
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
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_ConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_;
#pragma warning disable 0169
		static Delegate GetConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Handler ()
		{
			if (cb_ConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_ == null)
				cb_ConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_);
			return cb_ConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_;
		}

		static void n_ConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ConnectResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='ConnectResult' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode']]"
		[Register ("ConnectResult", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarServiceCode;)V", "GetConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Handler")]
		public abstract void ConnectResult (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode p1);

		static Delegate cb_Disconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_;
#pragma warning disable 0169
		static Delegate GetDisconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Handler ()
		{
			if (cb_Disconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_ == null)
				cb_Disconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Disconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_);
			return cb_Disconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_;
		}

		static void n_Disconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Disconnected (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='Disconnected' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode']]"
		[Register ("Disconnected", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarServiceCode;)V", "GetDisconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Handler")]
		public abstract void Disconnected (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode p1);

		static Delegate cb_GetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_ == null)
				cb_GetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_);
			return cb_GetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_;
		}

		static void n_GetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoMeetingSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoMeetingSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetMeetingsResult (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='GetMeetingsResult' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoMeetingSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Meeting.VidyoMeeting&gt;']]"
		[Register ("GetMeetingsResult", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoMeetingSearchResult;Ljava/util/ArrayList;)V", "GetGetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_Handler")]
		public abstract void GetMeetingsResult (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoMeetingSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> p2);

		static Delegate cb_MeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_Handler ()
		{
			if (cb_MeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ == null)
				cb_MeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_);
			return cb_MeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_;
		}

		static void n_MeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.MeetingCreated (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingCreated' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.Meeting.VidyoMeetingActionResult'] and parameter[4][@type='java.lang.String']]"
		[Register ("MeetingCreated", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;Ljava/lang/String;)V", "GetMeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_Handler")]
		public abstract void MeetingCreated (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2, string p3);

		static Delegate cb_MeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
#pragma warning disable 0169
		static Delegate GetMeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler ()
		{
			if (cb_MeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ == null)
				cb_MeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_);
			return cb_MeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
		}

		static void n_MeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.MeetingCreatedByService (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingCreatedByService' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee']]"
		[Register ("MeetingCreatedByService", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)V", "GetMeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler")]
		public abstract void MeetingCreatedByService (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p2);

		static Delegate cb_MeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_;
#pragma warning disable 0169
		static Delegate GetMeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Handler ()
		{
			if (cb_MeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_ == null)
				cb_MeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_);
			return cb_MeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_;
		}

		static void n_MeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MeetingEventNotification (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingEventNotification' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting']]"
		[Register ("MeetingEventNotification", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;)V", "GetMeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Handler")]
		public abstract void MeetingEventNotification (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1);

		static Delegate cb_MeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_Handler ()
		{
			if (cb_MeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ == null)
				cb_MeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_);
			return cb_MeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_;
		}

		static void n_MeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.MeetingRemoved (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingRemoved' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.Meeting.VidyoMeetingActionResult'] and parameter[4][@type='java.lang.String']]"
		[Register ("MeetingRemoved", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;Ljava/lang/String;)V", "GetMeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_Handler")]
		public abstract void MeetingRemoved (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2, string p3);

		static Delegate cb_MeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_;
#pragma warning disable 0169
		static Delegate GetMeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Handler ()
		{
			if (cb_MeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_ == null)
				cb_MeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_);
			return cb_MeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_;
		}

		static void n_MeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.MeetingRemovedByService (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingRemovedByService' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.Meeting.VidyoMeetingActionResult']]"
		[Register ("MeetingRemovedByService", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;)V", "GetMeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Handler")]
		public abstract void MeetingRemovedByService (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2);

		static Delegate cb_MeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_Handler ()
		{
			if (cb_MeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ == null)
				cb_MeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_);
			return cb_MeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_;
		}

		static void n_MeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.MeetingUpdated (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingUpdated' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.Meeting.VidyoMeetingActionResult'] and parameter[4][@type='java.lang.String']]"
		[Register ("MeetingUpdated", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;Ljava/lang/String;)V", "GetMeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_Handler")]
		public abstract void MeetingUpdated (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2, string p3);

		static Delegate cb_MeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_;
#pragma warning disable 0169
		static Delegate GetMeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Handler ()
		{
			if (cb_MeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_ == null)
				cb_MeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_);
			return cb_MeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_;
		}

		static void n_MeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.MeetingUpdatedByService (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingUpdatedByService' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.Meeting.VidyoMeetingActionResult']]"
		[Register ("MeetingUpdatedByService", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;)V", "GetMeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Handler")]
		public abstract void MeetingUpdatedByService (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2);

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
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='dispose' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback", DoNotGenerateAcw=true)]
	internal partial class VidyoCalendarFeedbackInvoker : VidyoCalendarFeedback {

		public VidyoCalendarFeedbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoCalendarFeedbackInvoker); }
		}

		static IntPtr id_ConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='ConnectResult' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode']]"
		[Register ("ConnectResult", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarServiceCode;)V", "GetConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Handler")]
		public override unsafe void ConnectResult (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode p1)
		{
			if (id_ConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_ == IntPtr.Zero)
				id_ConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_ = JNIEnv.GetMethodID (class_ref, "ConnectResult", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarServiceCode;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ConnectResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_, __args);
			} finally {
			}
		}

		static IntPtr id_Disconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='Disconnected' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode']]"
		[Register ("Disconnected", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarServiceCode;)V", "GetDisconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Handler")]
		public override unsafe void Disconnected (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode p1)
		{
			if (id_Disconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_ == IntPtr.Zero)
				id_Disconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_ = JNIEnv.GetMethodID (class_ref, "Disconnected", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarServiceCode;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Disconnected_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_, __args);
			} finally {
			}
		}

		static IntPtr id_GetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='GetMeetingsResult' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoMeetingSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Meeting.VidyoMeeting&gt;']]"
		[Register ("GetMeetingsResult", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoMeetingSearchResult;Ljava/util/ArrayList;)V", "GetGetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_Handler")]
		public override unsafe void GetMeetingsResult (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoMeetingSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> p2)
		{
			if (id_GetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetMeetingsResult", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoMeetingSearchResult;Ljava/util/ArrayList;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_GetMeetingsResult_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoMeetingSearchResult_Ljava_util_ArrayList_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_MeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingCreated' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.Meeting.VidyoMeetingActionResult'] and parameter[4][@type='java.lang.String']]"
		[Register ("MeetingCreated", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;Ljava/lang/String;)V", "GetMeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_Handler")]
		public override unsafe void MeetingCreated (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2, string p3)
		{
			if (id_MeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ == IntPtr.Zero)
				id_MeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "MeetingCreated", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_MeetingCreated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_MeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingCreatedByService' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.VidyoMeetingAttendee']]"
		[Register ("MeetingCreatedByService", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)V", "GetMeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_Handler")]
		public override unsafe void MeetingCreatedByService (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee p2)
		{
			if (id_MeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ == IntPtr.Zero)
				id_MeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_ = JNIEnv.GetMethodID (class_ref, "MeetingCreatedByService", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/VidyoMeetingAttendee;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_MeetingCreatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_VidyoMeetingAttendee_, __args);
			} finally {
			}
		}

		static IntPtr id_MeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingEventNotification' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting']]"
		[Register ("MeetingEventNotification", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;)V", "GetMeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Handler")]
		public override unsafe void MeetingEventNotification (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1)
		{
			if (id_MeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_ == IntPtr.Zero)
				id_MeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_ = JNIEnv.GetMethodID (class_ref, "MeetingEventNotification", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_MeetingEventNotification_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_, __args);
			} finally {
			}
		}

		static IntPtr id_MeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingRemoved' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.Meeting.VidyoMeetingActionResult'] and parameter[4][@type='java.lang.String']]"
		[Register ("MeetingRemoved", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;Ljava/lang/String;)V", "GetMeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_Handler")]
		public override unsafe void MeetingRemoved (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2, string p3)
		{
			if (id_MeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ == IntPtr.Zero)
				id_MeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "MeetingRemoved", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_MeetingRemoved_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_MeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingRemovedByService' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.Meeting.VidyoMeetingActionResult']]"
		[Register ("MeetingRemovedByService", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;)V", "GetMeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Handler")]
		public override unsafe void MeetingRemovedByService (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2)
		{
			if (id_MeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_ == IntPtr.Zero)
				id_MeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_ = JNIEnv.GetMethodID (class_ref, "MeetingRemovedByService", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_MeetingRemovedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_, __args);
			} finally {
			}
		}

		static IntPtr id_MeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingUpdated' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.Meeting.VidyoMeetingActionResult'] and parameter[4][@type='java.lang.String']]"
		[Register ("MeetingUpdated", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;Ljava/lang/String;)V", "GetMeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_Handler")]
		public override unsafe void MeetingUpdated (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2, string p3)
		{
			if (id_MeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ == IntPtr.Zero)
				id_MeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "MeetingUpdated", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_MeetingUpdated_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_MeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendarFeedback']/method[@name='MeetingUpdatedByService' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='com.vidyo.VidyoClient.Meeting.VidyoMeetingActionResult']]"
		[Register ("MeetingUpdatedByService", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;)V", "GetMeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_Handler")]
		public override unsafe void MeetingUpdatedByService (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeetingActionResult p2)
		{
			if (id_MeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_ == IntPtr.Zero)
				id_MeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_ = JNIEnv.GetMethodID (class_ref, "MeetingUpdatedByService", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Lcom/vidyo/VidyoClient/Meeting/VidyoMeetingActionResult;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_MeetingUpdatedByService_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Lcom_vidyo_VidyoClient_Meeting_VidyoMeetingActionResult_, __args);
			} finally {
			}
		}

	}

}
