using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Stats/VidyoEndpointStats", DoNotGenerateAcw=true)]
	public partial class VidyoEndpointStats : global::Java.Lang.Object {


		static IntPtr applicationTag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='applicationTag']"
		[Register ("applicationTag")]
		public string ApplicationTag {
			get {
				if (applicationTag_jfieldId == IntPtr.Zero)
					applicationTag_jfieldId = JNIEnv.GetFieldID (class_ref, "applicationTag", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, applicationTag_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (applicationTag_jfieldId == IntPtr.Zero)
					applicationTag_jfieldId = JNIEnv.GetFieldID (class_ref, "applicationTag", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, applicationTag_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr buildTag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='buildTag']"
		[Register ("buildTag")]
		public string BuildTag {
			get {
				if (buildTag_jfieldId == IntPtr.Zero)
					buildTag_jfieldId = JNIEnv.GetFieldID (class_ref, "buildTag", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, buildTag_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (buildTag_jfieldId == IntPtr.Zero)
					buildTag_jfieldId = JNIEnv.GetFieldID (class_ref, "buildTag", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, buildTag_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='id']"
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

		static IntPtr libraryVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='libraryVersion']"
		[Register ("libraryVersion")]
		public string LibraryVersion {
			get {
				if (libraryVersion_jfieldId == IntPtr.Zero)
					libraryVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "libraryVersion", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, libraryVersion_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (libraryVersion_jfieldId == IntPtr.Zero)
					libraryVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "libraryVersion", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, libraryVersion_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr localCameraStats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='localCameraStats']"
		[Register ("localCameraStats")]
		public global::System.Collections.IList LocalCameraStats {
			get {
				if (localCameraStats_jfieldId == IntPtr.Zero)
					localCameraStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localCameraStats", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, localCameraStats_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (localCameraStats_jfieldId == IntPtr.Zero)
					localCameraStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localCameraStats", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, localCameraStats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr localMicrophoneStats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='localMicrophoneStats']"
		[Register ("localMicrophoneStats")]
		public global::System.Collections.IList LocalMicrophoneStats {
			get {
				if (localMicrophoneStats_jfieldId == IntPtr.Zero)
					localMicrophoneStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localMicrophoneStats", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, localMicrophoneStats_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (localMicrophoneStats_jfieldId == IntPtr.Zero)
					localMicrophoneStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localMicrophoneStats", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, localMicrophoneStats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr localMonitorStats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='localMonitorStats']"
		[Register ("localMonitorStats")]
		public global::System.Collections.IList LocalMonitorStats {
			get {
				if (localMonitorStats_jfieldId == IntPtr.Zero)
					localMonitorStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localMonitorStats", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, localMonitorStats_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (localMonitorStats_jfieldId == IntPtr.Zero)
					localMonitorStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localMonitorStats", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, localMonitorStats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr localRendererStats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='localRendererStats']"
		[Register ("localRendererStats")]
		public global::System.Collections.IList LocalRendererStats {
			get {
				if (localRendererStats_jfieldId == IntPtr.Zero)
					localRendererStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localRendererStats", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, localRendererStats_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (localRendererStats_jfieldId == IntPtr.Zero)
					localRendererStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localRendererStats", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, localRendererStats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr localSpeakerStats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='localSpeakerStats']"
		[Register ("localSpeakerStats")]
		public global::System.Collections.IList LocalSpeakerStats {
			get {
				if (localSpeakerStats_jfieldId == IntPtr.Zero)
					localSpeakerStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localSpeakerStats", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, localSpeakerStats_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (localSpeakerStats_jfieldId == IntPtr.Zero)
					localSpeakerStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localSpeakerStats", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, localSpeakerStats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr localWindowShareStats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='localWindowShareStats']"
		[Register ("localWindowShareStats")]
		public global::System.Collections.IList LocalWindowShareStats {
			get {
				if (localWindowShareStats_jfieldId == IntPtr.Zero)
					localWindowShareStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localWindowShareStats", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, localWindowShareStats_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (localWindowShareStats_jfieldId == IntPtr.Zero)
					localWindowShareStats_jfieldId = JNIEnv.GetFieldID (class_ref, "localWindowShareStats", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, localWindowShareStats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr networkInterfaceStats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='networkInterfaceStats']"
		[Register ("networkInterfaceStats")]
		public global::System.Collections.IList NetworkInterfaceStats {
			get {
				if (networkInterfaceStats_jfieldId == IntPtr.Zero)
					networkInterfaceStats_jfieldId = JNIEnv.GetFieldID (class_ref, "networkInterfaceStats", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, networkInterfaceStats_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (networkInterfaceStats_jfieldId == IntPtr.Zero)
					networkInterfaceStats_jfieldId = JNIEnv.GetFieldID (class_ref, "networkInterfaceStats", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, networkInterfaceStats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr osName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='osName']"
		[Register ("osName")]
		public string OsName {
			get {
				if (osName_jfieldId == IntPtr.Zero)
					osName_jfieldId = JNIEnv.GetFieldID (class_ref, "osName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, osName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (osName_jfieldId == IntPtr.Zero)
					osName_jfieldId = JNIEnv.GetFieldID (class_ref, "osName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, osName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr osVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='osVersion']"
		[Register ("osVersion")]
		public string OsVersion {
			get {
				if (osVersion_jfieldId == IntPtr.Zero)
					osVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "osVersion", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, osVersion_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (osVersion_jfieldId == IntPtr.Zero)
					osVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "osVersion", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, osVersion_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr processorBrand_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='processorBrand']"
		[Register ("processorBrand")]
		public string ProcessorBrand {
			get {
				if (processorBrand_jfieldId == IntPtr.Zero)
					processorBrand_jfieldId = JNIEnv.GetFieldID (class_ref, "processorBrand", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, processorBrand_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (processorBrand_jfieldId == IntPtr.Zero)
					processorBrand_jfieldId = JNIEnv.GetFieldID (class_ref, "processorBrand", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, processorBrand_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr processorLogicalCores_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='processorLogicalCores']"
		[Register ("processorLogicalCores")]
		public int ProcessorLogicalCores {
			get {
				if (processorLogicalCores_jfieldId == IntPtr.Zero)
					processorLogicalCores_jfieldId = JNIEnv.GetFieldID (class_ref, "processorLogicalCores", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, processorLogicalCores_jfieldId);
			}
			set {
				if (processorLogicalCores_jfieldId == IntPtr.Zero)
					processorLogicalCores_jfieldId = JNIEnv.GetFieldID (class_ref, "processorLogicalCores", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, processorLogicalCores_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr processorModel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='processorModel']"
		[Register ("processorModel")]
		public string ProcessorModel {
			get {
				if (processorModel_jfieldId == IntPtr.Zero)
					processorModel_jfieldId = JNIEnv.GetFieldID (class_ref, "processorModel", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, processorModel_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (processorModel_jfieldId == IntPtr.Zero)
					processorModel_jfieldId = JNIEnv.GetFieldID (class_ref, "processorModel", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, processorModel_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr processorPhysicalCores_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='processorPhysicalCores']"
		[Register ("processorPhysicalCores")]
		public int ProcessorPhysicalCores {
			get {
				if (processorPhysicalCores_jfieldId == IntPtr.Zero)
					processorPhysicalCores_jfieldId = JNIEnv.GetFieldID (class_ref, "processorPhysicalCores", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, processorPhysicalCores_jfieldId);
			}
			set {
				if (processorPhysicalCores_jfieldId == IntPtr.Zero)
					processorPhysicalCores_jfieldId = JNIEnv.GetFieldID (class_ref, "processorPhysicalCores", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, processorPhysicalCores_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr processorSpeed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='processorSpeed']"
		[Register ("processorSpeed")]
		public int ProcessorSpeed {
			get {
				if (processorSpeed_jfieldId == IntPtr.Zero)
					processorSpeed_jfieldId = JNIEnv.GetFieldID (class_ref, "processorSpeed", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, processorSpeed_jfieldId);
			}
			set {
				if (processorSpeed_jfieldId == IntPtr.Zero)
					processorSpeed_jfieldId = JNIEnv.GetFieldID (class_ref, "processorSpeed", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, processorSpeed_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr timeStamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='timeStamp']"
		[Register ("timeStamp")]
		public string TimeStamp {
			get {
				if (timeStamp_jfieldId == IntPtr.Zero)
					timeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timeStamp", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, timeStamp_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (timeStamp_jfieldId == IntPtr.Zero)
					timeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timeStamp", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timeStamp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr userStats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/field[@name='userStats']"
		[Register ("userStats")]
		public global::System.Collections.IList UserStats {
			get {
				if (userStats_jfieldId == IntPtr.Zero)
					userStats_jfieldId = JNIEnv.GetFieldID (class_ref, "userStats", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, userStats_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (userStats_jfieldId == IntPtr.Zero)
					userStats_jfieldId = JNIEnv.GetFieldID (class_ref, "userStats", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, userStats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Stats/VidyoEndpointStats", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoEndpointStats); }
		}

		protected VidyoEndpointStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Stats']/class[@name='VidyoEndpointStats']/constructor[@name='VidyoEndpointStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoEndpointStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoEndpointStats)) {
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
