using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSiteNet.Models
{
    public class Prediction : IValidatableObject
    {
        public int Id { get; set; }
        public int MatchupId { get; set; }
        public Guid AspNetUserId { get; set; }

        public int? HomeTeamScore { get; set; }

        public int? EnemyTeamScore { get; set; }

        public int? PointsEarned { get; set; }
        public Matchup Matchup { get; set; }

        [NotMapped]
        public string EnemyTeamScoreText { get; set; }
        [NotMapped]
        public string HomeTeamScoreText { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (HomeTeamScore != null && HomeTeamScore == EnemyTeamScore)
            {
                yield return new ValidationResult("Neizšķirts nevar būt. :)");
            }
        }
    }
}
