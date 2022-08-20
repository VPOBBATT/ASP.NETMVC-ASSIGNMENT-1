using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootballCode.Models
{
    public class Football
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatchID { get; set; }
        [Required]
        public string TeamName1 { get; set; }
        [Required]
        public string TeamName2 { get; set; }
        [Required]
        public string Status { get; set; }
        [Compare("FootBall.Status")]
        public string WinningTeam { get; set; }
        [Required]
        public int Points { get; set; }
    }
}