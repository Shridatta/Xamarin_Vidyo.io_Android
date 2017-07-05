package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoUser_IRegisterContactEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterContactEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnRemoveRosterContact:(Ljava/lang/String;)V:GetOnRemoveRosterContact_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterContactEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnUpdateRosterContact:(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V:GetOnUpdateRosterContact_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterContactEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnUpdateSelf:(Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V:GetOnUpdateSelf_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterContactEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoUser+IRegisterContactEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoUser_IRegisterContactEventListenerImplementor.class, __md_methods);
	}


	public VidyoUser_IRegisterContactEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoUser_IRegisterContactEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoUser+IRegisterContactEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnRemoveRosterContact (java.lang.String p0)
	{
		n_OnRemoveRosterContact (p0);
	}

	private native void n_OnRemoveRosterContact (java.lang.String p0);


	public void OnUpdateRosterContact (com.vidyo.VidyoClient.Endpoint.VidyoContact p0)
	{
		n_OnUpdateRosterContact (p0);
	}

	private native void n_OnUpdateRosterContact (com.vidyo.VidyoClient.Endpoint.VidyoContact p0);


	public void OnUpdateSelf (com.vidyo.VidyoClient.Endpoint.VidyoContact p0)
	{
		n_OnUpdateSelf (p0);
	}

	private native void n_OnUpdateSelf (com.vidyo.VidyoClient.Endpoint.VidyoContact p0);

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
