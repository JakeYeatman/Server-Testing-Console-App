using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDSWebAPI.Models
{
    public class CarValution
    {
        public string RegPlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Mileage { get; set; }
        public bool MileageEstimate { get; set; }
        public double ValuationRetail { get; set; }
        public double ValuationTrade { get; set; }
        public DateTime DateOfValuation { get; } = DateTime.Now;
    }
}
