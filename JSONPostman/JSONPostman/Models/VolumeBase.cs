using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPostman.Models
{
    public class VolumeBase
    {
        public Volume Volume { get; set; }

        public VolumeBase(Volume volume)
        {
            Volume = volume;
        }
    }
}
