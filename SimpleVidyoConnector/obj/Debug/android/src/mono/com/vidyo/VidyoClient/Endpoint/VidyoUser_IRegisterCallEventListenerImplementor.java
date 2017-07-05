package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoUser_IRegisterCallEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterCallEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnCallCreatedByInvite:(Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;)V:GetOnCallCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterCallEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoUser+IRegisterCallEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoUser_IRegisterCallEventListenerImplementor.class, __md_methods);
	}


	public VidyoUser_IRegisterCallEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoUser_IRegisterCallEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoUser+IRegisterCallEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnCallCreatedByInvite (com.vidyo.VidyoClient.Endpoint.VidyoCall p0, com.vidyo.VidyoClient.Endpoint.VidyoContact p1)
	{
		n_OnCallCreatedByInvite (p0, p1);
	}

	private native void n_OnCallCreatedByInvite (com.vidyo.VidyoClient.Endpoint.VidyoCall p0, com.vidyo.VidyoClient.Endpoint.VidyoContact p1);

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
