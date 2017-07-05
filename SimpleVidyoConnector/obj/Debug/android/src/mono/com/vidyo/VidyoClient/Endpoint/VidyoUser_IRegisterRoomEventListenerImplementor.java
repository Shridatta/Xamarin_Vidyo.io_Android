package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoUser_IRegisterRoomEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoUser.IRegisterRoomEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnRoomCreatedByInvite:(Lcom/vidyo/VidyoClient/Endpoint/VidyoRoom;Lcom/vidyo/VidyoClient/Endpoint/VidyoContact;Ljava/lang/String;)V:GetOnRoomCreatedByInvite_Lcom_vidyo_VidyoClient_Endpoint_VidyoRoom_Lcom_vidyo_VidyoClient_Endpoint_VidyoContact_Ljava_lang_String_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoUser/IRegisterRoomEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoUser+IRegisterRoomEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoUser_IRegisterRoomEventListenerImplementor.class, __md_methods);
	}


	public VidyoUser_IRegisterRoomEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoUser_IRegisterRoomEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoUser+IRegisterRoomEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnRoomCreatedByInvite (com.vidyo.VidyoClient.Endpoint.VidyoRoom p0, com.vidyo.VidyoClient.Endpoint.VidyoContact p1, java.lang.String p2)
	{
		n_OnRoomCreatedByInvite (p0, p1, p2);
	}

	private native void n_OnRoomCreatedByInvite (com.vidyo.VidyoClient.Endpoint.VidyoRoom p0, com.vidyo.VidyoClient.Endpoint.VidyoContact p1, java.lang.String p2);

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
