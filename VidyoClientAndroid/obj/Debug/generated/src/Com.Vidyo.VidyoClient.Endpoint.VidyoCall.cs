using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall", DoNotGenerateAcw=true)]
	public partial class VidyoCall : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IAccept']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IAccept", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IAcceptInvoker")]
		public partial interface IAccept : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IAccept']/method[@name='OnEnded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason']]"
			[Register ("OnEnded", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;)V", "GetOnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IAcceptInvoker, VidyoClientAndroid")]
			void OnEnded (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IAccept']/method[@name='OnInitiated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnInitiated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IAcceptInvoker, VidyoClientAndroid")]
			void OnInitiated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IAccept", DoNotGenerateAcw=true)]
		internal class IAcceptInvoker : global::Java.Lang.Object, IAccept {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IAccept");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAcceptInvoker); }
			}

			IntPtr class_ref;

			public static IAccept GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAccept> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoCall.IAccept"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAcceptInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_;
#pragma warning disable 0169
			static Delegate GetOnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_Handler ()
			{
				if (cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ == null)
					cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_);
				return cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_;
			}

			static void n_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnEnded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_;
			public unsafe void OnEnded (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason p1)
			{
				if (id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ == IntPtr.Zero)
					id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ = JNIEnv.GetMethodID (class_ref, "OnEnded", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_, __args);
			}

			static Delegate cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnInitiated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnInitiated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				if (id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnInitiated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IInitiate']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IInitiate", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IInitiateInvoker")]
		public partial interface IInitiate : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IInitiate']/method[@name='OnEnded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason']]"
			[Register ("OnEnded", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;)V", "GetOnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IInitiateInvoker, VidyoClientAndroid")]
			void OnEnded (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IInitiate']/method[@name='OnInitiated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
			[Register ("OnInitiated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IInitiateInvoker, VidyoClientAndroid")]
			void OnInitiated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IInitiate", DoNotGenerateAcw=true)]
		internal class IInitiateInvoker : global::Java.Lang.Object, IInitiate {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IInitiate");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IInitiateInvoker); }
			}

			IntPtr class_ref;

			public static IInitiate GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInitiate> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoCall.IInitiate"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInitiateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_;
#pragma warning disable 0169
			static Delegate GetOnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_Handler ()
			{
				if (cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ == null)
					cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_);
				return cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_;
			}

			static void n_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IInitiate __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IInitiate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnEnded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_;
			public unsafe void OnEnded (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason p1)
			{
				if (id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ == IntPtr.Zero)
					id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ = JNIEnv.GetMethodID (class_ref, "OnEnded", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_, __args);
			}

			static Delegate cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
			static Delegate GetOnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
			{
				if (cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
					cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
				return cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			}

			static void n_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IInitiate __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IInitiate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnInitiated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
			public unsafe void OnInitiated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
			{
				if (id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
					id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnInitiated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IRegisterMessageEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterMessageEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IRegisterMessageEventListenerInvoker")]
		public partial interface IRegisterMessageEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IRegisterMessageEventListener']/method[@name='OnMessageAcknowledged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage']]"
			[Register ("OnMessageAcknowledged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V", "GetOnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IRegisterMessageEventListenerInvoker, VidyoClientAndroid")]
			void OnMessageAcknowledged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IRegisterMessageEventListener']/method[@name='OnMessageRead' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='long']]"
			[Register ("OnMessageRead", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;J)V", "GetOnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IRegisterMessageEventListenerInvoker, VidyoClientAndroid")]
			void OnMessageRead (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, long p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IRegisterMessageEventListener']/method[@name='OnMessageReceived' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage']]"
			[Register ("OnMessageReceived", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V", "GetOnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IRegisterMessageEventListenerInvoker, VidyoClientAndroid")]
			void OnMessageReceived (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IRegisterMessageEventListener']/method[@name='OnMessageTypingIndication' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication']]"
			[Register ("OnMessageTypingIndication", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;)V", "GetOnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IRegisterMessageEventListenerInvoker, VidyoClientAndroid")]
			void OnMessageTypingIndication (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterMessageEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterMessageEventListenerInvoker : global::Java.Lang.Object, IRegisterMessageEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterMessageEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener"));
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoCall_IRegisterMessageEventListenerImplementor")]
		internal sealed partial class IRegisterMessageEventListenerImplementor : global::Java.Lang.Object, IRegisterMessageEventListener {

			object sender;

			public IRegisterMessageEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoCall_IRegisterMessageEventListenerImplementor", "()V"),
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IRegisterSubjectEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterSubjectEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IRegisterSubjectEventListenerInvoker")]
		public partial interface IRegisterSubjectEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoCall.IRegisterSubjectEventListener']/method[@name='OnSetSubject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("OnSetSubject", "(Ljava/lang/String;)V", "GetOnSetSubject_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IRegisterSubjectEventListenerInvoker, VidyoClientAndroid")]
			void OnSetSubject (string p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterSubjectEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterSubjectEventListenerInvoker : global::Java.Lang.Object, IRegisterSubjectEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterSubjectEventListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterSubjectEventListener"));
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
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterSubjectEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterSubjectEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoCall_IRegisterSubjectEventListenerImplementor")]
		internal sealed partial class IRegisterSubjectEventListenerImplementor : global::Java.Lang.Object, IRegisterSubjectEventListener {

			object sender;

			public IRegisterSubjectEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoCall_IRegisterSubjectEventListenerImplementor", "()V"),
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


		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallEndReason']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason", DoNotGenerateAcw=true)]
		public sealed partial class VidyoCallEndReason : global::Java.Lang.Enum {


			static IntPtr VIDYO_CALLENDREASON_ConnectionFailed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallEndReason']/field[@name='VIDYO_CALLENDREASON_ConnectionFailed']"
			[Register ("VIDYO_CALLENDREASON_ConnectionFailed")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason VIDYOCALLENDREASONConnectionFailed {
				get {
					if (VIDYO_CALLENDREASON_ConnectionFailed_jfieldId == IntPtr.Zero)
						VIDYO_CALLENDREASON_ConnectionFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLENDREASON_ConnectionFailed", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLENDREASON_ConnectionFailed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLENDREASON_ConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallEndReason']/field[@name='VIDYO_CALLENDREASON_ConnectionLost']"
			[Register ("VIDYO_CALLENDREASON_ConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason VIDYOCALLENDREASONConnectionLost {
				get {
					if (VIDYO_CALLENDREASON_ConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_CALLENDREASON_ConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLENDREASON_ConnectionLost", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLENDREASON_ConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLENDREASON_Ended_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallEndReason']/field[@name='VIDYO_CALLENDREASON_Ended']"
			[Register ("VIDYO_CALLENDREASON_Ended")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason VIDYOCALLENDREASONEnded {
				get {
					if (VIDYO_CALLENDREASON_Ended_jfieldId == IntPtr.Zero)
						VIDYO_CALLENDREASON_Ended_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLENDREASON_Ended", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLENDREASON_Ended_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLENDREASON_MiscError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallEndReason']/field[@name='VIDYO_CALLENDREASON_MiscError']"
			[Register ("VIDYO_CALLENDREASON_MiscError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason VIDYOCALLENDREASONMiscError {
				get {
					if (VIDYO_CALLENDREASON_MiscError_jfieldId == IntPtr.Zero)
						VIDYO_CALLENDREASON_MiscError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLENDREASON_MiscError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLENDREASON_MiscError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLENDREASON_ParticipantBusy_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallEndReason']/field[@name='VIDYO_CALLENDREASON_ParticipantBusy']"
			[Register ("VIDYO_CALLENDREASON_ParticipantBusy")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason VIDYOCALLENDREASONParticipantBusy {
				get {
					if (VIDYO_CALLENDREASON_ParticipantBusy_jfieldId == IntPtr.Zero)
						VIDYO_CALLENDREASON_ParticipantBusy_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLENDREASON_ParticipantBusy", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLENDREASON_ParticipantBusy_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLENDREASON_ParticipantEnded_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallEndReason']/field[@name='VIDYO_CALLENDREASON_ParticipantEnded']"
			[Register ("VIDYO_CALLENDREASON_ParticipantEnded")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason VIDYOCALLENDREASONParticipantEnded {
				get {
					if (VIDYO_CALLENDREASON_ParticipantEnded_jfieldId == IntPtr.Zero)
						VIDYO_CALLENDREASON_ParticipantEnded_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLENDREASON_ParticipantEnded", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLENDREASON_ParticipantEnded_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLENDREASON_ParticipantRejected_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallEndReason']/field[@name='VIDYO_CALLENDREASON_ParticipantRejected']"
			[Register ("VIDYO_CALLENDREASON_ParticipantRejected")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason VIDYOCALLENDREASONParticipantRejected {
				get {
					if (VIDYO_CALLENDREASON_ParticipantRejected_jfieldId == IntPtr.Zero)
						VIDYO_CALLENDREASON_ParticipantRejected_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLENDREASON_ParticipantRejected", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLENDREASON_ParticipantRejected_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoCallEndReason); }
			}

			internal VidyoCallEndReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallEndReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallEndReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallInitiatedResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoCallInitiatedResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_CALLINITIATEDRESULT_Cancelled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallInitiatedResult']/field[@name='VIDYO_CALLINITIATEDRESULT_Cancelled']"
			[Register ("VIDYO_CALLINITIATEDRESULT_Cancelled")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult VIDYOCALLINITIATEDRESULTCancelled {
				get {
					if (VIDYO_CALLINITIATEDRESULT_Cancelled_jfieldId == IntPtr.Zero)
						VIDYO_CALLINITIATEDRESULT_Cancelled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLINITIATEDRESULT_Cancelled", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLINITIATEDRESULT_Cancelled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLINITIATEDRESULT_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallInitiatedResult']/field[@name='VIDYO_CALLINITIATEDRESULT_MiscLocalError']"
			[Register ("VIDYO_CALLINITIATEDRESULT_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult VIDYOCALLINITIATEDRESULTMiscLocalError {
				get {
					if (VIDYO_CALLINITIATEDRESULT_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_CALLINITIATEDRESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLINITIATEDRESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLINITIATEDRESULT_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLINITIATEDRESULT_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallInitiatedResult']/field[@name='VIDYO_CALLINITIATEDRESULT_MiscRemoteError']"
			[Register ("VIDYO_CALLINITIATEDRESULT_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult VIDYOCALLINITIATEDRESULTMiscRemoteError {
				get {
					if (VIDYO_CALLINITIATEDRESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_CALLINITIATEDRESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLINITIATEDRESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLINITIATEDRESULT_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLINITIATEDRESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallInitiatedResult']/field[@name='VIDYO_CALLINITIATEDRESULT_NoResponse']"
			[Register ("VIDYO_CALLINITIATEDRESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult VIDYOCALLINITIATEDRESULTNoResponse {
				get {
					if (VIDYO_CALLINITIATEDRESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_CALLINITIATEDRESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLINITIATEDRESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLINITIATEDRESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLINITIATEDRESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallInitiatedResult']/field[@name='VIDYO_CALLINITIATEDRESULT_OK']"
			[Register ("VIDYO_CALLINITIATEDRESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult VidyoCallinitiatedresultOk {
				get {
					if (VIDYO_CALLINITIATEDRESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_CALLINITIATEDRESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLINITIATEDRESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLINITIATEDRESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_CALLINITIATEDRESULT_UnknownParticipant_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallInitiatedResult']/field[@name='VIDYO_CALLINITIATEDRESULT_UnknownParticipant']"
			[Register ("VIDYO_CALLINITIATEDRESULT_UnknownParticipant")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult VIDYOCALLINITIATEDRESULTUnknownParticipant {
				get {
					if (VIDYO_CALLINITIATEDRESULT_UnknownParticipant_jfieldId == IntPtr.Zero)
						VIDYO_CALLINITIATEDRESULT_UnknownParticipant_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_CALLINITIATEDRESULT_UnknownParticipant", "Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_CALLINITIATEDRESULT_UnknownParticipant_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoCallInitiatedResult); }
			}

			internal VidyoCallInitiatedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallInitiatedResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall.VidyoCallInitiatedResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoCall", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoCall); }
		}

		protected VidyoCall (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/constructor[@name='VidyoCall' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoCall (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoCall)) {
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='GetId' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_GetSubject;
#pragma warning disable 0169
		static Delegate GetGetSubjectHandler ()
		{
			if (cb_GetSubject == null)
				cb_GetSubject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubject);
			return cb_GetSubject;
		}

		static IntPtr n_GetSubject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Subject);
		}
#pragma warning restore 0169

		static IntPtr id_GetSubject;
		public virtual unsafe string Subject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='GetSubject' and count(parameter)=0]"
			[Register ("GetSubject", "()Ljava/lang/String;", "GetGetSubjectHandler")]
			get {
				if (id_GetSubject == IntPtr.Zero)
					id_GetSubject = JNIEnv.GetMethodID (class_ref, "GetSubject", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetSubject), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSubject", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.User);
		}
#pragma warning restore 0169

		static IntPtr id_GetUser;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser User {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='GetUser' and count(parameter)=0]"
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

		static Delegate cb_Accept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_;
#pragma warning disable 0169
		static Delegate GetAccept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_Handler ()
		{
			if (cb_Accept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_ == null)
				cb_Accept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Accept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_);
			return cb_Accept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_;
		}

		static bool n_Accept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Accept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='Accept' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall.IAccept']]"
		[Register ("Accept", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IAccept;)Z", "GetAccept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_Handler")]
		public virtual unsafe bool Accept (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept p0)
		{
			if (id_Accept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_ == IntPtr.Zero)
				id_Accept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_ = JNIEnv.GetMethodID (class_ref, "Accept", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IAccept;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Accept_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Accept", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IAccept;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetParticipants_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetParticipants_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetParticipants_Ljava_util_ArrayList_ == null)
				cb_GetParticipants_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetParticipants_Ljava_util_ArrayList_);
			return cb_GetParticipants_Ljava_util_ArrayList_;
		}

		static bool n_GetParticipants_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetParticipants (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetParticipants_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='GetParticipants' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoParticipant&gt;']]"
		[Register ("GetParticipants", "(Ljava/util/ArrayList;)Z", "GetGetParticipants_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool GetParticipants (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> p0)
		{
			if (id_GetParticipants_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetParticipants_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetParticipants", "(Ljava/util/ArrayList;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetParticipants_Ljava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetParticipants", "(Ljava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetRemoteRenderers_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetRemoteRenderers_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetRemoteRenderers_Ljava_util_ArrayList_ == null)
				cb_GetRemoteRenderers_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetRemoteRenderers_Ljava_util_ArrayList_);
			return cb_GetRemoteRenderers_Ljava_util_ArrayList_;
		}

		static bool n_GetRemoteRenderers_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetRemoteRenderers (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetRemoteRenderers_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='GetRemoteRenderers' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoRemoteRenderer&gt;']]"
		[Register ("GetRemoteRenderers", "(Ljava/util/ArrayList;)Z", "GetGetRemoteRenderers_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool GetRemoteRenderers (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer> p0)
		{
			if (id_GetRemoteRenderers_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetRemoteRenderers_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetRemoteRenderers", "(Ljava/util/ArrayList;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteRenderer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetRemoteRenderers_Ljava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetRemoteRenderers", "(Ljava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetRemoteSpeakers_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetRemoteSpeakers_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetRemoteSpeakers_Ljava_util_ArrayList_ == null)
				cb_GetRemoteSpeakers_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetRemoteSpeakers_Ljava_util_ArrayList_);
			return cb_GetRemoteSpeakers_Ljava_util_ArrayList_;
		}

		static bool n_GetRemoteSpeakers_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetRemoteSpeakers (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetRemoteSpeakers_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='GetRemoteSpeakers' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker&gt;']]"
		[Register ("GetRemoteSpeakers", "(Ljava/util/ArrayList;)Z", "GetGetRemoteSpeakers_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool GetRemoteSpeakers (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker> p0)
		{
			if (id_GetRemoteSpeakers_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetRemoteSpeakers_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetRemoteSpeakers", "(Ljava/util/ArrayList;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Device.VidyoRemoteSpeaker>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetRemoteSpeakers_Ljava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetRemoteSpeakers", "(Ljava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_HangUp;
#pragma warning disable 0169
		static Delegate GetHangUpHandler ()
		{
			if (cb_HangUp == null)
				cb_HangUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HangUp);
			return cb_HangUp;
		}

		static void n_HangUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HangUp ();
		}
#pragma warning restore 0169

		static IntPtr id_HangUp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='HangUp' and count(parameter)=0]"
		[Register ("HangUp", "()V", "GetHangUpHandler")]
		public virtual unsafe void HangUp ()
		{
			if (id_HangUp == IntPtr.Zero)
				id_HangUp = JNIEnv.GetMethodID (class_ref, "HangUp", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_HangUp);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "HangUp", "()V"));
			} finally {
			}
		}

		static Delegate cb_Initiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_;
#pragma warning disable 0169
		static Delegate GetInitiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_Handler ()
		{
			if (cb_Initiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_ == null)
				cb_Initiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Initiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_);
			return cb_Initiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_;
		}

		static bool n_Initiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Initiate (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Initiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='Initiate' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall.IAccept']]"
		[Register ("Initiate", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IAccept;)Z", "GetInitiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_Handler")]
		public virtual unsafe bool Initiate (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IAccept p0)
		{
			if (id_Initiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_ == IntPtr.Zero)
				id_Initiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_ = JNIEnv.GetMethodID (class_ref, "Initiate", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IAccept;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Initiate_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IAccept_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Initiate", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IAccept;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_;
#pragma warning disable 0169
		static Delegate GetOnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_Handler ()
		{
			if (cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ == null)
				cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_);
			return cb_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_;
		}

		static void n_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnEnded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='OnEnded' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason']]"
		[Register ("OnEnded", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;)V", "GetOnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_Handler")]
		public virtual unsafe void OnEnded (global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallEndReason p1)
		{
			if (id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ == IntPtr.Zero)
				id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_ = JNIEnv.GetMethodID (class_ref, "OnEnded", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnEnded_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallEndReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnEnded", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallEndReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
#pragma warning disable 0169
		static Delegate GetOnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler ()
		{
			if (cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == null)
				cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_);
			return cb_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		}

		static void n_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInitiated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='OnInitiated' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant']]"
		[Register ("OnInitiated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V", "GetOnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler")]
		public virtual unsafe void OnInitiated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.VidyoCallInitiatedResult p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
		{
			if (id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ == IntPtr.Zero)
				id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ = JNIEnv.GetMethodID (class_ref, "OnInitiated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnInitiated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_VidyoCallInitiatedResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnInitiated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$VidyoCallInitiatedResult;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V"), __args);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageAcknowledged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='OnMessageAcknowledged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageRead (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='OnMessageRead' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='long']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageReceived (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='OnMessageReceived' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoParticipant> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageTypingIndication (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='OnMessageTypingIndication' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoParticipant'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSetSubject (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnSetSubject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='OnSetSubject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_Handler ()
		{
			if (cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_ == null)
				cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_);
			return cb_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_;
		}

		static bool n_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterMessageEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='RegisterMessageEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener']]"
		[Register ("RegisterMessageEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterMessageEventListener;)Z", "GetRegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_Handler")]
		public virtual unsafe bool RegisterMessageEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterMessageEventListener p0)
		{
			if (id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_ == IntPtr.Zero)
				id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterMessageEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterMessageEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterMessageEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterMessageEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterMessageEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterMessageEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_Handler ()
		{
			if (cb_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_ == null)
				cb_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_);
			return cb_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_;
		}

		static bool n_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterSubjectEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterSubjectEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterSubjectEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterSubjectEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='RegisterSubjectEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterSubjectEventListener']]"
		[Register ("RegisterSubjectEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterSubjectEventListener;)Z", "GetRegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_Handler")]
		public virtual unsafe bool RegisterSubjectEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterSubjectEventListener p0)
		{
			if (id_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_ == IntPtr.Zero)
				id_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterSubjectEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterSubjectEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterSubjectEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_IRegisterSubjectEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterSubjectEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall$IRegisterSubjectEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_Reject;
#pragma warning disable 0169
		static Delegate GetRejectHandler ()
		{
			if (cb_Reject == null)
				cb_Reject = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reject);
			return cb_Reject;
		}

		static void n_Reject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reject ();
		}
#pragma warning restore 0169

		static IntPtr id_Reject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='Reject' and count(parameter)=0]"
		[Register ("Reject", "()V", "GetRejectHandler")]
		public virtual unsafe void Reject ()
		{
			if (id_Reject == IntPtr.Zero)
				id_Reject = JNIEnv.GetMethodID (class_ref, "Reject", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Reject);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Reject", "()V"));
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SendMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='SendMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSubject (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetSubject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='SetSubject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoCall']/method[@name='dispose' and count(parameter)=0]"
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
