using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewGeneration.Models
{
    public class Pupil
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Phone { get; set; }
    }
}