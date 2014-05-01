///************************************************
/// Generated by: tuyendv
/// Date: 29/04/2014 09:12:24
/// Goal: Create User Service Class for GD_CHI_TIET_CHUNG_TU
///************************************************
/// <summary>
/// Create User Service Class for GD_CHI_TIET_CHUNG_TU
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US
{

    public class US_GD_CHI_TIET_CHUNG_TU : US_Object
    {
        private const string c_TableName = "GD_CHI_TIET_CHUNG_TU";
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

        public decimal dcID_HANG_HOA
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_HANG_HOA", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_HANG_HOA"] = value;
            }
        }

        public bool IsID_HANG_HOANull()
        {
            return pm_objDR.IsNull("ID_HANG_HOA");
        }

        public void SetID_HANG_HOANull()
        {
            pm_objDR["ID_HANG_HOA"] = System.Convert.DBNull;
        }

        public decimal dcSO_LUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_LUONG"] = value;
            }
        }

        public bool IsSO_LUONGNull()
        {
            return pm_objDR.IsNull("SO_LUONG");
        }

        public void SetSO_LUONGNull()
        {
            pm_objDR["SO_LUONG"] = System.Convert.DBNull;
        }

        public decimal dcGIA_GIAO_DICH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIA_GIAO_DICH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIA_GIAO_DICH"] = value;
            }
        }

        public bool IsGIA_GIAO_DICHNull()
        {
            return pm_objDR.IsNull("GIA_GIAO_DICH");
        }

        public void SetGIA_GIAO_DICHNull()
        {
            pm_objDR["GIA_GIAO_DICH"] = System.Convert.DBNull;
        }

        public decimal dcID_DON_VI_TINH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_TINH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI_TINH"] = value;
            }
        }

        public bool IsID_DON_VI_TINHNull()
        {
            return pm_objDR.IsNull("ID_DON_VI_TINH");
        }

        public void SetID_DON_VI_TINHNull()
        {
            pm_objDR["ID_DON_VI_TINH"] = System.Convert.DBNull;
        }

        public string strSO_SERI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_SERI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_SERI"] = value;
            }
        }

        public bool IsSO_SERINull()
        {
            return pm_objDR.IsNull("SO_SERI");
        }

        public void SetSO_SERINull()
        {
            pm_objDR["SO_SERI"] = System.Convert.DBNull;
        }

        public decimal dcTHOI_GIAN_BH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "THOI_GIAN_BH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["THOI_GIAN_BH"] = value;
            }
        }

        public bool IsTHOI_GIAN_BHNull()
        {
            return pm_objDR.IsNull("THOI_GIAN_BH");
        }

        public void SetTHOI_GIAN_BHNull()
        {
            pm_objDR["THOI_GIAN_BH"] = System.Convert.DBNull;
        }

        public decimal dcID_DVT_THOI_GIAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DVT_THOI_GIAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DVT_THOI_GIAN"] = value;
            }
        }

        public bool IsID_DVT_THOI_GIANNull()
        {
            return pm_objDR.IsNull("ID_DVT_THOI_GIAN");
        }

        public void SetID_DVT_THOI_GIANNull()
        {
            pm_objDR["ID_DVT_THOI_GIAN"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_GD_CHI_TIET_CHUNG_TU()
        {
            pm_objDS = new DS_GD_CHI_TIET_CHUNG_TU();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_CHI_TIET_CHUNG_TU(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_CHI_TIET_CHUNG_TU(decimal i_dbID)
        {
            pm_objDS = new DS_GD_CHI_TIET_CHUNG_TU();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void FillDatasetByIDChungTu(DS_GD_CHI_TIET_CHUNG_TU op_ds, decimal ip_dc_id_chung_tu)
        {
            CStoredProc v_sp = new CStoredProc("pr_GD_CHI_TIET_CHUNG_TU_Search_by_id_chung_tu");
            v_sp.addDecimalInputParam("@id_chung_tu", ip_dc_id_chung_tu);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
    }
}
