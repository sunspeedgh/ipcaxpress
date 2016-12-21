﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eSunSpeedDomain;
using eSunSpeed.DataAccess;

namespace eSunSpeed.BusinessLogic
{
    public class SaleTypeBL
    {
        private DBHelper _dbHelper = new DBHelper();
        public bool SaveStype(SaleTypeModel objStype)
        {
            string Query = string.Empty;
            bool isSaved = true;

            try
            {
                DBParameterCollection paramCollection = new DBParameterCollection();

                paramCollection.Add(new DBParameter("@SalesType", objStype.SalesType));
                paramCollection.Add(new DBParameter("@typeSpecifyHereSingleAccount", objStype.SpecifyHereSingleAccount));
                //paramCollection.Add(new DBParameter("@LedgerAccountBox", objStype.LedgerAccountBox));
                paramCollection.Add(new DBParameter("@DifferentTaxRate", objStype.SpecifyhereforDifferentTaxRate,System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@SpecifyINVoucher", objStype.SpecifyINVoucher,System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@typeTaxable", objStype.Taxable, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@typeMultiTax", objStype.MultiTax, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@typeAgainstSTFrom", objStype.AgainstSTFrom, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@typeTaxpaid", objStype.Taxpaid, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@typeExempt", objStype.Exempt, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@typeTaxFree", objStype.TaxFree, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@typeLUMSumDealer", objStype.LUMSumDealer, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@typeUnRegDealer", objStype.UnRegDealer, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TaxInvoice", objStype.TaxInvoice, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@VatReturnCategory", objStype.VatReturnCategory));
                paramCollection.Add(new DBParameter("@VatSaleTaxReport", objStype.VatSaleTaxReport, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@CalculateTaxonItemMRP", objStype.CalculateTaxonItemMRP, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TaxInclusiveItemPrice", objStype.TaxInclusiveItemPrice, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@CalculateTaxonpercentofAmount", objStype.CalculateTaxonpercentofAmount));
                paramCollection.Add(new DBParameter("@AdjustTaxinSaleAccount", objStype.AdjustTaxinSaleAccount, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TaxAccount", objStype.TaxAccount));
                paramCollection.Add(new DBParameter("@TypeLocal", objStype.TypeLocal, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TypeCentral", objStype.TypeCentral, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TypeStockTransfer", objStype.TypeStockTransfer, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TypeOther", objStype.TypeOther, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@ExportNormal", objStype.ExportNormal, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@SaleinTransit", objStype.SaleinTransit, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@ExportHighsea", objStype.ExportHighsea, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@IssueSTFrom", objStype.IssueSTFrom, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@FromIssuable", objStype.FromIssuable));
                paramCollection.Add(new DBParameter("@ReceiveSTForm", objStype.ReceiveSTForm, System.Data.DbType.Boolean));
                //paramCollection.Add(new DBParameter("@CreatedBy", objStype.CreatedBy));  ,pml[

                Query = "INSERT INTO saletype (`SalesType`,`typeSpecifyHereSingleAccount`,`typeDifferentTaxRate`," +
              "`typeSpecifyINVoucher`,`typeTaxable`,`tyypeMultiTax`,`typeAgainstSTFrom`,`typeTaxpaid`,`typeExempt`,`typeTaxFree`,`typeLUMSumDealer`," +
             " `typeUnRegDealer`,`TaxInvoice`,`VatReturnCategory`,`VatSaleTaxReport`,`CalculateTaxonItemMRP`,`TaxInclusiveItemPrice`, " +
              "`CalculateTaxonpercentofAmount`,`AdjustTaxinSaleAccount`,`TaxAccount`,`TypeLocal`,`TypeCentral`,`TypeStockTransfer`,`TypeOther`,`ExportNormal`," +
              "`SaleinTransit`,`ExportHighsea`,`IssueSTFrom`,`FromIssuable`,`ReceiveSTForm`)" +
              "VALUES(@SalesType,@typeSpecifyHereSingleAccount,@DifferentTaxRate,@SpecifyINVoucher,@typeTaxable, " +
              "@tyypeMultiTax,@typeAgainstSTFrom,@typeTaxpaid,@typeExempt,@typeTaxFree,@typeLUMSumDealer,@typeUnRegDealer,@TaxInvoice,@VatReturnCategory, " +
              "@VatSaleTaxReport,@CalculateTaxonItemMRP,@TaxInclusiveItemPrice,@CalculateTaxonpercentofAmount,@AdjustTaxinSaleAccount,@TaxAccount,@TypeLocal, " +
              "@TypeCentral,@TypeStockTransfer,@TypeOther,@ExportNormal,@SaleinTransit,@ExportHighsea,@IssueSTFrom,@FromIssuable,@ReceiveSTForm)";

                if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                    isSaved = true;
            }
            catch (Exception ex)
            {
                isSaved = false;
                throw ex;
            }

            return isSaved;
        }

        //update
        public bool UpdateStype(eSunSpeedDomain.SaleTypeModel objStype)
        {
            string Query = string.Empty;
            bool isUpdate = true;

            try
            {
                DBParameterCollection paramCollection = new DBParameterCollection();

                paramCollection.Add(new DBParameter("@SalesType", objStype.SalesType));
                paramCollection.Add(new DBParameter("@SpecifyHereSingleAccount", objStype.SpecifyHereSingleAccount));
                paramCollection.Add(new DBParameter("@LedgerAccountBox", objStype.LedgerAccountBox));
                paramCollection.Add(new DBParameter("@seperateaccountforDifferentTaxRate", objStype.SpecifyhereforDifferentTaxRate, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@SpecifyINVoucher", objStype.SpecifyINVoucher, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@Taxable", objStype.Taxable, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@MultiTax", objStype.MultiTax, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@AgainstSTFrom", objStype.AgainstSTFrom, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@Taxpaid", objStype.Taxpaid, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@Exempt", objStype.Exempt, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TaxFree", objStype.TaxFree, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@LUMSumDealer", objStype.LUMSumDealer, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@UnRegDealer", objStype.UnRegDealer, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TaxInvoice", objStype.TaxInvoice, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@VatReturnCategory", objStype.VatReturnCategory));
                paramCollection.Add(new DBParameter("@VatSaleTaxReport", objStype.VatSaleTaxReport, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@CalculateTaxonItemMRP", objStype.CalculateTaxonItemMRP, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TaxInclusiveItemPrice", objStype.TaxInclusiveItemPrice, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@CalculateTaxonpercentofAmount", objStype.CalculateTaxonpercentofAmount));
                paramCollection.Add(new DBParameter("@AdjustTaxinSaleAccount", objStype.AdjustTaxinSaleAccount, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TaxAccount", objStype.TaxAccount));
                paramCollection.Add(new DBParameter("@TypeLocal", objStype.TypeLocal, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TypeCentral", objStype.TypeCentral, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TypeStockTransfer", objStype.TypeStockTransfer, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@TypeOther", objStype.TypeOther, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@ExportNormal", objStype.ExportNormal, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@SaleinTransit", objStype.SaleinTransit, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@ExportHighsea", objStype.ExportHighsea, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@IssueSTFrom", objStype.IssueSTFrom, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@FromIssuable", objStype.FromIssuable));
                paramCollection.Add(new DBParameter("@ReceiveSTForm", objStype.ReceiveSTForm, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@ST_ID", objStype.Sale_Id));
                Query = "UPDATE SaleType SET [SalesType]=@SalesType,[SpecifyHereSingleAccount]=@SpecifyHereSingleAccount,[LedgerAccountBox]=@LedgerAccountBox,[DifferentTaxRate]=@DifferentTaxRate,[SpecifyINVoucher]=@SpecifyINVoucher,[Taxable]=@Taxable," +
                   "[MultiTax]=@MultiTax,[AgainstSTFrom]=@AgainstSTFrom,[Taxpaid]=@Taxpaid,[Exempt]=@Exempt," +
                   "[TaxFree]=@TaxFree,[LUMSumDealer]=@LUMSumDealer,[UnRegDealer]=@UnRegDealer,[TaxInvoice]=@TaxInvoice,[VatReturnCategory]=@VatReturnCategory,[VatSaleTaxReport]=@VatSaleTaxReport,[CalculateTaxonItemMRP]=@CalculateTaxonItemMRP,[TaxInclusiveItemPrice]=@TaxInclusiveItemPrice,[CalculateTaxonpercentofAmount]=@CalculateTaxonpercentofAmount,[AdjustTaxinSaleAccount]=@AdjustTaxinSaleAccount,[TaxAccount]=@TaxAccount,[Local]=@Local," +
                   "[Central]=@Central,[StockTransfer]=@StockTransfer,[Other]=@Other,[ExportNormal]=@ExportNormal,[SaleinTransit]=@SaleinTransit," +
                   "[ExportHighsea]=@ExportHighsea,[IssueSTFrom]=@IssueSTFrom,[FromIssuable]=@FromIssuable,[ReceiveSTForm]=@ReceiveSTForm " +
                   "WHERE [Id]=@ST_ID";
                if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                    isUpdate = true;
            }
            catch (Exception ex)
            {
                isUpdate = false;
                throw ex;
            }

            return isUpdate;
        }
        //List
        ////public SaleTypeModel GetAllSaleTypeBySaleName(string saletype)
        //{
        //    //List<eSunSpeedDomain.SaleTypeModel> lstSaleType = new List<SaleTypeModel>();
        //    SaleTypeModel objSaleType = new SaleTypeModel();
        //    string Query = "SELECT * FROM SaleType WHERE SalesType='" + saletype + "'";
        //    System.Data.IDataReader dr = _dbHelper.ExecuteDataReader(Query, _dbHelper.GetConnObject());

        //    while (dr.Read())
        //    {
        //        objSaleType = new SaleTypeModel();

                //objSaleType.Sale_Id = Convert.ToInt32(dr["Id"]);
                //objSaleType.SalesType = dr["SalesType"].ToString();
                //objSaleType.typeSpecifyHereSingleAccount = Convert.ToBoolean(dr["typeSpecifyHereSingleAccount"]);
                //objSaleType.LedgerAccountBox = dr["LedgerAccountBox"].ToString();
                //objSaleType.typeDifferentTaxRate = Convert.ToBoolean(dr["typeDifferentTaxRate"]);
                //objSaleType.typeSpecifyINVoucher = Convert.ToBoolean(dr["typeSpecifyINVoucher"]);
                //objSaleType.typeTaxable = Convert.ToBoolean(dr["typeTaxable"]);
                //objSaleType.typeMultiTax = Convert.ToBoolean(dr["tyypeMultiTax"]);
                //objSaleType.typeAgainstSTFrom = Convert.ToBoolean(dr["typeAgainstSTFrom"]);
                //objSaleType.typeTaxpaid = Convert.ToBoolean(dr["typeTaxpaid"]);
                //objSaleType.typeExempt = Convert.ToBoolean(dr["typeExempt"]);
                //objSaleType.typeTaxFree = Convert.ToBoolean(dr["typeTaxFree"]);
                //objSaleType.typeLUMSumDealer = Convert.ToBoolean(dr["typeLUMSumDealer"]);
                //objSaleType.typeUnRegDealer = Convert.ToBoolean(dr["typeUnRegDealer"]);
                //objSaleType.TaxInvoice = Convert.ToBoolean(dr["TaxInvoice"]);
                //objSaleType.VatReturnCategory = dr["VatReturnCategory"].ToString();
                //objSaleType.VatSaleTaxReport = Convert.ToBoolean(dr["VatSaleTaxReport"]);
                //objSaleType.CalculateTaxonItemMRP = Convert.ToBoolean(dr["CalculateTaxonItemMRP"]);
                //objSaleType.TaxInclusiveItemPrice = Convert.ToBoolean(dr["TaxInclusiveItemPrice"]);
                //objSaleType.CalculateTaxonpercentofAmount = Convert.ToDecimal(dr["CalculateTaxonpercentofAmount"]);
                //objSaleType.AdjustTaxinSaleAccount = Convert.ToBoolean(dr["AdjustTaxinSaleAccount"]);
                //objSaleType.TaxAccount = dr["VatSaleTaxReport"].ToString();
                //objSaleType.TypeLocal = Convert.ToBoolean(dr["TypeLocal"]);
                //objSaleType.TypeCentral = Convert.ToBoolean(dr["TypeCentral"]);



                //}
                //return objSaleType;

            }
        }
        
        //public List<eSunSpeedDomain.SaleTypeModel> GetAllSaleType()
        //{
        //    List<eSunSpeedDomain.SaleTypeModel> lstSaleType = new List<SaleTypeModel>();
        //    eSunSpeedDomain.SaleTypeModel objSaleType;

        //    string Query = "SELECT * FROM SaleType";
        //    System.Data.IDataReader dr = _dbHelper.ExecuteDataReader(Query, _dbHelper.GetConnObject());

        //    //Is
        //    //Enable

        //    while (dr.Read())
        //    {
        //        objSaleType = new SaleTypeModel();

        //        objSaleType.Sale_Id = Convert.ToInt32(dr["Id"]);
        //        objSaleType.SalesType = dr["SalesType"].ToString();
        //        objSaleType.typeSpecifyHereSingleAccount= Convert.ToBoolean(dr["typeSpecifyHereSingleAccount"]);
        //        objSaleType.LedgerAccountBox = dr["LedgerAccountBox"].ToString();
        //        objSaleType.typeDifferentTaxRate = Convert.ToBoolean(dr["typeDifferentTaxRate"]);
        //        objSaleType.typeSpecifyINVoucher = Convert.ToBoolean(dr["typeSpecifyINVoucher"]);
        //        objSaleType.typeTaxable = Convert.ToBoolean (dr["typeTaxable"]);
        //        objSaleType.typeMultiTax = Convert.ToBoolean(dr["tyypeMultiTax"]);
        //        objSaleType.typeAgainstSTFrom = Convert.ToBoolean(dr["typeAgainstSTFrom"]);
        //        objSaleType.typeTaxpaid = Convert.ToBoolean(dr["typeTaxpaid"]);
        //        objSaleType.typeExempt = Convert.ToBoolean(dr["typeExempt"]);
        //        objSaleType.typeTaxFree = Convert.ToBoolean(dr["typeTaxFree"]);
        //        objSaleType.typeLUMSumDealer = Convert.ToBoolean(dr["typeLUMSumDealer"]);
        //        objSaleType.typeUnRegDealer = Convert.ToBoolean(dr["typeUnRegDealer"]);
        //        objSaleType.TaxInvoice = Convert.ToBoolean(dr["TaxInvoice"]);
        //        objSaleType.VatReturnCategory = dr["VatReturnCategory"].ToString();
        //        objSaleType.VatSaleTaxReport = Convert.ToBoolean(dr["VatSaleTaxReport"]);
        //        objSaleType.CalculateTaxonItemMRP = Convert.ToBoolean(dr["CalculateTaxonItemMRP"]);
        //        objSaleType.TaxInclusiveItemPrice = Convert.ToBoolean(dr["TaxInclusiveItemPrice"]);
        //        objSaleType.CalculateTaxonpercentofAmount = Convert.ToDecimal(dr["CalculateTaxonpercentofAmount"]);
        //        objSaleType.AdjustTaxinSaleAccount = Convert.ToBoolean(dr["AdjustTaxinSaleAccount"]);
        //        objSaleType.TaxAccount = dr["VatSaleTaxReport"].ToString();
        //        objSaleType.TypeLocal = Convert.ToBoolean(dr["TypeLocal"]);
        //        objSaleType.TypeCentral = Convert.ToBoolean(dr["TypeCentral"]);

        //        lstSaleType.Add(objSaleType);

        //    }
        //    return lstSaleType;
        //}
        ////public bool DeleteSaleType(List<int> salid)
        //{
        //    string Query = string.Empty;
        //    bool isDeleted = true;

        //    try
        //    {
        //        DBParameterCollection paramCollection;

        //        foreach (int id in salid)
        //        {
        //            paramCollection = new DBParameterCollection();

        //            paramCollection.Add(new DBParameter("@Sale_Id", id));
        //            Query = "Delete from SaleType WHERE [Id]=@Sale_Id";

        //            //if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
        //            //    isDeleted = true;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        isDeleted = false;
        //        throw ex;
        //    }

        //    return isDeleted;
        //}

    




