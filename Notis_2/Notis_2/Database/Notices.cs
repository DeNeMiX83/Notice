using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notis_2.Database
{
    [Table("Friends")]
    public class Notices
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string description { get; set; }
        public string time { get; set; }
        public DateTime date {get; set;}

        public string uniDate { get { return date.ToShortDateString(); } }
       


        public string description_full { get; set; }
    }
}
