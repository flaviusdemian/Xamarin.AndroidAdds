using Android.Content;
using Android.Widget;

namespace com.google.android.gms.samples.ads
{
    internal class InterstitialToastAdListener : ToastAdListener
    {
        private readonly Button mShowButton = null;

        public InterstitialToastAdListener(Context context, Button mShowButton)
            : base(context)
        {
            this.mShowButton = mShowButton;
        }

        public override void OnAdLoaded()
        {
            base.OnAdLoaded();
            if (mShowButton != null)
            {
                mShowButton.Text = "Show Interstitial";
                mShowButton.Enabled = true;
            }
        }

        public override void OnAdFailedToLoad(int errorCode)
        {
            base.OnAdFailedToLoad(errorCode);
            if (mShowButton != null)
            {
                mShowButton.Text = "Ad Failed to Load";
                mShowButton.Enabled = false;
            }
        }
    }
}