using MySql.Data.EntityFramework;
using ExamApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamApp.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class WorkshopContext : DbContext
    {
        public DbSet<Workshop> Workshops { get; set; }
        public WorkshopContext() : base("WorkshopApp")
        {

        }
    }
}