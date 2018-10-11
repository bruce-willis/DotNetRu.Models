using Realms;

namespace DotNetRu.Models.Realm
{
    public class AuditVersion : RealmObject
    {
        public string CommitHash { get; set; }
    }
}
