
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
    [Activity(Label = "SuitActivity")]
    public class SuitActivity : ListActivity
    {
        private string[] items;
        private int Type;
        private int[] Sign =  {
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
        private Resources Res;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Suit);

            Type = Intent.GetIntExtra("SuitType", -1);
            Res = this.Resources;

            switch (Type)
            {
                case 1:
                    LoadHighArkan();
                    break;
                case 2:
                    LoadCupSuit();
                    break;
                case 3:
                    LoadSwordSuit();
                    break;
                case 4:
                    LoadPentacle();
                    break;
                case 5:
                    LoadStaff();
                    break;
                default:
                    break;
            }
        }

        private void LoadHighArkan()
        {
            var titleList = new List<String>();

            for(int i = 0; i < 14; i++)
            {
                titleList.Add(
                    String.Format("{0} {1}",
                    Res.GetString(Sign[i]),
                    Res.GetString(Resource.String.CupTitle)));
            }

            ListAdapter = new ArrayAdapter<String>(this, Resource.Layout.CardListItem, titleList);
        }

        private void LoadCupSuit()
        {
            var titleList = new List<String>();

            for (int i = 0; i < 14; i++)
            {
                titleList.Add(
                    String.Format("{0} {1}",
                    Res.GetString(Sign[i]),
                    Res.GetString(Resource.String.CupTitle)));
            }

            ListAdapter = new ArrayAdapter<String>(this, Resource.Layout.CardListItem, titleList);
        }

        private void LoadSwordSuit()
        {
            var titleList = new List<String>();

            for (int i = 0; i < 14; i++)
            {
                titleList.Add(
                    String.Format("{0} {1}",
                    Res.GetString(Sign[i]),
                    Res.GetString(Resource.String.SwordTitle)));
            }

            ListAdapter = new ArrayAdapter<String>(this, Resource.Layout.CardListItem, titleList);
        }

        private void LoadPentacle()
        {
            var titleList = new List<String>();

            for (int i = 0; i < 14; i++)
            {
                titleList.Add(
                    String.Format("{0} {1}",
                    Res.GetString(Sign[i]),
                    Res.GetString(Resource.String.PentacleTitle)));
            }

            ListAdapter = new ArrayAdapter<String>(this, Resource.Layout.CardListItem, titleList);
        }

        private void LoadStaff()
        {
            var titleList = new List<String>();

            for (int i = 0; i < 14; i++)
            {
                titleList.Add(
                    String.Format("{0} {1}",
                    Res.GetString(Sign[i]),
                    Res.GetString(Resource.String.StaffTitle)));
            }

            ListAdapter = new ArrayAdapter<String>(this, Resource.Layout.CardListItem, titleList);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            var t = items[position];

            Intent cardDetailsIntent = new Intent(this, typeof(CardDetailsActivity));
            cardDetailsIntent.PutExtra("Sign", t);
            cardDetailsIntent.PutExtra("Suit", Type);

            StartActivity(cardDetailsIntent);
        }
    }
}