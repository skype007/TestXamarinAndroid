using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Threading.Tasks;
using Android.Graphics;
using System.Net.Http;
using ModernHttpClient;

namespace MonAppDemo
{
    [Activity(Label = "MonAppDemo", MainLauncher = false, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int compteur = 0;
        Button button;
        ImageView image;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            button = FindViewById<Button>(Resource.Id.monBouton);
            button.Click += delegate
            {
                compteur++;
                button.Text = $"{compteur} clicks!";
            };

            image = FindViewById<ImageView>(Resource.Id.monImage);

        }

    }
}

