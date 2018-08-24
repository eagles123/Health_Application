using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Health_Application.Models
{
    public class UserData
    {

        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public float ProteinIntake { get; set; }

        public float CarbonIntake { get; set; }

        public float FatIntake { get; set; }

        public float CalorieIntake { get; set; }

        public float CalorieComsumption { get; set; }

        public float Distance { get; set; }
    }
}