///************************************************
/// Generated by: TuyenNT
/// Date: 27/04/2014 03:56:05
/// Goal: Create User Service Class for V_DM_HANG_HOA
///************************************************
/// <summary>
/// Create User Service Class for V_DM_HANG_HOA
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US{

public class US_V_DM_HANG_HOA : US_Object
{
	private const string c_TableName = "V_DM_HANG_HOA";
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

    public void SetMA_HANGNull()
    {
        pm_objDR["MA_HANG"] = System.Convert.DBNull;
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

    public bool IsID_NHOMNull()
    {
        return pm_objDR.IsNull("ID_NHOM");
    }

    public void SetID_NHOMNull()
    {
        pm_objDR["ID_NHOM"] = System.Convert.DBNull;
    }

    public decimal dcID_NHOM_CHA
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_CHA", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_NHOM_CHA"] = value;
        }
    }

    public bool IsID_NHOM_CHANull()
    {
        return pm_objDR.IsNull("ID_NHOM_CHA");
    }

    public void SetID_NHOM_CHANull()
    {
        pm_objDR["ID_NHOM_CHA"] = System.Convert.DBNull;
    }

    public string strTEN_NHOM
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_NHOM", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_NHOM"] = value;
        }
    }

    public bool IsTEN_NHOMNull()
    {
        return pm_objDR.IsNull("TEN_NHOM");
    }

    public void SetTEN_NHOMNull()
    {
        pm_objDR["TEN_NHOM"] = System.Convert.DBNull;
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

    public void SetTEN_NHOM_CHANull()
    {
        pm_objDR["TEN_NHOM_CHA"] = System.Convert.DBNull;
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

    public bool IsID_NHA_CUNG_CAPNull()
    {
        return pm_objDR.IsNull("ID_NHA_CUNG_CAP");
    }

    public void SetID_NHA_CUNG_CAPNull()
    {
        pm_objDR["ID_NHA_CUNG_CAP"] = System.Convert.DBNull;
    }

    public string strTEN_NHA_CUNG_CAP
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_NHA_CUNG_CAP", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_NHA_CUNG_CAP"] = value;
        }
    }

    public bool IsTEN_NHA_CUNG_CAPNull()
    {
        return pm_objDR.IsNull("TEN_NHA_CUNG_CAP");
    }

    public void SetTEN_NHA_CUNG_CAPNull()
    {
        pm_objDR["TEN_NHA_CUNG_CAP"] = System.Convert.DBNull;
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

    public bool IsID_DON_VINull()
    {
        return pm_objDR.IsNull("ID_DON_VI");
    }

    public void SetID_DON_VINull()
    {
        pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
    }

    public string strTEN_DON_VI
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_DON_VI", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_DON_VI"] = value;
        }
    }

    public bool IsTEN_DON_VINull()
    {
        return pm_objDR.IsNull("TEN_DON_VI");
    }

    public void SetTEN_DON_VINull()
    {
        pm_objDR["TEN_DON_VI"] = System.Convert.DBNull;
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

    public void SetTEN_HANG_VNNull()
    {
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

    public void SetTEN_HANG_ENNull()
    {
        pm_objDR["TEN_HANG_EN"] = System.Convert.DBNull;
    }

    public string strANH
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "ANH", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["ANH"] = value;
        }
    }

    public bool IsANHNull()
    {
        return pm_objDR.IsNull("ANH");
    }

    public void SetANHNull()
    {
        pm_objDR["ANH"] = System.Convert.DBNull;
    }

    public string strMA_VACH
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MA_VACH", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MA_VACH"] = value;
        }
    }

    public bool IsMA_VACHNull()
    {
        return pm_objDR.IsNull("MA_VACH");
    }

    public void SetMA_VACHNull()
    {
        pm_objDR["MA_VACH"] = System.Convert.DBNull;
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

    public bool IsGIA_NHAPNull()
    {
        return pm_objDR.IsNull("GIA_NHAP");
    }

    public void SetGIA_NHAPNull()
    {
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

    public bool IsGIA_BANNull()
    {
        return pm_objDR.IsNull("GIA_BAN");
    }

    public void SetGIA_BANNull()
    {
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

    public bool IsGIA_BAN_LENull()
    {
        return pm_objDR.IsNull("GIA_BAN_LE");
    }

    public void SetGIA_BAN_LENull()
    {
        pm_objDR["GIA_BAN_LE"] = System.Convert.DBNull;
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

    public void SetMO_TANull()
    {
        pm_objDR["MO_TA"] = System.Convert.DBNull;
    }

    public string strTRANG_THAI_HANG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TRANG_THAI_HANG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TRANG_THAI_HANG"] = value;
        }
    }

    public bool IsTRANG_THAI_HANGNull()
    {
        return pm_objDR.IsNull("TRANG_THAI_HANG");
    }

    public void SetTRANG_THAI_HANGNull()
    {
        pm_objDR["TRANG_THAI_HANG"] = System.Convert.DBNull;
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

    public string strPART_NUMBER
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "PART_NUMBER", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["PART_NUMBER"] = value;
        }
    }

    public bool IsPART_NUMBERNull()
    {
        return pm_objDR.IsNull("PART_NUMBER");
    }

    public void SetPART_NUMBERNull()
    {
        pm_objDR["PART_NUMBER"] = System.Convert.DBNull;
    }

    public string strNGUOI_MUON
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NGUOI_MUON", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NGUOI_MUON"] = value;
        }
    }

    public bool IsNGUOI_MUONNull()
    {
        return pm_objDR.IsNull("NGUOI_MUON");
    }

    public void SetNGUOI_MUONNull()
    {
        pm_objDR["NGUOI_MUON"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_MUON
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_MUON", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_MUON"] = value;
        }
    }

    public bool IsNGAY_MUONNull()
    {
        return pm_objDR.IsNull("NGAY_MUON");
    }

    public void SetNGAY_MUONNull()
    {
        pm_objDR["NGAY_MUON"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_PHAI_TRA
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_PHAI_TRA", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_PHAI_TRA"] = value;
        }
    }

    public bool IsNGAY_PHAI_TRANull()
    {
        return pm_objDR.IsNull("NGAY_PHAI_TRA");
    }

    public void SetNGAY_PHAI_TRANull()
    {
        pm_objDR["NGAY_PHAI_TRA"] = System.Convert.DBNull;
    }

    public string strNGUOI_TRA
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NGUOI_TRA", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NGUOI_TRA"] = value;
        }
    }

    public bool IsNGUOI_TRANull()
    {
        return pm_objDR.IsNull("NGUOI_TRA");
    }

    public void SetNGUOI_TRANull()
    {
        pm_objDR["NGUOI_TRA"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_TRA
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_TRA", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_TRA"] = value;
        }
    }

    public bool IsNGAY_TRANull()
    {
        return pm_objDR.IsNull("NGAY_TRA");
    }

    public void SetNGAY_TRANull()
    {
        pm_objDR["NGAY_TRA"] = System.Convert.DBNull;
    }

    public decimal dcID_LOAI_HANG
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_HANG", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_LOAI_HANG"] = value;
        }
    }

    public bool IsID_LOAI_HANGNull()
    {
        return pm_objDR.IsNull("ID_LOAI_HANG");
    }

    public void SetID_LOAI_HANGNull()
    {
        pm_objDR["ID_LOAI_HANG"] = System.Convert.DBNull;
    }

    public string strTEN_LOAI_HANG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_LOAI_HANG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_LOAI_HANG"] = value;
        }
    }

    public bool IsTEN_LOAI_HANGNull()
    {
        return pm_objDR.IsNull("TEN_LOAI_HANG");
    }

    public void SetTEN_LOAI_HANGNull()
    {
        pm_objDR["TEN_LOAI_HANG"] = System.Convert.DBNull;
    }

    public decimal dcID_KHO
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_KHO", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_KHO"] = value;
        }
    }

    public bool IsID_KHONull()
    {
        return pm_objDR.IsNull("ID_KHO");
    }

    public void SetID_KHONull()
    {
        pm_objDR["ID_KHO"] = System.Convert.DBNull;
    }

    public string strTEN_KHO
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_KHO", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_KHO"] = value;
        }
    }

    public bool IsTEN_KHONull()
    {
        return pm_objDR.IsNull("TEN_KHO");
    }

    public void SetTEN_KHONull()
    {
        pm_objDR["TEN_KHO"] = System.Convert.DBNull;
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

    public bool IsLEVEL_MODENull()
    {
        return pm_objDR.IsNull("LEVEL_MODE");
    }

    public void SetLEVEL_MODENull()
    {
        pm_objDR["LEVEL_MODE"] = System.Convert.DBNull;
    }

    public decimal dcID_HANG_CHA
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_HANG_CHA", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_HANG_CHA"] = value;
        }
    }

    public bool IsID_HANG_CHANull()
    {
        return pm_objDR.IsNull("ID_HANG_CHA");
    }

    public void SetID_HANG_CHANull()
    {
        pm_objDR["ID_HANG_CHA"] = System.Convert.DBNull;
    }

    public string strTEN_HANG_CHA
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_HANG_CHA", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_HANG_CHA"] = value;
        }
    }

    public bool IsTEN_HANG_CHANull()
    {
        return pm_objDR.IsNull("TEN_HANG_CHA");
    }

    public void SetTEN_HANG_CHANull()
    {
        pm_objDR["TEN_HANG_CHA"] = System.Convert.DBNull;
    }

    #endregion
#region "Init Functions"
	public US_V_DM_HANG_HOA() 
	{
		pm_objDS = new DS_V_DM_HANG_HOA();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_HANG_HOA(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_HANG_HOA(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_HANG_HOA();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDatasetSearch(DS_V_DM_HANG_HOA op_ds, string i_str_search, decimal i_id_kho)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_DM_HANG_HOA_search");
        v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_search);
        v_sp.addDecimalInputParam("@ID_KHO", i_id_kho);

        v_sp.fillDataSetByCommand(this, op_ds);
    }
}
}
