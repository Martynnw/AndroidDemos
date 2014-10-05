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
    public class CheckBoxActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            List<Player> players = Player.GetPlayers();
            this.ListAdapter = new CheckBoxAdapter(this, players);
        }

        private class CheckBoxAdapter : BaseAdapter<Player>
        {
            private Activity activity;
            private List<Player> data;

            public CheckBoxAdapter(Activity activity, List<Player> data)
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
                    view = this.activity.LayoutInflater.Inflate(Resource.Layout.PlayerListItem4, null);
                }

                Player player = this.data[position];

                view.FindViewById<TextView>(Resource.Id.txtName).Text = player.Name;
                view.FindViewById<TextView>(Resource.Id.txtTeam).Text = player.Team;

                CheckBox chkCaptain = view.FindViewById<CheckBox>(Resource.Id.chkCaptain);
                chkCaptain.Tag = player.Name;

                chkCaptain.SetOnCheckedChangeListener(null);
                chkCaptain.Checked = player.Captain;
                chkCaptain.SetOnCheckedChangeListener(new CheckedChangeListener(this.activity));

                return view;
            }

            private class CheckedChangeListener : Java.Lang.Object, CompoundButton.IOnCheckedChangeListener
            {
                private Activity activity;

                public CheckedChangeListener(Activity activity)
                {
                    this.activity = activity;
                }

                public void OnCheckedChanged(CompoundButton buttonView, bool isChecked)
                {
                    if (isChecked)
                    {
                        string name = (string)buttonView.Tag;
                        string text = string.Format("{0} Checked.", name);
                        Toast.MakeText(this.activity, text, ToastLength.Short).Show();
                    }
                }
            }
        }
    }
}