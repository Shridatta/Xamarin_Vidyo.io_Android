package mono.com.vidyo.VidyoClient.Endpoint;


public class VidyoRoom_IRegisterParticipantEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.VidyoClient.Endpoint.VidyoRoom.IRegisterParticipantEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnDynamicParticipantChanged:(Ljava/util/ArrayList;Ljava/util/ArrayList;)V:GetOnDynamicParticipantChanged_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnLoudestParticipantChanged:(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;Z)V:GetOnLoudestParticipantChanged_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_ZHandler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnParticipantJoined:(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V:GetOnParticipantJoined_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid\n" +
			"n_OnParticipantLeft:(Lcom/vidyo/VidyoClient/Endpoint/VidyoParticipant;)V:GetOnParticipantLeft_Lcom_vidyo_VidyoClient_Endpoint_VidyoParticipant_Handler:Com.Vidyo.VidyoClient.Endpoint.VidyoRoom/IRegisterParticipantEventListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.VidyoClient.Endpoint.VidyoRoom+IRegisterParticipantEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VidyoRoom_IRegisterParticipantEventListenerImplementor.class, __md_methods);
	}


	public VidyoRoom_IRegisterParticipantEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VidyoRoom_IRegisterParticipantEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.VidyoClient.Endpoint.VidyoRoom+IRegisterParticipantEventListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void OnDynamicParticipantChanged (java.util.ArrayList p0, java.util.ArrayList p1)
	{
		n_OnDynamicParticipantChanged (p0, p1);
	}

	private native void n_OnDynamicParticipantChanged (java.util.ArrayList p0, java.util.ArrayList p1);


	public void OnLoudestParticipantChanged (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0, boolean p1)
	{
		n_OnLoudestParticipantChanged (p0, p1);
	}

	private native void n_OnLoudestParticipantChanged (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0, boolean p1);


	public void OnParticipantJoined (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
	{
		n_OnParticipantJoined (p0);
	}

	private native void n_OnParticipantJoined (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0);


	public void OnParticipantLeft (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0)
	{
		n_OnParticipantLeft (p0);
	}

	private native void n_OnParticipantLeft (com.vidyo.VidyoClient.Endpoint.VidyoParticipant p0);

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
