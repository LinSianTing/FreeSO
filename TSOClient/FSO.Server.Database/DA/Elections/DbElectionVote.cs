﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Server.Database.DA.Elections
{
    public class DbElectionVote
    {
        public uint election_cycle_id { get; set; }
        public uint from_avatar_id { get; set; }
        public DbElectionVoteType type { get; set; }
        public uint target_avatar_id { get; set; }
        public uint date { get; set; }
    }
    
    public enum DbElectionVoteType
    {
        vote,
        nomination
    }
}
