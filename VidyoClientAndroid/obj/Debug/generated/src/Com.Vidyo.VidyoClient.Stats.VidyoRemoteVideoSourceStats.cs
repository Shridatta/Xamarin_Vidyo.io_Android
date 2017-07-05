using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoRemoteVideoSourceStats", DoNotGenerateAcw=true)]
	public partial class VidyoRemoteVideoSourceStats : global::Java.Lang.Object {


		static IntPtr codecFir_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='codecFir']"
		[Register ("codecFir")]
		public long CodecFir {
			get {
				if (codecFir_jfieldId == IntPtr.Zero)
					codecFir_jfieldId = JNIEnv.GetFieldID (class_ref, "codecFir", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, codecFir_jfieldId);
			}
			set {
				if (codecFir_jfieldId == IntPtr.Zero)
					codecFir_jfieldId = JNIEnv.GetFieldID (class_ref, "codecFir", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecFir_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecIFrames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='codecIFrames']"
		[Register ("codecIFrames")]
		public long CodecIFrames {
			get {
				if (codecIFrames_jfieldId == IntPtr.Zero)
					codecIFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "codecIFrames", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, codecIFrames_jfieldId);
			}
			set {
				if (codecIFrames_jfieldId == IntPtr.Zero)
					codecIFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "codecIFrames", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecIFrames_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecLayers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='codecLayers']"
		[Register ("codecLayers")]
		public long CodecLayers {
			get {
				if (codecLayers_jfieldId == IntPtr.Zero)
					codecLayers_jfieldId = JNIEnv.GetFieldID (class_ref, "codecLayers", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, codecLayers_jfieldId);
			}
			set {
				if (codecLayers_jfieldId == IntPtr.Zero)
					codecLayers_jfieldId = JNIEnv.GetFieldID (class_ref, "codecLayers", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecLayers_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecNacks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='codecNacks']"
		[Register ("codecNacks")]
		public long CodecNacks {
			get {
				if (codecNacks_jfieldId == IntPtr.Zero)
					codecNacks_jfieldId = JNIEnv.GetFieldID (class_ref, "codecNacks", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, codecNacks_jfieldId);
			}
			set {
				if (codecNacks_jfieldId == IntPtr.Zero)
					codecNacks_jfieldId = JNIEnv.GetFieldID (class_ref, "codecNacks", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecNacks_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='codecName']"
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

		static IntPtr fpsDecoded_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='fpsDecoded']"
		[Register ("fpsDecoded")]
		public long FpsDecoded {
			get {
				if (fpsDecoded_jfieldId == IntPtr.Zero)
					fpsDecoded_jfieldId = JNIEnv.GetFieldID (class_ref, "fpsDecoded", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, fpsDecoded_jfieldId);
			}
			set {
				if (fpsDecoded_jfieldId == IntPtr.Zero)
					fpsDecoded_jfieldId = JNIEnv.GetFieldID (class_ref, "fpsDecoded", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fpsDecoded_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fpsDecoderInput_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='fpsDecoderInput']"
		[Register ("fpsDecoderInput")]
		public long FpsDecoderInput {
			get {
				if (fpsDecoderInput_jfieldId == IntPtr.Zero)
					fpsDecoderInput_jfieldId = JNIEnv.GetFieldID (class_ref, "fpsDecoderInput", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, fpsDecoderInput_jfieldId);
			}
			set {
				if (fpsDecoderInput_jfieldId == IntPtr.Zero)
					fpsDecoderInput_jfieldId = JNIEnv.GetFieldID (class_ref, "fpsDecoderInput", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fpsDecoderInput_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fpsRendered_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='fpsRendered']"
		[Register ("fpsRendered")]
		public long FpsRendered {
			get {
				if (fpsRendered_jfieldId == IntPtr.Zero)
					fpsRendered_jfieldId = JNIEnv.GetFieldID (class_ref, "fpsRendered", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, fpsRendered_jfieldId);
			}
			set {
				if (fpsRendered_jfieldId == IntPtr.Zero)
					fpsRendered_jfieldId = JNIEnv.GetFieldID (class_ref, "fpsRendered", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fpsRendered_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='height']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='id']"
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

		static IntPtr localRendererStreams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='localRendererStreams']"
		[Register ("localRendererStreams")]
		public global::System.Collections.IList LocalRendererStreams {
			get {
				if (localRendererStreams_jfieldId == IntPtr.Zero)
					localRendererStreams_jfieldId = JNIEnv.GetFieldID (class_ref, "localRendererStreams", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, localRendererStreams_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (localRendererStreams_jfieldId == IntPtr.Zero)
					localRendererStreams_jfieldId = JNIEnv.GetFieldID (class_ref, "localRendererStreams", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, localRendererStreams_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr maxStreamFrameRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='maxStreamFrameRate']"
		[Register ("maxStreamFrameRate")]
		public long MaxStreamFrameRate {
			get {
				if (maxStreamFrameRate_jfieldId == IntPtr.Zero)
					maxStreamFrameRate_jfieldId = JNIEnv.GetFieldID (class_ref, "maxStreamFrameRate", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, maxStreamFrameRate_jfieldId);
			}
			set {
				if (maxStreamFrameRate_jfieldId == IntPtr.Zero)
					maxStreamFrameRate_jfieldId = JNIEnv.GetFieldID (class_ref, "maxStreamFrameRate", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxStreamFrameRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxStreamHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='maxStreamHeight']"
		[Register ("maxStreamHeight")]
		public long MaxStreamHeight {
			get {
				if (maxStreamHeight_jfieldId == IntPtr.Zero)
					maxStreamHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "maxStreamHeight", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, maxStreamHeight_jfieldId);
			}
			set {
				if (maxStreamHeight_jfieldId == IntPtr.Zero)
					maxStreamHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "maxStreamHeight", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxStreamHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxStreamWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='maxStreamWidth']"
		[Register ("maxStreamWidth")]
		public int MaxStreamWidth {
			get {
				if (maxStreamWidth_jfieldId == IntPtr.Zero)
					maxStreamWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "maxStreamWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, maxStreamWidth_jfieldId);
			}
			set {
				if (maxStreamWidth_jfieldId == IntPtr.Zero)
					maxStreamWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "maxStreamWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxStreamWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='name']"
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

		static IntPtr receiveNetworkBitRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='receiveNetworkBitRate']"
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

		static IntPtr receiveNetworkPacketsConcealed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='receiveNetworkPacketsConcealed']"
		[Register ("receiveNetworkPacketsConcealed")]
		public long ReceiveNetworkPacketsConcealed {
			get {
				if (receiveNetworkPacketsConcealed_jfieldId == IntPtr.Zero)
					receiveNetworkPacketsConcealed_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkPacketsConcealed", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, receiveNetworkPacketsConcealed_jfieldId);
			}
			set {
				if (receiveNetworkPacketsConcealed_jfieldId == IntPtr.Zero)
					receiveNetworkPacketsConcealed_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkPacketsConcealed", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receiveNetworkPacketsConcealed_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr receiveNetworkPacketsLost_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='receiveNetworkPacketsLost']"
		[Register ("receiveNetworkPacketsLost")]
		public long ReceiveNetworkPacketsLost {
			get {
				if (receiveNetworkPacketsLost_jfieldId == IntPtr.Zero)
					receiveNetworkPacketsLost_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkPacketsLost", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, receiveNetworkPacketsLost_jfieldId);
			}
			set {
				if (receiveNetworkPacketsLost_jfieldId == IntPtr.Zero)
					receiveNetworkPacketsLost_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkPacketsLost", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receiveNetworkPacketsLost_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr receiveNetworkPacketsReordered_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='receiveNetworkPacketsReordered']"
		[Register ("receiveNetworkPacketsReordered")]
		public long ReceiveNetworkPacketsReordered {
			get {
				if (receiveNetworkPacketsReordered_jfieldId == IntPtr.Zero)
					receiveNetworkPacketsReordered_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkPacketsReordered", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, receiveNetworkPacketsReordered_jfieldId);
			}
			set {
				if (receiveNetworkPacketsReordered_jfieldId == IntPtr.Zero)
					receiveNetworkPacketsReordered_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkPacketsReordered", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receiveNetworkPacketsReordered_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr receiveNetworkRecoveredWithFec_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='receiveNetworkRecoveredWithFec']"
		[Register ("receiveNetworkRecoveredWithFec")]
		public long ReceiveNetworkRecoveredWithFec {
			get {
				if (receiveNetworkRecoveredWithFec_jfieldId == IntPtr.Zero)
					receiveNetworkRecoveredWithFec_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkRecoveredWithFec", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, receiveNetworkRecoveredWithFec_jfieldId);
			}
			set {
				if (receiveNetworkRecoveredWithFec_jfieldId == IntPtr.Zero)
					receiveNetworkRecoveredWithFec_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveNetworkRecoveredWithFec", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receiveNetworkRecoveredWithFec_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr showFrameRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='showFrameRate']"
		[Register ("showFrameRate")]
		public int ShowFrameRate {
			get {
				if (showFrameRate_jfieldId == IntPtr.Zero)
					showFrameRate_jfieldId = JNIEnv.GetFieldID (class_ref, "showFrameRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, showFrameRate_jfieldId);
			}
			set {
				if (showFrameRate_jfieldId == IntPtr.Zero)
					showFrameRate_jfieldId = JNIEnv.GetFieldID (class_ref, "showFrameRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, showFrameRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr showHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='showHeight']"
		[Register ("showHeight")]
		public long ShowHeight {
			get {
				if (showHeight_jfieldId == IntPtr.Zero)
					showHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "showHeight", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, showHeight_jfieldId);
			}
			set {
				if (showHeight_jfieldId == IntPtr.Zero)
					showHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "showHeight", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, showHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr showPixelRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='showPixelRate']"
		[Register ("showPixelRate")]
		public int ShowPixelRate {
			get {
				if (showPixelRate_jfieldId == IntPtr.Zero)
					showPixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "showPixelRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, showPixelRate_jfieldId);
			}
			set {
				if (showPixelRate_jfieldId == IntPtr.Zero)
					showPixelRate_jfieldId = JNIEnv.GetFieldID (class_ref, "showPixelRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, showPixelRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr showState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='showState']"
		[Register ("showState")]
		public string ShowState {
			get {
				if (showState_jfieldId == IntPtr.Zero)
					showState_jfieldId = JNIEnv.GetFieldID (class_ref, "showState", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, showState_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (showState_jfieldId == IntPtr.Zero)
					showState_jfieldId = JNIEnv.GetFieldID (class_ref, "showState", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, showState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr showWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='showWidth']"
		[Register ("showWidth")]
		public long ShowWidth {
			get {
				if (showWidth_jfieldId == IntPtr.Zero)
					showWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "showWidth", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, showWidth_jfieldId);
			}
			set {
				if (showWidth_jfieldId == IntPtr.Zero)
					showWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "showWidth", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, showWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/field[@name='width']"
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
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoRemoteVideoSourceStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoRemoteVideoSourceStats); }
		}

		protected VidyoRemoteVideoSourceStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoRemoteVideoSourceStats']/constructor[@name='VidyoRemoteVideoSourceStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoRemoteVideoSourceStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoRemoteVideoSourceStats)) {
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
