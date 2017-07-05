using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoRoomStats", DoNotGenerateAcw=true)]
	public partial class VidyoRoomStats : global::Java.Lang.Object {


		static IntPtr bandwidthApp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='bandwidthApp']"
		[Register ("bandwidthApp")]
		public global::Com.Vidyo.VidyoClient.Stats.VidyoBandwidthSummaryStats BandwidthApp {
			get {
				if (bandwidthApp_jfieldId == IntPtr.Zero)
					bandwidthApp_jfieldId = JNIEnv.GetFieldID (class_ref, "bandwidthApp", "Lcom/vidyo/VidyoClient/Stats/VidyoBandwidthSummaryStats;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bandwidthApp_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Stats.VidyoBandwidthSummaryStats> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bandwidthApp_jfieldId == IntPtr.Zero)
					bandwidthApp_jfieldId = JNIEnv.GetFieldID (class_ref, "bandwidthApp", "Lcom/vidyo/VidyoClient/Stats/VidyoBandwidthSummaryStats;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bandwidthApp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr bandwidthAudio_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='bandwidthAudio']"
		[Register ("bandwidthAudio")]
		public global::Com.Vidyo.VidyoClient.Stats.VidyoBandwidthSummaryStats BandwidthAudio {
			get {
				if (bandwidthAudio_jfieldId == IntPtr.Zero)
					bandwidthAudio_jfieldId = JNIEnv.GetFieldID (class_ref, "bandwidthAudio", "Lcom/vidyo/VidyoClient/Stats/VidyoBandwidthSummaryStats;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bandwidthAudio_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Stats.VidyoBandwidthSummaryStats> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bandwidthAudio_jfieldId == IntPtr.Zero)
					bandwidthAudio_jfieldId = JNIEnv.GetFieldID (class_ref, "bandwidthAudio", "Lcom/vidyo/VidyoClient/Stats/VidyoBandwidthSummaryStats;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bandwidthAudio_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr bandwidthVideo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='bandwidthVideo']"
		[Register ("bandwidthVideo")]
		public global::Com.Vidyo.VidyoClient.Stats.VidyoBandwidthSummaryStats BandwidthVideo {
			get {
				if (bandwidthVideo_jfieldId == IntPtr.Zero)
					bandwidthVideo_jfieldId = JNIEnv.GetFieldID (class_ref, "bandwidthVideo", "Lcom/vidyo/VidyoClient/Stats/VidyoBandwidthSummaryStats;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bandwidthVideo_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Stats.VidyoBandwidthSummaryStats> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bandwidthVideo_jfieldId == IntPtr.Zero)
					bandwidthVideo_jfieldId = JNIEnv.GetFieldID (class_ref, "bandwidthVideo", "Lcom/vidyo/VidyoClient/Stats/VidyoBandwidthSummaryStats;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bandwidthVideo_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr conferenceId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='conferenceId']"
		[Register ("conferenceId")]
		public string ConferenceId {
			get {
				if (conferenceId_jfieldId == IntPtr.Zero)
					conferenceId_jfieldId = JNIEnv.GetFieldID (class_ref, "conferenceId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, conferenceId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (conferenceId_jfieldId == IntPtr.Zero)
					conferenceId_jfieldId = JNIEnv.GetFieldID (class_ref, "conferenceId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, conferenceId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cpuUsage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='cpuUsage']"
		[Register ("cpuUsage")]
		public int CpuUsage {
			get {
				if (cpuUsage_jfieldId == IntPtr.Zero)
					cpuUsage_jfieldId = JNIEnv.GetFieldID (class_ref, "cpuUsage", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, cpuUsage_jfieldId);
			}
			set {
				if (cpuUsage_jfieldId == IntPtr.Zero)
					cpuUsage_jfieldId = JNIEnv.GetFieldID (class_ref, "cpuUsage", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cpuUsage_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr currentBandwidthDecodePixelRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='currentBandwidthDecodePixelRate']"
		[Register ("currentBandwidthDecodePixelRate")]
		public long CurrentBandwidthDecodePixelRate {
			get {
				if (currentBandwidthDecodePixelRate_jfieldId == IntPtr.Zero)
					currentBandwidthDecodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "currentBandwidthDecodePixelRate", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, currentBandwidthDecodePixelRate_jfieldId);
			}
			set {
				if (currentBandwidthDecodePixelRate_jfieldId == IntPtr.Zero)
					currentBandwidthDecodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "currentBandwidthDecodePixelRate", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, currentBandwidthDecodePixelRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr currentBandwidthEncodePixelRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='currentBandwidthEncodePixelRate']"
		[Register ("currentBandwidthEncodePixelRate")]
		public long CurrentBandwidthEncodePixelRate {
			get {
				if (currentBandwidthEncodePixelRate_jfieldId == IntPtr.Zero)
					currentBandwidthEncodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "currentBandwidthEncodePixelRate", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, currentBandwidthEncodePixelRate_jfieldId);
			}
			set {
				if (currentBandwidthEncodePixelRate_jfieldId == IntPtr.Zero)
					currentBandwidthEncodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "currentBandwidthEncodePixelRate", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, currentBandwidthEncodePixelRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr currentCpuDecodePixelRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='currentCpuDecodePixelRate']"
		[Register ("currentCpuDecodePixelRate")]
		public long CurrentCpuDecodePixelRate {
			get {
				if (currentCpuDecodePixelRate_jfieldId == IntPtr.Zero)
					currentCpuDecodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "currentCpuDecodePixelRate", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, currentCpuDecodePixelRate_jfieldId);
			}
			set {
				if (currentCpuDecodePixelRate_jfieldId == IntPtr.Zero)
					currentCpuDecodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "currentCpuDecodePixelRate", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, currentCpuDecodePixelRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr currentCpuEncodePixelRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='currentCpuEncodePixelRate']"
		[Register ("currentCpuEncodePixelRate")]
		public long CurrentCpuEncodePixelRate {
			get {
				if (currentCpuEncodePixelRate_jfieldId == IntPtr.Zero)
					currentCpuEncodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "currentCpuEncodePixelRate", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, currentCpuEncodePixelRate_jfieldId);
			}
			set {
				if (currentCpuEncodePixelRate_jfieldId == IntPtr.Zero)
					currentCpuEncodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "currentCpuEncodePixelRate", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, currentCpuEncodePixelRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='id']"
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

		static IntPtr maxDecodePixelRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='maxDecodePixelRate']"
		[Register ("maxDecodePixelRate")]
		public long MaxDecodePixelRate {
			get {
				if (maxDecodePixelRate_jfieldId == IntPtr.Zero)
					maxDecodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "maxDecodePixelRate", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, maxDecodePixelRate_jfieldId);
			}
			set {
				if (maxDecodePixelRate_jfieldId == IntPtr.Zero)
					maxDecodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "maxDecodePixelRate", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxDecodePixelRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxEncodePixelRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='maxEncodePixelRate']"
		[Register ("maxEncodePixelRate")]
		public long MaxEncodePixelRate {
			get {
				if (maxEncodePixelRate_jfieldId == IntPtr.Zero)
					maxEncodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "maxEncodePixelRate", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, maxEncodePixelRate_jfieldId);
			}
			set {
				if (maxEncodePixelRate_jfieldId == IntPtr.Zero)
					maxEncodePixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "maxEncodePixelRate", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxEncodePixelRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxVideoSources_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='maxVideoSources']"
		[Register ("maxVideoSources")]
		public int MaxVideoSources {
			get {
				if (maxVideoSources_jfieldId == IntPtr.Zero)
					maxVideoSources_jfieldId = JNIEnv.GetFieldID (class_ref, "maxVideoSources", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, maxVideoSources_jfieldId);
			}
			set {
				if (maxVideoSources_jfieldId == IntPtr.Zero)
					maxVideoSources_jfieldId = JNIEnv.GetFieldID (class_ref, "maxVideoSources", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxVideoSources_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr participantGenerationStats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='participantGenerationStats']"
		[Register ("participantGenerationStats")]
		public global::System.Collections.IList ParticipantGenerationStats {
			get {
				if (participantGenerationStats_jfieldId == IntPtr.Zero)
					participantGenerationStats_jfieldId = JNIEnv.GetFieldID (class_ref, "participantGenerationStats", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, participantGenerationStats_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (participantGenerationStats_jfieldId == IntPtr.Zero)
					participantGenerationStats_jfieldId = JNIEnv.GetFieldID (class_ref, "participantGenerationStats", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, participantGenerationStats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr participantStats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='participantStats']"
		[Register ("participantStats")]
		public global::System.Collections.IList ParticipantStats {
			get {
				if (participantStats_jfieldId == IntPtr.Zero)
					participantStats_jfieldId = JNIEnv.GetFieldID (class_ref, "participantStats", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, participantStats_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (participantStats_jfieldId == IntPtr.Zero)
					participantStats_jfieldId = JNIEnv.GetFieldID (class_ref, "participantStats", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, participantStats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr rateShaperApp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='rateShaperApp']"
		[Register ("rateShaperApp")]
		public global::Com.Vidyo.VidyoClient.Stats.VidyoRateShaperStats RateShaperApp {
			get {
				if (rateShaperApp_jfieldId == IntPtr.Zero)
					rateShaperApp_jfieldId = JNIEnv.GetFieldID (class_ref, "rateShaperApp", "Lcom/vidyo/VidyoClient/Stats/VidyoRateShaperStats;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rateShaperApp_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Stats.VidyoRateShaperStats> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rateShaperApp_jfieldId == IntPtr.Zero)
					rateShaperApp_jfieldId = JNIEnv.GetFieldID (class_ref, "rateShaperApp", "Lcom/vidyo/VidyoClient/Stats/VidyoRateShaperStats;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rateShaperApp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr rateShaperAudio_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='rateShaperAudio']"
		[Register ("rateShaperAudio")]
		public global::Com.Vidyo.VidyoClient.Stats.VidyoRateShaperStats RateShaperAudio {
			get {
				if (rateShaperAudio_jfieldId == IntPtr.Zero)
					rateShaperAudio_jfieldId = JNIEnv.GetFieldID (class_ref, "rateShaperAudio", "Lcom/vidyo/VidyoClient/Stats/VidyoRateShaperStats;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rateShaperAudio_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Stats.VidyoRateShaperStats> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rateShaperAudio_jfieldId == IntPtr.Zero)
					rateShaperAudio_jfieldId = JNIEnv.GetFieldID (class_ref, "rateShaperAudio", "Lcom/vidyo/VidyoClient/Stats/VidyoRateShaperStats;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rateShaperAudio_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr rateShaperVideo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='rateShaperVideo']"
		[Register ("rateShaperVideo")]
		public global::Com.Vidyo.VidyoClient.Stats.VidyoRateShaperStats RateShaperVideo {
			get {
				if (rateShaperVideo_jfieldId == IntPtr.Zero)
					rateShaperVideo_jfieldId = JNIEnv.GetFieldID (class_ref, "rateShaperVideo", "Lcom/vidyo/VidyoClient/Stats/VidyoRateShaperStats;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rateShaperVideo_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Stats.VidyoRateShaperStats> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rateShaperVideo_jfieldId == IntPtr.Zero)
					rateShaperVideo_jfieldId = JNIEnv.GetFieldID (class_ref, "rateShaperVideo", "Lcom/vidyo/VidyoClient/Stats/VidyoRateShaperStats;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rateShaperVideo_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr receiveBitRateAvailable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='receiveBitRateAvailable']"
		[Register ("receiveBitRateAvailable")]
		public long ReceiveBitRateAvailable {
			get {
				if (receiveBitRateAvailable_jfieldId == IntPtr.Zero)
					receiveBitRateAvailable_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveBitRateAvailable", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, receiveBitRateAvailable_jfieldId);
			}
			set {
				if (receiveBitRateAvailable_jfieldId == IntPtr.Zero)
					receiveBitRateAvailable_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveBitRateAvailable", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receiveBitRateAvailable_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr receiveBitRateTotal_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='receiveBitRateTotal']"
		[Register ("receiveBitRateTotal")]
		public long ReceiveBitRateTotal {
			get {
				if (receiveBitRateTotal_jfieldId == IntPtr.Zero)
					receiveBitRateTotal_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveBitRateTotal", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, receiveBitRateTotal_jfieldId);
			}
			set {
				if (receiveBitRateTotal_jfieldId == IntPtr.Zero)
					receiveBitRateTotal_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveBitRateTotal", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receiveBitRateTotal_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr reflectorId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='reflectorId']"
		[Register ("reflectorId")]
		public string ReflectorId {
			get {
				if (reflectorId_jfieldId == IntPtr.Zero)
					reflectorId_jfieldId = JNIEnv.GetFieldID (class_ref, "reflectorId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, reflectorId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (reflectorId_jfieldId == IntPtr.Zero)
					reflectorId_jfieldId = JNIEnv.GetFieldID (class_ref, "reflectorId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, reflectorId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sendBitRateAvailable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='sendBitRateAvailable']"
		[Register ("sendBitRateAvailable")]
		public long SendBitRateAvailable {
			get {
				if (sendBitRateAvailable_jfieldId == IntPtr.Zero)
					sendBitRateAvailable_jfieldId = JNIEnv.GetFieldID (class_ref, "sendBitRateAvailable", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, sendBitRateAvailable_jfieldId);
			}
			set {
				if (sendBitRateAvailable_jfieldId == IntPtr.Zero)
					sendBitRateAvailable_jfieldId = JNIEnv.GetFieldID (class_ref, "sendBitRateAvailable", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sendBitRateAvailable_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sendBitRateTotal_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='sendBitRateTotal']"
		[Register ("sendBitRateTotal")]
		public long SendBitRateTotal {
			get {
				if (sendBitRateTotal_jfieldId == IntPtr.Zero)
					sendBitRateTotal_jfieldId = JNIEnv.GetFieldID (class_ref, "sendBitRateTotal", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, sendBitRateTotal_jfieldId);
			}
			set {
				if (sendBitRateTotal_jfieldId == IntPtr.Zero)
					sendBitRateTotal_jfieldId = JNIEnv.GetFieldID (class_ref, "sendBitRateTotal", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sendBitRateTotal_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr staticSources_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='staticSources']"
		[Register ("staticSources")]
		public int StaticSources {
			get {
				if (staticSources_jfieldId == IntPtr.Zero)
					staticSources_jfieldId = JNIEnv.GetFieldID (class_ref, "staticSources", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, staticSources_jfieldId);
			}
			set {
				if (staticSources_jfieldId == IntPtr.Zero)
					staticSources_jfieldId = JNIEnv.GetFieldID (class_ref, "staticSources", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, staticSources_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr transportInformation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/field[@name='transportInformation']"
		[Register ("transportInformation")]
		public global::System.Collections.IList TransportInformation {
			get {
				if (transportInformation_jfieldId == IntPtr.Zero)
					transportInformation_jfieldId = JNIEnv.GetFieldID (class_ref, "transportInformation", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, transportInformation_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (transportInformation_jfieldId == IntPtr.Zero)
					transportInformation_jfieldId = JNIEnv.GetFieldID (class_ref, "transportInformation", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, transportInformation_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoRoomStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoRoomStats); }
		}

		protected VidyoRoomStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRoomStats']/constructor[@name='VidyoRoomStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoRoomStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoRoomStats)) {
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
