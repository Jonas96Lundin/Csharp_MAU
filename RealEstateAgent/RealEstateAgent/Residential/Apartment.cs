using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Apartment : Residential
    {
        private int floor;
        public int Floor
        {
            get { return floor; }
            set
            {
                if (value > 0)
                {
                    floor = value;
                }
            }
        }
        public Apartment(int id, Adress adress, LegalForm legalForm, float nrOfRooms, float livingArea, float price, int floor) : base(id, adress, legalForm, nrOfRooms, livingArea, price)
        {
            this.floor = floor;
        }
    }
}