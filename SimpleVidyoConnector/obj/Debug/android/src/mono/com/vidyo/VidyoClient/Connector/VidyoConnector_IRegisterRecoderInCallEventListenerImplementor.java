package mono.com.vidyo.VidyoClient.Connector;


public class VidyoConnector_IRegisterRecoderInCallEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IRegisterRecoderInCallEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_RecorderInCall:(Z)V:GetRecorderInCall_ZHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IRegisterRecoderInCallEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterRecoderInCallEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoConnector_IRegisterRecoderInCallEventListenerImplementor.class, __md_methods);
	}


	public VidyoConnector_IRegisterRecoderInCallEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoConnector_IRegisterRecoderInCallEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Connector.VidyoConnector+IRegisterRecoderInCallEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void RecorderInCall (boolean p0)
	{
		n_RecorderInCall (p0);
	}

	private native void n_RecorderInCall (boolean p0);

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
