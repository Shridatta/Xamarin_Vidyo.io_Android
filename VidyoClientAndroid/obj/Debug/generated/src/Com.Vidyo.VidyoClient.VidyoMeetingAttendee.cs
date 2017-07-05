using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoMeetingAttendee", DoNotGenerateAcw=true)]
	public partial class VidyoMeetingAttendee : global::Java.Lang.Object {


		static IntPtr email_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee']/field[@name='email']"
		[Register ("email")]
		public string Email {
			get {
				if (email_jfieldId == IntPtr.Zero)
					email_jfieldId = JNIEnv.GetFieldID (class_ref, "email", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, email_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (email_jfieldId == IntPtr.Zero)
					email_jfieldId = JNIEnv.GetFieldID (class_ref, "email", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, email_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr role_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee']/field[@name='role']"
		[Register ("role")]
		public global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole Role {
			get {
				if (role_jfieldId == IntPtr.Zero)
					role_jfieldId = JNIEnv.GetFieldID (class_ref, "role", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, role_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (role_jfieldId == IntPtr.Zero)
					role_jfieldId = JNIEnv.GetFieldID (class_ref, "role", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, role_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee']/field[@name='status']"
		[Register ("status")]
		public global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus Status {
			get {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, status_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, status_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationRole']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole", DoNotGenerateAcw=true)]
		public sealed partial class VidyoAttendeeParticipationRole : global::Java.Lang.Enum {


			static IntPtr VIDYO_ATTENDEEPARTICIPATIONROLE_Chair_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationRole']/field[@name='VIDYO_ATTENDEEPARTICIPATIONROLE_Chair']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONROLE_Chair")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole VIDYOATTENDEEPARTICIPATIONROLEChair {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONROLE_Chair_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONROLE_Chair_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONROLE_Chair", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONROLE_Chair_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONROLE_Informational_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationRole']/field[@name='VIDYO_ATTENDEEPARTICIPATIONROLE_Informational']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONROLE_Informational")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole VIDYOATTENDEEPARTICIPATIONROLEInformational {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONROLE_Informational_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONROLE_Informational_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONROLE_Informational", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONROLE_Informational_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONROLE_Optional_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationRole']/field[@name='VIDYO_ATTENDEEPARTICIPATIONROLE_Optional']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONROLE_Optional")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole VIDYOATTENDEEPARTICIPATIONROLEOptional {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONROLE_Optional_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONROLE_Optional_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONROLE_Optional", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONROLE_Optional_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONROLE_Required_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationRole']/field[@name='VIDYO_ATTENDEEPARTICIPATIONROLE_Required']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONROLE_Required")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole VIDYOATTENDEEPARTICIPATIONROLERequired {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONROLE_Required_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONROLE_Required_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONROLE_Required", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONROLE_Required_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoAttendeeParticipationRole); }
			}

			internal VidyoAttendeeParticipationRole (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationRole']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationRole']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationRole;");
				try {
					return (global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationRole));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus", DoNotGenerateAcw=true)]
		public sealed partial class VidyoAttendeeParticipationStatus : global::Java.Lang.Enum {


			static IntPtr VIDYO_ATTENDEEPARTICIPATIONSTATUS_Accepted_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/field[@name='VIDYO_ATTENDEEPARTICIPATIONSTATUS_Accepted']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONSTATUS_Accepted")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus VIDYOATTENDEEPARTICIPATIONSTATUSAccepted {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONSTATUS_Accepted_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONSTATUS_Accepted_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONSTATUS_Accepted", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONSTATUS_Accepted_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONSTATUS_Completed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/field[@name='VIDYO_ATTENDEEPARTICIPATIONSTATUS_Completed']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONSTATUS_Completed")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus VIDYOATTENDEEPARTICIPATIONSTATUSCompleted {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONSTATUS_Completed_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONSTATUS_Completed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONSTATUS_Completed", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONSTATUS_Completed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONSTATUS_Declined_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/field[@name='VIDYO_ATTENDEEPARTICIPATIONSTATUS_Declined']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONSTATUS_Declined")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus VIDYOATTENDEEPARTICIPATIONSTATUSDeclined {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONSTATUS_Declined_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONSTATUS_Declined_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONSTATUS_Declined", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONSTATUS_Declined_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONSTATUS_Delegated_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/field[@name='VIDYO_ATTENDEEPARTICIPATIONSTATUS_Delegated']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONSTATUS_Delegated")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus VIDYOATTENDEEPARTICIPATIONSTATUSDelegated {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONSTATUS_Delegated_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONSTATUS_Delegated_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONSTATUS_Delegated", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONSTATUS_Delegated_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONSTATUS_InProcess_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/field[@name='VIDYO_ATTENDEEPARTICIPATIONSTATUS_InProcess']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONSTATUS_InProcess")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus VIDYOATTENDEEPARTICIPATIONSTATUSInProcess {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONSTATUS_InProcess_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONSTATUS_InProcess_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONSTATUS_InProcess", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONSTATUS_InProcess_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONSTATUS_NeedsAction_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/field[@name='VIDYO_ATTENDEEPARTICIPATIONSTATUS_NeedsAction']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONSTATUS_NeedsAction")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus VIDYOATTENDEEPARTICIPATIONSTATUSNeedsAction {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONSTATUS_NeedsAction_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONSTATUS_NeedsAction_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONSTATUS_NeedsAction", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONSTATUS_NeedsAction_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONSTATUS_None_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/field[@name='VIDYO_ATTENDEEPARTICIPATIONSTATUS_None']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONSTATUS_None")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus VIDYOATTENDEEPARTICIPATIONSTATUSNone {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONSTATUS_None_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONSTATUS_None_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONSTATUS_None", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONSTATUS_None_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONSTATUS_Organized_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/field[@name='VIDYO_ATTENDEEPARTICIPATIONSTATUS_Organized']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONSTATUS_Organized")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus VIDYOATTENDEEPARTICIPATIONSTATUSOrganized {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONSTATUS_Organized_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONSTATUS_Organized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONSTATUS_Organized", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONSTATUS_Organized_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ATTENDEEPARTICIPATIONSTATUS_Tentative_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/field[@name='VIDYO_ATTENDEEPARTICIPATIONSTATUS_Tentative']"
			[Register ("VIDYO_ATTENDEEPARTICIPATIONSTATUS_Tentative")]
			public static global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus VIDYOATTENDEEPARTICIPATIONSTATUSTentative {
				get {
					if (VIDYO_ATTENDEEPARTICIPATIONSTATUS_Tentative_jfieldId == IntPtr.Zero)
						VIDYO_ATTENDEEPARTICIPATIONSTATUS_Tentative_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ATTENDEEPARTICIPATIONSTATUS_Tentative", "Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ATTENDEEPARTICIPATIONSTATUS_Tentative_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoAttendeeParticipationStatus); }
			}

			internal VidyoAttendeeParticipationStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee.VidyoAttendeeParticipationStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/VidyoMeetingAttendee$VidyoAttendeeParticipationStatus;");
				try {
					return (global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.VidyoMeetingAttendee.VidyoAttendeeParticipationStatus));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/VidyoMeetingAttendee", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoMeetingAttendee); }
		}

		protected VidyoMeetingAttendee (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient']/class[@name='VidyoMeetingAttendee']/constructor[@name='VidyoMeetingAttendee' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoMeetingAttendee ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoMeetingAttendee)) {
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

	}
}
