package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterLocalCameraEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalCameraEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnLocalCameraAdded:(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V:GetOnLocalCameraAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalCameraRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V:GetOnLocalCameraRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalCameraSelected:(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;)V:GetOnLocalCameraSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalCameraStateUpdated:(Lcom/vidyo/VidyoClient/Device/VidyoLocalCamera;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V:GetOnLocalCameraStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalCamera_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalCameraEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterLocalCameraEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterLocalCameraEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterLocalCameraEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterLocalCameraEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterLocalCameraEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnLocalCameraAdded (com.vidyo.VidyoClient.Device.VidyoLocalCamera p0)
	{
		n_OnLocalCameraAdded (p0);
	}

	private native void n_OnLocalCameraAdded (com.vidyo.VidyoClient.Device.VidyoLocalCamera p0);


	public void OnLocalCameraRemoved (com.vidyo.VidyoClient.Device.VidyoLocalCamera p0)
	{
		n_OnLocalCameraRemoved (p0);
	}

	private native void n_OnLocalCameraRemoved (com.vidyo.VidyoClient.Device.VidyoLocalCamera p0);


	public void OnLocalCameraSelected (com.vidyo.VidyoClient.Device.VidyoLocalCamera p0)
	{
		n_OnLocalCameraSelected (p0);
	}

	private native void n_OnLocalCameraSelected (com.vidyo.VidyoClient.Device.VidyoLocalCamera p0);


	public void OnLocalCameraStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalCamera p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
	{
		n_OnLocalCameraStateUpdated (p0, p1);
	}

	private native void n_OnLocalCameraStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalCamera p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

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
