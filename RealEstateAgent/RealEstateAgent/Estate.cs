using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    /// <summary>
    /// Base class for estates
    /// </summary>
    public abstract class Estate : IEstate
    {
        //Variables
        private int id;
        private float nrOfRooms;
        private float livingArea;
        private float price;
        private float plotSize;
        private Adress adress;
        private LegalForm legalForm;

        //Properties
        public int ID
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }
        }
        public Adress Adress
        {
            get { return adress; }
            set
            {
                if (value != null)
                {
                    adress = value;
                }
            }
        }
        public LegalForm LegalForm
        {
            get { return legalForm; }
            set
            {
                legalForm = value;
            }
        }
        public float Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public float PlotSize
        {
            get { return plotSize; }
            set
            {
                plotSize = value;
            }
        }
        public float NrOfRooms
        {
            get { return nrOfRooms; }
            set
            {
                nrOfRooms = value;
            }
        }
        public float LivingArea
        {
            get { return livingArea; }
            set
            {
                livingArea = value;
            }
        }
        //Default constructor
        public Estate() { }
        public Estate(int id, Adress adress, LegalForm legalForm, float nrOfRooms, float livingArea, float price)
        {
            this.id = id;
            if (adress != null)
            {
                this.adress = adress;
            }
            this.legalForm = legalForm;
            this.nrOfRooms = nrOfRooms;
            this.livingArea = livingArea;
            this.price = price;
        }

        public abstract string ShowInfo();
    }
}