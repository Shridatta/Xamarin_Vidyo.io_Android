package md5cf03f7031fcedd0ec1df4aaa2f273a3c;


public class MainActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Connector.VidyoConnector.IConnect
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_OnDisconnected:(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorDisconnectReason;)V:GetOnDisconnected_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorDisconnectReason_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IConnectInvoker, VidyoClientAndroid\n" +
			"n_OnFailure:(Lcom/vidyo/VidyoClient/Connector/VidyoConnector$VidyoConnectorFailReason;)V:GetOnFailure_Lcom_vidyo_VidyoClient_Connector_VidyoConnector_VidyoConnectorFailReason_Handler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IConnectInvoker, VidyoClientAndroid\n" +
			"n_OnSuccess:()V:GetOnSuccessHandler:Com.Vidyo.VidyoClient.Connector.VidyoConnector/IConnectInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("SimpleVidyoConnector.MainActivity, SimpleVidyoConnector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("SimpleVidyoConnector.MainActivity, SimpleVidyoConnector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void OnDisconnected (com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason p0)
	{
		n_OnDisconnected (p0);
	}

	private native void n_OnDisconnected (com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorDisconnectReason p0);


	public void OnFailure (com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason p0)
	{
		n_OnFailure (p0);
	}

	private native void n_OnFailure (com.vidyo.VidyoClient.Connector.VidyoConnector.VidyoConnectorFailReason p0);


	public void OnSuccess ()
	{
		n_OnSuccess ();
	}

	private native void n_OnSuccess ();

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
