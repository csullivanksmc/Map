using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace spotter.Models
{
    public class Spot
    {
        public string spotName { get; set; }
        public string spotAddress { get; set; }
        public int ID { get; set; }
        public Double lat { get; set; }
        public Double lng { get; set; }
    }
}