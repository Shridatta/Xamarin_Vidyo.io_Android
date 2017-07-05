using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoRemoteMicrophoneStats", DoNotGenerateAcw=true)]
	public partial class VidyoRemoteMicrophoneStats : global::Java.Lang.Object {


		static IntPtr bitsPerSample_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='bitsPerSample']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='codecDtx']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='codecName']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='codecQualitySetting']"
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

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='id']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='localSpeakerStreams']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='name']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='numberOfChannels']"
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

		static IntPtr receiveNetworkBitRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='receiveNetworkBitRate']"
		[Register ("receiveNetworkBitRate")]
		public long ReceiveNetworkBitRate {
			get {
				if (receiveNetworkBitRate_jfieldId == IntPtr.Zero)
					receiveNetworkBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkBitRate", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, receiveNetworkBitRate_jfieldId);
			}
			set {
				if (receiveNetworkBitRate_jfieldId == IntPtr.Zero)
					receiveNetworkBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkBitRate", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receiveNetworkBitRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr receiveNetworkDelay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='receiveNetworkDelay']"
		[Register ("receiveNetworkDelay")]
		public long ReceiveNetworkDelay {
			get {
				if (receiveNetworkDelay_jfieldId == IntPtr.Zero)
					receiveNetworkDelay_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkDelay", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, receiveNetworkDelay_jfieldId);
			}
			set {
				if (receiveNetworkDelay_jfieldId == IntPtr.Zero)
					receiveNetworkDelay_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkDelay", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receiveNetworkDelay_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr receiveNetworkDroppedPackets_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='receiveNetworkDroppedPackets']"
		[Register ("receiveNetworkDroppedPackets")]
		public int ReceiveNetworkDroppedPackets {
			get {
				if (receiveNetworkDroppedPackets_jfieldId == IntPtr.Zero)
					receiveNetworkDroppedPackets_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkDroppedPackets", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, receiveNetworkDroppedPackets_jfieldId);
			}
			set {
				if (receiveNetworkDroppedPackets_jfieldId == IntPtr.Zero)
					receiveNetworkDroppedPackets_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkDroppedPackets", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receiveNetworkDroppedPackets_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr receiveNetworkJitter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='receiveNetworkJitter']"
		[Register ("receiveNetworkJitter")]
		public int ReceiveNetworkJitter {
			get {
				if (receiveNetworkJitter_jfieldId == IntPtr.Zero)
					receiveNetworkJitter_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkJitter", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, receiveNetworkJitter_jfieldId);
			}
			set {
				if (receiveNetworkJitter_jfieldId == IntPtr.Zero)
					receiveNetworkJitter_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkJitter", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receiveNetworkJitter_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sampleRateMeasured_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='sampleRateMeasured']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/field[@name='sampleRateSet']"
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
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoRemoteMicrophoneStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoRemoteMicrophoneStats); }
		}

		protected VidyoRemoteMicrophoneStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteMicrophoneStats']/constructor[@name='VidyoRemoteMicrophoneStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoRemoteMicrophoneStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoRemoteMicrophoneStats)) {
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
