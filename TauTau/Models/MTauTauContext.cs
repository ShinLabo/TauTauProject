﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TauTau.Models
{
    public class MTauTauContext : DbContext
    {
        public DbSet<MTauTau> MTauTaus { get; set; }
    }
}