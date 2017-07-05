package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterLocalMicrophoneEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalMicrophoneEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnLocalMicrophoneAdded:(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V:GetOnLocalMicrophoneAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalMicrophoneRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V:GetOnLocalMicrophoneRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalMicrophoneSelected:(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;)V:GetOnLocalMicrophoneSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalMicrophoneStateUpdated:(Lcom/vidyo/VidyoClient/Device/VidyoLocalMicrophone;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V:GetOnLocalMicrophoneStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMicrophone_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalMicrophoneEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterLocalMicrophoneEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterLocalMicrophoneEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterLocalMicrophoneEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterLocalMicrophoneEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterLocalMicrophoneEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnLocalMicrophoneAdded (com.vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
	{
		n_OnLocalMicrophoneAdded (p0);
	}

	private native void n_OnLocalMicrophoneAdded (com.vidyo.VidyoClient.Device.VidyoLocalMicrophone p0);


	public void OnLocalMicrophoneRemoved (com.vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
	{
		n_OnLocalMicrophoneRemoved (p0);
	}

	private native void n_OnLocalMicrophoneRemoved (com.vidyo.VidyoClient.Device.VidyoLocalMicrophone p0);


	public void OnLocalMicrophoneSelected (com.vidyo.VidyoClient.Device.VidyoLocalMicrophone p0)
	{
		n_OnLocalMicrophoneSelected (p0);
	}

	private native void n_OnLocalMicrophoneSelected (com.vidyo.VidyoClient.Device.VidyoLocalMicrophone p0);


	public void OnLocalMicrophoneStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalMicrophone p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
	{
		n_OnLocalMicrophoneStateUpdated (p0, p1);
	}

	private native void n_OnLocalMicrophoneStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalMicrophone p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

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
