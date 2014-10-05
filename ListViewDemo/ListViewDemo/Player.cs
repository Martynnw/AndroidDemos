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
    class Player
    {
        public enum RoleEnum
        {
            Batsman,
            Bowler,
            Allrounder,
            WicketKeeper
        }

        public string Name { get; set; }
        public string Team { get; set; }
        public bool Captain { get; set; }
        public RoleEnum Role { get; set; }

        public static List<Player> GetPlayers()
        {
            List<Player> result = new List<Player>();

            result.Add(new Player { Name = "Samit Patel", Team = "Notts", Role = RoleEnum.Batsman, Captain = false });
            result.Add(new Player { Name = "Chris Read", Team = "Notts", Role = RoleEnum.WicketKeeper, Captain = true });
            result.Add(new Player { Name = "Alex Hales", Team = "Notts", Role = RoleEnum.Batsman, Captain = false });
            result.Add(new Player { Name = "Luke Fletcher", Team = "Notts", Role = RoleEnum.Bowler, Captain = false });
            result.Add(new Player { Name = "Paul Collingwood", Team = "Durham", Role = RoleEnum.Batsman, Captain = true });
            result.Add(new Player { Name = "Ben Stokes", Team = "Durham", Role = RoleEnum.Batsman, Captain = false });
            result.Add(new Player { Name = "Stuart Broad", Team = "Notts", Role = RoleEnum.Bowler, Captain = false });
            result.Add(new Player { Name = "Matt Prior", Team = "Sussex", Role = RoleEnum.WicketKeeper, Captain = false });
            result.Add(new Player { Name = "Ian Bell", Team = "Warks", Role = RoleEnum.Batsman, Captain = false });
            result.Add(new Player { Name = "Jimmy Anderson", Team = "Lancashire", Role = RoleEnum.Batsman, Captain = false });

            return result;
        }
    }
}