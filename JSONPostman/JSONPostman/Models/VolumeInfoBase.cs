using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPostman.Models
{
    public class VolumeInfoBase
    {
        public VolumeInfo VolumeInfo { get; set; }
        public VolumeInfoBase(VolumeInfo volumeInfo)
        {
            VolumeInfo = volumeInfo;
        }
    }
}
