package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterLocalSpeakerEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalSpeakerEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnLocalSpeakerAdded:(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V:GetOnLocalSpeakerAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalSpeakerRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V:GetOnLocalSpeakerRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalSpeakerSelected:(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;)V:GetOnLocalSpeakerSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalSpeakerStateUpdated:(Lcom/vidyo/VidyoClient/Device/VidyoLocalSpeaker;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V:GetOnLocalSpeakerStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalSpeaker_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalSpeakerEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterLocalSpeakerEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterLocalSpeakerEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterLocalSpeakerEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterLocalSpeakerEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterLocalSpeakerEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnLocalSpeakerAdded (com.vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
	{
		n_OnLocalSpeakerAdded (p0);
	}

	private native void n_OnLocalSpeakerAdded (com.vidyo.VidyoClient.Device.VidyoLocalSpeaker p0);


	public void OnLocalSpeakerRemoved (com.vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
	{
		n_OnLocalSpeakerRemoved (p0);
	}

	private native void n_OnLocalSpeakerRemoved (com.vidyo.VidyoClient.Device.VidyoLocalSpeaker p0);


	public void OnLocalSpeakerSelected (com.vidyo.VidyoClient.Device.VidyoLocalSpeaker p0)
	{
		n_OnLocalSpeakerSelected (p0);
	}

	private native void n_OnLocalSpeakerSelected (com.vidyo.VidyoClient.Device.VidyoLocalSpeaker p0);


	public void OnLocalSpeakerStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
	{
		n_OnLocalSpeakerStateUpdated (p0, p1);
	}

	private native void n_OnLocalSpeakerStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalSpeaker p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

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
