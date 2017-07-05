using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser", DoNotGenerateAcw=true)]
	public partial class VidyoUser : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IAdvancedSearchRooms']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IAdvancedSearchRoomsInvoker")]
		public partial interface IAdvancedSearchRooms : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IAdvancedSearchRooms']/method[@name='OnRoomSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;'] and parameter[4][@type='long']]"
			[Register ("OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IAdvancedSearchRoomsInvoker, VidyoClientAndroid")]
			void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms", DoNotGenerateAcw=true)]
		internal class IAdvancedSearchRoomsInvoker : global::Java.Lang.Object, IAdvancedSearchRooms {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAdvancedSearchRoomsInvoker); }
			}

			IntPtr class_ref;

			public static IAdvancedSearchRooms GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAdvancedSearchRooms> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAdvancedSearchRoomsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
			static Delegate GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
			{
				if (cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
					cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
				return cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			}

			static void n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomSearchResults (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			public unsafe void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3)
			{
				if (id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
					id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IAdvancedSearchUsers']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchUsers", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IAdvancedSearchUsersInvoker")]
		public partial interface IAdvancedSearchUsers : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IAdvancedSearchUsers']/method[@name='OnUserSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoContactInfo&gt;'] and parameter[4][@type='long']]"
			[Register ("OnUserSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IAdvancedSearchUsersInvoker, VidyoClientAndroid")]
			void OnUserSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo> p2, long p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchUsers", DoNotGenerateAcw=true)]
		internal class IAdvancedSearchUsersInvoker : global::Java.Lang.Object, IAdvancedSearchUsers {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchUsers");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAdvancedSearchUsersInvoker); }
			}

			IntPtr class_ref;

			public static IAdvancedSearchUsers GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAdvancedSearchUsers> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAdvancedSearchUsersInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
			static Delegate GetOnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
			{
				if (cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
					cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
				return cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			}

			static void n_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnUserSearchResults (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			public unsafe void OnUserSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo> p2, long p3)
			{
				if (id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
					id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnUserSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ICreateCall']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateCall", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ICreateCallInvoker")]
		public partial interface ICreateCall : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ICreateCall']/method[@name='OnCallCreated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult'] and parameter[3][@type='java.lang.String']]"
			[Register ("OnCallCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;Ljava/lang/String;)V", "GetOnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ICreateCallInvoker, VidyoClientAndroid")]
			void OnCallCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult p1, string p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateCall", DoNotGenerateAcw=true)]
		internal class ICreateCallInvoker : global::Java.Lang.Object, ICreateCall {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateCall");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICreateCallInvoker); }
			}

			IntPtr class_ref;

			public static ICreateCall GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICreateCall> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ICreateCall"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICreateCallInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_Handler ()
			{
				if (cb_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_ == null)
					cb_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_);
				return cb_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_;
			}

			static void n_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateCall __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnCallCreated (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_;
			public unsafe void OnCallCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult p1, string p2)
			{
				if (id_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_ == IntPtr.Zero)
					id_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnCallCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;Ljava/lang/String;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ICreateRoomFromId']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ICreateRoomFromIdInvoker")]
		public partial interface ICreateRoomFromId : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ICreateRoomFromId']/method[@name='OnRoomCreated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult'] and parameter[3][@type='java.lang.String']]"
			[Register ("OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V", "GetOnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ICreateRoomFromIdInvoker, VidyoClientAndroid")]
			void OnRoomCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1, string p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId", DoNotGenerateAcw=true)]
		internal class ICreateRoomFromIdInvoker : global::Java.Lang.Object, ICreateRoomFromId {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICreateRoomFromIdInvoker); }
			}

			IntPtr class_ref;

			public static ICreateRoomFromId GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICreateRoomFromId> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICreateRoomFromIdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_Handler ()
			{
				if (cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ == null)
					cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_);
				return cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
			}

			static void n_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomCreated (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
			public unsafe void OnRoomCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1, string p2)
			{
				if (id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ == IntPtr.Zero)
					id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ICreateRoomWithId']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomWithId", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ICreateRoomWithIdInvoker")]
		public partial interface ICreateRoomWithId : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ICreateRoomWithId']/method[@name='OnRoomCreated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult'] and parameter[3][@type='java.lang.String']]"
			[Register ("OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V", "GetOnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ICreateRoomWithIdInvoker, VidyoClientAndroid")]
			void OnRoomCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1, string p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomWithId", DoNotGenerateAcw=true)]
		internal class ICreateRoomWithIdInvoker : global::Java.Lang.Object, ICreateRoomWithId {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomWithId");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICreateRoomWithIdInvoker); }
			}

			IntPtr class_ref;

			public static ICreateRoomWithId GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICreateRoomWithId> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomWithId"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICreateRoomWithIdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_Handler ()
			{
				if (cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ == null)
					cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_);
				return cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
			}

			static void n_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomWithId __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomWithId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomCreated (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
			public unsafe void OnRoomCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1, string p2)
			{
				if (id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ == IntPtr.Zero)
					id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ICreateTopicRoom']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateTopicRoom", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ICreateTopicRoomInvoker")]
		public partial interface ICreateTopicRoom : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ICreateTopicRoom']/method[@name='OnRoomCreated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult'] and parameter[3][@type='java.lang.String']]"
			[Register ("OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V", "GetOnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ICreateTopicRoomInvoker, VidyoClientAndroid")]
			void OnRoomCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1, string p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateTopicRoom", DoNotGenerateAcw=true)]
		internal class ICreateTopicRoomInvoker : global::Java.Lang.Object, ICreateTopicRoom {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateTopicRoom");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICreateTopicRoomInvoker); }
			}

			IntPtr class_ref;

			public static ICreateTopicRoom GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICreateTopicRoom> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ICreateTopicRoom"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICreateTopicRoomInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_Handler ()
			{
				if (cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ == null)
					cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_);
				return cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
			}

			static void n_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateTopicRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateTopicRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomCreated (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
			public unsafe void OnRoomCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1, string p2)
			{
				if (id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ == IntPtr.Zero)
					id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IGetContact']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetContact", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IGetContactInvoker")]
		public partial interface IGetContact : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IGetContact']/method[@name='OnGetContactResult' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult']]"
			[Register ("OnGetContactResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;)V", "GetOnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IGetContactInvoker, VidyoClientAndroid")]
			void OnGetContactResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetContact", DoNotGenerateAcw=true)]
		internal class IGetContactInvoker : global::Java.Lang.Object, IGetContact {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetContact");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGetContactInvoker); }
			}

			IntPtr class_ref;

			public static IGetContact GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGetContact> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.IGetContact"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGetContactInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_;
#pragma warning disable 0169
			static Delegate GetOnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_Handler ()
			{
				if (cb_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_ == null)
					cb_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_);
				return cb_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_;
			}

			static void n_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetContact __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetContact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnGetContactResult (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_;
			public unsafe void OnGetContactResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult p1)
			{
				if (id_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_ == IntPtr.Zero)
					id_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_ = JNIEnv.GetMethodID (class_ref, "OnGetContactResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IGetConversationRoom']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetConversationRoom", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IGetConversationRoomInvoker")]
		public partial interface IGetConversationRoom : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IGetConversationRoom']/method[@name='OnRoomCreated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult'] and parameter[3][@type='java.lang.String']]"
			[Register ("OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V", "GetOnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IGetConversationRoomInvoker, VidyoClientAndroid")]
			void OnRoomCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1, string p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetConversationRoom", DoNotGenerateAcw=true)]
		internal class IGetConversationRoomInvoker : global::Java.Lang.Object, IGetConversationRoom {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetConversationRoom");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGetConversationRoomInvoker); }
			}

			IntPtr class_ref;

			public static IGetConversationRoom GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGetConversationRoom> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.IGetConversationRoom"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGetConversationRoomInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_Handler ()
			{
				if (cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ == null)
					cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_);
				return cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
			}

			static void n_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetConversationRoom __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetConversationRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomCreated (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
			public unsafe void OnRoomCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1, string p2)
			{
				if (id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ == IntPtr.Zero)
					id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IGetFavoriteRooms']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetFavoriteRooms", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IGetFavoriteRoomsInvoker")]
		public partial interface IGetFavoriteRooms : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IGetFavoriteRooms']/method[@name='OnFavoriteRoomResults' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;']]"
			[Register ("OnFavoriteRoomResults", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;)V", "GetOnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IGetFavoriteRoomsInvoker, VidyoClientAndroid")]
			void OnFavoriteRoomResults (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetFavoriteRooms", DoNotGenerateAcw=true)]
		internal class IGetFavoriteRoomsInvoker : global::Java.Lang.Object, IGetFavoriteRooms {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetFavoriteRooms");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGetFavoriteRoomsInvoker); }
			}

			IntPtr class_ref;

			public static IGetFavoriteRooms GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGetFavoriteRooms> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.IGetFavoriteRooms"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGetFavoriteRoomsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetOnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_Handler ()
			{
				if (cb_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ == null)
					cb_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_);
				return cb_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
			}

			static void n_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetFavoriteRooms __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetFavoriteRooms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFavoriteRoomResults (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
			public unsafe void OnFavoriteRoomResults (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p1)
			{
				if (id_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "OnFavoriteRoomResults", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;)V");
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IGetRecentRooms']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetRecentRooms", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IGetRecentRoomsInvoker")]
		public partial interface IGetRecentRooms : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IGetRecentRooms']/method[@name='OnRecentRoomResults' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;']]"
			[Register ("OnRecentRoomResults", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;)V", "GetOnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IGetRecentRoomsInvoker, VidyoClientAndroid")]
			void OnRecentRoomResults (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetRecentRooms", DoNotGenerateAcw=true)]
		internal class IGetRecentRoomsInvoker : global::Java.Lang.Object, IGetRecentRooms {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IGetRecentRooms");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGetRecentRoomsInvoker); }
			}

			IntPtr class_ref;

			public static IGetRecentRooms GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGetRecentRooms> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.IGetRecentRooms"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGetRecentRoomsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetOnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_Handler ()
			{
				if (cb_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ == null)
					cb_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_);
				return cb_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
			}

			static void n_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetRecentRooms __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetRecentRooms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRecentRoomResults (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
			public unsafe void OnRecentRoomResults (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p1)
			{
				if (id_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "OnRecentRoomResults", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;)V");
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILogin']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginInvoker")]
		public partial interface ILogin : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILogin']/method[@name='OnConnectionStatusChanged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason']]"
			[Register ("OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V", "GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginInvoker, VidyoClientAndroid")]
			void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILogin']/method[@name='OnLoggedOut' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason']]"
			[Register ("OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V", "GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginInvoker, VidyoClientAndroid")]
			void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILogin']/method[@name='OnLoginComplete' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult'] and parameter[2][@type='boolean']]"
			[Register ("OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V", "GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginInvoker, VidyoClientAndroid")]
			void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILogin']/method[@name='OnTokenReceived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType']]"
			[Register ("OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V", "GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginInvoker, VidyoClientAndroid")]
			void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILogin']/method[@name='OnWebProxyCredentialsRequest' and count(parameter)=0]"
			[Register ("OnWebProxyCredentialsRequest", "()V", "GetOnWebProxyCredentialsRequestHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginInvoker, VidyoClientAndroid")]
			void OnWebProxyCredentialsRequest ();

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin", DoNotGenerateAcw=true)]
		internal class ILoginInvoker : global::Java.Lang.Object, ILogin {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ILoginInvoker); }
			}

			IntPtr class_ref;

			public static ILogin GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILogin> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ILogin"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILoginInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
#pragma warning disable 0169
			static Delegate GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler ()
			{
				if (cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == null)
					cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_);
				return cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
			}

			static void n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionStatusChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
			public unsafe void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0)
			{
				if (id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == IntPtr.Zero)
					id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNIEnv.GetMethodID (class_ref, "OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_, __args);
			}

			static Delegate cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
#pragma warning disable 0169
			static Delegate GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler ()
			{
				if (cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == null)
					cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_);
				return cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
			}

			static void n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoggedOut (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
			public unsafe void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0)
			{
				if (id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == IntPtr.Zero)
					id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNIEnv.GetMethodID (class_ref, "OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_, __args);
			}

			static Delegate cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
#pragma warning disable 0169
			static Delegate GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler ()
			{
				if (cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == null)
					cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z);
				return cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
			}

			static void n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoginComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
			public unsafe void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1)
			{
				if (id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == IntPtr.Zero)
					id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNIEnv.GetMethodID (class_ref, "OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z, __args);
			}

			static Delegate cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
#pragma warning disable 0169
			static Delegate GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler ()
			{
				if (cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == null)
					cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_);
				return cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
			}

			static void n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTokenReceived (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
			public unsafe void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1)
			{
				if (id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == IntPtr.Zero)
					id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNIEnv.GetMethodID (class_ref, "OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_OnWebProxyCredentialsRequest;
#pragma warning disable 0169
			static Delegate GetOnWebProxyCredentialsRequestHandler ()
			{
				if (cb_OnWebProxyCredentialsRequest == null)
					cb_OnWebProxyCredentialsRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebProxyCredentialsRequest);
				return cb_OnWebProxyCredentialsRequest;
			}

			static void n_OnWebProxyCredentialsRequest (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWebProxyCredentialsRequest ();
			}
#pragma warning restore 0169

			IntPtr id_OnWebProxyCredentialsRequest;
			public unsafe void OnWebProxyCredentialsRequest ()
			{
				if (id_OnWebProxyCredentialsRequest == IntPtr.Zero)
					id_OnWebProxyCredentialsRequest = JNIEnv.GetMethodID (class_ref, "OnWebProxyCredentialsRequest", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnWebProxyCredentialsRequest);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginAsGuest']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginAsGuest", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginAsGuestInvoker")]
		public partial interface ILoginAsGuest : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginAsGuest']/method[@name='OnConnectionStatusChanged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason']]"
			[Register ("OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V", "GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginAsGuestInvoker, VidyoClientAndroid")]
			void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginAsGuest']/method[@name='OnLoggedOut' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason']]"
			[Register ("OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V", "GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginAsGuestInvoker, VidyoClientAndroid")]
			void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginAsGuest']/method[@name='OnLoginComplete' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult'] and parameter[2][@type='boolean']]"
			[Register ("OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V", "GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginAsGuestInvoker, VidyoClientAndroid")]
			void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginAsGuest']/method[@name='OnTokenReceived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType']]"
			[Register ("OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V", "GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginAsGuestInvoker, VidyoClientAndroid")]
			void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginAsGuest']/method[@name='OnWebProxyCredentialsRequest' and count(parameter)=0]"
			[Register ("OnWebProxyCredentialsRequest", "()V", "GetOnWebProxyCredentialsRequestHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginAsGuestInvoker, VidyoClientAndroid")]
			void OnWebProxyCredentialsRequest ();

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginAsGuest", DoNotGenerateAcw=true)]
		internal class ILoginAsGuestInvoker : global::Java.Lang.Object, ILoginAsGuest {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginAsGuest");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ILoginAsGuestInvoker); }
			}

			IntPtr class_ref;

			public static ILoginAsGuest GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILoginAsGuest> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILoginAsGuestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
