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

namespace ListViewDemo
{
    [Activity(Label = "Simple Adapter")]
    public class SimpleAdapterActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            List<Player> players = Player.GetPlayers();
            string[] playerNames = players.Select(x => x.Name).ToArray();
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, playerNames);

            ListView.ItemLongClick += ListView_ItemLongClick;
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);

            string name = (string)this.ListAdapter.GetItem(position);
            string text = string.Format("Clicked on {0}", name);
            Toast.MakeText(this, text, ToastLength.Short).Show();
        }

        private void ListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            string name = (string)this.ListAdapter.GetItem(e.Position);
            string text = string.Format("Long Clicked on {0}", name);
            Toast.MakeText(this, text, ToastLength.Short).Show();
        }
    }
}