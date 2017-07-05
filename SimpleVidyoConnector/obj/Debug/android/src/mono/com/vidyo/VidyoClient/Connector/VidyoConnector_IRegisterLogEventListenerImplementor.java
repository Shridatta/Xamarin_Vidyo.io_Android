package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterLogEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterLogEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnLog:(Lcom/vidyo/VidyoClient/Endpoint/VidyoLogRecord;)V:GetOnLog_Lcom_vidyo_VidyoClient_Endpoint_VidyoLogRecord_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterLogEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterLogEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterLogEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterLogEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterLogEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterLogEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnLog (com.vidyo.VidyoClient.Endpoint.VidyoLogRecord p0)
	{
		n_OnLog (p0);
	}

	private native void n_OnLog (com.vidyo.VidyoClient.Endpoint.VidyoLogRecord p0);

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
