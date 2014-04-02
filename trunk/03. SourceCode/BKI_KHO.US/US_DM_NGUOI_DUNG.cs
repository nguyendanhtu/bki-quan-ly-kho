///************************************************
/// Generated by: QuyetNT
/// Date: 02-04-2014 12:45:21
/// Goal: Create User Service Class for DM_NGUOI_DUNG
///************************************************
/// <summary>
/// Create User Service Class for DM_NGUOI_DUNG
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US{

public class US_DM_NGUOI_DUNG : US_Object
{
	private const string c_TableName = "DM_NGUOI_DUNG";
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

	public string strMA_NGUOI_DUNG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_NGUOI_DUNG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_NGUOI_DUNG"] = value;
		}
	}

	public bool IsMA_NGUOI_DUNGNull() 
	{
		return pm_objDR.IsNull("MA_NGUOI_DUNG");
	}

	public void SetMA_NGUOI_DUNGNull() {
		pm_objDR["MA_NGUOI_DUNG"] = System.Convert.DBNull;
	}

	public string strHO_NGUOI_DUNG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_NGUOI_DUNG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_NGUOI_DUNG"] = value;
		}
	}

	public bool IsHO_NGUOI_DUNGNull() 
	{
		return pm_objDR.IsNull("HO_NGUOI_DUNG");
	}

	public void SetHO_NGUOI_DUNGNull() {
		pm_objDR["HO_NGUOI_DUNG"] = System.Convert.DBNull;
	}

	public string strTEN_DEM 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DEM", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DEM"] = value;
		}
	}

	public bool IsTEN_DEMNull() 
	{
		return pm_objDR.IsNull("TEN_DEM");
	}

	public void SetTEN_DEMNull() {
		pm_objDR["TEN_DEM"] = System.Convert.DBNull;
	}

	public string strMOBILE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MOBILE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MOBILE"] = value;
		}
	}

	public bool IsMOBILENull() 
	{
		return pm_objDR.IsNull("MOBILE");
	}

	public void SetMOBILENull() {
		pm_objDR["MOBILE"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_SINH
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_SINH", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_SINH"] = value;
		}
	}

	public bool IsNGAY_SINHNull()
	{
		return pm_objDR.IsNull("NGAY_SINH");
	}

	public void SetNGAY_SINHNull()
	{
		pm_objDR["NGAY_SINH"] = System.Convert.DBNull;
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

	public void SetEMAILNull() {
		pm_objDR["EMAIL"] = System.Convert.DBNull;
	}

	public decimal dcID_TO_CHUC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TO_CHUC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TO_CHUC"] = value;
		}
	}

	public bool IsID_TO_CHUCNull()	{
		return pm_objDR.IsNull("ID_TO_CHUC");
	}

	public void SetID_TO_CHUCNull() {
		pm_objDR["ID_TO_CHUC"] = System.Convert.DBNull;
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
	public US_DM_NGUOI_DUNG() 
	{
		pm_objDS = new DS_DM_NGUOI_DUNG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_NGUOI_DUNG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_NGUOI_DUNG(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_NGUOI_DUNG();
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
