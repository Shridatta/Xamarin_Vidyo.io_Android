package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterWebProxyEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterWebProxyEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnWebProxyCredentialsRequest:()V:GetOnWebProxyCredentialsRequestHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterWebProxyEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterWebProxyEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterWebProxyEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterWebProxyEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterWebProxyEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterWebProxyEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnWebProxyCredentialsRequest ()
	{
		n_OnWebProxyCredentialsRequest ();
	}

	private native void n_OnWebProxyCredentialsRequest ();

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
