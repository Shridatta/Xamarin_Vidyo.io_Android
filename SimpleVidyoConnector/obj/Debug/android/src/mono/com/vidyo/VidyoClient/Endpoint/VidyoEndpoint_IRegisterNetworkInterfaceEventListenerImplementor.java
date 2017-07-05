package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoEndpoint_IRegisterNetworkInterfaceEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoEndpoint.IRegisterNetworkInterfaceEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnNetworkInterfaceAdded:(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V:GetOnNetworkInterfaceAdded_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnNetworkInterfaceRemoved:(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;)V:GetOnNetworkInterfaceRemoved_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnNetworkInterfaceSelected:(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceTransportType;)V:GetOnNetworkInterfaceSelected_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceTransportType_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnNetworkInterfaceStateUpdated:(Lcom/vidyo/VidyoClient/VidyoNetworkInterface;Lcom/vidyo/VidyoClient/VidyoNetworkInterface$VidyoNetworkInterfaceState;)V:GetOnNetworkInterfaceStateUpdated_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_Lcom_vidyo_VidyoClient_VidyoNetworkInterface_VidyoNetworkInterfaceState_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint/IRegisterNetworkInterfaceEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterNetworkInterfaceEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoEndpoint_IRegisterNetworkInterfaceEventListenerImplementor.class, __md_methods);
	}


	public VidyoEndpoint_IRegisterNetworkInterfaceEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoEndpoint_IRegisterNetworkInterfaceEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoEndpoint+IRegisterNetworkInterfaceEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnNetworkInterfaceAdded (com.vidyo.VidyoClient.VidyoNetworkInterface p0)
	{
		n_OnNetworkInterfaceAdded (p0);
	}

	private native void n_OnNetworkInterfaceAdded (com.vidyo.VidyoClient.VidyoNetworkInterface p0);


	public void OnNetworkInterfaceRemoved (com.vidyo.VidyoClient.VidyoNetworkInterface p0)
	{
		n_OnNetworkInterfaceRemoved (p0);
	}

	private native void n_OnNetworkInterfaceRemoved (com.vidyo.VidyoClient.VidyoNetworkInterface p0);


	public void OnNetworkInterfaceSelected (com.vidyo.VidyoClient.VidyoNetworkInterface p0, com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1)
	{
		n_OnNetworkInterfaceSelected (p0, p1);
	}

	private native void n_OnNetworkInterfaceSelected (com.vidyo.VidyoClient.VidyoNetworkInterface p0, com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceTransportType p1);


	public void OnNetworkInterfaceStateUpdated (com.vidyo.VidyoClient.VidyoNetworkInterface p0, com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1)
	{
		n_OnNetworkInterfaceStateUpdated (p0, p1);
	}

	private native void n_OnNetworkInterfaceStateUpdated (com.vidyo.VidyoClient.VidyoNetworkInterface p0, com.vidyo.VidyoClient.VidyoNetworkInterface.VidyoNetworkInterfaceState p1);

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
