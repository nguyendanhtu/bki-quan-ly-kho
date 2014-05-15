///************************************************
/// Generated by: HOANGNH
/// Date: 16/04/2014 08:48:15
/// Goal: Create User Service Class for DM_NHAN_VIEN
///************************************************
/// <summary>
/// Create User Service Class for DM_NHAN_VIEN
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US
{

    public class US_DM_NHAN_VIEN : US_Object
    {
        private const string c_TableName = "DM_NHAN_VIEN";
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

        public string strSO_DIEN_THOAI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_DIEN_THOAI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_DIEN_THOAI"] = value;
            }
        }

        public bool IsSO_DIEN_THOAINull()
        {
            return pm_objDR.IsNull("SO_DIEN_THOAI");
        }

        public void SetSO_DIEN_THOAINull()
        {
            pm_objDR["SO_DIEN_THOAI"] = System.Convert.DBNull;
        }

        public string strEMAIL
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "EMAIL", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["EMAIL"] = value;
            }
        }

        public bool IsEMAILNull()
        {
            return pm_objDR.IsNull("EMAIL");
        }

        public void SetEMAILNull()
        {
            pm_objDR["EMAIL"] = System.Convert.DBNull;
        }

        public string strDIA_CHI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIA_CHI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIA_CHI"] = value;
            }
        }

        public bool IsDIA_CHINull()
        {
            return pm_objDR.IsNull("DIA_CHI");
        }

        public void SetDIA_CHINull()
        {
            pm_objDR["DIA_CHI"] = System.Convert.DBNull;
        }

        public string strCMND
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CMND", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CMND"] = value;
            }
        }

        public bool IsCMNDNull()
        {
            return pm_objDR.IsNull("CMND");
        }

        public void SetCMNDNull()
        {
            pm_objDR["CMND"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_DM_NHAN_VIEN()
        {
            pm_objDS = new DS_DM_NHAN_VIEN();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_DM_NHAN_VIEN(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_DM_NHAN_VIEN(decimal i_dbID)
        {
            pm_objDS = new DS_DM_NHAN_VIEN();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
        #region Methods
       
        //public decimal get_id_nhan_vien(decimal ma_nhan_vien,ref decimal id_nhan_vien)
        //{
        //    decimal v_dc_so_du = 0;
        //    CStoredProc v_str_proc = new CStoredProc("pr_DM_NHAN_VIEN_FillDatasetByMA_NHAN_VIEN");
        //    v_str_proc.addDecimalInputParam("@ma_nhan_vien", ma_nhan_vien);
        //    v_str_proc.ExecuteCommand(this);

        //    v_dc_so_du = ((Oracle.DataAccess.Types.OracleDecimal)v_obj_so_du.Value).Value;
        //    return v_dc_so_du;
        //}
        public bool exit_hang_hoa_yn(string i_str_ma_hang_hoa)
        {
            DS_DM_HANG_HOA m_ds_hang_hoa = new DS_DM_HANG_HOA();
            IMakeSelectCmd v_obj_make_cmd = new CMakeAndSelectCmd(m_ds_hang_hoa, m_ds_hang_hoa.DM_HANG_HOA.TableName);
            v_obj_make_cmd.AddCondition("MA_HANG", i_str_ma_hang_hoa, eKieuDuLieu.KieuString, eKieuSoSanh.Bang);
            this.FillDatasetByCommand(m_ds_hang_hoa, v_obj_make_cmd.getSelectCmd());
            //US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            //DataRow v_dr = (DataRow)m_ds_hang_hoa.DM_HANG_HOA.Rows[0];
            //v_us.DataRow2Me(v_dr);
            //id_hang_hoa = v_us.dcID;
            if (m_ds_hang_hoa.DM_HANG_HOA.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void FillDatasetSearchByMaNhanVien(DS_DM_NHAN_VIEN op_ds, string ip_str_ma_nhan_vien)
        {
            CStoredProc v_sp = new CStoredProc("pr_DM_NHAN_VIEN_Search_By_Ma_Nhan_Vien");
            v_sp.addNVarcharInputParam("@MA_NHAN_VIEN", ip_str_ma_nhan_vien);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
        public void FillDatasetSearchByID(DS_DM_NHAN_VIEN op_ds, decimal ip_id_nhan_vien)
        {
            CStoredProc v_sp = new CStoredProc("pr_DM_NHAN_VIEN_Search_By_ID");
            v_sp.addNVarcharInputParam("@ID", ip_id_nhan_vien);
            v_sp.fillDataSetByCommand(this, op_ds);

            //DataRow v_dr = (DataRow)op_ds.DM_NHAN_VIEN.Rows[0];
            //this.DataRow2Me(v_dr);
            //v_ho_ten = this.strHO_DEM + this.strTEN;
        }
        public void FillDataSetByKeyword(DS_DM_NHAN_VIEN op_ds, string ip_str_keyword)
        {
            CStoredProc v_sp = new CStoredProc("pr_DM_NHAN_VIEN_Search");
            v_sp.addNVarcharInputParam("@keyword", ip_str_keyword);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
        #endregion
    }
}
