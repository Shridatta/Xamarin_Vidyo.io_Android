package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoRoom_IRegisterMessageEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterMessageEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnMessageAcknowledged:(Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V:GetOnMessageAcknowledged_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterMessageEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnMessageRead:(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;J)V:GetOnMessageRead_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_JHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterMessageEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnMessageReceived:(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage;)V:GetOnMessageReceived_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterMessageEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnMessageTypingIndication:(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Endpoint/VidyoChatMessage$VidyoChatMessageTypingIndication;)V:GetOnMessageTypingIndication_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Endpoint_VidyoChatMessage_VidyoChatMessageTypingIndication_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterMessageEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoRoom+IRegisterMessageEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoRoom_IRegisterMessageEventListenerImplementor.class, __md_methods);
	}


	public VidyoRoom_IRegisterMessageEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoRoom_IRegisterMessageEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoRoom+IRegisterMessageEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnMessageAcknowledged (com.vidyo.VidyoClient.Endpoint.VidyoChatMessage p0)
	{
		n_OnMessageAcknowledged (p0);
	}

	private native void n_OnMessageAcknowledged (com.vidyo.VidyoClient.Endpoint.VidyoChatMessage p0);


	public void OnMessageRead (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0, long p1)
	{
		n_OnMessageRead (p0, p1);
	}

	private native void n_OnMessageRead (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0, long p1);


	public void OnMessageReceived (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0, com.vidyo.VidyoClient.Endpoint.VidyoChatMessage p1)
	{
		n_OnMessageReceived (p0, p1);
	}

	private native void n_OnMessageReceived (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0, com.vidyo.VidyoClient.Endpoint.VidyoChatMessage p1);


	public void OnMessageTypingIndication (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0, com.vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1)
	{
		n_OnMessageTypingIndication (p0, p1);
	}

	private native void n_OnMessageTypingIndication (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0, com.vidyo.VidyoClient.Endpoint.VidyoChatMessage.VidyoChatMessageTypingIndication p1);

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
