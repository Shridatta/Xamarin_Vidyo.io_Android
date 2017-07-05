using Android.App;
using Android.Widget;
using Android.OS;
using Com.Vidyo.VidyoClient.Connector;
using static Com.Vidyo.VidyoClient.Connector.VidyoConnector;
using System;

namespace SimpleVidyoConnector
{
    [Activity(Label = "SimpleVidyoConnector", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, IConnect  
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            Setup();

            Button btnConstruct = FindViewById<Button>(Resource.Id.btnConstruct);
            Button btnConnect = FindViewById<Button>(Resource.Id.btnConnect);
            Button btnDisconnect = FindViewById<Button>(Resource.Id.btnDisconnect);

            frmSimpleVideo = FindViewById<FrameLayout>(Resource.Id.frmSimpleVideo);

            btnConstruct.Click += BtnConstruct_Click;
            btnConnect.Click += BtnConnect_Click;
            btnDisconnect.Click += BtnDisconnect_Click;
        }
        VidyoConnector vc;
        FrameLayout frmSimpleVideo;
        private void BtnConstruct_Click(object sender, System.EventArgs e)
        {
            vc = new VidyoConnector(frmSimpleVideo, VidyoConnector.VidyoConnectorViewStyle.VIDYOCONNECTORVIEWSTYLEDefault, 16, "", "", 0);
            vc.ShowViewAt(frmSimpleVideo, 0, 0, frmSimpleVideo.Width, frmSimpleVideo.Height);
        }

        private void BtnDisconnect_Click(object sender, System.EventArgs e)
        {
            vc.Disconnect();
        }
        private void BtnConnect_Click(object sender, System.EventArgs e)
        {
            string token = "";
            string appId = "";
            string userName = "";
            string roomName = "";
            vc.Connect(appId, token, userName, roomName, this);
        }

        void Setup()
        {
            Connector.SetApplicationUIContext(this);
            Connector.Initialize();
        }

        public void OnDisconnected(VidyoConnectorDisconnectReason p0)
        {
        }

        public void OnFailure(VidyoConnectorFailReason p0)
        {
        }

        public void OnSuccess()
        {
        }
    }
}

