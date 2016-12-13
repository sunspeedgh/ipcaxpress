﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSunSpeedDomain
{
    public class ContraVoucherModel
    {
        public int Id { get; set; }
        public int CV_Id { get; set; }
        public string Type { get; set; }
        public string Voucher_Series { get; set; }
        public int Voucher_Number { get; set; }
        public int BillNo { get; set; }
        public DateTime PDCDate { get; set; }        
        public DateTime CV_Date { get; set; }                        
        public string Party { get; set; }
        public string MatCenter { get; set; }
        public string LongNarration { get; set; }

        public bool IsDeleted { get; set; }

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public List<AccountModel> AccountModel { get; set; }
        //public List<Item_VoucherModel> Item_Voucher { get; set; }
        //public List<BillSundry_VoucherModel> BillSundry_Voucher { get; set; }
    }
}
