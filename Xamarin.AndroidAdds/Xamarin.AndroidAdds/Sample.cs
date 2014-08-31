using System;

namespace com.google.android.gms.samples.ads
{
    public class Sample : Java.Lang.Object
    {
        private readonly Type mActivityClass;
        private readonly String mTitle;

        public Sample(String title, Type activityClass)
        {
            mTitle = title;
            mActivityClass = activityClass;
        }

        public override String ToString()
        {
            return mTitle;
        }

        public Type getActivityClass()
        {
            return mActivityClass;
        }
    }
}