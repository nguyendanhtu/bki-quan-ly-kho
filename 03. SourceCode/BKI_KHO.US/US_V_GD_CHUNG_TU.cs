///************************************************
/// Generated by: tuyendv
/// Date: 05/05/2014 12:13:04
/// Goal: Create User Service Class for V_GD_CHUNG_TU
///************************************************
/// <summary>
/// Create User Service Class for V_GD_CHUNG_TU
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US{

public class US_V_GD_CHUNG_TU : US_Object
{
	private const string c_TableName = "V_GD_CHUNG_TU";
#region "Public Properties"
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

	public void SetMA_CTNull() {
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

	public void SetGHI_CHU_1Null() {
		pm_objDR["GHI_CHU_1"] = System.Convert.DBNull;
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

	public void SetDIEN_GIAINull() {
		pm_objDR["DIEN_GIAI"] = System.Convert.DBNull;
	}

	public string strMA_HANG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_HANG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_HANG"] = value;
		}
	}

	public bool IsMA_HANGNull() 
	{
		return pm_objDR.IsNull("MA_HANG");
	}

	public void SetMA_HANGNull() {
		pm_objDR["MA_HANG"] = System.Convert.DBNull;
	}

	public string strTEN_HANG_VN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_HANG_VN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_HANG_VN"] = value;
		}
	}

	public bool IsTEN_HANG_VNNull() 
	{
		return pm_objDR.IsNull("TEN_HANG_VN");
	}

	public void SetTEN_HANG_VNNull() {
		pm_objDR["TEN_HANG_VN"] = System.Convert.DBNull;
	}

	public string strTEN_HANG_EN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_HANG_EN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_HANG_EN"] = value;
		}
	}

	public bool IsTEN_HANG_ENNull() 
	{
		return pm_objDR.IsNull("TEN_HANG_EN");
	}

	public void SetTEN_HANG_ENNull() {
		pm_objDR["TEN_HANG_EN"] = System.Convert.DBNull;
	}

	public decimal dcGIA_NHAP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA_NHAP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA_NHAP"] = value;
		}
	}

	public bool IsGIA_NHAPNull()	{
		return pm_objDR.IsNull("GIA_NHAP");
	}

	public void SetGIA_NHAPNull() {
		pm_objDR["GIA_NHAP"] = System.Convert.DBNull;
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

	public bool IsSO_LUONGNull()	{
		return pm_objDR.IsNull("SO_LUONG");
	}

	public void SetSO_LUONGNull() {
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

	public bool IsGIA_GIAO_DICHNull()	{
		return pm_objDR.IsNull("GIA_GIAO_DICH");
	}

	public void SetGIA_GIAO_DICHNull() {
		pm_objDR["GIA_GIAO_DICH"] = System.Convert.DBNull;
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

	public void SetSO_SERINull() {
		pm_objDR["SO_SERI"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_CHUNG_TU() 
	{
		pm_objDS = new DS_V_GD_CHUNG_TU();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_CHUNG_TU(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_CHUNG_TU(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_CHUNG_TU();
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