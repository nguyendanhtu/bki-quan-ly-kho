///************************************************
/// Generated by: QUYETNT
/// Date: 16/04/2014 05:07:18
/// Goal: Create User Service Class for DM_LOAI_CHUNG_TU
///************************************************
/// <summary>
/// Create User Service Class for DM_LOAI_CHUNG_TU
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US{

public class US_DM_LOAI_CHUNG_TU : US_Object
{
	private const string c_TableName = "DM_LOAI_CHUNG_TU";
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

	public string strMA_LOAI_CT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_LOAI_CT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_LOAI_CT"] = value;
		}
	}

	public bool IsMA_LOAI_CTNull() 
	{
		return pm_objDR.IsNull("MA_LOAI_CT");
	}

	public void SetMA_LOAI_CTNull() {
		pm_objDR["MA_LOAI_CT"] = System.Convert.DBNull;
	}

	public string strTEN_LOAI_CT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_LOAI_CT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_LOAI_CT"] = value;
		}
	}

	public bool IsTEN_LOAI_CTNull() 
	{
		return pm_objDR.IsNull("TEN_LOAI_CT");
	}

	public void SetTEN_LOAI_CTNull() {
		pm_objDR["TEN_LOAI_CT"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_LOAI_CHUNG_TU() 
	{
		pm_objDS = new DS_DM_LOAI_CHUNG_TU();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_LOAI_CHUNG_TU(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_LOAI_CHUNG_TU(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_LOAI_CHUNG_TU();
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
