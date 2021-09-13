using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    /// <summary>
    /// Interface that set rules for the Estate class
    /// </summary>
    public interface IEstate
    {
        //Properties
        int ID { get; set; }
        Adress Adress { get; set; }
        LegalForm LegalForm { get; set; }
    }
}