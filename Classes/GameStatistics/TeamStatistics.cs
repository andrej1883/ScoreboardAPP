namespace Scoreboard.Classes.GameStatistics
{
    public struct TeamStatistics
    {
        private string _name;
        private int _goals;
        private int _shots;
        private int _faceOffs;

        public int FaceOffs
        {
            get => _faceOffs;
            set => _faceOffs = value;
        }

        private Time _penalTime;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Goals
        {
            get => _goals;
            set => _goals = value;
        }

        public int Shots
        {
            get => _shots;
            set => _shots = value;
        }

        public Time PenalTime
        {
            get => _penalTime;
            set => _penalTime = value;
        }
    }
}