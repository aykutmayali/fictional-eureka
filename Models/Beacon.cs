using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_1
{
    public class Beacon
    {      
        [Key]
        public int ID { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Date { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Type { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Location { get; set; }

        public int rssi1 { get; set; }

        public int rssi2 { get; set; }

        public int rssi3 { get; set; }

        public int rssi4 { get; set; }

        public int Mac { get; set; }


    }
}
