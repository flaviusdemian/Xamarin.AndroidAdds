using System;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace com.google.android.gms.samples.ads
{
    [Activity(Label = "GoogleAdsSampleActivity", MainLauncher = true, Icon = "@drawable/ic_launcher")]
    public class GoogleAdsSampleActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            try
            {
                Resources res = Resources;
                Sample[] samples =
                {
                    new Sample(res.GetString(Resource.String.banner_in_xml), typeof (BannerXmlActivity)),
                    new Sample(res.GetString(Resource.String.banner_in_code), typeof (BannerCodeActivity)),
                    new Sample(res.GetString(Resource.String.interstitial), typeof (InterstitialActivity))
                };
                ListAdapter = new ArrayAdapter<Sample>(this, Android.Resource.Layout.SimpleListItem1, samples);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected override void OnListItemClick(ListView listView, View view, int position, long id)
        {
            try
            {
                var sample = (Sample)listView.GetItemAtPosition(position);
                var intent = new Intent(ApplicationContext, sample.getActivityClass());
                StartActivity(intent);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}