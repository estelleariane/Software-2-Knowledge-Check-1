﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Apartment : Building
    {
        public int NumberOfUnits { get; set; }
        public int NumberOfOpenUnits { get; set; }

        public bool HasParking { get; set; }


        //public Apartment(string Street, int StreetNumber, int NumberOfUnits, int NumberOfOpenUnits, bool HasParking)
        //{
        //    this.Street = Street;
        //    this.StreetNumber = StreetNumber;                
        //    this.NumberOfUnits = NumberOfUnits;
        //    this.NumberOfOpenUnits = NumberOfOpenUnits;
        //    this.HasParking = HasParking;                    
        //}
    }
}
