namespace Scoreboard.Classes.GameStatistics
{
    public struct MatchEvent
    {
        private string _eventName;
        private string _eventInfo;

        public string EventName
        {
            get => _eventName;
            set => _eventName = value;
        }
        public string EventInfo
        {
            get => _eventInfo;
            set => _eventInfo = value;
        }
    }
}
