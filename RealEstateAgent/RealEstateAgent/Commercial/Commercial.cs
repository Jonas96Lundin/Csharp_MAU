﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Commercial : Estate
    {
        public Commercial(int id, Adress adress, LegalForm legalForm, float nrOfRooms, float livingArea, float price) : base(id, adress, legalForm, nrOfRooms, livingArea, price)
        {

        }
    }
}