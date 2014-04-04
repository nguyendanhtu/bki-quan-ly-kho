///************************************************
/// Generated by: TONGDV
/// Date: 04/04/2014 10:33:44
/// Goal: Create User Service Class for DM_TAI_KHOAN
///************************************************
/// <summary>
/// Create User Service Class for DM_TAI_KHOAN
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US{

public class US_DM_TAI_KHOAN : US_Object
{
	private const string c_TableName = "DM_TAI_KHOAN";
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

	public decimal dcID_NHOM_TAI_KHOAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_TAI_KHOAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NHOM_TAI_KHOAN"] = value;
		}
	}

	public bool IsID_NHOM_TAI_KHOANNull()	{
		return pm_objDR.IsNull("ID_NHOM_TAI_KHOAN");
	}

	public void SetID_NHOM_TAI_KHOANNull() {
		pm_objDR["ID_NHOM_TAI_KHOAN"] = System.Convert.DBNull;
	}

	public decimal dcParentAccountID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ParentAccountID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ParentAccountID"] = value;
		}
	}

	public bool IsParentAccountIDNull()	{
		return pm_objDR.IsNull("ParentAccountID");
	}

	public void SetParentAccountIDNull() {
		pm_objDR["ParentAccountID"] = System.Convert.DBNull;
	}

	public string strMA_TAI_KHOAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_TAI_KHOAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_TAI_KHOAN"] = value;
		}
	}

	public bool IsMA_TAI_KHOANNull() 
	{
		return pm_objDR.IsNull("MA_TAI_KHOAN");
	}

	public void SetMA_TAI_KHOANNull() {
		pm_objDR["MA_TAI_KHOAN"] = System.Convert.DBNull;
	}

	public string strTEN_TAI_KHOAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_TAI_KHOAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_TAI_KHOAN"] = value;
		}
	}

	public bool IsTEN_TAI_KHOANNull() 
	{
		return pm_objDR.IsNull("TEN_TAI_KHOAN");
	}

	public void SetTEN_TAI_KHOANNull() {
		pm_objDR["TEN_TAI_KHOAN"] = System.Convert.DBNull;
	}

	public string strKIEU_TAI_KHOAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "KIEU_TAI_KHOAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["KIEU_TAI_KHOAN"] = value;
		}
	}

	public bool IsKIEU_TAI_KHOANNull() 
	{
		return pm_objDR.IsNull("KIEU_TAI_KHOAN");
	}

	public void SetKIEU_TAI_KHOANNull() {
		pm_objDR["KIEU_TAI_KHOAN"] = System.Convert.DBNull;
	}

	public string strDA_TIEN_TE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DA_TIEN_TE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DA_TIEN_TE"] = value;
		}
	}

	public bool IsDA_TIEN_TENull() 
	{
		return pm_objDR.IsNull("DA_TIEN_TE");
	}

	public void SetDA_TIEN_TENull() {
		pm_objDR["DA_TIEN_TE"] = System.Convert.DBNull;
	}

	public decimal dcTHEO_SO_LUONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "THEO_SO_LUONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["THEO_SO_LUONG"] = value;
		}
	}

	public bool IsTHEO_SO_LUONGNull()	{
		return pm_objDR.IsNull("THEO_SO_LUONG");
	}

	public void SetTHEO_SO_LUONGNull() {
		pm_objDR["THEO_SO_LUONG"] = System.Convert.DBNull;
	}

	public string strDANG_CHI_TIET 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DANG_CHI_TIET", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DANG_CHI_TIET"] = value;
		}
	}

	public bool IsDANG_CHI_TIETNull() 
	{
		return pm_objDR.IsNull("DANG_CHI_TIET");
	}

	public void SetDANG_CHI_TIETNull() {
		pm_objDR["DANG_CHI_TIET"] = System.Convert.DBNull;
	}

	public decimal dcKICH_HOAT 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "KICH_HOAT", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["KICH_HOAT"] = value;
		}
	}

	public bool IsKICH_HOATNull()	{
		return pm_objDR.IsNull("KICH_HOAT");
	}

	public void SetKICH_HOATNull() {
		pm_objDR["KICH_HOAT"] = System.Convert.DBNull;
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
	public US_DM_TAI_KHOAN() 
	{
		pm_objDS = new DS_DM_TAI_KHOAN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_TAI_KHOAN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_TAI_KHOAN(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_TAI_KHOAN();
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
