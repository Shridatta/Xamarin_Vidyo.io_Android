using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRateShaperStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoRateShaperStats", DoNotGenerateAcw=true)]
	public partial class VidyoRateShaperStats : global::Java.Lang.Object {


		static IntPtr delayNormal_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRateShaperStats']/field[@name='delayNormal']"
		[Register ("delayNormal")]
		public int DelayNormal {
			get {
				if (delayNormal_jfieldId == IntPtr.Zero)
					delayNormal_jfieldId = JNIEnv.GetFieldID (class_ref, "delayNormal", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, delayNormal_jfieldId);
			}
			set {
				if (delayNormal_jfieldId == IntPtr.Zero)
					delayNormal_jfieldId = JNIEnv.GetFieldID (class_ref, "delayNormal", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, delayNormal_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr delayRetransmit_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRateShaperStats']/field[@name='delayRetransmit']"
		[Register ("delayRetransmit")]
		public int DelayRetransmit {
			get {
				if (delayRetransmit_jfieldId == IntPtr.Zero)
					delayRetransmit_jfieldId = JNIEnv.GetFieldID (class_ref, "delayRetransmit", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, delayRetransmit_jfieldId);
			}
			set {
				if (delayRetransmit_jfieldId == IntPtr.Zero)
					delayRetransmit_jfieldId = JNIEnv.GetFieldID (class_ref, "delayRetransmit", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, delayRetransmit_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr dropNormal_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRateShaperStats']/field[@name='dropNormal']"
		[Register ("dropNormal")]
		public int DropNormal {
			get {
				if (dropNormal_jfieldId == IntPtr.Zero)
					dropNormal_jfieldId = JNIEnv.GetFieldID (class_ref, "dropNormal", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, dropNormal_jfieldId);
			}
			set {
				if (dropNormal_jfieldId == IntPtr.Zero)
					dropNormal_jfieldId = JNIEnv.GetFieldID (class_ref, "dropNormal", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dropNormal_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr packetsNormal_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRateShaperStats']/field[@name='packetsNormal']"
		[Register ("packetsNormal")]
		public int PacketsNormal {
			get {
				if (packetsNormal_jfieldId == IntPtr.Zero)
					packetsNormal_jfieldId = JNIEnv.GetFieldID (class_ref, "packetsNormal", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, packetsNormal_jfieldId);
			}
			set {
				if (packetsNormal_jfieldId == IntPtr.Zero)
					packetsNormal_jfieldId = JNIEnv.GetFieldID (class_ref, "packetsNormal", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, packetsNormal_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr packetsRetransmit_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRateShaperStats']/field[@name='packetsRetransmit']"
		[Register ("packetsRetransmit")]
		public int PacketsRetransmit {
			get {
				if (packetsRetransmit_jfieldId == IntPtr.Zero)
					packetsRetransmit_jfieldId = JNIEnv.GetFieldID (class_ref, "packetsRetransmit", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, packetsRetransmit_jfieldId);
			}
			set {
				if (packetsRetransmit_jfieldId == IntPtr.Zero)
					packetsRetransmit_jfieldId = JNIEnv.GetFieldID (class_ref, "packetsRetransmit", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, packetsRetransmit_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoRateShaperStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoRateShaperStats); }
		}

		protected VidyoRateShaperStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRateShaperStats']/constructor[@name='VidyoRateShaperStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoRateShaperStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoRateShaperStats)) {
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
