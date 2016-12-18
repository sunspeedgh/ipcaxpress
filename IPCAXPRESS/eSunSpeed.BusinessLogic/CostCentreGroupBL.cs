﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eSunSpeedDomain;
using eSunSpeed.DataAccess;

namespace eSunSpeed.BusinessLogic
{
   public class CostCentreGroupBL
    {
        private DBHelper _dbHelper = new DBHelper();

        public object ParamCollection { get; private set; }

        //Save

        public bool SaveCCG(eSunSpeedDomain.CostCentreGroupModel ObjCCG)
        {
            string Query = string.Empty;
            bool isSaved = true;
            try
            {
                DBParameterCollection paramCollection = new DBParameterCollection();

                paramCollection.Add(new DBParameter("@GroupName", ObjCCG.GroupName));
                paramCollection.Add(new DBParameter("@Alias", ObjCCG.Alias));
                paramCollection.Add(new DBParameter("@PrimaryGroup", ObjCCG.PrimaryGroup, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@underGroup", ObjCCG.underGroup));
                paramCollection.Add(new DBParameter("@CreatedBy", ObjCCG.CreatedBy));

                Query = "INSERT INTO CostCentreGroupMaster(`GroupName`,`Alias`,`PrimaryGroup`,`underGroup`,`CreatedBy`)" +

                    "VALUES(@GroupName,@Alias,@PrimaryGroup,@underGroup,@CreatedBy)";


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

        //UPDATE
        public bool UpdateCCGM(eSunSpeedDomain.CostCentreGroupModel objCCG)
        {
            string Query = string.Empty;
            bool isUpdated = true;
            try
            {
                DBParameterCollection paramCollection = new DBParameterCollection();                
                
                paramCollection.Add(new DBParameter("@GroupName", objCCG.GroupName));
                paramCollection.Add(new DBParameter("@Alias",objCCG.Alias));
                paramCollection.Add(new DBParameter("@PrimaryGroup",objCCG.PrimaryGroup, System.Data.DbType.Boolean));
                paramCollection.Add(new DBParameter("@underGroup", objCCG.underGroup));
                paramCollection.Add(new DBParameter("@ModifiedBy", objCCG.ModifiedBy));
                paramCollection.Add(new DBParameter("@CCG_ID", objCCG.CCG_ID));

                Query = "UPDATE CostCentreGroupMaster SET [GroupName]=@GroupName,[Alias]=@Alias,[PrimaryGroup]=@PrimaryGroup,[underGroup]=@underGroup,[ModifiedBy]=@ModifiedBy " +
                   "WHERE CCG_ID=@CCG_ID";

                if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                    isUpdated = true;
            }
            catch (Exception ex)
            {
                isUpdated = false;
                throw ex;
            }

            return isUpdated;
        }

        //Delete
        
        public bool DeletCostCentreGroup(List<int> lstIds)
        {
            string Query = string.Empty;
            bool isDeleted = true;

            try
            {
                DBParameterCollection paramCollection;

                foreach (int id in lstIds)
                {
                    paramCollection = new DBParameterCollection();

                    paramCollection.Add(new DBParameter("@CCG_ID", id));
                    Query = "Delete from CostCentreGroupMaster WHERE [CCG_ID]=@CCG_ID";

                    if (_dbHelper.ExecuteNonQuery(Query, paramCollection) > 0)
                        isDeleted = true;
                }

            }
            catch (Exception ex)
            {
                isDeleted = false;
                throw ex;
            }

            return isDeleted;
        }

        //List
        public List<CostCentreGroupModel> GetAllCostCentreGroups()
        {
            List<CostCentreGroupModel> lstCCG = new List<CostCentreGroupModel>();
            CostCentreGroupModel objCCG;           

            string Query = "SELECT * FROM CostCentreGroupMaster";
            System.Data.IDataReader dr = _dbHelper.ExecuteDataReader(Query, _dbHelper.GetConnObject());

            while (dr.Read())
            {

                objCCG = new CostCentreGroupModel();
                objCCG.CCG_ID = Convert.ToInt32(dr["CCG_ID"]);
                objCCG.GroupName = dr["GroupName"].ToString();
                objCCG.Alias = dr["Alias"].ToString();
                objCCG.PrimaryGroup = Convert.ToBoolean(dr["PrimaryGroup"]);
                objCCG.underGroup = dr["underGroup"].ToString();
                objCCG.ModifiedBy = dr["ModifiedBy"].ToString();
                
               lstCCG.Add(objCCG);
                
            }

            return lstCCG;
        }

    }
}
