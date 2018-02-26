﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMM.Models
{
    public class LatLngModel
    {
        public int deviceid { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public double PrevLat { get; set; }
        public double PrevLng { get; set; }
    }
}
