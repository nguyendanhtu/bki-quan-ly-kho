///************************************************
/// Generated by: TuyenNT
/// Date: 19/04/2014 12:17:29
/// Goal: Create User Service Class for V_DM_NHOM_HANG
///************************************************
/// <summary>
/// Create User Service Class for V_DM_NHOM_HANG
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US{

public class US_V_DM_NHOM_HANG : US_Object
{
	private const string c_TableName = "V_DM_NHOM_HANG";
#region "Public Properties"
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

	public bool IsSTTNull()	{
		return pm_objDR.IsNull("STT");
	}

	public void SetSTTNull() {
		pm_objDR["STT"] = System.Convert.DBNull;
	}

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

	public void SetTENNull() {
		pm_objDR["TEN"] = System.Convert.DBNull;
	}

	public string strTEN_NHOM_CHA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NHOM_CHA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NHOM_CHA"] = value;
		}
	}

	public bool IsTEN_NHOM_CHANull() 
	{
		return pm_objDR.IsNull("TEN_NHOM_CHA");
	}

	public void SetTEN_NHOM_CHANull() {
		pm_objDR["TEN_NHOM_CHA"] = System.Convert.DBNull;
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

	public bool IsLEVEL_MODENull()	{
		return pm_objDR.IsNull("LEVEL_MODE");
	}

	public void SetLEVEL_MODENull() {
		pm_objDR["LEVEL_MODE"] = System.Convert.DBNull;
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

	public void SetMO_TANull() {
		pm_objDR["MO_TA"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_NHOM_HANG() 
	{
		pm_objDS = new DS_V_DM_NHOM_HANG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_NHOM_HANG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_NHOM_HANG(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_NHOM_HANG();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion



    public void FillDatasetSearch(DS_V_DM_NHOM_HANG op_ds, string i_str_search)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_DM_NHOM_HANG_search");
        v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_search);
        v_sp.fillDataSetByCommand(this, op_ds);
    }
}
}
