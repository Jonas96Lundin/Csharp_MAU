using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Institutional : Estate
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
        public Institutional(int id, Adress adress, LegalForm legalForm, string name, float nrOfRooms, float livingArea, float price) : base(id, adress, legalForm, nrOfRooms, livingArea, price)
        {
            this.name = name;
        }
    }
}