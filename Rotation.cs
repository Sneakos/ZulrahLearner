using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Common;

namespace ZulrahLearner
{
    public class Rotation
    {
        public List<Phase> Phases { get; set; }

        private int _currPhase;
        private string _rotation;

        public Rotation(string rotation)
        {
            rotation = rotation.ToUpper();

            switch (rotation)
            {
                case "A":
                    LoadPhases(DataFiles.RotationA); break;
                case "B":
                    LoadPhases(DataFiles.RotationB); break;
                case "C":
                    LoadPhases(DataFiles.RotationC); break;
                case "D":
                    LoadPhases(DataFiles.RotationD); break;
                default:
                    Phases = new List<Phase>(); break;
            }

            _currPhase = 0;
            _rotation = rotation;
        }

        private void LoadPhases(string fileName)
        {
            string phasesJson = File.ReadAllText(fileName);

            Phases = phasesJson.Deserialize<List<Phase>>();
        }

        [JsonIgnore]
        public Phase CurrentPhase
        {
            get
            {
                return Phases[_currPhase];
            }
        }

        public bool NextPhase()
        {
            _currPhase++;

            if (_currPhase >= Phases.Count)
            {
                _currPhase = 0;

                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "Rotation: " + _rotation + "    Phase: " + (_currPhase + 1);
        }
    }
}