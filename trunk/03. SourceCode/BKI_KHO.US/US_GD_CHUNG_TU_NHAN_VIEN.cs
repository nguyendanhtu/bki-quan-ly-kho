///************************************************
/// Generated by: tuyendv
/// Date: 29/04/2014 02:33:09
/// Goal: Create User Service Class for GD_CHUNG_TU_NHAN_VIEN
///************************************************
/// <summary>
/// Create User Service Class for GD_CHUNG_TU_NHAN_VIEN
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US
{

    public class US_GD_CHUNG_TU_NHAN_VIEN : US_Object
    {
        private const string c_TableName = "GD_CHUNG_TU_NHAN_VIEN";
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

        public decimal dcID_CHUNG_TU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_CHUNG_TU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_CHUNG_TU"] = value;
            }
        }

        public bool IsID_CHUNG_TUNull()
        {
            return pm_objDR.IsNull("ID_CHUNG_TU");
        }

        public void SetID_CHUNG_TUNull()
        {
            pm_objDR["ID_CHUNG_TU"] = System.Convert.DBNull;
        }

        public decimal dcID_NHAN_VIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NHAN_VIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NHAN_VIEN"] = value;
            }
        }

        public bool IsID_NHAN_VIENNull()
        {
            return pm_objDR.IsNull("ID_NHAN_VIEN");
        }

        public void SetID_NHAN_VIENNull()
        {
            pm_objDR["ID_NHAN_VIEN"] = System.Convert.DBNull;
        }

        public decimal dcSO_TIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_TIEN"] = value;
            }
        }

        public bool IsSO_TIENNull()
        {
            return pm_objDR.IsNull("SO_TIEN");
        }

        public void SetSO_TIENNull()
        {
            pm_objDR["SO_TIEN"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_GD_CHUNG_TU_NHAN_VIEN()
        {
            pm_objDS = new DS_GD_CHUNG_TU_NHAN_VIEN();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_CHUNG_TU_NHAN_VIEN(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_CHUNG_TU_NHAN_VIEN(decimal i_dbID)
        {
            pm_objDS = new DS_GD_CHUNG_TU_NHAN_VIEN();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void FillDatasetByIDChungTu(DS_GD_CHUNG_TU_NHAN_VIEN op_ds, decimal ip_dc_id_chung_tu)
        {
            CStoredProc v_sp = new CStoredProc("pr_GD_CHUNG_TU_NHAN_VIEN_Search_by_id_chung_tu");
            v_sp.addDecimalInputParam("@id_chung_tu", ip_dc_id_chung_tu);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
    }
}
