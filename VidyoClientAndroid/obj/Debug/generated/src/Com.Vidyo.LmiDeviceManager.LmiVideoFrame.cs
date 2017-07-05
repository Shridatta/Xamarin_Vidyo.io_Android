using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.LmiDeviceManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']"
	[global::Android.Runtime.Register ("com/vidyo/LmiDeviceManager/LmiVideoFrame", DoNotGenerateAcw=true)]
	public partial class LmiVideoFrame : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/LmiDeviceManager/LmiVideoFrame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LmiVideoFrame); }
		}

		protected LmiVideoFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_arrayBII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/constructor[@name='LmiVideoFrame' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;[BII)V", "")]
		public unsafe LmiVideoFrame (string p0, byte[] p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (LmiVideoFrame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;[BII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;[BII)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_arrayBII == IntPtr.Zero)
					id_ctor_Ljava_lang_String_arrayBII = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[BII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayBII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_arrayBII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_Landroid_media_Image_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/constructor[@name='LmiVideoFrame' and count(parameter)=1 and parameter[1][@type='android.media.Image']]"
		[Register (".ctor", "(Landroid/media/Image;)V", "")]
		public unsafe LmiVideoFrame (global::Android.Media.Image p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LmiVideoFrame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/media/Image;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/media/Image;)V", __args);
					return;
				}

				if (id_ctor_Landroid_media_Image_ == IntPtr.Zero)
					id_ctor_Landroid_media_Image_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/media/Image;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_media_Image_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_media_Image_, __args);
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
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Format);
		}
#pragma warning restore 0169

		static IntPtr id_getFormat;
		public virtual unsafe string Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='getFormat' and count(parameter)=0]"
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
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='getHeight' and count(parameter)=0]"
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
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		public virtual unsafe global::Android.Media.Image Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Landroid/media/Image;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Landroid/media/Image;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Media.Image> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Media.Image> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Landroid/media/Image;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMirrored;
#pragma warning disable 0169
		static Delegate GetGetMirroredHandler ()
		{
			if (cb_getMirrored == null)
				cb_getMirrored = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetMirrored);
			return cb_getMirrored;
		}

		static bool n_GetMirrored (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mirrored;
		}
#pragma warning restore 0169

		static Delegate cb_setMirrored_Z;
#pragma warning disable 0169
		static Delegate GetSetMirrored_ZHandler ()
		{
			if (cb_setMirrored_Z == null)
				cb_setMirrored_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMirrored_Z);
			return cb_setMirrored_Z;
		}

		static void n_SetMirrored_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mirrored = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMirrored;
		static IntPtr id_setMirrored_Z;
		public virtual unsafe bool Mirrored {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='getMirrored' and count(parameter)=0]"
			[Register ("getMirrored", "()Z", "GetGetMirroredHandler")]
			get {
				if (id_getMirrored == IntPtr.Zero)
					id_getMirrored = JNIEnv.GetMethodID (class_ref, "getMirrored", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getMirrored);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMirrored", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='setMirrored' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMirrored", "(Z)V", "GetSetMirrored_ZHandler")]
			set {
				if (id_setMirrored_Z == IntPtr.Zero)
					id_setMirrored_Z = JNIEnv.GetMethodID (class_ref, "setMirrored", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMirrored_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMirrored", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObject;
#pragma warning disable 0169
		static Delegate GetGetObjectHandler ()
		{
			if (cb_getObject == null)
				cb_getObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObject);
			return cb_getObject;
		}

		static IntPtr n_GetObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Object);
		}
