using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetVue.Models
{
    public class SecurityItem
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; }

        public SecurityItem()
        {
            Name = string.Empty;
            IsChecked = false;
        }
    }
}