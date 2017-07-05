package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoEndpoint_IRegisterRemoteRendererEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteRendererEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnRemoteRendererAdded:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V:GetOnRemoteRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteRendererEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnRemoteRendererRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteRenderer;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;)V:GetOnRemoteRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteRenderer_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteRendererEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterRemoteRendererEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoEndpoint_IRegisterRemoteRendererEventListenerImplementor.class, __md_methods);
	}


	public VidyoEndpoint_IRegisterRemoteRendererEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoEndpoint_IRegisterRemoteRendererEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterRemoteRendererEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnRemoteRendererAdded (com.vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3)
	{
		n_OnRemoteRendererAdded (p0, p1, p2, p3);
	}

	private native void n_OnRemoteRendererAdded (com.vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3);


	public void OnRemoteRendererRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3)
	{
		n_OnRemoteRendererRemoved (p0, p1, p2, p3);
	}

	private native void n_OnRemoteRendererRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteRenderer p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3);

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
