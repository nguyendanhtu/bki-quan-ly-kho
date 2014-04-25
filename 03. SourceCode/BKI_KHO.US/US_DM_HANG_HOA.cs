///************************************************
/// Generated by: TuyenNT
/// Date: 31/03/2014 03:59:36
/// Goal: Create User Service Class for DM_HANG_HOA
///************************************************
/// <summary>
/// Create User Service Class for DM_HANG_HOA
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace BKI_KHO.US{

public class US_DM_HANG_HOA : US_Object
{
	private const string c_TableName = "DM_HANG_HOA";
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

	public decimal dcID_NHOM_GOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_GOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NHOM_GOC"] = value;
		}
	}

	public bool IsID_NHOM_GOCNull()	{
		return pm_objDR.IsNull("ID_NHOM_GOC");
	}

	public void SetID_NHOM_GOCNull() {
		pm_objDR["ID_NHOM_GOC"] = System.Convert.DBNull;
	}

	public decimal dcID_NHOM 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NHOM"] = value;
		}
	}

	public bool IsID_NHOMNull()	{
		return pm_objDR.IsNull("ID_NHOM");
	}

	public void SetID_NHOMNull() {
		pm_objDR["ID_NHOM"] = System.Convert.DBNull;
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

	public string strIMAGE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "IMAGE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["IMAGE"] = value;
		}
	}

	public bool IsIMAGENull() 
	{
		return pm_objDR.IsNull("IMAGE");
	}

	public void SetIMAGENull() {
		pm_objDR["IMAGE"] = System.Convert.DBNull;
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

	public decimal dcID_NHA_CUNG_CAP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NHA_CUNG_CAP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NHA_CUNG_CAP"] = value;
		}
	}

	public bool IsID_NHA_CUNG_CAPNull()	{
		return pm_objDR.IsNull("ID_NHA_CUNG_CAP");
	}

	public void SetID_NHA_CUNG_CAPNull() {
		pm_objDR["ID_NHA_CUNG_CAP"] = System.Convert.DBNull;
	}

	public string strBARCODE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "BARCODE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["BARCODE"] = value;
		}
	}

	public bool IsBARCODENull() 
	{
		return pm_objDR.IsNull("BARCODE");
	}

	public void SetBARCODENull() {
		pm_objDR["BARCODE"] = System.Convert.DBNull;
	}

	public decimal dcID_DON_VI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI"] = value;
		}
	}

	public bool IsID_DON_VINull()	{
		return pm_objDR.IsNull("ID_DON_VI");
	}

	public void SetID_DON_VINull() {
		pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
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

	public decimal dcGIA_BAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA_BAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA_BAN"] = value;
		}
	}

	public bool IsGIA_BANNull()	{
		return pm_objDR.IsNull("GIA_BAN");
	}

	public void SetGIA_BANNull() {
		pm_objDR["GIA_BAN"] = System.Convert.DBNull;
	}

	public decimal dcGIA_BAN_LE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA_BAN_LE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA_BAN_LE"] = value;
		}
	}

	public bool IsGIA_BAN_LENull()	{
		return pm_objDR.IsNull("GIA_BAN_LE");
	}

	public void SetGIA_BAN_LENull() {
		pm_objDR["GIA_BAN_LE"] = System.Convert.DBNull;
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

    public bool IsID_TRANG_THAINull()
    {
        return pm_objDR.IsNull("ID_TRANG_THAI");
    }

    public void SetID_TRANG_THAINull()
    {
        pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
    }
#endregion
#region "Init Functions"
	public US_DM_HANG_HOA() 
	{
		pm_objDS = new DS_DM_HANG_HOA();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_HANG_HOA(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_HANG_HOA(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_HANG_HOA();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDatasetById(DS_DM_HANG_HOA op_ds, decimal ip_dc_id)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_DM_HANG_HOA_FillDatasetById");
        v_stored_proc.addDecimalInputParam("@ID", ip_dc_id);
        v_stored_proc.fillDataSetByCommand(this, op_ds);
    }
}
}
