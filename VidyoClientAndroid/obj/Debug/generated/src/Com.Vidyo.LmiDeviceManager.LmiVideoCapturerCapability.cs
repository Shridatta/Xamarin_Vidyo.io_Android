using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.LmiDeviceManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']"
	[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiVideoCapturerCapability", DoNotGenerateAcw=true)]
	public partial class LmiVideoCapturerCapability : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability.FrameRateInfo']"
		[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiVideoCapturerCapability$FrameRateInfo", DoNotGenerateAcw=true)]
		public partial class FrameRateInfo : global::Java.Lang.Object, global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IRateInfo {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiVideoCapturerCapability$FrameRateInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FrameRateInfo); }
			}

			protected FrameRateInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getMaxFrameInterval;
#pragma warning disable 0169
			static Delegate GetGetMaxFrameIntervalHandler ()
			{
				if (cb_getMaxFrameInterval == null)
					cb_getMaxFrameInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxFrameInterval);
				return cb_getMaxFrameInterval;
			}

			static long n_GetMaxFrameInterval (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.FrameRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.FrameRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxFrameInterval;
			}
#pragma warning restore 0169

			static IntPtr id_getMaxFrameInterval;
			public virtual unsafe long MaxFrameInterval {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability.FrameRateInfo']/method[@name='getMaxFrameInterval' and count(parameter)=0]"
				[Register ("getMaxFrameInterval", "()J", "GetGetMaxFrameIntervalHandler")]
				get {
					if (id_getMaxFrameInterval == IntPtr.Zero)
						id_getMaxFrameInterval = JNIEnv.GetMethodID (class_ref, "getMaxFrameInterval", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMaxFrameInterval);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxFrameInterval", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_getMaxFrameRate;
#pragma warning disable 0169
			static Delegate GetGetMaxFrameRateHandler ()
			{
				if (cb_getMaxFrameRate == null)
					cb_getMaxFrameRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxFrameRate);
				return cb_getMaxFrameRate;
			}

			static int n_GetMaxFrameRate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.FrameRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.FrameRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxFrameRate;
			}
#pragma warning restore 0169

			static IntPtr id_getMaxFrameRate;
			public virtual unsafe int MaxFrameRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability.FrameRateInfo']/method[@name='getMaxFrameRate' and count(parameter)=0]"
				[Register ("getMaxFrameRate", "()I", "GetGetMaxFrameRateHandler")]
				get {
					if (id_getMaxFrameRate == IntPtr.Zero)
						id_getMaxFrameRate = JNIEnv.GetMethodID (class_ref, "getMaxFrameRate", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxFrameRate);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxFrameRate", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getMinFrameInterval;
#pragma warning disable 0169
			static Delegate GetGetMinFrameIntervalHandler ()
			{
				if (cb_getMinFrameInterval == null)
					cb_getMinFrameInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMinFrameInterval);
				return cb_getMinFrameInterval;
			}

			static long n_GetMinFrameInterval (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.FrameRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.FrameRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MinFrameInterval;
			}
#pragma warning restore 0169

			static IntPtr id_getMinFrameInterval;
			public virtual unsafe long MinFrameInterval {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability.FrameRateInfo']/method[@name='getMinFrameInterval' and count(parameter)=0]"
				[Register ("getMinFrameInterval", "()J", "GetGetMinFrameIntervalHandler")]
				get {
					if (id_getMinFrameInterval == IntPtr.Zero)
						id_getMinFrameInterval = JNIEnv.GetMethodID (class_ref, "getMinFrameInterval", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMinFrameInterval);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinFrameInterval", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_getMinFrameRate;
#pragma warning disable 0169
			static Delegate GetGetMinFrameRateHandler ()
			{
				if (cb_getMinFrameRate == null)
					cb_getMinFrameRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinFrameRate);
				return cb_getMinFrameRate;
			}

			static int n_GetMinFrameRate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.FrameRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.FrameRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MinFrameRate;
			}
