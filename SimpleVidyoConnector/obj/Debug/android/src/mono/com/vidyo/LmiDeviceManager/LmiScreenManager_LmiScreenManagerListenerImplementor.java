package mono.com.vidyo.LmiDeviceManager;


public class LmiScreenManager_LmiScreenManagerListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vidyo.LmiDeviceManager.LmiScreenManager.LmiScreenManagerListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getDisplays:()[Landroid/view/Display;:GetGetDisplaysHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid\n" +
			"n_getName:(I)Ljava/lang/String;:GetGetName_IHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid\n" +
			"n_getRealHeight:(I)I:GetGetRealHeight_IHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid\n" +
			"n_getRealWidth:(I)I:GetGetRealWidth_IHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid\n" +
			"n_start:()Z:GetStartHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid\n" +
			"n_stop:()V:GetStopHandler:Com.Vidyo.LmiDeviceManager.LmiScreenManager/ILmiScreenManagerListenerInvoker, VidyoClientAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Vidyo.LmiDeviceManager.LmiScreenManager+ILmiScreenManagerListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LmiScreenManager_LmiScreenManagerListenerImplementor.class, __md_methods);
	}


	public LmiScreenManager_LmiScreenManagerListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LmiScreenManager_LmiScreenManagerListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Vidyo.LmiDeviceManager.LmiScreenManager+ILmiScreenManagerListenerImplementor, VidyoClientAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.Display[] getDisplays ()
	{
		return n_getDisplays ();
	}

	private native android.view.Display[] n_getDisplays ();


	public java.lang.String getName (int p0)
	{
		return n_getName (p0);
	}

	private native java.lang.String n_getName (int p0);


	public int getRealHeight (int p0)
	{
		return n_getRealHeight (p0);
	}

	private native int n_getRealHeight (int p0);


	public int getRealWidth (int p0)
	{
		return n_getRealWidth (p0);
	}

	private native int n_getRealWidth (int p0);


	public boolean start ()
	{
		return n_start ();
	}

	private native boolean n_start ();


	public void stop ()
	{
		n_stop ();
	}

	private native void n_stop ();

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
