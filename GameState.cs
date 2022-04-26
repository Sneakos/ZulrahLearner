using System.Drawing;

namespace ZulrahLearner
{
    public class GameState
    {

        public bool Debug_mode { get; set; }
        public bool Correct { get; set; }
        public bool ShowCorrectSquare { get; set; }

        public int BlockIDClicked { get; set; }
        public int PhaseBlock { get; set; }
        public int CorrectCount { get; set; }
        public int IncorrectCount { get; set; }
        public int CurrentSpeed { get; set; }

        public Point PointClicked { get; set; }

        public Prayer CurrentPrayer { get; set; }
        public Weapon CurrentWeapon { get; set; }
        public Helm CurrentHelm { get; set; }
    }
}
