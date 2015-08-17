
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

namespace Astra
{
    [Activity(Label = "SuitActivity")]
    public class SuitActivity : ListActivity
    {
        private string[] items;
        private int Type;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Suit);

            Type = Intent.GetIntExtra("SuitType", -1);

            switch(Type)
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
            String[] sign =  {"Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева",
                "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы"};
            ListAdapter = new ArrayAdapter<String>(this, Resource.Layout.CardListItem, sign);
        }

        private void LoadCupSuit()
        {
            String[] sign =  {"Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева",
                "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы"};
            ListAdapter = new ArrayAdapter<String>(this, Resource.Layout.CardListItem, sign);
        }

        private void LoadSwordSuit()
        {
            String[] sign =  {"Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева",
                "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы"};
            ListAdapter = new ArrayAdapter<String>(this, Resource.Layout.CardListItem, sign);
        }

        private void LoadPentacle()
        {
            String[] sign =  {"Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева",
                "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы"};
            ListAdapter = new ArrayAdapter<String>(this, Resource.Layout.CardListItem, sign);
        }

        private void LoadStaff()
        {
            String[] sign =  {"Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева",
                "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы"};
            ListAdapter = new ArrayAdapter<String>(this, Resource.Layout.CardListItem, sign);
        }
    }
}