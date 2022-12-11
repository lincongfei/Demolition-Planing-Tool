﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demolition_Planing_Tool
{
    public class Waste
    {
        private string wasteID;
        private double billing;
        private bool roomExclusive = true;
        private string unit;
        private int quantities = 0;
        
        public Waste(string wasteID, int quatities)
        {
            this.wasteID = wasteID;
            quantities = quatities;
            var wasteValue = WasteData.wasteData[wasteID];
            billing = double.Parse(wasteValue[1], System.Globalization.CultureInfo.InvariantCulture);
            unit = wasteValue[2];
            roomExclusive = bool.Parse(wasteValue[3]);
        }

        public string WasteID
        { 
            get { return wasteID; } 
            set { wasteID = value; }
        }

        public double Billing
        { 
            get { return billing; }
            set { billing = value; } 
        }
        
        public int Quantities 
        {
            get { return quantities; }
            set { quantities = value; } 
        }

        public bool RoomExclusive 
        {
            get { return roomExclusive; }
            set { roomExclusive = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
