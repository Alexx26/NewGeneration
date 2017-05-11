using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewGeneration.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public int Phone { get; set; }
        public int PupilId { get; set; }
    }
}