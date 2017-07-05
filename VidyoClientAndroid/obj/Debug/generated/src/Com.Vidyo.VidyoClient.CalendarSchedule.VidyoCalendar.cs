using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarSchedule {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar", DoNotGenerateAcw=true)]
	public partial class VidyoCalendar : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnProps']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnProps", DoNotGenerateAcw=true)]
		public partial class VidyoCalendarConnProps : global::Java.Lang.Object {


			static IntPtr connPropType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnProps']/field[@name='connPropType']"
			[Register ("connPropType")]
			public global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType ConnPropType {
				get {
					if (connPropType_jfieldId == IntPtr.Zero)
						connPropType_jfieldId = JNIEnv.GetFieldID (class_ref, "connPropType", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, connPropType_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (connPropType_jfieldId == IntPtr.Zero)
						connPropType_jfieldId = JNIEnv.GetFieldID (class_ref, "connPropType", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connPropType_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr connPropValue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnProps']/field[@name='connPropValue']"
			[Register ("connPropValue")]
			public string ConnPropValue {
				get {
					if (connPropValue_jfieldId == IntPtr.Zero)
						connPropValue_jfieldId = JNIEnv.GetFieldID (class_ref, "connPropValue", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, connPropValue_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (connPropValue_jfieldId == IntPtr.Zero)
						connPropValue_jfieldId = JNIEnv.GetFieldID (class_ref, "connPropValue", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connPropValue_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnProps", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoCalendarConnProps); }
			}

			protected VidyoCalendarConnProps (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnProps']/constructor[@name='VidyoCalendar.VidyoCalendarConnProps' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendar']]"
			[Register (".ctor", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;)V", "")]
			public unsafe VidyoCalendarConnProps (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (VidyoCalendarConnProps)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_ == IntPtr.Zero)
						id_ctor_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendar_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnectParamType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoCalendarConnectParamType : global::Java.Lang.Enum {


			static IntPtr VIDYO_CALENDARCONNECTPARAMTYPE_Mailbox_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnectParamType']/field[@name='VIDYO_CALENDARCONNECTPARAMTYPE_Mailbox']"
			[Register ("VIDYO_CALENDARCONNECTPARAMTYPE_Mailbox")]
			public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType VIDYOCALENDARCONNECTPARAMTYPEMailbox {
				get {
					if (VIDYO_CALENDARCONNECTPARAMTYPE_Mailbox_jfieldId == IntPtr.Zero)
						VIDYO_CALENDARCONNECTPARAMTYPE_Mailbox_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARCONNECTPARAMTYPE_Mailbox", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARCONNECTPARAMTYPE_Mailbox_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALENDARCONNECTPARAMTYPE_PasswordToken_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnectParamType']/field[@name='VIDYO_CALENDARCONNECTPARAMTYPE_PasswordToken']"
			[Register ("VIDYO_CALENDARCONNECTPARAMTYPE_PasswordToken")]
			public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType VIDYOCALENDARCONNECTPARAMTYPEPasswordToken {
				get {
					if (VIDYO_CALENDARCONNECTPARAMTYPE_PasswordToken_jfieldId == IntPtr.Zero)
						VIDYO_CALENDARCONNECTPARAMTYPE_PasswordToken_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARCONNECTPARAMTYPE_PasswordToken", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARCONNECTPARAMTYPE_PasswordToken_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALENDARCONNECTPARAMTYPE_ServerAddress_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnectParamType']/field[@name='VIDYO_CALENDARCONNECTPARAMTYPE_ServerAddress']"
			[Register ("VIDYO_CALENDARCONNECTPARAMTYPE_ServerAddress")]
			public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType VIDYOCALENDARCONNECTPARAMTYPEServerAddress {
				get {
					if (VIDYO_CALENDARCONNECTPARAMTYPE_ServerAddress_jfieldId == IntPtr.Zero)
						VIDYO_CALENDARCONNECTPARAMTYPE_ServerAddress_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARCONNECTPARAMTYPE_ServerAddress", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARCONNECTPARAMTYPE_ServerAddress_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALENDARCONNECTPARAMTYPE_Unknown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnectParamType']/field[@name='VIDYO_CALENDARCONNECTPARAMTYPE_Unknown']"
			[Register ("VIDYO_CALENDARCONNECTPARAMTYPE_Unknown")]
			public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType VIDYOCALENDARCONNECTPARAMTYPEUnknown {
				get {
					if (VIDYO_CALENDARCONNECTPARAMTYPE_Unknown_jfieldId == IntPtr.Zero)
						VIDYO_CALENDARCONNECTPARAMTYPE_Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARCONNECTPARAMTYPE_Unknown", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARCONNECTPARAMTYPE_Unknown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALENDARCONNECTPARAMTYPE_UserId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnectParamType']/field[@name='VIDYO_CALENDARCONNECTPARAMTYPE_UserId']"
			[Register ("VIDYO_CALENDARCONNECTPARAMTYPE_UserId")]
			public static global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType VIDYOCALENDARCONNECTPARAMTYPEUserId {
				get {
					if (VIDYO_CALENDARCONNECTPARAMTYPE_UserId_jfieldId == IntPtr.Zero)
						VIDYO_CALENDARCONNECTPARAMTYPE_UserId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALENDARCONNECTPARAMTYPE_UserId", "Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALENDARCONNECTPARAMTYPE_UserId_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoCalendarConnectParamType); }
			}

			internal VidyoCalendarConnectParamType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnectParamType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar.VidyoCalendarConnectParamType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar$VidyoCalendarConnectParamType;");
				try {
					return (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar.VidyoCalendarConnectParamType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarSchedule/VidyoCalendar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoCalendar); }
		}

		protected VidyoCalendar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/constructor[@name='VidyoCalendar' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoCalendar (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoCalendar)) {
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
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='GetId' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_GetServiceState;
#pragma warning disable 0169
		static Delegate GetGetServiceStateHandler ()
		{
			if (cb_GetServiceState == null)
				cb_GetServiceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServiceState);
			return cb_GetServiceState;
		}

		static IntPtr n_GetServiceState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ServiceState);
		}
#pragma warning restore 0169

		static IntPtr id_GetServiceState;
		public virtual unsafe global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState ServiceState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='GetServiceState' and count(parameter)=0]"
			[Register ("GetServiceState", "()Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;", "GetGetServiceStateHandler")]
			get {
				if (id_GetServiceState == IntPtr.Zero)
					id_GetServiceState = JNIEnv.GetMethodID (class_ref, "GetServiceState", "()Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetServiceState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetServiceState", "()Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarState;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetServiceType;
#pragma warning disable 0169
		static Delegate GetGetServiceTypeHandler ()
		{
			if (cb_GetServiceType == null)
				cb_GetServiceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServiceType);
			return cb_GetServiceType;
		}

		static IntPtr n_GetServiceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceType);
		}
#pragma warning restore 0169

		static IntPtr id_GetServiceType;
		public virtual unsafe string ServiceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='GetServiceType' and count(parameter)=0]"
			[Register ("GetServiceType", "()Ljava/lang/String;", "GetGetServiceTypeHandler")]
			get {
				if (id_GetServiceType == IntPtr.Zero)
					id_GetServiceType = JNIEnv.GetMethodID (class_ref, "GetServiceType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetServiceType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetServiceType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_Connect_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_util_ArrayList_Handler ()
		{
			if (cb_Connect_Ljava_util_ArrayList_ == null)
				cb_Connect_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Connect_Ljava_util_ArrayList_);
			return cb_Connect_Ljava_util_ArrayList_;
		}

		static bool n_Connect_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormField>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Connect (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Connect_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='Connect' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.CalendarManager.VidyoFormField&gt;']]"
		[Register ("Connect", "(Ljava/util/ArrayList;)Z", "GetConnect_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool Connect (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormField> p0)
		{
			if (id_Connect_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_Connect_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "Connect", "(Ljava/util/ArrayList;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormField>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Connect_Ljava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Connect", "(Ljava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_CreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_Handler ()
		{
			if (cb_CreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ == null)
				cb_CreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_);
			return cb_CreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_;
		}

		static bool n_CreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CreateMeeting (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='CreateMeeting' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='java.lang.String']]"
		[Register ("CreateMeeting", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Ljava/lang/String;)Z", "GetCreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_Handler")]
		public virtual unsafe bool CreateMeeting (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, string p2)
		{
			if (id_CreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ == IntPtr.Zero)
				id_CreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "CreateMeeting", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Ljava/lang/String;)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CreateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateMeeting", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_GetMeetingsByDay_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMeetingsByDay_IIILjava_lang_String_Handler ()
		{
			if (cb_GetMeetingsByDay_IIILjava_lang_String_ == null)
				cb_GetMeetingsByDay_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, bool>) n_GetMeetingsByDay_IIILjava_lang_String_);
			return cb_GetMeetingsByDay_IIILjava_lang_String_;
		}

		static bool n_GetMeetingsByDay_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetMeetingsByDay (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetMeetingsByDay_IIILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='GetMeetingsByDay' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("GetMeetingsByDay", "(IIILjava/lang/String;)Z", "GetGetMeetingsByDay_IIILjava_lang_String_Handler")]
		public virtual unsafe bool GetMeetingsByDay (int p0, int p1, int p2, string p3)
		{
			if (id_GetMeetingsByDay_IIILjava_lang_String_ == IntPtr.Zero)
				id_GetMeetingsByDay_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetMeetingsByDay", "(IIILjava/lang/String;)Z");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetMeetingsByDay_IIILjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMeetingsByDay", "(IIILjava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_GetMeetingsByMonth_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMeetingsByMonth_IILjava_lang_String_Handler ()
		{
			if (cb_GetMeetingsByMonth_IILjava_lang_String_ == null)
				cb_GetMeetingsByMonth_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, bool>) n_GetMeetingsByMonth_IILjava_lang_String_);
			return cb_GetMeetingsByMonth_IILjava_lang_String_;
		}

		static bool n_GetMeetingsByMonth_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetMeetingsByMonth (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetMeetingsByMonth_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='GetMeetingsByMonth' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("GetMeetingsByMonth", "(IILjava/lang/String;)Z", "GetGetMeetingsByMonth_IILjava_lang_String_Handler")]
		public virtual unsafe bool GetMeetingsByMonth (int p0, int p1, string p2)
		{
			if (id_GetMeetingsByMonth_IILjava_lang_String_ == IntPtr.Zero)
				id_GetMeetingsByMonth_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetMeetingsByMonth", "(IILjava/lang/String;)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetMeetingsByMonth_IILjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMeetingsByMonth", "(IILjava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_GetMeetingsByWeek_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMeetingsByWeek_IIILjava_lang_String_Handler ()
		{
			if (cb_GetMeetingsByWeek_IIILjava_lang_String_ == null)
				cb_GetMeetingsByWeek_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, bool>) n_GetMeetingsByWeek_IIILjava_lang_String_);
			return cb_GetMeetingsByWeek_IIILjava_lang_String_;
		}

		static bool n_GetMeetingsByWeek_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetMeetingsByWeek (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetMeetingsByWeek_IIILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='GetMeetingsByWeek' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("GetMeetingsByWeek", "(IIILjava/lang/String;)Z", "GetGetMeetingsByWeek_IIILjava_lang_String_Handler")]
		public virtual unsafe bool GetMeetingsByWeek (int p0, int p1, int p2, string p3)
		{
			if (id_GetMeetingsByWeek_IIILjava_lang_String_ == IntPtr.Zero)
				id_GetMeetingsByWeek_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetMeetingsByWeek", "(IIILjava/lang/String;)Z");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetMeetingsByWeek_IIILjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMeetingsByWeek", "(IIILjava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_RemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_Handler ()
		{
			if (cb_RemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ == null)
				cb_RemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_);
			return cb_RemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_;
		}

		static bool n_RemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveMeeting (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='RemoveMeeting' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='java.lang.String']]"
		[Register ("RemoveMeeting", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Ljava/lang/String;)Z", "GetRemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemoveMeeting (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, string p2)
		{
			if (id_RemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ == IntPtr.Zero)
				id_RemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "RemoveMeeting", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Ljava/lang/String;)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RemoveMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveMeeting", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_SearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetSearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIHandler ()
		{
			if (cb_SearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II == null)
				cb_SearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, bool>) n_SearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II);
			return cb_SearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II;
		}

		static bool n_SearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchMeetings (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='SearchMeetings' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("SearchMeetings", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)Z", "GetSearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIHandler")]
		public virtual unsafe bool SearchMeetings (string p0, string p1, string p2, int p3, int p4)
		{
			if (id_SearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
				id_SearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "SearchMeetings", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SearchMeetings_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SearchMeetings", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_SetRoomIdMatchString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRoomIdMatchString_Ljava_lang_String_Handler ()
		{
			if (cb_SetRoomIdMatchString_Ljava_lang_String_ == null)
				cb_SetRoomIdMatchString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetRoomIdMatchString_Ljava_lang_String_);
			return cb_SetRoomIdMatchString_Ljava_lang_String_;
		}

		static bool n_SetRoomIdMatchString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetRoomIdMatchString (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetRoomIdMatchString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='SetRoomIdMatchString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetRoomIdMatchString", "(Ljava/lang/String;)Z", "GetSetRoomIdMatchString_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetRoomIdMatchString (string p0)
		{
			if (id_SetRoomIdMatchString_Ljava_lang_String_ == IntPtr.Zero)
				id_SetRoomIdMatchString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetRoomIdMatchString", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetRoomIdMatchString_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetRoomIdMatchString", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_UpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_Handler ()
		{
			if (cb_UpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ == null)
				cb_UpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_);
			return cb_UpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_;
		}

		static bool n_UpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateMeeting (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_UpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='UpdateMeeting' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback'] and parameter[2][@type='com.vidyo.VidyoClient.Meeting.VidyoMeeting'] and parameter[3][@type='java.lang.String']]"
		[Register ("UpdateMeeting", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Ljava/lang/String;)Z", "GetUpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_Handler")]
		public virtual unsafe bool UpdateMeeting (global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendarFeedback p0, global::Com.Vidyo.VidyoClient.Meeting.VidyoMeeting p1, string p2)
		{
			if (id_UpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ == IntPtr.Zero)
				id_UpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "UpdateMeeting", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Ljava/lang/String;)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UpdateMeeting_Lcom_vidyo_VidyoClient_CalendarSchedule_VidyoCalendarFeedback_Lcom_vidyo_VidyoClient_Meeting_VidyoMeeting_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UpdateMeeting", "(Lcom/vidyo/VidyoClient/CalendarSchedule/VidyoCalendarFeedback;Lcom/vidyo/VidyoClient/Meeting/VidyoMeeting;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarSchedule.VidyoCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarSchedule']/class[@name='VidyoCalendar']/method[@name='dispose' and count(parameter)=0]"
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
