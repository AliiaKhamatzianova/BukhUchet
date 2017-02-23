using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BukhUchet.Models
{
    [Table("Rasxod")]
    public class Rasxod
    {
        [Key]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public double Summa { get; set; }

        public string Comment { get; set; }
    }
}
