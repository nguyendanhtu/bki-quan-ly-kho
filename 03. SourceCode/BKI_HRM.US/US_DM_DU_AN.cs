///************************************************
/// Generated by: THAIPH
/// Date: 23/02/2014 05:44:39
/// Goal: Create User Service Class for DM_DU_AN
///************************************************
/// <summary>
/// Create User Service Class for DM_DU_AN
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_DM_DU_AN : US_Object
{
	private const string c_TableName = "DM_DU_AN";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strMA_DU_AN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_DU_AN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_DU_AN"] = value;
		}
	}

	public bool IsMA_DU_ANNull() 
	{
		return pm_objDR.IsNull("MA_DU_AN");
	}

	public void SetMA_DU_ANNull() {
		pm_objDR["MA_DU_AN"] = System.Convert.DBNull;
	}

	public string strTEN_DU_AN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DU_AN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DU_AN"] = value;
		}
	}

	public bool IsTEN_DU_ANNull() 
	{
		return pm_objDR.IsNull("TEN_DU_AN");
	}

	public void SetTEN_DU_ANNull() {
		pm_objDR["TEN_DU_AN"] = System.Convert.DBNull;
	}

	public decimal dcID_TRANG_THAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRANG_THAI"] = value;
		}
	}

	public bool IsID_TRANG_THAINull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI");
	}

	public void SetID_TRANG_THAINull() {
		pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_DU_AN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_DU_AN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_DU_AN"] = value;
		}
	}

	public bool IsID_LOAI_DU_ANNull()	{
		return pm_objDR.IsNull("ID_LOAI_DU_AN");
	}

	public void SetID_LOAI_DU_ANNull() {
		pm_objDR["ID_LOAI_DU_AN"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_BAT_DAU
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_BAT_DAU"] = value;
		}
	}

	public bool IsNGAY_BAT_DAUNull()
	{
		return pm_objDR.IsNull("NGAY_BAT_DAU");
	}

	public void SetNGAY_BAT_DAUNull()
	{
		pm_objDR["NGAY_BAT_DAU"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_KET_THUC
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_KET_THUC"] = value;
		}
	}

	public bool IsNGAY_KET_THUCNull()
	{
		return pm_objDR.IsNull("NGAY_KET_THUC");
	}

	public void SetNGAY_KET_THUCNull()
	{
		pm_objDR["NGAY_KET_THUC"] = System.Convert.DBNull;
	}

	public string strNOI_DUNG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NOI_DUNG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NOI_DUNG"] = value;
		}
	}

	public bool IsNOI_DUNGNull() 
	{
		return pm_objDR.IsNull("NOI_DUNG");
	}

	public void SetNOI_DUNGNull() {
		pm_objDR["NOI_DUNG"] = System.Convert.DBNull;
	}

	public decimal dcID_CO_CHE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_CO_CHE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_CO_CHE"] = value;
		}
	}

	public bool IsID_CO_CHENull()	{
		return pm_objDR.IsNull("ID_CO_CHE");
	}

	public void SetID_CO_CHENull() {
		pm_objDR["ID_CO_CHE"] = System.Convert.DBNull;
	}

	public decimal dcID_QUYET_DINH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_QUYET_DINH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_QUYET_DINH"] = value;
		}
	}

	public bool IsID_QUYET_DINHNull()	{
		return pm_objDR.IsNull("ID_QUYET_DINH");
	}

	public void SetID_QUYET_DINHNull() {
		pm_objDR["ID_QUYET_DINH"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_DU_AN() 
	{
		pm_objDS = new DS_DM_DU_AN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_DU_AN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_DU_AN(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_DU_AN();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void DeleteDuAnById(DS_DM_DU_AN v_ds_dm_du_an, decimal i_dc_id)
    {
        CStoredProc v_sp = new CStoredProc("pr_DM_DU_AN_Delete");
        v_sp.addDecimalInputParam("@ID", i_dc_id);
        v_sp.fillDataSetByCommand(this, v_ds_dm_du_an);
    }

    public void FillDatasetByID(DS_DM_DU_AN op_ds_dm_da, decimal i_dc_id)
    {
        CStoredProc v_sp = new CStoredProc("pr_DM_DU_AN_select_by_ID");
        v_sp.addDecimalInputParam("@ID", i_dc_id);
        v_sp.fillDataSetByCommand(this, op_ds_dm_da);
    }

    public void FillDataset_search_by_ma_da(DS_DM_DU_AN op_ds_dm_da, string i_str_id)
    {
        CStoredProc v_sp = new CStoredProc("pr_DM_DU_AN_select_by_ma_da");
        v_sp.addNVarcharInputParam("@MA_DA", i_str_id);
        v_sp.fillDataSetByCommand(this, op_ds_dm_da);
    }

    public void FillDatasetSapKetThuc(DS_DM_DU_AN op_ds_dm_da, DateTime i_dat_now)
    {
        CStoredProc v_sp = new CStoredProc("pr_DM_DU_AN_sap_ket_thuc");
        v_sp.addDatetimeInputParam("@DAT_NOW", i_dat_now);
        v_sp.fillDataSetByCommand(this, op_ds_dm_da);
    }
}
}
