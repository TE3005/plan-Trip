using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Parking : ExtraServices
    {

        private string description;

        private string startPoint;

        private string endPoint;

        public string Description { get; set; }

        public string StartPoint { get; set; }

        public string EndPoint { get; set; }

        public Parking()
        {
        }
    }

    

}