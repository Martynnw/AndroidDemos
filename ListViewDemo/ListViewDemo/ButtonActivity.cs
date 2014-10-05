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
    [Activity(Label = "Custom Adapter")]
    public class ButtonActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            List<Player> players = Player.GetPlayers();
            this.ListAdapter = new ButtonAdapter(this, players);
        }

        private class ButtonAdapter : BaseAdapter<Player>
        {
            private Activity activity;
            private List<Player> data;

            public ButtonAdapter(Activity activity, List<Player> data)
            {
                this.activity = activity;
                this.data = data;
            }

            public override Player this[int position]
            {
                get { return this.data[position]; }
            }

            public override int Count
            {
                get { return this.data.Count(); }
            }

            public override long GetItemId(int position)
            {
                return 0;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                View view = convertView;

                if (view == null)
                {
                    view = this.activity.LayoutInflater.Inflate(Resource.Layout.PlayerListItem3, null);
                }

                Player player = this.data[position];

                string name = player.Name;

                if (player.Captain)
                {
                    name = string.Format("{0} (c)", name);
                }

                view.FindViewById<TextView>(Resource.Id.txtName).Text = name;
                view.FindViewById<TextView>(Resource.Id.txtTeam).Text = player.Team;

                Button button1 = view.FindViewById<Button>(Resource.Id.button1);
                button1.Tag = name;
                button1.SetOnClickListener(new ButtonClickListener(this.activity));

                return view;
            }

            private class ButtonClickListener : Java.Lang.Object, View.IOnClickListener
            {
                private Activity activity;

                public ButtonClickListener(Activity activity)
                {
                    this.activity = activity;
                }

                public void OnClick(View v)
                {
                    string name = (string)v.Tag;
                    string text = string.Format("{0} Pressed.", name);
                    Toast.MakeText(this.activity, text, ToastLength.Short).Show();
                }
            }
        }
    }
}