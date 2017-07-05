package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterMessageEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterMessageEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnChatMessageReceived:(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V:GetOnChatMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterMessageEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterMessageEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterMessageEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterMessageEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterMessageEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterMessageEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnChatMessageReceived (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0, com.vidyo.VidyoClient.Endpoint.VidyoChatMessage p1)
	{
		n_OnChatMessageReceived (p0, p1);
	}

	private native void n_OnChatMessageReceived (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0, com.vidyo.VidyoClient.Endpoint.VidyoChatMessage p1);

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
