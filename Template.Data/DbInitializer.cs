using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.Data
{
    public class DbInitializer 
    {
        public  void InitializeDb(MatricExcellenceDbContext context)
        {
            //context.Database.EnsureCreated();

            //if (context.Reports.Any())
            //{
            //    return;
            //}

            //var ReportList = new List<Report>()
            //{
            //    new Report
            //    {
            //        Short = 4114,
            //        Long =55245,
            //    },
            //    new Report
            //    {
            //        Short = 4589,
            //        Long =55245,
            //    },
            //    new Report
            //    {
            //        Short = 41124114,
            //        Long =8745,
            //    }
            //}.ToList();

            //foreach (var Report in ReportList)
            //{
            //    context.Reports.Add(Report);
            //}

            //context.SaveChanges();
        }
    }
}
