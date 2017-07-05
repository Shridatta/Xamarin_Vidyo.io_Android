using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoLocalRendererStats", DoNotGenerateAcw=true)]
	public partial class VidyoLocalRendererStats : global::Java.Lang.Object {


		static IntPtr format_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']/field[@name='format']"
		[Register ("format")]
		public global::Com.Vidyo.VidyoClient.Endpoint.VidyoMediaFormat Format {
			get {
				if (format_jfieldId == IntPtr.Zero)
					format_jfieldId = JNIEnv.GetFieldID (class_ref, "format", "Lcom/vidyo/VidyoClient/Endpoint/VidyoMediaFormat;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, format_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoMediaFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (format_jfieldId == IntPtr.Zero)
					format_jfieldId = JNIEnv.GetFieldID (class_ref, "format", "Lcom/vidyo/VidyoClient/Endpoint/VidyoMediaFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, format_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr frameIntervalMeasured_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']/field[@name='frameIntervalMeasured']"
		[Register ("frameIntervalMeasured")]
		public long FrameIntervalMeasured {
			get {
				if (frameIntervalMeasured_jfieldId == IntPtr.Zero)
					frameIntervalMeasured_jfieldId = JNIEnv.GetFieldID (class_ref, "frameIntervalMeasured", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, frameIntervalMeasured_jfieldId);
			}
			set {
				if (frameIntervalMeasured_jfieldId == IntPtr.Zero)
					frameIntervalMeasured_jfieldId = JNIEnv.GetFieldID (class_ref, "frameIntervalMeasured", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameIntervalMeasured_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr frameIntervalSet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']/field[@name='frameIntervalSet']"
		[Register ("frameIntervalSet")]
		public long FrameIntervalSet {
			get {
				if (frameIntervalSet_jfieldId == IntPtr.Zero)
					frameIntervalSet_jfieldId = JNIEnv.GetFieldID (class_ref, "frameIntervalSet", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, frameIntervalSet_jfieldId);
			}
			set {
				if (frameIntervalSet_jfieldId == IntPtr.Zero)
					frameIntervalSet_jfieldId = JNIEnv.GetFieldID (class_ref, "frameIntervalSet", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameIntervalSet_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']/field[@name='height']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']/field[@name='id']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']/field[@name='name']"
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

		static IntPtr totalFrames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']/field[@name='totalFrames']"
		[Register ("totalFrames")]
		public int TotalFrames {
			get {
				if (totalFrames_jfieldId == IntPtr.Zero)
					totalFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "totalFrames", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, totalFrames_jfieldId);
			}
			set {
				if (totalFrames_jfieldId == IntPtr.Zero)
					totalFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "totalFrames", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, totalFrames_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr totalPixels_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']/field[@name='totalPixels']"
		[Register ("totalPixels")]
		public int TotalPixels {
			get {
				if (totalPixels_jfieldId == IntPtr.Zero)
					totalPixels_jfieldId = JNIEnv.GetFieldID (class_ref, "totalPixels", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, totalPixels_jfieldId);
			}
			set {
				if (totalPixels_jfieldId == IntPtr.Zero)
					totalPixels_jfieldId = JNIEnv.GetFieldID (class_ref, "totalPixels", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, totalPixels_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']/field[@name='width']"
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
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoLocalRendererStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoLocalRendererStats); }
		}

		protected VidyoLocalRendererStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalRendererStats']/constructor[@name='VidyoLocalRendererStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoLocalRendererStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoLocalRendererStats)) {
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