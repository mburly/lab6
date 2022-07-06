using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPostmanDotNET.Models
{
    public class VolumeInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Authors { get; set; }

        public VolumeInfo(string title, string description, string[] authors)
        {
            Title = title;
            Description = description;
            Authors = authors;
        }
    }
}
