using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the Place number 1,2,3 place.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the actual name that give this placement.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the Amount of the Prize at this placement.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the Percentage of the prize at this placement.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
