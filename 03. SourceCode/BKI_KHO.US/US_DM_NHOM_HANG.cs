///************************************************
/// Generated by: DucVT
/// Date: 16/04/2014 07:47:22
/// Goal: Create User Service Class for DM_NHOM_HANG
///************************************************
/// <summary>
/// Create User Service Class for DM_NHOM_HANG
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US
{

    public class US_DM_NHOM_HANG : US_Object
    {
        private const string c_TableName = "DM_NHOM_HANG";

        #region "Public Properties"
        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public decimal dcID_NHOM_CHA
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_CHA", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NHOM_CHA"] = value;
            }
        }

        public bool IsID_NHOM_CHANull()
        {
            return pm_objDR.IsNull("ID_NHOM_CHA");
        }

        public void SetID_NHOM_CHANull()
        {
            pm_objDR["ID_NHOM_CHA"] = System.Convert.DBNull;
        }

        public string strTEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN"] = value;
            }
        }

        public bool IsTENNull()
        {
            return pm_objDR.IsNull("TEN");
        }

        public void SetTENNull()
        {
            pm_objDR["TEN"] = System.Convert.DBNull;
        }

        public string strMO_TA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MO_TA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MO_TA"] = value;
            }
        }

        public bool IsMO_TANull()
        {
            return pm_objDR.IsNull("MO_TA");
        }

        public void SetMO_TANull()
        {
            pm_objDR["MO_TA"] = System.Convert.DBNull;
        }

        public decimal dcSTT
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "STT", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["STT"] = value;
            }
        }

        public bool IsSTTNull()
        {
            return pm_objDR.IsNull("STT");
        }

        public void SetSTTNull()
        {
            pm_objDR["STT"] = System.Convert.DBNull;
        }

        public decimal dcLEVEL_MODE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "LEVEL_MODE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["LEVEL_MODE"] = value;
            }
        }

        public bool IsLEVEL_MODENull()
        {
            return pm_objDR.IsNull("LEVEL_MODE");
        }

        public void SetLEVEL_MODENull()
        {
            pm_objDR["LEVEL_MODE"] = System.Convert.DBNull;
        }

        #endregion

        #region "Init Functions"
        public US_DM_NHOM_HANG()
        {
            pm_objDS = new DS_DM_NHOM_HANG();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_DM_NHOM_HANG(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_DM_NHOM_HANG(decimal i_dbID)
        {
            pm_objDS = new DS_DM_NHOM_HANG();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void fillDatasetById(DS_DM_NHOM_HANG op_ds, decimal ip_dc_id)
        {
            CStoredProc v_stored_proc = new CStoredProc("pr_DM_NHOM_HANG_FillDatasetById");
            v_stored_proc.addDecimalInputParam("@ID", ip_dc_id);
            v_stored_proc.fillDataSetByCommand(this, op_ds);
        }

        public void fillDataSet_By_TEN_NHOM_HANG(DS_DM_NHOM_HANG op_ds, String ip_ten_nhom_hang)
        {
            CStoredProc v_stored_proc = new CStoredProc("pr_DM_NHOM_HANG_Select_By_TEN_NHOM_HANG");
            v_stored_proc.addNVarcharInputParam("@ip_ten_nhom_hang", ip_ten_nhom_hang);
            v_stored_proc.fillDataSetByCommand(this, op_ds);
        }
    }
}
