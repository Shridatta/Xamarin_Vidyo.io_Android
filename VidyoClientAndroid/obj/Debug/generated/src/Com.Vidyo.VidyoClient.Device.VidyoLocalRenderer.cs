using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoLocalRenderer", DoNotGenerateAcw=true)]
	public partial class VidyoLocalRenderer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer.VidyoLocalRendererViewStyle']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle", DoNotGenerateAcw=true)]
		public sealed partial class VidyoLocalRendererViewStyle : global::Java.Lang.Enum {


			static IntPtr VIDYO_LOCALRENDERERVIEWSTYLE_Default_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer.VidyoLocalRendererViewStyle']/field[@name='VIDYO_LOCALRENDERERVIEWSTYLE_Default']"
			[Register ("VIDYO_LOCALRENDERERVIEWSTYLE_Default")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle VIDYOLOCALRENDERERVIEWSTYLEDefault {
				get {
					if (VIDYO_LOCALRENDERERVIEWSTYLE_Default_jfieldId == IntPtr.Zero)
						VIDYO_LOCALRENDERERVIEWSTYLE_Default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOCALRENDERERVIEWSTYLE_Default", "Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOCALRENDERERVIEWSTYLE_Default_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_LOCALRENDERERVIEWSTYLE_Tiles_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer.VidyoLocalRendererViewStyle']/field[@name='VIDYO_LOCALRENDERERVIEWSTYLE_Tiles']"
			[Register ("VIDYO_LOCALRENDERERVIEWSTYLE_Tiles")]
			public static global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle VIDYOLOCALRENDERERVIEWSTYLETiles {
				get {
					if (VIDYO_LOCALRENDERERVIEWSTYLE_Tiles_jfieldId == IntPtr.Zero)
						VIDYO_LOCALRENDERERVIEWSTYLE_Tiles_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_LOCALRENDERERVIEWSTYLE_Tiles", "Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_LOCALRENDERERVIEWSTYLE_Tiles_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoLocalRendererViewStyle); }
			}

			internal VidyoLocalRendererViewStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer.VidyoLocalRendererViewStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer.VidyoLocalRendererViewStyle']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer$VidyoLocalRendererViewStyle;");
				try {
					return (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer.VidyoLocalRendererViewStyle));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Device/VidyoLocalRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoLocalRenderer); }
		}

		protected VidyoLocalRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/constructor[@name='VidyoLocalRenderer' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoLocalRenderer (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoLocalRenderer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_GetId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_GetId == null)
				cb_GetId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_GetId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_SetId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_SetId_Ljava_lang_String_ == null)
				cb_SetId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_SetId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		static IntPtr id_SetId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/method[@name='GetId' and count(parameter)=0]"
			[Register ("GetId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_GetId == IntPtr.Zero)
					id_GetId = JNIEnv.GetMethodID (class_ref, "GetId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/method[@name='SetId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_SetId_Ljava_lang_String_ == IntPtr.Zero)
					id_SetId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_IsPaused;
#pragma warning disable 0169
		static Delegate GetIsPausedHandler ()
		{
			if (cb_IsPaused == null)
				cb_IsPaused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPaused);
			return cb_IsPaused;
		}

		static bool n_IsPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_IsPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/method[@name='IsPaused' and count(parameter)=0]"
			[Register ("IsPaused", "()Z", "GetIsPausedHandler")]
			get {
				if (id_IsPaused == IntPtr.Zero)
					id_IsPaused = JNIEnv.GetMethodID (class_ref, "IsPaused", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsPaused);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsPaused", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_GetName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_GetName == null)
				cb_GetName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_GetName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_GetName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/method[@name='GetName' and count(parameter)=0]"
			[Register ("GetName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_GetName == IntPtr.Zero)
					id_GetName = JNIEnv.GetMethodID (class_ref, "GetName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetObjectPtr;
#pragma warning disable 0169
		static Delegate GetGetObjectPtrHandler ()
		{
			if (cb_GetObjectPtr == null)
				cb_GetObjectPtr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetObjectPtr);
			return cb_GetObjectPtr;
		}

		static long n_GetObjectPtr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/method[@name='GetObjectPtr' and count(parameter)=0]"
			[Register ("GetObjectPtr", "()J", "GetGetObjectPtrHandler")]
			get {
				if (id_GetObjectPtr == IntPtr.Zero)
					id_GetObjectPtr = JNIEnv.GetMethodID (class_ref, "GetObjectPtr", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_GetObjectPtr);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetObjectPtr", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_Pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_Pause == null)
				cb_Pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_Pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_Pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/method[@name='Pause' and count(parameter)=0]"
		[Register ("Pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_Pause == IntPtr.Zero)
				id_Pause = JNIEnv.GetMethodID (class_ref, "Pause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Pause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_Resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_Resume == null)
				cb_Resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_Resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_Resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/method[@name='Resume' and count(parameter)=0]"
		[Register ("Resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_Resume == IntPtr.Zero)
				id_Resume = JNIEnv.GetMethodID (class_ref, "Resume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Resume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Resume", "()V"));
			} finally {
			}
		}

		static Delegate cb_SetMaxStreams_I;
#pragma warning disable 0169
		static Delegate GetSetMaxStreams_IHandler ()
		{
			if (cb_SetMaxStreams_I == null)
				cb_SetMaxStreams_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetMaxStreams_I);
			return cb_SetMaxStreams_I;
		}

		static bool n_SetMaxStreams_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetMaxStreams (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetMaxStreams_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/method[@name='SetMaxStreams' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetMaxStreams", "(I)Z", "GetSetMaxStreams_IHandler")]
		public virtual unsafe bool SetMaxStreams (int p0)
		{
			if (id_SetMaxStreams_I == IntPtr.Zero)
				id_SetMaxStreams_I = JNIEnv.GetMethodID (class_ref, "SetMaxStreams", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetMaxStreams_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMaxStreams", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetPosition_IIII;
#pragma warning disable 0169
		static Delegate GetSetPosition_IIIIHandler ()
		{
			if (cb_SetPosition_IIII == null)
				cb_SetPosition_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, bool>) n_SetPosition_IIII);
			return cb_SetPosition_IIII;
		}

		static bool n_SetPosition_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetPosition (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_SetPosition_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/method[@name='SetPosition' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("SetPosition", "(IIII)Z", "GetSetPosition_IIIIHandler")]
		public virtual unsafe bool SetPosition (int p0, int p1, int p2, int p3)
		{
			if (id_SetPosition_IIII == IntPtr.Zero)
				id_SetPosition_IIII = JNIEnv.GetMethodID (class_ref, "SetPosition", "(IIII)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetPosition_IIII, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPosition", "(IIII)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Device']/class[@name='VidyoLocalRenderer']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		protected virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

	}
}
