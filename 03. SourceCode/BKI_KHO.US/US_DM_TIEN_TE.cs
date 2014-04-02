///************************************************
/// Generated by: DucVT
/// Date: 02/04/2014 12:32:08
/// Goal: Create User Service Class for DM_TIEN_TE
///************************************************
/// <summary>
/// Create User Service Class for DM_TIEN_TE
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US{

public class US_DM_TIEN_TE : US_Object
{
	private const string c_TableName = "DM_TIEN_TE";
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

	public string strMA_TIEN_TE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_TIEN_TE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_TIEN_TE"] = value;
		}
	}

	public bool IsMA_TIEN_TENull() 
	{
		return pm_objDR.IsNull("MA_TIEN_TE");
	}

	public void SetMA_TIEN_TENull() {
		pm_objDR["MA_TIEN_TE"] = System.Convert.DBNull;
	}

	public string strTEN_TIEN_TE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_TIEN_TE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_TIEN_TE"] = value;
		}
	}

	public bool IsTEN_TIEN_TENull() 
	{
		return pm_objDR.IsNull("TEN_TIEN_TE");
	}

	public void SetTEN_TIEN_TENull() {
		pm_objDR["TEN_TIEN_TE"] = System.Convert.DBNull;
	}

	public string strDANG_CHU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DANG_CHU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DANG_CHU"] = value;
		}
	}

	public bool IsDANG_CHUNull() 
	{
		return pm_objDR.IsNull("DANG_CHU");
	}

	public void SetDANG_CHUNull() {
		pm_objDR["DANG_CHU"] = System.Convert.DBNull;
	}

	public string strDOI_TEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DOI_TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DOI_TEN"] = value;
		}
	}

	public bool IsDOI_TENNull() 
	{
		return pm_objDR.IsNull("DOI_TEN");
	}

	public void SetDOI_TENNull() {
		pm_objDR["DOI_TEN"] = System.Convert.DBNull;
	}

	public string strKY_HIEU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "KY_HIEU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["KY_HIEU"] = value;
		}
	}

	public bool IsKY_HIEUNull() 
	{
		return pm_objDR.IsNull("KY_HIEU");
	}

	public void SetKY_HIEUNull() {
		pm_objDR["KY_HIEU"] = System.Convert.DBNull;
	}

	public decimal dcDANG_THAP_PHAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DANG_THAP_PHAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DANG_THAP_PHAN"] = value;
		}
	}

	public bool IsDANG_THAP_PHANNull()	{
		return pm_objDR.IsNull("DANG_THAP_PHAN");
	}

	public void SetDANG_THAP_PHANNull() {
		pm_objDR["DANG_THAP_PHAN"] = System.Convert.DBNull;
	}

	public string strGHI_CHU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU"] = value;
		}
	}

	public bool IsGHI_CHUNull() 
	{
		return pm_objDR.IsNull("GHI_CHU");
	}

	public void SetGHI_CHUNull() {
		pm_objDR["GHI_CHU"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_TIEN_TE() 
	{
		pm_objDS = new DS_DM_TIEN_TE();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_TIEN_TE(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_TIEN_TE(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_TIEN_TE();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}
