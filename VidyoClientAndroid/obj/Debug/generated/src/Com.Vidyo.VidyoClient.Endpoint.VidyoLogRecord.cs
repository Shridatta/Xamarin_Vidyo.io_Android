using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoLogRecord", DoNotGenerateAcw=true)]
	public partial class VidyoLogRecord : global::Java.Lang.Object {


		static IntPtr categoryName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']/field[@name='categoryName']"
		[Register ("categoryName")]
		public long CategoryName {
			get {
				if (categoryName_jfieldId == IntPtr.Zero)
					categoryName_jfieldId = JNIEnv.GetFieldID (class_ref, "categoryName", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, categoryName_jfieldId);
			}
			set {
				if (categoryName_jfieldId == IntPtr.Zero)
					categoryName_jfieldId = JNIEnv.GetFieldID (class_ref, "categoryName", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, categoryName_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr eventTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']/field[@name='eventTime']"
		[Register ("eventTime")]
		public long EventTime {
			get {
				if (eventTime_jfieldId == IntPtr.Zero)
					eventTime_jfieldId = JNIEnv.GetFieldID (class_ref, "eventTime", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, eventTime_jfieldId);
			}
			set {
				if (eventTime_jfieldId == IntPtr.Zero)
					eventTime_jfieldId = JNIEnv.GetFieldID (class_ref, "eventTime", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, eventTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr file_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']/field[@name='file']"
		[Register ("file")]
		public string File {
			get {
				if (file_jfieldId == IntPtr.Zero)
					file_jfieldId = JNIEnv.GetFieldID (class_ref, "file", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, file_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (file_jfieldId == IntPtr.Zero)
					file_jfieldId = JNIEnv.GetFieldID (class_ref, "file", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, file_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr functionName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']/field[@name='functionName']"
		[Register ("functionName")]
		public string FunctionName {
			get {
				if (functionName_jfieldId == IntPtr.Zero)
					functionName_jfieldId = JNIEnv.GetFieldID (class_ref, "functionName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, functionName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (functionName_jfieldId == IntPtr.Zero)
					functionName_jfieldId = JNIEnv.GetFieldID (class_ref, "functionName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, functionName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr level_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']/field[@name='level']"
		[Register ("level")]
		public global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel Level {
			get {
				if (level_jfieldId == IntPtr.Zero)
					level_jfieldId = JNIEnv.GetFieldID (class_ref, "level", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, level_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (level_jfieldId == IntPtr.Zero)
					level_jfieldId = JNIEnv.GetFieldID (class_ref, "level", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, level_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr line_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']/field[@name='line']"
		[Register ("line")]
		public int Line {
			get {
				if (line_jfieldId == IntPtr.Zero)
					line_jfieldId = JNIEnv.GetFieldID (class_ref, "line", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, line_jfieldId);
			}
			set {
				if (line_jfieldId == IntPtr.Zero)
					line_jfieldId = JNIEnv.GetFieldID (class_ref, "line", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, line_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr message_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']/field[@name='message']"
		[Register ("message")]
		public string Message {
			get {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, message_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, message_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']/field[@name='name']"
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

		static IntPtr threadName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']/field[@name='threadName']"
		[Register ("threadName")]
		public string ThreadName {
			get {
				if (threadName_jfieldId == IntPtr.Zero)
					threadName_jfieldId = JNIEnv.GetFieldID (class_ref, "threadName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, threadName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (threadName_jfieldId == IntPtr.Zero)
					threadName_jfieldId = JNIEnv.GetFieldID (class_ref, "threadName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, threadName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel", DoNotGenerateAcw=true)]
		public sealed partial class VidyoLogLevel : global::Java.Lang.Enum {


			static IntPtr VIDYO_LOGLEVEL_DEBUG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/field[@name='VIDYO_LOGLEVEL_DEBUG']"
			[Register ("VIDYO_LOGLEVEL_DEBUG")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel VidyoLoglevelDebug {
				get {
					if (VIDYO_LOGLEVEL_DEBUG_jfieldId == IntPtr.Zero)
						VIDYO_LOGLEVEL_DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOGLEVEL_DEBUG", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOGLEVEL_DEBUG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOGLEVEL_ENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/field[@name='VIDYO_LOGLEVEL_ENTER']"
			[Register ("VIDYO_LOGLEVEL_ENTER")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel VidyoLoglevelEnter {
				get {
					if (VIDYO_LOGLEVEL_ENTER_jfieldId == IntPtr.Zero)
						VIDYO_LOGLEVEL_ENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOGLEVEL_ENTER", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOGLEVEL_ENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOGLEVEL_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/field[@name='VIDYO_LOGLEVEL_ERROR']"
			[Register ("VIDYO_LOGLEVEL_ERROR")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel VidyoLoglevelError {
				get {
					if (VIDYO_LOGLEVEL_ERROR_jfieldId == IntPtr.Zero)
						VIDYO_LOGLEVEL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOGLEVEL_ERROR", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOGLEVEL_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOGLEVEL_FATAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/field[@name='VIDYO_LOGLEVEL_FATAL']"
			[Register ("VIDYO_LOGLEVEL_FATAL")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel VidyoLoglevelFatal {
				get {
					if (VIDYO_LOGLEVEL_FATAL_jfieldId == IntPtr.Zero)
						VIDYO_LOGLEVEL_FATAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOGLEVEL_FATAL", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOGLEVEL_FATAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOGLEVEL_INFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/field[@name='VIDYO_LOGLEVEL_INFO']"
			[Register ("VIDYO_LOGLEVEL_INFO")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel VidyoLoglevelInfo {
				get {
					if (VIDYO_LOGLEVEL_INFO_jfieldId == IntPtr.Zero)
						VIDYO_LOGLEVEL_INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOGLEVEL_INFO", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOGLEVEL_INFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOGLEVEL_INVALID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/field[@name='VIDYO_LOGLEVEL_INVALID']"
			[Register ("VIDYO_LOGLEVEL_INVALID")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel VidyoLoglevelInvalid {
				get {
					if (VIDYO_LOGLEVEL_INVALID_jfieldId == IntPtr.Zero)
						VIDYO_LOGLEVEL_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOGLEVEL_INVALID", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOGLEVEL_INVALID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOGLEVEL_LEAVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/field[@name='VIDYO_LOGLEVEL_LEAVE']"
			[Register ("VIDYO_LOGLEVEL_LEAVE")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel VidyoLoglevelLeave {
				get {
					if (VIDYO_LOGLEVEL_LEAVE_jfieldId == IntPtr.Zero)
						VIDYO_LOGLEVEL_LEAVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOGLEVEL_LEAVE", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOGLEVEL_LEAVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOGLEVEL_RECEIVED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/field[@name='VIDYO_LOGLEVEL_RECEIVED']"
			[Register ("VIDYO_LOGLEVEL_RECEIVED")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel VidyoLoglevelReceived {
				get {
					if (VIDYO_LOGLEVEL_RECEIVED_jfieldId == IntPtr.Zero)
						VIDYO_LOGLEVEL_RECEIVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOGLEVEL_RECEIVED", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOGLEVEL_RECEIVED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOGLEVEL_SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/field[@name='VIDYO_LOGLEVEL_SENT']"
			[Register ("VIDYO_LOGLEVEL_SENT")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel VidyoLoglevelSent {
				get {
					if (VIDYO_LOGLEVEL_SENT_jfieldId == IntPtr.Zero)
						VIDYO_LOGLEVEL_SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOGLEVEL_SENT", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOGLEVEL_SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOGLEVEL_WARNING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/field[@name='VIDYO_LOGLEVEL_WARNING']"
			[Register ("VIDYO_LOGLEVEL_WARNING")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel VidyoLoglevelWarning {
				get {
					if (VIDYO_LOGLEVEL_WARNING_jfieldId == IntPtr.Zero)
						VIDYO_LOGLEVEL_WARNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOGLEVEL_WARNING", "Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOGLEVEL_WARNING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoLogLevel); }
			}

			internal VidyoLogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord.VidyoLogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord$VidyoLogLevel;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoLogRecord.VidyoLogLevel));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoLogRecord", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoLogRecord); }
		}

		protected VidyoLogRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoLogRecord']/constructor[@name='VidyoLogRecord' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoLogRecord ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoLogRecord)) {
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
