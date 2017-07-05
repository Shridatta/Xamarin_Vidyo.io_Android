package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterRemoteWindowShareEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteWindowShareEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnRemoteWindowShareAdded:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V:GetOnRemoteWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteWindowShareEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnRemoteWindowShareRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V:GetOnRemoteWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteWindowShareEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnRemoteWindowShareStateUpdated:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteWindowShare;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V:GetOnRemoteWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteWindowShare_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteWindowShareEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterRemoteWindowShareEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterRemoteWindowShareEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterRemoteWindowShareEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterRemoteWindowShareEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterRemoteWindowShareEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnRemoteWindowShareAdded (com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
	{
		n_OnRemoteWindowShareAdded (p0, p1);
	}

	private native void n_OnRemoteWindowShareAdded (com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1);


	public void OnRemoteWindowShareRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
	{
		n_OnRemoteWindowShareRemoved (p0, p1);
	}

	private native void n_OnRemoteWindowShareRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1);


	public void OnRemoteWindowShareStateUpdated (com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
	{
		n_OnRemoteWindowShareStateUpdated (p0, p1, p2);
	}

	private native void n_OnRemoteWindowShareStateUpdated (com.vidyo.VidyoClient.Device.VidyoRemoteWindowShare p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2);

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
