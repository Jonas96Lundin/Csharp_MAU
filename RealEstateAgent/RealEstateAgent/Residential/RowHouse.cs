using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class RowHouse : Villa
    {
        public RowHouse(int id, Adress adress, LegalForm legalForm, float nrOfRooms, float livingArea, float price) : base(id, adress, legalForm, nrOfRooms, livingArea, price)
        {

        }
        public override string ToString()
        {
            if (LegalForm == LegalForm.LegalOwnership)
            {
                return "Rowhouse: " + NrOfRooms + " rooms | Adress: " + Adress.ToString() + " | Price: " + Price;
            }
            else
            {
                return "Rowhouse: " + NrOfRooms + " rooms | Adress: " + Adress.ToString() + " | Rent: " + Price;
            }
        }
        public override string ShowInfo()
        {
            return "Rental apartment \r\n ;";
        }
    }
}