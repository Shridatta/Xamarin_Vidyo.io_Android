using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vidyo.VidyoClient.CalendarManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']"
	[global::Android.Runtime.Register ("com/vidyo/VidyoClient/CalendarManager/VidyoFormField", DoNotGenerateAcw=true)]
	public partial class VidyoFormField : global::Java.Lang.Object {


		static IntPtr cols_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/field[@name='cols']"
		[Register ("cols")]
		public int Cols {
			get {
				if (cols_jfieldId == IntPtr.Zero)
					cols_jfieldId = JNIEnv.GetFieldID (class_ref, "cols", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, cols_jfieldId);
			}
			set {
				if (cols_jfieldId == IntPtr.Zero)
					cols_jfieldId = JNIEnv.GetFieldID (class_ref, "cols", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cols_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxlength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/field[@name='maxlength']"
		[Register ("maxlength")]
		public int Maxlength {
			get {
				if (maxlength_jfieldId == IntPtr.Zero)
					maxlength_jfieldId = JNIEnv.GetFieldID (class_ref, "maxlength", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, maxlength_jfieldId);
			}
			set {
				if (maxlength_jfieldId == IntPtr.Zero)
					maxlength_jfieldId = JNIEnv.GetFieldID (class_ref, "maxlength", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxlength_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr multiple_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/field[@name='multiple']"
		[Register ("multiple")]
		public bool Multiple {
			get {
				if (multiple_jfieldId == IntPtr.Zero)
					multiple_jfieldId = JNIEnv.GetFieldID (class_ref, "multiple", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, multiple_jfieldId);
			}
			set {
				if (multiple_jfieldId == IntPtr.Zero)
					multiple_jfieldId = JNIEnv.GetFieldID (class_ref, "multiple", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, multiple_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/field[@name='name']"
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

		static IntPtr options_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/field[@name='options']"
		[Register ("options")]
		public global::System.Collections.IList Options {
			get {
				if (options_jfieldId == IntPtr.Zero)
					options_jfieldId = JNIEnv.GetFieldID (class_ref, "options", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, options_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (options_jfieldId == IntPtr.Zero)
					options_jfieldId = JNIEnv.GetFieldID (class_ref, "options", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, options_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr rows_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/field[@name='rows']"
		[Register ("rows")]
		public int Rows {
			get {
				if (rows_jfieldId == IntPtr.Zero)
					rows_jfieldId = JNIEnv.GetFieldID (class_ref, "rows", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, rows_jfieldId);
			}
			set {
				if (rows_jfieldId == IntPtr.Zero)
					rows_jfieldId = JNIEnv.GetFieldID (class_ref, "rows", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rows_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/field[@name='size']"
		[Register ("size")]
		public int Size {
			get {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, size_jfieldId);
			}
			set {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, size_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/field[@name='type']"
		[Register ("type")]
		public global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr value_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/field[@name='value']"
		[Register ("value")]
		public string Value {
			get {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr wrap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/field[@name='wrap']"
		[Register ("wrap")]
		public global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode Wrap {
			get {
				if (wrap_jfieldId == IntPtr.Zero)
					wrap_jfieldId = JNIEnv.GetFieldID (class_ref, "wrap", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, wrap_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vidyo.VidyoClient.CalendarManager.VidyoFormFieldTextWrapMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (wrap_jfieldId == IntPtr.Zero)
					wrap_jfieldId = JNIEnv.GetFieldID (class_ref, "wrap", "Lcom/vidyo/VidyoClient/CalendarManager/VidyoFormFieldTextWrapMode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, wrap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vidyo/VidyoClient/CalendarManager/VidyoFormField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VidyoFormField); }
		}

		protected VidyoFormField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vidyo.VidyoClient.CalendarManager']/class[@name='VidyoFormField']/constructor[@name='VidyoFormField' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VidyoFormField ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VidyoFormField)) {
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
