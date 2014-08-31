using Android.App;
using Android.Gms.Ads;
using Android.OS;
using Android.Widget;

namespace com.google.android.gms.samples.ads
{
    [Activity(Label = "@string/interstitial", Icon = "@drawable/ic_launcher")]
    public class InterstitialActivity : Activity
    {
        private InterstitialAd mInterstitial;
        private Button mLoadButton;
        private Button mShowButton;

        /** Called when the activity is first created. */

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_interstitial);

            mInterstitial = new InterstitialAd(this);
            mInterstitial.AdUnitId = Resources.GetString(Resource.String.ad_unit_id_interstitial);

            mShowButton = FindViewById<Button>(Resource.Id.showButton);
            mShowButton.Click += delegate { ShowInterstitial(); };
            mShowButton.Enabled = false;
            mLoadButton = FindViewById<Button>(Resource.Id.loadButton);
            mLoadButton.Click += delegate { LoadInterstitial(); };

            var adsListener = new InterstitialToastAdListener(this, mShowButton);
            mInterstitial.AdListener = adsListener;
        }

        public void LoadInterstitial()
        {
            mShowButton.Text = "Loading Interstitial...";
            mShowButton.Enabled = false;
            mInterstitial.LoadAd(new AdRequest.Builder().Build());
        }

        public void ShowInterstitial()
        {
            if (mInterstitial.IsLoaded)
            {
                mInterstitial.Show();
            }

            mShowButton.Text = "Interstitial Not Ready";
            mShowButton.Enabled = false;
        }
    }
}