﻿namespace DotNetRu.Models.UI
{
    /// <summary>
    /// Per user feedback
    /// </summary>
    public class Feedback
    {
        public string UserId { get; set; }

        public string SessionId { get; set; }

        public int SessionRating { get; set; }
    }
}