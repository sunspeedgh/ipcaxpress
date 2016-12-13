﻿using eSunSpeed.DataAccess;
using eSunSpeed.Formatting;
using eSunSpeedDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSunSpeed.BusinessLogic
{
    public class PaymentVoucherBL
    {
        private DBHelper _dbHelper = new DBHelper();

        #region SAVE PAYMENT VOUCHER
        public int SavePaymentVoucher(PaymentVoucherModel obpaybl)
        {
            string Query = string.Empty;
            int payid = 0;

            try
            {
                DBParameterCollection paramCollection = new DBParameterCollection();


                paramCollection.Add(new DBParameter("@Series", obpaybl.Voucher_Series));             
                paramCollection.Add(new DBParameter("@Date", obpaybl.Pay_Date));
                paramCollection.Add(new DBParameter("@Voucher_Number", obpaybl.Voucher_Number));
                paramCollection.Add(new DBParameter("@Type", obpaybl.Type));
                paramCollection.Add(new DBParameter("@PDDate", obpaybl.PDCDate));
                //paramCollection.Add(new DBParameter("@Long", obpaybl.LongNarration));

                paramCollection.Add(new DBParameter("@CreatedBy", "Admin"));
                paramCollection.Add(new DBParameter("@CreatedDate", DateTime.Now));


                Query = "INSERT INTO Payment_Voucher([Series],[Pay_Date],[VoucherNo],[Type],[PDC_Date]," +
                "[CreatedBy],[CreatedDate]) VALUES " +
                "(@Series,@Date,@Voucher_Number,@Type,@PDDate, " +
                " @CreatedBy,@CreatedDate)";

                if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                {
                    SavePaymentAccounts(obpaybl.PaymentAccountModel);
                    payid = GetPaymentId();
                    
                }
            }
            catch (Exception ex)
            {
                payid = 0;
                throw ex;
            }

            return payid;
        }

        public bool SavePaymentAccounts(List<AccountModel> lstAcc)
        {
            string Query = string.Empty;
            bool isSaved = true;

            int ParentId = GetPaymentId();

            foreach (AccountModel Acc in lstAcc)
            {
                Acc.ParentId = ParentId;

                try
                {
                    DBParameterCollection paramCollection = new DBParameterCollection();

                    paramCollection.Add(new DBParameter("@Pay_ID", (Acc.ParentId)));
                    paramCollection.Add(new DBParameter("@DC", (Acc.DC)));
                    paramCollection.Add(new DBParameter("@Account", Acc.Account));
                    paramCollection.Add(new DBParameter("@Debit", Acc.Debit));
                    paramCollection.Add(new DBParameter("@Credit", Acc.Credit));
                    paramCollection.Add(new DBParameter("@Narration", Acc.Narration));

                    paramCollection.Add(new DBParameter("@CreatedBy", "Admin"));
                    paramCollection.Add(new DBParameter("@CreatedDate", DateTime.Now));


                    Query = "INSERT INTO Payment_Voucher_Accounts([Payment_Id],[DC],[Account],[Debit]," +
                    "[Credit],[Narration],[CreatedBy],[CreatedDate]) VALUES " +
                    "(@Pay_ID,@DC,@Account,@Debit,@Credit,@Narration,@CreatedBy,@CreatedDate)";

                    if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                        isSaved = true;
                }
                catch (Exception ex)
                {
                    isSaved = false;
                    throw ex;
                }
            }
            return isSaved;
        }


        public int GetPaymentId()
        {
            string Query = "SELECT MAX(Payment_Id) FROM Payment_Voucher";

            int id = Convert.ToInt32(_dbHelper.ExecuteScalar(Query));

            return id;
        }


        #endregion
        //Update Payment Voucher
        public bool UpdatePaymentVoucher(PaymentVoucherModel objPay)
        {
            string Query = string.Empty;
            bool isUpdated = true;

            try
            {
                //UPDATE CREDIT NOTE TABLE - PARENT TABLE

                DBParameterCollection paramCollection = new DBParameterCollection();

                paramCollection.Add(new DBParameter("@Series", objPay.Voucher_Series));
                paramCollection.Add(new DBParameter("@Date", objPay.Pay_Date));
                paramCollection.Add(new DBParameter("@Voucher_Number", objPay.Voucher_Number));
                paramCollection.Add(new DBParameter("@Type", objPay.Type));
                paramCollection.Add(new DBParameter("@PDDate", objPay.PDCDate));
                //paramCollection.Add(new DBParameter("@TotalCreditAmt", "0"));
                //paramCollection.Add(new DBParameter("@TotalDebitAmt", "0"));

                paramCollection.Add(new DBParameter("@ModifiedBy", "Admin"));
                paramCollection.Add(new DBParameter("@ModifiedDate", DateTime.Now));
                paramCollection.Add(new DBParameter("@id", objPay.Pay_Id));

                Query = "UPDATE Payment_Voucher SET [Series]=@Series,[Pay_Date]=@Date,[VoucherNo]=@Voucher_Number," +
                         "[Type]=@Type,[PDC_Date]=@PDDate,[ModifiedBy]=@ModifiedBy," +
                        "[ModifiedDate]=@ModifiedDate " +
                        "WHERE Payment_Id=@id";

                if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                {
                    List<AccountModel> lstAcct = new List<AccountModel>();

                    //UPDATE CREDIT NOTE ACCOUNT -CHILD TABLE UPDATES
                    foreach (AccountModel act in objPay.PaymentAccountModel)
                    {
                        if (act.AC_Id > 0)
                        {

                            paramCollection = new DBParameterCollection();

                            paramCollection.Add(new DBParameter("@DC", (act.DC)));
                            paramCollection.Add(new DBParameter("@Account", act.Account));
                            paramCollection.Add(new DBParameter("@Debit", act.Debit));
                            paramCollection.Add(new DBParameter("@Credit", act.Credit));
                            paramCollection.Add(new DBParameter("@Narration", act.Narration));

                            paramCollection.Add(new DBParameter("@ModifiedBy", "Admin"));
                            paramCollection.Add(new DBParameter("@ModifiedDate", DateTime.Now));
                            paramCollection.Add(new DBParameter("@ACT_ID", act.AC_Id));

                            Query = "UPDATE Payment_Voucher_Accounts SET [DC]=@DC," +
                            "[Account]=@Account,[Debit]=@Debit,[Credit]=@Credit,[Narration]=@Narration,[ModifiedBy]=@ModifiedBy,[ModifiedDate]=@ModifiedDate " +
                            "WHERE [AC_Id]=@ACT_ID";

                            if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                            {
                                isUpdated = true;
                            }
                        }
                        else
                        {
                            paramCollection = new DBParameterCollection();

                            paramCollection.Add(new DBParameter("@DN_ID", (act.ParentId)));
                            paramCollection.Add(new DBParameter("@DC", (act.DC)));
                            paramCollection.Add(new DBParameter("@Account", act.Account));
                            paramCollection.Add(new DBParameter("@Debit", act.Debit));
                            paramCollection.Add(new DBParameter("@Credit", act.Credit));
                            paramCollection.Add(new DBParameter("@Narration", act.Narration));

                            paramCollection.Add(new DBParameter("@CreatedBy", "Admin"));
                            paramCollection.Add(new DBParameter("@CreatedDate", DateTime.Now));


                            Query = "INSERT INTO Payment_Voucher_Accounts([Payment_Id],[DC],[Account],[Debit]," +
                    "[Credit],[Narration],[CreatedBy],[CreatedDate]) VALUES " +
                    "(@Pay_ID,@DC,@Account,@Debit,@Credit,@Narration,@CreatedBy,@CreatedDate)";

                            if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                                isUpdated= true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                isUpdated = false;
                throw ex;
            }

            return isUpdated;
        }

       


        //public List<PaymentVoucherModel> GetAllPaymentVoucher()
        //{
        //    List<PaymentVoucherModel> lstPayment = new List<PaymentVoucherModel>();
        //    PaymentVoucherModel objpay;

        //    string Query = "SELECT * FROM Payment_Voucher";
        //    System.Data.IDataReader dr = _dbHelper.ExecuteDataReader(Query, _dbHelper.GetConnObject());

        //    while (dr.Read())
        //    {
        //        objpay = new PaymentVoucherModel();

        //        objpay.Pay_Id = DataFormat.GetInteger(dr["Pay_Id"]);
        //        objpay.Voucher_Series = dr["Series"].ToString();
        //        objpay.Pay_Date = DataFormat.GetDateTime(dr["Pay_Date"]);
        //        objpay.Voucher_Number = DataFormat.GetInteger(dr["VoucherNo"]);
        //        objpay.Type = dr["Type"].ToString();
        //        objpay.PDCDate = Convert.ToDateTime(dr["PDCDate"].ToString());

        //        //SELECT Payment Voucher Accounts

        //        string itemQuery = "SELECT * FROM Payment_Voucher_Accounts WHERE Payment_Id=" + objpay.Pay_Id;
        //        System.Data.IDataReader drAcc = _dbHelper.ExecuteDataReader(itemQuery, _dbHelper.GetConnObject());

        //        objpay.PaymentAccountModel = new List<AccountModel>();
        //        AccountModel objAcc;

        //        while (drAcc.Read())
        //        {
        //            objAcc = new AccountModel();

        //            objAcc.AC_Id = DataFormat.GetInteger(drAcc["AC_Id"]);
        //            objAcc.ParentId = DataFormat.GetInteger(drAcc["Payment_Id"]);
        //            objAcc.DC = drAcc["DC"].ToString();
        //            objAcc.Account = drAcc["Account"].ToString();
        //            objAcc.Debit = Convert.ToDecimal(drAcc["Debit"]);
        //            objAcc.Credit = Convert.ToDecimal(drAcc["Credit"]);
        //            objAcc.Narration = drAcc["Narration"].ToString();


        //            objpay.PaymentAccountModel.Add(objAcc);

        //        }

        //        lstPayment.Add(objpay);

        //    }
        //    return lstPayment;
        //}

        //Delete Payment Voucher

            //Delete Payment Voucher
        public bool DeletPaymentVoucher(int id)
        {

            bool isDelete = true;
            try
            {
                DeletePaymentAccounts(id);
                string Query = "DELETE * FROM Payment_Voucher WHERE Payment_Id=" + id;
                if (_dbHelper.ExecuteNonQuery(Query) > 0)
                  isDelete = true;
            }
            catch (Exception ex)
            {
                isDelete = false;
                throw ex;
            }
            return isDelete;
        }

        public bool DeletePaymentAccounts(int id)
        {

            bool isDelete = true;
            try
            {
                string Query = "DELETE * FROM Payment_Voucher_Accounts WHERE Payment_Id=" + id;
                if (_dbHelper.ExecuteNonQuery(Query) > 0)
                    isDelete = true;
            }
            catch (Exception ex)
            {
                isDelete = false;
                throw ex;
            }
            return isDelete;
        }

        public List<ListModel> GetAllPaymentVoucher()
        {
            List<ListModel> lstModel = new List<ListModel>();
            ListModel objList;

            StringBuilder sbQuery = new StringBuilder();

            sbQuery.Append("SELECT C.PAYMENT_ID, C.Pay_DATE, C.VOUCHERNO, A.ACCOUNT,A.DEBIT, A.CREDIT,A.NARRATION FROM PAYMENT_VOUCHER C ");
            sbQuery.Append("INNER JOIN PAYMENT_VOUCHER_ACCOUNTS A ");
            sbQuery.Append("ON A.PAYMENT_ID = C.PAYMENT_ID");

            System.Data.IDataReader dr = _dbHelper.ExecuteDataReader(sbQuery.ToString(), _dbHelper.GetConnObject());

            while (dr.Read())
            {
                objList = new ListModel();

                objList.Id = Convert.ToInt32(dr["PAYMENT_ID"]);

                objList.Date = Convert.ToDateTime(dr["Pay_Date"]);
                objList.VoucherNo = Convert.ToInt32(dr["VOUCHERNO"]);
                objList.Account = Convert.ToString(dr["Account"]);
                objList.Debit = Convert.ToInt32(dr["DEBIT"]);
                objList.Credit = Convert.ToInt32(dr["CREDIT"]);
                objList.Narration = Convert.ToString(dr["NARRATION"]);
                lstModel.Add(objList);

            }
            return lstModel;
        }

        public List<PaymentVoucherModel> GetPaymentbyId(int id)
        {
            List<PaymentVoucherModel> lstPayment = new List<PaymentVoucherModel>();
            PaymentVoucherModel objPayment;

            string Query = "SELECT * FROM Payment_Voucher WHERE Payment_Id=" + id;
            System.Data.IDataReader dr = _dbHelper.ExecuteDataReader(Query, _dbHelper.GetConnObject());

            while (dr.Read())
            {
                objPayment = new PaymentVoucherModel();

                objPayment.Pay_Id = DataFormat.GetInteger(dr["Payment_ID"]);
                objPayment.Voucher_Series = dr["Series"].ToString();
                objPayment.Pay_Date = DataFormat.GetDateTime(dr["Pay_Date"]);
                objPayment.Voucher_Number = DataFormat.GetInteger(dr["VoucherNo"]);
                objPayment.Type = dr["Type"].ToString();
                if (dr["PDC_Date"].ToString() != "")
                    objPayment.PDCDate = Convert.ToDateTime(dr["PDC_Date"]);

                //SELECT Payment Voucher Accounts

                string itemQuery = "SELECT * FROM Payment_Voucher_Accounts WHERE Payment_Id=" + objPayment.Pay_Id;
                System.Data.IDataReader drAcc = _dbHelper.ExecuteDataReader(itemQuery, _dbHelper.GetConnObject());

                objPayment.PaymentAccountModel = new List<AccountModel>();
                AccountModel objAcc;

                while (drAcc.Read())
                {
                    objAcc = new AccountModel();

                    objAcc.AC_Id = DataFormat.GetInteger(drAcc["AC_Id"]);
                    objAcc.ParentId = DataFormat.GetInteger(drAcc["Payment_Id"]);
                    objAcc.DC = drAcc["DC"].ToString();
                    objAcc.Account = drAcc["Account"].ToString();
                    objAcc.Debit = Convert.ToDecimal(drAcc["Debit"]);
                    objAcc.Credit = Convert.ToDecimal(drAcc["Credit"]);
                    objAcc.Narration = drAcc["Narration"].ToString();

                    objPayment.PaymentAccountModel.Add(objAcc);

                }

                lstPayment.Add(objPayment);

            }
            return lstPayment;
        }
    }
}
