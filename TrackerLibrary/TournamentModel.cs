using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the Tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// This is the Entry Fee for the Tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// This is a List of all the teams entered into the Tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// This is a list of all the Prizes in the Tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// This is a List of the Rounds and what teams are in each round.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
