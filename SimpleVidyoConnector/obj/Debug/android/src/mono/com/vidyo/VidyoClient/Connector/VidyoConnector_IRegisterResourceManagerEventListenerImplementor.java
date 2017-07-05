package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterResourceManagerEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterResourceManagerEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnAvailableResourcesChanged:(IIII)V:GetOnAvailableResourcesChanged_IIIIHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterResourceManagerEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnMaxRemoteSourcesChanged:(I)V:GetOnMaxRemoteSourcesChanged_IHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterResourceManagerEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterResourceManagerEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterResourceManagerEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterResourceManagerEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterResourceManagerEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterResourceManagerEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnAvailableResourcesChanged (int p0, int p1, int p2, int p3)
	{
		n_OnAvailableResourcesChanged (p0, p1, p2, p3);
	}

	private native void n_OnAvailableResourcesChanged (int p0, int p1, int p2, int p3);


	public void OnMaxRemoteSourcesChanged (int p0)
	{
		n_OnMaxRemoteSourcesChanged (p0);
	}

	private native void n_OnMaxRemoteSourcesChanged (int p0);

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