#pragma warning restore 0169

			static IntPtr id_getMinFrameRate;
			public virtual unsafe int MinFrameRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability.FrameRateInfo']/method[@name='getMinFrameRate' and count(parameter)=0]"
				[Register ("getMinFrameRate", "()I", "GetGetMinFrameRateHandler")]
				get {
					if (id_getMinFrameRate == IntPtr.Zero)
						id_getMinFrameRate = JNIEnv.GetMethodID (class_ref, "getMinFrameRate", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinFrameRate);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinFrameRate", "()I"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability.IntervalRateInfo']"
		[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiVideoCapturerCapability$IntervalRateInfo", DoNotGenerateAcw=true)]
		public partial class IntervalRateInfo : global::Java.Lang.Object, global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IRateInfo {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiVideoCapturerCapability$IntervalRateInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IntervalRateInfo); }
			}

			protected IntervalRateInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getMaxFrameInterval;
#pragma warning disable 0169
			static Delegate GetGetMaxFrameIntervalHandler ()
			{
				if (cb_getMaxFrameInterval == null)
					cb_getMaxFrameInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxFrameInterval);
				return cb_getMaxFrameInterval;
			}

			static long n_GetMaxFrameInterval (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IntervalRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IntervalRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxFrameInterval;
			}
#pragma warning restore 0169

			static IntPtr id_getMaxFrameInterval;
			public virtual unsafe long MaxFrameInterval {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability.IntervalRateInfo']/method[@name='getMaxFrameInterval' and count(parameter)=0]"
				[Register ("getMaxFrameInterval", "()J", "GetGetMaxFrameIntervalHandler")]
				get {
					if (id_getMaxFrameInterval == IntPtr.Zero)
						id_getMaxFrameInterval = JNIEnv.GetMethodID (class_ref, "getMaxFrameInterval", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMaxFrameInterval);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxFrameInterval", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_getMaxFrameRate;
#pragma warning disable 0169
			static Delegate GetGetMaxFrameRateHandler ()
			{
				if (cb_getMaxFrameRate == null)
					cb_getMaxFrameRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxFrameRate);
				return cb_getMaxFrameRate;
			}

			static int n_GetMaxFrameRate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IntervalRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IntervalRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxFrameRate;
			}
#pragma warning restore 0169

			static IntPtr id_getMaxFrameRate;
			public virtual unsafe int MaxFrameRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability.IntervalRateInfo']/method[@name='getMaxFrameRate' and count(parameter)=0]"
				[Register ("getMaxFrameRate", "()I", "GetGetMaxFrameRateHandler")]
				get {
					if (id_getMaxFrameRate == IntPtr.Zero)
						id_getMaxFrameRate = JNIEnv.GetMethodID (class_ref, "getMaxFrameRate", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxFrameRate);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxFrameRate", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getMinFrameInterval;
#pragma warning disable 0169
			static Delegate GetGetMinFrameIntervalHandler ()
			{
				if (cb_getMinFrameInterval == null)
					cb_getMinFrameInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMinFrameInterval);
				return cb_getMinFrameInterval;
			}

			static long n_GetMinFrameInterval (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IntervalRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IntervalRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MinFrameInterval;
			}
#pragma warning restore 0169

			static IntPtr id_getMinFrameInterval;
			public virtual unsafe long MinFrameInterval {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability.IntervalRateInfo']/method[@name='getMinFrameInterval' and count(parameter)=0]"
				[Register ("getMinFrameInterval", "()J", "GetGetMinFrameIntervalHandler")]
				get {
					if (id_getMinFrameInterval == IntPtr.Zero)
						id_getMinFrameInterval = JNIEnv.GetMethodID (class_ref, "getMinFrameInterval", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMinFrameInterval);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinFrameInterval", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_getMinFrameRate;
#pragma warning disable 0169
			static Delegate GetGetMinFrameRateHandler ()
			{
				if (cb_getMinFrameRate == null)
					cb_getMinFrameRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinFrameRate);
				return cb_getMinFrameRate;
			}

			static int n_GetMinFrameRate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IntervalRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IntervalRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MinFrameRate;
			}
