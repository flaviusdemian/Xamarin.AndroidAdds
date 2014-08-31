using Android.App;
using Android.Gms.Ads;
using Android.OS;

namespace com.google.android.gms.samples.ads
{
    [Activity(Label = "@string/banner_in_xml")]
    public class BannerXmlActivity : Activity
    {
        private AdView mAdView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_banner_xml);

            mAdView = FindViewById<AdView>(Resource.Id.adView);
            mAdView.AdListener = new ToastAdListener(this);
            mAdView.LoadAd(new AdRequest.Builder().Build());
        }

        protected override void OnPause()
        {
            mAdView.Pause();
            base.OnPause();
        }

        protected override void OnResume()
        {
            base.OnResume();
            mAdView.Resume();
        }

        protected override void OnDestroy()
        {
            mAdView.Destroy();
            base.OnDestroy();
        }
    }
}