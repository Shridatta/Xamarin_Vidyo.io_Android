package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterRemoteMicrophoneEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRemoteMicrophoneEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnRemoteMicrophoneAdded:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V:GetOnRemoteMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteMicrophoneEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnRemoteMicrophoneRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V:GetOnRemoteMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteMicrophoneEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnRemoteMicrophoneStateUpdated:(Lcom/vidyo/VidyoClient/Device/VidyoRemoteMicrophone;Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V:GetOnRemoteMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoRemoteMicrophone_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRemoteMicrophoneEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterRemoteMicrophoneEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterRemoteMicrophoneEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterRemoteMicrophoneEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterRemoteMicrophoneEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterRemoteMicrophoneEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnRemoteMicrophoneAdded (com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
	{
		n_OnRemoteMicrophoneAdded (p0, p1);
	}

	private native void n_OnRemoteMicrophoneAdded (com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1);


	public void OnRemoteMicrophoneRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1)
	{
		n_OnRemoteMicrophoneRemoved (p0, p1);
	}

	private native void n_OnRemoteMicrophoneRemoved (com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1);


	public void OnRemoteMicrophoneStateUpdated (com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2)
	{
		n_OnRemoteMicrophoneStateUpdated (p0, p1, p2);
	}

	private native void n_OnRemoteMicrophoneStateUpdated (com.vidyo.VidyoClient.Device.VidyoRemoteMicrophone p0, com.vidyo.VidyoClient.Endpoint.VidyoParticipant p1, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p2);

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
