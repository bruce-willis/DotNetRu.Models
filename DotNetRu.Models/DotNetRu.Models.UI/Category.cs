﻿using System.Collections.Generic;

namespace DotNetRu.Models.UI
{
    public class Category
    {
        /// <summary>
        /// Gets or sets the name that is displayed during filtering
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short name/code that is displayed on the sessions page.
        /// For instance the short name for Xamarin.Forms is X.Forms
        /// </summary>
        /// <value>The short name.</value>
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the color in Hex form, for instance #FFFFFF
        /// </summary>
        /// <value>The color.</value>
        public string Color { get; set; }

        public virtual ICollection<TalkModel> Sessions { get; set; }

        public bool IsFiltered { get; }

        public bool IsEnabled { get; }

        public string BadgeName => string.IsNullOrWhiteSpace(this.ShortName) ? this.Name : this.ShortName;
    }
}