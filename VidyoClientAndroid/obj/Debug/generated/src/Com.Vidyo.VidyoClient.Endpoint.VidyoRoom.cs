using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom", DoNotGenerateAcw=true)]
	public partial class VidyoRoom : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IAcceptIncoming']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcceptIncoming", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IAcceptIncomingInvoker")]
		public partial interface IAcceptIncoming : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IAcceptIncoming']/method[@name='OnEntered' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult']]"
			[Register ("OnEntered", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;)V", "GetOnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IAcceptIncomingInvoker, VidyoClientAndroid")]
			void OnEntered (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IAcceptIncoming']/method[@name='OnExited' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason']]"
			[Register ("OnExited", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;)V", "GetOnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IAcceptIncomingInvoker, VidyoClientAndroid")]
			void OnExited (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcceptIncoming", DoNotGenerateAcw=true)]
		internal class IAcceptIncomingInvoker : global::Java.Lang.Object, IAcceptIncoming {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcceptIncoming");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAcceptIncomingInvoker); }
			}

			IntPtr class_ref;

			public static IAcceptIncoming GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAcceptIncoming> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAcceptIncomingInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_;
#pragma warning disable 0169
			static Delegate GetOnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_Handler ()
			{
				if (cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ == null)
					cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_);
				return cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_;
			}

			static void n_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnEntered (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_;
			public unsafe void OnEntered (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult p0)
			{
				if (id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ == IntPtr.Zero)
					id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ = JNIEnv.GetMethodID (class_ref, "OnEntered", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_, __args);
			}

			static Delegate cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_;
#pragma warning disable 0169
			static Delegate GetOnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_Handler ()
			{
				if (cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ == null)
					cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_);
				return cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_;
			}

			static void n_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnExited (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_;
			public unsafe void OnExited (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason p0)
			{
				if (id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ == IntPtr.Zero)
					id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ = JNIEnv.GetMethodID (class_ref, "OnExited", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IAcquireMediaRoute']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcquireMediaRoute", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IAcquireMediaRouteInvoker")]
		public partial interface IAcquireMediaRoute : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IAcquireMediaRoute']/method[@name='OnMediaRouteAcquired' and count(parameter)=0]"
			[Register ("OnMediaRouteAcquired", "()V", "GetOnMediaRouteAcquiredHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IAcquireMediaRouteInvoker, VidyoClientAndroid")]
			void OnMediaRouteAcquired ();

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcquireMediaRoute", DoNotGenerateAcw=true)]
		internal class IAcquireMediaRouteInvoker : global::Java.Lang.Object, IAcquireMediaRoute {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcquireMediaRoute");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAcquireMediaRouteInvoker); }
			}

			IntPtr class_ref;

			public static IAcquireMediaRoute GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAcquireMediaRoute> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IAcquireMediaRoute"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAcquireMediaRouteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnMediaRouteAcquired;
#pragma warning disable 0169
			static Delegate GetOnMediaRouteAcquiredHandler ()
			{
				if (cb_OnMediaRouteAcquired == null)
					cb_OnMediaRouteAcquired = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMediaRouteAcquired);
				return cb_OnMediaRouteAcquired;
			}

			static void n_OnMediaRouteAcquired (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcquireMediaRoute __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcquireMediaRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMediaRouteAcquired ();
			}
#pragma warning restore 0169

			IntPtr id_OnMediaRouteAcquired;
			public unsafe void OnMediaRouteAcquired ()
			{
				if (id_OnMediaRouteAcquired == IntPtr.Zero)
					id_OnMediaRouteAcquired = JNIEnv.GetMethodID (class_ref, "OnMediaRouteAcquired", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaRouteAcquired);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IDelete']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IDelete", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IDeleteInvoker")]
		public partial interface IDelete : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IDelete']/method[@name='OnDeleteResult' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult']]"
			[Register ("OnDeleteResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;)V", "GetOnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IDeleteInvoker, VidyoClientAndroid")]
			void OnDeleteResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IDelete", DoNotGenerateAcw=true)]
		internal class IDeleteInvoker : global::Java.Lang.Object, IDelete {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IDelete");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDeleteInvoker); }
			}

			IntPtr class_ref;

			public static IDelete GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDelete> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IDelete"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDeleteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_;
#pragma warning disable 0169
			static Delegate GetOnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_Handler ()
			{
				if (cb_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_ == null)
					cb_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_);
				return cb_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_;
			}

			static void n_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IDelete __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IDelete> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDeleteResult (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_;
			public unsafe void OnDeleteResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult p0)
			{
				if (id_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_ == IntPtr.Zero)
					id_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_ = JNIEnv.GetMethodID (class_ref, "OnDeleteResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IEnableMedia']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IEnableMedia", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IEnableMediaInvoker")]
		public partial interface IEnableMedia : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IEnableMedia']/method[@name='OnMediaDisabled' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason']]"
			[Register ("OnMediaDisabled", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;)V", "GetOnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IEnableMediaInvoker, VidyoClientAndroid")]
			void OnMediaDisabled (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IEnableMedia']/method[@name='OnMediaEnabled' and count(parameter)=0]"
			[Register ("OnMediaEnabled", "()V", "GetOnMediaEnabledHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IEnableMediaInvoker, VidyoClientAndroid")]
			void OnMediaEnabled ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IEnableMedia']/method[@name='OnMediaFailed' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason']]"
			[Register ("OnMediaFailed", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;)V", "GetOnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IEnableMediaInvoker, VidyoClientAndroid")]
			void OnMediaFailed (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IEnableMedia", DoNotGenerateAcw=true)]
		internal class IEnableMediaInvoker : global::Java.Lang.Object, IEnableMedia {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IEnableMedia");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IEnableMediaInvoker); }
			}

			IntPtr class_ref;

			public static IEnableMedia GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEnableMedia> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEnableMediaInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_;
#pragma warning disable 0169
			static Delegate GetOnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_Handler ()
			{
				if (cb_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_ == null)
					cb_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_);
				return cb_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_;
			}

			static void n_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMediaDisabled (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_;
			public unsafe void OnMediaDisabled (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason p0)
			{
				if (id_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_ == IntPtr.Zero)
					id_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_ = JNIEnv.GetMethodID (class_ref, "OnMediaDisabled", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_, __args);
			}

			static Delegate cb_OnMediaEnabled;
#pragma warning disable 0169
			static Delegate GetOnMediaEnabledHandler ()
			{
				if (cb_OnMediaEnabled == null)
					cb_OnMediaEnabled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMediaEnabled);
				return cb_OnMediaEnabled;
			}

			static void n_OnMediaEnabled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMediaEnabled ();
			}
#pragma warning restore 0169

			IntPtr id_OnMediaEnabled;
			public unsafe void OnMediaEnabled ()
			{
				if (id_OnMediaEnabled == IntPtr.Zero)
					id_OnMediaEnabled = JNIEnv.GetMethodID (class_ref, "OnMediaEnabled", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaEnabled);
			}

			static Delegate cb_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_;
#pragma warning disable 0169
			static Delegate GetOnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_Handler ()
			{
				if (cb_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_ == null)
					cb_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_);
				return cb_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_;
			}

			static void n_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMediaFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_;
			public unsafe void OnMediaFailed (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason p0)
			{
				if (id_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_ == IntPtr.Zero)
					id_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_ = JNIEnv.GetMethodID (class_ref, "OnMediaFailed", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IEnter']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IEnter", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IEnterInvoker")]
		public partial interface IEnter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IEnter']/method[@name='OnEntered' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult']]"
			[Register ("OnEntered", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;)V", "GetOnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IEnterInvoker, VidyoClientAndroid")]
			void OnEntered (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IEnter']/method[@name='OnExited' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason']]"
			[Register ("OnExited", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;)V", "GetOnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IEnterInvoker, VidyoClientAndroid")]
			void OnExited (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IEnter", DoNotGenerateAcw=true)]
		internal class IEnterInvoker : global::Java.Lang.Object, IEnter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IEnter");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IEnterInvoker); }
			}

			IntPtr class_ref;

			public static IEnter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEnter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IEnter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEnterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_;
#pragma warning disable 0169
			static Delegate GetOnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_Handler ()
			{
				if (cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ == null)
					cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_);
				return cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_;
			}

			static void n_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnter __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnEntered (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_;
			public unsafe void OnEntered (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult p0)
			{
				if (id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ == IntPtr.Zero)
					id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ = JNIEnv.GetMethodID (class_ref, "OnEntered", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_, __args);
			}

			static Delegate cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_;
#pragma warning disable 0169
			static Delegate GetOnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_Handler ()
			{
				if (cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ == null)
					cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_);
				return cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_;
			}

			static void n_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnter __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnExited (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_;
			public unsafe void OnExited (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason p0)
			{
				if (id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ == IntPtr.Zero)
					id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ = JNIEnv.GetMethodID (class_ref, "OnExited", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IGetHistory']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IGetHistoryInvoker")]
		public partial interface IGetHistory : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IGetHistory']/method[@name='OnGetHistoryResults' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoChatMessage&gt;'] and parameter[2][@type='long'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult']]"
			[Register ("OnGetHistoryResults", "(Ljava/util/ArrayList;JLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V", "GetOnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IGetHistoryInvoker, VidyoClientAndroid")]
			void OnGetHistoryResults (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> p0, long p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory", DoNotGenerateAcw=true)]
		internal class IGetHistoryInvoker : global::Java.Lang.Object, IGetHistory {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGetHistoryInvoker); }
			}

			IntPtr class_ref;

			public static IGetHistory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGetHistory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGetHistoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
#pragma warning disable 0169
			static Delegate GetOnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler ()
			{
				if (cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == null)
					cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_);
				return cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
			}

			static void n_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnGetHistoryResults (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
			public unsafe void OnGetHistoryResults (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> p0, long p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2)
			{
				if (id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == IntPtr.Zero)
					id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNIEnv.GetMethodID (class_ref, "OnGetHistoryResults", "(Ljava/util/ArrayList;JLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IGetHistoryById']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistoryById", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IGetHistoryByIdInvoker")]
		public partial interface IGetHistoryById : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IGetHistoryById']/method[@name='OnGetHistoryResults' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoChatMessage&gt;'] and parameter[2][@type='long'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult']]"
			[Register ("OnGetHistoryResults", "(Ljava/util/ArrayList;JLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V", "GetOnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IGetHistoryByIdInvoker, VidyoClientAndroid")]
			void OnGetHistoryResults (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> p0, long p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistoryById", DoNotGenerateAcw=true)]
		internal class IGetHistoryByIdInvoker : global::Java.Lang.Object, IGetHistoryById {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistoryById");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGetHistoryByIdInvoker); }
			}

			IntPtr class_ref;

			public static IGetHistoryById GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGetHistoryById> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistoryById"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGetHistoryByIdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
#pragma warning disable 0169
			static Delegate GetOnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler ()
			{
				if (cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == null)
					cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_);
				return cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
			}

			static void n_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistoryById __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistoryById> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnGetHistoryResults (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
			public unsafe void OnGetHistoryResults (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> p0, long p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2)
			{
				if (id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == IntPtr.Zero)
					id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNIEnv.GetMethodID (class_ref, "OnGetHistoryResults", "(Ljava/util/ArrayList;JLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IGetHistoryByTime']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistoryByTime", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IGetHistoryByTimeInvoker")]
		public partial interface IGetHistoryByTime : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IGetHistoryByTime']/method[@name='OnGetHistoryResults' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoChatMessage&gt;'] and parameter[2][@type='long'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult']]"
			[Register ("OnGetHistoryResults", "(Ljava/util/ArrayList;JLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V", "GetOnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IGetHistoryByTimeInvoker, VidyoClientAndroid")]
			void OnGetHistoryResults (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> p0, long p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistoryByTime", DoNotGenerateAcw=true)]
		internal class IGetHistoryByTimeInvoker : global::Java.Lang.Object, IGetHistoryByTime {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistoryByTime");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGetHistoryByTimeInvoker); }
			}

			IntPtr class_ref;

			public static IGetHistoryByTime GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGetHistoryByTime> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistoryByTime"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGetHistoryByTimeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
#pragma warning disable 0169
			static Delegate GetOnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler ()
			{
				if (cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == null)
					cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_);
				return cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
			}

			static void n_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistoryByTime __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistoryByTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnGetHistoryResults (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
			public unsafe void OnGetHistoryResults (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> p0, long p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2)
			{
				if (id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == IntPtr.Zero)
					id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNIEnv.GetMethodID (class_ref, "OnGetHistoryResults", "(Ljava/util/ArrayList;JLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IGetRoomProperties']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetRoomProperties", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IGetRoomPropertiesInvoker")]
		public partial interface IGetRoomProperties : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IGetRoomProperties']/method[@name='OnGetRoomPropertiesResult' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties']]"
			[Register ("OnGetRoomPropertiesResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V", "GetOnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IGetRoomPropertiesInvoker, VidyoClientAndroid")]
			void OnGetRoomPropertiesResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetRoomProperties", DoNotGenerateAcw=true)]
		internal class IGetRoomPropertiesInvoker : global::Java.Lang.Object, IGetRoomProperties {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetRoomProperties");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGetRoomPropertiesInvoker); }
			}

			IntPtr class_ref;

			public static IGetRoomProperties GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGetRoomProperties> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IGetRoomProperties"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGetRoomPropertiesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
#pragma warning disable 0169
			static Delegate GetOnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Handler ()
			{
				if (cb_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ == null)
					cb_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_);
				return cb_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
			}

			static void n_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetRoomProperties __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetRoomProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnGetRoomPropertiesResult (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
			public unsafe void OnGetRoomPropertiesResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p1)
			{
				if (id_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ == IntPtr.Zero)
					id_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ = JNIEnv.GetMethodID (class_ref, "OnGetRoomPropertiesResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IMessageSearch']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IMessageSearch", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IMessageSearchInvoker")]
		public partial interface IMessageSearch : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IMessageSearch']/method[@name='OnMessageSearchResults' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoChatMessage&gt;'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult']]"
			[Register ("OnMessageSearchResults", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V", "GetOnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IMessageSearchInvoker, VidyoClientAndroid")]
			void OnMessageSearchResults (string p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IMessageSearch", DoNotGenerateAcw=true)]
		internal class IMessageSearchInvoker : global::Java.Lang.Object, IMessageSearch {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IMessageSearch");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMessageSearchInvoker); }
			}

			IntPtr class_ref;

			public static IMessageSearch GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMessageSearch> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IMessageSearch"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMessageSearchInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
#pragma warning disable 0169
			static Delegate GetOnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler ()
			{
				if (cb_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == null)
					cb_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_);
				return cb_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
			}

			static void n_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IMessageSearch __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IMessageSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnMessageSearchResults (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
			public unsafe void OnMessageSearchResults (string p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2)
			{
				if (id_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == IntPtr.Zero)
					id_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNIEnv.GetMethodID (class_ref, "OnMessageSearchResults", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterMessageEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterMessageEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterMessageEventListenerInvoker")]
		public partial interface IRegisterMessageEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterMessageEventListener']/method[@name='OnMessageAcknowledged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage']]"
			[Register ("OnMessageAcknowledged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V", "GetOnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterMessageEventListenerInvoker, VidyoClientAndroid")]
			void OnMessageAcknowledged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterMessageEventListener']/method[@name='OnMessageRead' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='long']]"
			[Register ("OnMessageRead", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;J)V", "GetOnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterMessageEventListenerInvoker, VidyoClientAndroid")]
			void OnMessageRead (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, long p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterMessageEventListener']/method[@name='OnMessageReceived' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage']]"
			[Register ("OnMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V", "GetOnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterMessageEventListenerInvoker, VidyoClientAndroid")]
			void OnMessageReceived (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterMessageEventListener']/method[@name='OnMessageTypingIndication' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication']]"
			[Register ("OnMessageTypingIndication", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;)V", "GetOnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterMessageEventListenerInvoker, VidyoClientAndroid")]
			void OnMessageTypingIndication (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterMessageEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterMessageEventListenerInvoker : global::Java.Lang.Object, IRegisterMessageEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterMessageEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterMessageEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterMessageEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterMessageEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterMessageEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
#pragma warning disable 0169
			static Delegate GetOnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler ()
			{
				if (cb_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == null)
					cb_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_);
				return cb_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
			}

			static void n_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMessageAcknowledged (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
			public unsafe void OnMessageAcknowledged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p0)
			{
				if (id_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == IntPtr.Zero)
					id_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNIEnv.GetMethodID (class_ref, "OnMessageAcknowledged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_, __args);
			}

			static Delegate cb_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J;
#pragma warning disable 0169
			static Delegate GetOnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_JHandler ()
			{
				if (cb_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J == null)
					cb_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J);
				return cb_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J;
			}

			static void n_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMessageRead (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J;
			public unsafe void OnMessageRead (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, long p1)
			{
				if (id_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J == IntPtr.Zero)
					id_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J = JNIEnv.GetMethodID (class_ref, "OnMessageRead", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;J)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J, __args);
			}

			static Delegate cb_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
#pragma warning disable 0169
			static Delegate GetOnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler ()
			{
				if (cb_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == null)
					cb_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_);
				return cb_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
			}

			static void n_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnMessageReceived (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
			public unsafe void OnMessageReceived (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1)
			{
				if (id_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == IntPtr.Zero)
					id_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNIEnv.GetMethodID (class_ref, "OnMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_, __args);
			}

			static Delegate cb_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_;
#pragma warning disable 0169
			static Delegate GetOnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_Handler ()
			{
				if (cb_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ == null)
					cb_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_);
				return cb_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_;
			}

			static void n_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnMessageTypingIndication (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_;
			public unsafe void OnMessageTypingIndication (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1)
			{
				if (id_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ == IntPtr.Zero)
					id_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ = JNIEnv.GetMethodID (class_ref, "OnMessageTypingIndication", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_, __args);
			}

		}

		public partial class MessageAcknowledgedEventArgs : global::System.EventArgs {

			public MessageAcknowledgedEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage P0 {
				get { return p0; }
			}
		}

		public partial class MessageReadEventArgs : global::System.EventArgs {

			public MessageReadEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, long p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P0 {
				get { return p0; }
			}

			long p1;
			public long P1 {
				get { return p1; }
			}
		}

		public partial class MessageReceivedEventArgs : global::System.EventArgs {

			public MessageReceivedEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage P1 {
				get { return p1; }
			}
		}

		public partial class MessageTypingIndicationEventArgs : global::System.EventArgs {

			public MessageTypingIndicationEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterMessageEventListenerImplementor")]
		internal sealed partial class IRegisterMessageEventListenerImplementor : global::Java.Lang.Object, IRegisterMessageEventListener {

			object sender;

			public IRegisterMessageEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterMessageEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MessageAcknowledgedEventArgs> OnMessageAcknowledgedHandler;
#pragma warning restore 0649

			public void OnMessageAcknowledged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p0)
			{
				var __h = OnMessageAcknowledgedHandler;
				if (__h != null)
					__h (sender, new MessageAcknowledgedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MessageReadEventArgs> OnMessageReadHandler;
#pragma warning restore 0649

			public void OnMessageRead (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, long p1)
			{
				var __h = OnMessageReadHandler;
				if (__h != null)
					__h (sender, new MessageReadEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<MessageReceivedEventArgs> OnMessageReceivedHandler;
#pragma warning restore 0649

			public void OnMessageReceived (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1)
			{
				var __h = OnMessageReceivedHandler;
				if (__h != null)
					__h (sender, new MessageReceivedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<MessageTypingIndicationEventArgs> OnMessageTypingIndicationHandler;
#pragma warning restore 0649

			public void OnMessageTypingIndication (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1)
			{
				var __h = OnMessageTypingIndicationHandler;
				if (__h != null)
					__h (sender, new MessageTypingIndicationEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRegisterMessageEventListenerImplementor value)
			{
				return value.OnMessageAcknowledgedHandler == null && value.OnMessageReadHandler == null && value.OnMessageReceivedHandler == null && value.OnMessageTypingIndicationHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterParticipantEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterParticipantEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterParticipantEventListenerInvoker")]
		public partial interface IRegisterParticipantEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterParticipantEventListener']/method[@name='OnDynamicParticipantChanged' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoParticipant&gt;'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoRemoteCamera&gt;']]"
			[Register ("OnDynamicParticipantChanged", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", "GetOnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid")]
			void OnDynamicParticipantChanged (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterParticipantEventListener']/method[@name='OnLoudestParticipantChanged' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='boolean']]"
			[Register ("OnLoudestParticipantChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V", "GetOnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ZHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid")]
			void OnLoudestParticipantChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, bool p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterParticipantEventListener']/method[@name='OnParticipantJoined' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnParticipantJoined", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid")]
			void OnParticipantJoined (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterParticipantEventListener']/method[@name='OnParticipantLeft' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnParticipantLeft", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid")]
			void OnParticipantLeft (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterParticipantEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterParticipantEventListenerInvoker : global::Java.Lang.Object, IRegisterParticipantEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterParticipantEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterParticipantEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterParticipantEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterParticipantEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterParticipantEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetOnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
			{
				if (cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
					cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_);
				return cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
			}

			static void n_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDynamicParticipantChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
			public unsafe void OnDynamicParticipantChanged (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1)
			{
				if (id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "OnDynamicParticipantChanged", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant>.ToLocalJniHandle (p0);
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera>.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
#pragma warning disable 0169
			static Delegate GetOnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ZHandler ()
			{
				if (cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z == null)
					cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z);
				return cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
			}

			static void n_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoudestParticipantChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
			public unsafe void OnLoudestParticipantChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, bool p1)
			{
				if (id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z == IntPtr.Zero)
					id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z = JNIEnv.GetMethodID (class_ref, "OnLoudestParticipantChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z, __args);
			}

			static Delegate cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnParticipantJoined (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnParticipantJoined (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				if (id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnParticipantJoined", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

			static Delegate cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnParticipantLeft (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnParticipantLeft (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				if (id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnParticipantLeft", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

		}

		public partial class DynamicParticipantChangedEventArgs : global::System.EventArgs {

			public DynamicParticipantChangedEventArgs (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0;
			public global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> P0 {
				get { return p0; }
			}

			global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1;
			public global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> P1 {
				get { return p1; }
			}
		}

		public partial class LoudestParticipantChangedEventArgs : global::System.EventArgs {

			public LoudestParticipantChangedEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, bool p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P0 {
				get { return p0; }
			}

			bool p1;
			public bool P1 {
				get { return p1; }
			}
		}

		public partial class ParticipantJoinedEventArgs : global::System.EventArgs {

			public ParticipantJoinedEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P0 {
				get { return p0; }
			}
		}

		public partial class ParticipantLeftEventArgs : global::System.EventArgs {

			public ParticipantLeftEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterParticipantEventListenerImplementor")]
		internal sealed partial class IRegisterParticipantEventListenerImplementor : global::Java.Lang.Object, IRegisterParticipantEventListener {

			object sender;

			public IRegisterParticipantEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterParticipantEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DynamicParticipantChangedEventArgs> OnDynamicParticipantChangedHandler;
#pragma warning restore 0649

			public void OnDynamicParticipantChanged (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1)
			{
				var __h = OnDynamicParticipantChangedHandler;
				if (__h != null)
					__h (sender, new DynamicParticipantChangedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<LoudestParticipantChangedEventArgs> OnLoudestParticipantChangedHandler;
#pragma warning restore 0649

			public void OnLoudestParticipantChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, bool p1)
			{
				var __h = OnLoudestParticipantChangedHandler;
				if (__h != null)
					__h (sender, new LoudestParticipantChangedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<ParticipantJoinedEventArgs> OnParticipantJoinedHandler;
#pragma warning restore 0649

			public void OnParticipantJoined (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				var __h = OnParticipantJoinedHandler;
				if (__h != null)
					__h (sender, new ParticipantJoinedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ParticipantLeftEventArgs> OnParticipantLeftHandler;
#pragma warning restore 0649

			public void OnParticipantLeft (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
			{
				var __h = OnParticipantLeftHandler;
				if (__h != null)
					__h (sender, new ParticipantLeftEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterParticipantEventListenerImplementor value)
			{
				return value.OnDynamicParticipantChangedHandler == null && value.OnLoudestParticipantChangedHandler == null && value.OnParticipantJoinedHandler == null && value.OnParticipantLeftHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterRecoderInCallEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRecoderInCallEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterRecoderInCallEventListenerInvoker")]
		public partial interface IRegisterRecoderInCallEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterRecoderInCallEventListener']/method[@name='RecorderInCall' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("RecorderInCall", "(Z)V", "GetRecorderInCall_ZHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterRecoderInCallEventListenerInvoker, VidyoClientAndroid")]
			void RecorderInCall (bool p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRecoderInCallEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRecoderInCallEventListenerInvoker : global::Java.Lang.Object, IRegisterRecoderInCallEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRecoderInCallEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterRecoderInCallEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterRecoderInCallEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterRecoderInCallEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRecoderInCallEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterRecoderInCallEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_RecorderInCall_Z;
#pragma warning disable 0169
			static Delegate GetRecorderInCall_ZHandler ()
			{
				if (cb_RecorderInCall_Z == null)
					cb_RecorderInCall_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_RecorderInCall_Z);
				return cb_RecorderInCall_Z;
			}

			static void n_RecorderInCall_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRecoderInCallEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRecoderInCallEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.RecorderInCall (p0);
			}
#pragma warning restore 0169

			IntPtr id_RecorderInCall_Z;
			public unsafe void RecorderInCall (bool p0)
			{
				if (id_RecorderInCall_Z == IntPtr.Zero)
					id_RecorderInCall_Z = JNIEnv.GetMethodID (class_ref, "RecorderInCall", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RecorderInCall_Z, __args);
			}

		}

		public partial class RegisterRecoderInCallEventEventArgs : global::System.EventArgs {

			public RegisterRecoderInCallEventEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterRecoderInCallEventListenerImplementor")]
		internal sealed partial class IRegisterRecoderInCallEventListenerImplementor : global::Java.Lang.Object, IRegisterRecoderInCallEventListener {

			object sender;

			public IRegisterRecoderInCallEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterRecoderInCallEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RegisterRecoderInCallEventEventArgs> Handler;
#pragma warning restore 0649

			public void RecorderInCall (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RegisterRecoderInCallEventEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterRecoderInCallEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterResourceManagerEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterResourceManagerEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterResourceManagerEventListenerInvoker")]
		public partial interface IRegisterResourceManagerEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterResourceManagerEventListener']/method[@name='OnAvailableResourcesChanged' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("OnAvailableResourcesChanged", "(IIII)V", "GetOnAvailableResourcesChanged_IIIIHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterResourceManagerEventListenerInvoker, VidyoClientAndroid")]
			void OnAvailableResourcesChanged (int p0, int p1, int p2, int p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterResourceManagerEventListener']/method[@name='OnMaxRemoteSourcesChanged' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("OnMaxRemoteSourcesChanged", "(I)V", "GetOnMaxRemoteSourcesChanged_IHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterResourceManagerEventListenerInvoker, VidyoClientAndroid")]
			void OnMaxRemoteSourcesChanged (int p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterResourceManagerEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterResourceManagerEventListenerInvoker : global::Java.Lang.Object, IRegisterResourceManagerEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterResourceManagerEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterResourceManagerEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterResourceManagerEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterResourceManagerEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterResourceManagerEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterResourceManagerEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnAvailableResourcesChanged_IIII;
#pragma warning disable 0169
			static Delegate GetOnAvailableResourcesChanged_IIIIHandler ()
			{
				if (cb_OnAvailableResourcesChanged_IIII == null)
					cb_OnAvailableResourcesChanged_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_OnAvailableResourcesChanged_IIII);
				return cb_OnAvailableResourcesChanged_IIII;
			}

			static void n_OnAvailableResourcesChanged_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterResourceManagerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterResourceManagerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAvailableResourcesChanged (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnAvailableResourcesChanged_IIII;
			public unsafe void OnAvailableResourcesChanged (int p0, int p1, int p2, int p3)
			{
				if (id_OnAvailableResourcesChanged_IIII == IntPtr.Zero)
					id_OnAvailableResourcesChanged_IIII = JNIEnv.GetMethodID (class_ref, "OnAvailableResourcesChanged", "(IIII)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnAvailableResourcesChanged_IIII, __args);
			}

			static Delegate cb_OnMaxRemoteSourcesChanged_I;
#pragma warning disable 0169
			static Delegate GetOnMaxRemoteSourcesChanged_IHandler ()
			{
				if (cb_OnMaxRemoteSourcesChanged_I == null)
					cb_OnMaxRemoteSourcesChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnMaxRemoteSourcesChanged_I);
				return cb_OnMaxRemoteSourcesChanged_I;
			}

			static void n_OnMaxRemoteSourcesChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterResourceManagerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterResourceManagerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMaxRemoteSourcesChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnMaxRemoteSourcesChanged_I;
			public unsafe void OnMaxRemoteSourcesChanged (int p0)
			{
				if (id_OnMaxRemoteSourcesChanged_I == IntPtr.Zero)
					id_OnMaxRemoteSourcesChanged_I = JNIEnv.GetMethodID (class_ref, "OnMaxRemoteSourcesChanged", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMaxRemoteSourcesChanged_I, __args);
			}

		}

		public partial class AvailableResourcesChangedEventArgs : global::System.EventArgs {

			public AvailableResourcesChangedEventArgs (int p0, int p1, int p2, int p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}
		}

		public partial class MaxRemoteSourcesChangedEventArgs : global::System.EventArgs {

			public MaxRemoteSourcesChangedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterResourceManagerEventListenerImplementor")]
		internal sealed partial class IRegisterResourceManagerEventListenerImplementor : global::Java.Lang.Object, IRegisterResourceManagerEventListener {

			object sender;

			public IRegisterResourceManagerEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterResourceManagerEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AvailableResourcesChangedEventArgs> OnAvailableResourcesChangedHandler;
#pragma warning restore 0649

			public void OnAvailableResourcesChanged (int p0, int p1, int p2, int p3)
			{
				var __h = OnAvailableResourcesChangedHandler;
				if (__h != null)
					__h (sender, new AvailableResourcesChangedEventArgs (p0, p1, p2, p3));
			}
#pragma warning disable 0649
			public EventHandler<MaxRemoteSourcesChangedEventArgs> OnMaxRemoteSourcesChangedHandler;
#pragma warning restore 0649

			public void OnMaxRemoteSourcesChanged (int p0)
			{
				var __h = OnMaxRemoteSourcesChangedHandler;
				if (__h != null)
					__h (sender, new MaxRemoteSourcesChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterResourceManagerEventListenerImplementor value)
			{
				return value.OnAvailableResourcesChangedHandler == null && value.OnMaxRemoteSourcesChangedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterRoomPropertiesEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRoomPropertiesEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterRoomPropertiesEventListenerInvoker")]
		public partial interface IRegisterRoomPropertiesEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterRoomPropertiesEventListener']/method[@name='OnRoomPropertiesChanged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties']]"
			[Register ("OnRoomPropertiesChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V", "GetOnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterRoomPropertiesEventListenerInvoker, VidyoClientAndroid")]
			void OnRoomPropertiesChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRoomPropertiesEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRoomPropertiesEventListenerInvoker : global::Java.Lang.Object, IRegisterRoomPropertiesEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRoomPropertiesEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterRoomPropertiesEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterRoomPropertiesEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterRoomPropertiesEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRoomPropertiesEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterRoomPropertiesEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
#pragma warning disable 0169
			static Delegate GetOnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Handler ()
			{
				if (cb_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ == null)
					cb_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_);
				return cb_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
			}

			static void n_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRoomPropertiesEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRoomPropertiesEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomPropertiesChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
			public unsafe void OnRoomPropertiesChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0)
			{
				if (id_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ == IntPtr.Zero)
					id_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ = JNIEnv.GetMethodID (class_ref, "OnRoomPropertiesChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_, __args);
			}

		}

		public partial class RegisterRoomPropertiesEventEventArgs : global::System.EventArgs {

			public RegisterRoomPropertiesEventEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterRoomPropertiesEventListenerImplementor")]
		internal sealed partial class IRegisterRoomPropertiesEventListenerImplementor : global::Java.Lang.Object, IRegisterRoomPropertiesEventListener {

			object sender;

			public IRegisterRoomPropertiesEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterRoomPropertiesEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RegisterRoomPropertiesEventEventArgs> Handler;
#pragma warning restore 0649

			public void OnRoomPropertiesChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RegisterRoomPropertiesEventEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterRoomPropertiesEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterSubjectEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterSubjectEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterSubjectEventListenerInvoker")]
		public partial interface IRegisterSubjectEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.IRegisterSubjectEventListener']/method[@name='OnSetSubject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("OnSetSubject", "(Ljava/lang/String;)V", "GetOnSetSubject_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterSubjectEventListenerInvoker, VidyoClientAndroid")]
			void OnSetSubject (string p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterSubjectEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterSubjectEventListenerInvoker : global::Java.Lang.Object, IRegisterSubjectEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterSubjectEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterSubjectEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterSubjectEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterSubjectEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterSubjectEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterSubjectEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnSetSubject_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSetSubject_Ljava_lang_String_Handler ()
			{
				if (cb_OnSetSubject_Ljava_lang_String_ == null)
					cb_OnSetSubject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetSubject_Ljava_lang_String_);
				return cb_OnSetSubject_Ljava_lang_String_;
			}

			static void n_OnSetSubject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterSubjectEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterSubjectEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSetSubject (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnSetSubject_Ljava_lang_String_;
			public unsafe void OnSetSubject (string p0)
			{
				if (id_OnSetSubject_Ljava_lang_String_ == IntPtr.Zero)
					id_OnSetSubject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnSetSubject", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnSetSubject_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class RegisterSubjectEventEventArgs : global::System.EventArgs {

			public RegisterSubjectEventEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterSubjectEventListenerImplementor")]
		internal sealed partial class IRegisterSubjectEventListenerImplementor : global::Java.Lang.Object, IRegisterSubjectEventListener {

			object sender;

			public IRegisterSubjectEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoRoom_IRegisterSubjectEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RegisterSubjectEventEventArgs> Handler;
#pragma warning restore 0649

			public void OnSetSubject (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RegisterSubjectEventEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterSubjectEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.ISetFavorite']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetFavorite", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/ISetFavoriteInvoker")]
		public partial interface ISetFavorite : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.ISetFavorite']/method[@name='OnSetFavoriteResult' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult']]"
			[Register ("OnSetFavoriteResult", "(ZLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;)V", "GetOnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/ISetFavoriteInvoker, VidyoClientAndroid")]
			void OnSetFavoriteResult (bool p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetFavorite", DoNotGenerateAcw=true)]
		internal class ISetFavoriteInvoker : global::Java.Lang.Object, ISetFavorite {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetFavorite");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISetFavoriteInvoker); }
			}

			IntPtr class_ref;

			public static ISetFavorite GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISetFavorite> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.ISetFavorite"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISetFavoriteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_;
#pragma warning disable 0169
			static Delegate GetOnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_Handler ()
			{
				if (cb_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_ == null)
					cb_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_);
				return cb_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_;
			}

			static void n_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnSetFavoriteResult (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_;
			public unsafe void OnSetFavoriteResult (bool p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult p1)
			{
				if (id_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_ == IntPtr.Zero)
					id_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_ = JNIEnv.GetMethodID (class_ref, "OnSetFavoriteResult", "(ZLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.ISetRoomProperties']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetRoomProperties", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/ISetRoomPropertiesInvoker")]
		public partial interface ISetRoomProperties : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoRoom.ISetRoomProperties']/method[@name='OnSetRoomPropertiesResult' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult']]"
			[Register ("OnSetRoomPropertiesResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;)V", "GetOnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/ISetRoomPropertiesInvoker, VidyoClientAndroid")]
			void OnSetRoomPropertiesResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetRoomProperties", DoNotGenerateAcw=true)]
		internal class ISetRoomPropertiesInvoker : global::Java.Lang.Object, ISetRoomProperties {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetRoomProperties");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISetRoomPropertiesInvoker); }
			}

			IntPtr class_ref;

			public static ISetRoomProperties GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISetRoomProperties> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoRoom.ISetRoomProperties"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISetRoomPropertiesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_;
#pragma warning disable 0169
			static Delegate GetOnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_Handler ()
			{
				if (cb_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_ == null)
					cb_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_);
				return cb_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_;
			}

			static void n_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetRoomProperties __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetRoomProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSetRoomPropertiesResult (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_;
			public unsafe void OnSetRoomPropertiesResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult p0)
			{
				if (id_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_ == IntPtr.Zero)
					id_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_ = JNIEnv.GetMethodID (class_ref, "OnSetRoomPropertiesResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoGenerationDiff']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoGenerationDiff", DoNotGenerateAcw=true)]
		public partial class VidyoGenerationDiff : global::Java.Lang.Object {


			static IntPtr newIndex_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoGenerationDiff']/field[@name='newIndex']"
			[Register ("newIndex")]
			public int NewIndex {
				get {
					if (newIndex_jfieldId == IntPtr.Zero)
						newIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "newIndex", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, newIndex_jfieldId);
				}
				set {
					if (newIndex_jfieldId == IntPtr.Zero)
						newIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "newIndex", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, newIndex_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr oldIndex_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoGenerationDiff']/field[@name='oldIndex']"
			[Register ("oldIndex")]
			public int OldIndex {
				get {
					if (oldIndex_jfieldId == IntPtr.Zero)
						oldIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "oldIndex", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, oldIndex_jfieldId);
				}
				set {
					if (oldIndex_jfieldId == IntPtr.Zero)
						oldIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "oldIndex", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, oldIndex_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr participant_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoGenerationDiff']/field[@name='participant']"
			[Register ("participant")]
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant Participant {
				get {
					if (participant_jfieldId == IntPtr.Zero)
						participant_jfieldId = JNIEnv.GetFieldID (class_ref, "participant", "Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, participant_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (participant_jfieldId == IntPtr.Zero)
						participant_jfieldId = JNIEnv.GetFieldID (class_ref, "participant", "Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, participant_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoGenerationDiff", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoGenerationDiff); }
			}

			protected VidyoGenerationDiff (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoGenerationDiff']/constructor[@name='VidyoRoom.VidyoGenerationDiff' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom']]"
			[Register (".ctor", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V", "")]
			public unsafe VidyoGenerationDiff (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (VidyoGenerationDiff)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == IntPtr.Zero)
						id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomDeleteResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomDeleteResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMDELETERESULT_MiscError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomDeleteResult']/field[@name='VIDYO_ROOMDELETERESULT_MiscError']"
			[Register ("VIDYO_ROOMDELETERESULT_MiscError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult VIDYOROOMDELETERESULTMiscError {
				get {
					if (VIDYO_ROOMDELETERESULT_MiscError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMDELETERESULT_MiscError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMDELETERESULT_MiscError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMDELETERESULT_MiscError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMDELETERESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomDeleteResult']/field[@name='VIDYO_ROOMDELETERESULT_NoResponse']"
			[Register ("VIDYO_ROOMDELETERESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult VIDYOROOMDELETERESULTNoResponse {
				get {
					if (VIDYO_ROOMDELETERESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_ROOMDELETERESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMDELETERESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMDELETERESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMDELETERESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomDeleteResult']/field[@name='VIDYO_ROOMDELETERESULT_OK']"
			[Register ("VIDYO_ROOMDELETERESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult VidyoRoomdeleteresultOk {
				get {
					if (VIDYO_ROOMDELETERESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_ROOMDELETERESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMDELETERESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMDELETERESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMDELETERESULT_OutOfResources_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomDeleteResult']/field[@name='VIDYO_ROOMDELETERESULT_OutOfResources']"
			[Register ("VIDYO_ROOMDELETERESULT_OutOfResources")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult VIDYOROOMDELETERESULTOutOfResources {
				get {
					if (VIDYO_ROOMDELETERESULT_OutOfResources_jfieldId == IntPtr.Zero)
						VIDYO_ROOMDELETERESULT_OutOfResources_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMDELETERESULT_OutOfResources", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMDELETERESULT_OutOfResources_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMDELETERESULT_Unauthorized_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomDeleteResult']/field[@name='VIDYO_ROOMDELETERESULT_Unauthorized']"
			[Register ("VIDYO_ROOMDELETERESULT_Unauthorized")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult VIDYOROOMDELETERESULTUnauthorized {
				get {
					if (VIDYO_ROOMDELETERESULT_Unauthorized_jfieldId == IntPtr.Zero)
						VIDYO_ROOMDELETERESULT_Unauthorized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMDELETERESULT_Unauthorized", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMDELETERESULT_Unauthorized_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomDeleteResult); }
			}

			internal VidyoRoomDeleteResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomDeleteResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomDeleteResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomEnterResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMENTERRESULT_Banned_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/field[@name='VIDYO_ROOMENTERRESULT_Banned']"
			[Register ("VIDYO_ROOMENTERRESULT_Banned")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult VIDYOROOMENTERRESULTBanned {
				get {
					if (VIDYO_ROOMENTERRESULT_Banned_jfieldId == IntPtr.Zero)
						VIDYO_ROOMENTERRESULT_Banned_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMENTERRESULT_Banned", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMENTERRESULT_Banned_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMENTERRESULT_Cancelled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/field[@name='VIDYO_ROOMENTERRESULT_Cancelled']"
			[Register ("VIDYO_ROOMENTERRESULT_Cancelled")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult VIDYOROOMENTERRESULTCancelled {
				get {
					if (VIDYO_ROOMENTERRESULT_Cancelled_jfieldId == IntPtr.Zero)
						VIDYO_ROOMENTERRESULT_Cancelled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMENTERRESULT_Cancelled", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMENTERRESULT_Cancelled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMENTERRESULT_InvalidPassword_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/field[@name='VIDYO_ROOMENTERRESULT_InvalidPassword']"
			[Register ("VIDYO_ROOMENTERRESULT_InvalidPassword")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult VIDYOROOMENTERRESULTInvalidPassword {
				get {
					if (VIDYO_ROOMENTERRESULT_InvalidPassword_jfieldId == IntPtr.Zero)
						VIDYO_ROOMENTERRESULT_InvalidPassword_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMENTERRESULT_InvalidPassword", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMENTERRESULT_InvalidPassword_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMENTERRESULT_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/field[@name='VIDYO_ROOMENTERRESULT_MiscLocalError']"
			[Register ("VIDYO_ROOMENTERRESULT_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult VIDYOROOMENTERRESULTMiscLocalError {
				get {
					if (VIDYO_ROOMENTERRESULT_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMENTERRESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMENTERRESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMENTERRESULT_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMENTERRESULT_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/field[@name='VIDYO_ROOMENTERRESULT_MiscRemoteError']"
			[Register ("VIDYO_ROOMENTERRESULT_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult VIDYOROOMENTERRESULTMiscRemoteError {
				get {
					if (VIDYO_ROOMENTERRESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMENTERRESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMENTERRESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMENTERRESULT_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMENTERRESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/field[@name='VIDYO_ROOMENTERRESULT_NoResponse']"
			[Register ("VIDYO_ROOMENTERRESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult VIDYOROOMENTERRESULTNoResponse {
				get {
					if (VIDYO_ROOMENTERRESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_ROOMENTERRESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMENTERRESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMENTERRESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMENTERRESULT_NotMember_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/field[@name='VIDYO_ROOMENTERRESULT_NotMember']"
			[Register ("VIDYO_ROOMENTERRESULT_NotMember")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult VIDYOROOMENTERRESULTNotMember {
				get {
					if (VIDYO_ROOMENTERRESULT_NotMember_jfieldId == IntPtr.Zero)
						VIDYO_ROOMENTERRESULT_NotMember_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMENTERRESULT_NotMember", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMENTERRESULT_NotMember_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMENTERRESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/field[@name='VIDYO_ROOMENTERRESULT_OK']"
			[Register ("VIDYO_ROOMENTERRESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult VidyoRoomenterresultOk {
				get {
					if (VIDYO_ROOMENTERRESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_ROOMENTERRESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMENTERRESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMENTERRESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMENTERRESULT_RoomFull_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/field[@name='VIDYO_ROOMENTERRESULT_RoomFull']"
			[Register ("VIDYO_ROOMENTERRESULT_RoomFull")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult VIDYOROOMENTERRESULTRoomFull {
				get {
					if (VIDYO_ROOMENTERRESULT_RoomFull_jfieldId == IntPtr.Zero)
						VIDYO_ROOMENTERRESULT_RoomFull_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMENTERRESULT_RoomFull", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMENTERRESULT_RoomFull_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMENTERRESULT_UnknownRoom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/field[@name='VIDYO_ROOMENTERRESULT_UnknownRoom']"
			[Register ("VIDYO_ROOMENTERRESULT_UnknownRoom")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult VIDYOROOMENTERRESULTUnknownRoom {
				get {
					if (VIDYO_ROOMENTERRESULT_UnknownRoom_jfieldId == IntPtr.Zero)
						VIDYO_ROOMENTERRESULT_UnknownRoom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMENTERRESULT_UnknownRoom", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMENTERRESULT_UnknownRoom_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomEnterResult); }
			}

			internal VidyoRoomEnterResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomEnterResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomExitReason : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMEXITREASON_Booted_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/field[@name='VIDYO_ROOMEXITREASON_Booted']"
			[Register ("VIDYO_ROOMEXITREASON_Booted")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason VIDYOROOMEXITREASONBooted {
				get {
					if (VIDYO_ROOMEXITREASON_Booted_jfieldId == IntPtr.Zero)
						VIDYO_ROOMEXITREASON_Booted_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMEXITREASON_Booted", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMEXITREASON_Booted_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMEXITREASON_ConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/field[@name='VIDYO_ROOMEXITREASON_ConnectionLost']"
			[Register ("VIDYO_ROOMEXITREASON_ConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason VIDYOROOMEXITREASONConnectionLost {
				get {
					if (VIDYO_ROOMEXITREASON_ConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_ROOMEXITREASON_ConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMEXITREASON_ConnectionLost", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMEXITREASON_ConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMEXITREASON_Left_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/field[@name='VIDYO_ROOMEXITREASON_Left']"
			[Register ("VIDYO_ROOMEXITREASON_Left")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason VIDYOROOMEXITREASONLeft {
				get {
					if (VIDYO_ROOMEXITREASON_Left_jfieldId == IntPtr.Zero)
						VIDYO_ROOMEXITREASON_Left_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMEXITREASON_Left", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMEXITREASON_Left_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMEXITREASON_MembershipConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/field[@name='VIDYO_ROOMEXITREASON_MembershipConnectionLost']"
			[Register ("VIDYO_ROOMEXITREASON_MembershipConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason VIDYOROOMEXITREASONMembershipConnectionLost {
				get {
					if (VIDYO_ROOMEXITREASON_MembershipConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_ROOMEXITREASON_MembershipConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMEXITREASON_MembershipConnectionLost", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMEXITREASON_MembershipConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMEXITREASON_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/field[@name='VIDYO_ROOMEXITREASON_MiscLocalError']"
			[Register ("VIDYO_ROOMEXITREASON_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason VIDYOROOMEXITREASONMiscLocalError {
				get {
					if (VIDYO_ROOMEXITREASON_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMEXITREASON_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMEXITREASON_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMEXITREASON_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMEXITREASON_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/field[@name='VIDYO_ROOMEXITREASON_MiscRemoteError']"
			[Register ("VIDYO_ROOMEXITREASON_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason VIDYOROOMEXITREASONMiscRemoteError {
				get {
					if (VIDYO_ROOMEXITREASON_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMEXITREASON_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMEXITREASON_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMEXITREASON_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMEXITREASON_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/field[@name='VIDYO_ROOMEXITREASON_NoResponse']"
			[Register ("VIDYO_ROOMEXITREASON_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason VIDYOROOMEXITREASONNoResponse {
				get {
					if (VIDYO_ROOMEXITREASON_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_ROOMEXITREASON_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMEXITREASON_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMEXITREASON_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMEXITREASON_ProtocolViolation_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/field[@name='VIDYO_ROOMEXITREASON_ProtocolViolation']"
			[Register ("VIDYO_ROOMEXITREASON_ProtocolViolation")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason VIDYOROOMEXITREASONProtocolViolation {
				get {
					if (VIDYO_ROOMEXITREASON_ProtocolViolation_jfieldId == IntPtr.Zero)
						VIDYO_ROOMEXITREASON_ProtocolViolation_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMEXITREASON_ProtocolViolation", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMEXITREASON_ProtocolViolation_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMEXITREASON_SessionConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/field[@name='VIDYO_ROOMEXITREASON_SessionConnectionLost']"
			[Register ("VIDYO_ROOMEXITREASON_SessionConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason VIDYOROOMEXITREASONSessionConnectionLost {
				get {
					if (VIDYO_ROOMEXITREASON_SessionConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_ROOMEXITREASON_SessionConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMEXITREASON_SessionConnectionLost", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMEXITREASON_SessionConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMEXITREASON_ShuttingDown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/field[@name='VIDYO_ROOMEXITREASON_ShuttingDown']"
			[Register ("VIDYO_ROOMEXITREASON_ShuttingDown")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason VIDYOROOMEXITREASONShuttingDown {
				get {
					if (VIDYO_ROOMEXITREASON_ShuttingDown_jfieldId == IntPtr.Zero)
						VIDYO_ROOMEXITREASON_ShuttingDown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMEXITREASON_ShuttingDown", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMEXITREASON_ShuttingDown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomExitReason); }
			}

			internal VidyoRoomExitReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomExitReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomGetPropertiesResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomGetPropertiesResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMGETPROPERTIESRESULT_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomGetPropertiesResult']/field[@name='VIDYO_ROOMGETPROPERTIESRESULT_MiscLocalError']"
			[Register ("VIDYO_ROOMGETPROPERTIESRESULT_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult VIDYOROOMGETPROPERTIESRESULTMiscLocalError {
				get {
					if (VIDYO_ROOMGETPROPERTIESRESULT_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMGETPROPERTIESRESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMGETPROPERTIESRESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMGETPROPERTIESRESULT_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMGETPROPERTIESRESULT_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomGetPropertiesResult']/field[@name='VIDYO_ROOMGETPROPERTIESRESULT_MiscRemoteError']"
			[Register ("VIDYO_ROOMGETPROPERTIESRESULT_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult VIDYOROOMGETPROPERTIESRESULTMiscRemoteError {
				get {
					if (VIDYO_ROOMGETPROPERTIESRESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMGETPROPERTIESRESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMGETPROPERTIESRESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMGETPROPERTIESRESULT_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMGETPROPERTIESRESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomGetPropertiesResult']/field[@name='VIDYO_ROOMGETPROPERTIESRESULT_NoResponse']"
			[Register ("VIDYO_ROOMGETPROPERTIESRESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult VIDYOROOMGETPROPERTIESRESULTNoResponse {
				get {
					if (VIDYO_ROOMGETPROPERTIESRESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_ROOMGETPROPERTIESRESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMGETPROPERTIESRESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMGETPROPERTIESRESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMGETPROPERTIESRESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomGetPropertiesResult']/field[@name='VIDYO_ROOMGETPROPERTIESRESULT_OK']"
			[Register ("VIDYO_ROOMGETPROPERTIESRESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult VidyoRoomgetpropertiesresultOk {
				get {
					if (VIDYO_ROOMGETPROPERTIESRESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_ROOMGETPROPERTIESRESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMGETPROPERTIESRESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMGETPROPERTIESRESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMGETPROPERTIESRESULT_Unauthorized_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomGetPropertiesResult']/field[@name='VIDYO_ROOMGETPROPERTIESRESULT_Unauthorized']"
			[Register ("VIDYO_ROOMGETPROPERTIESRESULT_Unauthorized")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult VIDYOROOMGETPROPERTIESRESULTUnauthorized {
				get {
					if (VIDYO_ROOMGETPROPERTIESRESULT_Unauthorized_jfieldId == IntPtr.Zero)
						VIDYO_ROOMGETPROPERTIESRESULT_Unauthorized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMGETPROPERTIESRESULT_Unauthorized", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMGETPROPERTIESRESULT_Unauthorized_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomGetPropertiesResult); }
			}

			internal VidyoRoomGetPropertiesResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomGetPropertiesResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomGetPropertiesResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomMediaDisableReason : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMMEDIADISABLEREASON_Booted_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/field[@name='VIDYO_ROOMMEDIADISABLEREASON_Booted']"
			[Register ("VIDYO_ROOMMEDIADISABLEREASON_Booted")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason VIDYOROOMMEDIADISABLEREASONBooted {
				get {
					if (VIDYO_ROOMMEDIADISABLEREASON_Booted_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIADISABLEREASON_Booted_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIADISABLEREASON_Booted", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIADISABLEREASON_Booted_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIADISABLEREASON_ConferenceDestroyed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/field[@name='VIDYO_ROOMMEDIADISABLEREASON_ConferenceDestroyed']"
			[Register ("VIDYO_ROOMMEDIADISABLEREASON_ConferenceDestroyed")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason VIDYOROOMMEDIADISABLEREASONConferenceDestroyed {
				get {
					if (VIDYO_ROOMMEDIADISABLEREASON_ConferenceDestroyed_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIADISABLEREASON_ConferenceDestroyed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIADISABLEREASON_ConferenceDestroyed", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIADISABLEREASON_ConferenceDestroyed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIADISABLEREASON_Disabled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/field[@name='VIDYO_ROOMMEDIADISABLEREASON_Disabled']"
			[Register ("VIDYO_ROOMMEDIADISABLEREASON_Disabled")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason VIDYOROOMMEDIADISABLEREASONDisabled {
				get {
					if (VIDYO_ROOMMEDIADISABLEREASON_Disabled_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIADISABLEREASON_Disabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIADISABLEREASON_Disabled", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIADISABLEREASON_Disabled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIADISABLEREASON_MediaConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/field[@name='VIDYO_ROOMMEDIADISABLEREASON_MediaConnectionLost']"
			[Register ("VIDYO_ROOMMEDIADISABLEREASON_MediaConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason VIDYOROOMMEDIADISABLEREASONMediaConnectionLost {
				get {
					if (VIDYO_ROOMMEDIADISABLEREASON_MediaConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIADISABLEREASON_MediaConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIADISABLEREASON_MediaConnectionLost", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIADISABLEREASON_MediaConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIADISABLEREASON_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/field[@name='VIDYO_ROOMMEDIADISABLEREASON_MiscLocalError']"
			[Register ("VIDYO_ROOMMEDIADISABLEREASON_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason VIDYOROOMMEDIADISABLEREASONMiscLocalError {
				get {
					if (VIDYO_ROOMMEDIADISABLEREASON_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIADISABLEREASON_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIADISABLEREASON_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIADISABLEREASON_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIADISABLEREASON_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/field[@name='VIDYO_ROOMMEDIADISABLEREASON_MiscRemoteError']"
			[Register ("VIDYO_ROOMMEDIADISABLEREASON_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason VIDYOROOMMEDIADISABLEREASONMiscRemoteError {
				get {
					if (VIDYO_ROOMMEDIADISABLEREASON_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIADISABLEREASON_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIADISABLEREASON_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIADISABLEREASON_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIADISABLEREASON_ServerShuttingDown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/field[@name='VIDYO_ROOMMEDIADISABLEREASON_ServerShuttingDown']"
			[Register ("VIDYO_ROOMMEDIADISABLEREASON_ServerShuttingDown")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason VIDYOROOMMEDIADISABLEREASONServerShuttingDown {
				get {
					if (VIDYO_ROOMMEDIADISABLEREASON_ServerShuttingDown_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIADISABLEREASON_ServerShuttingDown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIADISABLEREASON_ServerShuttingDown", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIADISABLEREASON_ServerShuttingDown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIADISABLEREASON_SessionTerminated_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/field[@name='VIDYO_ROOMMEDIADISABLEREASON_SessionTerminated']"
			[Register ("VIDYO_ROOMMEDIADISABLEREASON_SessionTerminated")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason VIDYOROOMMEDIADISABLEREASONSessionTerminated {
				get {
					if (VIDYO_ROOMMEDIADISABLEREASON_SessionTerminated_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIADISABLEREASON_SessionTerminated_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIADISABLEREASON_SessionTerminated", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIADISABLEREASON_SessionTerminated_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIADISABLEREASON_SignalingConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/field[@name='VIDYO_ROOMMEDIADISABLEREASON_SignalingConnectionLost']"
			[Register ("VIDYO_ROOMMEDIADISABLEREASON_SignalingConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason VIDYOROOMMEDIADISABLEREASONSignalingConnectionLost {
				get {
					if (VIDYO_ROOMMEDIADISABLEREASON_SignalingConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIADISABLEREASON_SignalingConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIADISABLEREASON_SignalingConnectionLost", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIADISABLEREASON_SignalingConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomMediaDisableReason); }
			}

			internal VidyoRoomMediaDisableReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaDisableReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaFailReason']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomMediaFailReason : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMMEDIAFAILREASON_Cancelled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaFailReason']/field[@name='VIDYO_ROOMMEDIAFAILREASON_Cancelled']"
			[Register ("VIDYO_ROOMMEDIAFAILREASON_Cancelled")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason VIDYOROOMMEDIAFAILREASONCancelled {
				get {
					if (VIDYO_ROOMMEDIAFAILREASON_Cancelled_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIAFAILREASON_Cancelled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIAFAILREASON_Cancelled", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIAFAILREASON_Cancelled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIAFAILREASON_MediaConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaFailReason']/field[@name='VIDYO_ROOMMEDIAFAILREASON_MediaConnectionLost']"
			[Register ("VIDYO_ROOMMEDIAFAILREASON_MediaConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason VIDYOROOMMEDIAFAILREASONMediaConnectionLost {
				get {
					if (VIDYO_ROOMMEDIAFAILREASON_MediaConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIAFAILREASON_MediaConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIAFAILREASON_MediaConnectionLost", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIAFAILREASON_MediaConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIAFAILREASON_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaFailReason']/field[@name='VIDYO_ROOMMEDIAFAILREASON_MiscLocalError']"
			[Register ("VIDYO_ROOMMEDIAFAILREASON_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason VIDYOROOMMEDIAFAILREASONMiscLocalError {
				get {
					if (VIDYO_ROOMMEDIAFAILREASON_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIAFAILREASON_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIAFAILREASON_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIAFAILREASON_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIAFAILREASON_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaFailReason']/field[@name='VIDYO_ROOMMEDIAFAILREASON_MiscRemoteError']"
			[Register ("VIDYO_ROOMMEDIAFAILREASON_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason VIDYOROOMMEDIAFAILREASONMiscRemoteError {
				get {
					if (VIDYO_ROOMMEDIAFAILREASON_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIAFAILREASON_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIAFAILREASON_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIAFAILREASON_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIAFAILREASON_NoConference_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaFailReason']/field[@name='VIDYO_ROOMMEDIAFAILREASON_NoConference']"
			[Register ("VIDYO_ROOMMEDIAFAILREASON_NoConference")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason VIDYOROOMMEDIAFAILREASONNoConference {
				get {
					if (VIDYO_ROOMMEDIAFAILREASON_NoConference_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIAFAILREASON_NoConference_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIAFAILREASON_NoConference", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIAFAILREASON_NoConference_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMMEDIAFAILREASON_SignalingConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaFailReason']/field[@name='VIDYO_ROOMMEDIAFAILREASON_SignalingConnectionLost']"
			[Register ("VIDYO_ROOMMEDIAFAILREASON_SignalingConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason VIDYOROOMMEDIAFAILREASONSignalingConnectionLost {
				get {
					if (VIDYO_ROOMMEDIAFAILREASON_SignalingConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_ROOMMEDIAFAILREASON_SignalingConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMMEDIAFAILREASON_SignalingConnectionLost", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMMEDIAFAILREASON_SignalingConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomMediaFailReason); }
			}

			internal VidyoRoomMediaFailReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaFailReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomMediaFailReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProfileControlMode']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomProfileControlMode : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMPROFILECONTROLMODE_AlwaysOff_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProfileControlMode']/field[@name='VIDYO_ROOMPROFILECONTROLMODE_AlwaysOff']"
			[Register ("VIDYO_ROOMPROFILECONTROLMODE_AlwaysOff")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode VIDYOROOMPROFILECONTROLMODEAlwaysOff {
				get {
					if (VIDYO_ROOMPROFILECONTROLMODE_AlwaysOff_jfieldId == IntPtr.Zero)
						VIDYO_ROOMPROFILECONTROLMODE_AlwaysOff_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMPROFILECONTROLMODE_AlwaysOff", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMPROFILECONTROLMODE_AlwaysOff_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMPROFILECONTROLMODE_AlwaysOn_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProfileControlMode']/field[@name='VIDYO_ROOMPROFILECONTROLMODE_AlwaysOn']"
			[Register ("VIDYO_ROOMPROFILECONTROLMODE_AlwaysOn")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode VIDYOROOMPROFILECONTROLMODEAlwaysOn {
				get {
					if (VIDYO_ROOMPROFILECONTROLMODE_AlwaysOn_jfieldId == IntPtr.Zero)
						VIDYO_ROOMPROFILECONTROLMODE_AlwaysOn_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMPROFILECONTROLMODE_AlwaysOn", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMPROFILECONTROLMODE_AlwaysOn_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMPROFILECONTROLMODE_Default_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProfileControlMode']/field[@name='VIDYO_ROOMPROFILECONTROLMODE_Default']"
			[Register ("VIDYO_ROOMPROFILECONTROLMODE_Default")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode VIDYOROOMPROFILECONTROLMODEDefault {
				get {
					if (VIDYO_ROOMPROFILECONTROLMODE_Default_jfieldId == IntPtr.Zero)
						VIDYO_ROOMPROFILECONTROLMODE_Default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMPROFILECONTROLMODE_Default", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMPROFILECONTROLMODE_Default_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomProfileControlMode); }
			}

			internal VidyoRoomProfileControlMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProfileControlMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProfileControlMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties", DoNotGenerateAcw=true)]
		public partial class VidyoRoomProperties : global::Java.Lang.Object {


			static IntPtr administrators_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='administrators']"
			[Register ("administrators")]
			public global::System.Collections.IList Administrators {
				get {
					if (administrators_jfieldId == IntPtr.Zero)
						administrators_jfieldId = JNIEnv.GetFieldID (class_ref, "administrators", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, administrators_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (administrators_jfieldId == IntPtr.Zero)
						administrators_jfieldId = JNIEnv.GetFieldID (class_ref, "administrators", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, administrators_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr creationTime_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='creationTime']"
			[Register ("creationTime")]
			public long CreationTime {
				get {
					if (creationTime_jfieldId == IntPtr.Zero)
						creationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "creationTime", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, creationTime_jfieldId);
				}
				set {
					if (creationTime_jfieldId == IntPtr.Zero)
						creationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "creationTime", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, creationTime_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr defaultProfile_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='defaultProfile']"
			[Register ("defaultProfile")]
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties.VidyoRoomParticipantProfile DefaultProfile {
				get {
					if (defaultProfile_jfieldId == IntPtr.Zero)
						defaultProfile_jfieldId = JNIEnv.GetFieldID (class_ref, "defaultProfile", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties$VidyoRoomParticipantProfile;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, defaultProfile_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties.VidyoRoomParticipantProfile> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (defaultProfile_jfieldId == IntPtr.Zero)
						defaultProfile_jfieldId = JNIEnv.GetFieldID (class_ref, "defaultProfile", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties$VidyoRoomParticipantProfile;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, defaultProfile_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr description_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='description']"
			[Register ("description")]
			public string Description {
				get {
					if (description_jfieldId == IntPtr.Zero)
						description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, description_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (description_jfieldId == IntPtr.Zero)
						description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, description_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr hasPassword_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='hasPassword']"
			[Register ("hasPassword")]
			public bool HasPassword {
				get {
					if (hasPassword_jfieldId == IntPtr.Zero)
						hasPassword_jfieldId = JNIEnv.GetFieldID (class_ref, "hasPassword", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, hasPassword_jfieldId);
				}
				set {
					if (hasPassword_jfieldId == IntPtr.Zero)
						hasPassword_jfieldId = JNIEnv.GetFieldID (class_ref, "hasPassword", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, hasPassword_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr isLoggingEnabled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='isLoggingEnabled']"
			[Register ("isLoggingEnabled")]
			public bool IsLoggingEnabled {
				get {
					if (isLoggingEnabled_jfieldId == IntPtr.Zero)
						isLoggingEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "isLoggingEnabled", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isLoggingEnabled_jfieldId);
				}
				set {
					if (isLoggingEnabled_jfieldId == IntPtr.Zero)
						isLoggingEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "isLoggingEnabled", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isLoggingEnabled_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr isMembersOnly_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='isMembersOnly']"
			[Register ("isMembersOnly")]
			public bool IsMembersOnly {
				get {
					if (isMembersOnly_jfieldId == IntPtr.Zero)
						isMembersOnly_jfieldId = JNIEnv.GetFieldID (class_ref, "isMembersOnly", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isMembersOnly_jfieldId);
				}
				set {
					if (isMembersOnly_jfieldId == IntPtr.Zero)
						isMembersOnly_jfieldId = JNIEnv.GetFieldID (class_ref, "isMembersOnly", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isMembersOnly_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr isModerated_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='isModerated']"
			[Register ("isModerated")]
			public bool IsModerated {
				get {
					if (isModerated_jfieldId == IntPtr.Zero)
						isModerated_jfieldId = JNIEnv.GetFieldID (class_ref, "isModerated", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isModerated_jfieldId);
				}
				set {
					if (isModerated_jfieldId == IntPtr.Zero)
						isModerated_jfieldId = JNIEnv.GetFieldID (class_ref, "isModerated", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isModerated_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr isPasswordProtected_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='isPasswordProtected']"
			[Register ("isPasswordProtected")]
			public bool IsPasswordProtected {
				get {
					if (isPasswordProtected_jfieldId == IntPtr.Zero)
						isPasswordProtected_jfieldId = JNIEnv.GetFieldID (class_ref, "isPasswordProtected", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isPasswordProtected_jfieldId);
				}
				set {
					if (isPasswordProtected_jfieldId == IntPtr.Zero)
						isPasswordProtected_jfieldId = JNIEnv.GetFieldID (class_ref, "isPasswordProtected", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isPasswordProtected_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr isPublic_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='isPublic']"
			[Register ("isPublic")]
			public bool IsPublic {
				get {
					if (isPublic_jfieldId == IntPtr.Zero)
						isPublic_jfieldId = JNIEnv.GetFieldID (class_ref, "isPublic", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isPublic_jfieldId);
				}
				set {
					if (isPublic_jfieldId == IntPtr.Zero)
						isPublic_jfieldId = JNIEnv.GetFieldID (class_ref, "isPublic", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isPublic_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr language_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='language']"
			[Register ("language")]
			public string Language {
				get {
					if (language_jfieldId == IntPtr.Zero)
						language_jfieldId = JNIEnv.GetFieldID (class_ref, "language", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, language_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (language_jfieldId == IntPtr.Zero)
						language_jfieldId = JNIEnv.GetFieldID (class_ref, "language", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, language_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr maxParticipants_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='maxParticipants']"
			[Register ("maxParticipants")]
			public int MaxParticipants {
				get {
					if (maxParticipants_jfieldId == IntPtr.Zero)
						maxParticipants_jfieldId = JNIEnv.GetFieldID (class_ref, "maxParticipants", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, maxParticipants_jfieldId);
				}
				set {
					if (maxParticipants_jfieldId == IntPtr.Zero)
						maxParticipants_jfieldId = JNIEnv.GetFieldID (class_ref, "maxParticipants", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxParticipants_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr members_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='members']"
			[Register ("members")]
			public global::System.Collections.IList Members {
				get {
					if (members_jfieldId == IntPtr.Zero)
						members_jfieldId = JNIEnv.GetFieldID (class_ref, "members", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, members_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (members_jfieldId == IntPtr.Zero)
						members_jfieldId = JNIEnv.GetFieldID (class_ref, "members", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, members_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr moderators_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='moderators']"
			[Register ("moderators")]
			public global::System.Collections.IList Moderators {
				get {
					if (moderators_jfieldId == IntPtr.Zero)
						moderators_jfieldId = JNIEnv.GetFieldID (class_ref, "moderators", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, moderators_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (moderators_jfieldId == IntPtr.Zero)
						moderators_jfieldId = JNIEnv.GetFieldID (class_ref, "moderators", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, moderators_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='name']"
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

			static IntPtr outcasts_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='outcasts']"
			[Register ("outcasts")]
			public global::System.Collections.IList Outcasts {
				get {
					if (outcasts_jfieldId == IntPtr.Zero)
						outcasts_jfieldId = JNIEnv.GetFieldID (class_ref, "outcasts", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, outcasts_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (outcasts_jfieldId == IntPtr.Zero)
						outcasts_jfieldId = JNIEnv.GetFieldID (class_ref, "outcasts", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, outcasts_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr owners_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='owners']"
			[Register ("owners")]
			public global::System.Collections.IList Owners {
				get {
					if (owners_jfieldId == IntPtr.Zero)
						owners_jfieldId = JNIEnv.GetFieldID (class_ref, "owners", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, owners_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (owners_jfieldId == IntPtr.Zero)
						owners_jfieldId = JNIEnv.GetFieldID (class_ref, "owners", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, owners_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr participantProfiles_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='participantProfiles']"
			[Register ("participantProfiles")]
			public global::System.Collections.IList ParticipantProfiles {
				get {
					if (participantProfiles_jfieldId == IntPtr.Zero)
						participantProfiles_jfieldId = JNIEnv.GetFieldID (class_ref, "participantProfiles", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, participantProfiles_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (participantProfiles_jfieldId == IntPtr.Zero)
						participantProfiles_jfieldId = JNIEnv.GetFieldID (class_ref, "participantProfiles", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, participantProfiles_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr password_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='password']"
			[Register ("password")]
			public string Password {
				get {
					if (password_jfieldId == IntPtr.Zero)
						password_jfieldId = JNIEnv.GetFieldID (class_ref, "password", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, password_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (password_jfieldId == IntPtr.Zero)
						password_jfieldId = JNIEnv.GetFieldID (class_ref, "password", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, password_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr schedule_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/field[@name='schedule']"
			[Register ("schedule")]
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule Schedule {
				get {
					if (schedule_jfieldId == IntPtr.Zero)
						schedule_jfieldId = JNIEnv.GetFieldID (class_ref, "schedule", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties$VidyoRoomSchedule;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, schedule_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (schedule_jfieldId == IntPtr.Zero)
						schedule_jfieldId = JNIEnv.GetFieldID (class_ref, "schedule", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties$VidyoRoomSchedule;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, schedule_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomParticipantProfile']"
			[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties$VidyoRoomParticipantProfile", DoNotGenerateAcw=true)]
			public partial class VidyoRoomParticipantProfile : global::Java.Lang.Object {


				static IntPtr camera_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomParticipantProfile']/field[@name='camera']"
				[Register ("camera")]
				public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode Camera {
					get {
						if (camera_jfieldId == IntPtr.Zero)
							camera_jfieldId = JNIEnv.GetFieldID (class_ref, "camera", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, camera_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (camera_jfieldId == IntPtr.Zero)
							camera_jfieldId = JNIEnv.GetFieldID (class_ref, "camera", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, camera_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr chat_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomParticipantProfile']/field[@name='chat']"
				[Register ("chat")]
				public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode Chat {
					get {
						if (chat_jfieldId == IntPtr.Zero)
							chat_jfieldId = JNIEnv.GetFieldID (class_ref, "chat", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chat_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (chat_jfieldId == IntPtr.Zero)
							chat_jfieldId = JNIEnv.GetFieldID (class_ref, "chat", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chat_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr microphone_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomParticipantProfile']/field[@name='microphone']"
				[Register ("microphone")]
				public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode Microphone {
					get {
						if (microphone_jfieldId == IntPtr.Zero)
							microphone_jfieldId = JNIEnv.GetFieldID (class_ref, "microphone", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, microphone_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (microphone_jfieldId == IntPtr.Zero)
							microphone_jfieldId = JNIEnv.GetFieldID (class_ref, "microphone", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, microphone_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr userId_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomParticipantProfile']/field[@name='userId']"
				[Register ("userId")]
				public string UserId {
					get {
						if (userId_jfieldId == IntPtr.Zero)
							userId_jfieldId = JNIEnv.GetFieldID (class_ref, "userId", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, userId_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (userId_jfieldId == IntPtr.Zero)
							userId_jfieldId = JNIEnv.GetFieldID (class_ref, "userId", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, userId_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr windowShare_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomParticipantProfile']/field[@name='windowShare']"
				[Register ("windowShare")]
				public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode WindowShare {
					get {
						if (windowShare_jfieldId == IntPtr.Zero)
							windowShare_jfieldId = JNIEnv.GetFieldID (class_ref, "windowShare", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, windowShare_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProfileControlMode> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (windowShare_jfieldId == IntPtr.Zero)
							windowShare_jfieldId = JNIEnv.GetFieldID (class_ref, "windowShare", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProfileControlMode;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, windowShare_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties$VidyoRoomParticipantProfile", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (VidyoRoomParticipantProfile); }
				}

				protected VidyoRoomParticipantProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomParticipantProfile']/constructor[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomParticipantProfile' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties']]"
				[Register (".ctor", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V", "")]
				public unsafe VidyoRoomParticipantProfile (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties __self)
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (__self);
						if (((object) this).GetType () != typeof (VidyoRoomParticipantProfile)) {
							SetHandle (
									global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
									JniHandleOwnership.TransferLocalRef);
							global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
							return;
						}

						if (id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ == IntPtr.Zero)
							id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V");
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_, __args),
								JniHandleOwnership.TransferLocalRef);
						JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_, __args);
					} finally {
					}
				}

			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']"
			[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties$VidyoRoomSchedule", DoNotGenerateAcw=true)]
			public partial class VidyoRoomSchedule : global::Java.Lang.Object {


				static IntPtr byDay_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='byDay']"
				[Register ("byDay")]
				public string ByDay {
					get {
						if (byDay_jfieldId == IntPtr.Zero)
							byDay_jfieldId = JNIEnv.GetFieldID (class_ref, "byDay", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, byDay_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (byDay_jfieldId == IntPtr.Zero)
							byDay_jfieldId = JNIEnv.GetFieldID (class_ref, "byDay", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, byDay_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr byMonth_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='byMonth']"
				[Register ("byMonth")]
				public string ByMonth {
					get {
						if (byMonth_jfieldId == IntPtr.Zero)
							byMonth_jfieldId = JNIEnv.GetFieldID (class_ref, "byMonth", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, byMonth_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (byMonth_jfieldId == IntPtr.Zero)
							byMonth_jfieldId = JNIEnv.GetFieldID (class_ref, "byMonth", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, byMonth_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr byMonthDay_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='byMonthDay']"
				[Register ("byMonthDay")]
				public string ByMonthDay {
					get {
						if (byMonthDay_jfieldId == IntPtr.Zero)
							byMonthDay_jfieldId = JNIEnv.GetFieldID (class_ref, "byMonthDay", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, byMonthDay_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (byMonthDay_jfieldId == IntPtr.Zero)
							byMonthDay_jfieldId = JNIEnv.GetFieldID (class_ref, "byMonthDay", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, byMonthDay_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr bySetPos_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='bySetPos']"
				[Register ("bySetPos")]
				public string BySetPos {
					get {
						if (bySetPos_jfieldId == IntPtr.Zero)
							bySetPos_jfieldId = JNIEnv.GetFieldID (class_ref, "bySetPos", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bySetPos_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (bySetPos_jfieldId == IntPtr.Zero)
							bySetPos_jfieldId = JNIEnv.GetFieldID (class_ref, "bySetPos", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bySetPos_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr byWeekNum_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='byWeekNum']"
				[Register ("byWeekNum")]
				public string ByWeekNum {
					get {
						if (byWeekNum_jfieldId == IntPtr.Zero)
							byWeekNum_jfieldId = JNIEnv.GetFieldID (class_ref, "byWeekNum", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, byWeekNum_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (byWeekNum_jfieldId == IntPtr.Zero)
							byWeekNum_jfieldId = JNIEnv.GetFieldID (class_ref, "byWeekNum", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, byWeekNum_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr byYearDay_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='byYearDay']"
				[Register ("byYearDay")]
				public string ByYearDay {
					get {
						if (byYearDay_jfieldId == IntPtr.Zero)
							byYearDay_jfieldId = JNIEnv.GetFieldID (class_ref, "byYearDay", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, byYearDay_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (byYearDay_jfieldId == IntPtr.Zero)
							byYearDay_jfieldId = JNIEnv.GetFieldID (class_ref, "byYearDay", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, byYearDay_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr count_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='count']"
				[Register ("count")]
				public string Count {
					get {
						if (count_jfieldId == IntPtr.Zero)
							count_jfieldId = JNIEnv.GetFieldID (class_ref, "count", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, count_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (count_jfieldId == IntPtr.Zero)
							count_jfieldId = JNIEnv.GetFieldID (class_ref, "count", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, count_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr duration_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='duration']"
				[Register ("duration")]
				public string Duration {
					get {
						if (duration_jfieldId == IntPtr.Zero)
							duration_jfieldId = JNIEnv.GetFieldID (class_ref, "duration", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, duration_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (duration_jfieldId == IntPtr.Zero)
							duration_jfieldId = JNIEnv.GetFieldID (class_ref, "duration", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, duration_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr endTime_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='endTime']"
				[Register ("endTime")]
				public string EndTime {
					get {
						if (endTime_jfieldId == IntPtr.Zero)
							endTime_jfieldId = JNIEnv.GetFieldID (class_ref, "endTime", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, endTime_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (endTime_jfieldId == IntPtr.Zero)
							endTime_jfieldId = JNIEnv.GetFieldID (class_ref, "endTime", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, endTime_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr eventId_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='eventId']"
				[Register ("eventId")]
				public string EventId {
					get {
						if (eventId_jfieldId == IntPtr.Zero)
							eventId_jfieldId = JNIEnv.GetFieldID (class_ref, "eventId", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, eventId_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (eventId_jfieldId == IntPtr.Zero)
							eventId_jfieldId = JNIEnv.GetFieldID (class_ref, "eventId", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, eventId_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr frequency_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='frequency']"
				[Register ("frequency")]
				public string Frequency {
					get {
						if (frequency_jfieldId == IntPtr.Zero)
							frequency_jfieldId = JNIEnv.GetFieldID (class_ref, "frequency", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frequency_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (frequency_jfieldId == IntPtr.Zero)
							frequency_jfieldId = JNIEnv.GetFieldID (class_ref, "frequency", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frequency_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr interval_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='interval']"
				[Register ("interval")]
				public string Interval {
					get {
						if (interval_jfieldId == IntPtr.Zero)
							interval_jfieldId = JNIEnv.GetFieldID (class_ref, "interval", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, interval_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (interval_jfieldId == IntPtr.Zero)
							interval_jfieldId = JNIEnv.GetFieldID (class_ref, "interval", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, interval_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr startTime_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='startTime']"
				[Register ("startTime")]
				public string StartTime {
					get {
						if (startTime_jfieldId == IntPtr.Zero)
							startTime_jfieldId = JNIEnv.GetFieldID (class_ref, "startTime", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, startTime_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (startTime_jfieldId == IntPtr.Zero)
							startTime_jfieldId = JNIEnv.GetFieldID (class_ref, "startTime", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startTime_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr until_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='until']"
				[Register ("until")]
				public string Until {
					get {
						if (until_jfieldId == IntPtr.Zero)
							until_jfieldId = JNIEnv.GetFieldID (class_ref, "until", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, until_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (until_jfieldId == IntPtr.Zero)
							until_jfieldId = JNIEnv.GetFieldID (class_ref, "until", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, until_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr weekStartDay_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/field[@name='weekStartDay']"
				[Register ("weekStartDay")]
				public string WeekStartDay {
					get {
						if (weekStartDay_jfieldId == IntPtr.Zero)
							weekStartDay_jfieldId = JNIEnv.GetFieldID (class_ref, "weekStartDay", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, weekStartDay_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (weekStartDay_jfieldId == IntPtr.Zero)
							weekStartDay_jfieldId = JNIEnv.GetFieldID (class_ref, "weekStartDay", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, weekStartDay_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties$VidyoRoomSchedule", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (VidyoRoomSchedule); }
				}

				protected VidyoRoomSchedule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule']/constructor[@name='VidyoRoom.VidyoRoomProperties.VidyoRoomSchedule' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties']]"
				[Register (".ctor", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V", "")]
				public unsafe VidyoRoomSchedule (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties __self)
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (__self);
						if (((object) this).GetType () != typeof (VidyoRoomSchedule)) {
							SetHandle (
									global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
									JniHandleOwnership.TransferLocalRef);
							global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
							return;
						}

						if (id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ == IntPtr.Zero)
							id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V");
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_, __args),
								JniHandleOwnership.TransferLocalRef);
						JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_, __args);
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomProperties); }
			}

			protected VidyoRoomProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomProperties']/constructor[@name='VidyoRoom.VidyoRoomProperties' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom']]"
			[Register (".ctor", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V", "")]
			public unsafe VidyoRoomProperties (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (VidyoRoomProperties)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ == IntPtr.Zero)
						id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSearchResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomSearchResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMSEARCHRESULT_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSearchResult']/field[@name='VIDYO_ROOMSEARCHRESULT_MiscLocalError']"
			[Register ("VIDYO_ROOMSEARCHRESULT_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult VIDYOROOMSEARCHRESULTMiscLocalError {
				get {
					if (VIDYO_ROOMSEARCHRESULT_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHRESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHRESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHRESULT_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHRESULT_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSearchResult']/field[@name='VIDYO_ROOMSEARCHRESULT_MiscRemoteError']"
			[Register ("VIDYO_ROOMSEARCHRESULT_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult VIDYOROOMSEARCHRESULTMiscRemoteError {
				get {
					if (VIDYO_ROOMSEARCHRESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHRESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHRESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHRESULT_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHRESULT_NoRecords_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSearchResult']/field[@name='VIDYO_ROOMSEARCHRESULT_NoRecords']"
			[Register ("VIDYO_ROOMSEARCHRESULT_NoRecords")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult VIDYOROOMSEARCHRESULTNoRecords {
				get {
					if (VIDYO_ROOMSEARCHRESULT_NoRecords_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHRESULT_NoRecords_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHRESULT_NoRecords", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHRESULT_NoRecords_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHRESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSearchResult']/field[@name='VIDYO_ROOMSEARCHRESULT_NoResponse']"
			[Register ("VIDYO_ROOMSEARCHRESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult VIDYOROOMSEARCHRESULTNoResponse {
				get {
					if (VIDYO_ROOMSEARCHRESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHRESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHRESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHRESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHRESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSearchResult']/field[@name='VIDYO_ROOMSEARCHRESULT_OK']"
			[Register ("VIDYO_ROOMSEARCHRESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult VidyoRoomsearchresultOk {
				get {
					if (VIDYO_ROOMSEARCHRESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHRESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHRESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHRESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHRESULT_Unauthorized_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSearchResult']/field[@name='VIDYO_ROOMSEARCHRESULT_Unauthorized']"
			[Register ("VIDYO_ROOMSEARCHRESULT_Unauthorized")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult VIDYOROOMSEARCHRESULTUnauthorized {
				get {
					if (VIDYO_ROOMSEARCHRESULT_Unauthorized_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHRESULT_Unauthorized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHRESULT_Unauthorized", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHRESULT_Unauthorized_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomSearchResult); }
			}

			internal VidyoRoomSearchResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSearchResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSearchResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomSetFavoriteResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMSETFAVORITERESULT_Conflict_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']/field[@name='VIDYO_ROOMSETFAVORITERESULT_Conflict']"
			[Register ("VIDYO_ROOMSETFAVORITERESULT_Conflict")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult VIDYOROOMSETFAVORITERESULTConflict {
				get {
					if (VIDYO_ROOMSETFAVORITERESULT_Conflict_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETFAVORITERESULT_Conflict_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETFAVORITERESULT_Conflict", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETFAVORITERESULT_Conflict_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETFAVORITERESULT_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']/field[@name='VIDYO_ROOMSETFAVORITERESULT_MiscLocalError']"
			[Register ("VIDYO_ROOMSETFAVORITERESULT_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult VIDYOROOMSETFAVORITERESULTMiscLocalError {
				get {
					if (VIDYO_ROOMSETFAVORITERESULT_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETFAVORITERESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETFAVORITERESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETFAVORITERESULT_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETFAVORITERESULT_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']/field[@name='VIDYO_ROOMSETFAVORITERESULT_MiscRemoteError']"
			[Register ("VIDYO_ROOMSETFAVORITERESULT_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult VIDYOROOMSETFAVORITERESULTMiscRemoteError {
				get {
					if (VIDYO_ROOMSETFAVORITERESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETFAVORITERESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETFAVORITERESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETFAVORITERESULT_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETFAVORITERESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']/field[@name='VIDYO_ROOMSETFAVORITERESULT_NoResponse']"
			[Register ("VIDYO_ROOMSETFAVORITERESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult VIDYOROOMSETFAVORITERESULTNoResponse {
				get {
					if (VIDYO_ROOMSETFAVORITERESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETFAVORITERESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETFAVORITERESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETFAVORITERESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETFAVORITERESULT_NotAcceptable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']/field[@name='VIDYO_ROOMSETFAVORITERESULT_NotAcceptable']"
			[Register ("VIDYO_ROOMSETFAVORITERESULT_NotAcceptable")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult VIDYOROOMSETFAVORITERESULTNotAcceptable {
				get {
					if (VIDYO_ROOMSETFAVORITERESULT_NotAcceptable_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETFAVORITERESULT_NotAcceptable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETFAVORITERESULT_NotAcceptable", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETFAVORITERESULT_NotAcceptable_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETFAVORITERESULT_NotAllowed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']/field[@name='VIDYO_ROOMSETFAVORITERESULT_NotAllowed']"
			[Register ("VIDYO_ROOMSETFAVORITERESULT_NotAllowed")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult VIDYOROOMSETFAVORITERESULTNotAllowed {
				get {
					if (VIDYO_ROOMSETFAVORITERESULT_NotAllowed_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETFAVORITERESULT_NotAllowed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETFAVORITERESULT_NotAllowed", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETFAVORITERESULT_NotAllowed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETFAVORITERESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']/field[@name='VIDYO_ROOMSETFAVORITERESULT_OK']"
			[Register ("VIDYO_ROOMSETFAVORITERESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult VidyoRoomsetfavoriteresultOk {
				get {
					if (VIDYO_ROOMSETFAVORITERESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETFAVORITERESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETFAVORITERESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETFAVORITERESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETFAVORITERESULT_Unauthorized_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']/field[@name='VIDYO_ROOMSETFAVORITERESULT_Unauthorized']"
			[Register ("VIDYO_ROOMSETFAVORITERESULT_Unauthorized")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult VIDYOROOMSETFAVORITERESULTUnauthorized {
				get {
					if (VIDYO_ROOMSETFAVORITERESULT_Unauthorized_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETFAVORITERESULT_Unauthorized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETFAVORITERESULT_Unauthorized", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETFAVORITERESULT_Unauthorized_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomSetFavoriteResult); }
			}

			internal VidyoRoomSetFavoriteResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetFavoriteResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomSetPropertiesResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMSETPROPERTIESRESULT_Conflict_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']/field[@name='VIDYO_ROOMSETPROPERTIESRESULT_Conflict']"
			[Register ("VIDYO_ROOMSETPROPERTIESRESULT_Conflict")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult VIDYOROOMSETPROPERTIESRESULTConflict {
				get {
					if (VIDYO_ROOMSETPROPERTIESRESULT_Conflict_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETPROPERTIESRESULT_Conflict_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETPROPERTIESRESULT_Conflict", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETPROPERTIESRESULT_Conflict_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETPROPERTIESRESULT_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']/field[@name='VIDYO_ROOMSETPROPERTIESRESULT_MiscLocalError']"
			[Register ("VIDYO_ROOMSETPROPERTIESRESULT_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult VIDYOROOMSETPROPERTIESRESULTMiscLocalError {
				get {
					if (VIDYO_ROOMSETPROPERTIESRESULT_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETPROPERTIESRESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETPROPERTIESRESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETPROPERTIESRESULT_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETPROPERTIESRESULT_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']/field[@name='VIDYO_ROOMSETPROPERTIESRESULT_MiscRemoteError']"
			[Register ("VIDYO_ROOMSETPROPERTIESRESULT_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult VIDYOROOMSETPROPERTIESRESULTMiscRemoteError {
				get {
					if (VIDYO_ROOMSETPROPERTIESRESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETPROPERTIESRESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETPROPERTIESRESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETPROPERTIESRESULT_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETPROPERTIESRESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']/field[@name='VIDYO_ROOMSETPROPERTIESRESULT_NoResponse']"
			[Register ("VIDYO_ROOMSETPROPERTIESRESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult VIDYOROOMSETPROPERTIESRESULTNoResponse {
				get {
					if (VIDYO_ROOMSETPROPERTIESRESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETPROPERTIESRESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETPROPERTIESRESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETPROPERTIESRESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETPROPERTIESRESULT_NotAcceptable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']/field[@name='VIDYO_ROOMSETPROPERTIESRESULT_NotAcceptable']"
			[Register ("VIDYO_ROOMSETPROPERTIESRESULT_NotAcceptable")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult VIDYOROOMSETPROPERTIESRESULTNotAcceptable {
				get {
					if (VIDYO_ROOMSETPROPERTIESRESULT_NotAcceptable_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETPROPERTIESRESULT_NotAcceptable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETPROPERTIESRESULT_NotAcceptable", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETPROPERTIESRESULT_NotAcceptable_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETPROPERTIESRESULT_NotAllowed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']/field[@name='VIDYO_ROOMSETPROPERTIESRESULT_NotAllowed']"
			[Register ("VIDYO_ROOMSETPROPERTIESRESULT_NotAllowed")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult VIDYOROOMSETPROPERTIESRESULTNotAllowed {
				get {
					if (VIDYO_ROOMSETPROPERTIESRESULT_NotAllowed_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETPROPERTIESRESULT_NotAllowed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETPROPERTIESRESULT_NotAllowed", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETPROPERTIESRESULT_NotAllowed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETPROPERTIESRESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']/field[@name='VIDYO_ROOMSETPROPERTIESRESULT_OK']"
			[Register ("VIDYO_ROOMSETPROPERTIESRESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult VidyoRoomsetpropertiesresultOk {
				get {
					if (VIDYO_ROOMSETPROPERTIESRESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETPROPERTIESRESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETPROPERTIESRESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETPROPERTIESRESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSETPROPERTIESRESULT_Unauthorized_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']/field[@name='VIDYO_ROOMSETPROPERTIESRESULT_Unauthorized']"
			[Register ("VIDYO_ROOMSETPROPERTIESRESULT_Unauthorized")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult VIDYOROOMSETPROPERTIESRESULTUnauthorized {
				get {
					if (VIDYO_ROOMSETPROPERTIESRESULT_Unauthorized_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSETPROPERTIESRESULT_Unauthorized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSETPROPERTIESRESULT_Unauthorized", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSETPROPERTIESRESULT_Unauthorized_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomSetPropertiesResult); }
			}

			internal VidyoRoomSetPropertiesResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomSetPropertiesResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomState : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMSTATE_Created_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_Created']"
			[Register ("VIDYO_ROOMSTATE_Created")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATECreated {
				get {
					if (VIDYO_ROOMSTATE_Created_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_Created_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_Created", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_Created_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_Creating_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_Creating']"
			[Register ("VIDYO_ROOMSTATE_Creating")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATECreating {
				get {
					if (VIDYO_ROOMSTATE_Creating_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_Creating_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_Creating", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_Creating_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_Entered_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_Entered']"
			[Register ("VIDYO_ROOMSTATE_Entered")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATEEntered {
				get {
					if (VIDYO_ROOMSTATE_Entered_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_Entered_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_Entered", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_Entered_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_Entering_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_Entering']"
			[Register ("VIDYO_ROOMSTATE_Entering")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATEEntering {
				get {
					if (VIDYO_ROOMSTATE_Entering_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_Entering_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_Entering", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_Entering_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_Exited_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_Exited']"
			[Register ("VIDYO_ROOMSTATE_Exited")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATEExited {
				get {
					if (VIDYO_ROOMSTATE_Exited_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_Exited_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_Exited", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_Exited_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_Exiting_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_Exiting']"
			[Register ("VIDYO_ROOMSTATE_Exiting")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATEExiting {
				get {
					if (VIDYO_ROOMSTATE_Exiting_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_Exiting_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_Exiting", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_Exiting_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_MediaDisabled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_MediaDisabled']"
			[Register ("VIDYO_ROOMSTATE_MediaDisabled")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATEMediaDisabled {
				get {
					if (VIDYO_ROOMSTATE_MediaDisabled_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_MediaDisabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_MediaDisabled", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_MediaDisabled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_MediaDisabling_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_MediaDisabling']"
			[Register ("VIDYO_ROOMSTATE_MediaDisabling")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATEMediaDisabling {
				get {
					if (VIDYO_ROOMSTATE_MediaDisabling_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_MediaDisabling_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_MediaDisabling", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_MediaDisabling_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_MediaEnabled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_MediaEnabled']"
			[Register ("VIDYO_ROOMSTATE_MediaEnabled")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATEMediaEnabled {
				get {
					if (VIDYO_ROOMSTATE_MediaEnabled_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_MediaEnabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_MediaEnabled", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_MediaEnabled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_MediaEnabling_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_MediaEnabling']"
			[Register ("VIDYO_ROOMSTATE_MediaEnabling")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATEMediaEnabling {
				get {
					if (VIDYO_ROOMSTATE_MediaEnabling_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_MediaEnabling_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_MediaEnabling", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_MediaEnabling_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_MediaRouteAcquired_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_MediaRouteAcquired']"
			[Register ("VIDYO_ROOMSTATE_MediaRouteAcquired")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATEMediaRouteAcquired {
				get {
					if (VIDYO_ROOMSTATE_MediaRouteAcquired_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_MediaRouteAcquired_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_MediaRouteAcquired", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_MediaRouteAcquired_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSTATE_MediaRouteAcquiring_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/field[@name='VIDYO_ROOMSTATE_MediaRouteAcquiring']"
			[Register ("VIDYO_ROOMSTATE_MediaRouteAcquiring")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState VIDYOROOMSTATEMediaRouteAcquiring {
				get {
					if (VIDYO_ROOMSTATE_MediaRouteAcquiring_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSTATE_MediaRouteAcquiring_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSTATE_MediaRouteAcquiring", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSTATE_MediaRouteAcquiring_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomState); }
			}

			internal VidyoRoomState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomState;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomType : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMTYPE_Conversation_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomType']/field[@name='VIDYO_ROOMTYPE_Conversation']"
			[Register ("VIDYO_ROOMTYPE_Conversation")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType VIDYOROOMTYPEConversation {
				get {
					if (VIDYO_ROOMTYPE_Conversation_jfieldId == IntPtr.Zero)
						VIDYO_ROOMTYPE_Conversation_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMTYPE_Conversation", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMTYPE_Conversation_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMTYPE_Scheduled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomType']/field[@name='VIDYO_ROOMTYPE_Scheduled']"
			[Register ("VIDYO_ROOMTYPE_Scheduled")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType VIDYOROOMTYPEScheduled {
				get {
					if (VIDYO_ROOMTYPE_Scheduled_jfieldId == IntPtr.Zero)
						VIDYO_ROOMTYPE_Scheduled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMTYPE_Scheduled", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMTYPE_Scheduled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMTYPE_Topic_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomType']/field[@name='VIDYO_ROOMTYPE_Topic']"
			[Register ("VIDYO_ROOMTYPE_Topic")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType VIDYOROOMTYPETopic {
				get {
					if (VIDYO_ROOMTYPE_Topic_jfieldId == IntPtr.Zero)
						VIDYO_ROOMTYPE_Topic_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMTYPE_Topic", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMTYPE_Topic_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMTYPE_Unknown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomType']/field[@name='VIDYO_ROOMTYPE_Unknown']"
			[Register ("VIDYO_ROOMTYPE_Unknown")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType VIDYOROOMTYPEUnknown {
				get {
					if (VIDYO_ROOMTYPE_Unknown_jfieldId == IntPtr.Zero)
						VIDYO_ROOMTYPE_Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMTYPE_Unknown", "Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMTYPE_Unknown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomType); }
			}

			internal VidyoRoomType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom.VidyoRoomType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoRoom", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoRoom); }
		}

		protected VidyoRoom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/constructor[@name='VidyoRoom' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoRoom (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoRoom)) {
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetId' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_GetType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_GetType == null)
				cb_GetType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_GetType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_GetType;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetType' and count(parameter)=0]"
			[Register ("GetType", "()Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;", "GetGetTypeHandler")]
			get {
				if (id_GetType == IntPtr.Zero)
					id_GetType = JNIEnv.GetMethodID (class_ref, "GetType", "()Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetType", "()Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetUser;
#pragma warning disable 0169
		static Delegate GetGetUserHandler ()
		{
			if (cb_GetUser == null)
				cb_GetUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUser);
			return cb_GetUser;
		}

		static IntPtr n_GetUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.User);
		}
#pragma warning restore 0169

		static IntPtr id_GetUser;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser User {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetUser' and count(parameter)=0]"
			[Register ("GetUser", "()Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;", "GetGetUserHandler")]
			get {
				if (id_GetUser == IntPtr.Zero)
					id_GetUser = JNIEnv.GetMethodID (class_ref, "GetUser", "()Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetUser), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetUser", "()Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetUserData;
#pragma warning disable 0169
		static Delegate GetGetUserDataHandler ()
		{
			if (cb_GetUserData == null)
				cb_GetUserData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetUserData);
			return cb_GetUserData;
		}

		static long n_GetUserData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserData;
		}
#pragma warning restore 0169

		static Delegate cb_SetUserData_J;
#pragma warning disable 0169
		static Delegate GetSetUserData_JHandler ()
		{
			if (cb_SetUserData_J == null)
				cb_SetUserData_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetUserData_J);
			return cb_SetUserData_J;
		}

		static void n_SetUserData_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UserData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetUserData;
		static IntPtr id_SetUserData_J;
		public virtual unsafe long UserData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetUserData' and count(parameter)=0]"
			[Register ("GetUserData", "()J", "GetGetUserDataHandler")]
			get {
				if (id_GetUserData == IntPtr.Zero)
					id_GetUserData = JNIEnv.GetMethodID (class_ref, "GetUserData", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_GetUserData);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetUserData", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SetUserData' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("SetUserData", "(J)V", "GetSetUserData_JHandler")]
			set {
				if (id_SetUserData_J == IntPtr.Zero)
					id_SetUserData_J = JNIEnv.GetMethodID (class_ref, "SetUserData", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetUserData_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetUserData", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_AcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_;
#pragma warning disable 0169
		static Delegate GetAcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_Handler ()
		{
			if (cb_AcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_ == null)
				cb_AcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_);
			return cb_AcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_;
		}

		static bool n_AcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AcceptIncoming (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='AcceptIncoming' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming']]"
		[Register ("AcceptIncoming", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcceptIncoming;)Z", "GetAcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_Handler")]
		public virtual unsafe bool AcceptIncoming (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming p0)
		{
			if (id_AcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_ == IntPtr.Zero)
				id_AcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_ = JNIEnv.GetMethodID (class_ref, "AcceptIncoming", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcceptIncoming;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AcceptIncoming_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AcceptIncoming", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcceptIncoming;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_AcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_;
#pragma warning disable 0169
		static Delegate GetAcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_Handler ()
		{
			if (cb_AcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_ == null)
				cb_AcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_);
			return cb_AcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_;
		}

		static bool n_AcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcquireMediaRoute p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcquireMediaRoute)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcquireMediaRoute> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AcquireMediaRoute (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='AcquireMediaRoute' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IAcquireMediaRoute']]"
		[Register ("AcquireMediaRoute", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcquireMediaRoute;)Z", "GetAcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_Handler")]
		public virtual unsafe bool AcquireMediaRoute (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcquireMediaRoute p0)
		{
			if (id_AcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_ == IntPtr.Zero)
				id_AcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_ = JNIEnv.GetMethodID (class_ref, "AcquireMediaRoute", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcquireMediaRoute;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AcquireMediaRoute_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcquireMediaRoute_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AcquireMediaRoute", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcquireMediaRoute;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_AddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Z;
#pragma warning disable 0169
		static Delegate GetAddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZHandler ()
		{
			if (cb_AddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Z == null)
				cb_AddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Z);
			return cb_AddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Z;
		}

		static void n_AddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLocalCamera (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_AddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='AddLocalCamera' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera'] and parameter[2][@type='boolean']]"
		[Register ("AddLocalCamera", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Z)V", "GetAddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ZHandler")]
		public virtual unsafe void AddLocalCamera (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0, bool p1)
		{
			if (id_AddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Z == IntPtr.Zero)
				id_AddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Z = JNIEnv.GetMethodID (class_ref, "AddLocalCamera", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_AddLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddLocalCamera", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_AddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZ;
#pragma warning disable 0169
		static Delegate GetAddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZHandler ()
		{
			if (cb_AddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZ == null)
				cb_AddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, bool>) n_AddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZ);
			return cb_AddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZ;
		}

		static void n_AddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLocalMicrophone (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_AddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='AddLocalMicrophone' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("AddLocalMicrophone", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;ZZ)V", "GetAddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZHandler")]
		public virtual unsafe void AddLocalMicrophone (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0, bool p1, bool p2)
		{
			if (id_AddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZ == IntPtr.Zero)
				id_AddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZ = JNIEnv.GetMethodID (class_ref, "AddLocalMicrophone", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;ZZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_AddLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddLocalMicrophone", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;ZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_AddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Z;
#pragma warning disable 0169
		static Delegate GetAddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ZHandler ()
		{
			if (cb_AddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Z == null)
				cb_AddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Z);
			return cb_AddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Z;
		}

		static void n_AddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLocalMonitor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_AddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='AddLocalMonitor' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor'] and parameter[2][@type='boolean']]"
		[Register ("AddLocalMonitor", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Z)V", "GetAddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ZHandler")]
		public virtual unsafe void AddLocalMonitor (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0, bool p1)
		{
			if (id_AddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Z == IntPtr.Zero)
				id_AddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Z = JNIEnv.GetMethodID (class_ref, "AddLocalMonitor", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_AddLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddLocalMonitor", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_AddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Z;
#pragma warning disable 0169
		static Delegate GetAddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ZHandler ()
		{
			if (cb_AddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Z == null)
				cb_AddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Z);
			return cb_AddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Z;
		}

		static void n_AddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLocalRenderer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_AddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='AddLocalRenderer' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer'] and parameter[2][@type='boolean']]"
		[Register ("AddLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Z)V", "GetAddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ZHandler")]
		public virtual unsafe void AddLocalRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0, bool p1)
		{
			if (id_AddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Z == IntPtr.Zero)
				id_AddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Z = JNIEnv.GetMethodID (class_ref, "AddLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_AddLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_AddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZ;
#pragma warning disable 0169
		static Delegate GetAddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZHandler ()
		{
			if (cb_AddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZ == null)
				cb_AddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, bool>) n_AddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZ);
			return cb_AddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZ;
		}

		static void n_AddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLocalSpeaker (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_AddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='AddLocalSpeaker' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("AddLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;ZZ)V", "GetAddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZHandler")]
		public virtual unsafe void AddLocalSpeaker (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, bool p1, bool p2)
		{
			if (id_AddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZ == IntPtr.Zero)
				id_AddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZ = JNIEnv.GetMethodID (class_ref, "AddLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;ZZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_AddLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;ZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_AddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Z;
#pragma warning disable 0169
		static Delegate GetAddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ZHandler ()
		{
			if (cb_AddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Z == null)
				cb_AddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Z);
			return cb_AddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Z;
		}

		static void n_AddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLocalWindowShare (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_AddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='AddLocalWindowShare' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare'] and parameter[2][@type='boolean']]"
		[Register ("AddLocalWindowShare", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Z)V", "GetAddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ZHandler")]
		public virtual unsafe void AddLocalWindowShare (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0, bool p1)
		{
			if (id_AddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Z == IntPtr.Zero)
				id_AddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Z = JNIEnv.GetMethodID (class_ref, "AddLocalWindowShare", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_AddLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddLocalWindowShare", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_Delete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_Handler ()
		{
			if (cb_Delete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_ == null)
				cb_Delete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_);
			return cb_Delete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_;
		}

		static void n_Delete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IDelete p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IDelete)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IDelete> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Delete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='Delete' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IDelete']]"
		[Register ("Delete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IDelete;)V", "GetDelete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_Handler")]
		public virtual unsafe void Delete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IDelete p0)
		{
			if (id_Delete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_ == IntPtr.Zero)
				id_Delete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_ = JNIEnv.GetMethodID (class_ref, "Delete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IDelete;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Delete_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IDelete_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Delete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IDelete;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_DisableMedia;
#pragma warning disable 0169
		static Delegate GetDisableMediaHandler ()
		{
			if (cb_DisableMedia == null)
				cb_DisableMedia = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DisableMedia);
			return cb_DisableMedia;
		}

		static bool n_DisableMedia (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisableMedia ();
		}
#pragma warning restore 0169

		static IntPtr id_DisableMedia;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='DisableMedia' and count(parameter)=0]"
		[Register ("DisableMedia", "()Z", "GetDisableMediaHandler")]
		public virtual unsafe bool DisableMedia ()
		{
			if (id_DisableMedia == IntPtr.Zero)
				id_DisableMedia = JNIEnv.GetMethodID (class_ref, "DisableMedia", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_DisableMedia);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DisableMedia", "()Z"));
			} finally {
			}
		}

		static Delegate cb_EnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_;
#pragma warning disable 0169
		static Delegate GetEnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_Handler ()
		{
			if (cb_EnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_ == null)
				cb_EnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_EnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_);
			return cb_EnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_;
		}

		static bool n_EnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EnableMedia (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_EnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='EnableMedia' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia']]"
		[Register ("EnableMedia", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IEnableMedia;)Z", "GetEnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_Handler")]
		public virtual unsafe bool EnableMedia (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IEnableMedia p0)
		{
			if (id_EnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_ == IntPtr.Zero)
				id_EnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_ = JNIEnv.GetMethodID (class_ref, "EnableMedia", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IEnableMedia;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_EnableMedia_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IEnableMedia_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "EnableMedia", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IEnableMedia;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_Enter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_;
#pragma warning disable 0169
		static Delegate GetEnter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_Handler ()
		{
			if (cb_Enter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_ == null)
				cb_Enter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Enter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_);
			return cb_Enter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_;
		}

		static bool n_Enter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Enter (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Enter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='Enter' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming']]"
		[Register ("Enter", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcceptIncoming;)Z", "GetEnter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_Handler")]
		public virtual unsafe bool Enter (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IAcceptIncoming p0)
		{
			if (id_Enter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_ == IntPtr.Zero)
				id_Enter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_ = JNIEnv.GetMethodID (class_ref, "Enter", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcceptIncoming;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Enter_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IAcceptIncoming_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Enter", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IAcceptIncoming;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_;
#pragma warning disable 0169
		static Delegate GetGetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_Handler ()
		{
			if (cb_GetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ == null)
				cb_GetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_GetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_);
			return cb_GetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_;
		}

		static bool n_GetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory p1 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetHistory (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetHistory' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory']]"
		[Register ("GetHistory", "(ILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory;)Z", "GetGetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_Handler")]
		public virtual unsafe bool GetHistory (int p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory p1)
		{
			if (id_GetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ == IntPtr.Zero)
				id_GetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ = JNIEnv.GetMethodID (class_ref, "GetHistory", "(ILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetHistory_ILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetHistory", "(ILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_;
#pragma warning disable 0169
		static Delegate GetGetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_Handler ()
		{
			if (cb_GetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ == null)
				cb_GetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int, IntPtr, bool>) n_GetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_);
			return cb_GetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_;
		}

		static bool n_GetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetHistoryById (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetHistoryById' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory']]"
		[Register ("GetHistoryById", "(JIILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory;)Z", "GetGetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_Handler")]
		public virtual unsafe bool GetHistoryById (long p0, int p1, int p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory p3)
		{
			if (id_GetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ == IntPtr.Zero)
				id_GetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ = JNIEnv.GetMethodID (class_ref, "GetHistoryById", "(JIILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory;)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetHistoryById_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetHistoryById", "(JIILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_;
#pragma warning disable 0169
		static Delegate GetGetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_Handler ()
		{
			if (cb_GetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ == null)
				cb_GetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int, IntPtr, bool>) n_GetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_);
			return cb_GetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_;
		}

		static bool n_GetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetHistoryByTime (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetHistoryByTime' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory']]"
		[Register ("GetHistoryByTime", "(JIILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory;)Z", "GetGetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_Handler")]
		public virtual unsafe bool GetHistoryByTime (long p0, int p1, int p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetHistory p3)
		{
			if (id_GetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ == IntPtr.Zero)
				id_GetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_ = JNIEnv.GetMethodID (class_ref, "GetHistoryByTime", "(JIILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory;)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetHistoryByTime_JIILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetHistory_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetHistoryByTime", "(JIILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetHistory;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_;
#pragma warning disable 0169
		static Delegate GetGetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_Handler ()
		{
			if (cb_GetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_ == null)
				cb_GetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_);
			return cb_GetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_;
		}

		static bool n_GetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetRoomProperties p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetRoomProperties)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetRoomProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetRoomProperties (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetRoomProperties' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IGetRoomProperties']]"
		[Register ("GetRoomProperties", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetRoomProperties;)Z", "GetGetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_Handler")]
		public virtual unsafe bool GetRoomProperties (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IGetRoomProperties p0)
		{
			if (id_GetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_ == IntPtr.Zero)
				id_GetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_ = JNIEnv.GetMethodID (class_ref, "GetRoomProperties", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetRoomProperties;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IGetRoomProperties_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetRoomProperties", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IGetRoomProperties;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetSelectedLocalCameras_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetSelectedLocalCameras_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetSelectedLocalCameras_Ljava_util_ArrayList_ == null)
				cb_GetSelectedLocalCameras_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSelectedLocalCameras_Ljava_util_ArrayList_);
			return cb_GetSelectedLocalCameras_Ljava_util_ArrayList_;
		}

		static void n_GetSelectedLocalCameras_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSelectedLocalCameras (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetSelectedLocalCameras_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetSelectedLocalCameras' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoLocalCamera&gt;']]"
		[Register ("GetSelectedLocalCameras", "(Ljava/util/ArrayList;)V", "GetGetSelectedLocalCameras_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void GetSelectedLocalCameras (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> p0)
		{
			if (id_GetSelectedLocalCameras_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetSelectedLocalCameras_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetSelectedLocalCameras", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_GetSelectedLocalCameras_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSelectedLocalCameras", "(Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetSelectedLocalMicrophones_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetSelectedLocalMicrophones_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetSelectedLocalMicrophones_Ljava_util_ArrayList_ == null)
				cb_GetSelectedLocalMicrophones_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSelectedLocalMicrophones_Ljava_util_ArrayList_);
			return cb_GetSelectedLocalMicrophones_Ljava_util_ArrayList_;
		}

		static void n_GetSelectedLocalMicrophones_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSelectedLocalMicrophones (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetSelectedLocalMicrophones_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetSelectedLocalMicrophones' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoLocalMicrophone&gt;']]"
		[Register ("GetSelectedLocalMicrophones", "(Ljava/util/ArrayList;)V", "GetGetSelectedLocalMicrophones_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void GetSelectedLocalMicrophones (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> p0)
		{
			if (id_GetSelectedLocalMicrophones_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetSelectedLocalMicrophones_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetSelectedLocalMicrophones", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_GetSelectedLocalMicrophones_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSelectedLocalMicrophones", "(Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetSelectedLocalMonitors_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetSelectedLocalMonitors_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetSelectedLocalMonitors_Ljava_util_ArrayList_ == null)
				cb_GetSelectedLocalMonitors_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSelectedLocalMonitors_Ljava_util_ArrayList_);
			return cb_GetSelectedLocalMonitors_Ljava_util_ArrayList_;
		}

		static void n_GetSelectedLocalMonitors_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSelectedLocalMonitors (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetSelectedLocalMonitors_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetSelectedLocalMonitors' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoLocalMonitor&gt;']]"
		[Register ("GetSelectedLocalMonitors", "(Ljava/util/ArrayList;)V", "GetGetSelectedLocalMonitors_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void GetSelectedLocalMonitors (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> p0)
		{
			if (id_GetSelectedLocalMonitors_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetSelectedLocalMonitors_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetSelectedLocalMonitors", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_GetSelectedLocalMonitors_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSelectedLocalMonitors", "(Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetSelectedLocalRenderers_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetSelectedLocalRenderers_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetSelectedLocalRenderers_Ljava_util_ArrayList_ == null)
				cb_GetSelectedLocalRenderers_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSelectedLocalRenderers_Ljava_util_ArrayList_);
			return cb_GetSelectedLocalRenderers_Ljava_util_ArrayList_;
		}

		static void n_GetSelectedLocalRenderers_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSelectedLocalRenderers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetSelectedLocalRenderers_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetSelectedLocalRenderers' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoLocalRenderer&gt;']]"
		[Register ("GetSelectedLocalRenderers", "(Ljava/util/ArrayList;)V", "GetGetSelectedLocalRenderers_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void GetSelectedLocalRenderers (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> p0)
		{
			if (id_GetSelectedLocalRenderers_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetSelectedLocalRenderers_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetSelectedLocalRenderers", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_GetSelectedLocalRenderers_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSelectedLocalRenderers", "(Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetSelectedLocalSpeakers_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetSelectedLocalSpeakers_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetSelectedLocalSpeakers_Ljava_util_ArrayList_ == null)
				cb_GetSelectedLocalSpeakers_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSelectedLocalSpeakers_Ljava_util_ArrayList_);
			return cb_GetSelectedLocalSpeakers_Ljava_util_ArrayList_;
		}

		static void n_GetSelectedLocalSpeakers_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSelectedLocalSpeakers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetSelectedLocalSpeakers_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetSelectedLocalSpeakers' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoLocalSpeaker&gt;']]"
		[Register ("GetSelectedLocalSpeakers", "(Ljava/util/ArrayList;)V", "GetGetSelectedLocalSpeakers_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void GetSelectedLocalSpeakers (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> p0)
		{
			if (id_GetSelectedLocalSpeakers_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetSelectedLocalSpeakers_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetSelectedLocalSpeakers", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_GetSelectedLocalSpeakers_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSelectedLocalSpeakers", "(Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetSelectedLocalWindowShares_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetSelectedLocalWindowShares_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetSelectedLocalWindowShares_Ljava_util_ArrayList_ == null)
				cb_GetSelectedLocalWindowShares_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSelectedLocalWindowShares_Ljava_util_ArrayList_);
			return cb_GetSelectedLocalWindowShares_Ljava_util_ArrayList_;
		}

		static void n_GetSelectedLocalWindowShares_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSelectedLocalWindowShares (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetSelectedLocalWindowShares_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetSelectedLocalWindowShares' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoLocalWindowShare&gt;']]"
		[Register ("GetSelectedLocalWindowShares", "(Ljava/util/ArrayList;)V", "GetGetSelectedLocalWindowShares_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void GetSelectedLocalWindowShares (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> p0)
		{
			if (id_GetSelectedLocalWindowShares_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetSelectedLocalWindowShares_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetSelectedLocalWindowShares", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_GetSelectedLocalWindowShares_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSelectedLocalWindowShares", "(Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_;
#pragma warning disable 0169
		static Delegate GetGetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_Handler ()
		{
			if (cb_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_ == null)
				cb_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_);
			return cb_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_;
		}

		static bool n_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Stats.VidyoRoomStats p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Stats.VidyoRoomStats> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetStats (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='GetStats' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Stats.VidyoRoomStats']]"
		[Register ("GetStats", "(Lcom/vidyo/VidyoClient/Stats/VidyoRoomStats;)Z", "GetGetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_Handler")]
		public virtual unsafe bool GetStats (global::Com.Vidyo.VidyoClient.Stats.VidyoRoomStats p0)
		{
			if (id_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_ == IntPtr.Zero)
				id_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_ = JNIEnv.GetMethodID (class_ref, "GetStats", "(Lcom/vidyo/VidyoClient/Stats/VidyoRoomStats;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoRoomStats_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetStats", "(Lcom/vidyo/VidyoClient/Stats/VidyoRoomStats;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_HideStatisticsDialog;
#pragma warning disable 0169
		static Delegate GetHideStatisticsDialogHandler ()
		{
			if (cb_HideStatisticsDialog == null)
				cb_HideStatisticsDialog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideStatisticsDialog);
			return cb_HideStatisticsDialog;
		}

		static void n_HideStatisticsDialog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideStatisticsDialog ();
		}
#pragma warning restore 0169

		static IntPtr id_HideStatisticsDialog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='HideStatisticsDialog' and count(parameter)=0]"
		[Register ("HideStatisticsDialog", "()V", "GetHideStatisticsDialogHandler")]
		public virtual unsafe void HideStatisticsDialog ()
		{
			if (id_HideStatisticsDialog == IntPtr.Zero)
				id_HideStatisticsDialog = JNIEnv.GetMethodID (class_ref, "HideStatisticsDialog", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_HideStatisticsDialog);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "HideStatisticsDialog", "()V"));
			} finally {
			}
		}

		static Delegate cb_Invite_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvite_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_Invite_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_Invite_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Invite_Ljava_lang_String_Ljava_lang_String_);
			return cb_Invite_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Invite_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Invite (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Invite_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='Invite' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Invite", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetInvite_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool Invite (string p0, string p1)
		{
			if (id_Invite_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Invite_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Invite", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Invite_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Invite", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_InviteAll_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInviteAll_Ljava_lang_String_Handler ()
		{
			if (cb_InviteAll_Ljava_lang_String_ == null)
				cb_InviteAll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InviteAll_Ljava_lang_String_);
			return cb_InviteAll_Ljava_lang_String_;
		}

		static bool n_InviteAll_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InviteAll (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_InviteAll_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='InviteAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("InviteAll", "(Ljava/lang/String;)Z", "GetInviteAll_Ljava_lang_String_Handler")]
		public virtual unsafe bool InviteAll (string p0)
		{
			if (id_InviteAll_Ljava_lang_String_ == IntPtr.Zero)
				id_InviteAll_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "InviteAll", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_InviteAll_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "InviteAll", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_InviteN_Ljava_util_ArrayList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInviteN_Ljava_util_ArrayList_Ljava_lang_String_Handler ()
		{
			if (cb_InviteN_Ljava_util_ArrayList_Ljava_lang_String_ == null)
				cb_InviteN_Ljava_util_ArrayList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_InviteN_Ljava_util_ArrayList_Ljava_lang_String_);
			return cb_InviteN_Ljava_util_ArrayList_Ljava_lang_String_;
		}

		static bool n_InviteN_Ljava_util_ArrayList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InviteN (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_InviteN_Ljava_util_ArrayList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='InviteN' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("InviteN", "(Ljava/util/ArrayList;Ljava/lang/String;)Z", "GetInviteN_Ljava_util_ArrayList_Ljava_lang_String_Handler")]
		public virtual unsafe bool InviteN (global::System.Collections.Generic.IList<string> p0, string p1)
		{
			if (id_InviteN_Ljava_util_ArrayList_Ljava_lang_String_ == IntPtr.Zero)
				id_InviteN_Ljava_util_ArrayList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "InviteN", "(Ljava/util/ArrayList;Ljava/lang/String;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_InviteN_Ljava_util_ArrayList_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "InviteN", "(Ljava/util/ArrayList;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_Leave;
#pragma warning disable 0169
		static Delegate GetLeaveHandler ()
		{
			if (cb_Leave == null)
				cb_Leave = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Leave);
			return cb_Leave;
		}

		static bool n_Leave (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Leave ();
		}
#pragma warning restore 0169

		static IntPtr id_Leave;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='Leave' and count(parameter)=0]"
		[Register ("Leave", "()Z", "GetLeaveHandler")]
		public virtual unsafe bool Leave ()
		{
			if (id_Leave == IntPtr.Zero)
				id_Leave = JNIEnv.GetMethodID (class_ref, "Leave", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Leave);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Leave", "()Z"));
			} finally {
			}
		}

		static Delegate cb_MessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_;
#pragma warning disable 0169
		static Delegate GetMessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_Handler ()
		{
			if (cb_MessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_ == null)
				cb_MessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_MessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_);
			return cb_MessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_;
		}

		static bool n_MessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IMessageSearch p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IMessageSearch)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IMessageSearch> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MessageSearch (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_MessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='MessageSearch' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IMessageSearch']]"
		[Register ("MessageSearch", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IMessageSearch;)Z", "GetMessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_Handler")]
		public virtual unsafe bool MessageSearch (string p0, int p1, int p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IMessageSearch p3)
		{
			if (id_MessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_ == IntPtr.Zero)
				id_MessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_ = JNIEnv.GetMethodID (class_ref, "MessageSearch", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IMessageSearch;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_MessageSearch_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IMessageSearch_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "MessageSearch", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IMessageSearch;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_OnAvailableResourcesChanged_IIII;
#pragma warning disable 0169
		static Delegate GetOnAvailableResourcesChanged_IIIIHandler ()
		{
			if (cb_OnAvailableResourcesChanged_IIII == null)
				cb_OnAvailableResourcesChanged_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_OnAvailableResourcesChanged_IIII);
			return cb_OnAvailableResourcesChanged_IIII;
		}

		static void n_OnAvailableResourcesChanged_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAvailableResourcesChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_OnAvailableResourcesChanged_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnAvailableResourcesChanged' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("OnAvailableResourcesChanged", "(IIII)V", "GetOnAvailableResourcesChanged_IIIIHandler")]
		public virtual unsafe void OnAvailableResourcesChanged (int p0, int p1, int p2, int p3)
		{
			if (id_OnAvailableResourcesChanged_IIII == IntPtr.Zero)
				id_OnAvailableResourcesChanged_IIII = JNIEnv.GetMethodID (class_ref, "OnAvailableResourcesChanged", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnAvailableResourcesChanged_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnAvailableResourcesChanged", "(IIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_;
#pragma warning disable 0169
		static Delegate GetOnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_Handler ()
		{
			if (cb_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_ == null)
				cb_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_);
			return cb_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_;
		}

		static void n_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDeleteResult (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnDeleteResult' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult']]"
		[Register ("OnDeleteResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;)V", "GetOnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_Handler")]
		public virtual unsafe void OnDeleteResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomDeleteResult p0)
		{
			if (id_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_ == IntPtr.Zero)
				id_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_ = JNIEnv.GetMethodID (class_ref, "OnDeleteResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDeleteResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomDeleteResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnDeleteResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomDeleteResult;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetOnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
		{
			if (cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
				cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_);
			return cb_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		}

		static void n_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDynamicParticipantChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnDynamicParticipantChanged' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoParticipant&gt;'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoRemoteCamera&gt;']]"
		[Register ("OnDynamicParticipantChanged", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", "GetOnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void OnDynamicParticipantChanged (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera> p1)
		{
			if (id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "OnDynamicParticipantChanged", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteCamera>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnDynamicParticipantChanged", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_;
#pragma warning disable 0169
		static Delegate GetOnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_Handler ()
		{
			if (cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ == null)
				cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_);
			return cb_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_;
		}

		static void n_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEntered (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnEntered' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult']]"
		[Register ("OnEntered", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;)V", "GetOnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_Handler")]
		public virtual unsafe void OnEntered (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomEnterResult p0)
		{
			if (id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ == IntPtr.Zero)
				id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_ = JNIEnv.GetMethodID (class_ref, "OnEntered", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnEntered_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomEnterResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnEntered", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomEnterResult;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_;
#pragma warning disable 0169
		static Delegate GetOnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_Handler ()
		{
			if (cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ == null)
				cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_);
			return cb_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_;
		}

		static void n_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnExited (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnExited' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason']]"
		[Register ("OnExited", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;)V", "GetOnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_Handler")]
		public virtual unsafe void OnExited (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomExitReason p0)
		{
			if (id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ == IntPtr.Zero)
				id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_ = JNIEnv.GetMethodID (class_ref, "OnExited", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnExited_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomExitReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnExited", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomExitReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
#pragma warning disable 0169
		static Delegate GetOnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler ()
		{
			if (cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == null)
				cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_);
			return cb_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
		}

		static void n_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnGetHistoryResults (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnGetHistoryResults' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoChatMessage&gt;'] and parameter[2][@type='long'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult']]"
		[Register ("OnGetHistoryResults", "(Ljava/util/ArrayList;JLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V", "GetOnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler")]
		public virtual unsafe void OnGetHistoryResults (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> p0, long p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2)
		{
			if (id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == IntPtr.Zero)
				id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNIEnv.GetMethodID (class_ref, "OnGetHistoryResults", "(Ljava/util/ArrayList;JLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnGetHistoryResults_Ljava_util_ArrayList_JLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnGetHistoryResults", "(Ljava/util/ArrayList;JLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
#pragma warning disable 0169
		static Delegate GetOnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Handler ()
		{
			if (cb_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ == null)
				cb_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_);
			return cb_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
		}

		static void n_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGetRoomPropertiesResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnGetRoomPropertiesResult' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties']]"
		[Register ("OnGetRoomPropertiesResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V", "GetOnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Handler")]
		public virtual unsafe void OnGetRoomPropertiesResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomGetPropertiesResult p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p1)
		{
			if (id_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ == IntPtr.Zero)
				id_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ = JNIEnv.GetMethodID (class_ref, "OnGetRoomPropertiesResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnGetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomGetPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnGetRoomPropertiesResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomGetPropertiesResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
#pragma warning disable 0169
		static Delegate GetOnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ZHandler ()
		{
			if (cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z == null)
				cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z);
			return cb_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
		}

		static void n_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoudestParticipantChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnLoudestParticipantChanged' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='boolean']]"
		[Register ("OnLoudestParticipantChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V", "GetOnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ZHandler")]
		public virtual unsafe void OnLoudestParticipantChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, bool p1)
		{
			if (id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z == IntPtr.Zero)
				id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z = JNIEnv.GetMethodID (class_ref, "OnLoudestParticipantChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLoudestParticipantChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnMaxRemoteSourcesChanged_I;
#pragma warning disable 0169
		static Delegate GetOnMaxRemoteSourcesChanged_IHandler ()
		{
			if (cb_OnMaxRemoteSourcesChanged_I == null)
				cb_OnMaxRemoteSourcesChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnMaxRemoteSourcesChanged_I);
			return cb_OnMaxRemoteSourcesChanged_I;
		}

		static void n_OnMaxRemoteSourcesChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMaxRemoteSourcesChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnMaxRemoteSourcesChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnMaxRemoteSourcesChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("OnMaxRemoteSourcesChanged", "(I)V", "GetOnMaxRemoteSourcesChanged_IHandler")]
		public virtual unsafe void OnMaxRemoteSourcesChanged (int p0)
		{
			if (id_OnMaxRemoteSourcesChanged_I == IntPtr.Zero)
				id_OnMaxRemoteSourcesChanged_I = JNIEnv.GetMethodID (class_ref, "OnMaxRemoteSourcesChanged", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMaxRemoteSourcesChanged_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMaxRemoteSourcesChanged", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_;
#pragma warning disable 0169
		static Delegate GetOnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_Handler ()
		{
			if (cb_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_ == null)
				cb_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_);
			return cb_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_;
		}

		static void n_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaDisabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnMediaDisabled' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason']]"
		[Register ("OnMediaDisabled", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;)V", "GetOnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_Handler")]
		public virtual unsafe void OnMediaDisabled (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaDisableReason p0)
		{
			if (id_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_ == IntPtr.Zero)
				id_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_ = JNIEnv.GetMethodID (class_ref, "OnMediaDisabled", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaDisabled_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaDisableReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMediaDisabled", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaDisableReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnMediaEnabled;
#pragma warning disable 0169
		static Delegate GetOnMediaEnabledHandler ()
		{
			if (cb_OnMediaEnabled == null)
				cb_OnMediaEnabled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMediaEnabled);
			return cb_OnMediaEnabled;
		}

		static void n_OnMediaEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaEnabled ();
		}
#pragma warning restore 0169

		static IntPtr id_OnMediaEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnMediaEnabled' and count(parameter)=0]"
		[Register ("OnMediaEnabled", "()V", "GetOnMediaEnabledHandler")]
		public virtual unsafe void OnMediaEnabled ()
		{
			if (id_OnMediaEnabled == IntPtr.Zero)
				id_OnMediaEnabled = JNIEnv.GetMethodID (class_ref, "OnMediaEnabled", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaEnabled);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMediaEnabled", "()V"));
			} finally {
			}
		}

		static Delegate cb_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_;
#pragma warning disable 0169
		static Delegate GetOnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_Handler ()
		{
			if (cb_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_ == null)
				cb_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_);
			return cb_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_;
		}

		static void n_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnMediaFailed' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason']]"
		[Register ("OnMediaFailed", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;)V", "GetOnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_Handler")]
		public virtual unsafe void OnMediaFailed (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomMediaFailReason p0)
		{
			if (id_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_ == IntPtr.Zero)
				id_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_ = JNIEnv.GetMethodID (class_ref, "OnMediaFailed", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaFailed_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomMediaFailReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMediaFailed", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomMediaFailReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnMediaRouteAcquired;
#pragma warning disable 0169
		static Delegate GetOnMediaRouteAcquiredHandler ()
		{
			if (cb_OnMediaRouteAcquired == null)
				cb_OnMediaRouteAcquired = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMediaRouteAcquired);
			return cb_OnMediaRouteAcquired;
		}

		static void n_OnMediaRouteAcquired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaRouteAcquired ();
		}
#pragma warning restore 0169

		static IntPtr id_OnMediaRouteAcquired;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnMediaRouteAcquired' and count(parameter)=0]"
		[Register ("OnMediaRouteAcquired", "()V", "GetOnMediaRouteAcquiredHandler")]
		public virtual unsafe void OnMediaRouteAcquired ()
		{
			if (id_OnMediaRouteAcquired == IntPtr.Zero)
				id_OnMediaRouteAcquired = JNIEnv.GetMethodID (class_ref, "OnMediaRouteAcquired", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaRouteAcquired);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMediaRouteAcquired", "()V"));
			} finally {
			}
		}

		static Delegate cb_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
#pragma warning disable 0169
		static Delegate GetOnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler ()
		{
			if (cb_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == null)
				cb_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_);
			return cb_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
		}

		static void n_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageAcknowledged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnMessageAcknowledged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage']]"
		[Register ("OnMessageAcknowledged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V", "GetOnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler")]
		public virtual unsafe void OnMessageAcknowledged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p0)
		{
			if (id_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == IntPtr.Zero)
				id_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNIEnv.GetMethodID (class_ref, "OnMessageAcknowledged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMessageAcknowledged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J;
#pragma warning disable 0169
		static Delegate GetOnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_JHandler ()
		{
			if (cb_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J == null)
				cb_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J);
			return cb_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J;
		}

		static void n_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageRead (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnMessageRead' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='long']]"
		[Register ("OnMessageRead", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;J)V", "GetOnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_JHandler")]
		public virtual unsafe void OnMessageRead (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, long p1)
		{
			if (id_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J == IntPtr.Zero)
				id_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J = JNIEnv.GetMethodID (class_ref, "OnMessageRead", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMessageRead", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
#pragma warning disable 0169
		static Delegate GetOnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler ()
		{
			if (cb_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == null)
				cb_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_);
			return cb_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
		}

		static void n_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageReceived (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnMessageReceived' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage']]"
		[Register ("OnMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V", "GetOnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler")]
		public virtual unsafe void OnMessageReceived (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1)
		{
			if (id_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ == IntPtr.Zero)
				id_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_ = JNIEnv.GetMethodID (class_ref, "OnMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
#pragma warning disable 0169
		static Delegate GetOnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler ()
		{
			if (cb_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == null)
				cb_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_);
			return cb_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
		}

		static void n_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageSearchResults (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnMessageSearchResults' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoChatMessage&gt;'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult']]"
		[Register ("OnMessageSearchResults", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V", "GetOnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_Handler")]
		public virtual unsafe void OnMessageSearchResults (string p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSearchResult p2)
		{
			if (id_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ == IntPtr.Zero)
				id_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_ = JNIEnv.GetMethodID (class_ref, "OnMessageSearchResults", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMessageSearchResults_Ljava_lang_String_Ljava_util_ArrayList_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSearchResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMessageSearchResults", "(Ljava/lang/String;Ljava/util/ArrayList;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSearchResult;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_;
#pragma warning disable 0169
		static Delegate GetOnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_Handler ()
		{
			if (cb_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ == null)
				cb_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_);
			return cb_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_;
		}

		static void n_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageTypingIndication (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnMessageTypingIndication' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication']]"
		[Register ("OnMessageTypingIndication", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;)V", "GetOnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_Handler")]
		public virtual unsafe void OnMessageTypingIndication (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1)
		{
			if (id_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ == IntPtr.Zero)
				id_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ = JNIEnv.GetMethodID (class_ref, "OnMessageTypingIndication", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMessageTypingIndication", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnParticipantJoined (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnParticipantJoined' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnParticipantJoined", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnParticipantJoined (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
		{
			if (id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnParticipantJoined", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnParticipantJoined", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnParticipantLeft (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnParticipantLeft' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnParticipantLeft", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnParticipantLeft (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
		{
			if (id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnParticipantLeft", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnParticipantLeft", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
#pragma warning disable 0169
		static Delegate GetOnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Handler ()
		{
			if (cb_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ == null)
				cb_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_);
			return cb_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
		}

		static void n_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRoomPropertiesChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnRoomPropertiesChanged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties']]"
		[Register ("OnRoomPropertiesChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V", "GetOnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Handler")]
		public virtual unsafe void OnRoomPropertiesChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0)
		{
			if (id_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ == IntPtr.Zero)
				id_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_ = JNIEnv.GetMethodID (class_ref, "OnRoomPropertiesChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRoomPropertiesChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_;
#pragma warning disable 0169
		static Delegate GetOnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_Handler ()
		{
			if (cb_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_ == null)
				cb_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_);
			return cb_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_;
		}

		static void n_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSetFavoriteResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnSetFavoriteResult' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult']]"
		[Register ("OnSetFavoriteResult", "(ZLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;)V", "GetOnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_Handler")]
		public virtual unsafe void OnSetFavoriteResult (bool p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetFavoriteResult p1)
		{
			if (id_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_ == IntPtr.Zero)
				id_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_ = JNIEnv.GetMethodID (class_ref, "OnSetFavoriteResult", "(ZLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnSetFavoriteResult_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetFavoriteResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnSetFavoriteResult", "(ZLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetFavoriteResult;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_;
#pragma warning disable 0169
		static Delegate GetOnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_Handler ()
		{
			if (cb_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_ == null)
				cb_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_);
			return cb_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_;
		}

		static void n_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSetRoomPropertiesResult (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnSetRoomPropertiesResult' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult']]"
		[Register ("OnSetRoomPropertiesResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;)V", "GetOnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_Handler")]
		public virtual unsafe void OnSetRoomPropertiesResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomSetPropertiesResult p0)
		{
			if (id_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_ == IntPtr.Zero)
				id_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_ = JNIEnv.GetMethodID (class_ref, "OnSetRoomPropertiesResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnSetRoomPropertiesResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomSetPropertiesResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnSetRoomPropertiesResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomSetPropertiesResult;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnSetSubject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSetSubject_Ljava_lang_String_Handler ()
		{
			if (cb_OnSetSubject_Ljava_lang_String_ == null)
				cb_OnSetSubject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetSubject_Ljava_lang_String_);
			return cb_OnSetSubject_Ljava_lang_String_;
		}

		static void n_OnSetSubject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSetSubject (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnSetSubject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='OnSetSubject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("OnSetSubject", "(Ljava/lang/String;)V", "GetOnSetSubject_Ljava_lang_String_Handler")]
		public virtual unsafe void OnSetSubject (string p0)
		{
			if (id_OnSetSubject_Ljava_lang_String_ == IntPtr.Zero)
				id_OnSetSubject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnSetSubject", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnSetSubject_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnSetSubject", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_RecorderInCall_Z;
#pragma warning disable 0169
		static Delegate GetRecorderInCall_ZHandler ()
		{
			if (cb_RecorderInCall_Z == null)
				cb_RecorderInCall_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_RecorderInCall_Z);
			return cb_RecorderInCall_Z;
		}

		static void n_RecorderInCall_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecorderInCall (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RecorderInCall_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RecorderInCall' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("RecorderInCall", "(Z)V", "GetRecorderInCall_ZHandler")]
		public virtual unsafe void RecorderInCall (bool p0)
		{
			if (id_RecorderInCall_Z == IntPtr.Zero)
				id_RecorderInCall_Z = JNIEnv.GetMethodID (class_ref, "RecorderInCall", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RecorderInCall_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RecorderInCall", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_Handler ()
		{
			if (cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_ == null)
				cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_);
			return cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_;
		}

		static bool n_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterMessageEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RegisterMessageEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener']]"
		[Register ("RegisterMessageEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterMessageEventListener;)Z", "GetRegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_Handler")]
		public virtual unsafe bool RegisterMessageEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener p0)
		{
			if (id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_ == IntPtr.Zero)
				id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterMessageEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterMessageEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterMessageEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterMessageEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterMessageEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_Handler ()
		{
			if (cb_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_ == null)
				cb_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_);
			return cb_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_;
		}

		static bool n_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterParticipantEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RegisterParticipantEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener']]"
		[Register ("RegisterParticipantEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterParticipantEventListener;)Z", "GetRegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_Handler")]
		public virtual unsafe bool RegisterParticipantEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener p0)
		{
			if (id_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_ == IntPtr.Zero)
				id_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterParticipantEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterParticipantEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterParticipantEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterParticipantEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterParticipantEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterParticipantEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_Handler ()
		{
			if (cb_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_ == null)
				cb_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_);
			return cb_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_;
		}

		static bool n_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRecoderInCallEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRecoderInCallEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRecoderInCallEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRecoderInCallEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RegisterRecoderInCallEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRecoderInCallEventListener']]"
		[Register ("RegisterRecoderInCallEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRecoderInCallEventListener;)Z", "GetRegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_Handler")]
		public virtual unsafe bool RegisterRecoderInCallEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRecoderInCallEventListener p0)
		{
			if (id_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_ == IntPtr.Zero)
				id_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRecoderInCallEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRecoderInCallEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRecoderInCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRecoderInCallEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRecoderInCallEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRecoderInCallEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_Handler ()
		{
			if (cb_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_ == null)
				cb_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_);
			return cb_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_;
		}

		static bool n_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterResourceManagerEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterResourceManagerEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterResourceManagerEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterResourceManagerEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RegisterResourceManagerEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterResourceManagerEventListener']]"
		[Register ("RegisterResourceManagerEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterResourceManagerEventListener;)Z", "GetRegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_Handler")]
		public virtual unsafe bool RegisterResourceManagerEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterResourceManagerEventListener p0)
		{
			if (id_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_ == IntPtr.Zero)
				id_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterResourceManagerEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterResourceManagerEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterResourceManagerEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterResourceManagerEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterResourceManagerEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterResourceManagerEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_Handler ()
		{
			if (cb_RegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_ == null)
				cb_RegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_);
			return cb_RegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_;
		}

		static bool n_RegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRoomPropertiesEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRoomPropertiesEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRoomPropertiesEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRoomPropertiesEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RegisterRoomPropertiesEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRoomPropertiesEventListener']]"
		[Register ("RegisterRoomPropertiesEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRoomPropertiesEventListener;)Z", "GetRegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_Handler")]
		public virtual unsafe bool RegisterRoomPropertiesEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRoomPropertiesEventListener p0)
		{
			if (id_RegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_ == IntPtr.Zero)
				id_RegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRoomPropertiesEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRoomPropertiesEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRoomPropertiesEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterRoomPropertiesEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRoomPropertiesEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterRoomPropertiesEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_Handler ()
		{
			if (cb_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_ == null)
				cb_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_);
			return cb_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_;
		}

		static bool n_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterSubjectEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterSubjectEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterSubjectEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterSubjectEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RegisterSubjectEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterSubjectEventListener']]"
		[Register ("RegisterSubjectEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterSubjectEventListener;)Z", "GetRegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_Handler")]
		public virtual unsafe bool RegisterSubjectEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterSubjectEventListener p0)
		{
			if (id_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_ == IntPtr.Zero)
				id_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterSubjectEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterSubjectEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_IRegisterSubjectEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterSubjectEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$IRegisterSubjectEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RejectIncoming;
#pragma warning disable 0169
		static Delegate GetRejectIncomingHandler ()
		{
			if (cb_RejectIncoming == null)
				cb_RejectIncoming = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RejectIncoming);
			return cb_RejectIncoming;
		}

		static bool n_RejectIncoming (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RejectIncoming ();
		}
#pragma warning restore 0169

		static IntPtr id_RejectIncoming;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RejectIncoming' and count(parameter)=0]"
		[Register ("RejectIncoming", "()Z", "GetRejectIncomingHandler")]
		public virtual unsafe bool RejectIncoming ()
		{
			if (id_RejectIncoming == IntPtr.Zero)
				id_RejectIncoming = JNIEnv.GetMethodID (class_ref, "RejectIncoming", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RejectIncoming);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RejectIncoming", "()Z"));
			} finally {
			}
		}

		static Delegate cb_RemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
#pragma warning disable 0169
		static Delegate GetRemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler ()
		{
			if (cb_RemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == null)
				cb_RemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_);
			return cb_RemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		}

		static void n_RemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocalCamera (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RemoveLocalCamera' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalCamera']]"
		[Register ("RemoveLocalCamera", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V", "GetRemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler")]
		public virtual unsafe void RemoveLocalCamera (global::Com.Vidyo.VidyoClient.Device.VidyoLocalCamera p0)
		{
			if (id_RemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ == IntPtr.Zero)
				id_RemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_ = JNIEnv.GetMethodID (class_ref, "RemoveLocalCamera", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RemoveLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveLocalCamera", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_RemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
#pragma warning disable 0169
		static Delegate GetRemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler ()
		{
			if (cb_RemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == null)
				cb_RemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_);
			return cb_RemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		}

		static void n_RemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocalMicrophone (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RemoveLocalMicrophone' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMicrophone']]"
		[Register ("RemoveLocalMicrophone", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V", "GetRemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler")]
		public virtual unsafe void RemoveLocalMicrophone (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
		{
			if (id_RemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ == IntPtr.Zero)
				id_RemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_ = JNIEnv.GetMethodID (class_ref, "RemoveLocalMicrophone", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RemoveLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveLocalMicrophone", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_RemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
#pragma warning disable 0169
		static Delegate GetRemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler ()
		{
			if (cb_RemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == null)
				cb_RemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_);
			return cb_RemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		}

		static void n_RemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocalMonitor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RemoveLocalMonitor' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalMonitor']]"
		[Register ("RemoveLocalMonitor", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V", "GetRemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler")]
		public virtual unsafe void RemoveLocalMonitor (global::Com.Vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
		{
			if (id_RemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ == IntPtr.Zero)
				id_RemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_ = JNIEnv.GetMethodID (class_ref, "RemoveLocalMonitor", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RemoveLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveLocalMonitor", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_RemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
		static Delegate GetRemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
		{
			if (cb_RemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
				cb_RemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
			return cb_RemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		}

		static void n_RemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocalRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RemoveLocalRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
		[Register ("RemoveLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V", "GetRemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler")]
		public virtual unsafe void RemoveLocalRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
		{
			if (id_RemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
				id_RemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "RemoveLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RemoveLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_RemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
#pragma warning disable 0169
		static Delegate GetRemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler ()
		{
			if (cb_RemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == null)
				cb_RemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_);
			return cb_RemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		}

		static void n_RemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocalSpeaker (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RemoveLocalSpeaker' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalSpeaker']]"
		[Register ("RemoveLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V", "GetRemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler")]
		public virtual unsafe void RemoveLocalSpeaker (global::Com.Vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
		{
			if (id_RemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ == IntPtr.Zero)
				id_RemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_ = JNIEnv.GetMethodID (class_ref, "RemoveLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RemoveLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveLocalSpeaker", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_RemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
#pragma warning disable 0169
		static Delegate GetRemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler ()
		{
			if (cb_RemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == null)
				cb_RemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_);
			return cb_RemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		}

		static void n_RemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocalWindowShare (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='RemoveLocalWindowShare' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalWindowShare']]"
		[Register ("RemoveLocalWindowShare", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V", "GetRemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler")]
		public virtual unsafe void RemoveLocalWindowShare (global::Com.Vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
		{
			if (id_RemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ == IntPtr.Zero)
				id_RemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_ = JNIEnv.GetMethodID (class_ref, "RemoveLocalWindowShare", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RemoveLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveLocalWindowShare", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_SendMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Handler ()
		{
			if (cb_SendMessage_Ljava_lang_String_ == null)
				cb_SendMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendMessage_Ljava_lang_String_);
			return cb_SendMessage_Ljava_lang_String_;
		}

		static bool n_SendMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SendMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SendMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SendMessage", "(Ljava/lang/String;)Z", "GetSendMessage_Ljava_lang_String_Handler")]
		public virtual unsafe bool SendMessage (string p0)
		{
			if (id_SendMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_SendMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SendMessage", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SendMessage_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SendMessage", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SendMessageAcknowledged_J;
#pragma warning disable 0169
		static Delegate GetSendMessageAcknowledged_JHandler ()
		{
			if (cb_SendMessageAcknowledged_J == null)
				cb_SendMessageAcknowledged_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_SendMessageAcknowledged_J);
			return cb_SendMessageAcknowledged_J;
		}

		static bool n_SendMessageAcknowledged_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SendMessageAcknowledged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SendMessageAcknowledged_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SendMessageAcknowledged' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("SendMessageAcknowledged", "(J)Z", "GetSendMessageAcknowledged_JHandler")]
		public virtual unsafe bool SendMessageAcknowledged (long p0)
		{
			if (id_SendMessageAcknowledged_J == IntPtr.Zero)
				id_SendMessageAcknowledged_J = JNIEnv.GetMethodID (class_ref, "SendMessageAcknowledged", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SendMessageAcknowledged_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SendMessageAcknowledged", "(J)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_;
#pragma warning disable 0169
		static Delegate GetSendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_Handler ()
		{
			if (cb_SendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ == null)
				cb_SendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_);
			return cb_SendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_;
		}

		static bool n_SendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendMessageTypingIndication (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SendMessageTypingIndication' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication']]"
		[Register ("SendMessageTypingIndication", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;)Z", "GetSendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_Handler")]
		public virtual unsafe bool SendMessageTypingIndication (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p0)
		{
			if (id_SendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ == IntPtr.Zero)
				id_SendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_ = JNIEnv.GetMethodID (class_ref, "SendMessageTypingIndication", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SendMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SendMessageTypingIndication", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetDynamicGenerationPosition_IIIIIJ;
#pragma warning disable 0169
		static Delegate GetSetDynamicGenerationPosition_IIIIIJHandler ()
		{
			if (cb_SetDynamicGenerationPosition_IIIIIJ == null)
				cb_SetDynamicGenerationPosition_IIIIIJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, long, bool>) n_SetDynamicGenerationPosition_IIIIIJ);
			return cb_SetDynamicGenerationPosition_IIIIIJ;
		}

		static bool n_SetDynamicGenerationPosition_IIIIIJ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, long p5)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetDynamicGenerationPosition (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_SetDynamicGenerationPosition_IIIIIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SetDynamicGenerationPosition' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='long']]"
		[Register ("SetDynamicGenerationPosition", "(IIIIIJ)Z", "GetSetDynamicGenerationPosition_IIIIIJHandler")]
		public virtual unsafe bool SetDynamicGenerationPosition (int p0, int p1, int p2, int p3, int p4, long p5)
		{
			if (id_SetDynamicGenerationPosition_IIIIIJ == IntPtr.Zero)
				id_SetDynamicGenerationPosition_IIIIIJ = JNIEnv.GetMethodID (class_ref, "SetDynamicGenerationPosition", "(IIIIIJ)Z");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetDynamicGenerationPosition_IIIIIJ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetDynamicGenerationPosition", "(IIIIIJ)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
#pragma warning disable 0169
		static Delegate GetSetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler ()
		{
			if (cb_SetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == null)
				cb_SetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_);
			return cb_SetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		}

		static bool n_SetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetDynamicLocalRenderer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SetDynamicLocalRenderer' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Device.VidyoLocalRenderer']]"
		[Register ("SetDynamicLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)Z", "GetSetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler")]
		public virtual unsafe bool SetDynamicLocalRenderer (global::Com.Vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
		{
			if (id_SetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ == IntPtr.Zero)
				id_SetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_ = JNIEnv.GetMethodID (class_ref, "SetDynamicLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetDynamicLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetDynamicLocalRenderer", "(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_;
#pragma warning disable 0169
		static Delegate GetSetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_Handler ()
		{
			if (cb_SetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_ == null)
				cb_SetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_);
			return cb_SetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_;
		}

		static void n_SetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetFavorite p1 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetFavorite)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetFavorite> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFavorite (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_SetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SetFavorite' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.ISetFavorite']]"
		[Register ("SetFavorite", "(ZLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetFavorite;)V", "GetSetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_Handler")]
		public virtual unsafe void SetFavorite (bool p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetFavorite p1)
		{
			if (id_SetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_ == IntPtr.Zero)
				id_SetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_ = JNIEnv.GetMethodID (class_ref, "SetFavorite", "(ZLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetFavorite;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetFavorite_ZLcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetFavorite_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetFavorite", "(ZLcom/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetFavorite;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_SetMaxAudioSources_I;
#pragma warning disable 0169
		static Delegate GetSetMaxAudioSources_IHandler ()
		{
			if (cb_SetMaxAudioSources_I == null)
				cb_SetMaxAudioSources_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetMaxAudioSources_I);
			return cb_SetMaxAudioSources_I;
		}

		static bool n_SetMaxAudioSources_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetMaxAudioSources (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetMaxAudioSources_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SetMaxAudioSources' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetMaxAudioSources", "(I)Z", "GetSetMaxAudioSources_IHandler")]
		public virtual unsafe bool SetMaxAudioSources (int p0)
		{
			if (id_SetMaxAudioSources_I == IntPtr.Zero)
				id_SetMaxAudioSources_I = JNIEnv.GetMethodID (class_ref, "SetMaxAudioSources", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetMaxAudioSources_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMaxAudioSources", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetMaxVideoSources_I;
#pragma warning disable 0169
		static Delegate GetSetMaxVideoSources_IHandler ()
		{
			if (cb_SetMaxVideoSources_I == null)
				cb_SetMaxVideoSources_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetMaxVideoSources_I);
			return cb_SetMaxVideoSources_I;
		}

		static bool n_SetMaxVideoSources_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetMaxVideoSources (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetMaxVideoSources_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SetMaxVideoSources' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetMaxVideoSources", "(I)Z", "GetSetMaxVideoSources_IHandler")]
		public virtual unsafe bool SetMaxVideoSources (int p0)
		{
			if (id_SetMaxVideoSources_I == IntPtr.Zero)
				id_SetMaxVideoSources_I = JNIEnv.GetMethodID (class_ref, "SetMaxVideoSources", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetMaxVideoSources_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMaxVideoSources", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_;
#pragma warning disable 0169
		static Delegate GetSetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_Handler ()
		{
			if (cb_SetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_ == null)
				cb_SetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_);
			return cb_SetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_;
		}

		static bool n_SetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetRoomProperties p1 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetRoomProperties)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetRoomProperties> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetRoomProperties (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SetRoomProperties' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom.ISetRoomProperties']]"
		[Register ("SetRoomProperties", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetRoomProperties;)Z", "GetSetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_Handler")]
		public virtual unsafe bool SetRoomProperties (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom.ISetRoomProperties p1)
		{
			if (id_SetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_ == IntPtr.Zero)
				id_SetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_ = JNIEnv.GetMethodID (class_ref, "SetRoomProperties", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetRoomProperties;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_ISetRoomProperties_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetRoomProperties", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$ISetRoomProperties;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetSubject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubject_Ljava_lang_String_Handler ()
		{
			if (cb_SetSubject_Ljava_lang_String_ == null)
				cb_SetSubject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetSubject_Ljava_lang_String_);
			return cb_SetSubject_Ljava_lang_String_;
		}

		static bool n_SetSubject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSubject (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetSubject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='SetSubject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetSubject", "(Ljava/lang/String;)Z", "GetSetSubject_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetSubject (string p0)
		{
			if (id_SetSubject_Ljava_lang_String_ == IntPtr.Zero)
				id_SetSubject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetSubject", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetSubject_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSubject", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_ShowStatisticsDialog;
#pragma warning disable 0169
		static Delegate GetShowStatisticsDialogHandler ()
		{
			if (cb_ShowStatisticsDialog == null)
				cb_ShowStatisticsDialog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowStatisticsDialog);
			return cb_ShowStatisticsDialog;
		}

		static void n_ShowStatisticsDialog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowStatisticsDialog ();
		}
#pragma warning restore 0169

		static IntPtr id_ShowStatisticsDialog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='ShowStatisticsDialog' and count(parameter)=0]"
		[Register ("ShowStatisticsDialog", "()V", "GetShowStatisticsDialogHandler")]
		public virtual unsafe void ShowStatisticsDialog ()
		{
			if (id_ShowStatisticsDialog == IntPtr.Zero)
				id_ShowStatisticsDialog = JNIEnv.GetMethodID (class_ref, "ShowStatisticsDialog", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ShowStatisticsDialog);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowStatisticsDialog", "()V"));
			} finally {
			}
		}

		static Delegate cb_UnregisterMessageEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterMessageEventListenerHandler ()
		{
			if (cb_UnregisterMessageEventListener == null)
				cb_UnregisterMessageEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterMessageEventListener);
			return cb_UnregisterMessageEventListener;
		}

		static bool n_UnregisterMessageEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterMessageEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterMessageEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='UnregisterMessageEventListener' and count(parameter)=0]"
		[Register ("UnregisterMessageEventListener", "()Z", "GetUnregisterMessageEventListenerHandler")]
		public virtual unsafe bool UnregisterMessageEventListener ()
		{
			if (id_UnregisterMessageEventListener == IntPtr.Zero)
				id_UnregisterMessageEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterMessageEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterMessageEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterMessageEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterParticipantEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterParticipantEventListenerHandler ()
		{
			if (cb_UnregisterParticipantEventListener == null)
				cb_UnregisterParticipantEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterParticipantEventListener);
			return cb_UnregisterParticipantEventListener;
		}

		static bool n_UnregisterParticipantEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterParticipantEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterParticipantEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='UnregisterParticipantEventListener' and count(parameter)=0]"
		[Register ("UnregisterParticipantEventListener", "()Z", "GetUnregisterParticipantEventListenerHandler")]
		public virtual unsafe bool UnregisterParticipantEventListener ()
		{
			if (id_UnregisterParticipantEventListener == IntPtr.Zero)
				id_UnregisterParticipantEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterParticipantEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterParticipantEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterParticipantEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterRecoderInCallEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterRecoderInCallEventListenerHandler ()
		{
			if (cb_UnregisterRecoderInCallEventListener == null)
				cb_UnregisterRecoderInCallEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterRecoderInCallEventListener);
			return cb_UnregisterRecoderInCallEventListener;
		}

		static bool n_UnregisterRecoderInCallEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRecoderInCallEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRecoderInCallEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='UnregisterRecoderInCallEventListener' and count(parameter)=0]"
		[Register ("UnregisterRecoderInCallEventListener", "()Z", "GetUnregisterRecoderInCallEventListenerHandler")]
		public virtual unsafe bool UnregisterRecoderInCallEventListener ()
		{
			if (id_UnregisterRecoderInCallEventListener == IntPtr.Zero)
				id_UnregisterRecoderInCallEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterRecoderInCallEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterRecoderInCallEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterRecoderInCallEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterResourceManagerEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterResourceManagerEventListenerHandler ()
		{
			if (cb_UnregisterResourceManagerEventListener == null)
				cb_UnregisterResourceManagerEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterResourceManagerEventListener);
			return cb_UnregisterResourceManagerEventListener;
		}

		static bool n_UnregisterResourceManagerEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterResourceManagerEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterResourceManagerEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='UnregisterResourceManagerEventListener' and count(parameter)=0]"
		[Register ("UnregisterResourceManagerEventListener", "()Z", "GetUnregisterResourceManagerEventListenerHandler")]
		public virtual unsafe bool UnregisterResourceManagerEventListener ()
		{
			if (id_UnregisterResourceManagerEventListener == IntPtr.Zero)
				id_UnregisterResourceManagerEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterResourceManagerEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterResourceManagerEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterResourceManagerEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterRoomPropertiesEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterRoomPropertiesEventListenerHandler ()
		{
			if (cb_UnregisterRoomPropertiesEventListener == null)
				cb_UnregisterRoomPropertiesEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterRoomPropertiesEventListener);
			return cb_UnregisterRoomPropertiesEventListener;
		}

		static bool n_UnregisterRoomPropertiesEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRoomPropertiesEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRoomPropertiesEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='UnregisterRoomPropertiesEventListener' and count(parameter)=0]"
		[Register ("UnregisterRoomPropertiesEventListener", "()Z", "GetUnregisterRoomPropertiesEventListenerHandler")]
		public virtual unsafe bool UnregisterRoomPropertiesEventListener ()
		{
			if (id_UnregisterRoomPropertiesEventListener == IntPtr.Zero)
				id_UnregisterRoomPropertiesEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterRoomPropertiesEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterRoomPropertiesEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterRoomPropertiesEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterSubjectEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterSubjectEventListenerHandler ()
		{
			if (cb_UnregisterSubjectEventListener == null)
				cb_UnregisterSubjectEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterSubjectEventListener);
			return cb_UnregisterSubjectEventListener;
		}

		static bool n_UnregisterSubjectEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterSubjectEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterSubjectEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='UnregisterSubjectEventListener' and count(parameter)=0]"
		[Register ("UnregisterSubjectEventListener", "()Z", "GetUnregisterSubjectEventListenerHandler")]
		public virtual unsafe bool UnregisterSubjectEventListener ()
		{
			if (id_UnregisterSubjectEventListener == IntPtr.Zero)
				id_UnregisterSubjectEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterSubjectEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterSubjectEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterSubjectEventListener", "()Z"));
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoRoom']/method[@name='dispose' and count(parameter)=0]"
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
