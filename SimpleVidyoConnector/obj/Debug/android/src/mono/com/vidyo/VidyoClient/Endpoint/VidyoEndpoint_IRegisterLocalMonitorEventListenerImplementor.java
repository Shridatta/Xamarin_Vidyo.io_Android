package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoEndpoint_IRegisterLocalMonitorEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterLocalMonitorEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnLocalMonitorAdded:(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V:GetOnLocalMonitorAdded_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalMonitorRemoved:(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V:GetOnLocalMonitorRemoved_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalMonitorSelected:(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;)V:GetOnLocalMonitorSelected_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLocalMonitorStateUpdated:(Lcom/vidyo/VidyoClient/Device/VidyoLocalMonitor;Lcom/vidyo/VidyoClient/Device/VidyoDevice$VidyoDeviceState;)V:GetOnLocalMonitorStateUpdated_Lcom_vidyo_VidyoClient_Device_VidyoLocalMonitor_Lcom_vidyo_VidyoClient_Device_VidyoDevice_VidyoDeviceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterLocalMonitorEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterLocalMonitorEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoEndpoint_IRegisterLocalMonitorEventListenerImplementor.class, __md_methods);
	}


	public VidyoEndpoint_IRegisterLocalMonitorEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoEndpoint_IRegisterLocalMonitorEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterLocalMonitorEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnLocalMonitorAdded (com.vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
	{
		n_OnLocalMonitorAdded (p0);
	}

	private native void n_OnLocalMonitorAdded (com.vidyo.VidyoClient.Device.VidyoLocalMonitor p0);


	public void OnLocalMonitorRemoved (com.vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
	{
		n_OnLocalMonitorRemoved (p0);
	}

	private native void n_OnLocalMonitorRemoved (com.vidyo.VidyoClient.Device.VidyoLocalMonitor p0);


	public void OnLocalMonitorSelected (com.vidyo.VidyoClient.Device.VidyoLocalMonitor p0)
	{
		n_OnLocalMonitorSelected (p0);
	}

	private native void n_OnLocalMonitorSelected (com.vidyo.VidyoClient.Device.VidyoLocalMonitor p0);


	public void OnLocalMonitorStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalMonitor p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1)
	{
		n_OnLocalMonitorStateUpdated (p0, p1);
	}

	private native void n_OnLocalMonitorStateUpdated (com.vidyo.VidyoClient.Device.VidyoLocalMonitor p0, com.vidyo.VidyoClient.Device.VidyoDevice.VidyoDeviceState p1);

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
