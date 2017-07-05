using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoParticipantGenerationStats", DoNotGenerateAcw=true)]
	public partial class VidyoParticipantGenerationStats : global::Java.Lang.Object {


		static IntPtr cameraId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']/field[@name='cameraId']"
		[Register ("cameraId")]
		public string CameraId {
			get {
				if (cameraId_jfieldId == IntPtr.Zero)
					cameraId_jfieldId = JNIEnv.GetFieldID (class_ref, "cameraId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cameraId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cameraId_jfieldId == IntPtr.Zero)
					cameraId_jfieldId = JNIEnv.GetFieldID (class_ref, "cameraId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cameraId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cameraName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']/field[@name='cameraName']"
		[Register ("cameraName")]
		public string CameraName {
			get {
				if (cameraName_jfieldId == IntPtr.Zero)
					cameraName_jfieldId = JNIEnv.GetFieldID (class_ref, "cameraName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cameraName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cameraName_jfieldId == IntPtr.Zero)
					cameraName_jfieldId = JNIEnv.GetFieldID (class_ref, "cameraName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cameraName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr enabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']/field[@name='enabled']"
		[Register ("enabled")]
		public bool Enabled {
			get {
				if (enabled_jfieldId == IntPtr.Zero)
					enabled_jfieldId = JNIEnv.GetFieldID (class_ref, "enabled", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, enabled_jfieldId);
			}
			set {
				if (enabled_jfieldId == IntPtr.Zero)
					enabled_jfieldId = JNIEnv.GetFieldID (class_ref, "enabled", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, enabled_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr frameInterval_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']/field[@name='frameInterval']"
		[Register ("frameInterval")]
		public long FrameInterval {
			get {
				if (frameInterval_jfieldId == IntPtr.Zero)
					frameInterval_jfieldId = JNIEnv.GetFieldID (class_ref, "frameInterval", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, frameInterval_jfieldId);
			}
			set {
				if (frameInterval_jfieldId == IntPtr.Zero)
					frameInterval_jfieldId = JNIEnv.GetFieldID (class_ref, "frameInterval", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameInterval_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']/field[@name='height']"
		[Register ("height")]
		public long Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']/field[@name='name']"
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

		static IntPtr pixelRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']/field[@name='pixelRate']"
		[Register ("pixelRate")]
		public long PixelRate {
			get {
				if (pixelRate_jfieldId == IntPtr.Zero)
					pixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "pixelRate", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, pixelRate_jfieldId);
			}
			set {
				if (pixelRate_jfieldId == IntPtr.Zero)
					pixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "pixelRate", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pixelRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']/field[@name='width']"
		[Register ("width")]
		public long Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoParticipantGenerationStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoParticipantGenerationStats); }
		}

		protected VidyoParticipantGenerationStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoParticipantGenerationStats']/constructor[@name='VidyoParticipantGenerationStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoParticipantGenerationStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoParticipantGenerationStats)) {
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
