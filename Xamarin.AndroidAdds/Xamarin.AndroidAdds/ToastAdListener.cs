using System;
using Android.Content;
using Android.Gms.Ads;
using Android.Widget;

namespace com.google.android.gms.samples.ads
{
    public class ToastAdListener : AdListener
    {
        private readonly Context mContext;

        public ToastAdListener(Context context)
        {
            mContext = context;
        }

        public override void OnAdLoaded()
        {
            Toast.MakeText(mContext, "onAdLoaded()", ToastLength.Long).Show();
        }

        public override void OnAdFailedToLoad(int errorCode)
        {
            String errorReason = "";
            switch (errorCode)
            {
                case AdRequest.ErrorCodeInternalError:
                    errorReason = "Internal error";
                    break;
                case AdRequest.ErrorCodeInvalidRequest:
                    errorReason = "Invalid request";
                    break;
                case AdRequest.ErrorCodeNetworkError:
                    errorReason = "Network Error";
                    break;
                case AdRequest.ErrorCodeNoFill:
                    errorReason = "No fill";
                    break;
            }
            Toast.MakeText(mContext, String.Format("onAdFailedToLoad({0})", errorReason), ToastLength.Long).Show();
        }

        public override void OnAdOpened()
        {
            Toast.MakeText(mContext, "onAdOpened()", ToastLength.Long).Show();
        }

        public override void OnAdClosed()
        {
            Toast.MakeText(mContext, "onAdClosed()", ToastLength.Long).Show();
        }

        public override void OnAdLeftApplication()
        {
            Toast.MakeText(mContext, "onAdLeftApplication()", ToastLength.Long).Show();
        }
    }
}