#pragma warning restore 0169

			static IntPtr id_getMinFrameRate;
			public virtual unsafe int MinFrameRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability.IntervalRateInfo']/method[@name='getMinFrameRate' and count(parameter)=0]"
				[Register ("getMinFrameRate", "()I", "GetGetMinFrameRateHandler")]
				get {
					if (id_getMinFrameRate == IntPtr.Zero)
						id_getMinFrameRate = JNIEnv.GetMethodID (class_ref, "getMinFrameRate", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinFrameRate);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinFrameRate", "()I"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiVideoCapturerCapability.RateInfo']"
		[Register ("com/vidyo/LmiDeviceManager/LmiVideoCapturerCapability$RateInfo", "", "Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability/IRateInfoInvoker")]
		public partial interface IRateInfo : IJavaObject {

			long MaxFrameInterval {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiVideoCapturerCapability.RateInfo']/method[@name='getMaxFrameInterval' and count(parameter)=0]"
				[Register ("getMaxFrameInterval", "()J", "GetGetMaxFrameIntervalHandler:Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability/IRateInfoInvoker, VidyoClientAndroid")] get;
			}

			int MaxFrameRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiVideoCapturerCapability.RateInfo']/method[@name='getMaxFrameRate' and count(parameter)=0]"
				[Register ("getMaxFrameRate", "()I", "GetGetMaxFrameRateHandler:Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability/IRateInfoInvoker, VidyoClientAndroid")] get;
			}

			long MinFrameInterval {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiVideoCapturerCapability.RateInfo']/method[@name='getMinFrameInterval' and count(parameter)=0]"
				[Register ("getMinFrameInterval", "()J", "GetGetMinFrameIntervalHandler:Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability/IRateInfoInvoker, VidyoClientAndroid")] get;
			}

			int MinFrameRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/interface[@name='LmiVideoCapturerCapability.RateInfo']/method[@name='getMinFrameRate' and count(parameter)=0]"
				[Register ("getMinFrameRate", "()I", "GetGetMinFrameRateHandler:Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability/IRateInfoInvoker, VidyoClientAndroid")] get;
			}

		}

		[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiVideoCapturerCapability$RateInfo", DoNotGenerateAcw=true)]
		internal class IRateInfoInvoker : global::Java.Lang.Object, IRateInfo {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiVideoCapturerCapability$RateInfo");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRateInfoInvoker); }
			}

			IntPtr class_ref;

			public static IRateInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRateInfo> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.LmiDeviceManager.LmiVideoCapturerCapability.RateInfo"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRateInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getMaxFrameInterval;
#pragma warning disable 0169
			static Delegate GetGetMaxFrameIntervalHandler ()
			{
				if (cb_getMaxFrameInterval == null)
					cb_getMaxFrameInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxFrameInterval);
				return cb_getMaxFrameInterval;
			}

			static long n_GetMaxFrameInterval (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxFrameInterval;
			}
#pragma warning restore 0169

			IntPtr id_getMaxFrameInterval;
			public unsafe long MaxFrameInterval {
				get {
					if (id_getMaxFrameInterval == IntPtr.Zero)
						id_getMaxFrameInterval = JNIEnv.GetMethodID (class_ref, "getMaxFrameInterval", "()J");
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMaxFrameInterval);
				}
			}

			static Delegate cb_getMaxFrameRate;
#pragma warning disable 0169
			static Delegate GetGetMaxFrameRateHandler ()
			{
				if (cb_getMaxFrameRate == null)
					cb_getMaxFrameRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxFrameRate);
				return cb_getMaxFrameRate;
			}

			static int n_GetMaxFrameRate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxFrameRate;
			}
