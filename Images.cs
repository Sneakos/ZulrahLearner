using OSRSGearSetup;
using System.Drawing;

namespace ZulrahLearner
{
    public class Images : Helper
    {
        //public static Image Crossbow = Image.FromFile(upperDirectory + "Crossbow.png");
        //public static Image Staff = Image.FromFile(upperDirectory + "Staff.png");
        //public static Image MageHelm = Image.FromFile(upperDirectory + "MageHelm.png");
        //public static Image RangeHelm = Image.FromFile(upperDirectory + "RangeHelm.png");
        //public static Image MagePrayerOff = Image.FromFile(upperDirectory + "MageOff.png");
        //public static Image RangePrayerOff = Image.FromFile(upperDirectory + "RangeOff.png");
        //public static Image MeleePrayerOff = Image.FromFile(upperDirectory + "MeleeOff.png");
        //public static Image MagePrayerOn = Image.FromFile(upperDirectory + "MageOn.png");
        //public static Image RangePrayerOn = Image.FromFile(upperDirectory + "RangeOn.png");
        //public static Image MeleePrayerOn = Image.FromFile(upperDirectory + "MeleeOn.png");

        private static string ImagePath = @$"{AssetsPath}Images\";

        public static Image ZulrahMage = Image.FromFile($@"{ImagePath}ZulrahMage.png");
        public static Image ZulrahRange = Image.FromFile($@"{ImagePath}ZulrahRange.png");
        public static Image ZulrahMelee = Image.FromFile($@"{ImagePath}ZulrahMelee.png");
        public static Image ZulrahShrine = Image.FromFile($@"{ImagePath}Shrine.png");
        public static Image ZulrahShrineWithGridLines = Image.FromFile($@"{ImagePath}ShrineWithGridLines.png");
    }
}
