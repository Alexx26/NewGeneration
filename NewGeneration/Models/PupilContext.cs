using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NewGeneration.Models
{
    public class PupilContext : DbContext
    {
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Parent> Parents { get; set; }
    }

}