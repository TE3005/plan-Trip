using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class WetTrack : PartsOfTrack {


        private static string recommendation;

        private float maxDepth;

        private string description;

        private bool swimming;

        public float MaxDepth { get; set; }

        public string Description { get; set; }

        public bool Swimming { get; set; }


        public WetTrack()
        {
        }
    }
}
