package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoEndpoint_IRegisterRemoteSpeakerEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteSpeakerEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnRemoteSpeakerAdded:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V:GetOnRemoteSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteSpeakerEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnRemoteSpeakerRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteSpeaker;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V:GetOnRemoteSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteSpeaker_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteSpeakerEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterRemoteSpeakerEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoEndpoint_IRegisterRemoteSpeakerEventListenerImplementor.class, __md_methods);
	}


	public VidyoEndpoint_IRegisterRemoteSpeakerEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoEndpoint_IRegisterRemoteSpeakerEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterRemoteSpeakerEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnRemoteSpeakerAdded (com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3)
	{
		n_OnRemoteSpeakerAdded (p0, p1, p2, p3);
	}

	private native void n_OnRemoteSpeakerAdded (com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3);


	public void OnRemoteSpeakerRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3)
	{
		n_OnRemoteSpeakerRemoved (p0, p1, p2, p3);
	}

	private native void n_OnRemoteSpeakerRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteSpeaker p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3);

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
