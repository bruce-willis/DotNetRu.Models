using System;
using System.Xml.Serialization;

namespace DotNetRu.Models.Xml
{
    [XmlType("Session")]
    public class SessionEntity
    {
        public string TalkId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}