#pragma warning restore 0169

		static Delegate cb_setObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetObject_Ljava_lang_Object_Handler ()
		{
			if (cb_setObject_Ljava_lang_Object_ == null)
				cb_setObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObject_Ljava_lang_Object_);
			return cb_setObject_Ljava_lang_Object_;
		}

		static void n_SetObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Object = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getObject;
		static IntPtr id_setObject_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object Object {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='getObject' and count(parameter)=0]"
			[Register ("getObject", "()Ljava/lang/Object;", "GetGetObjectHandler")]
			get {
				if (id_getObject == IntPtr.Zero)
					id_getObject = JNIEnv.GetMethodID (class_ref, "getObject", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObject), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObject", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='setObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setObject", "(Ljava/lang/Object;)V", "GetSetObject_Ljava_lang_Object_Handler")]
			set {
				if (id_setObject_Ljava_lang_Object_ == IntPtr.Zero)
					id_setObject_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setObject", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setObject_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setObject", "(Ljava/lang/Object;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		static Delegate cb_setOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetOrientation_IHandler ()
		{
			if (cb_setOrientation_I == null)
				cb_setOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOrientation_I);
			return cb_setOrientation_I;
		}

		static void n_SetOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Orientation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		static IntPtr id_setOrientation_I;
		public virtual unsafe int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrientation);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOrientation", "(I)V", "GetSetOrientation_IHandler")]
			set {
				if (id_setOrientation_I == IntPtr.Zero)
					id_setOrientation_I = JNIEnv.GetMethodID (class_ref, "setOrientation", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOrientation_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientation", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientationRelativeToApp;
#pragma warning disable 0169
		static Delegate GetGetOrientationRelativeToAppHandler ()
		{
			if (cb_getOrientationRelativeToApp == null)
				cb_getOrientationRelativeToApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrientationRelativeToApp);
			return cb_getOrientationRelativeToApp;
		}

		static int n_GetOrientationRelativeToApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OrientationRelativeToApp;
		}
#pragma warning restore 0169

		static Delegate cb_setOrientationRelativeToApp_I;
#pragma warning disable 0169
		static Delegate GetSetOrientationRelativeToApp_IHandler ()
		{
			if (cb_setOrientationRelativeToApp_I == null)
				cb_setOrientationRelativeToApp_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOrientationRelativeToApp_I);
			return cb_setOrientationRelativeToApp_I;
		}

		static void n_SetOrientationRelativeToApp_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OrientationRelativeToApp = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientationRelativeToApp;
		static IntPtr id_setOrientationRelativeToApp_I;
		public virtual unsafe int OrientationRelativeToApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='getOrientationRelativeToApp' and count(parameter)=0]"
			[Register ("getOrientationRelativeToApp", "()I", "GetGetOrientationRelativeToAppHandler")]
			get {
				if (id_getOrientationRelativeToApp == IntPtr.Zero)
					id_getOrientationRelativeToApp = JNIEnv.GetMethodID (class_ref, "getOrientationRelativeToApp", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrientationRelativeToApp);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientationRelativeToApp", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='setOrientationRelativeToApp' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOrientationRelativeToApp", "(I)V", "GetSetOrientationRelativeToApp_IHandler")]
			set {
				if (id_setOrientationRelativeToApp_I == IntPtr.Zero)
					id_setOrientationRelativeToApp_I = JNIEnv.GetMethodID (class_ref, "setOrientationRelativeToApp", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOrientationRelativeToApp_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientationRelativeToApp", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static Delegate cb_setTimestamp_J;
#pragma warning disable 0169
		static Delegate GetSetTimestamp_JHandler ()
		{
			if (cb_setTimestamp_J == null)
				cb_setTimestamp_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimestamp_J);
			return cb_setTimestamp_J;
		}

		static void n_SetTimestamp_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timestamp = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		static IntPtr id_setTimestamp_J;
		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimestamp);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimestamp", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='setTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTimestamp", "(J)V", "GetSetTimestamp_JHandler")]
			set {
				if (id_setTimestamp_J == IntPtr.Zero)
					id_setTimestamp_J = JNIEnv.GetMethodID (class_ref, "setTimestamp", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimestamp_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimestamp", "(J)V"), __args);
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
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='getWidth' and count(parameter)=0]"
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
		}

		static Delegate cb_getBuffer;
#pragma warning disable 0169
		static Delegate GetGetBufferHandler ()
		{
			if (cb_getBuffer == null)
				cb_getBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuffer);
			return cb_getBuffer;
		}

		static IntPtr n_GetBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.LmiDeviceManager.LmiVideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBuffer ());
		}
#pragma warning restore 0169

		static IntPtr id_getBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.LmiDeviceManager']/class[@name='LmiVideoFrame']/method[@name='getBuffer' and count(parameter)=0]"
		[Register ("getBuffer", "()[B", "GetGetBufferHandler")]
		public virtual unsafe byte[] GetBuffer ()
		{
			if (id_getBuffer == IntPtr.Zero)
				id_getBuffer = JNIEnv.GetMethodID (class_ref, "getBuffer", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBuffer), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuffer", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
