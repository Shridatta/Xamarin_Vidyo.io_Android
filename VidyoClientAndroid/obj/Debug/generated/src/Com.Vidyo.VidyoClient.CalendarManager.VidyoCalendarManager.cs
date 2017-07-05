using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager", DoNotGenerateAcw=true)]
	public partial class VidyoCalendarManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarManager/VidyoCalendarManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoCalendarManager); }
		}

		protected VidyoCalendarManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManagerFeedback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']/constructor[@name='VidyoCalendarManager' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.CalendarManager.VidyoCalendarManagerFeedback']]"
		[Register (".ctor", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManagerFeedback;)V", "")]
		public unsafe VidyoCalendarManager (global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManagerFeedback p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoCalendarManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManagerFeedback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManagerFeedback;)V", __args);
					return;
				}

				if (id_ctor_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManagerFeedback_ == IntPtr.Zero)
					id_ctor_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManagerFeedback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/CalendarManager/VidyoCalendarManagerFeedback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManagerFeedback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_CalendarManager_VidyoCalendarManagerFeedback_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']/constructor[@name='VidyoCalendarManager' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoCalendarManager (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoCalendarManager)) {
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
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_CreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_CreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_CreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_CreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_CreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CreateCalendarInstance (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']/method[@name='CreateCalendarInstance' and count(parameter)=4 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("CreateCalendarInstance", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z", "GetCreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool CreateCalendarInstance (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback p0, string p1, string p2, string p3)
		{
			if (id_CreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_CreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "CreateCalendarInstance", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CreateCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateCalendarInstance", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_DeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_;
#pragma warning disable 0169
		static Delegate GetDeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Handler ()
		{
			if (cb_DeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_ == null)
				cb_DeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_);
			return cb_DeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_;
		}

		static void n_DeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteCalendarInstance (p0);
		}
#pragma warning restore 0169

		static IntPtr id_DeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']/method[@name='DeleteCalendarInstance' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar']]"
		[Register ("DeleteCalendarInstance", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;)V", "GetDeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_Handler")]
		public virtual unsafe void DeleteCalendarInstance (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar p0)
		{
			if (id_DeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_ == IntPtr.Zero)
				id_DeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_ = JNIEnv.GetMethodID (class_ref, "DeleteCalendarInstance", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_DeleteCalendarInstance_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DeleteCalendarInstance", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_GetCalendarTypes_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetCalendarTypes_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetCalendarTypes_Ljava_util_ArrayList_ == null)
				cb_GetCalendarTypes_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetCalendarTypes_Ljava_util_ArrayList_);
			return cb_GetCalendarTypes_Ljava_util_ArrayList_;
		}

		static bool n_GetCalendarTypes_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarManagerDefaultServices>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetCalendarTypes (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetCalendarTypes_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']/method[@name='GetCalendarTypes' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarManagerDefaultServices&gt;']]"
		[Register ("GetCalendarTypes", "(Ljava/util/ArrayList;)Z", "GetGetCalendarTypes_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool GetCalendarTypes (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarManagerDefaultServices> p0)
		{
			if (id_GetCalendarTypes_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetCalendarTypes_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetCalendarTypes", "(Ljava/util/ArrayList;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarManagerDefaultServices>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetCalendarTypes_Ljava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetCalendarTypes", "(Ljava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_Initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_Initialize == null)
				cb_Initialize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Initialize);
			return cb_Initialize;
		}

		static bool n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Initialize ();
		}
#pragma warning restore 0169

		static IntPtr id_Initialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']/method[@name='Initialize' and count(parameter)=0]"
		[Register ("Initialize", "()Z", "GetInitializeHandler")]
		public virtual unsafe bool Initialize ()
		{
			if (id_Initialize == IntPtr.Zero)
				id_Initialize = JNIEnv.GetMethodID (class_ref, "Initialize", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Initialize);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Initialize", "()Z"));
			} finally {
			}
		}

		static Delegate cb_SetCalendarTypes_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetCalendarTypes_Ljava_util_ArrayList_Handler ()
		{
			if (cb_SetCalendarTypes_Ljava_util_ArrayList_ == null)
				cb_SetCalendarTypes_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetCalendarTypes_Ljava_util_ArrayList_);
			return cb_SetCalendarTypes_Ljava_util_ArrayList_;
		}

		static bool n_SetCalendarTypes_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarManagerDefaultServices>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetCalendarTypes (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetCalendarTypes_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']/method[@name='SetCalendarTypes' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarManagerDefaultServices&gt;']]"
		[Register ("SetCalendarTypes", "(Ljava/util/ArrayList;)Z", "GetSetCalendarTypes_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool SetCalendarTypes (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarManagerDefaultServices> p0)
		{
			if (id_SetCalendarTypes_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_SetCalendarTypes_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "SetCalendarTypes", "(Ljava/util/ArrayList;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarManagerDefaultServices>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetCalendarTypes_Ljava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCalendarTypes", "(Ljava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_Uninitialize;
#pragma warning disable 0169
		static Delegate GetUninitializeHandler ()
		{
			if (cb_Uninitialize == null)
				cb_Uninitialize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Uninitialize);
			return cb_Uninitialize;
		}

		static bool n_Uninitialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Uninitialize ();
		}
#pragma warning restore 0169

		static IntPtr id_Uninitialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']/method[@name='Uninitialize' and count(parameter)=0]"
		[Register ("Uninitialize", "()Z", "GetUninitializeHandler")]
		public virtual unsafe bool Uninitialize ()
		{
			if (id_Uninitialize == IntPtr.Zero)
				id_Uninitialize = JNIEnv.GetMethodID (class_ref, "Uninitialize", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Uninitialize);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Uninitialize", "()Z"));
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
			global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoCalendarManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoCalendarManager']/method[@name='dispose' and count(parameter)=0]"
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
