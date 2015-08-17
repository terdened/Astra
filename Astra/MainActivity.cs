using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Astra
{
    [Activity(Label = "Astra", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            
            Button HighArkanButton = FindViewById<Button>(Resource.Id.HighArkan);
            Button CupSuitButton = FindViewById<Button>(Resource.Id.CupSuit);
            Button SwordSuitButton = FindViewById<Button>(Resource.Id.SwordSuit);
            Button PentacleSuitButton = FindViewById<Button>(Resource.Id.PentacleSuit);
            Button StaffSuitButton = FindViewById<Button>(Resource.Id.StaffSuit);

            HighArkanButton.Click += delegate { GoToSuit(1); };
            CupSuitButton.Click += delegate { GoToSuit(2); };
            SwordSuitButton.Click += delegate { GoToSuit(3); };
            PentacleSuitButton.Click += delegate { GoToSuit(4); };
            StaffSuitButton.Click += delegate { GoToSuit(5); };
        }

        private void GoToSuit(int suitType)
        {
            Intent suitIntent = new Intent(this, typeof(SuitActivity));
            suitIntent.PutExtra("SuitType", suitType);
            StartActivity(suitIntent);
        }   
    }
}

