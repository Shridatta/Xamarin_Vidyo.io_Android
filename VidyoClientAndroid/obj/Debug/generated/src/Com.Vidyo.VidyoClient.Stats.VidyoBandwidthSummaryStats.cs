using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoBandwidthSummaryStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoBandwidthSummaryStats", DoNotGenerateAcw=true)]
	public partial class VidyoBandwidthSummaryStats : global::Java.Lang.Object {


		static IntPtr actualEncoderBitRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoBandwidthSummaryStats']/field[@name='actualEncoderBitRate']"
		[Register ("actualEncoderBitRate")]
		public int ActualEncoderBitRate {
			get {
				if (actualEncoderBitRate_jfieldId == IntPtr.Zero)
					actualEncoderBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "actualEncoderBitRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, actualEncoderBitRate_jfieldId);
			}
			set {
				if (actualEncoderBitRate_jfieldId == IntPtr.Zero)
					actualEncoderBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "actualEncoderBitRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, actualEncoderBitRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr availableBandwidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoBandwidthSummaryStats']/field[@name='availableBandwidth']"
		[Register ("availableBandwidth")]
		public int AvailableBandwidth {
			get {
				if (availableBandwidth_jfieldId == IntPtr.Zero)
					availableBandwidth_jfieldId = JNIEnv.GetFieldID (class_ref, "availableBandwidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, availableBandwidth_jfieldId);
			}
			set {
				if (availableBandwidth_jfieldId == IntPtr.Zero)
					availableBandwidth_jfieldId = JNIEnv.GetFieldID (class_ref, "availableBandwidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, availableBandwidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr leakyBucketDelay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoBandwidthSummaryStats']/field[@name='leakyBucketDelay']"
		[Register ("leakyBucketDelay")]
		public int LeakyBucketDelay {
			get {
				if (leakyBucketDelay_jfieldId == IntPtr.Zero)
					leakyBucketDelay_jfieldId = JNIEnv.GetFieldID (class_ref, "leakyBucketDelay", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, leakyBucketDelay_jfieldId);
			}
			set {
				if (leakyBucketDelay_jfieldId == IntPtr.Zero)
					leakyBucketDelay_jfieldId = JNIEnv.GetFieldID (class_ref, "leakyBucketDelay", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, leakyBucketDelay_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr retransmitBitRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoBandwidthSummaryStats']/field[@name='retransmitBitRate']"
		[Register ("retransmitBitRate")]
		public int RetransmitBitRate {
			get {
				if (retransmitBitRate_jfieldId == IntPtr.Zero)
					retransmitBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "retransmitBitRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, retransmitBitRate_jfieldId);
			}
			set {
				if (retransmitBitRate_jfieldId == IntPtr.Zero)
					retransmitBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "retransmitBitRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, retransmitBitRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr targetEncoderBitRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoBandwidthSummaryStats']/field[@name='targetEncoderBitRate']"
		[Register ("targetEncoderBitRate")]
		public int TargetEncoderBitRate {
			get {
				if (targetEncoderBitRate_jfieldId == IntPtr.Zero)
					targetEncoderBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "targetEncoderBitRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, targetEncoderBitRate_jfieldId);
			}
			set {
				if (targetEncoderBitRate_jfieldId == IntPtr.Zero)
					targetEncoderBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "targetEncoderBitRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, targetEncoderBitRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr totalTransmitBitRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoBandwidthSummaryStats']/field[@name='totalTransmitBitRate']"
		[Register ("totalTransmitBitRate")]
		public int TotalTransmitBitRate {
			get {
				if (totalTransmitBitRate_jfieldId == IntPtr.Zero)
					totalTransmitBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "totalTransmitBitRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, totalTransmitBitRate_jfieldId);
			}
			set {
				if (totalTransmitBitRate_jfieldId == IntPtr.Zero)
					totalTransmitBitRate_jfieldId = JNIEnv.GetFieldID (class_ref, "totalTransmitBitRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, totalTransmitBitRate_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoBandwidthSummaryStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoBandwidthSummaryStats); }
		}

		protected VidyoBandwidthSummaryStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoBandwidthSummaryStats']/constructor[@name='VidyoBandwidthSummaryStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoBandwidthSummaryStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoBandwidthSummaryStats)) {
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
