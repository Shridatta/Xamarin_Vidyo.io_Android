using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoRemoteSpeakerStreamStats", DoNotGenerateAcw=true)]
	public partial class VidyoRemoteSpeakerStreamStats : global::Java.Lang.Object {


		static IntPtr bitsPerSample_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']/field[@name='bitsPerSample']"
		[Register ("bitsPerSample")]
		public int BitsPerSample {
			get {
				if (bitsPerSample_jfieldId == IntPtr.Zero)
					bitsPerSample_jfieldId = JNIEnv.GetFieldID (class_ref, "bitsPerSample", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, bitsPerSample_jfieldId);
			}
			set {
				if (bitsPerSample_jfieldId == IntPtr.Zero)
					bitsPerSample_jfieldId = JNIEnv.GetFieldID (class_ref, "bitsPerSample", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bitsPerSample_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecDtx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']/field[@name='codecDtx']"
		[Register ("codecDtx")]
		public int CodecDtx {
			get {
				if (codecDtx_jfieldId == IntPtr.Zero)
					codecDtx_jfieldId = JNIEnv.GetFieldID (class_ref, "codecDtx", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codecDtx_jfieldId);
			}
			set {
				if (codecDtx_jfieldId == IntPtr.Zero)
					codecDtx_jfieldId = JNIEnv.GetFieldID (class_ref, "codecDtx", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecDtx_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']/field[@name='codecName']"
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

		static IntPtr codecQualitySetting_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']/field[@name='codecQualitySetting']"
		[Register ("codecQualitySetting")]
		public int CodecQualitySetting {
			get {
				if (codecQualitySetting_jfieldId == IntPtr.Zero)
					codecQualitySetting_jfieldId = JNIEnv.GetFieldID (class_ref, "codecQualitySetting", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codecQualitySetting_jfieldId);
			}
			set {
				if (codecQualitySetting_jfieldId == IntPtr.Zero)
					codecQualitySetting_jfieldId = JNIEnv.GetFieldID (class_ref, "codecQualitySetting", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecQualitySetting_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']/field[@name='name']"
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

		static IntPtr numberOfChannels_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']/field[@name='numberOfChannels']"
		[Register ("numberOfChannels")]
		public int NumberOfChannels {
			get {
				if (numberOfChannels_jfieldId == IntPtr.Zero)
					numberOfChannels_jfieldId = JNIEnv.GetFieldID (class_ref, "numberOfChannels", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, numberOfChannels_jfieldId);
			}
			set {
				if (numberOfChannels_jfieldId == IntPtr.Zero)
					numberOfChannels_jfieldId = JNIEnv.GetFieldID (class_ref, "numberOfChannels", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, numberOfChannels_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sampleRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']/field[@name='sampleRate']"
		[Register ("sampleRate")]
		public int SampleRate {
			get {
				if (sampleRate_jfieldId == IntPtr.Zero)
					sampleRate_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sampleRate_jfieldId);
			}
			set {
				if (sampleRate_jfieldId == IntPtr.Zero)
					sampleRate_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sampleRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sendNetworkBitRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']/field[@name='sendNetworkBitRate']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']/field[@name='sendNetworkRtt']"
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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoRemoteSpeakerStreamStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoRemoteSpeakerStreamStats); }
		}

		protected VidyoRemoteSpeakerStreamStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteSpeakerStreamStats']/constructor[@name='VidyoRemoteSpeakerStreamStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoRemoteSpeakerStreamStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoRemoteSpeakerStreamStats)) {
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
