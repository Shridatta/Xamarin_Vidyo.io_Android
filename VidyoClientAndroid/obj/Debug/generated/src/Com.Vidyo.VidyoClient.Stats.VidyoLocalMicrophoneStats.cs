using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoLocalMicrophoneStats", DoNotGenerateAcw=true)]
	public partial class VidyoLocalMicrophoneStats : global::Java.Lang.Object {


		static IntPtr aecEchoCoupling_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='aecEchoCoupling']"
		[Register ("aecEchoCoupling")]
		public int AecEchoCoupling {
			get {
				if (aecEchoCoupling_jfieldId == IntPtr.Zero)
					aecEchoCoupling_jfieldId = JNIEnv.GetFieldID (class_ref, "aecEchoCoupling", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, aecEchoCoupling_jfieldId);
			}
			set {
				if (aecEchoCoupling_jfieldId == IntPtr.Zero)
					aecEchoCoupling_jfieldId = JNIEnv.GetFieldID (class_ref, "aecEchoCoupling", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, aecEchoCoupling_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr agcAverageGain_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='agcAverageGain']"
		[Register ("agcAverageGain")]
		public int AgcAverageGain {
			get {
				if (agcAverageGain_jfieldId == IntPtr.Zero)
					agcAverageGain_jfieldId = JNIEnv.GetFieldID (class_ref, "agcAverageGain", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, agcAverageGain_jfieldId);
			}
			set {
				if (agcAverageGain_jfieldId == IntPtr.Zero)
					agcAverageGain_jfieldId = JNIEnv.GetFieldID (class_ref, "agcAverageGain", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, agcAverageGain_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bitsPerSample_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='bitsPerSample']"
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

		static IntPtr format_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='format']"
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

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='id']"
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

		static IntPtr localSpeakerStreams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='localSpeakerStreams']"
		[Register ("localSpeakerStreams")]
		public global::System.Collections.IList LocalSpeakerStreams {
			get {
				if (localSpeakerStreams_jfieldId == IntPtr.Zero)
					localSpeakerStreams_jfieldId = JNIEnv.GetFieldID (class_ref, "localSpeakerStreams", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, localSpeakerStreams_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (localSpeakerStreams_jfieldId == IntPtr.Zero)
					localSpeakerStreams_jfieldId = JNIEnv.GetFieldID (class_ref, "localSpeakerStreams", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, localSpeakerStreams_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='name']"
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

		static IntPtr noiseSuppressionSnr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='noiseSuppressionSnr']"
		[Register ("noiseSuppressionSnr")]
		public int NoiseSuppressionSnr {
			get {
				if (noiseSuppressionSnr_jfieldId == IntPtr.Zero)
					noiseSuppressionSnr_jfieldId = JNIEnv.GetFieldID (class_ref, "noiseSuppressionSnr", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, noiseSuppressionSnr_jfieldId);
			}
			set {
				if (noiseSuppressionSnr_jfieldId == IntPtr.Zero)
					noiseSuppressionSnr_jfieldId = JNIEnv.GetFieldID (class_ref, "noiseSuppressionSnr", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, noiseSuppressionSnr_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr numberOfChannels_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='numberOfChannels']"
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

		static IntPtr remoteSpeakerStreams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='remoteSpeakerStreams']"
		[Register ("remoteSpeakerStreams")]
		public global::System.Collections.IList RemoteSpeakerStreams {
			get {
				if (remoteSpeakerStreams_jfieldId == IntPtr.Zero)
					remoteSpeakerStreams_jfieldId = JNIEnv.GetFieldID (class_ref, "remoteSpeakerStreams", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, remoteSpeakerStreams_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (remoteSpeakerStreams_jfieldId == IntPtr.Zero)
					remoteSpeakerStreams_jfieldId = JNIEnv.GetFieldID (class_ref, "remoteSpeakerStreams", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, remoteSpeakerStreams_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sampleRateMeasured_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='sampleRateMeasured']"
		[Register ("sampleRateMeasured")]
		public int SampleRateMeasured {
			get {
				if (sampleRateMeasured_jfieldId == IntPtr.Zero)
					sampleRateMeasured_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleRateMeasured", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sampleRateMeasured_jfieldId);
			}
			set {
				if (sampleRateMeasured_jfieldId == IntPtr.Zero)
					sampleRateMeasured_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleRateMeasured", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sampleRateMeasured_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sampleRateSet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/field[@name='sampleRateSet']"
		[Register ("sampleRateSet")]
		public int SampleRateSet {
			get {
				if (sampleRateSet_jfieldId == IntPtr.Zero)
					sampleRateSet_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleRateSet", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sampleRateSet_jfieldId);
			}
			set {
				if (sampleRateSet_jfieldId == IntPtr.Zero)
					sampleRateSet_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleRateSet", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sampleRateSet_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoLocalMicrophoneStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoLocalMicrophoneStats); }
		}

		protected VidyoLocalMicrophoneStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalMicrophoneStats']/constructor[@name='VidyoLocalMicrophoneStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoLocalMicrophoneStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoLocalMicrophoneStats)) {
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
