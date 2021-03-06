﻿using System;
using Android.App;
using Android.Views;

namespace DroidKaigi2016Xamarin.Droid.Activities
{
    public class SessionDetailActivityBinding
    {
        public ViewGroup Root { get; }

        public static SessionDetailActivityBinding SetContentView(Activity activity, int layoutId)
        {
            return new SessionDetailActivityBinding(activity, layoutId);
        }

        private SessionDetailActivityBinding(Activity activity, int layoutId)
        {
            activity.SetContentView(layoutId);

            var decorView = activity.Window.DecorView;
            Root = (ViewGroup) decorView.FindViewById(global::Android.Resource.Id.Content);
        }
    }
}

