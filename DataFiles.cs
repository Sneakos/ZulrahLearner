using OSRSGearSetup;

namespace ZulrahLearner
{
    public class DataFiles : Helper
    {
        private static string ZulrahData = @$"{DataPath}ZulrahData\";

        public static string RotationA = @$"{ZulrahData}RotationA.json";
        public static string RotationB = @$"{ZulrahData}RotationB.json";
        public static string RotationC = @$"{ZulrahData}RotationC.json";
        public static string RotationD = @$"{ZulrahData}RotationD.json";        
        public static string Blocks = @$"{ZulrahData}Blocks.json";
    }
}