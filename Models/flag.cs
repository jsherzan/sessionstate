using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransferSherzan.Models
{
    public class flag
    {
        public string ImagePath { get; set; }
        public string Country { get; set; }
        public string Game { get; set; }
        public string Category { get; set; }
        public string ToolTip { 
            get
            {
                return "Country: " + this.Country + " Category: " + this.Category + " Game: " + this.Game;
            } 
        }
    }
   
}
