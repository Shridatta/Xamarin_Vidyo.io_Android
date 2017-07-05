package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoEndpoint_IRegisterLocalRendererEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalRendererEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnLocalRendererAdded:(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V:GetOnLocalRendererAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalRendererEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalRendererRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V:GetOnLocalRendererRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalRendererEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalRendererSelected:(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;)V:GetOnLocalRendererSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalRendererEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalRendererStateUpdated:(Lcom/vidyo/VidyoClient/Device/VidyoLocalRenderer;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V:GetOnLocalRendererStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalRenderer_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalRendererEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterLocalRendererEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoEndpoint_IRegisterLocalRendererEventListenerImplementor.class, __md_methods);
	}


	public VidyoEndpoint_IRegisterLocalRendererEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoEndpoint_IRegisterLocalRendererEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterLocalRendererEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnLocalRendererAdded (com.vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
	{
		n_OnLocalRendererAdded (p0);
	}

	private native void n_OnLocalRendererAdded (com.vidyo.VidyoClient.Device.VidyoLocalRenderer p0);


	public void OnLocalRendererRemoved (com.vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
	{
		n_OnLocalRendererRemoved (p0);
	}

	private native void n_OnLocalRendererRemoved (com.vidyo.VidyoClient.Device.VidyoLocalRenderer p0);


	public void OnLocalRendererSelected (com.vidyo.VidyoClient.Device.VidyoLocalRenderer p0)
	{
		n_OnLocalRendererSelected (p0);
	}

	private native void n_OnLocalRendererSelected (com.vidyo.VidyoClient.Device.VidyoLocalRenderer p0);


	public void OnLocalRendererStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalRenderer p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
	{
		n_OnLocalRendererStateUpdated (p0, p1);
	}

	private native void n_OnLocalRendererStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalRenderer p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

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
