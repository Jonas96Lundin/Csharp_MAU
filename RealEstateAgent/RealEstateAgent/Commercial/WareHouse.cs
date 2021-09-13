using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class WareHouse : Commercial
    {
        public WareHouse(int id, Adress adress, LegalForm legalForm, float nrOfRooms, float livingArea, float price) : base(id, adress, legalForm, nrOfRooms, livingArea, price)
        {

        }
        public override string ToString()
        {
            if (LegalForm == LegalForm.LegalOwnership)
            {
                return "Warehouse: " + LivingArea + " m^2 | Adress: " + Adress.ToString() + " | Price: " + Price;
            }
            else
            {
                return "Warehouse: " + LivingArea + " m^2 | Adress: " + Adress.ToString() + " | Rent: " + Price;
            }
        }
        public override string ShowInfo()
        {
            return "Rental apartment \r\n ;";
        }
    }
}