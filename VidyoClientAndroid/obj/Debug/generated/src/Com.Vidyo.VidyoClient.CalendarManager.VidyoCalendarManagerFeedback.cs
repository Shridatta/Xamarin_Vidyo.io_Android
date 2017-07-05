using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManagerFeedback']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarManager/VidyoCalendarManagerFeedback", DoNotGenerateAcw=true)]
	public abstract partial class VidyoCalendarManagerFeedback : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarManager/VidyoCalendarManagerFeedback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoCalendarManagerFeedback); }
		}

		protected VidyoCalendarManagerFeedback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManagerFeedback']/constructor[@name='VidyoCalendarManagerFeedback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoCalendarManagerFeedback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoCalendarManagerFeedback)) {
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
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManagerFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManagerFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManagerFeedback']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_CalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_Handler ()
		{
			if (cb_CalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_ == null)
				cb_CalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_);
			return cb_CalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_;
		}

		static void n_CalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManagerFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManagerFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.CalendarCreated (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManagerFeedback']/method[@name='CalendarCreated' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.CalendarManager.VidyoCalendarManager'] and parameter[2][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[3][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode'] and parameter[4][@type='java.lang.String']]"
		[Register ("CalendarCreated", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarServiceCode;Ljava/lang/String;)V", "GetCalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_Handler")]
		public abstract void CalendarCreated (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager p0, global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p1, global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode p2, string p3);

		static Delegate cb_ServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_;
#pragma warning disable 0169
		static Delegate GetServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_Handler ()
		{
			if (cb_ServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_ == null)
				cb_ServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_);
			return cb_ServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_;
		}

		static void n_ServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManagerFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManagerFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ServiceDiscovery (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManagerFeedback']/method[@name='ServiceDiscovery' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarManager.VidyoCalendarManager'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus']]"
		[Register ("ServiceDiscovery", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager;Ljava/lang/String;Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;)V", "GetServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_Handler")]
		public abstract void ServiceDiscovery (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager p0, string p1, global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus p2);

		static Delegate cb_Uninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_;
#pragma warning disable 0169
		static Delegate GetUninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Handler ()
		{
			if (cb_Uninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_ == null)
				cb_Uninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Uninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_);
			return cb_Uninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_;
		}

		static void n_Uninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManagerFeedback __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManagerFeedback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Uninitialized (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManagerFeedback']/method[@name='Uninitialized' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.CalendarManager.VidyoCalendarManager']]"
		[Register ("Uninitialized", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager;)V", "GetUninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Handler")]
		public abstract void Uninitialized (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager p0);

	}

	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarManager/VidyoCalendarManagerFeedback", DoNotGenerateAcw=true)]
	internal partial class VidyoCalendarManagerFeedbackInvoker : VidyoCalendarManagerFeedback {

		public VidyoCalendarManagerFeedbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoCalendarManagerFeedbackInvoker); }
		}

		static IntPtr id_CalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManagerFeedback']/method[@name='CalendarCreated' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.CalendarManager.VidyoCalendarManager'] and parameter[2][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar'] and parameter[3][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode'] and parameter[4][@type='java.lang.String']]"
		[Register ("CalendarCreated", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarServiceCode;Ljava/lang/String;)V", "GetCalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_Handler")]
		public override unsafe void CalendarCreated (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager p0, global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p1, global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarServiceCode p2, string p3)
		{
			if (id_CalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_ == IntPtr.Zero)
				id_CalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "CalendarCreated", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarServiceCode;Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_CalendarCreated_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarServiceCode_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManagerFeedback']/method[@name='ServiceDiscovery' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarManager.VidyoCalendarManager'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus']]"
		[Register ("ServiceDiscovery", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager;Ljava/lang/String;Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;)V", "GetServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_Handler")]
		public override unsafe void ServiceDiscovery (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager p0, string p1, global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarServiceStatus p2)
		{
			if (id_ServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_ == IntPtr.Zero)
				id_ServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_ = JNIEnv.GetMethodID (class_ref, "ServiceDiscovery", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager;Ljava/lang/String;Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarServiceStatus;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ServiceDiscovery_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Ljava_lang_String_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarServiceStatus_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Uninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManagerFeedback']/method[@name='Uninitialized' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.CalendarManager.VidyoCalendarManager']]"
		[Register ("Uninitialized", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager;)V", "GetUninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_Handler")]
		public override unsafe void Uninitialized (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager p0)
		{
			if (id_Uninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_ == IntPtr.Zero)
				id_Uninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_ = JNIEnv.GetMethodID (class_ref, "Uninitialized", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Uninitialized_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManager_, __args);
			} finally {
			}
		}

	}

}
