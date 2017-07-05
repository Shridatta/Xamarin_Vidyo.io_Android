using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.LmiDeviceManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiLocationManager']"
	[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiLocationManager", DoNotGenerateAcw=true)]
	public partial class LmiLocationManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiLocationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LmiLocationManager); }
		}

		protected LmiLocationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiLocationManager']/constructor[@name='LmiLocationManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LmiLocationManager (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LmiLocationManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getAltitude;
#pragma warning disable 0169
		static Delegate GetGetAltitudeHandler ()
		{
			if (cb_getAltitude == null)
				cb_getAltitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAltitude);
			return cb_getAltitude;
		}

		static double n_GetAltitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Altitude;
		}
#pragma warning restore 0169

		static IntPtr id_getAltitude;
		public virtual unsafe double Altitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiLocationManager']/method[@name='getAltitude' and count(parameter)=0]"
			[Register ("getAltitude", "()D", "GetGetAltitudeHandler")]
			get {
				if (id_getAltitude == IntPtr.Zero)
					id_getAltitude = JNIEnv.GetMethodID (class_ref, "getAltitude", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAltitude);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAltitude", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitude;
		public virtual unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiLocationManager']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLatitude);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitude", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitude;
		public virtual unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiLocationManager']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLongitude);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitude", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_setAddress_J;
#pragma warning disable 0169
		static Delegate GetSetAddress_JHandler ()
		{
			if (cb_setAddress_J == null)
				cb_setAddress_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAddress_J);
			return cb_setAddress_J;
		}

		static void n_SetAddress_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAddress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAddress_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiLocationManager']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setAddress", "(J)V", "GetSetAddress_JHandler")]
		public virtual unsafe void SetAddress (long p0)
		{
			if (id_setAddress_J == IntPtr.Zero)
				id_setAddress_J = JNIEnv.GetMethodID (class_ref, "setAddress", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAddress_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAddress", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startUpdates;
#pragma warning disable 0169
		static Delegate GetStartUpdatesHandler ()
		{
			if (cb_startUpdates == null)
				cb_startUpdates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartUpdates);
			return cb_startUpdates;
		}

		static void n_StartUpdates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartUpdates ();
		}
#pragma warning restore 0169

		static IntPtr id_startUpdates;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiLocationManager']/method[@name='startUpdates' and count(parameter)=0]"
		[Register ("startUpdates", "()V", "GetStartUpdatesHandler")]
		public virtual unsafe void StartUpdates ()
		{
			if (id_startUpdates == IntPtr.Zero)
				id_startUpdates = JNIEnv.GetMethodID (class_ref, "startUpdates", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startUpdates);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startUpdates", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopUpdates;
#pragma warning disable 0169
		static Delegate GetStopUpdatesHandler ()
		{
			if (cb_stopUpdates == null)
				cb_stopUpdates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopUpdates);
			return cb_stopUpdates;
		}

		static void n_StopUpdates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopUpdates ();
		}
#pragma warning restore 0169

		static IntPtr id_stopUpdates;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiLocationManager']/method[@name='stopUpdates' and count(parameter)=0]"
		[Register ("stopUpdates", "()V", "GetStopUpdatesHandler")]
		public virtual unsafe void StopUpdates ()
		{
			if (id_stopUpdates == IntPtr.Zero)
				id_stopUpdates = JNIEnv.GetMethodID (class_ref, "stopUpdates", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopUpdates);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopUpdates", "()V"));
			} finally {
			}
		}

	}
}
