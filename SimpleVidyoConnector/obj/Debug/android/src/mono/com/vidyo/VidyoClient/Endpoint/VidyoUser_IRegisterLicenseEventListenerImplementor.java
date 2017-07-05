package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoUser_IRegisterLicenseEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterLicenseEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnGetLicenseKey:(Ljava/lang/String;)V:GetOnGetLicenseKey_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterLicenseEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLicenseReceived:(Ljava/lang/String;)V:GetOnLicenseReceived_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterLicenseEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoUser+IRegisterLicenseEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoUser_IRegisterLicenseEventListenerImplementor.class, __md_methods);
	}


	public VidyoUser_IRegisterLicenseEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoUser_IRegisterLicenseEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoUser+IRegisterLicenseEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnGetLicenseKey (java.lang.String p0)
	{
		n_OnGetLicenseKey (p0);
	}

	private native void n_OnGetLicenseKey (java.lang.String p0);


	public void OnLicenseReceived (java.lang.String p0)
	{
		n_OnLicenseReceived (p0);
	}

	private native void n_OnLicenseReceived (java.lang.String p0);

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
