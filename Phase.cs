using System.Collections.Generic;

namespace ZulrahLearner
{
    public class Phase
    {
        public Weapon Weapon { get; set; }
        public Helm Helm { get; set; }
        public Prayer Prayer { get; set; }
        public int ZulrahLocationBlockID { get; set; }
        public ZulrahStyle ZulrahStyle { get; set; }
        public List<int> PlayerBlockIDs { get; set; }
        public bool JadPhase { get; set; }
    }
}
