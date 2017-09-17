using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TeamOfPlayer.Models
{
    public class TeamOfPlayerContext : DbContext
    {
    
        public TeamOfPlayerContext() : base("name=TeamOfPlayerContext")
        {
        }

        public DbSet<TeamOfPlayer.Player> Players { get; set; }

        public DbSet<TeamOfPlayer.Team> Teams { get; set; }
    }
}
