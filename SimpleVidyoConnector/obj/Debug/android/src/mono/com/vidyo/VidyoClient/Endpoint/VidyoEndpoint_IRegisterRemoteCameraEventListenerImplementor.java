package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoEndpoint_IRegisterRemoteCameraEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterRemoteCameraEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnRemoteCameraAdded:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V:GetOnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnRemoteCameraRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V:GetOnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnRemoteCameraStateUpdated:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoUser;Lcom/vidyo/VidyoClient/Endpoint/VidyoCall;Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V:GetOnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoUser_Lcom_vidyo_VidyoClient_Endpoint_VidyoCall_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterRemoteCameraEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoEndpoint_IRegisterRemoteCameraEventListenerImplementor.class, __md_methods);
	}


	public VidyoEndpoint_IRegisterRemoteCameraEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoEndpoint_IRegisterRemoteCameraEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterRemoteCameraEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnRemoteCameraAdded (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
	{
		n_OnRemoteCameraAdded (p0, p1, p2, p3, p4);
	}

	private native void n_OnRemoteCameraAdded (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p4);


	public void OnRemoteCameraRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p4)
	{
		n_OnRemoteCameraRemoved (p0, p1, p2, p3, p4);
	}

	private native void n_OnRemoteCameraRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p4);


	public void OnRemoteCameraStateUpdated (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p4, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5)
	{
		n_OnRemoteCameraStateUpdated (p0, p1, p2, p3, p4, p5);
	}

	private native void n_OnRemoteCameraStateUpdated (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoUser p1, com.vidyo.VidyoClient.Endpoint.VidyoCall p2, com.vidyo.VidyoClient.Endpoint.VidyoRoom p3, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p4, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p5);

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
