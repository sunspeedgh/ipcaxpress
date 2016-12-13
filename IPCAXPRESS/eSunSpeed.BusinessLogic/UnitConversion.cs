﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eSunSpeedDomain;
using eSunSpeed.DataAccess;

namespace eSunSpeed.BusinessLogic
{
    public class UnitConversion
    {
        private DBHelper _dbHelper = new DBHelper();
        public bool SaveUC(eSunSpeedDomain.UnitConversionModel objUC)
        {
            string Query = string.Empty;
            bool isSaved = true;

            try
            {
                DBParameterCollection paramCollection = new DBParameterCollection();

                paramCollection.Add(new DBParameter("@MainUnit", objUC.MainUnit));
                paramCollection.Add(new DBParameter("@SubUnit", objUC.SubUnit));
                paramCollection.Add(new DBParameter("@ConFactor", objUC.ConFactor));
                //paramCollection.Add(new DBParameter("@CreatedBy", "Admin"));

                Query = "INSERT INTO UnitConversion([MainUnit],[SubUnit],[ConFactor]) " +
                    "VALUES(@MainUnit,@SubUnit,@ConFactor)";

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
        public bool UpdateUC(eSunSpeedDomain.UnitConversionModel objUC)
        {
            string Query = string.Empty;
            bool isUpdated = true;

            DBParameterCollection paramCollection = new DBParameterCollection();

            try
            {                
                paramCollection.Add(new DBParameter("@MainUnit", objUC.MainUnit));
                paramCollection.Add(new DBParameter("@SubUnit", objUC.SubUnit));
                paramCollection.Add(new DBParameter("@ConFactor", objUC.ConFactor));
                paramCollection.Add(new DBParameter("@UC_ID", objUC.ID));

                Query = "UPDATE UnitConversion SET [MainUnit]=@MainUnit,[SubUnit]=@SubUnit,[ConFactor]=@ConFactor "+
                  "WHERE Id=@UC_Id";

                if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                    isUpdated = true;
            }
            catch (Exception ex)
            {
                isUpdated = false;
                throw ex;
            }
            finally
            {
                paramCollection = null;
            }

            return isUpdated;
        }

        #region Delete Unit Conversion
        /// <summary>
        /// Modified Account Group
        /// </summary>
        /// <param name="objAccountGroup"></param>
        /// <returns>True/False</returns>
        public bool DeletUnitConversion(List<int> unitconversionIds)
        {
            string Query = string.Empty;
            bool isUpdated = true;

            try
            {
                DBParameterCollection paramCollection;

                foreach (int unitconid in unitconversionIds)
                {
                    paramCollection = new DBParameterCollection();

                    paramCollection.Add(new DBParameter("@ucid", unitconid));
                    Query = "Delete from UnitConversion WHERE [Id]=@ucid";

                    if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                        isUpdated = true;
                }

            }
            catch (Exception ex)
            {
                isUpdated = false;
                throw ex;
            }

            return isUpdated;
        }
        #endregion

        #region Get List of Unit Conversion
        public List<UnitConversionModel> GetListofUnitConversions()
        {
            List<UnitConversionModel> lsObj = new List<UnitConversionModel>();
            UnitConversionModel obj;

            try
            {
                string Query = "SELECT * from unitconversion";
                System.Data.IDataReader dr = _dbHelper.ExecuteDataReader(Query, _dbHelper.GetConnObject());

                while (dr.Read())
                {
                    //Initialize/reset account master object
                    obj = new UnitConversionModel();

                    obj.ID= Convert.ToInt32(dr["ID"]);
                    obj.ConFactor = Convert.ToDecimal(dr["ConFactor"]);
                    obj.SubUnit = dr["SubUnit"].ToString();
                    obj.MainUnit = dr["MainUnit"].ToString();

                    lsObj.Add(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lsObj;
        }
        #endregion
    }
}
