///************************************************
/// Generated by: HOANGNH
/// Date: 28/04/2014 03:12:00
/// Goal: Create User Service Class for V_BAO_HANH_SUA_CHUA
///************************************************
/// <summary>
/// Create User Service Class for V_BAO_HANH_SUA_CHUA
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US
{

    public class US_V_BAO_HANH_SUA_CHUA : US_Object
    {
        private const string c_TableName = "V_BAO_HANH_SUA_CHUA";
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

        public decimal dcID_LOAI_CT
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_CT", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_CT"] = value;
            }
        }

        public bool IsID_LOAI_CTNull()
        {
            return pm_objDR.IsNull("ID_LOAI_CT");
        }

        public void SetID_LOAI_CTNull()
        {
            pm_objDR["ID_LOAI_CT"] = System.Convert.DBNull;
        }

        public string strMA_CT
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_CT", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_CT"] = value;
            }
        }

        public bool IsMA_CTNull()
        {
            return pm_objDR.IsNull("MA_CT");
        }

        public void SetMA_CTNull()
        {
            pm_objDR["MA_CT"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CT
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CT", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CT"] = value;
            }
        }

        public bool IsNGAY_CTNull()
        {
            return pm_objDR.IsNull("NGAY_CT");
        }

        public void SetNGAY_CTNull()
        {
            pm_objDR["NGAY_CT"] = System.Convert.DBNull;
        }

        public string strDIEN_GIAI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIEN_GIAI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIEN_GIAI"] = value;
            }
        }

        public bool IsDIEN_GIAINull()
        {
            return pm_objDR.IsNull("DIEN_GIAI");
        }

        public void SetDIEN_GIAINull()
        {
            pm_objDR["DIEN_GIAI"] = System.Convert.DBNull;
        }

        public decimal dcTONG_TIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_TIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_TIEN"] = value;
            }
        }

        public bool IsTONG_TIENNull()
        {
            return pm_objDR.IsNull("TONG_TIEN");
        }

        public void SetTONG_TIENNull()
        {
            pm_objDR["TONG_TIEN"] = System.Convert.DBNull;
        }

        public decimal dcID_TO_CHUC_NGUON
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TO_CHUC_NGUON", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TO_CHUC_NGUON"] = value;
            }
        }

        public bool IsID_TO_CHUC_NGUONNull()
        {
            return pm_objDR.IsNull("ID_TO_CHUC_NGUON");
        }

        public void SetID_TO_CHUC_NGUONNull()
        {
            pm_objDR["ID_TO_CHUC_NGUON"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_GIAO_DICH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_GIAO_DICH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_GIAO_DICH"] = value;
            }
        }

        public bool IsID_NGUOI_GIAO_DICHNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_GIAO_DICH");
        }

        public void SetID_NGUOI_GIAO_DICHNull()
        {
            pm_objDR["ID_NGUOI_GIAO_DICH"] = System.Convert.DBNull;
        }

        public decimal dcID_TO_CHUC_DICH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TO_CHUC_DICH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TO_CHUC_DICH"] = value;
            }
        }

        public bool IsID_TO_CHUC_DICHNull()
        {
            return pm_objDR.IsNull("ID_TO_CHUC_DICH");
        }

        public void SetID_TO_CHUC_DICHNull()
        {
            pm_objDR["ID_TO_CHUC_DICH"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_NHAP
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_NHAP", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_NHAP"] = value;
            }
        }

        public bool IsID_NGUOI_NHAPNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_NHAP");
        }

        public void SetID_NGUOI_NHAPNull()
        {
            pm_objDR["ID_NGUOI_NHAP"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_NHAP
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_NHAP", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_NHAP"] = value;
            }
        }

        public bool IsNGAY_NHAPNull()
        {
            return pm_objDR.IsNull("NGAY_NHAP");
        }

        public void SetNGAY_NHAPNull()
        {
            pm_objDR["NGAY_NHAP"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_NHAP_CUOI
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_NHAP_CUOI", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_NHAP_CUOI"] = value;
            }
        }

        public bool IsNGAY_NHAP_CUOINull()
        {
            return pm_objDR.IsNull("NGAY_NHAP_CUOI");
        }

        public void SetNGAY_NHAP_CUOINull()
        {
            pm_objDR["NGAY_NHAP_CUOI"] = System.Convert.DBNull;
        }

        public string strGHI_CHU_1
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU_1", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU_1"] = value;
            }
        }

        public bool IsGHI_CHU_1Null()
        {
            return pm_objDR.IsNull("GHI_CHU_1");
        }

        public void SetGHI_CHU_1Null()
        {
            pm_objDR["GHI_CHU_1"] = System.Convert.DBNull;
        }

        public string strGHI_CHU_2
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU_2", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU_2"] = value;
            }
        }

        public bool IsGHI_CHU_2Null()
        {
            return pm_objDR.IsNull("GHI_CHU_2");
        }

        public void SetGHI_CHU_2Null()
        {
            pm_objDR["GHI_CHU_2"] = System.Convert.DBNull;
        }

        public string strGHI_CHU_3
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU_3", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU_3"] = value;
            }
        }

        public bool IsGHI_CHU_3Null()
        {
            return pm_objDR.IsNull("GHI_CHU_3");
        }

        public void SetGHI_CHU_3Null()
        {
            pm_objDR["GHI_CHU_3"] = System.Convert.DBNull;
        }

        public string strMA_NHAN_VIEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_NHAN_VIEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_NHAN_VIEN"] = value;
            }
        }

        public bool IsMA_NHAN_VIENNull()
        {
            return pm_objDR.IsNull("MA_NHAN_VIEN");
        }

        public void SetMA_NHAN_VIENNull()
        {
            pm_objDR["MA_NHAN_VIEN"] = System.Convert.DBNull;
        }

        public string strHO_DEM
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_DEM", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_DEM"] = value;
            }
        }

        public bool IsHO_DEMNull()
        {
            return pm_objDR.IsNull("HO_DEM");
        }

        public void SetHO_DEMNull()
        {
            pm_objDR["HO_DEM"] = System.Convert.DBNull;
        }

        public string strTEN_NHAN_VIEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_NHAN_VIEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_NHAN_VIEN"] = value;
            }
        }

        public bool IsTEN_NHAN_VIENNull()
        {
            return pm_objDR.IsNull("TEN_NHAN_VIEN");
        }

        public void SetTEN_NHAN_VIENNull()
        {
            pm_objDR["TEN_NHAN_VIEN"] = System.Convert.DBNull;
        }

        public string strHO_TEN_NHAN_VIEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_TEN_NHAN_VIEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_TEN_NHAN_VIEN"] = value;
            }
        }

        public bool IsHO_TEN_NHAN_VIENNull()
        {
            return pm_objDR.IsNull("HO_TEN_NHAN_VIEN");
        }

        public void SetHO_TEN_NHAN_VIENNull()
        {
            pm_objDR["HO_TEN_NHAN_VIEN"] = System.Convert.DBNull;
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
        public US_V_BAO_HANH_SUA_CHUA()
        {
            pm_objDS = new DS_V_BAO_HANH_SUA_CHUA();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_BAO_HANH_SUA_CHUA(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_BAO_HANH_SUA_CHUA(decimal i_dbID)
        {
            pm_objDS = new DS_V_BAO_HANH_SUA_CHUA();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

#region Addtional

        public void InitByID(decimal i_dbID)
        {
            
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        public void FillDatasetByLoaiChungTu(DS_V_BAO_HANH_SUA_CHUA op_ds
            , string ip_str_keyword
            , decimal ip_dc_loai_chung_tu)
        {
            CStoredProc v_sp = new CStoredProc("pr_V_BAO_HANH_SUA_CHUA_by_loai_chung_tu");
            v_sp.addNVarcharInputParam("@keyword", ip_str_keyword);
            v_sp.addDecimalInputParam("@loai_chung_tu", ip_dc_loai_chung_tu);
            v_sp.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetByIDChungTu(DS_V_BAO_HANH_SUA_CHUA op_ds, decimal ip_dc_id_chung_tu)
        {
            CStoredProc v_sp = new CStoredProc("pr_V_BAO_HANH_SUA_CHUA_by_id_chung_tu");
            v_sp.addDecimalInputParam("@id_chung_tu", ip_dc_id_chung_tu);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
#endregion
    }

}
