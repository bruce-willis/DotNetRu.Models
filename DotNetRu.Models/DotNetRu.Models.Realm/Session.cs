using System;
using System.Linq;
using Realms;

namespace DotNetRu.Models.Realm
{
    public class Session : RealmObject
    {
        public Talk Talk { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public DateTimeOffset EndTime { get; set; }

        [Backlink(nameof(Models.Realm.Meetup.Sessions))]
        public IQueryable<Meetup> Meetup { get; }
    }
}