#pragma warning restore 0169

			IntPtr id_getMaxFrameRate;
			public unsafe int MaxFrameRate {
				get {
					if (id_getMaxFrameRate == IntPtr.Zero)
						id_getMaxFrameRate = JNIEnv.GetMethodID (class_ref, "getMaxFrameRate", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxFrameRate);
				}
			}

			static Delegate cb_getMinFrameInterval;
#pragma warning disable 0169
			static Delegate GetGetMinFrameIntervalHandler ()
			{
				if (cb_getMinFrameInterval == null)
					cb_getMinFrameInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMinFrameInterval);
				return cb_getMinFrameInterval;
			}

			static long n_GetMinFrameInterval (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MinFrameInterval;
			}
#pragma warning restore 0169

			IntPtr id_getMinFrameInterval;
			public unsafe long MinFrameInterval {
				get {
					if (id_getMinFrameInterval == IntPtr.Zero)
						id_getMinFrameInterval = JNIEnv.GetMethodID (class_ref, "getMinFrameInterval", "()J");
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMinFrameInterval);
				}
			}

			static Delegate cb_getMinFrameRate;
#pragma warning disable 0169
			static Delegate GetGetMinFrameRateHandler ()
			{
				if (cb_getMinFrameRate == null)
					cb_getMinFrameRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinFrameRate);
				return cb_getMinFrameRate;
			}

			static int n_GetMinFrameRate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IRateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability.IRateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MinFrameRate;
			}
#pragma warning restore 0169

			IntPtr id_getMinFrameRate;
			public unsafe int MinFrameRate {
				get {
					if (id_getMinFrameRate == IntPtr.Zero)
						id_getMinFrameRate = JNIEnv.GetMethodID (class_ref, "getMinFrameRate", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinFrameRate);
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiVideoCapturerCapability", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LmiVideoCapturerCapability); }
		}

		protected LmiVideoCapturerCapability (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIJJLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/constructor[@name='LmiVideoCapturerCapability' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(IIJJLjava/lang/String;)V", "")]
		public unsafe LmiVideoCapturerCapability (int p0, int p1, long p2, long p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (LmiVideoCapturerCapability)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIJJLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIJJLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_IIJJLjava_lang_String_ == IntPtr.Zero)
					id_ctor_IIJJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIJJLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIJJLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIJJLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor_IIIILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/constructor[@name='LmiVideoCapturerCapability' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(IIIILjava/lang/String;)V", "")]
		public unsafe LmiVideoCapturerCapability (int p0, int p1, int p2, int p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (LmiVideoCapturerCapability)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIIILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_IIIILjava_lang_String_ == IntPtr.Zero)
					id_ctor_IIIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/constructor[@name='LmiVideoCapturerCapability' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LmiVideoCapturerCapability ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LmiVideoCapturerCapability)) {
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

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Format);
		}
#pragma warning restore 0169

		static Delegate cb_setFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setFormat_Ljava_lang_String_ == null)
				cb_setFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFormat_Ljava_lang_String_);
			return cb_setFormat_Ljava_lang_String_;
		}

		static void n_SetFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Format = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFormat;
		static IntPtr id_setFormat_Ljava_lang_String_;
		public virtual unsafe string Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Ljava/lang/String;", "GetGetFormatHandler")]
			get {
				if (id_getFormat == IntPtr.Zero)
					id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormat", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/method[@name='setFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFormat", "(Ljava/lang/String;)V", "GetSetFormat_Ljava_lang_String_Handler")]
			set {
				if (id_setFormat_Ljava_lang_String_ == IntPtr.Zero)
					id_setFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFormat", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFormat_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFormat", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static Delegate cb_setHeight_I;
#pragma warning disable 0169
		static Delegate GetSetHeight_IHandler ()
		{
			if (cb_setHeight_I == null)
				cb_setHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeight_I);
			return cb_setHeight_I;
		}

		static void n_SetHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Height = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		static IntPtr id_setHeight_I;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeight", "(I)V", "GetSetHeight_IHandler")]
			set {
				if (id_setHeight_I == IntPtr.Zero)
					id_setHeight_I = JNIEnv.GetMethodID (class_ref, "setHeight", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeight_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxFrameInterval;
#pragma warning disable 0169
		static Delegate GetGetMaxFrameIntervalHandler ()
		{
			if (cb_getMaxFrameInterval == null)
				cb_getMaxFrameInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxFrameInterval);
			return cb_getMaxFrameInterval;
		}

		static long n_GetMaxFrameInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxFrameInterval;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxFrameInterval;
		public virtual unsafe long MaxFrameInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/method[@name='getMaxFrameInterval' and count(parameter)=0]"
			[Register ("getMaxFrameInterval", "()J", "GetGetMaxFrameIntervalHandler")]
			get {
				if (id_getMaxFrameInterval == IntPtr.Zero)
					id_getMaxFrameInterval = JNIEnv.GetMethodID (class_ref, "getMaxFrameInterval", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMaxFrameInterval);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxFrameInterval", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxFrameRate;
#pragma warning disable 0169
		static Delegate GetGetMaxFrameRateHandler ()
		{
			if (cb_getMaxFrameRate == null)
				cb_getMaxFrameRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxFrameRate);
			return cb_getMaxFrameRate;
		}

		static int n_GetMaxFrameRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxFrameRate;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxFrameRate;
		public virtual unsafe int MaxFrameRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/method[@name='getMaxFrameRate' and count(parameter)=0]"
			[Register ("getMaxFrameRate", "()I", "GetGetMaxFrameRateHandler")]
			get {
				if (id_getMaxFrameRate == IntPtr.Zero)
					id_getMaxFrameRate = JNIEnv.GetMethodID (class_ref, "getMaxFrameRate", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxFrameRate);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxFrameRate", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMinFrameInterval;
#pragma warning disable 0169
		static Delegate GetGetMinFrameIntervalHandler ()
		{
			if (cb_getMinFrameInterval == null)
				cb_getMinFrameInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMinFrameInterval);
			return cb_getMinFrameInterval;
		}

		static long n_GetMinFrameInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinFrameInterval;
		}
