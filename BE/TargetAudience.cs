using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TargetAudience
    {
        private bool forAdults;

        private bool forDisabled; 

        private bool forGoodWalkers;

        private bool forFamilies;

        public bool ForAdults { get; set; }
        public bool ForDisabled { get; set; }
        public bool ForGoodWalkers { get; set; }
        public bool ForFamilies { get; set; }

        public TargetAudience()
        {
        }

        


    }
}
