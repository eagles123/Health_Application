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

        public DateTime Date { get; set; }

        public int ProteinIntake { get; set; }

        public int CarbonIntake { get; set; }

        public int FatIntake { get; set; }

        public int CalorieIntake { get; set; }

        public int CalorieComsumption { get; set; }

        public short Distance { get; set; }
    }
}