using System.Collections.Generic;
using System.Linq;

namespace ZulrahLearner
{
    public class Phase
    {
        public Weapon Weapon { get; set; }
        public Helm Helm { get; set; }
        public Prayer Prayer { get; set; }
        public int ZulrahLocationBlockID { get; set; }
        public ZulrahStyle ZulrahStyle { get; set; }
        public List<List<int>> PlayerBlockIDs { get; set; }
        public bool JadPhase { get; set; }
    }

    public class Phase_Old
    {
        public Weapon Weapon { get; set; }
        public Helm Helm { get; set; }
        public Prayer Prayer { get; set; }
        public int ZulrahLocationBlockID { get; set; }
        public ZulrahStyle ZulrahStyle { get; set; }
        public List<int> PlayerBlockIDs { get; set; }
        public bool JadPhase { get; set; }

        public Phase ConvertToNewPhase()
        {
            Phase phase = new()
            {
                Weapon = Weapon,
                Helm = Helm,
                Prayer = Prayer,
                ZulrahLocationBlockID = ZulrahLocationBlockID,
                ZulrahStyle = ZulrahStyle,
                PlayerBlockIDs = new List<List<int>>(),
                JadPhase = JadPhase
            };

            foreach(int id in PlayerBlockIDs)
            {
                phase.PlayerBlockIDs.Add(new List<int>());
                phase.PlayerBlockIDs.Last().Add(id);
            }

            return phase;
        }
    }
}
