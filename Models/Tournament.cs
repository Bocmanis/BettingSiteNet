﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSiteNet.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MatchupClosingTime { get; set; }
        [DisplayName("Nosaukums")]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int PointsForPerfect { get; set; }
        public int PointForDifference { get; set; }
        public int PointsForWinnerOnly { get; set; }

        public Country Country { get; set; }
        public List<Matchup>  Matchups { get; set; }

        [NotMapped]
        public bool HasUserJoinedTournament { get; set; }

    }
}
