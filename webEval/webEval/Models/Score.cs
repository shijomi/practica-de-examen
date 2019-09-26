using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace webEval.Models
{    public enum Sex
    {
        masculino,
        femenino,

    }

    public class Score
    {
        public int scoreID { get; set; }
        public string name { get; set; }
        public Sex sex { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime birthdate { get; set; }
    }
}