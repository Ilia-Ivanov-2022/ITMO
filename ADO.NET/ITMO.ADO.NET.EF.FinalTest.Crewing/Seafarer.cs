using System;
using System.ComponentModel.DataAnnotations;

namespace ITMO.ADO.NET.EF.FinalTest.Crewing
{
    public class Seafarer
    {
        public int SeafarerId { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [MaxLength(20)]
        public string Position { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public byte[] Photo { get; set; }
        public Vessel Vessel { get; set; }
    }
}
