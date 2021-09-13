using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Rental : Apartment
    {
        public Rental(int id, Adress adress, LegalForm legalForm, float nrOfRooms, float livingArea, float price, int floor) : base(id, adress, legalForm, nrOfRooms, livingArea, price, floor)
        {

        }
        public override string ToString()
        {
            return "Rental apartment: " + NrOfRooms + " rooms | Adress: " + Adress.ToString() + " | Rent: " + Price;
        }
        public override string ShowInfo()
        {
            var sb = new StringBuilder();
            sb.Append(@"{\rtf1\ansi");
            sb.Append(@"\b \fs24");
            sb.Append(Adress.Street);
            sb.Append(@" \b0 \fs18");
            sb.Append(@" \line ");
            sb.Append(Adress.ZipCode + ", " + Adress.City + ", " + Adress.Country);
            sb.Append(@" \line \line");
            sb.Append(@"\b ");
            sb.Append(Price + " kr/month");
            sb.Append(@"\b0 ");
            sb.Append(@" \line \line ");

            sb.Append(@"Housing type \tab \tab Apartment");
            sb.Append(@" \line ");
            sb.Append(@"Legal form \tab \tab Rental");
            sb.Append(@" \line ");
            sb.Append(@"Number of rooms \tab " + NrOfRooms);
            sb.Append(@" \line ");
            sb.Append(@"Living area \tab \tab " + LivingArea + " m^2");
            sb.Append(@" \line ");
            sb.Append(@"Floor \tab \tab \tab " + Floor);
            sb.Append(@" \line ");
            sb.Append(@"Rent \tab \tab \tab " + Price + " kr/month");
            sb.Append(@" \line ");
            sb.Append(@"Price/m^2 \tab \tab " + Price/LivingArea + " kr/m^2");

            sb.Append(@"}");

            return sb.ToString();
        }
    }
}