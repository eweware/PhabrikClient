﻿
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
	public class StructurePopFragment : PopSubFragment
    {
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
            var theView = inflater.Inflate(Resource.Layout.StructurePopLayout, container, false);

            return theView;
        }
	}
}
