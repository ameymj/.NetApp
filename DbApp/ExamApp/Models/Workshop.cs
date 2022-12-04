using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamApp.Models
{
  
        [Table("WorkshopManagement")]
        public class Workshop
        {
            public int Id { get; set; }
            public string Topic { get; set; }
            public string Description { get; set; }
            public string Faculty { get; set; }
            public string Location { get; set; }
        }
    }
