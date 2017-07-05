package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoRoom_IRegisterRoomPropertiesEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterRoomPropertiesEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnRoomPropertiesChanged:(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom$VidyoRoomProperties;)V:GetOnRoomPropertiesChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_VidyoRoomProperties_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterRoomPropertiesEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoRoom+IRegisterRoomPropertiesEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoRoom_IRegisterRoomPropertiesEventListenerImplementor.class, __md_methods);
	}


	public VidyoRoom_IRegisterRoomPropertiesEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoRoom_IRegisterRoomPropertiesEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoRoom+IRegisterRoomPropertiesEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnRoomPropertiesChanged (com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0)
	{
		n_OnRoomPropertiesChanged (p0);
	}

	private native void n_OnRoomPropertiesChanged (com.vidyo.VidyoClient.Endpoint.VidyoRoom.VidyoRoomProperties p0);

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
