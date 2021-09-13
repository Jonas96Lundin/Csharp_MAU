using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Store : Commercial
    {
        public Store(int id, Adress adress, LegalForm legalForm, float nrOfRooms, float livingArea, float price) : base(id, adress, legalForm, nrOfRooms, livingArea, price)
        {

        }
        public override string ToString()
        {
            if (LegalForm == LegalForm.LegalOwnership)
            {
                return "Store: " + LivingArea + " m^2 | Adress: " + Adress.ToString() + " | Price: " + Price;
            }
            else
            {
                return "Store: " + LivingArea + " m^2 | Adress: " + Adress.ToString() + " | Rent: " + Price;
            }
        }
        public override string ShowInfo()
        {
            return "Rental apartment \r\n ;";
        }
    }
}