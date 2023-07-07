using System.Drawing;

namespace ZulrahLearner
{
    public class GameState
    {
        public static bool Debug_mode { get; set; } = false;
        public static bool ShowGridLines { get; set; } = false;
        public static bool Correct { get; set; } = false;
        public static bool ShowCorrectSquare { get; set; } = false;

        public static bool CorrectSpotClicked { get; set; } = false;
        public static int PhaseBlock { get; set; } = 0;
        public static int CorrectCount { get; set; } = 0;
        public static int IncorrectCount { get; set; } = 0;

        public static Point PointClicked { get; set; } = new Point(-25, -10);

        public static Prayer CurrentPrayer { get; set; } = Prayer.None;
        public static Weapon CurrentWeapon { get; set; } = Weapon.Staff;
        public static Helm CurrentHelm { get; set; } = Helm.Mage;
    }
}
