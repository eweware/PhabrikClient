using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Phabrik.AndroidApp
{
    public class FleetListFragment : Android.Support.V4.App.Fragment
    {
        public GameFragment gameFragment { get; set; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var theView = inflater.Inflate(Resource.Layout.FleetListLayout, container, false);

            return theView;
        }
    }
}