#pragma warning disable 0169
			static Delegate GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler ()
			{
				if (cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == null)
					cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_);
				return cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
			}

			static void n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionStatusChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
			public unsafe void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0)
			{
				if (id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == IntPtr.Zero)
					id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNIEnv.GetMethodID (class_ref, "OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_, __args);
			}

			static Delegate cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
#pragma warning disable 0169
			static Delegate GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler ()
			{
				if (cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == null)
					cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_);
				return cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
			}

			static void n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoggedOut (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
			public unsafe void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0)
			{
				if (id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == IntPtr.Zero)
					id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNIEnv.GetMethodID (class_ref, "OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_, __args);
			}

			static Delegate cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
#pragma warning disable 0169
			static Delegate GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler ()
			{
				if (cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == null)
					cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z);
				return cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
			}

			static void n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoginComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
			public unsafe void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1)
			{
				if (id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == IntPtr.Zero)
					id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNIEnv.GetMethodID (class_ref, "OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z, __args);
			}

			static Delegate cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
#pragma warning disable 0169
			static Delegate GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler ()
			{
				if (cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == null)
					cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_);
				return cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
			}

			static void n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTokenReceived (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
			public unsafe void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1)
			{
				if (id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == IntPtr.Zero)
					id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNIEnv.GetMethodID (class_ref, "OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_OnWebProxyCredentialsRequest;
#pragma warning disable 0169
			static Delegate GetOnWebProxyCredentialsRequestHandler ()
			{
				if (cb_OnWebProxyCredentialsRequest == null)
					cb_OnWebProxyCredentialsRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebProxyCredentialsRequest);
				return cb_OnWebProxyCredentialsRequest;
			}

			static void n_OnWebProxyCredentialsRequest (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginAsGuest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWebProxyCredentialsRequest ();
			}
#pragma warning restore 0169

			IntPtr id_OnWebProxyCredentialsRequest;
			public unsafe void OnWebProxyCredentialsRequest ()
			{
				if (id_OnWebProxyCredentialsRequest == IntPtr.Zero)
					id_OnWebProxyCredentialsRequest = JNIEnv.GetMethodID (class_ref, "OnWebProxyCredentialsRequest", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnWebProxyCredentialsRequest);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithAccessToken']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginWithAccessToken", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithAccessTokenInvoker")]
		public partial interface ILoginWithAccessToken : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithAccessToken']/method[@name='OnConnectionStatusChanged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason']]"
			[Register ("OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V", "GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithAccessTokenInvoker, VidyoClientAndroid")]
			void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithAccessToken']/method[@name='OnLoggedOut' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason']]"
			[Register ("OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V", "GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithAccessTokenInvoker, VidyoClientAndroid")]
			void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithAccessToken']/method[@name='OnLoginComplete' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult'] and parameter[2][@type='boolean']]"
			[Register ("OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V", "GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithAccessTokenInvoker, VidyoClientAndroid")]
			void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithAccessToken']/method[@name='OnTokenReceived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType']]"
			[Register ("OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V", "GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithAccessTokenInvoker, VidyoClientAndroid")]
			void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithAccessToken']/method[@name='OnWebProxyCredentialsRequest' and count(parameter)=0]"
			[Register ("OnWebProxyCredentialsRequest", "()V", "GetOnWebProxyCredentialsRequestHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithAccessTokenInvoker, VidyoClientAndroid")]
			void OnWebProxyCredentialsRequest ();

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginWithAccessToken", DoNotGenerateAcw=true)]
		internal class ILoginWithAccessTokenInvoker : global::Java.Lang.Object, ILoginWithAccessToken {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginWithAccessToken");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ILoginWithAccessTokenInvoker); }
			}

			IntPtr class_ref;

			public static ILoginWithAccessToken GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILoginWithAccessToken> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILoginWithAccessTokenInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
#pragma warning disable 0169
			static Delegate GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler ()
			{
				if (cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == null)
					cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_);
				return cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
			}

			static void n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionStatusChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
			public unsafe void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0)
			{
				if (id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == IntPtr.Zero)
					id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNIEnv.GetMethodID (class_ref, "OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_, __args);
			}

			static Delegate cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
#pragma warning disable 0169
			static Delegate GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler ()
			{
				if (cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == null)
					cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_);
				return cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
			}

			static void n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoggedOut (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
			public unsafe void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0)
			{
				if (id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == IntPtr.Zero)
					id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNIEnv.GetMethodID (class_ref, "OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_, __args);
			}

			static Delegate cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
#pragma warning disable 0169
			static Delegate GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler ()
			{
				if (cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == null)
					cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z);
				return cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
			}

			static void n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoginComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
			public unsafe void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1)
			{
				if (id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == IntPtr.Zero)
					id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNIEnv.GetMethodID (class_ref, "OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z, __args);
			}

			static Delegate cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
#pragma warning disable 0169
			static Delegate GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler ()
			{
				if (cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == null)
					cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_);
				return cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
			}

			static void n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTokenReceived (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
			public unsafe void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1)
			{
				if (id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == IntPtr.Zero)
					id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNIEnv.GetMethodID (class_ref, "OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_OnWebProxyCredentialsRequest;
#pragma warning disable 0169
			static Delegate GetOnWebProxyCredentialsRequestHandler ()
			{
				if (cb_OnWebProxyCredentialsRequest == null)
					cb_OnWebProxyCredentialsRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebProxyCredentialsRequest);
				return cb_OnWebProxyCredentialsRequest;
			}

			static void n_OnWebProxyCredentialsRequest (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithAccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWebProxyCredentialsRequest ();
			}
#pragma warning restore 0169

			IntPtr id_OnWebProxyCredentialsRequest;
			public unsafe void OnWebProxyCredentialsRequest ()
			{
				if (id_OnWebProxyCredentialsRequest == IntPtr.Zero)
					id_OnWebProxyCredentialsRequest = JNIEnv.GetMethodID (class_ref, "OnWebProxyCredentialsRequest", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnWebProxyCredentialsRequest);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithRefreshToken']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginWithRefreshToken", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithRefreshTokenInvoker")]
		public partial interface ILoginWithRefreshToken : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithRefreshToken']/method[@name='OnConnectionStatusChanged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason']]"
			[Register ("OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V", "GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithRefreshTokenInvoker, VidyoClientAndroid")]
			void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithRefreshToken']/method[@name='OnLoggedOut' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason']]"
			[Register ("OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V", "GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithRefreshTokenInvoker, VidyoClientAndroid")]
			void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithRefreshToken']/method[@name='OnLoginComplete' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult'] and parameter[2][@type='boolean']]"
			[Register ("OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V", "GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithRefreshTokenInvoker, VidyoClientAndroid")]
			void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithRefreshToken']/method[@name='OnTokenReceived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType']]"
			[Register ("OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V", "GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithRefreshTokenInvoker, VidyoClientAndroid")]
			void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithRefreshToken']/method[@name='OnWebProxyCredentialsRequest' and count(parameter)=0]"
			[Register ("OnWebProxyCredentialsRequest", "()V", "GetOnWebProxyCredentialsRequestHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithRefreshTokenInvoker, VidyoClientAndroid")]
			void OnWebProxyCredentialsRequest ();

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginWithRefreshToken", DoNotGenerateAcw=true)]
		internal class ILoginWithRefreshTokenInvoker : global::Java.Lang.Object, ILoginWithRefreshToken {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginWithRefreshToken");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ILoginWithRefreshTokenInvoker); }
			}

			IntPtr class_ref;

			public static ILoginWithRefreshToken GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILoginWithRefreshToken> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILoginWithRefreshTokenInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
#pragma warning disable 0169
			static Delegate GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler ()
			{
				if (cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == null)
					cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_);
				return cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
			}

			static void n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionStatusChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
			public unsafe void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0)
			{
				if (id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == IntPtr.Zero)
					id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNIEnv.GetMethodID (class_ref, "OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_, __args);
			}

			static Delegate cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
#pragma warning disable 0169
			static Delegate GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler ()
			{
				if (cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == null)
					cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_);
				return cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
			}

			static void n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoggedOut (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
			public unsafe void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0)
			{
				if (id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == IntPtr.Zero)
					id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNIEnv.GetMethodID (class_ref, "OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_, __args);
			}

			static Delegate cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
#pragma warning disable 0169
			static Delegate GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler ()
			{
				if (cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == null)
					cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z);
				return cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
			}

			static void n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoginComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
			public unsafe void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1)
			{
				if (id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == IntPtr.Zero)
					id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNIEnv.GetMethodID (class_ref, "OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z, __args);
			}

			static Delegate cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
#pragma warning disable 0169
			static Delegate GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler ()
			{
				if (cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == null)
					cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_);
				return cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
			}

			static void n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTokenReceived (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
			public unsafe void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1)
			{
				if (id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == IntPtr.Zero)
					id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNIEnv.GetMethodID (class_ref, "OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_OnWebProxyCredentialsRequest;
#pragma warning disable 0169
			static Delegate GetOnWebProxyCredentialsRequestHandler ()
			{
				if (cb_OnWebProxyCredentialsRequest == null)
					cb_OnWebProxyCredentialsRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebProxyCredentialsRequest);
				return cb_OnWebProxyCredentialsRequest;
			}

			static void n_OnWebProxyCredentialsRequest (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithRefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWebProxyCredentialsRequest ();
			}
#pragma warning restore 0169

			IntPtr id_OnWebProxyCredentialsRequest;
			public unsafe void OnWebProxyCredentialsRequest ()
			{
				if (id_OnWebProxyCredentialsRequest == IntPtr.Zero)
					id_OnWebProxyCredentialsRequest = JNIEnv.GetMethodID (class_ref, "OnWebProxyCredentialsRequest", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnWebProxyCredentialsRequest);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithTenantToken']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginWithTenantToken", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithTenantTokenInvoker")]
		public partial interface ILoginWithTenantToken : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithTenantToken']/method[@name='OnConnectionStatusChanged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason']]"
			[Register ("OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V", "GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithTenantTokenInvoker, VidyoClientAndroid")]
			void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithTenantToken']/method[@name='OnLoggedOut' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason']]"
			[Register ("OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V", "GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithTenantTokenInvoker, VidyoClientAndroid")]
			void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithTenantToken']/method[@name='OnLoginComplete' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult'] and parameter[2][@type='boolean']]"
			[Register ("OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V", "GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithTenantTokenInvoker, VidyoClientAndroid")]
			void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithTenantToken']/method[@name='OnTokenReceived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType']]"
			[Register ("OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V", "GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithTenantTokenInvoker, VidyoClientAndroid")]
			void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ILoginWithTenantToken']/method[@name='OnWebProxyCredentialsRequest' and count(parameter)=0]"
			[Register ("OnWebProxyCredentialsRequest", "()V", "GetOnWebProxyCredentialsRequestHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ILoginWithTenantTokenInvoker, VidyoClientAndroid")]
			void OnWebProxyCredentialsRequest ();

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginWithTenantToken", DoNotGenerateAcw=true)]
		internal class ILoginWithTenantTokenInvoker : global::Java.Lang.Object, ILoginWithTenantToken {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ILoginWithTenantToken");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ILoginWithTenantTokenInvoker); }
			}

			IntPtr class_ref;

			public static ILoginWithTenantToken GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILoginWithTenantToken> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILoginWithTenantTokenInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
