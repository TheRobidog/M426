using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportBet.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Odds { get; set; }
        public string Amount { get; set; }
    }
}