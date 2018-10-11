using System;

namespace DotNetRu.Models.UI
{
    public class SessionModel
    {
        public TalkModel Talk { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public DateTimeOffset EndTime { get; set; }

        public MeetupModel Meetup { get; set; }
    }
}