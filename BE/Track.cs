using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BE
{
    public class Track
    { 

        private string name;

        private string description;

        private Area area;

        private int trackLength;

        private float rate;

        private bool isCircular;

        private TargetAudience forWho;

        private AproachingWays aproachingWays;

        private Cost cost;

        private List<PartsOfTrack> parts;

        private List<ExtraServices> additionalServices;



        public string Name { get; set; }

        public string Description { get; set; }

        public Area Area { get; set; }

        public int TrackLength { get; set; }

        public float Rate { get; set; }

        public bool IsCircular { get; set; }

        public TargetAudience ForWho { get; set; }

        public AproachingWays AproachingWays { get; set; }

        public Cost Cost { get; set; }

        public List<PartsOfTrack> Parts { get; set; }

        public List<ExtraServices> AdditionalServices { get; set; }


        public Track()
        {
        }






        /// <summary>
        /// @param string 
        /// @param float 
        /// @return
        /// </summary>
        public void rateTrack(string trackName, float rate)
        {
            // TODO implement here
            
        }

        /// <summary>
        /// @param Track
        /// </summary>
        public void saveTrack(Track track)
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public List<Track> findTrack()
        {
            // TODO implement here
            return null;
        }

    }
}