#pragma warning disable 0169
			static Delegate GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler ()
			{
				if (cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == null)
					cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_);
				return cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
			}

			static void n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionStatusChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
			public unsafe void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0)
			{
				if (id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == IntPtr.Zero)
					id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNIEnv.GetMethodID (class_ref, "OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_, __args);
			}

			static Delegate cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
#pragma warning disable 0169
			static Delegate GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler ()
			{
				if (cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == null)
					cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_);
				return cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
			}

			static void n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoggedOut (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
			public unsafe void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0)
			{
				if (id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == IntPtr.Zero)
					id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNIEnv.GetMethodID (class_ref, "OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_, __args);
			}

			static Delegate cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
#pragma warning disable 0169
			static Delegate GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler ()
			{
				if (cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == null)
					cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z);
				return cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
			}

			static void n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoginComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
			public unsafe void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1)
			{
				if (id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == IntPtr.Zero)
					id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNIEnv.GetMethodID (class_ref, "OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z, __args);
			}

			static Delegate cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
#pragma warning disable 0169
			static Delegate GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler ()
			{
				if (cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == null)
					cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_);
				return cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
			}

			static void n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTokenReceived (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
			public unsafe void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1)
			{
				if (id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == IntPtr.Zero)
					id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNIEnv.GetMethodID (class_ref, "OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_OnWebProxyCredentialsRequest;
#pragma warning disable 0169
			static Delegate GetOnWebProxyCredentialsRequestHandler ()
			{
				if (cb_OnWebProxyCredentialsRequest == null)
					cb_OnWebProxyCredentialsRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebProxyCredentialsRequest);
				return cb_OnWebProxyCredentialsRequest;
			}

			static void n_OnWebProxyCredentialsRequest (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILoginWithTenantToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWebProxyCredentialsRequest ();
			}
#pragma warning restore 0169

			IntPtr id_OnWebProxyCredentialsRequest;
			public unsafe void OnWebProxyCredentialsRequest ()
			{
				if (id_OnWebProxyCredentialsRequest == IntPtr.Zero)
					id_OnWebProxyCredentialsRequest = JNIEnv.GetMethodID (class_ref, "OnWebProxyCredentialsRequest", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnWebProxyCredentialsRequest);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterCallEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterCallEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterCallEventListenerInvoker")]
		public partial interface IRegisterCallEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterCallEventListener']/method[@name='OnCallCreatedByInvite' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact']]"
			[Register ("OnCallCreatedByInvite", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V", "GetOnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterCallEventListenerInvoker, VidyoClientAndroid")]
			void OnCallCreatedByInvite (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterCallEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterCallEventListenerInvoker : global::Java.Lang.Object, IRegisterCallEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterCallEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterCallEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterCallEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterCallEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterCallEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterCallEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
#pragma warning disable 0169
			static Delegate GetOnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler ()
			{
				if (cb_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == null)
					cb_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_);
				return cb_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
			}

			static void n_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterCallEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterCallEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnCallCreatedByInvite (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
			public unsafe void OnCallCreatedByInvite (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1)
			{
				if (id_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == IntPtr.Zero)
					id_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNIEnv.GetMethodID (class_ref, "OnCallCreatedByInvite", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_, __args);
			}

		}

		public partial class RegisterCallEventEventArgs : global::System.EventArgs {

			public RegisterCallEventEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoUser_IRegisterCallEventListenerImplementor")]
		internal sealed partial class IRegisterCallEventListenerImplementor : global::Java.Lang.Object, IRegisterCallEventListener {

			object sender;

			public IRegisterCallEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoUser_IRegisterCallEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RegisterCallEventEventArgs> Handler;
#pragma warning restore 0649

			public void OnCallCreatedByInvite (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RegisterCallEventEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRegisterCallEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterContactEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterContactEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterContactEventListenerInvoker")]
		public partial interface IRegisterContactEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterContactEventListener']/method[@name='OnRemoveRosterContact' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("OnRemoveRosterContact", "(Ljava/lang/String;)V", "GetOnRemoveRosterContact_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterContactEventListenerInvoker, VidyoClientAndroid")]
			void OnRemoveRosterContact (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterContactEventListener']/method[@name='OnUpdateRosterContact' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact']]"
			[Register ("OnUpdateRosterContact", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V", "GetOnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterContactEventListenerInvoker, VidyoClientAndroid")]
			void OnUpdateRosterContact (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterContactEventListener']/method[@name='OnUpdateSelf' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact']]"
			[Register ("OnUpdateSelf", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V", "GetOnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterContactEventListenerInvoker, VidyoClientAndroid")]
			void OnUpdateSelf (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterContactEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterContactEventListenerInvoker : global::Java.Lang.Object, IRegisterContactEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterContactEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterContactEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterContactEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterContactEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterContactEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRemoveRosterContact_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRemoveRosterContact_Ljava_lang_String_Handler ()
			{
				if (cb_OnRemoveRosterContact_Ljava_lang_String_ == null)
					cb_OnRemoveRosterContact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRemoveRosterContact_Ljava_lang_String_);
				return cb_OnRemoveRosterContact_Ljava_lang_String_;
			}

			static void n_OnRemoveRosterContact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoveRosterContact (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnRemoveRosterContact_Ljava_lang_String_;
			public unsafe void OnRemoveRosterContact (string p0)
			{
				if (id_OnRemoveRosterContact_Ljava_lang_String_ == IntPtr.Zero)
					id_OnRemoveRosterContact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnRemoveRosterContact", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoveRosterContact_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
#pragma warning disable 0169
			static Delegate GetOnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler ()
			{
				if (cb_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == null)
					cb_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_);
				return cb_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
			}

			static void n_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUpdateRosterContact (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
			public unsafe void OnUpdateRosterContact (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0)
			{
				if (id_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == IntPtr.Zero)
					id_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNIEnv.GetMethodID (class_ref, "OnUpdateRosterContact", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_, __args);
			}

			static Delegate cb_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
#pragma warning disable 0169
			static Delegate GetOnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler ()
			{
				if (cb_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == null)
					cb_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_);
				return cb_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
			}

			static void n_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUpdateSelf (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
			public unsafe void OnUpdateSelf (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0)
			{
				if (id_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == IntPtr.Zero)
					id_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNIEnv.GetMethodID (class_ref, "OnUpdateSelf", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_, __args);
			}

		}

		public partial class RemoveRosterContactEventArgs : global::System.EventArgs {

			public RemoveRosterContactEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		public partial class UpdateRosterContactEventArgs : global::System.EventArgs {

			public UpdateRosterContactEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact P0 {
				get { return p0; }
			}
		}

		public partial class UpdateSelfEventArgs : global::System.EventArgs {

			public UpdateSelfEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0)
			{
				this.p0 = p0;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoUser_IRegisterContactEventListenerImplementor")]
		internal sealed partial class IRegisterContactEventListenerImplementor : global::Java.Lang.Object, IRegisterContactEventListener {

			object sender;

			public IRegisterContactEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoUser_IRegisterContactEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoveRosterContactEventArgs> OnRemoveRosterContactHandler;
#pragma warning restore 0649

			public void OnRemoveRosterContact (string p0)
			{
				var __h = OnRemoveRosterContactHandler;
				if (__h != null)
					__h (sender, new RemoveRosterContactEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<UpdateRosterContactEventArgs> OnUpdateRosterContactHandler;
#pragma warning restore 0649

			public void OnUpdateRosterContact (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0)
			{
				var __h = OnUpdateRosterContactHandler;
				if (__h != null)
					__h (sender, new UpdateRosterContactEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<UpdateSelfEventArgs> OnUpdateSelfHandler;
#pragma warning restore 0649

			public void OnUpdateSelf (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0)
			{
				var __h = OnUpdateSelfHandler;
				if (__h != null)
					__h (sender, new UpdateSelfEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterContactEventListenerImplementor value)
			{
				return value.OnRemoveRosterContactHandler == null && value.OnUpdateRosterContactHandler == null && value.OnUpdateSelfHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterLicenseEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterLicenseEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterLicenseEventListenerInvoker")]
		public partial interface IRegisterLicenseEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterLicenseEventListener']/method[@name='OnGetLicenseKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("OnGetLicenseKey", "(Ljava/lang/String;)V", "GetOnGetLicenseKey_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterLicenseEventListenerInvoker, VidyoClientAndroid")]
			void OnGetLicenseKey (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterLicenseEventListener']/method[@name='OnLicenseReceived' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("OnLicenseReceived", "(Ljava/lang/String;)V", "GetOnLicenseReceived_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterLicenseEventListenerInvoker, VidyoClientAndroid")]
			void OnLicenseReceived (string p0);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterLicenseEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterLicenseEventListenerInvoker : global::Java.Lang.Object, IRegisterLicenseEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterLicenseEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterLicenseEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterLicenseEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterLicenseEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterLicenseEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnGetLicenseKey_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnGetLicenseKey_Ljava_lang_String_Handler ()
			{
				if (cb_OnGetLicenseKey_Ljava_lang_String_ == null)
					cb_OnGetLicenseKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetLicenseKey_Ljava_lang_String_);
				return cb_OnGetLicenseKey_Ljava_lang_String_;
			}

			static void n_OnGetLicenseKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnGetLicenseKey (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnGetLicenseKey_Ljava_lang_String_;
			public unsafe void OnGetLicenseKey (string p0)
			{
				if (id_OnGetLicenseKey_Ljava_lang_String_ == IntPtr.Zero)
					id_OnGetLicenseKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnGetLicenseKey", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnGetLicenseKey_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_OnLicenseReceived_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnLicenseReceived_Ljava_lang_String_Handler ()
			{
				if (cb_OnLicenseReceived_Ljava_lang_String_ == null)
					cb_OnLicenseReceived_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLicenseReceived_Ljava_lang_String_);
				return cb_OnLicenseReceived_Ljava_lang_String_;
			}

			static void n_OnLicenseReceived_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLicenseReceived (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnLicenseReceived_Ljava_lang_String_;
			public unsafe void OnLicenseReceived (string p0)
			{
				if (id_OnLicenseReceived_Ljava_lang_String_ == IntPtr.Zero)
					id_OnLicenseReceived_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnLicenseReceived", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLicenseReceived_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class GetLicenseKeyEventArgs : global::System.EventArgs {

			public GetLicenseKeyEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		public partial class LicenseReceivedEventArgs : global::System.EventArgs {

			public LicenseReceivedEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoUser_IRegisterLicenseEventListenerImplementor")]
		internal sealed partial class IRegisterLicenseEventListenerImplementor : global::Java.Lang.Object, IRegisterLicenseEventListener {

			object sender;

			public IRegisterLicenseEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoUser_IRegisterLicenseEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<GetLicenseKeyEventArgs> OnGetLicenseKeyHandler;
#pragma warning restore 0649

			public void OnGetLicenseKey (string p0)
			{
				var __h = OnGetLicenseKeyHandler;
				if (__h != null)
					__h (sender, new GetLicenseKeyEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LicenseReceivedEventArgs> OnLicenseReceivedHandler;
#pragma warning restore 0649

			public void OnLicenseReceived (string p0)
			{
				var __h = OnLicenseReceivedHandler;
				if (__h != null)
					__h (sender, new LicenseReceivedEventArgs (p0));
			}

			internal static bool __IsEmpty (IRegisterLicenseEventListenerImplementor value)
			{
				return value.OnGetLicenseKeyHandler == null && value.OnLicenseReceivedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterRoomEventListener']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterRoomEventListener", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterRoomEventListenerInvoker")]
		public partial interface IRegisterRoomEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.IRegisterRoomEventListener']/method[@name='OnRoomCreatedByInvite' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact'] and parameter[3][@type='java.lang.String']]"
			[Register ("OnRoomCreatedByInvite", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Ljava/lang/String;)V", "GetOnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterRoomEventListenerInvoker, VidyoClientAndroid")]
			void OnRoomCreatedByInvite (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1, string p2);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterRoomEventListener", DoNotGenerateAcw=true)]
		internal class IRegisterRoomEventListenerInvoker : global::Java.Lang.Object, IRegisterRoomEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterRoomEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegisterRoomEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IRegisterRoomEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterRoomEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterRoomEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterRoomEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_Handler ()
			{
				if (cb_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_ == null)
					cb_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_);
				return cb_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_;
			}

			static void n_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterRoomEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterRoomEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomCreatedByInvite (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_;
			public unsafe void OnRoomCreatedByInvite (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1, string p2)
			{
				if (id_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_ == IntPtr.Zero)
					id_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnRoomCreatedByInvite", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Ljava/lang/String;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}

		public partial class RegisterRoomEventEventArgs : global::System.EventArgs {

			public RegisterRoomEventEventArgs (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1, string p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom P0 {
				get { return p0; }
			}

			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1;
			public global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact P1 {
				get { return p1; }
			}

			string p2;
			public string P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vidyo/VidyoClient/Endpoint/VidyoUser_IRegisterRoomEventListenerImplementor")]
		internal sealed partial class IRegisterRoomEventListenerImplementor : global::Java.Lang.Object, IRegisterRoomEventListener {

			object sender;

			public IRegisterRoomEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vidyo/VidyoClient/Endpoint/VidyoUser_IRegisterRoomEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RegisterRoomEventEventArgs> Handler;
#pragma warning restore 0649

			public void OnRoomCreatedByInvite (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1, string p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RegisterRoomEventEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IRegisterRoomEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchConversationRooms']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchConversationRooms", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchConversationRoomsInvoker")]
		public partial interface ISearchConversationRooms : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchConversationRooms']/method[@name='OnRoomSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;'] and parameter[4][@type='long']]"
			[Register ("OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchConversationRoomsInvoker, VidyoClientAndroid")]
			void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchConversationRooms", DoNotGenerateAcw=true)]
		internal class ISearchConversationRoomsInvoker : global::Java.Lang.Object, ISearchConversationRooms {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchConversationRooms");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISearchConversationRoomsInvoker); }
			}

			IntPtr class_ref;

			public static ISearchConversationRooms GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISearchConversationRooms> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ISearchConversationRooms"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISearchConversationRoomsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
			static Delegate GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
			{
				if (cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
					cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
				return cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			}

			static void n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchConversationRooms __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchConversationRooms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomSearchResults (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			public unsafe void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3)
			{
				if (id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
					id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchRooms']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRooms", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchRoomsInvoker")]
		public partial interface ISearchRooms : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchRooms']/method[@name='OnRoomSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;'] and parameter[4][@type='long']]"
			[Register ("OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchRoomsInvoker, VidyoClientAndroid")]
			void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRooms", DoNotGenerateAcw=true)]
		internal class ISearchRoomsInvoker : global::Java.Lang.Object, ISearchRooms {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRooms");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISearchRoomsInvoker); }
			}

			IntPtr class_ref;

			public static ISearchRooms GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISearchRooms> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRooms"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISearchRoomsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
			static Delegate GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
			{
				if (cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
					cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
				return cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			}

			static void n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRooms __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRooms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomSearchResults (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			public unsafe void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3)
			{
				if (id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
					id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchRoomsWithName']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRoomsWithName", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchRoomsWithNameInvoker")]
		public partial interface ISearchRoomsWithName : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchRoomsWithName']/method[@name='OnRoomSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;'] and parameter[4][@type='long']]"
			[Register ("OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchRoomsWithNameInvoker, VidyoClientAndroid")]
			void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRoomsWithName", DoNotGenerateAcw=true)]
		internal class ISearchRoomsWithNameInvoker : global::Java.Lang.Object, ISearchRoomsWithName {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRoomsWithName");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISearchRoomsWithNameInvoker); }
			}

			IntPtr class_ref;

			public static ISearchRoomsWithName GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISearchRoomsWithName> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRoomsWithName"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISearchRoomsWithNameInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
			static Delegate GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
			{
				if (cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
					cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
				return cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			}

			static void n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRoomsWithName __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRoomsWithName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomSearchResults (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			public unsafe void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3)
			{
				if (id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
					id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchRoomsWithOwner']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRoomsWithOwner", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchRoomsWithOwnerInvoker")]
		public partial interface ISearchRoomsWithOwner : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchRoomsWithOwner']/method[@name='OnRoomSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;'] and parameter[4][@type='long']]"
			[Register ("OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchRoomsWithOwnerInvoker, VidyoClientAndroid")]
			void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRoomsWithOwner", DoNotGenerateAcw=true)]
		internal class ISearchRoomsWithOwnerInvoker : global::Java.Lang.Object, ISearchRoomsWithOwner {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRoomsWithOwner");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISearchRoomsWithOwnerInvoker); }
			}

			IntPtr class_ref;

			public static ISearchRoomsWithOwner GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISearchRoomsWithOwner> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRoomsWithOwner"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISearchRoomsWithOwnerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
			static Delegate GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
			{
				if (cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
					cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
				return cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			}

			static void n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRoomsWithOwner __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRoomsWithOwner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomSearchResults (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			public unsafe void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3)
			{
				if (id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
					id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchRoomsWithSubject']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRoomsWithSubject", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchRoomsWithSubjectInvoker")]
		public partial interface ISearchRoomsWithSubject : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchRoomsWithSubject']/method[@name='OnRoomSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;'] and parameter[4][@type='long']]"
			[Register ("OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchRoomsWithSubjectInvoker, VidyoClientAndroid")]
			void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRoomsWithSubject", DoNotGenerateAcw=true)]
		internal class ISearchRoomsWithSubjectInvoker : global::Java.Lang.Object, ISearchRoomsWithSubject {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchRoomsWithSubject");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISearchRoomsWithSubjectInvoker); }
			}

			IntPtr class_ref;

			public static ISearchRoomsWithSubject GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISearchRoomsWithSubject> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRoomsWithSubject"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISearchRoomsWithSubjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
			static Delegate GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
			{
				if (cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
					cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
				return cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			}

			static void n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRoomsWithSubject __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchRoomsWithSubject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomSearchResults (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			public unsafe void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3)
			{
				if (id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
					id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchTopicRooms']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchTopicRooms", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchTopicRoomsInvoker")]
		public partial interface ISearchTopicRooms : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchTopicRooms']/method[@name='OnRoomSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;'] and parameter[4][@type='long']]"
			[Register ("OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchTopicRoomsInvoker, VidyoClientAndroid")]
			void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchTopicRooms", DoNotGenerateAcw=true)]
		internal class ISearchTopicRoomsInvoker : global::Java.Lang.Object, ISearchTopicRooms {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchTopicRooms");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISearchTopicRoomsInvoker); }
			}

			IntPtr class_ref;

			public static ISearchTopicRooms GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISearchTopicRooms> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ISearchTopicRooms"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISearchTopicRoomsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
			static Delegate GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
			{
				if (cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
					cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
				return cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			}

			static void n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchTopicRooms __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchTopicRooms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnRoomSearchResults (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			public unsafe void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3)
			{
				if (id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
					id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchUsers']"
		[Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchUsers", "", "Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchUsersInvoker")]
		public partial interface ISearchUsers : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/interface[@name='VidyoUser.ISearchUsers']/method[@name='OnUserSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoContactInfo&gt;'] and parameter[4][@type='long']]"
			[Register ("OnUserSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/ISearchUsersInvoker, VidyoClientAndroid")]
			void OnUserSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo> p2, long p3);

		}

		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchUsers", DoNotGenerateAcw=true)]
		internal class ISearchUsersInvoker : global::Java.Lang.Object, ISearchUsers {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$ISearchUsers");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISearchUsersInvoker); }
			}

			IntPtr class_ref;

			public static ISearchUsers GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISearchUsers> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vidyo.VidyoClient.Endpoint.VidyoUser.ISearchUsers"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISearchUsersInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
			static Delegate GetOnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
			{
				if (cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
					cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
				return cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			}

			static void n_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
			{
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchUsers __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ISearchUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnUserSearchResults (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
			public unsafe void OnUserSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo> p2, long p3)
			{
				if (id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
					id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnUserSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomSearchField : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMSEARCHFIELD_Admin_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/field[@name='VIDYO_ROOMSEARCHFIELD_Admin']"
			[Register ("VIDYO_ROOMSEARCHFIELD_Admin")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField VIDYOROOMSEARCHFIELDAdmin {
				get {
					if (VIDYO_ROOMSEARCHFIELD_Admin_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELD_Admin_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELD_Admin", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELD_Admin_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHFIELD_Member_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/field[@name='VIDYO_ROOMSEARCHFIELD_Member']"
			[Register ("VIDYO_ROOMSEARCHFIELD_Member")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField VIDYOROOMSEARCHFIELDMember {
				get {
					if (VIDYO_ROOMSEARCHFIELD_Member_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELD_Member_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELD_Member", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELD_Member_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHFIELD_Moderator_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/field[@name='VIDYO_ROOMSEARCHFIELD_Moderator']"
			[Register ("VIDYO_ROOMSEARCHFIELD_Moderator")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField VIDYOROOMSEARCHFIELDModerator {
				get {
					if (VIDYO_ROOMSEARCHFIELD_Moderator_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELD_Moderator_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELD_Moderator", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELD_Moderator_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHFIELD_Name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/field[@name='VIDYO_ROOMSEARCHFIELD_Name']"
			[Register ("VIDYO_ROOMSEARCHFIELD_Name")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField VIDYOROOMSEARCHFIELDName {
				get {
					if (VIDYO_ROOMSEARCHFIELD_Name_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELD_Name_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELD_Name", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELD_Name_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHFIELD_NonMembers_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/field[@name='VIDYO_ROOMSEARCHFIELD_NonMembers']"
			[Register ("VIDYO_ROOMSEARCHFIELD_NonMembers")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField VIDYOROOMSEARCHFIELDNonMembers {
				get {
					if (VIDYO_ROOMSEARCHFIELD_NonMembers_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELD_NonMembers_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELD_NonMembers", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELD_NonMembers_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHFIELD_Owner_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/field[@name='VIDYO_ROOMSEARCHFIELD_Owner']"
			[Register ("VIDYO_ROOMSEARCHFIELD_Owner")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField VIDYOROOMSEARCHFIELDOwner {
				get {
					if (VIDYO_ROOMSEARCHFIELD_Owner_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELD_Owner_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELD_Owner", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELD_Owner_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHFIELD_Public_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/field[@name='VIDYO_ROOMSEARCHFIELD_Public']"
			[Register ("VIDYO_ROOMSEARCHFIELD_Public")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField VIDYOROOMSEARCHFIELDPublic {
				get {
					if (VIDYO_ROOMSEARCHFIELD_Public_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELD_Public_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELD_Public", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELD_Public_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHFIELD_Subject_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/field[@name='VIDYO_ROOMSEARCHFIELD_Subject']"
			[Register ("VIDYO_ROOMSEARCHFIELD_Subject")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField VIDYOROOMSEARCHFIELDSubject {
				get {
					if (VIDYO_ROOMSEARCHFIELD_Subject_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELD_Subject_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELD_Subject", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELD_Subject_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHFIELD_Type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/field[@name='VIDYO_ROOMSEARCHFIELD_Type']"
			[Register ("VIDYO_ROOMSEARCHFIELD_Type")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField VIDYOROOMSEARCHFIELDType {
				get {
					if (VIDYO_ROOMSEARCHFIELD_Type_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELD_Type_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELD_Type", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELD_Type_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHFIELD_User_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/field[@name='VIDYO_ROOMSEARCHFIELD_User']"
			[Register ("VIDYO_ROOMSEARCHFIELD_User")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField VIDYOROOMSEARCHFIELDUser {
				get {
					if (VIDYO_ROOMSEARCHFIELD_User_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELD_User_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELD_User", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELD_User_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomSearchField); }
			}

			internal VidyoRoomSearchField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchField']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchField;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchFieldRelation']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchFieldRelation", DoNotGenerateAcw=true)]
		public sealed partial class VidyoRoomSearchFieldRelation : global::Java.Lang.Enum {


			static IntPtr VIDYO_ROOMSEARCHFIELDRELATION_AND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchFieldRelation']/field[@name='VIDYO_ROOMSEARCHFIELDRELATION_AND']"
			[Register ("VIDYO_ROOMSEARCHFIELDRELATION_AND")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation VidyoRoomsearchfieldrelationAnd {
				get {
					if (VIDYO_ROOMSEARCHFIELDRELATION_AND_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELDRELATION_AND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELDRELATION_AND", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchFieldRelation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELDRELATION_AND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_ROOMSEARCHFIELDRELATION_OR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchFieldRelation']/field[@name='VIDYO_ROOMSEARCHFIELDRELATION_OR']"
			[Register ("VIDYO_ROOMSEARCHFIELDRELATION_OR")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation VidyoRoomsearchfieldrelationOr {
				get {
					if (VIDYO_ROOMSEARCHFIELDRELATION_OR_jfieldId == IntPtr.Zero)
						VIDYO_ROOMSEARCHFIELDRELATION_OR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_ROOMSEARCHFIELDRELATION_OR", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchFieldRelation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_ROOMSEARCHFIELDRELATION_OR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchFieldRelation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoRoomSearchFieldRelation); }
			}

			internal VidyoRoomSearchFieldRelation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchFieldRelation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchFieldRelation;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchFieldRelation;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoRoomSearchFieldRelation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchFieldRelation;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoRoomSearchFieldRelation;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserCallCreateResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoUserCallCreateResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_USERCALLCREATERESULT_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserCallCreateResult']/field[@name='VIDYO_USERCALLCREATERESULT_MiscLocalError']"
			[Register ("VIDYO_USERCALLCREATERESULT_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult VIDYOUSERCALLCREATERESULTMiscLocalError {
				get {
					if (VIDYO_USERCALLCREATERESULT_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_USERCALLCREATERESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCALLCREATERESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCALLCREATERESULT_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERCALLCREATERESULT_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserCallCreateResult']/field[@name='VIDYO_USERCALLCREATERESULT_MiscRemoteError']"
			[Register ("VIDYO_USERCALLCREATERESULT_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult VIDYOUSERCALLCREATERESULTMiscRemoteError {
				get {
					if (VIDYO_USERCALLCREATERESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_USERCALLCREATERESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCALLCREATERESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCALLCREATERESULT_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERCALLCREATERESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserCallCreateResult']/field[@name='VIDYO_USERCALLCREATERESULT_NoResponse']"
			[Register ("VIDYO_USERCALLCREATERESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult VIDYOUSERCALLCREATERESULTNoResponse {
				get {
					if (VIDYO_USERCALLCREATERESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_USERCALLCREATERESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCALLCREATERESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCALLCREATERESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERCALLCREATERESULT_NotAllowed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserCallCreateResult']/field[@name='VIDYO_USERCALLCREATERESULT_NotAllowed']"
			[Register ("VIDYO_USERCALLCREATERESULT_NotAllowed")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult VIDYOUSERCALLCREATERESULTNotAllowed {
				get {
					if (VIDYO_USERCALLCREATERESULT_NotAllowed_jfieldId == IntPtr.Zero)
						VIDYO_USERCALLCREATERESULT_NotAllowed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCALLCREATERESULT_NotAllowed", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCALLCREATERESULT_NotAllowed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERCALLCREATERESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserCallCreateResult']/field[@name='VIDYO_USERCALLCREATERESULT_OK']"
			[Register ("VIDYO_USERCALLCREATERESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult VidyoUsercallcreateresultOk {
				get {
					if (VIDYO_USERCALLCREATERESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_USERCALLCREATERESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCALLCREATERESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCALLCREATERESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoUserCallCreateResult); }
			}

			internal VidyoUserCallCreateResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserCallCreateResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserCallCreateResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserConnectionStatusChangedReason']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason", DoNotGenerateAcw=true)]
		public sealed partial class VidyoUserConnectionStatusChangedReason : global::Java.Lang.Enum {


			static IntPtr VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_ConnectionError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserConnectionStatusChangedReason']/field[@name='VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_ConnectionError']"
			[Register ("VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_ConnectionError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason VIDYOUSERCONNECTIONSTATUSCHANGEDREASONConnectionError {
				get {
					if (VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_ConnectionError_jfieldId == IntPtr.Zero)
						VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_ConnectionError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_ConnectionError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_ConnectionError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_LostContactWithServer_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserConnectionStatusChangedReason']/field[@name='VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_LostContactWithServer']"
			[Register ("VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_LostContactWithServer")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason VIDYOUSERCONNECTIONSTATUSCHANGEDREASONLostContactWithServer {
				get {
					if (VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_LostContactWithServer_jfieldId == IntPtr.Zero)
						VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_LostContactWithServer_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_LostContactWithServer", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_LostContactWithServer_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_MiscNetworkError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserConnectionStatusChangedReason']/field[@name='VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_MiscNetworkError']"
			[Register ("VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_MiscNetworkError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason VIDYOUSERCONNECTIONSTATUSCHANGEDREASONMiscNetworkError {
				get {
					if (VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_MiscNetworkError_jfieldId == IntPtr.Zero)
						VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_MiscNetworkError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_MiscNetworkError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_MiscNetworkError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NetworkInterfaceChanged_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserConnectionStatusChangedReason']/field[@name='VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NetworkInterfaceChanged']"
			[Register ("VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NetworkInterfaceChanged")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason VIDYOUSERCONNECTIONSTATUSCHANGEDREASONNetworkInterfaceChanged {
				get {
					if (VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NetworkInterfaceChanged_jfieldId == IntPtr.Zero)
						VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NetworkInterfaceChanged_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NetworkInterfaceChanged", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NetworkInterfaceChanged_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoCommunicationWithServer_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserConnectionStatusChangedReason']/field[@name='VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoCommunicationWithServer']"
			[Register ("VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoCommunicationWithServer")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason VIDYOUSERCONNECTIONSTATUSCHANGEDREASONNoCommunicationWithServer {
				get {
					if (VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoCommunicationWithServer_jfieldId == IntPtr.Zero)
						VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoCommunicationWithServer_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoCommunicationWithServer", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoCommunicationWithServer_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoValidNetworkInterfaces_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserConnectionStatusChangedReason']/field[@name='VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoValidNetworkInterfaces']"
			[Register ("VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoValidNetworkInterfaces")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason VIDYOUSERCONNECTIONSTATUSCHANGEDREASONNoValidNetworkInterfaces {
				get {
					if (VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoValidNetworkInterfaces_jfieldId == IntPtr.Zero)
						VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoValidNetworkInterfaces_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoValidNetworkInterfaces", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_NoValidNetworkInterfaces_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserConnectionStatusChangedReason']/field[@name='VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_OK']"
			[Register ("VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason VidyoUserconnectionstatuschangedreasonOk {
				get {
					if (VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_OK_jfieldId == IntPtr.Zero)
						VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERCONNECTIONSTATUSCHANGEDREASON_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoUserConnectionStatusChangedReason); }
			}

			internal VidyoUserConnectionStatusChangedReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserConnectionStatusChangedReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserConnectionStatusChangedReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserGetContactResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoUserGetContactResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_USERGETCONTACTRESULT_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserGetContactResult']/field[@name='VIDYO_USERGETCONTACTRESULT_MiscLocalError']"
			[Register ("VIDYO_USERGETCONTACTRESULT_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult VIDYOUSERGETCONTACTRESULTMiscLocalError {
				get {
					if (VIDYO_USERGETCONTACTRESULT_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_USERGETCONTACTRESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERGETCONTACTRESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERGETCONTACTRESULT_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERGETCONTACTRESULT_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserGetContactResult']/field[@name='VIDYO_USERGETCONTACTRESULT_MiscRemoteError']"
			[Register ("VIDYO_USERGETCONTACTRESULT_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult VIDYOUSERGETCONTACTRESULTMiscRemoteError {
				get {
					if (VIDYO_USERGETCONTACTRESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_USERGETCONTACTRESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERGETCONTACTRESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERGETCONTACTRESULT_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERGETCONTACTRESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserGetContactResult']/field[@name='VIDYO_USERGETCONTACTRESULT_NoResponse']"
			[Register ("VIDYO_USERGETCONTACTRESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult VIDYOUSERGETCONTACTRESULTNoResponse {
				get {
					if (VIDYO_USERGETCONTACTRESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_USERGETCONTACTRESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERGETCONTACTRESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERGETCONTACTRESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERGETCONTACTRESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserGetContactResult']/field[@name='VIDYO_USERGETCONTACTRESULT_OK']"
			[Register ("VIDYO_USERGETCONTACTRESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult VidyoUsergetcontactresultOk {
				get {
					if (VIDYO_USERGETCONTACTRESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_USERGETCONTACTRESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERGETCONTACTRESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERGETCONTACTRESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERGETCONTACTRESULT_Unauthorized_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserGetContactResult']/field[@name='VIDYO_USERGETCONTACTRESULT_Unauthorized']"
			[Register ("VIDYO_USERGETCONTACTRESULT_Unauthorized")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult VIDYOUSERGETCONTACTRESULTUnauthorized {
				get {
					if (VIDYO_USERGETCONTACTRESULT_Unauthorized_jfieldId == IntPtr.Zero)
						VIDYO_USERGETCONTACTRESULT_Unauthorized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERGETCONTACTRESULT_Unauthorized", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERGETCONTACTRESULT_Unauthorized_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoUserGetContactResult); }
			}

			internal VidyoUserGetContactResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserGetContactResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserGetContactResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoUserLoginResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_USERLOGINRESULT_Cancelled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_Cancelled']"
			[Register ("VIDYO_USERLOGINRESULT_Cancelled")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTCancelled {
				get {
					if (VIDYO_USERLOGINRESULT_Cancelled_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_Cancelled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_Cancelled", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_Cancelled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_ConnectionFailed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_ConnectionFailed']"
			[Register ("VIDYO_USERLOGINRESULT_ConnectionFailed")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTConnectionFailed {
				get {
					if (VIDYO_USERLOGINRESULT_ConnectionFailed_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_ConnectionFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_ConnectionFailed", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_ConnectionFailed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_ConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_ConnectionLost']"
			[Register ("VIDYO_USERLOGINRESULT_ConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTConnectionLost {
				get {
					if (VIDYO_USERLOGINRESULT_ConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_ConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_ConnectionLost", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_ConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_ConnectionTimeout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_ConnectionTimeout']"
			[Register ("VIDYO_USERLOGINRESULT_ConnectionTimeout")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTConnectionTimeout {
				get {
					if (VIDYO_USERLOGINRESULT_ConnectionTimeout_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_ConnectionTimeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_ConnectionTimeout", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_ConnectionTimeout_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_InvalidPassword_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_InvalidPassword']"
			[Register ("VIDYO_USERLOGINRESULT_InvalidPassword")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTInvalidPassword {
				get {
					if (VIDYO_USERLOGINRESULT_InvalidPassword_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_InvalidPassword_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_InvalidPassword", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_InvalidPassword_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_InvalidUser_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_InvalidUser']"
			[Register ("VIDYO_USERLOGINRESULT_InvalidUser")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTInvalidUser {
				get {
					if (VIDYO_USERLOGINRESULT_InvalidUser_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_InvalidUser_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_InvalidUser", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_InvalidUser_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_MiscAuthError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_MiscAuthError']"
			[Register ("VIDYO_USERLOGINRESULT_MiscAuthError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTMiscAuthError {
				get {
					if (VIDYO_USERLOGINRESULT_MiscAuthError_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_MiscAuthError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_MiscAuthError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_MiscAuthError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_MiscError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_MiscError']"
			[Register ("VIDYO_USERLOGINRESULT_MiscError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTMiscError {
				get {
					if (VIDYO_USERLOGINRESULT_MiscError_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_MiscError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_MiscError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_MiscError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_NoResponse']"
			[Register ("VIDYO_USERLOGINRESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTNoResponse {
				get {
					if (VIDYO_USERLOGINRESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_OK']"
			[Register ("VIDYO_USERLOGINRESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VidyoUserloginresultOk {
				get {
					if (VIDYO_USERLOGINRESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_Terminated_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_Terminated']"
			[Register ("VIDYO_USERLOGINRESULT_Terminated")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTTerminated {
				get {
					if (VIDYO_USERLOGINRESULT_Terminated_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_Terminated_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_Terminated", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_Terminated_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGINRESULT_WebProxyAuthenticationRequired_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/field[@name='VIDYO_USERLOGINRESULT_WebProxyAuthenticationRequired']"
			[Register ("VIDYO_USERLOGINRESULT_WebProxyAuthenticationRequired")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult VIDYOUSERLOGINRESULTWebProxyAuthenticationRequired {
				get {
					if (VIDYO_USERLOGINRESULT_WebProxyAuthenticationRequired_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGINRESULT_WebProxyAuthenticationRequired_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGINRESULT_WebProxyAuthenticationRequired", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGINRESULT_WebProxyAuthenticationRequired_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoUserLoginResult); }
			}

			internal VidyoUserLoginResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLoginResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLogoutReason']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason", DoNotGenerateAcw=true)]
		public sealed partial class VidyoUserLogoutReason : global::Java.Lang.Enum {


			static IntPtr VIDYO_USERLOGOUTREASON_ConnectionLost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLogoutReason']/field[@name='VIDYO_USERLOGOUTREASON_ConnectionLost']"
			[Register ("VIDYO_USERLOGOUTREASON_ConnectionLost")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason VIDYOUSERLOGOUTREASONConnectionLost {
				get {
					if (VIDYO_USERLOGOUTREASON_ConnectionLost_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGOUTREASON_ConnectionLost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGOUTREASON_ConnectionLost", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGOUTREASON_ConnectionLost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGOUTREASON_ConnectionTimeout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLogoutReason']/field[@name='VIDYO_USERLOGOUTREASON_ConnectionTimeout']"
			[Register ("VIDYO_USERLOGOUTREASON_ConnectionTimeout")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason VIDYOUSERLOGOUTREASONConnectionTimeout {
				get {
					if (VIDYO_USERLOGOUTREASON_ConnectionTimeout_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGOUTREASON_ConnectionTimeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGOUTREASON_ConnectionTimeout", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGOUTREASON_ConnectionTimeout_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGOUTREASON_LoggedOut_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLogoutReason']/field[@name='VIDYO_USERLOGOUTREASON_LoggedOut']"
			[Register ("VIDYO_USERLOGOUTREASON_LoggedOut")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason VIDYOUSERLOGOUTREASONLoggedOut {
				get {
					if (VIDYO_USERLOGOUTREASON_LoggedOut_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGOUTREASON_LoggedOut_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGOUTREASON_LoggedOut", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGOUTREASON_LoggedOut_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGOUTREASON_MiscError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLogoutReason']/field[@name='VIDYO_USERLOGOUTREASON_MiscError']"
			[Register ("VIDYO_USERLOGOUTREASON_MiscError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason VIDYOUSERLOGOUTREASONMiscError {
				get {
					if (VIDYO_USERLOGOUTREASON_MiscError_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGOUTREASON_MiscError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGOUTREASON_MiscError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGOUTREASON_MiscError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGOUTREASON_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLogoutReason']/field[@name='VIDYO_USERLOGOUTREASON_NoResponse']"
			[Register ("VIDYO_USERLOGOUTREASON_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason VIDYOUSERLOGOUTREASONNoResponse {
				get {
					if (VIDYO_USERLOGOUTREASON_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGOUTREASON_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGOUTREASON_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGOUTREASON_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERLOGOUTREASON_Terminated_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLogoutReason']/field[@name='VIDYO_USERLOGOUTREASON_Terminated']"
			[Register ("VIDYO_USERLOGOUTREASON_Terminated")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason VIDYOUSERLOGOUTREASONTerminated {
				get {
					if (VIDYO_USERLOGOUTREASON_Terminated_jfieldId == IntPtr.Zero)
						VIDYO_USERLOGOUTREASON_Terminated_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERLOGOUTREASON_Terminated", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERLOGOUTREASON_Terminated_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoUserLogoutReason); }
			}

			internal VidyoUserLogoutReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLogoutReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserLogoutReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserRoomCreateResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoUserRoomCreateResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_USERROOMCREATERESULT_DuplicateName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserRoomCreateResult']/field[@name='VIDYO_USERROOMCREATERESULT_DuplicateName']"
			[Register ("VIDYO_USERROOMCREATERESULT_DuplicateName")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult VIDYOUSERROOMCREATERESULTDuplicateName {
				get {
					if (VIDYO_USERROOMCREATERESULT_DuplicateName_jfieldId == IntPtr.Zero)
						VIDYO_USERROOMCREATERESULT_DuplicateName_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERROOMCREATERESULT_DuplicateName", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERROOMCREATERESULT_DuplicateName_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERROOMCREATERESULT_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserRoomCreateResult']/field[@name='VIDYO_USERROOMCREATERESULT_MiscLocalError']"
			[Register ("VIDYO_USERROOMCREATERESULT_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult VIDYOUSERROOMCREATERESULTMiscLocalError {
				get {
					if (VIDYO_USERROOMCREATERESULT_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_USERROOMCREATERESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERROOMCREATERESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERROOMCREATERESULT_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERROOMCREATERESULT_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserRoomCreateResult']/field[@name='VIDYO_USERROOMCREATERESULT_MiscRemoteError']"
			[Register ("VIDYO_USERROOMCREATERESULT_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult VIDYOUSERROOMCREATERESULTMiscRemoteError {
				get {
					if (VIDYO_USERROOMCREATERESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_USERROOMCREATERESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERROOMCREATERESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERROOMCREATERESULT_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERROOMCREATERESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserRoomCreateResult']/field[@name='VIDYO_USERROOMCREATERESULT_NoResponse']"
			[Register ("VIDYO_USERROOMCREATERESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult VIDYOUSERROOMCREATERESULTNoResponse {
				get {
					if (VIDYO_USERROOMCREATERESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_USERROOMCREATERESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERROOMCREATERESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERROOMCREATERESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERROOMCREATERESULT_NotFound_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserRoomCreateResult']/field[@name='VIDYO_USERROOMCREATERESULT_NotFound']"
			[Register ("VIDYO_USERROOMCREATERESULT_NotFound")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult VIDYOUSERROOMCREATERESULTNotFound {
				get {
					if (VIDYO_USERROOMCREATERESULT_NotFound_jfieldId == IntPtr.Zero)
						VIDYO_USERROOMCREATERESULT_NotFound_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERROOMCREATERESULT_NotFound", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERROOMCREATERESULT_NotFound_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERROOMCREATERESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserRoomCreateResult']/field[@name='VIDYO_USERROOMCREATERESULT_OK']"
			[Register ("VIDYO_USERROOMCREATERESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult VidyoUserroomcreateresultOk {
				get {
					if (VIDYO_USERROOMCREATERESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_USERROOMCREATERESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERROOMCREATERESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERROOMCREATERESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERROOMCREATERESULT_Unauthorized_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserRoomCreateResult']/field[@name='VIDYO_USERROOMCREATERESULT_Unauthorized']"
			[Register ("VIDYO_USERROOMCREATERESULT_Unauthorized")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult VIDYOUSERROOMCREATERESULTUnauthorized {
				get {
					if (VIDYO_USERROOMCREATERESULT_Unauthorized_jfieldId == IntPtr.Zero)
						VIDYO_USERROOMCREATERESULT_Unauthorized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERROOMCREATERESULT_Unauthorized", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERROOMCREATERESULT_Unauthorized_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoUserRoomCreateResult); }
			}

			internal VidyoUserRoomCreateResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserRoomCreateResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserRoomCreateResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchField']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchField", DoNotGenerateAcw=true)]
		public sealed partial class VidyoUserSearchField : global::Java.Lang.Enum {


			static IntPtr VIDYO_USERSEARCHFIELD_EMAIL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchField']/field[@name='VIDYO_USERSEARCHFIELD_EMAIL']"
			[Register ("VIDYO_USERSEARCHFIELD_EMAIL")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField VidyoUsersearchfieldEmail {
				get {
					if (VIDYO_USERSEARCHFIELD_EMAIL_jfieldId == IntPtr.Zero)
						VIDYO_USERSEARCHFIELD_EMAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSEARCHFIELD_EMAIL", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSEARCHFIELD_EMAIL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERSEARCHFIELD_NAME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchField']/field[@name='VIDYO_USERSEARCHFIELD_NAME']"
			[Register ("VIDYO_USERSEARCHFIELD_NAME")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField VidyoUsersearchfieldName {
				get {
					if (VIDYO_USERSEARCHFIELD_NAME_jfieldId == IntPtr.Zero)
						VIDYO_USERSEARCHFIELD_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSEARCHFIELD_NAME", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSEARCHFIELD_NAME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERSEARCHFIELD_TELNO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchField']/field[@name='VIDYO_USERSEARCHFIELD_TELNO']"
			[Register ("VIDYO_USERSEARCHFIELD_TELNO")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField VidyoUsersearchfieldTelno {
				get {
					if (VIDYO_USERSEARCHFIELD_TELNO_jfieldId == IntPtr.Zero)
						VIDYO_USERSEARCHFIELD_TELNO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSEARCHFIELD_TELNO", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSEARCHFIELD_TELNO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERSEARCHFIELD_UID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchField']/field[@name='VIDYO_USERSEARCHFIELD_UID']"
			[Register ("VIDYO_USERSEARCHFIELD_UID")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField VidyoUsersearchfieldUid {
				get {
					if (VIDYO_USERSEARCHFIELD_UID_jfieldId == IntPtr.Zero)
						VIDYO_USERSEARCHFIELD_UID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSEARCHFIELD_UID", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchField;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSEARCHFIELD_UID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchField", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoUserSearchField); }
			}

			internal VidyoUserSearchField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchField']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchField;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchField;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchField']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchField;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchField;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchResult']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult", DoNotGenerateAcw=true)]
		public sealed partial class VidyoUserSearchResult : global::Java.Lang.Enum {


			static IntPtr VIDYO_USERSEARCHRESULT_MiscLocalError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchResult']/field[@name='VIDYO_USERSEARCHRESULT_MiscLocalError']"
			[Register ("VIDYO_USERSEARCHRESULT_MiscLocalError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult VIDYOUSERSEARCHRESULTMiscLocalError {
				get {
					if (VIDYO_USERSEARCHRESULT_MiscLocalError_jfieldId == IntPtr.Zero)
						VIDYO_USERSEARCHRESULT_MiscLocalError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSEARCHRESULT_MiscLocalError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSEARCHRESULT_MiscLocalError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERSEARCHRESULT_MiscRemoteError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchResult']/field[@name='VIDYO_USERSEARCHRESULT_MiscRemoteError']"
			[Register ("VIDYO_USERSEARCHRESULT_MiscRemoteError")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult VIDYOUSERSEARCHRESULTMiscRemoteError {
				get {
					if (VIDYO_USERSEARCHRESULT_MiscRemoteError_jfieldId == IntPtr.Zero)
						VIDYO_USERSEARCHRESULT_MiscRemoteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSEARCHRESULT_MiscRemoteError", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSEARCHRESULT_MiscRemoteError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERSEARCHRESULT_NoRecords_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchResult']/field[@name='VIDYO_USERSEARCHRESULT_NoRecords']"
			[Register ("VIDYO_USERSEARCHRESULT_NoRecords")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult VIDYOUSERSEARCHRESULTNoRecords {
				get {
					if (VIDYO_USERSEARCHRESULT_NoRecords_jfieldId == IntPtr.Zero)
						VIDYO_USERSEARCHRESULT_NoRecords_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSEARCHRESULT_NoRecords", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSEARCHRESULT_NoRecords_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERSEARCHRESULT_NoResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchResult']/field[@name='VIDYO_USERSEARCHRESULT_NoResponse']"
			[Register ("VIDYO_USERSEARCHRESULT_NoResponse")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult VIDYOUSERSEARCHRESULTNoResponse {
				get {
					if (VIDYO_USERSEARCHRESULT_NoResponse_jfieldId == IntPtr.Zero)
						VIDYO_USERSEARCHRESULT_NoResponse_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSEARCHRESULT_NoResponse", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSEARCHRESULT_NoResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERSEARCHRESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchResult']/field[@name='VIDYO_USERSEARCHRESULT_OK']"
			[Register ("VIDYO_USERSEARCHRESULT_OK")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult VidyoUsersearchresultOk {
				get {
					if (VIDYO_USERSEARCHRESULT_OK_jfieldId == IntPtr.Zero)
						VIDYO_USERSEARCHRESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSEARCHRESULT_OK", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSEARCHRESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoUserSearchResult); }
			}

			internal VidyoUserSearchResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserSearchResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserState']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserState", DoNotGenerateAcw=true)]
		public sealed partial class VidyoUserState : global::Java.Lang.Enum {


			static IntPtr VIDYO_USERSTATE_Idle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserState']/field[@name='VIDYO_USERSTATE_Idle']"
			[Register ("VIDYO_USERSTATE_Idle")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState VIDYOUSERSTATEIdle {
				get {
					if (VIDYO_USERSTATE_Idle_jfieldId == IntPtr.Zero)
						VIDYO_USERSTATE_Idle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSTATE_Idle", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSTATE_Idle_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERSTATE_LoggedIn_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserState']/field[@name='VIDYO_USERSTATE_LoggedIn']"
			[Register ("VIDYO_USERSTATE_LoggedIn")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState VIDYOUSERSTATELoggedIn {
				get {
					if (VIDYO_USERSTATE_LoggedIn_jfieldId == IntPtr.Zero)
						VIDYO_USERSTATE_LoggedIn_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSTATE_LoggedIn", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSTATE_LoggedIn_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERSTATE_LoggingIn_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserState']/field[@name='VIDYO_USERSTATE_LoggingIn']"
			[Register ("VIDYO_USERSTATE_LoggingIn")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState VIDYOUSERSTATELoggingIn {
				get {
					if (VIDYO_USERSTATE_LoggingIn_jfieldId == IntPtr.Zero)
						VIDYO_USERSTATE_LoggingIn_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSTATE_LoggingIn", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSTATE_LoggingIn_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERSTATE_Reconnecting_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserState']/field[@name='VIDYO_USERSTATE_Reconnecting']"
			[Register ("VIDYO_USERSTATE_Reconnecting")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState VIDYOUSERSTATEReconnecting {
				get {
					if (VIDYO_USERSTATE_Reconnecting_jfieldId == IntPtr.Zero)
						VIDYO_USERSTATE_Reconnecting_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERSTATE_Reconnecting", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERSTATE_Reconnecting_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoUserState); }
			}

			internal VidyoUserState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserState;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserState;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserTokenType']"
		[global::Android.Runtime.Register ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType", DoNotGenerateAcw=true)]
		public sealed partial class VidyoUserTokenType : global::Java.Lang.Enum {


			static IntPtr VIDYO_USERTOKENTYPE_AccessToken_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserTokenType']/field[@name='VIDYO_USERTOKENTYPE_AccessToken']"
			[Register ("VIDYO_USERTOKENTYPE_AccessToken")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType VIDYOUSERTOKENTYPEAccessToken {
				get {
					if (VIDYO_USERTOKENTYPE_AccessToken_jfieldId == IntPtr.Zero)
						VIDYO_USERTOKENTYPE_AccessToken_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERTOKENTYPE_AccessToken", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERTOKENTYPE_AccessToken_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDYO_USERTOKENTYPE_RefreshToken_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserTokenType']/field[@name='VIDYO_USERTOKENTYPE_RefreshToken']"
			[Register ("VIDYO_USERTOKENTYPE_RefreshToken")]
			public static global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType VIDYOUSERTOKENTYPERefreshToken {
				get {
					if (VIDYO_USERTOKENTYPE_RefreshToken_jfieldId == IntPtr.Zero)
						VIDYO_USERTOKENTYPE_RefreshToken_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDYO_USERTOKENTYPE_RefreshToken", "Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDYO_USERTOKENTYPE_RefreshToken_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VidyoUserTokenType); }
			}

			internal VidyoUserTokenType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserTokenType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType __ret = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser.VidyoUserTokenType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;", "")]
			public static unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;");
				try {
					return (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/Endpoint/VidyoUser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoUser); }
		}

		protected VidyoUser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/constructor[@name='VidyoUser' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VidyoUser (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoUser)) {
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

		static IntPtr id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/constructor[@name='VidyoUser' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoEndpoint']]"
		[Register (".ctor", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;)V", "")]
		public unsafe VidyoUser (global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VidyoUser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;)V", __args);
					return;
				}

				if (id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ == IntPtr.Zero)
					id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vidyo_VidyoClient_Endpoint_VidyoEndpoint_, __args);
			} finally {
			}
		}

		static Delegate cb_GetEndpoint;
#pragma warning disable 0169
		static Delegate GetGetEndpointHandler ()
		{
			if (cb_GetEndpoint == null)
				cb_GetEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndpoint);
			return cb_GetEndpoint;
		}

		static IntPtr n_GetEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Endpoint);
		}
#pragma warning restore 0169

		static IntPtr id_GetEndpoint;
		public virtual unsafe global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint Endpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='GetEndpoint' and count(parameter)=0]"
			[Register ("GetEndpoint", "()Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;", "GetGetEndpointHandler")]
			get {
				if (id_GetEndpoint == IntPtr.Zero)
					id_GetEndpoint = JNIEnv.GetMethodID (class_ref, "GetEndpoint", "()Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetEndpoint), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetEndpoint", "()Lcom/vidyo/VidyoClient/Endpoint/VidyoEndpoint;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='GetId' and count(parameter)=0]"
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPtr;
		}
#pragma warning restore 0169

		static IntPtr id_GetObjectPtr;
		public virtual unsafe long ObjectPtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='GetObjectPtr' and count(parameter)=0]"
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

		static Delegate cb_AddRosterContact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddRosterContact_Ljava_lang_String_Handler ()
		{
			if (cb_AddRosterContact_Ljava_lang_String_ == null)
				cb_AddRosterContact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddRosterContact_Ljava_lang_String_);
			return cb_AddRosterContact_Ljava_lang_String_;
		}

		static bool n_AddRosterContact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddRosterContact (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddRosterContact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='AddRosterContact' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("AddRosterContact", "(Ljava/lang/String;)Z", "GetAddRosterContact_Ljava_lang_String_Handler")]
		public virtual unsafe bool AddRosterContact (string p0)
		{
			if (id_AddRosterContact_Ljava_lang_String_ == IntPtr.Zero)
				id_AddRosterContact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "AddRosterContact", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AddRosterContact_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddRosterContact", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_AdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
#pragma warning disable 0169
		static Delegate GetAdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler ()
		{
			if (cb_AdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == null)
				cb_AdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_AdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_);
			return cb_AdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		}

		static bool n_AdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, int p5, IntPtr native_p6)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p6 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms> (native_p6, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AdvancedSearchRooms (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='AdvancedSearchRooms' and count(parameter)=7 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField&gt;'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation&gt;'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.String&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms']]"
		[Register ("AdvancedSearchRooms", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z", "GetAdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler")]
		public virtual unsafe bool AdvancedSearchRooms (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField> p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation> p1, global::System.Collections.Generic.IList<string> p2, string p3, int p4, int p5, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p6)
		{
			if (id_AdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == IntPtr.Zero)
				id_AdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNIEnv.GetMethodID (class_ref, "AdvancedSearchRooms", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchField>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoRoomSearchFieldRelation>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AdvancedSearchRooms_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AdvancedSearchRooms", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_AdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_;
#pragma warning disable 0169
		static Delegate GetAdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_Handler ()
		{
			if (cb_AdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_ == null)
				cb_AdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_AdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_);
			return cb_AdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_;
		}

		static bool n_AdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers p5 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers> (native_p5, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AdvancedSearchUsers (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='AdvancedSearchUsers' and count(parameter)=6 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField&gt;'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.String&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers']]"
		[Register ("AdvancedSearchUsers", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchUsers;)Z", "GetAdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_Handler")]
		public virtual unsafe bool AdvancedSearchUsers (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField> p0, global::System.Collections.Generic.IList<string> p1, string p2, int p3, int p4, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers p5)
		{
			if (id_AdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_ == IntPtr.Zero)
				id_AdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_ = JNIEnv.GetMethodID (class_ref, "AdvancedSearchUsers", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchUsers;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchField>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AdvancedSearchUsers_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AdvancedSearchUsers", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchUsers;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_AllowSubscriber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAllowSubscriber_Ljava_lang_String_Handler ()
		{
			if (cb_AllowSubscriber_Ljava_lang_String_ == null)
				cb_AllowSubscriber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AllowSubscriber_Ljava_lang_String_);
			return cb_AllowSubscriber_Ljava_lang_String_;
		}

		static bool n_AllowSubscriber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AllowSubscriber (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AllowSubscriber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='AllowSubscriber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("AllowSubscriber", "(Ljava/lang/String;)Z", "GetAllowSubscriber_Ljava_lang_String_Handler")]
		public virtual unsafe bool AllowSubscriber (string p0)
		{
			if (id_AllowSubscriber_Ljava_lang_String_ == IntPtr.Zero)
				id_AllowSubscriber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "AllowSubscriber", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_AllowSubscriber_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AllowSubscriber", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_BlockSubscriber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBlockSubscriber_Ljava_lang_String_Handler ()
		{
			if (cb_BlockSubscriber_Ljava_lang_String_ == null)
				cb_BlockSubscriber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_BlockSubscriber_Ljava_lang_String_);
			return cb_BlockSubscriber_Ljava_lang_String_;
		}

		static bool n_BlockSubscriber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BlockSubscriber (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_BlockSubscriber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='BlockSubscriber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("BlockSubscriber", "(Ljava/lang/String;)Z", "GetBlockSubscriber_Ljava_lang_String_Handler")]
		public virtual unsafe bool BlockSubscriber (string p0)
		{
			if (id_BlockSubscriber_Ljava_lang_String_ == IntPtr.Zero)
				id_BlockSubscriber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "BlockSubscriber", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_BlockSubscriber_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "BlockSubscriber", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_CreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_;
#pragma warning disable 0169
		static Delegate GetCreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_Handler ()
		{
			if (cb_CreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_ == null)
				cb_CreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_);
			return cb_CreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_;
		}

		static bool n_CreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateCall p2 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateCall)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateCall> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CreateCall (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='CreateCall' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.ICreateCall']]"
		[Register ("CreateCall", "(Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateCall;)Z", "GetCreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_Handler")]
		public virtual unsafe bool CreateCall (string p0, string p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateCall p2)
		{
			if (id_CreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_ == IntPtr.Zero)
				id_CreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_ = JNIEnv.GetMethodID (class_ref, "CreateCall", "(Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateCall;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CreateCall_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateCall_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateCall", "(Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateCall;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_CreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
#pragma warning disable 0169
		static Delegate GetCreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_Handler ()
		{
			if (cb_CreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ == null)
				cb_CreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_);
			return cb_CreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
		}

		static bool n_CreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId p2 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CreateRoomFromId (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='CreateRoomFromId' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId']]"
		[Register ("CreateRoomFromId", "(Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z", "GetCreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_Handler")]
		public virtual unsafe bool CreateRoomFromId (string p0, string p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId p2)
		{
			if (id_CreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ == IntPtr.Zero)
				id_CreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ = JNIEnv.GetMethodID (class_ref, "CreateRoomFromId", "(Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CreateRoomFromId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateRoomFromId", "(Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_CreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
#pragma warning disable 0169
		static Delegate GetCreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_Handler ()
		{
			if (cb_CreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ == null)
				cb_CreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_);
			return cb_CreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
		}

		static bool n_CreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId p2 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CreateRoomWithId (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='CreateRoomWithId' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId']]"
		[Register ("CreateRoomWithId", "(Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z", "GetCreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_Handler")]
		public virtual unsafe bool CreateRoomWithId (string p0, string p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId p2)
		{
			if (id_CreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ == IntPtr.Zero)
				id_CreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ = JNIEnv.GetMethodID (class_ref, "CreateRoomWithId", "(Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CreateRoomWithId_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateRoomWithId", "(Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_CreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
#pragma warning disable 0169
		static Delegate GetCreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_Handler ()
		{
			if (cb_CreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ == null)
				cb_CreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_);
			return cb_CreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
		}

		static bool n_CreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CreateTopicRoom (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='CreateTopicRoom' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId']]"
		[Register ("CreateTopicRoom", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z", "GetCreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_Handler")]
		public virtual unsafe bool CreateTopicRoom (string p0, string p1, string p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId p3)
		{
			if (id_CreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ == IntPtr.Zero)
				id_CreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ = JNIEnv.GetMethodID (class_ref, "CreateTopicRoom", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_CreateTopicRoom_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateTopicRoom", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_GetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_;
#pragma warning disable 0169
		static Delegate GetGetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_Handler ()
		{
			if (cb_GetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_ == null)
				cb_GetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_GetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_);
			return cb_GetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_;
		}

		static bool n_GetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetContact p1 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetContact)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetContact> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetContact (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='GetContact' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IGetContact']]"
		[Register ("GetContact", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IGetContact;)Z", "GetGetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_Handler")]
		public virtual unsafe bool GetContact (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetContact p1)
		{
			if (id_GetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_ == IntPtr.Zero)
				id_GetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_ = JNIEnv.GetMethodID (class_ref, "GetContact", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IGetContact;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetContact_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetContact_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetContact", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IGetContact;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
#pragma warning disable 0169
		static Delegate GetGetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_Handler ()
		{
			if (cb_GetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ == null)
				cb_GetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_GetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_);
			return cb_GetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
		}

		static bool n_GetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId p2 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetConversationRoom (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='GetConversationRoom' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId']]"
		[Register ("GetConversationRoom", "(Ljava/util/ArrayList;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z", "GetGetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_Handler")]
		public virtual unsafe bool GetConversationRoom (global::System.Collections.Generic.IList<string> p0, string p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ICreateRoomFromId p2)
		{
			if (id_GetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ == IntPtr.Zero)
				id_GetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_ = JNIEnv.GetMethodID (class_ref, "GetConversationRoom", "(Ljava/util/ArrayList;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetConversationRoom_Ljava_util_ArrayList_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ICreateRoomFromId_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetConversationRoom", "(Ljava/util/ArrayList;Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ICreateRoomFromId;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_GetCurrentRoster_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetCurrentRoster_Ljava_util_ArrayList_Handler ()
		{
			if (cb_GetCurrentRoster_Ljava_util_ArrayList_ == null)
				cb_GetCurrentRoster_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetCurrentRoster_Ljava_util_ArrayList_);
			return cb_GetCurrentRoster_Ljava_util_ArrayList_;
		}

		static bool n_GetCurrentRoster_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetCurrentRoster (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetCurrentRoster_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='GetCurrentRoster' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoContact&gt;']]"
		[Register ("GetCurrentRoster", "(Ljava/util/ArrayList;)Z", "GetGetCurrentRoster_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool GetCurrentRoster (global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> p0)
		{
			if (id_GetCurrentRoster_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_GetCurrentRoster_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "GetCurrentRoster", "(Ljava/util/ArrayList;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetCurrentRoster_Ljava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetCurrentRoster", "(Ljava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_;
#pragma warning disable 0169
		static Delegate GetGetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_Handler ()
		{
			if (cb_GetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_ == null)
				cb_GetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, bool>) n_GetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_);
			return cb_GetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_;
		}

		static bool n_GetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetFavoriteRooms p2 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetFavoriteRooms)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetFavoriteRooms> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetFavoriteRooms (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='GetFavoriteRooms' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IGetFavoriteRooms']]"
		[Register ("GetFavoriteRooms", "(IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IGetFavoriteRooms;)Z", "GetGetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_Handler")]
		public virtual unsafe bool GetFavoriteRooms (int p0, int p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetFavoriteRooms p2)
		{
			if (id_GetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_ == IntPtr.Zero)
				id_GetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_ = JNIEnv.GetMethodID (class_ref, "GetFavoriteRooms", "(IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IGetFavoriteRooms;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetFavoriteRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetFavoriteRooms_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFavoriteRooms", "(IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IGetFavoriteRooms;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_;
#pragma warning disable 0169
		static Delegate GetGetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_Handler ()
		{
			if (cb_GetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_ == null)
				cb_GetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, bool>) n_GetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_);
			return cb_GetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_;
		}

		static bool n_GetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetRecentRooms p2 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetRecentRooms)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetRecentRooms> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetRecentRooms (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='GetRecentRooms' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IGetRecentRooms']]"
		[Register ("GetRecentRooms", "(IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IGetRecentRooms;)Z", "GetGetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_Handler")]
		public virtual unsafe bool GetRecentRooms (int p0, int p1, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IGetRecentRooms p2)
		{
			if (id_GetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_ == IntPtr.Zero)
				id_GetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_ = JNIEnv.GetMethodID (class_ref, "GetRecentRooms", "(IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IGetRecentRooms;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetRecentRooms_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IGetRecentRooms_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetRecentRooms", "(IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IGetRecentRooms;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_;
#pragma warning disable 0169
		static Delegate GetGetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_Handler ()
		{
			if (cb_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_ == null)
				cb_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_);
			return cb_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_;
		}

		static bool n_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Stats.VidyoUserStats p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Stats.VidyoUserStats> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetStats (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='GetStats' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Stats.VidyoUserStats']]"
		[Register ("GetStats", "(Lcom/vidyo/VidyoClient/Stats/VidyoUserStats;)Z", "GetGetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_Handler")]
		public virtual unsafe bool GetStats (global::Com.Vidyo.VidyoClient.Stats.VidyoUserStats p0)
		{
			if (id_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_ == IntPtr.Zero)
				id_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_ = JNIEnv.GetMethodID (class_ref, "GetStats", "(Lcom/vidyo/VidyoClient/Stats/VidyoUserStats;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetStats_Lcom_vidyo_VidyoClient_Stats_VidyoUserStats_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetStats", "(Lcom/vidyo/VidyoClient/Stats/VidyoUserStats;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_Login_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
#pragma warning disable 0169
		static Delegate GetLogin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_Handler ()
		{
			if (cb_Login_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ == null)
				cb_Login_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_Login_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_);
			return cb_Login_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
		}

		static bool n_Login_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin p5 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin> (native_p5, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Login (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Login_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='Login' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.ILogin']]"
		[Register ("Login", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z", "GetLogin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_Handler")]
		public virtual unsafe bool Login (string p0, string p1, string p2, int p3, string p4, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin p5)
		{
			if (id_Login_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ == IntPtr.Zero)
				id_Login_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ = JNIEnv.GetMethodID (class_ref, "Login", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Login_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Login", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_LoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
#pragma warning disable 0169
		static Delegate GetLoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_Handler ()
		{
			if (cb_LoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ == null)
				cb_LoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_LoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_);
			return cb_LoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
		}

		static bool n_LoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin p4 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin> (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoginAsGuest (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='LoginAsGuest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.ILogin']]"
		[Register ("LoginAsGuest", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z", "GetLoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_Handler")]
		public virtual unsafe bool LoginAsGuest (string p0, string p1, int p2, string p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin p4)
		{
			if (id_LoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ == IntPtr.Zero)
				id_LoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ = JNIEnv.GetMethodID (class_ref, "LoginAsGuest", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LoginAsGuest_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LoginAsGuest", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_LoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
#pragma warning disable 0169
		static Delegate GetLoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_Handler ()
		{
			if (cb_LoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ == null)
				cb_LoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_LoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_);
			return cb_LoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
		}

		static bool n_LoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin p4 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin> (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoginWithAccessToken (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='LoginWithAccessToken' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.ILogin']]"
		[Register ("LoginWithAccessToken", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z", "GetLoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_Handler")]
		public virtual unsafe bool LoginWithAccessToken (string p0, string p1, int p2, string p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin p4)
		{
			if (id_LoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ == IntPtr.Zero)
				id_LoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ = JNIEnv.GetMethodID (class_ref, "LoginWithAccessToken", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LoginWithAccessToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LoginWithAccessToken", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_LoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
#pragma warning disable 0169
		static Delegate GetLoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_Handler ()
		{
			if (cb_LoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ == null)
				cb_LoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_LoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_);
			return cb_LoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
		}

		static bool n_LoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin p4 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin> (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoginWithRefreshToken (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='LoginWithRefreshToken' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.ILogin']]"
		[Register ("LoginWithRefreshToken", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z", "GetLoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_Handler")]
		public virtual unsafe bool LoginWithRefreshToken (string p0, string p1, int p2, string p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin p4)
		{
			if (id_LoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ == IntPtr.Zero)
				id_LoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ = JNIEnv.GetMethodID (class_ref, "LoginWithRefreshToken", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LoginWithRefreshToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LoginWithRefreshToken", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_LoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
#pragma warning disable 0169
		static Delegate GetLoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_Handler ()
		{
			if (cb_LoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ == null)
				cb_LoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_LoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_);
			return cb_LoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
		}

		static bool n_LoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin p4 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin> (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoginWithTenantToken (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='LoginWithTenantToken' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.ILogin']]"
		[Register ("LoginWithTenantToken", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z", "GetLoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_Handler")]
		public virtual unsafe bool LoginWithTenantToken (string p0, string p1, int p2, string p3, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.ILogin p4)
		{
			if (id_LoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ == IntPtr.Zero)
				id_LoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_ = JNIEnv.GetMethodID (class_ref, "LoginWithTenantToken", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LoginWithTenantToken_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_ILogin_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LoginWithTenantToken", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$ILogin;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_Logout;
#pragma warning disable 0169
		static Delegate GetLogoutHandler ()
		{
			if (cb_Logout == null)
				cb_Logout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Logout);
			return cb_Logout;
		}

		static bool n_Logout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Logout ();
		}
#pragma warning restore 0169

		static IntPtr id_Logout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='Logout' and count(parameter)=0]"
		[Register ("Logout", "()Z", "GetLogoutHandler")]
		public virtual unsafe bool Logout ()
		{
			if (id_Logout == IntPtr.Zero)
				id_Logout = JNIEnv.GetMethodID (class_ref, "Logout", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Logout);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Logout", "()Z"));
			} finally {
			}
		}

		static Delegate cb_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_Handler ()
		{
			if (cb_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_ == null)
				cb_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_);
			return cb_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_;
		}

		static void n_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnCallCreated (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnCallCreated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult'] and parameter[3][@type='java.lang.String']]"
		[Register ("OnCallCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;Ljava/lang/String;)V", "GetOnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_Handler")]
		public virtual unsafe void OnCallCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserCallCreateResult p1, string p2)
		{
			if (id_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_ == IntPtr.Zero)
				id_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnCallCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCallCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserCallCreateResult_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnCallCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserCallCreateResult;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
#pragma warning disable 0169
		static Delegate GetOnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler ()
		{
			if (cb_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == null)
				cb_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_);
			return cb_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
		}

		static void n_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCallCreatedByInvite (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnCallCreatedByInvite' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoCall'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact']]"
		[Register ("OnCallCreatedByInvite", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V", "GetOnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler")]
		public virtual unsafe void OnCallCreatedByInvite (global::Com.Vidyo.VidyoClient.Endpoint.VidyoCall p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1)
		{
			if (id_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == IntPtr.Zero)
				id_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNIEnv.GetMethodID (class_ref, "OnCallCreatedByInvite", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnCallCreatedByInvite", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
#pragma warning disable 0169
		static Delegate GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler ()
		{
			if (cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == null)
				cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_);
			return cb_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
		}

		static void n_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionStatusChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnConnectionStatusChanged' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason']]"
		[Register ("OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V", "GetOnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_Handler")]
		public virtual unsafe void OnConnectionStatusChanged (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserConnectionStatusChangedReason p0)
		{
			if (id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ == IntPtr.Zero)
				id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_ = JNIEnv.GetMethodID (class_ref, "OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnConnectionStatusChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserConnectionStatusChangedReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnConnectionStatusChanged", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserConnectionStatusChangedReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetOnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_Handler ()
		{
			if (cb_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ == null)
				cb_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_);
			return cb_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
		}

		static void n_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFavoriteRoomResults (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnFavoriteRoomResults' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;']]"
		[Register ("OnFavoriteRoomResults", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;)V", "GetOnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void OnFavoriteRoomResults (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p1)
		{
			if (id_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "OnFavoriteRoomResults", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnFavoriteRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnFavoriteRoomResults", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_;
#pragma warning disable 0169
		static Delegate GetOnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_Handler ()
		{
			if (cb_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_ == null)
				cb_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_);
			return cb_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_;
		}

		static void n_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGetContactResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnGetContactResult' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult']]"
		[Register ("OnGetContactResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;)V", "GetOnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_Handler")]
		public virtual unsafe void OnGetContactResult (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserGetContactResult p1)
		{
			if (id_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_ == IntPtr.Zero)
				id_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_ = JNIEnv.GetMethodID (class_ref, "OnGetContactResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnGetContactResult_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserGetContactResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnGetContactResult", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserGetContactResult;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnGetLicenseKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnGetLicenseKey_Ljava_lang_String_Handler ()
		{
			if (cb_OnGetLicenseKey_Ljava_lang_String_ == null)
				cb_OnGetLicenseKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetLicenseKey_Ljava_lang_String_);
			return cb_OnGetLicenseKey_Ljava_lang_String_;
		}

		static void n_OnGetLicenseKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetLicenseKey (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnGetLicenseKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnGetLicenseKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("OnGetLicenseKey", "(Ljava/lang/String;)V", "GetOnGetLicenseKey_Ljava_lang_String_Handler")]
		public virtual unsafe void OnGetLicenseKey (string p0)
		{
			if (id_OnGetLicenseKey_Ljava_lang_String_ == IntPtr.Zero)
				id_OnGetLicenseKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnGetLicenseKey", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnGetLicenseKey_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnGetLicenseKey", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_OnLicenseReceived_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnLicenseReceived_Ljava_lang_String_Handler ()
		{
			if (cb_OnLicenseReceived_Ljava_lang_String_ == null)
				cb_OnLicenseReceived_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLicenseReceived_Ljava_lang_String_);
			return cb_OnLicenseReceived_Ljava_lang_String_;
		}

		static void n_OnLicenseReceived_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLicenseReceived (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLicenseReceived_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnLicenseReceived' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("OnLicenseReceived", "(Ljava/lang/String;)V", "GetOnLicenseReceived_Ljava_lang_String_Handler")]
		public virtual unsafe void OnLicenseReceived (string p0)
		{
			if (id_OnLicenseReceived_Ljava_lang_String_ == IntPtr.Zero)
				id_OnLicenseReceived_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnLicenseReceived", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLicenseReceived_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLicenseReceived", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
#pragma warning disable 0169
		static Delegate GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler ()
		{
			if (cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == null)
				cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_);
			return cb_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
		}

		static void n_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoggedOut (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnLoggedOut' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason']]"
		[Register ("OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V", "GetOnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_Handler")]
		public virtual unsafe void OnLoggedOut (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLogoutReason p0)
		{
			if (id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ == IntPtr.Zero)
				id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_ = JNIEnv.GetMethodID (class_ref, "OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoggedOut_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLogoutReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLoggedOut", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLogoutReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
#pragma warning disable 0169
		static Delegate GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler ()
		{
			if (cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == null)
				cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z);
			return cb_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
		}

		static void n_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoginComplete (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnLoginComplete' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult'] and parameter[2][@type='boolean']]"
		[Register ("OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V", "GetOnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_ZHandler")]
		public virtual unsafe void OnLoginComplete (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserLoginResult p0, bool p1)
		{
			if (id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z == IntPtr.Zero)
				id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z = JNIEnv.GetMethodID (class_ref, "OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnLoginComplete_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserLoginResult_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnLoginComplete", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserLoginResult;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetOnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_Handler ()
		{
			if (cb_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ == null)
				cb_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_);
			return cb_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
		}

		static void n_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRecentRoomResults (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnRecentRoomResults' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[2][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;']]"
		[Register ("OnRecentRoomResults", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;)V", "GetOnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void OnRecentRoomResults (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p0, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p1)
		{
			if (id_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "OnRecentRoomResults", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRecentRoomResults_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRecentRoomResults", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_OnRemoveRosterContact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRemoveRosterContact_Ljava_lang_String_Handler ()
		{
			if (cb_OnRemoveRosterContact_Ljava_lang_String_ == null)
				cb_OnRemoveRosterContact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRemoveRosterContact_Ljava_lang_String_);
			return cb_OnRemoveRosterContact_Ljava_lang_String_;
		}

		static void n_OnRemoveRosterContact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoveRosterContact (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnRemoveRosterContact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnRemoveRosterContact' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("OnRemoveRosterContact", "(Ljava/lang/String;)V", "GetOnRemoveRosterContact_Ljava_lang_String_Handler")]
		public virtual unsafe void OnRemoveRosterContact (string p0)
		{
			if (id_OnRemoveRosterContact_Ljava_lang_String_ == IntPtr.Zero)
				id_OnRemoveRosterContact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnRemoveRosterContact", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRemoveRosterContact_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRemoveRosterContact", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_Handler ()
		{
			if (cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ == null)
				cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_);
			return cb_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
		}

		static void n_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRoomCreated (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnRoomCreated' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult'] and parameter[3][@type='java.lang.String']]"
		[Register ("OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V", "GetOnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_Handler")]
		public virtual unsafe void OnRoomCreated (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserRoomCreateResult p1, string p2)
		{
			if (id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ == IntPtr.Zero)
				id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomCreated_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserRoomCreateResult_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRoomCreated", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserRoomCreateResult;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_Handler ()
		{
			if (cb_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_ == null)
				cb_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_);
			return cb_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_;
		}

		static void n_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRoomCreatedByInvite (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnRoomCreatedByInvite' and count(parameter)=3 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoRoom'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact'] and parameter[3][@type='java.lang.String']]"
		[Register ("OnRoomCreatedByInvite", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Ljava/lang/String;)V", "GetOnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_Handler")]
		public virtual unsafe void OnRoomCreatedByInvite (global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoom p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p1, string p2)
		{
			if (id_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_ == IntPtr.Zero)
				id_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnRoomCreatedByInvite", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRoomCreatedByInvite", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
		static Delegate GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
		{
			if (cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
				cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
			return cb_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
		}

		static void n_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRoomSearchResults (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnRoomSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoRoomInfo&gt;'] and parameter[4][@type='long']]"
		[Register ("OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler")]
		public virtual unsafe void OnRoomSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo> p2, long p3)
		{
			if (id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
				id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoRoomInfo>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRoomSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRoomSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
#pragma warning disable 0169
		static Delegate GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler ()
		{
			if (cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == null)
				cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_);
			return cb_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
		}

		static void n_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTokenReceived (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnTokenReceived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType']]"
		[Register ("OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V", "GetOnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_Handler")]
		public virtual unsafe void OnTokenReceived (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserTokenType p1)
		{
			if (id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ == IntPtr.Zero)
				id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_ = JNIEnv.GetMethodID (class_ref, "OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnTokenReceived_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserTokenType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnTokenReceived", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserTokenType;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
#pragma warning disable 0169
		static Delegate GetOnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler ()
		{
			if (cb_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == null)
				cb_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_);
			return cb_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
		}

		static void n_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateRosterContact (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnUpdateRosterContact' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact']]"
		[Register ("OnUpdateRosterContact", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V", "GetOnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler")]
		public virtual unsafe void OnUpdateRosterContact (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0)
		{
			if (id_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == IntPtr.Zero)
				id_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNIEnv.GetMethodID (class_ref, "OnUpdateRosterContact", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnUpdateRosterContact", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
#pragma warning disable 0169
		static Delegate GetOnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler ()
		{
			if (cb_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == null)
				cb_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_);
			return cb_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
		}

		static void n_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateSelf (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnUpdateSelf' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact']]"
		[Register ("OnUpdateSelf", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V", "GetOnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler")]
		public virtual unsafe void OnUpdateSelf (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact p0)
		{
			if (id_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ == IntPtr.Zero)
				id_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_ = JNIEnv.GetMethodID (class_ref, "OnUpdateSelf", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnUpdateSelf", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
#pragma warning disable 0169
		static Delegate GetOnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler ()
		{
			if (cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == null)
				cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J);
			return cb_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
		}

		static void n_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnUserSearchResults (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnUserSearchResults' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult'] and parameter[3][@type='java.util.ArrayList&lt;com.vidyo.VidyoClient.Endpoint.VidyoContactInfo&gt;'] and parameter[4][@type='long']]"
		[Register ("OnUserSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V", "GetOnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_JHandler")]
		public virtual unsafe void OnUserSearchResults (string p0, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.VidyoUserSearchResult p1, global::System.Collections.Generic.IList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo> p2, long p3)
		{
			if (id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J == IntPtr.Zero)
				id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J = JNIEnv.GetMethodID (class_ref, "OnUserSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContactInfo>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnUserSearchResults_Ljava_lang_String_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_VidyoUserSearchResult_Ljava_util_ArrayList_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnUserSearchResults", "(Ljava/lang/String;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$VidyoUserSearchResult;Ljava/util/ArrayList;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_OnWebProxyCredentialsRequest;
#pragma warning disable 0169
		static Delegate GetOnWebProxyCredentialsRequestHandler ()
		{
			if (cb_OnWebProxyCredentialsRequest == null)
				cb_OnWebProxyCredentialsRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebProxyCredentialsRequest);
			return cb_OnWebProxyCredentialsRequest;
		}

		static void n_OnWebProxyCredentialsRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWebProxyCredentialsRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_OnWebProxyCredentialsRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='OnWebProxyCredentialsRequest' and count(parameter)=0]"
		[Register ("OnWebProxyCredentialsRequest", "()V", "GetOnWebProxyCredentialsRequestHandler")]
		public virtual unsafe void OnWebProxyCredentialsRequest ()
		{
			if (id_OnWebProxyCredentialsRequest == IntPtr.Zero)
				id_OnWebProxyCredentialsRequest = JNIEnv.GetMethodID (class_ref, "OnWebProxyCredentialsRequest", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnWebProxyCredentialsRequest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnWebProxyCredentialsRequest", "()V"));
			} finally {
			}
		}

		static Delegate cb_RegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_Handler ()
		{
			if (cb_RegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_ == null)
				cb_RegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_);
			return cb_RegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_;
		}

		static bool n_RegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterCallEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterCallEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterCallEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterCallEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='RegisterCallEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterCallEventListener']]"
		[Register ("RegisterCallEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterCallEventListener;)Z", "GetRegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_Handler")]
		public virtual unsafe bool RegisterCallEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterCallEventListener p0)
		{
			if (id_RegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_ == IntPtr.Zero)
				id_RegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterCallEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterCallEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterCallEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterCallEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterCallEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterCallEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_Handler ()
		{
			if (cb_RegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_ == null)
				cb_RegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_);
			return cb_RegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_;
		}

		static bool n_RegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterContactEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='RegisterContactEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener']]"
		[Register ("RegisterContactEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterContactEventListener;)Z", "GetRegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_Handler")]
		public virtual unsafe bool RegisterContactEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener p0)
		{
			if (id_RegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_ == IntPtr.Zero)
				id_RegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterContactEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterContactEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterContactEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterContactEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterContactEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterContactEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_Handler ()
		{
			if (cb_RegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_ == null)
				cb_RegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_);
			return cb_RegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_;
		}

		static bool n_RegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterLicenseEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='RegisterLicenseEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener']]"
		[Register ("RegisterLicenseEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterLicenseEventListener;)Z", "GetRegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_Handler")]
		public virtual unsafe bool RegisterLicenseEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener p0)
		{
			if (id_RegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_ == IntPtr.Zero)
				id_RegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterLicenseEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterLicenseEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterLicenseEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterLicenseEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterLicenseEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterLicenseEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_Handler ()
		{
			if (cb_RegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_ == null)
				cb_RegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_);
			return cb_RegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_;
		}

		static bool n_RegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterRoomEventListener p0 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterRoomEventListener)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterRoomEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterRoomEventListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='RegisterRoomEventListener' and count(parameter)=1 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterRoomEventListener']]"
		[Register ("RegisterRoomEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterRoomEventListener;)Z", "GetRegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_Handler")]
		public virtual unsafe bool RegisterRoomEventListener (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterRoomEventListener p0)
		{
			if (id_RegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_ == IntPtr.Zero)
				id_RegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_ = JNIEnv.GetMethodID (class_ref, "RegisterRoomEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterRoomEventListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RegisterRoomEventListener_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_IRegisterRoomEventListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterRoomEventListener", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoUser$IRegisterRoomEventListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RemoveRosterContact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveRosterContact_Ljava_lang_String_Handler ()
		{
			if (cb_RemoveRosterContact_Ljava_lang_String_ == null)
				cb_RemoveRosterContact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveRosterContact_Ljava_lang_String_);
			return cb_RemoveRosterContact_Ljava_lang_String_;
		}

		static bool n_RemoveRosterContact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveRosterContact (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RemoveRosterContact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='RemoveRosterContact' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("RemoveRosterContact", "(Ljava/lang/String;)Z", "GetRemoveRosterContact_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemoveRosterContact (string p0)
		{
			if (id_RemoveRosterContact_Ljava_lang_String_ == IntPtr.Zero)
				id_RemoveRosterContact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "RemoveRosterContact", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_RemoveRosterContact_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveRosterContact", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
#pragma warning disable 0169
		static Delegate GetSearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler ()
		{
			if (cb_SearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == null)
				cb_SearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_SearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_);
			return cb_SearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		}

		static bool n_SearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchConversationRooms (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='SearchConversationRooms' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms']]"
		[Register ("SearchConversationRooms", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z", "GetSearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler")]
		public virtual unsafe bool SearchConversationRooms (string p0, int p1, int p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3)
		{
			if (id_SearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == IntPtr.Zero)
				id_SearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNIEnv.GetMethodID (class_ref, "SearchConversationRooms", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SearchConversationRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SearchConversationRooms", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
#pragma warning disable 0169
		static Delegate GetSearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler ()
		{
			if (cb_SearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == null)
				cb_SearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_SearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_);
			return cb_SearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		}

		static bool n_SearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchRooms (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='SearchRooms' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms']]"
		[Register ("SearchRooms", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z", "GetSearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler")]
		public virtual unsafe bool SearchRooms (string p0, int p1, int p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3)
		{
			if (id_SearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == IntPtr.Zero)
				id_SearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNIEnv.GetMethodID (class_ref, "SearchRooms", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SearchRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SearchRooms", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
#pragma warning disable 0169
		static Delegate GetSearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler ()
		{
			if (cb_SearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == null)
				cb_SearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_SearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_);
			return cb_SearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		}

		static bool n_SearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchRoomsWithName (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='SearchRoomsWithName' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms']]"
		[Register ("SearchRoomsWithName", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z", "GetSearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler")]
		public virtual unsafe bool SearchRoomsWithName (string p0, int p1, int p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3)
		{
			if (id_SearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == IntPtr.Zero)
				id_SearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNIEnv.GetMethodID (class_ref, "SearchRoomsWithName", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SearchRoomsWithName_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SearchRoomsWithName", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
#pragma warning disable 0169
		static Delegate GetSearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler ()
		{
			if (cb_SearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == null)
				cb_SearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_SearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_);
			return cb_SearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		}

		static bool n_SearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchRoomsWithOwner (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='SearchRoomsWithOwner' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms']]"
		[Register ("SearchRoomsWithOwner", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z", "GetSearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler")]
		public virtual unsafe bool SearchRoomsWithOwner (string p0, int p1, int p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3)
		{
			if (id_SearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == IntPtr.Zero)
				id_SearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNIEnv.GetMethodID (class_ref, "SearchRoomsWithOwner", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SearchRoomsWithOwner_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SearchRoomsWithOwner", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
#pragma warning disable 0169
		static Delegate GetSearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler ()
		{
			if (cb_SearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == null)
				cb_SearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_SearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_);
			return cb_SearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		}

		static bool n_SearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchRoomsWithSubject (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='SearchRoomsWithSubject' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms']]"
		[Register ("SearchRoomsWithSubject", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z", "GetSearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler")]
		public virtual unsafe bool SearchRoomsWithSubject (string p0, int p1, int p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3)
		{
			if (id_SearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == IntPtr.Zero)
				id_SearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNIEnv.GetMethodID (class_ref, "SearchRoomsWithSubject", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SearchRoomsWithSubject_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SearchRoomsWithSubject", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
#pragma warning disable 0169
		static Delegate GetSearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler ()
		{
			if (cb_SearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == null)
				cb_SearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_SearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_);
			return cb_SearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		}

		static bool n_SearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchTopicRooms (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='SearchTopicRooms' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms']]"
		[Register ("SearchTopicRooms", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z", "GetSearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_Handler")]
		public virtual unsafe bool SearchTopicRooms (string p0, int p1, int p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchRooms p3)
		{
			if (id_SearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ == IntPtr.Zero)
				id_SearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_ = JNIEnv.GetMethodID (class_ref, "SearchTopicRooms", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SearchTopicRooms_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchRooms_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SearchTopicRooms", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchRooms;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_;
#pragma warning disable 0169
		static Delegate GetSearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_Handler ()
		{
			if (cb_SearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_ == null)
				cb_SearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_SearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_);
			return cb_SearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_;
		}

		static bool n_SearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers p3 = (global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers)global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchUsers (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='SearchUsers' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers']]"
		[Register ("SearchUsers", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchUsers;)Z", "GetSearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_Handler")]
		public virtual unsafe bool SearchUsers (string p0, int p1, int p2, global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser.IAdvancedSearchUsers p3)
		{
			if (id_SearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_ == IntPtr.Zero)
				id_SearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_ = JNIEnv.GetMethodID (class_ref, "SearchUsers", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchUsers;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SearchUsers_Ljava_lang_String_IILcom_vidyo_VidyoClient_Endpoint_VidyoUser_IAdvancedSearchUsers_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SearchUsers", "(Ljava/lang/String;IILcom/vidyo/VidyoClient/Endpoint/VidyoUser$IAdvancedSearchUsers;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_SetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_SetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_SetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetCA (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_SetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='SetCA' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("SetCA", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCA (string p0, string p1, string p2)
		{
			if (id_SetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_SetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetCA", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetCA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCA", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_SetDisplayName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDisplayName_Ljava_lang_String_Handler ()
		{
			if (cb_SetDisplayName_Ljava_lang_String_ == null)
				cb_SetDisplayName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisplayName_Ljava_lang_String_);
			return cb_SetDisplayName_Ljava_lang_String_;
		}

		static void n_SetDisplayName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetDisplayName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='SetDisplayName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetDisplayName", "(Ljava/lang/String;)V", "GetSetDisplayName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDisplayName (string p0)
		{
			if (id_SetDisplayName_Ljava_lang_String_ == IntPtr.Zero)
				id_SetDisplayName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetDisplayName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetDisplayName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetDisplayName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetWebProxyAddressCredentials (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='SetWebProxyAddressCredentials' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("SetWebProxyAddressCredentials", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetWebProxyAddressCredentials (string p0, string p1, string p2)
		{
			if (id_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetWebProxyAddressCredentials", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetWebProxyAddressCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetWebProxyAddressCredentials", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_UnregisterCallEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterCallEventListenerHandler ()
		{
			if (cb_UnregisterCallEventListener == null)
				cb_UnregisterCallEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterCallEventListener);
			return cb_UnregisterCallEventListener;
		}

		static bool n_UnregisterCallEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterCallEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterCallEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='UnregisterCallEventListener' and count(parameter)=0]"
		[Register ("UnregisterCallEventListener", "()Z", "GetUnregisterCallEventListenerHandler")]
		public virtual unsafe bool UnregisterCallEventListener ()
		{
			if (id_UnregisterCallEventListener == IntPtr.Zero)
				id_UnregisterCallEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterCallEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterCallEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterCallEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterContactEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterContactEventListenerHandler ()
		{
			if (cb_UnregisterContactEventListener == null)
				cb_UnregisterContactEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterContactEventListener);
			return cb_UnregisterContactEventListener;
		}

		static bool n_UnregisterContactEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterContactEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterContactEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='UnregisterContactEventListener' and count(parameter)=0]"
		[Register ("UnregisterContactEventListener", "()Z", "GetUnregisterContactEventListenerHandler")]
		public virtual unsafe bool UnregisterContactEventListener ()
		{
			if (id_UnregisterContactEventListener == IntPtr.Zero)
				id_UnregisterContactEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterContactEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterContactEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterContactEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterLicenseEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterLicenseEventListenerHandler ()
		{
			if (cb_UnregisterLicenseEventListener == null)
				cb_UnregisterLicenseEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterLicenseEventListener);
			return cb_UnregisterLicenseEventListener;
		}

		static bool n_UnregisterLicenseEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterLicenseEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterLicenseEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='UnregisterLicenseEventListener' and count(parameter)=0]"
		[Register ("UnregisterLicenseEventListener", "()Z", "GetUnregisterLicenseEventListenerHandler")]
		public virtual unsafe bool UnregisterLicenseEventListener ()
		{
			if (id_UnregisterLicenseEventListener == IntPtr.Zero)
				id_UnregisterLicenseEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterLicenseEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterLicenseEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterLicenseEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UnregisterRoomEventListener;
#pragma warning disable 0169
		static Delegate GetUnregisterRoomEventListenerHandler ()
		{
			if (cb_UnregisterRoomEventListener == null)
				cb_UnregisterRoomEventListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnregisterRoomEventListener);
			return cb_UnregisterRoomEventListener;
		}

		static bool n_UnregisterRoomEventListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnregisterRoomEventListener ();
		}
#pragma warning restore 0169

		static IntPtr id_UnregisterRoomEventListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='UnregisterRoomEventListener' and count(parameter)=0]"
		[Register ("UnregisterRoomEventListener", "()Z", "GetUnregisterRoomEventListenerHandler")]
		public virtual unsafe bool UnregisterRoomEventListener ()
		{
			if (id_UnregisterRoomEventListener == IntPtr.Zero)
				id_UnregisterRoomEventListener = JNIEnv.GetMethodID (class_ref, "UnregisterRoomEventListener", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UnregisterRoomEventListener);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UnregisterRoomEventListener", "()Z"));
			} finally {
			}
		}

		static Delegate cb_UpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_Handler ()
		{
			if (cb_UpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_ == null)
				cb_UpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_);
			return cb_UpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_;
		}

		static bool n_UpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState p0 = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdatePresence (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_UpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='UpdatePresence' and count(parameter)=2 and parameter[1][@type='com.vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState'] and parameter[2][@type='java.lang.String']]"
		[Register ("UpdatePresence", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;Ljava/lang/String;)Z", "GetUpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_Handler")]
		public virtual unsafe bool UpdatePresence (global::Com.Vidyo.VidyoClient.Endpoint.VidyoContact.VidyoContactPresenceState p0, string p1)
		{
			if (id_UpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_ == IntPtr.Zero)
				id_UpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "UpdatePresence", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UpdatePresence_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_VidyoContactPresenceState_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UpdatePresence", "(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact$VidyoContactPresenceState;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser __this = global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.Endpoint.VidyoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vidyo.VidyoClient.Endpoint']/class[@name='VidyoUser']/method[@name='dispose' and count(parameter)=0]"
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
