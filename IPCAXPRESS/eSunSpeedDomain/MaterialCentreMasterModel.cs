﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSunSpeedDomain
{
    public class MaterialCentreMasterModel:AddressModel
    {
        public int MC_Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string PrintName { get; set; }
        public string Group { get; set; }
        public string StockAccount { get; set; }
        public bool EnableStockinBal { get; set; }
        public string SalesAccount { get; set; }
        public string PurchaseAccount { get; set; }
        public bool EnableAccinTransfer { get; set; }        
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
