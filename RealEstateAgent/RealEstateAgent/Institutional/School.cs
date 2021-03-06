using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class School : Institutional
    {
        public School(int id, Adress adress, LegalForm legalForm, string name, float nrOfRooms, float livingArea, float price) : base(id, adress, legalForm, name, nrOfRooms, livingArea, price)
        {
            
        }
        public override string ToString()
        {
            return "School: " + Name + " | Adress: " + Adress.ToString() + " | Price: " + Price;
        }
        public override string ShowInfo()
        {
            return "Rental apartment \r\n ;";
        }
    }
}