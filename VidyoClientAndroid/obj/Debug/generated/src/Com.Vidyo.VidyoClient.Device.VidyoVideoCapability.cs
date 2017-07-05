using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoVideoCapability", DoNotGenerateAcw=true)]
	public partial class VidyoVideoCapability : global::Java.Lang.Object {


		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability']/field[@name='height']"
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

		static IntPtr ranges_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability']/field[@name='ranges']"
		[Register ("ranges")]
		public global::System.Collections.IList Ranges {
			get {
				if (ranges_jfieldId == IntPtr.Zero)
					ranges_jfieldId = JNIEnv.GetFieldID (class_ref, "ranges", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ranges_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ranges_jfieldId == IntPtr.Zero)
					ranges_jfieldId = JNIEnv.GetFieldID (class_ref, "ranges", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ranges_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability']/field[@name='width']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoVideoCapability$VidyoVideoFrameIntervalRange", DoNotGenerateAcw=true)]
		public partial class VidyoVideoFrameIntervalRange : global::Java.Lang.Object {


			static IntPtr formats_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange']/field[@name='formats']"
			[Register ("formats")]
			public global::System.Collections.IList Formats {
				get {
					if (formats_jfieldId == IntPtr.Zero)
						formats_jfieldId = JNIEnv.GetFieldID (class_ref, "formats", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, formats_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (formats_jfieldId == IntPtr.Zero)
						formats_jfieldId = JNIEnv.GetFieldID (class_ref, "formats", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, formats_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr range_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange']/field[@name='range']"
			[Register ("range")]
			public global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability.VidyoVideoFrameIntervalRange.VidyoTimeRange Range {
				get {
					if (range_jfieldId == IntPtr.Zero)
						range_jfieldId = JNIEnv.GetFieldID (class_ref, "range", "Lcom/vidyo/VidyoClient/Device/VidyoVideoCapability$VidyoVideoFrameIntervalRange$VidyoTimeRange;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, range_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability.VidyoVideoFrameIntervalRange.VidyoTimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (range_jfieldId == IntPtr.Zero)
						range_jfieldId = JNIEnv.GetFieldID (class_ref, "range", "Lcom/vidyo/VidyoClient/Device/VidyoVideoCapability$VidyoVideoFrameIntervalRange$VidyoTimeRange;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, range_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr step_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange']/field[@name='step']"
			[Register ("step")]
			public long Step {
				get {
					if (step_jfieldId == IntPtr.Zero)
						step_jfieldId = JNIEnv.GetFieldID (class_ref, "step", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, step_jfieldId);
				}
				set {
					if (step_jfieldId == IntPtr.Zero)
						step_jfieldId = JNIEnv.GetFieldID (class_ref, "step", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, step_jfieldId, value);
					} finally {
					}
				}
			}
			// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange.VidyoTimeRange']"
			[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoVideoCapability$VidyoVideoFrameIntervalRange$VidyoTimeRange", DoNotGenerateAcw=true)]
			public partial class VidyoTimeRange : global::Java.Lang.Object {


				static IntPtr begin_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange.VidyoTimeRange']/field[@name='begin']"
				[Register ("begin")]
				public long Begin {
					get {
						if (begin_jfieldId == IntPtr.Zero)
							begin_jfieldId = JNIEnv.GetFieldID (class_ref, "begin", "J");
						return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, begin_jfieldId);
					}
					set {
						if (begin_jfieldId == IntPtr.Zero)
							begin_jfieldId = JNIEnv.GetFieldID (class_ref, "begin", "J");
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, begin_jfieldId, value);
						} finally {
						}
					}
				}

				static IntPtr end_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange.VidyoTimeRange']/field[@name='end']"
				[Register ("end")]
				public long End {
					get {
						if (end_jfieldId == IntPtr.Zero)
							end_jfieldId = JNIEnv.GetFieldID (class_ref, "end", "J");
						return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, end_jfieldId);
					}
					set {
						if (end_jfieldId == IntPtr.Zero)
							end_jfieldId = JNIEnv.GetFieldID (class_ref, "end", "J");
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, end_jfieldId, value);
						} finally {
						}
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoVideoCapability$VidyoVideoFrameIntervalRange$VidyoTimeRange", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (VidyoTimeRange); }
				}

				protected VidyoTimeRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor_Lcom_vidyo_VidyoClient_Device_VidyoVideoCapability_VidyoVideoFrameIntervalRange_;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange.VidyoTimeRange']/constructor[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange.VidyoTimeRange' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoVideoCapability.VidyoVideoFrameIntervalRange']]"
				[Register (".ctor", "(Lcom/vidyo/VidyoClient/Device/VidyoVideoCapability$VidyoVideoFrameIntervalRange;)V", "")]
				public unsafe VidyoTimeRange (global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability.VidyoVideoFrameIntervalRange __self)
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (__self);
						if (((object) this).GetType () != typeof (VidyoTimeRange)) {
							SetHandle (
									global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
									JniHandleOwnership.TransferLocalRef);
							global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
							return;
						}

						if (id_ctor_Lcom_vidyo_VidyoClient_Device_VidyoVideoCapability_VidyoVideoFrameIntervalRange_ == IntPtr.Zero)
							id_ctor_Lcom_vidyo_VidyoClient_Device_VidyoVideoCapability_VidyoVideoFrameIntervalRange_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/Device/VidyoVideoCapability$VidyoVideoFrameIntervalRange;)V");
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_Device_VidyoVideoCapability_VidyoVideoFrameIntervalRange_, __args),
								JniHandleOwnership.TransferLocalRef);
						JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_Device_VidyoVideoCapability_VidyoVideoFrameIntervalRange_, __args);
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoVideoCapability$VidyoVideoFrameIntervalRange", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoVideoFrameIntervalRange); }
			}

			protected VidyoVideoFrameIntervalRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_vidyo_VidyoClient_Device_VidyoVideoCapability_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange']/constructor[@name='VidyoVideoCapability.VidyoVideoFrameIntervalRange' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoVideoCapability']]"
			[Register (".ctor", "(Lcom/vidyo/VidyoClient/Device/VidyoVideoCapability;)V", "")]
			public unsafe VidyoVideoFrameIntervalRange (global::Com.Vidyo.VidyoClient.Device.VidyoVideoCapability __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (VidyoVideoFrameIntervalRange)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_vidyo_VidyoClient_Device_VidyoVideoCapability_ == IntPtr.Zero)
						id_ctor_Lcom_vidyo_VidyoClient_Device_VidyoVideoCapability_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/Device/VidyoVideoCapability;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_Device_VidyoVideoCapability_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_Device_VidyoVideoCapability_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoVideoCapability", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoVideoCapability); }
		}

		protected VidyoVideoCapability (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoVideoCapability']/constructor[@name='VidyoVideoCapability' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoVideoCapability ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoVideoCapability)) {
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
