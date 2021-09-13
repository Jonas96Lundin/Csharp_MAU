using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    /// <summary>
    /// Holds information about an adress
    /// </summary>
    public class Adress
    {
        string street;
        string zipCode;
        string city;
        Countries country;
        public string Street
        {
            get { return street; }
            set
            {
                if (value != null)
                    value = street;
            }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set
            {
                if (value != null)
                    value = zipCode;
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (value != null)
                    value = city;
            }
        }
        public Countries Country
        {
            get { return country; }
            set
            {
                value = country;
            }
        }

        public Adress(string street, string zipCode, string city, Countries country)
        {
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
            this.country = country;
        }

        public override string ToString()
        {
            return street + ", " + city + ", " + country;
        }
    }
}