using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Ticket
    {
        private string moviename;
        private int cinemaroom;
        private DateTime starttime;
        private decimal price;
        private int minimumage;
        private bool discount;


        public Ticket(string movieName, int cinemaRoom, DateTime startTime, decimal price, int minimumAge)
        {
            MovieName = movieName;
            CinemaRoom = cinemaRoom;
            StartTime = startTime;
            Price = price;
            MinimumAge = minimumAge;
            discount = Discount;
        }




        public string MovieName
        {
            get { return moviename; }

            set
            {
                if (!String.IsNullOrEmpty(value))
                    moviename = value;
                else
                    throw new ArgumentException("Error occured : Movie name can't be empty!", "moviename");
            }
        }
        
        public int CinemaRoom
        {
            get { return cinemaroom; }

            set
            {
                if (value <= 5 && value > 0)
                    cinemaroom = value;
                else
                    throw new ArgumentException("Error occured : Invalid cinema room {" + value + "}!", "cinemaroom");
            }
        }

        public DateTime StartTime
        {
            get { return starttime; }

            set
            {
                if (value.Minute == 30 || value.Minute == 0)
                    starttime = value;
                else
                    throw new ArgumentException("Error occured : Each movie should start on the hour or on the half hour!", "starttime");
            }
        }

        public int MinimumAge
        {
            get { return minimumage; }

            set
            {
                if (value == 0 || value == 6 || value == 9 || value == 12 || value == 16)
                    minimumage = value;
                else
                    throw new ArgumentException("Error occured : Invalid age!", "minimumage");

            }
        }

        public decimal Price { get { return price; } set { price = value; } }

        public bool Discount 
        {
            get {
                if (starttime.DayOfWeek == DayOfWeek.Monday || starttime.DayOfWeek == DayOfWeek.Tuesday)
                    return true;
                else
                    return false;
            }

            private set{ }
        }
    }
}
