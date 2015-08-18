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
using Android.Content.Res;

namespace Astra
{
    [Activity(Label = "CardDetailsActivity")]
    public class CardDetailsActivity : Activity
    {
        private int Type;
        private int Sign;
        private int[] SignArray =  {
                Resource.String.OneTitle,
                Resource.String.TwoTitle,
                Resource.String.ThreeTitle,
                Resource.String.FourTitle,
                Resource.String.FiveTitle,
                Resource.String.SixTitle,
                Resource.String.SevenTitle,
                Resource.String.EightTitle,
                Resource.String.NineTitle,
                Resource.String.TenTitle,
                Resource.String.ElevenTitle,
                Resource.String.TwelveTitle,
                Resource.String.ThirteenTitle,
                Resource.String.FourteenTitle,
            };
        private int[] TypeArray =  {
                Resource.String.CupTitle,
                Resource.String.SwordTitle,
                Resource.String.PentacleTitle,
                Resource.String.StaffTitle
            };
        private Resources Res;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CardDetails);

            Res = this.Resources;

            Type = Intent.GetIntExtra("Suit", -1);
            Sign = Intent.GetIntExtra("Sign", -1);

            ImageView Poster = FindViewById<ImageView>(Resource.Id.Poster);
            TextView Title = FindViewById<TextView>(Resource.Id.Title);
            EditText Description = FindViewById<EditText>(Resource.Id.Description);

            AddSignTitle(Title);
            AddTypeTitle(Title);
        }
        
        private void AddSignTitle(TextView Title)
        {
            Title.Text = Res.GetString(SignArray[Sign]);
        }

        private void AddTypeTitle(TextView Title)
        {
            if(Type != 1)
                Title.Text += Res.GetString(TypeArray[Type - 1]);
        }

    }
}