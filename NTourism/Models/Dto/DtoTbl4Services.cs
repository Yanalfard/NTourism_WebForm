using NTourism.Models.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTourism.Models.Dto
{
    public class DtoTbl4Services
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Status { get; set; }

        public DtoTbl4Services(Tbl4Services tbl)
        {
            id = tbl.id;
            Title = tbl.Title;
            Text = tbl.Text;
            Status = tbl.Status;
        }
    }
}