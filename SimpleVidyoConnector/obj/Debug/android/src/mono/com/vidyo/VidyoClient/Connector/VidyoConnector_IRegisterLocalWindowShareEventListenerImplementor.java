package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterLocalWindowShareEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLocalWindowShareEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnLocalWindowShareAdded:(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V:GetOnLocalWindowShareAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalWindowShareRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V:GetOnLocalWindowShareRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalWindowShareSelected:(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;)V:GetOnLocalWindowShareSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalWindowShareStateUpdated:(Lcom/vidyo/VidyoClient/Device/VidyoLocalWindowShare;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V:GetOnLocalWindowShareStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalWindowShare_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLocalWindowShareEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterLocalWindowShareEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterLocalWindowShareEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterLocalWindowShareEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterLocalWindowShareEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterLocalWindowShareEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnLocalWindowShareAdded (com.vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
	{
		n_OnLocalWindowShareAdded (p0);
	}

	private native void n_OnLocalWindowShareAdded (com.vidyo.VidyoClient.Device.VidyoLocalWindowShare p0);


	public void OnLocalWindowShareRemoved (com.vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
	{
		n_OnLocalWindowShareRemoved (p0);
	}

	private native void n_OnLocalWindowShareRemoved (com.vidyo.VidyoClient.Device.VidyoLocalWindowShare p0);


	public void OnLocalWindowShareSelected (com.vidyo.VidyoClient.Device.VidyoLocalWindowShare p0)
	{
		n_OnLocalWindowShareSelected (p0);
	}

	private native void n_OnLocalWindowShareSelected (com.vidyo.VidyoClient.Device.VidyoLocalWindowShare p0);


	public void OnLocalWindowShareStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalWindowShare p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
	{
		n_OnLocalWindowShareStateUpdated (p0, p1);
	}

	private native void n_OnLocalWindowShareStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalWindowShare p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

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
