package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoCall_IRegisterSubjectEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoCall.IRegisterSubjectEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnSetSubject:(Ljava/lang/String;)V:GetOnSetSubject_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoCall/IRegisterSubjectEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoCall+IRegisterSubjectEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoCall_IRegisterSubjectEventListenerImplementor.class, __md_methods);
	}


	public VidyoCall_IRegisterSubjectEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoCall_IRegisterSubjectEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoCall+IRegisterSubjectEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnSetSubject (java.lang.String p0)
	{
		n_OnSetSubject (p0);
	}

	private native void n_OnSetSubject (java.lang.String p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}