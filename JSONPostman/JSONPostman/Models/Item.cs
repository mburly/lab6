using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPostman.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string SelfLink { get; set; }
        public VolumeInfo VolumeInfo { get; set; }
        public Item(string id, string selfLink, VolumeInfo volumeInfo)
        {
            Id = id;
            SelfLink = selfLink;
            VolumeInfo = volumeInfo;
        }
        public override string ToString()
        {
            return $"Id: {Id}\nTitle: {VolumeInfo.Title}\nAuthors: {String.Join(", ", VolumeInfo.Authors)}\nDescription: {VolumeInfo.Description}\nLink: {SelfLink}";
        }
    }
}
