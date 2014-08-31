using Android.App;
using Android.Gms.Ads;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace com.google.android.gms.samples.ads
{
    [Activity(Label = "@string/banner_in_code")]
    public class BannerCodeActivity : Activity
    {
        private AdView mAdView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_banner_code_ad_listener);

            mAdView = new AdView(this);
            mAdView.AdUnitId = Resources.GetString(Resource.String.ad_unit_id);
            mAdView.AdSize = AdSize.Banner;
            mAdView.AdListener = new ToastAdListener(this);
            var layout = FindViewById<RelativeLayout>(Resource.Id.mainLayout);
            var par = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);
            layout.AddView(mAdView, par);
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