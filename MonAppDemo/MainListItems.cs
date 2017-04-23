using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MonAppDemo.CustomAdapters;

namespace MonAppDemo
{
    [Activity(Label = "MainListItems", MainLauncher = true)]
    public class MainListItems : Activity
    {
        ListView listview;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RoundItemsList);

            listview = FindViewById<ListView>(Resource.Id.myListView);

            // Create your application here
            var uneListe = new List<string> { "Item1", "Item2" };
            var adapter = new MyAdapter(this, uneListe);
            listview.Adapter = adapter;
        }
    }
}