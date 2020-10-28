using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Rate
    {

        private string userMail;

        private string trackName;

        private int rating;

        private string feedback;

        private DateTime ratingDate;


        public string UserMail { get; set; }
        public string TrackName { get; set; }
        public int Rating { get; set; }
        public string Feedback { get; set; }
        public DateTime RatingDate { get; set; }

        public Rate()
        {

        }


    }
}
