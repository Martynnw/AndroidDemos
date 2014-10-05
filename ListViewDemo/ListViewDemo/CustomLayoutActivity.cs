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
    public class CustomLayoutActivity : ListActivity
    {
        private List<Player> data;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.SetContentView(Resource.Layout.CustomLayout);

            this.FindViewById<Button>(Resource.Id.btnSort).Click += this.btnSort_Click;
            this.FindViewById<Button>(Resource.Id.btnJustNotts).Click += this.btnJustNotts_Click;
            this.FindViewById<Button>(Resource.Id.btnEmpty).Click += this.btnEmpty_Click;

            data = Player.GetPlayers();
            this.ListAdapter = new PlayerAdapter(this, data);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<Player> data = this.data.OrderBy(x => x.Name).ToList();
            ((PlayerAdapter)this.ListAdapter).UpdateData(data);
        }

        private void btnJustNotts_Click(object sender, EventArgs e)
        {
            List<Player> data = this.data.Where(x => x.Team == "Notts").ToList();
            ((PlayerAdapter)this.ListAdapter).UpdateData(data);
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            List<Player> data = new List<Player>();
            ((PlayerAdapter)this.ListAdapter).UpdateData(data);
        }

        private class PlayerAdapter : BaseAdapter<Player>
        {
            private Activity activity;
            private List<Player> data;

            public PlayerAdapter(Activity activity, List<Player> data)
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
                    view = this.activity.LayoutInflater.Inflate(Resource.Layout.PlayerListItem1, null);
                }

                Player player = this.data[position];

                string name = player.Name;

                if (player.Captain)
                {
                    name = string.Format("{0} (c)", name);
                }

                view.FindViewById<TextView>(Resource.Id.txtName).Text = name;
                view.FindViewById<TextView>(Resource.Id.txtTeam).Text = player.Team;

                ImageView imgRoleIcon = view.FindViewById<ImageView>(Resource.Id.imgRoleIcon);

                switch (player.Role)
                {
                    case Player.RoleEnum.Batsman:
                        imgRoleIcon.SetImageResource(Resource.Drawable.Bat);
                        break;

                    case Player.RoleEnum.Bowler:
                        imgRoleIcon.SetImageResource(Resource.Drawable.Ball);
                        break;

                    case Player.RoleEnum.WicketKeeper:
                        imgRoleIcon.SetImageResource(Resource.Drawable.Wicket);
                        break;

                    case Player.RoleEnum.Allrounder:
                        throw new NotImplementedException();
                }

                return view;
            }

            public void UpdateData(List<Player> data)
            {
                this.data = data;
                this.NotifyDataSetChanged();
            }
        }
    }
}