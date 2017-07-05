using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoRemoteRendererStreamStats", DoNotGenerateAcw=true)]
	public partial class VidyoRemoteRendererStreamStats : global::Java.Lang.Object {


		static IntPtr codecFir_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='codecFir']"
		[Register ("codecFir")]
		public int CodecFir {
			get {
				if (codecFir_jfieldId == IntPtr.Zero)
					codecFir_jfieldId = JNIEnv.GetFieldID (class_ref, "codecFir", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codecFir_jfieldId);
			}
			set {
				if (codecFir_jfieldId == IntPtr.Zero)
					codecFir_jfieldId = JNIEnv.GetFieldID (class_ref, "codecFir", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecFir_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecIFrames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='codecIFrames']"
		[Register ("codecIFrames")]
		public int CodecIFrames {
			get {
				if (codecIFrames_jfieldId == IntPtr.Zero)
					codecIFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "codecIFrames", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codecIFrames_jfieldId);
			}
			set {
				if (codecIFrames_jfieldId == IntPtr.Zero)
					codecIFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "codecIFrames", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecIFrames_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecLayers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='codecLayers']"
		[Register ("codecLayers")]
		public int CodecLayers {
			get {
				if (codecLayers_jfieldId == IntPtr.Zero)
					codecLayers_jfieldId = JNIEnv.GetFieldID (class_ref, "codecLayers", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codecLayers_jfieldId);
			}
			set {
				if (codecLayers_jfieldId == IntPtr.Zero)
					codecLayers_jfieldId = JNIEnv.GetFieldID (class_ref, "codecLayers", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecLayers_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecNacks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='codecNacks']"
		[Register ("codecNacks")]
		public int CodecNacks {
			get {
				if (codecNacks_jfieldId == IntPtr.Zero)
					codecNacks_jfieldId = JNIEnv.GetFieldID (class_ref, "codecNacks", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codecNacks_jfieldId);
			}
			set {
				if (codecNacks_jfieldId == IntPtr.Zero)
					codecNacks_jfieldId = JNIEnv.GetFieldID (class_ref, "codecNacks", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecNacks_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='codecName']"
		[Register ("codecName")]
		public string CodecName {
			get {
				if (codecName_jfieldId == IntPtr.Zero)
					codecName_jfieldId = JNIEnv.GetFieldID (class_ref, "codecName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, codecName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (codecName_jfieldId == IntPtr.Zero)
					codecName_jfieldId = JNIEnv.GetFieldID (class_ref, "codecName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr fps_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='fps']"
		[Register ("fps")]
		public int Fps {
			get {
				if (fps_jfieldId == IntPtr.Zero)
					fps_jfieldId = JNIEnv.GetFieldID (class_ref, "fps", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, fps_jfieldId);
			}
			set {
				if (fps_jfieldId == IntPtr.Zero)
					fps_jfieldId = JNIEnv.GetFieldID (class_ref, "fps", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fps_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fpsInput_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='fpsInput']"
		[Register ("fpsInput")]
		public int FpsInput {
			get {
				if (fpsInput_jfieldId == IntPtr.Zero)
					fpsInput_jfieldId = JNIEnv.GetFieldID (class_ref, "fpsInput", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, fpsInput_jfieldId);
			}
			set {
				if (fpsInput_jfieldId == IntPtr.Zero)
					fpsInput_jfieldId = JNIEnv.GetFieldID (class_ref, "fpsInput", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fpsInput_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fpsSent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='fpsSent']"
		[Register ("fpsSent")]
		public int FpsSent {
			get {
				if (fpsSent_jfieldId == IntPtr.Zero)
					fpsSent_jfieldId = JNIEnv.GetFieldID (class_ref, "fpsSent", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, fpsSent_jfieldId);
			}
			set {
				if (fpsSent_jfieldId == IntPtr.Zero)
					fpsSent_jfieldId = JNIEnv.GetFieldID (class_ref, "fpsSent", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fpsSent_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr framesDropped_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='framesDropped']"
		[Register ("framesDropped")]
		public long FramesDropped {
			get {
				if (framesDropped_jfieldId == IntPtr.Zero)
					framesDropped_jfieldId = JNIEnv.GetFieldID (class_ref, "framesDropped", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, framesDropped_jfieldId);
			}
			set {
				if (framesDropped_jfieldId == IntPtr.Zero)
					framesDropped_jfieldId = JNIEnv.GetFieldID (class_ref, "framesDropped", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, framesDropped_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='height']"
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

		static IntPtr lastHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='lastHeight']"
		[Register ("lastHeight")]
		public long LastHeight {
			get {
				if (lastHeight_jfieldId == IntPtr.Zero)
					lastHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "lastHeight", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, lastHeight_jfieldId);
			}
			set {
				if (lastHeight_jfieldId == IntPtr.Zero)
					lastHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "lastHeight", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lastHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lastWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='lastWidth']"
		[Register ("lastWidth")]
		public long LastWidth {
			get {
				if (lastWidth_jfieldId == IntPtr.Zero)
					lastWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "lastWidth", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, lastWidth_jfieldId);
			}
			set {
				if (lastWidth_jfieldId == IntPtr.Zero)
					lastWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "lastWidth", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lastWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='name']"
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

		static IntPtr sendNetworkBitRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='sendNetworkBitRate']"
		[Register ("sendNetworkBitRate")]
		public int SendNetworkBitRate {
			get {
				if (sendNetworkBitRate_jfieldId == IntPtr.Zero)
					sendNetworkBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "sendNetworkBitRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sendNetworkBitRate_jfieldId);
			}
			set {
				if (sendNetworkBitRate_jfieldId == IntPtr.Zero)
					sendNetworkBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "sendNetworkBitRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sendNetworkBitRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sendNetworkRtt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='sendNetworkRtt']"
		[Register ("sendNetworkRtt")]
		public long SendNetworkRtt {
			get {
				if (sendNetworkRtt_jfieldId == IntPtr.Zero)
					sendNetworkRtt_jfieldId = JNIEnv.GetFieldID (class_ref, "sendNetworkRtt", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, sendNetworkRtt_jfieldId);
			}
			set {
				if (sendNetworkRtt_jfieldId == IntPtr.Zero)
					sendNetworkRtt_jfieldId = JNIEnv.GetFieldID (class_ref, "sendNetworkRtt", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sendNetworkRtt_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/field[@name='width']"
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
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoRemoteRendererStreamStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoRemoteRendererStreamStats); }
		}

		protected VidyoRemoteRendererStreamStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteRendererStreamStats']/constructor[@name='VidyoRemoteRendererStreamStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoRemoteRendererStreamStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoRemoteRendererStreamStats)) {
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
