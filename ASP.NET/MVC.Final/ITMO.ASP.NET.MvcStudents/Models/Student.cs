using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASP.NET.MvcStudents.Models
{
    public class Student
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(30)]
        public string LastName { get; set; }
        [Range(1,5)]
        public int? AdoMark { get; set; }
        [Range(1, 5)]
        public int? AspMark { get; set; }
        [Range(1, 5)]
        public int? JavaMark { get; set; }

        public int TotalScore(int mark1, int mark2, int mark3)
        {
            return mark1 + mark2 + mark3;
        }
    }
}