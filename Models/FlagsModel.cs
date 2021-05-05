using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransferSherzan.Models
{

    public class FlagsModel
    {
        private List<flag> flags;
        private List<string> gameFilters;
        private List<string> categoryFilters;
        public string gameFilter { get; set; }
        public string categoryFilter { get; set; }
        
        private void loadFlags()
        {
            this.flags.Add(new flag { Country = "Canada", ImagePath = "Canada.jpeg", Category = "Indoor", Game = "Winter Olympics" });
            this.flags.Add(new flag { Country = "Sweden", ImagePath = "Sweden.jpeg", Category = "Indoor", Game = "Winter Olympics" });
            this.flags.Add(new flag { Country = "Great Britain", ImagePath = "GreatBritain.jpeg", Category = "Indoor", Game = "Winter Olympics" });
            this.flags.Add(new flag { Country = "Jamaica", ImagePath = "Jamaica.jpeg", Category = "Outdoor", Game = "Winter Olympics" });
            this.flags.Add(new flag { Country = "Italy", ImagePath = "Italy.jpeg", Category = "Outdoor", Game = "Winter Olympics" });
            this.flags.Add(new flag { Country = "Japan", ImagePath = "Japan.jpeg", Category = "Outdoor", Game = "Winter Olympics" });
            this.flags.Add(new flag { Country = "Germany", ImagePath = "Germany.jpeg", Category = "Indoor", Game = "Summer Olympics" });
            this.flags.Add(new flag { Country = "China", ImagePath = "China.jpeg", Category = "Indoor", Game = "Summer Olympics" });
            this.flags.Add(new flag { Country = "Mexico", ImagePath = "Mexico.jpeg", Category = "Indoor", Game = "Summer Olympics" });
            this.flags.Add(new flag { Country = "Brazil", ImagePath = "Brazil.jpeg", Category = "Outdoor", Game = "Summer Olympics" });
            this.flags.Add(new flag { Country = "Netherlands", ImagePath = "Netherlands.jpeg", Category = "Outdoor", Game = "Summer Olympics" });
            this.flags.Add(new flag { Country = "USA", ImagePath = "USA.jpeg", Category = "Outdoor", Game = "Summer Olympics" });
            this.flags.Add(new flag { Country = "Thailand", ImagePath = "Thailand.jpeg", Category = "Indoor", Game = "Paralympics" });
            this.flags.Add(new flag { Country = "Uruguay", ImagePath = "Uruguay.jpeg", Category = "Indoor", Game = "Paralympics" });
            this.flags.Add(new flag { Country = "Ukraine", ImagePath = "Ukraine.jpeg", Category = "Indoor", Game = "Paralympics" });
            this.flags.Add(new flag { Country = "Austria", ImagePath = "Austria.jpeg", Category = "Outdoor", Game = "Paralympics" });
            this.flags.Add(new flag { Country = "Pakistan", ImagePath = "Pakistan.jpeg", Category = "Outdoor", Game = "Paralympics" });
            this.flags.Add(new flag { Country = "Zimbabwe", ImagePath = "Zimbabwe.jpeg", Category = "Outdoor", Game = "Paralympics" });
            this.flags.Add(new flag { Country = "France", ImagePath = "France.jpeg", Category = "Indoor", Game = "Youth Olympic Games" });
            this.flags.Add(new flag { Country = "Cyprus", ImagePath = "Cyprus.jpeg", Category = "Indoor", Game = "Youth Olympic Games" });
            this.flags.Add(new flag { Country = "Russia", ImagePath = "Russia.jpeg", Category = "Indoor", Game = "Youth Olympic Games" });
            this.flags.Add(new flag { Country = "Finland", ImagePath = "Finland.jpeg", Category = "Outdoor", Game = "Youth Olympic Games" });
            this.flags.Add(new flag { Country = "Slovakia", ImagePath = "Slovakia.jpeg", Category = "Outdoor", Game = "Youth Olympic Games" });
            this.flags.Add(new flag { Country = "Portugal", ImagePath = "Portugal.jpeg", Category = "Outdoor", Game = "Youth Olympic Games" });

        }
        public List<flag> Flags
        {
            get
            {
                return flags;
            }
        }
        public List<flag> FilteredFlags
        {
            get
            {
                List<flag> filteredFlags = this.flags;
                if (this.categoryFilter != "All")
                {
                    filteredFlags = this.flags.Where(flag => flag.Category == this.categoryFilter).ToList<flag>();
                }
                if (this.gameFilter != "All")
                {
                    filteredFlags = filteredFlags.Where(flag => flag.Game == this.gameFilter).ToList<flag>();
                }
                return filteredFlags;
            }
        }
        public FlagsModel()
        {
            flags = new List<flag>();
            this.loadFlags();
            this.flags = this.flags.OrderBy(flag => flag.Country).ToList<flag>();
            this.gameFilters = this.flags.Select(flag => flag.Game).Distinct().ToList<string>();
            this.gameFilters.Add("All");
            this.gameFilters.Sort();
            this.categoryFilters = this.flags.Select(flag => flag.Category).Distinct().ToList<string>();
            this.categoryFilters.Add("All");
            this.categoryFilters.Sort();
            this.categoryFilter = "All";
            this.gameFilter = "All";

        }

        public List<string> GameFilters 
        {
            get { return this.gameFilters; }
        }
        public List<string> CategoryFilters
        {
            get { return this.categoryFilters; }
        }


    }


}
