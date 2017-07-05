package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterRemoteCameraEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteCameraEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnRemoteCameraAdded:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V:GetOnRemoteCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnRemoteCameraRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V:GetOnRemoteCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnRemoteCameraStateUpdated:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteCamera;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V:GetOnRemoteCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteCamera_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteCameraEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterRemoteCameraEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterRemoteCameraEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterRemoteCameraEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterRemoteCameraEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterRemoteCameraEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnRemoteCameraAdded (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
	{
		n_OnRemoteCameraAdded (p0, p1);
	}

	private native void n_OnRemoteCameraAdded (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1);


	public void OnRemoteCameraRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
	{
		n_OnRemoteCameraRemoved (p0, p1);
	}

	private native void n_OnRemoteCameraRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1);


	public void OnRemoteCameraStateUpdated (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
	{
		n_OnRemoteCameraStateUpdated (p0, p1, p2);
	}

	private native void n_OnRemoteCameraStateUpdated (com.vidyo.VidyoClient.Device.VidyoRemoteCamera p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2);

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