#pragma warning restore 0169

		static IntPtr id_getMinFrameInterval;
		public virtual unsafe long MinFrameInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/method[@name='getMinFrameInterval' and count(parameter)=0]"
			[Register ("getMinFrameInterval", "()J", "GetGetMinFrameIntervalHandler")]
			get {
				if (id_getMinFrameInterval == IntPtr.Zero)
					id_getMinFrameInterval = JNIEnv.GetMethodID (class_ref, "getMinFrameInterval", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMinFrameInterval);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinFrameInterval", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getMinFrameRate;
#pragma warning disable 0169
		static Delegate GetGetMinFrameRateHandler ()
		{
			if (cb_getMinFrameRate == null)
				cb_getMinFrameRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinFrameRate);
			return cb_getMinFrameRate;
		}

		static int n_GetMinFrameRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinFrameRate;
		}
#pragma warning restore 0169

		static IntPtr id_getMinFrameRate;
		public virtual unsafe int MinFrameRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/method[@name='getMinFrameRate' and count(parameter)=0]"
			[Register ("getMinFrameRate", "()I", "GetGetMinFrameRateHandler")]
			get {
				if (id_getMinFrameRate == IntPtr.Zero)
					id_getMinFrameRate = JNIEnv.GetMethodID (class_ref, "getMinFrameRate", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinFrameRate);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinFrameRate", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_I;
#pragma warning disable 0169
		static Delegate GetSetWidth_IHandler ()
		{
			if (cb_setWidth_I == null)
				cb_setWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWidth_I);
			return cb_setWidth_I;
		}

		static void n_SetWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoCapturerCapability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_I;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoCapturerCapability']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
			set {
				if (id_setWidth_I == IntPtr.Zero)
					id_setWidth_I = JNIEnv.GetMethodID (class_ref, "setWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWidth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
