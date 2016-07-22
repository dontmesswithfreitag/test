using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freNWTools.Internals
{
    public class Settings
    {
        public static bool  ShowMobs
        { 
            get { return Properties.Settings.Default.ShowMobs; }
            set
            {
                Properties.Settings.Default.ShowMobs = value;
                Properties.Settings.Default.Save();
            }
        }


        public static bool ShowLoot
        {
            get { return Properties.Settings.Default.ShowLoot; }
            set
            {
                Properties.Settings.Default.ShowLoot = value;
                Properties.Settings.Default.Save();
            }
        }

        public static bool ShowPets
        {
            get { return Properties.Settings.Default.ShowPets; }
            set
            {
                Properties.Settings.Default.ShowPets = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool ShowNPC
        {
            get { return Properties.Settings.Default.ShowNPC; }
            set
            {
                Properties.Settings.Default.ShowNPC = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool Show { get; set; }


     
    }
}
