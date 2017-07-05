using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoLocalSpeakerStreamStats", DoNotGenerateAcw=true)]
	public partial class VidyoLocalSpeakerStreamStats : global::Java.Lang.Object {


		static IntPtr bitsPerSample_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='bitsPerSample']"
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

		static IntPtr delay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='delay']"
		[Register ("delay")]
		public long Delay {
			get {
				if (delay_jfieldId == IntPtr.Zero)
					delay_jfieldId = JNIEnv.GetFieldID (class_ref, "delay", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, delay_jfieldId);
			}
			set {
				if (delay_jfieldId == IntPtr.Zero)
					delay_jfieldId = JNIEnv.GetFieldID (class_ref, "delay", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, delay_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr format_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='format']"
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

		static IntPtr highThreshold_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='highThreshold']"
		[Register ("highThreshold")]
		public long HighThreshold {
			get {
				if (highThreshold_jfieldId == IntPtr.Zero)
					highThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "highThreshold", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, highThreshold_jfieldId);
			}
			set {
				if (highThreshold_jfieldId == IntPtr.Zero)
					highThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "highThreshold", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, highThreshold_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr highestThreshold_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='highestThreshold']"
		[Register ("highestThreshold")]
		public long HighestThreshold {
			get {
				if (highestThreshold_jfieldId == IntPtr.Zero)
					highestThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "highestThreshold", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, highestThreshold_jfieldId);
			}
			set {
				if (highestThreshold_jfieldId == IntPtr.Zero)
					highestThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "highestThreshold", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, highestThreshold_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lastEnergy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='lastEnergy']"
		[Register ("lastEnergy")]
		public int LastEnergy {
			get {
				if (lastEnergy_jfieldId == IntPtr.Zero)
					lastEnergy_jfieldId = JNIEnv.GetFieldID (class_ref, "lastEnergy", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lastEnergy_jfieldId);
			}
			set {
				if (lastEnergy_jfieldId == IntPtr.Zero)
					lastEnergy_jfieldId = JNIEnv.GetFieldID (class_ref, "lastEnergy", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lastEnergy_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lastPlayed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='lastPlayed']"
		[Register ("lastPlayed")]
		public long LastPlayed {
			get {
				if (lastPlayed_jfieldId == IntPtr.Zero)
					lastPlayed_jfieldId = JNIEnv.GetFieldID (class_ref, "lastPlayed", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, lastPlayed_jfieldId);
			}
			set {
				if (lastPlayed_jfieldId == IntPtr.Zero)
					lastPlayed_jfieldId = JNIEnv.GetFieldID (class_ref, "lastPlayed", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lastPlayed_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lowThreshold_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='lowThreshold']"
		[Register ("lowThreshold")]
		public long LowThreshold {
			get {
				if (lowThreshold_jfieldId == IntPtr.Zero)
					lowThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "lowThreshold", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, lowThreshold_jfieldId);
			}
			set {
				if (lowThreshold_jfieldId == IntPtr.Zero)
					lowThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "lowThreshold", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lowThreshold_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lowestThreshold_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='lowestThreshold']"
		[Register ("lowestThreshold")]
		public long LowestThreshold {
			get {
				if (lowestThreshold_jfieldId == IntPtr.Zero)
					lowestThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "lowestThreshold", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, lowestThreshold_jfieldId);
			}
			set {
				if (lowestThreshold_jfieldId == IntPtr.Zero)
					lowestThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "lowestThreshold", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lowestThreshold_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxThreshold_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='maxThreshold']"
		[Register ("maxThreshold")]
		public long MaxThreshold {
			get {
				if (maxThreshold_jfieldId == IntPtr.Zero)
					maxThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "maxThreshold", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, maxThreshold_jfieldId);
			}
			set {
				if (maxThreshold_jfieldId == IntPtr.Zero)
					maxThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "maxThreshold", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxThreshold_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='name']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='numberOfChannels']"
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

		static IntPtr overrun_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='overrun']"
		[Register ("overrun")]
		public long Overrun {
			get {
				if (overrun_jfieldId == IntPtr.Zero)
					overrun_jfieldId = JNIEnv.GetFieldID (class_ref, "overrun", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, overrun_jfieldId);
			}
			set {
				if (overrun_jfieldId == IntPtr.Zero)
					overrun_jfieldId = JNIEnv.GetFieldID (class_ref, "overrun", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, overrun_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr played_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='played']"
		[Register ("played")]
		public long Played {
			get {
				if (played_jfieldId == IntPtr.Zero)
					played_jfieldId = JNIEnv.GetFieldID (class_ref, "played", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, played_jfieldId);
			}
			set {
				if (played_jfieldId == IntPtr.Zero)
					played_jfieldId = JNIEnv.GetFieldID (class_ref, "played", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, played_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sampleRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='sampleRate']"
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

		static IntPtr underrun_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/field[@name='underrun']"
		[Register ("underrun")]
		public long Underrun {
			get {
				if (underrun_jfieldId == IntPtr.Zero)
					underrun_jfieldId = JNIEnv.GetFieldID (class_ref, "underrun", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, underrun_jfieldId);
			}
			set {
				if (underrun_jfieldId == IntPtr.Zero)
					underrun_jfieldId = JNIEnv.GetFieldID (class_ref, "underrun", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, underrun_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoLocalSpeakerStreamStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoLocalSpeakerStreamStats); }
		}

		protected VidyoLocalSpeakerStreamStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoLocalSpeakerStreamStats']/constructor[@name='VidyoLocalSpeakerStreamStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoLocalSpeakerStreamStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoLocalSpeakerStreamStats)) {
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
