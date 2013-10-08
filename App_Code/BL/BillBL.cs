using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using WPM.BusinessObjects;
using WPM.DataLayer;
using System.Collections;

namespace WPM.BusinessLayer
{
    class BillBL
    {

        #region Objects
        BillDL oDL;
       
        #endregion

        #region Constructor
        public BillBL()
        {
            oDL = new BillDL();
        }
        #endregion

        #region Methods
        public DataTable GetIssueAssets(int argCCId, int argContId, int argWORegId)
        {
            return oDL.GetIssueAssets(argCCId, argContId, argWORegId);
        }
        public bool Update_FAWorkBill(DataTable argDt)
        {
            return oDL.Update_FAWorkBill(argDt);
        }
        //update
        public void UpdateTDSUpdateToFAService()
        {
            oDL.UpdateTDSUpdateToFAService();
        }

        public void UpdateTDSUpdateToFAHire()
        {
            oDL.UpdateTDSUpdateToFAHire();
        }

        public void UpdateTDSUpdateToFAWorkBill()
        {
            oDL.UpdateTDSUpdateToFAWorkBill();
        }
        public bool CheckVendorWOBill(string argBillNo, int argRegId, int argVendorId)
        {
            return oDL.CheckVendorWOBill(argBillNo, argRegId, argVendorId);
        }

        public DataTable BillStageDetails(DateTime argFDate, DateTime argTDate, int argCCId, string argDBName)
        {
            return oDL.BillStageDetails(argFDate, argTDate, argCCId, argDBName);
        }

        public bool Update_FAWorkBill(int argRegId)
        {
            return oDL.Update_FAWorkBill(argRegId);
        }

        public DataTable GetLabourStrength(DateTime argFDate, DateTime argTDate, int argCCID, int argContId, int argWORegId)
        {
            return oDL.GetLabourStrength(argFDate,argTDate,argCCID,argContId,argWORegId);
        }

        public void WCTDetails(DateTime argFDate, DateTime argTDate, int argCCId, int argContId, int argCompanyId)
        {
            oDL.WCTDetailsNew(argFDate, argTDate, argCCId, argContId, argCompanyId);
        }
        public DataTable GetWCTDetails()
        {
            return oDL.GetWCTDetails();
        }


        public DataTable GetBillAdvancePrintDetails(DateTime dStart, DateTime dEnd, int argCompanyId, int argContId, int argCCId)
        {
            return oDL.GetBillAdvancePrintDetails(dStart, dEnd, argCompanyId, argContId, argCCId);
        }

        public string GetDPERegIdWO(int argBillRegId)
        {
            return oDL.GetDPERegIdWO(argBillRegId);
        }

        public void GetBillDetailRegister(DateTime argFromDate, DateTime argToDate, int argCCId, int argContId, int argCompanyId)
        {
            oDL.GetBillDetailRegister(argFromDate, argToDate, argCCId, argContId, argCompanyId);
        }

        public void InsertTmpBillAdvancePrintDetails(DataTable argDt)
        {
            oDL.InsertTmpBillAdvancePrintDetails(argDt);
        }
        public DataTable FinancialProgress(DateTime argFrmDate, DateTime argToDate)
        {
            return oDL.FinancialProgress(argFrmDate, argToDate);
        }

        public DataTable BillPaymentDetails(DateTime argFDate, DateTime argTDate, int argCCId, int argContId, int argCompanyId)
        {
            return oDL.BillPaymentDetails(argFDate, argTDate, argCCId, argContId, argCompanyId);
        }

        public decimal getWOSumQty(int argCCId, int argIOWID, int argContractorId, int argAnalysID, int argCompId, int argWoRegId, bool argAmendment,string argType)
        {
            return oDL.getWOSumQty(argCCId, argIOWID, argContractorId, argAnalysID, argCompId, argWoRegId, argAmendment,argType);
        }

        public decimal getWOWBSQty(int argCCId, int argIOWID, int argContractorId, int argAnalysID, int argCompId, string arfType, int argWoRegId, bool argWoAmdment)
        {
            return oDL.getWOWBSQty(argCCId, argIOWID, argContractorId, argAnalysID, argCompId, arfType, argWoRegId, argWoAmdment);
        }

        public void InsertBillLSWBSTrans(int argBillRegId, int argRevId, string argSplit,string argLSCCNo,string argDBName)
        {
            oDL.InsertBillLSWBSTrans(argBillRegId, argRevId, argSplit, argLSCCNo,argDBName);
        }

        public DataTable  GetWOAdvanceAdvAmt(int argCCId, int argContId, int argWoRegId)
        {
            return oDL.GetWOAdvanceAdvAmt(argCCId, argContId, argWoRegId);
        }

        public DataTable GetWOAdvanceDetails(int argBillRegId, int argWORegId, int argCCId, int argContId)
        {
            return oDL.GetWOAdvanceDetails(argBillRegId, argWORegId, argCCId,argContId);
        }

        public decimal getIOWQtyWithoutWBS(int argCCId, int argIOWID, int argContractorId, string arfType, int argWoRegId)
        {
            return oDL.getIOWQtyWithoutWBS(argCCId, argIOWID, argContractorId,arfType, argWoRegId);
        }

        public decimal getIOWQtyWithWBS(int argCCId, int argIOWID, int argContractorId, string arfType, int argWoRegId, int argAnalId, int argBillTranId)
        {
            return oDL.getIOWQtyWithWBS(argCCId, argIOWID, argContractorId, arfType, argWoRegId, argAnalId, argBillTranId);
        }

        public decimal getIOWCumQty(int argCCId, int argIOWID, int argContractorId, int argAnalysID, int argCompId, string arfType, int argWoRegId, int argBillTransId)
        {
            return oDL.getIOWCumQty(argCCId, argIOWID, argContractorId, argAnalysID, argCompId, arfType, argWoRegId, argBillTransId);
        }

        public bool CheckBillNO(string argBillNO,string frmWhere)
        {
            return oDL.CheckBillNO(argBillNO, frmWhere);
        }      

        public DataTable GetBillTDSE(int argBillRegId, int argFormatTypeId)
        {
            return oDL.GetBillTDSE(argBillRegId,argFormatTypeId);
        }

        public DataTable GetWoAmt(int argWoRegId,decimal argQty,int argAnlId)
        {
            return oDL.GetWoAmt(argWoRegId, argQty,argAnlId);
        }

        public DataTable GetDPERegId(int argAnalysisId, int argWoRegId)
        { 
            return oDL.GetDPERegId(argAnalysisId,argWoRegId);
        }

        public decimal GetDPEBillLSRate(int argResId, string argDBName)
        {
            return oDL.GetDPEBillLSRate(argResId,argDBName);
        }

        public DataTable GetWOQualifierOverAll(int argWoRegId, int argCCId, int argContId)
        {
            return oDL.GetWOQualifierOverAll(argWoRegId, argCCId,argContId);
        }
        public DataTable GetWOFixRate(int argWOREgId)
        {
            return oDL.GetWOFixRate(argWOREgId);
        }

        public DataTable PopulateAccountInternal(bool argInternal)
        {
            return oDL.PopulateAccountInternal(argInternal);
        }

        public DataTable GetWOResQual(int argWORegId, string argWOType, int argContId, int argCCId)
        {
            return oDL.GetWOResQual(argWORegId, argWOType, argContId, argCCId);
        }

        public decimal GetTkeyPrevAmt(int argWORegId, string argmode, int argBRegId)
        {
            return oDL.GetTkeyPrevAmt(argWORegId, argmode, argBRegId);
        }
        public DataTable GetDPETurnKeyDet(string argDPERegId, string argDBName)
        {
            return oDL.GetDPETurnKeyDet(argDPERegId,argDBName);
        }

        public decimal GetBillTCumQty(int argAnalysisId, int argContId, int argCCId)
        {
            return oDL.GetBillTCumQty(argAnalysisId, argContId, argCCId);
        }

        public decimal GetTkeyPrevQty(int argWORegId, int argAnalTransId, int argBillRegId, int argAnalId)
        {
            return oDL.GetTkeyPrevQty(argWORegId,argAnalTransId,argBillRegId,argAnalId);
        }

        public decimal GetWOTurnKEyQty(int argWORegId, int argAnalId)
        {
            return oDL.GetWOTurnKEyQty(argWORegId, argAnalId);
        }

        //public DataTable GetTurnKeyWO(int argWoRegId)
        //{
        //    return oDL.GetTurnKeyWO(argWoRegId);
        //}
        public DataTable GetDetaildWB(int argCCId, DateTime argFrmDate, DateTime argToDate, int argRevId, string argBType, string argDBName,bool argAbstract)
        {
            return oDL.GetDetaildWB(argCCId, argFrmDate, argToDate, argRevId, argBType,argDBName,argAbstract);
        }

        public DataTable GetWBSWiseWB(int argCCId, DateTime argFrmDate, DateTime argToDate, int argRevId, string argBType, string argDBName)
        {
            return oDL.GetWBSWiseWB(argCCId, argFrmDate, argToDate, argRevId, argBType,argDBName);
        }




        public DataTable GetAdvBillAdjustment(int argBillRegId)
        {
            return oDL.GetAdvBillAdjustment(argBillRegId);
        }

        public DataTable PopulateGetWOAdvanceAmount(int argCCId, int argContId, int argBillRegId, int argWORegId)
        {
            return oDL.PopulateGetWOAdvanceAmount(argCCId,argContId,argBillRegId,argWORegId);
        }

        public DataTable PopulateLabourAdvanceAmount(int argCCId, int argContId, int argBillRegId)
        {
            return oDL.PopulateLabourAdvanceAmount(argCCId, argContId, argBillRegId);
        }

        public  DataTable GetWOAdjustmemnt(int argVenId, int argCCId,int WORegId)
        {
            return oDL.GetWOAdjustmemnt(argVenId, argCCId, WORegId);
        }

        public DataTable PopulateDetailsPrintNew(int argCCId, int argContId, int argCompId, DateTime argFDate, DateTime argTDate, int argBillRegId)
        {
            return oDL.PopulateDetailsPrintNew(argCCId, argContId, argCompId, argFDate, argTDate, argBillRegId);
        }

        public  DataSet PopulateDetailsPrint(int argCCId, int argContId, int argCompId, DateTime argFDate, DateTime argTDate,int argBillRegId)
        {
            return oDL.PopulateDetailsPrint(argCCId, argContId, argCompId, argFDate, argTDate, argBillRegId);
        }

        public DataTable GetDetailsColumn(int argCCId)
        {
            return oDL.GetDetailsColumn(argCCId);
        }

        public DataTable GetWOBillDetails(int argBillRegId)
        {
           return oDL.GetWOBillDetails(argBillRegId);
        }

        public DataTable BindGridDetails(string argType, int argID, int argCCId, int argContractId, int m_lRevId, int argPartRate, decimal argRate, string argSplit, int argAHeadId, int argWoRegId, int argLbrResId, int argBillRegId, string argMode, bool argWOAmdment, string argRateType, string argDBName,string argDPERegId)
        {
            return oDL.BindGridDetails(argType, argID, argCCId, argContractId, m_lRevId, argPartRate, argRate, argSplit, argAHeadId, argWoRegId, argLbrResId, argBillRegId, argMode, argWOAmdment, argRateType,argDBName,argDPERegId);
        }

        //public void UpdateSortOrderCC(DataTable dt, string argfrm,int argccId)
        //{
        //    oDL.UpdateSortOrderCC(dt, argfrm, argccId);
        //}

        public void UpdateSortOrderCCNew(DataTable dt,  int argccId)
        {
            oDL.UpdateSortOrderCCNew(dt,  argccId);
        }

        public void UpdateSortOrderMaster(DataTable dt)
        {
            oDL.UpdateSortOrderMaster(dt);
        }

        public DataTable GetIssueMaterials(int argCCId, int argContId ,DateTime argDate, int argWORegId)
        {
            return oDL.GetIssueMaterials(argCCId, argContId , argDate, argWORegId);
        }

        public DataTable getBillWBSTranQtyEdit(int argDPETransId, int argAHeadID)
        {
            return oDL.getBillWBSTranQtyEdit(argDPETransId, argAHeadID);
        }

        public DataTable BillWBSE(int argBillTransId, string split, int RevId, int argIOWTransId, string argDBName)
        {
            return oDL.BillWBSE(argBillTransId, split, RevId, argIOWTransId,argDBName);
        }

        public void DeleteBillDetails(int BillRegId, int iCCId, int argContId, int argRevId, int argWoRegId,string argDBName)
        {
            oDL.DeleteBillDetails(BillRegId, iCCId, argContId, argRevId, argWoRegId,argDBName);
        }

        public decimal ChekAmtPaid(int argBRegId)
        {
            return oDL.ChekAmtPaid(argBRegId);
        }

        public DataTable GetBillTransId(int argTypeId)
        {
            return oDL.GetBillTransId(argTypeId);
        }

        public DataTable GetMatBRegId(int argTypeId)
        {
            return oDL.GetMatBRegId(argTypeId);
        }

        public DataTable GetLbrBRegId(int argTypeId,bool argInternal)
        {
            return oDL.GetLbrBRegId(argTypeId, argInternal);
        }

        public DataTable GetLbrAdvBRegId(int argTypeId)
        {
            return oDL.GetLbrAdvBRegId(argTypeId);
        }

        public int GetMeasurementQtyDigit(int argCCId)
        {
            return oDL.GetMeasurementQtyDigit(argCCId);
        }

        public DataTable PopularAHeadName(string argDBName)
        {
            return oDL.PopulatAHeadName(argDBName);
        }

        public bool GetProjectDB(int argCostCentreId, string argDBName)
        {
            return oDL.GetProjectDB(argCostCentreId,argDBName);
        }

        //public bool GetZCRProjectDB(int argCostCentreId)
        //{
        //    return oDL.GetZCRProjectDB(argCostCentreId);
        //}

        public string DisplayAnalysisHead(int argAHeadID)
        {
            return oDL.DisplayAnalysisHead(argAHeadID);
        }

        public DataSet GetCumBillDetails(int argBRegId)
        {
            return oDL.GetCumBillDetails(argBRegId);
        }

        public void GetBillTrans(int argBillRegId, string argBillType, string argSplit, ArrayList argBType, int argRevId, string argDBName)
        {
            oDL.GetBillTrans(argBillRegId, argBillType, argSplit, argBType,argRevId,argDBName);
        }

        public void GetBillIOWTrans(int argBillRegId, string argBillType, string argSplit, int argRevId, string argDBName)
        {
            oDL.GetBillIOWTrans(argBillRegId, argBillType, argSplit,argRevId,argDBName);
        }

        public void UpdateCumulateBillTrans(int argBillRegId, int argCCId, int argContId,string argWORegId)
        {
            oDL.UpdateCumulateBillTrans(argBillRegId, argCCId, argContId,argWORegId);
        }

        public void UpdateTmpComp(int argBillRegId, int argCCId, int argContId, ArrayList argBillType, string argWORegId)
        {
            oDL.UpdateTmpComp(argBillRegId, argCCId, argContId, argBillType,argWORegId);
        }

        public void UpdateTmpIOW(int argBillRegId, int argCCId, int argContId, ArrayList argBillType, string argWORegId)
        {
            oDL.UpdateTmpIOW(argBillRegId, argCCId, argContId, argBillType,argWORegId);
        }

        public void TruncateLbrTrans()
        {
            oDL.TruncateLbrTrans();
        }
        public void UpdateTmpCumLabourType(int argBillRegId, int argCCId, int argContId, string argWOREgId)
        {
            oDL.UpdateTmpCumLabourType(argBillRegId, argCCId, argContId,argWOREgId);
        }
        public void GetBillMatreialTrans(int argBillRegId)
        {
            oDL.GetBillMatreialTrans(argBillRegId);
        }
        public void GetBillLbrTrans(int argBillRegId)
        {
            oDL.GetBillLbrTrans(argBillRegId);
        }
        public void GetBillLbrTypeTrans(int argBillRegId, string argDBName)
        {
            oDL.GetBillLbrTypeTrans(argBillRegId,argDBName);
        }

        public void GetBillServiceTrans(int argBillRegId)
        {
            oDL.GetBillServiceTrans(argBillRegId);
        }
        public DataTable GetIOWMeasurmentTrans(int argBillTransId, int argIOWId)
        {
            return oDL.GetIOWMeasurmentTrans(argBillTransId, argIOWId);
        }
        public DataTable GetBillLbrItemTrans(int argBillTransId)
        {
            return oDL.GetBillLbrItemTrans(argBillTransId);
        }

        public DataTable GetBillIOWDetails(int argBillTransId, int argRevId, int argResourceId, string argSplit, string argDBName)
        {
            return oDL.GetBillIOWDetails(argBillTransId, argRevId, argResourceId, argSplit,argDBName);
        }

        public DataTable GetBillType(int argDPERegId)
        {
            return oDL.GetBillType(argDPERegId);
        }

        public void DeleteBillFormatMaster(int argTypeId)
        {
            oDL.DeleteBillFormatMaster(argTypeId);
        }

        public int DeleteBillFormat(int argTypeId,int argCCId)
        {
            return oDL.DeleteBillFormat(argTypeId, argCCId);
        }

        public string GetSplit(int argRevId,string argDBName)
        {
            return oDL.GetSplit(argRevId,argDBName);
        }

        public string GetLSSplit(int argCCId,string argDBName)
        {
            return oDL.GetSplit(argCCId,argDBName);
        }


        public DataTable GetBillList(DateTime frmDate, DateTime toDate, int argOption, string argBillType, int argCCId, int argContId, int argCompId)
        {
            return oDL.GetBillList(frmDate, toDate, argOption, argBillType,argCCId,argContId,argCompId);
        }

        public DataTable GetBillRegValue(int argRegId)
        {
            return oDL.GetBillRegValue(argRegId);
        }

        public DataTable GetFormate(int argCCId, string argFType, int argContId,ref bool argAccountFound)
        {
            return oDL.GetFormate(argCCId, argFType, argContId,ref argAccountFound);
        }
        public DataTable InsertBillFormat(int argQualId, int argQTypeId, string argQualName, int argAddType, int argCCId)
        {
            return oDL.InsertBillFormat(argQualId, argQTypeId, argQualName, argAddType, argCCId);
        }
        public DataTable PopulateAccountName()
        {
            return oDL.PopulateAccountName();
        }

        //public DataTable GetBillFormatTDS(int argTypeId, int argCCId)
        //{
        //    return oDL.GetBillFormatTDS(argTypeId, argCCId);
        //}

        public DataTable GetWBSMeasurementE(int argIOWID, int argBTransId, int argAheadId)
        {
            return oDL.GetWBSMeasurementE(argIOWID, argBTransId, argAheadId);
        }
        public DataTable GetMeasurement(int argIOWID, string argSplit, string argDBName)
        {
            return oDL.GetMeasurement(argIOWID,argSplit,argDBName);
        }

        public DataTable GetSteel() { return oDL.GetSteel(); }

        public DataTable getBillIOWTranQtyEdit()
        {
            return oDL.getBillIOWTranQtyEdit();
        }

        public decimal GetIOWTRansQty(int resourceId, int argIOWID, int argAHeadID, int argCCId, string split, string argDBName)
        {
            return oDL.GetIOWTRansQty(resourceId, argIOWID, argAHeadID, argCCId, split,argDBName);
        }

        //public decimal getWOIOWTransQtyE(int argIOWID, int argTransId, int argAHeadID)
        //{
        //    return oBillDL.getWOIOWTransQtyE(argIOWID, argTransId, argAHeadID);
        //}

        public void UpdateIOWTranQty(List<BillIOWTransUpdate> argBIOWTransUpd, int iBillTransId)
        {
            oDL.UpdateIOWTranQty(argBIOWTransUpd, iBillTransId);
        }

        public DataTable getWorkOrder(int argCCId, int argContId, string argmode)
        {
            return oDL.getWorkOrder(argCCId, argContId, argmode);
        }

        public DataSet GetWORefPopulate(int argWORegId)
        {
            return oDL.GetWORefPopulate(argWORegId);
        }

        public decimal GetSurcharge(int argTypeId, int argCCId)
        {
            return oDL.GetSurcharge(argTypeId, argCCId);
        }

        public int GetFACCId(int argCCId)
        {
            return oDL.GetFACCId(argCCId);
        }

        public int GetFAContractId(int argContId)
        {
            return oDL.GetFAContractId(argContId);
        }

        public DataTable getMaterial(string argCompId, int argRevid, string argDBName, string argType, int argWORegId)
        {
            return oDL.getMaterial(argCompId, argRevid,argDBName,argType,argWORegId);
        }

        public DataTable getReturnMaterial(string argCompId)
        {
            return oDL.getReturnMaterial(argCompId);
        }

        public decimal GetRecoveryQty(int argIssueId)
        {
            return oDL.GetRecoveryQty(argIssueId);
        }

        public DataTable GetDPEBillType(string argDPERegId)
        {
            return oDL.GetDPEBillType(argDPERegId);
        }

        public DataTable getDPEList(int argCCId, int argContId, string argtype, string argDPEType, string argDPERegId, bool argInternal, int argWOAccId, int argWoRegId,string argCostOption,int argBillRegId,string argDPERegIdO,int argTypeId)
        {
            return oDL.getDPEList(argCCId, argContId, argtype, argDPEType, argDPERegId, argInternal, argWOAccId, argWoRegId, argCostOption, argBillRegId, argDPERegIdO,argTypeId);
        }

        public bool CheckDPEMUnit(string argBilType, string argDPERegId)
        {
            return oDL.CheckDPEMUnit(argBilType, argDPERegId);
        }

        public DataTable getPopulabourDPE(string argDPERegId,string argBtype)
        {
            return oDL.getPopulabourDPE(argDPERegId, argBtype);
        }

        public DataTable getPopulateService(string argDPERegId, string argBillType)
        {
            return oDL.getPopulateService(argDPERegId, argBillType);
        }

        public DataTable getPopulateDPEIOWCol(string argDPERegId, string argBtype, string argDBName)
        {
            return oDL.getPopulateDPEIOWCol(argDPERegId, argBtype,argDBName);
        }

        public DataTable getBillLSWBSTranQtyEdit(int argTransId, int argTypeId, int argAnalId, string argLSRegId)
        {
            return oDL.getBillLSWBSTranQtyEdit(argTransId, argTypeId, argAnalId, argLSRegId);
        }

        public DataTable getDPEWBSTranQtyEdit(string argDPERegId, int argIOWTransId, int argAnalId)
        {
            return oDL.getDPEWBSTranQtyEdit(argDPERegId, argIOWTransId, argAnalId);
        }
        public DataTable GetDPELabourIOWActivityItem(string argDPERegId, int argAHeadId, int argIOWId, int argCompId, string argRateType)
        {
            return oDL.GetDPELabourIOWActivityItem(argDPERegId, argAHeadId, argIOWId, argCompId, argRateType);
        }
        public DataTable GetDPELabourIOWSubtem(string argDPERegId, int argAHeadId, int argIOWId, int argSubIOWId)
        {
            return oDL.GetDPELabourIOWSubtem(argDPERegId, argAHeadId, argIOWId, argSubIOWId);
        }
        public DataTable GetDPELabourWBSItem(string argDPERegId, int argAHeadId, int argIOWId)
        {
            return oDL.GetDPELabourWBSItem(argDPERegId, argAHeadId, argIOWId);
        }
        public DataTable GetDPELabourItem(string argDPERegId, int argIOWId)
        {
            return oDL.GetDPELabourItem(argDPERegId, argIOWId);
        }
        public DataTable GetDPELabourItemActivity(string argDPERegId, int argCompId, string argRateType)
        {
            return oDL.GetDPELabourItemActivity(argDPERegId, argCompId, argRateType);
        }

        public decimal getLSWBSCumQty(int argCCId, int argLbrResId, int argContId, int argAnalysId, int argBillRegId)
        {
           return oDL.getLSWBSCumQty(argCCId,argLbrResId,argContId,argAnalysId,argBillRegId);
        }

        public DataTable getDPEWBSCol(string argDPERegId, int argIOWTransId, int RevId, string argDBName)
        {
            return oDL.getDPEWBSCol(argDPERegId, argIOWTransId, RevId,argDBName);
        }

        public DataTable GetLSWBS(int argRevId, int argResId, string argDBName)
        {
            return oDL.GetLSWBS(argRevId, argResId, argDBName);
        }

        public DataTable GetDPEWBSMsrment(int argIOWID, string argDPERegId, int argAheadId)
        {
            return oDL.GetDPEWBSMsrment(argIOWID, argDPERegId, argAheadId);
        }

        public void GetEStAmt(string argType, int argResId, int argIOWId, string argSplit, string argDBName, int argRevId, string argRateType, int argWORegId, int argBillId, int argCCId, string argDPERegId, ref decimal argEstAmt, ref decimal argWOAmt, ref decimal argWOBillAmt, ref decimal argTotBillAmt, ref decimal argCurAmt)
        {
            oDL.GetEStAmt(argType, argResId, argIOWId, argSplit, argDBName, argRevId, argRateType, argWORegId, argBillId, argCCId, argDPERegId, ref argEstAmt, ref argWOAmt, ref argWOBillAmt, ref argTotBillAmt, ref argCurAmt);
        }

        public decimal GetWOCompRate(int argCompId, int argCboWoRegId, int argiCCid, int argContId)
        {
            return oDL.GetWOCompRate(argCompId,argCboWoRegId,argiCCid,argContId);
        }

        public decimal GetCompRate(int argCompId, int argRevId, string argDBName)
        {
            return oDL.GetCompRate(argCompId, argRevId,argDBName);
        }
        public string getLsID(string LbrIds, int argCCId, int argContId)
        {
            return oDL.getLsID(LbrIds, argCCId, argContId);
        }

        public string getLSVNo(int argBillRegId)
        {
            return oDL.getLSVNo(argBillRegId);
        }

        public decimal GetWOIOWRate(int argIOWID, int argCboWoRegId, int argiCCid, int argContId)
        {
            return oDL.GetWOIOWRate(argIOWID, argCboWoRegId, argiCCid, argContId);
        }

        public decimal GetIOWRate(int argIOWID, string argBillType, int argRevId, string argDBName)
        {
            return oDL.GetIOWRate(argIOWID, argBillType, argRevId,argDBName);
        }

        public DataTable getLSList(int argCCId, int argContId, string argLSRegId, bool argInternal,int argWORegId,int argTypeId)
        {
            return oDL.getLSList(argCCId, argContId, argLSRegId, argInternal,argWORegId,argTypeId);
        }

        public DataTable getFromLbrAuto(int argCCId, int argContId, string argLSRegId, DateTime argFrmDate, DateTime argToDate, bool argInternal)
        {
            return oDL.getFromLbrAuto(argCCId, argContId, argLSRegId, argFrmDate, argToDate, argInternal);
        }

        public DataTable VendorList(string argType, string argVendorId)
        {
            return oDL.VendorList(argType, argVendorId);
        }

        public void UpdateTmpBillFormatAbsTotal(int argCCid, string argVendorId, DateTime frmDate, DateTime toDate)
        {
            oDL.UpdateTmpBillFormatAbsTotal(argCCid, argVendorId, frmDate, toDate);
        }

        public DataTable PopulateLS(string argLSRegId, string argFormtType, bool argInternal, string argBtnClk)
        {
            return oDL.PopulateLS(argLSRegId, argFormtType, argInternal, argBtnClk);
        }

        public string GetAnalysisHeadName(int argAHeadId, string argDBName)
        {
            return oDL.GetAnalysisHeadName(argAHeadId,argDBName);
        }

        public DataTable UpdateLabourTrans(string argDPERegID)
        {
            return oDL.UpdateLabourTrans(argDPERegID);
        }

        public decimal GetLabourRate(int argLbrTypeId, int argCCId, string argDBName)
        {
            return oDL.GetLabourRate(argLbrTypeId, argCCId,argDBName);
        }

        public decimal GetLabourMinRate(int argLbrTypeId, int argCCId)
        {
            return oDL.GetLabourMinRate(argLbrTypeId, argCCId);
        }

        public decimal GetLabourAppRate(int argLbrTypeId, int argCCId)
        {
            return oDL.GetLabourAppRate(argLbrTypeId, argCCId);
        }

        public DataTable InsertDPE(int argCompId,string argSplit,int argRevId,string argDBName)
        {
            return oDL.InsertDPE(argCompId, argSplit, argRevId,argDBName);
        }

        public DataTable getDPEDetailsE(int argIOWId, int argAnlysId, string argDEPRegId, int argCompId)
        {
            return oDL.getDPEDetailsE(argIOWId, argAnlysId, argDEPRegId, argCompId);
        }

        public DataTable PopulateMeasrColl(int argIowId, string argBilType, string argDPERedId,int argAHeadId,int argCompId)
        {
            return oDL.PopulateMeasrColl(argIowId,argBilType,argDPERedId,argAHeadId,argCompId);
        }

        public DataTable PopulateIOWLabourColl(int argCompId,string argDPERegID, int argIOWID, int argAHeadID)
        {
            return oDL.PopulateIOWLabourColl(argCompId,argDPERegID, argIOWID, argAHeadID);
        }

        public DataTable UpdateItemLbrTrans(string argDPERegId,int argCompId,string argBtype)
        {
            return oDL.UpdateItemLbrTrans(argDPERegId, argCompId, argBtype);
        }

        public DataTable InsertSubIOW(int argCompId, string argSplit, int argRevId, string argDBName)
        {
            return oDL.InsertSubIOW(argCompId, argSplit, argRevId,argDBName);
        }

        public DataSet PopulateBillFormate()
        {
            return oDL.PopulateBillFormate();
        }
        public DataTable PopulateBillFormatType(int argTypeId)
        {
            return oDL.PopulateBillFormatType(argTypeId);
        }

        public DataTable GetBillFormateDetails(int argTypeId, string argType)
        {
            return oDL.GetBillFormateDetails(argTypeId, argType);
        }

        public void InsertBFMaster(BillFormatMaster argBFMaster, string argfrm)
        {
            oDL.InsertBFMaster(argBFMaster, argfrm);
        }

        public int BillFormatMaxOrdNo(string argfrm)
        {
            return oDL.BillFormatMaxOrdNo(argfrm);
        }

        public void UpdateBFMaster(BillFormatMaster argBFMaster, string m_sArgType)
        {
            oDL.UpdateBFMaster(argBFMaster, m_sArgType);
        }

        public int BillFormatMaxTypeId(string argfrm)
        {
            return oDL.BillFormatMaxTypeId(argfrm);
        }

      

        public int CheckTypeIdUsed(int argTypeID)
        {
            return oDL.CheckTypeIdUsed(argTypeID);
        }        
        
        public DataTable getTypeList(int argCCId,string argType)
        {
            return oDL.getTypeList(argCCId,argType);
        }
        
        public void InsertIntoCBFormat(int argTypeId, int argCCId, int argOrderNo, string argType)
        {
            oDL.InsertIntoCBFormat(argTypeId, argCCId, argOrderNo, argType);
        }
        public DataTable PopulateCCBillFormate(int argCCID)
        {
            return oDL.PopulateCCBillFormate(argCCID);
        }
        public DataTable GetCCBillFormatType(int argTypeId, int argCCId)
        {
            return oDL.GetCCBillFormatType(argTypeId, argCCId);
        }

        public DataTable PopulateBillFormat(int argTypeId, int argCCId, string frmWhere)
        {
            return oDL.PopulateBillFormat(argTypeId, argCCId, frmWhere);
        }

        public void InsertBillFormatTDS(BillFormateTDSBO arfTDS)
        {
            oDL.InsertBillFormatTDS(arfTDS);
        }

        //public void UpdateBillFormatTDS(BillFormatMaster arfTDSM)
        //{
        //    oBillDL.UpdateBillFormatTDS(arfTDSM);
        //}

        public DataTable GetMaterialAdvance(int argBillRegId)
        {
            return oDL.GetMaterialAdvance(argBillRegId);
        }

        public DataTable GetAdvance(int argBillRegId, int argCCId, int argContId, int argWOREgId)
        {
            return oDL.GetAdvance(argBillRegId, argCCId, argContId, argWOREgId);
        }
        public int InsertBillEntries(BillRegister argBReg, List<BillAbstract> argBAbs, List<BillEntry> argBEntry, List<BillLabourTypeTransBO> argBLbrType, List<BillMaterialRecovery> argBMatRec, List<BillIOWTransUpdate> argBIOWTrans, List<BIMeasurementBO> argBIMsrment, List<BillIOWMeasurementBOUpdate> argBIOWMsrment, List<BillFormateTDSNewBO> argBFTDS, DataTable argBLbrTrNew, string argBillType, int argCCId, int argContId, int argBdetId, int argRevId, List<BillWBSTrans> argWBSTrans, List<BillWBSMeasurementTransBO> argWBSMsrTrans, List<DPERegTrans> argDPE, ref bool argUpdate, ref string argRefNo, List<BillAdvanceBO> argAdvance, DataTable dtQual, List<BillTurnKeyEntry> argTurnKeyTrans, List<BillLBRResourceTransBO> argLbrRes, DataTable argWOQualTrans, List<BillMSteelSelection> oSteelSel, List<BillLSWBSTrans> argLSWBS, bool argInternal, List<BillLabourAdvance> argBLbrAdv, List<BillServiceTaxNewBO> argBFST, DataTable dtLbrAdj, string argDBName, List<BillLSVTrans> argBillLSV, List<BillLSTransBO> argBillLSTrans, DataTable argResQualTran, DataTable argResRateQ, List<LabourTransBO> argItemLbr, List<LabourTransBO> argLabourItem, List<LabourTransBO> argLabourSum, List<BillRetentionBO> argRetention, DataTable argMatAdvance, List<BillVATBO> argVAT)
        {
            return oDL.InsertBillEntries(argBReg, argBAbs, argBEntry, argBLbrType, argBMatRec, argBIOWTrans, argBIMsrment, argBIOWMsrment, argBFTDS, argBLbrTrNew, argBillType, argCCId, argContId, argBdetId, argRevId, argWBSTrans, argWBSMsrTrans, argDPE, ref argUpdate, ref argRefNo,  argAdvance, dtQual, argTurnKeyTrans, argLbrRes, argWOQualTrans, oSteelSel, argLSWBS, argInternal, argBLbrAdv, argBFST, dtLbrAdj, argDBName, argBillLSV, argBillLSTrans,argResQualTran,argResRateQ,argItemLbr,argLabourItem,argLabourSum,argRetention,argMatAdvance,argVAT);	
        }
        public DataTable GetLabourSum(int argBillRegId)
        {
            return oDL.GetLabourSum(argBillRegId);
        }
        public DataTable GetLabourItemSum(int argBillTransId)
        {
            return oDL.GetLabourItemSum(argBillTransId);
        }

        public string GetLabourUsedTypeDPE(string argDPERegId)
        {
            return oDL.GetLabourUsedTypeDPE(argDPERegId);
        }

        public bool UpdateBillEntries(BillRegister argBReg, List<BillAbstract> argBAbs, List<BillEntry> argBEntry, List<BillLabourTypeTransBO> argBLbrType, List<BillMaterialRecovery> argBMatRec, List<BillIOWTransUpdate> argBIOWTrans, List<BIMeasurementBO> argBIMsrment, List<BillIOWMeasurementBOUpdate> argBIOWMsrment, List<BillFormateTDSNewBO> argBFTDS, DataTable argBLbrTrNew, string argBillType, int argCCId, int argContId, int argBdetId, int argRevId, List<BillWBSTrans> argWBSTrans, List<BillWBSMeasurementTransBO> argWBSMsrTrans, List<DPERegTrans> argDPE, List<BillAdvanceBO> argAdvance, DataTable dtQual, List<BillTurnKeyEntry> argTurnKeyTrans, List<BillLBRResourceTransBO> argLbrRes, DataTable argWOQualTrans, List<BillMSteelSelection> oSteelSel, List<BillLSWBSTrans> argLSWBS, bool argInternal, List<BillLabourAdvance> argBLbrAdv, List<BillServiceTaxNewBO> argBFST, DataTable dtLbrAdj, string argDBName, List<BillLSVTrans> argBillLSV, List<BillLSTransBO> argBillLSTrans, DataTable argResQualTran, DataTable argResRateQ, List<LabourTransBO> argItemLbr, List<LabourTransBO> argLabourItem, List<LabourTransBO> argLabourSum, List<BillRetentionBO> argRetention, DataTable argMatAdvance, List<BillVATBO> argVAT)
        {
            return oDL.UpdateBillEntries(argBReg, argBAbs, argBEntry, argBLbrType, argBMatRec, argBIOWTrans, argBIMsrment, argBIOWMsrment, argBFTDS, argBLbrTrNew, argBillType, argCCId, argContId, argBdetId, argRevId, argWBSTrans, argWBSMsrTrans, argDPE,  argAdvance, dtQual, argTurnKeyTrans, argLbrRes, argWOQualTrans, oSteelSel, argLSWBS, argInternal, argBLbrAdv, argBFST, dtLbrAdj, argDBName, argBillLSV,argBillLSTrans,argResQualTran,argResRateQ,argItemLbr,argLabourItem,argLabourSum,argRetention,argMatAdvance,argVAT);
        }


        public DataSet getBillRegDetailsE(int argBRegId)
        {
            return oDL.getBillRegDetailsE(argBRegId);
        }
        public DataTable getIOWResource(int argIOWId, int argRevID, decimal argQty, string argmode, int argBillTransId, string argDBName, int argWORegId, int argTypeId)
        {
            return oDL.getIOWResource(argIOWId, argRevID, argQty, argmode, argBillTransId, argDBName,argWORegId,argTypeId);
        }
        public DataTable PopulateWBSResQual(int argBillTransId, int argResId, int argIOWId, int argVendorId, string argQType, DateTime argDate)
        {
            return oDL.PopulateWBSResQual(argBillTransId, argResId, argIOWId, argVendorId, argQType, argDate);
        }

        public DataTable PopulateTDSQualifier()
        {
            return oDL.PopulateTDSQualifier();
        }

        public DataTable PopulateIOW(int argBillRegId, string argBillType, int argTypeId, int argRevId, string argDBName)
        {
            return oDL.PopulateIOW(argBillRegId, argBillType, argTypeId, argRevId,argDBName);
        }

        public DataTable PopulateService(int argBillRegId, string argBillType, int argTypeId)
        {
            return oDL.PopulateService(argBillRegId, argBillType, argTypeId);
        }

        public DataTable PopulateLabourE(int argBillRegId, string argBillType, int argTypeId)
        {
            return oDL.PopulateLabourE(argBillRegId, argBillType, argTypeId);
        }

        public DataTable getBillLbrResTranQtyEdit(int argResID, int argTransId, string argAHType)
        {
            return oDL.getBillLbrResTranQtyEdit(argResID, argTransId, argAHType);
        }

        public DataTable InsertIOWE(int argCompId, string argMode, int argBillTrnsId, string argSplit, string argDBName)
        {
            return oDL.InsertIOWE(argCompId, argMode, argBillTrnsId, argSplit,argDBName);
        }

        public DataTable getIOWDetailsE(int argIOWId, int argAnlysId, int argBillTransId, int argLbrResTransId)
        {
            return oDL.getIOWDetailsE(argIOWId, argAnlysId, argBillTransId,argLbrResTransId);
        }

        public DataTable PopulateMeasrCollE(string argBilType, int argBillTransId, int argBillIOWTransId)
        {
            return oDL.PopulateMeasrCollE(argBilType, argBillTransId, argBillIOWTransId);
        }

        public DataTable PopulateIOWLabourCollE(int argBillIOWTransID, int argAnalId,int argBillTransId)
        {
            return oDL.PopulateIOWLabourCollE(argBillIOWTransID, argAnalId, argBillTransId);
        }

        public DataTable UpdateItemLbrTransE(int argBillTransId)
        {
            return oDL.UpdateItemLbrTransE(argBillTransId);
        }

        public DataTable PopulateIOWE(int argBillRegId, ArrayList argBillType, int argTypeId,string argDBName)
        {
            return oDL.PopulateIOWE(argBillRegId, argBillType, argTypeId, argDBName);
        }
        //PopulateTDSCollection//

        public DataTable PopulateTDSCollection(int argBillRegId,int argTypeId,string argType)
        {
            return oDL.PopulateTDSCollection(argBillRegId, argTypeId, argType);
        }

        public DataTable PopulateMaterialCol(int argBillRegId, int argTypeId)
        {
            return oDL.PopulateMaterialCol(argBillRegId, argTypeId);
        }

        public DataTable PopulateLabourAdvanceTypeCol(int argBillRegId, int argTypeId, string sFormatType, bool argIntrnal)
        {
            return oDL.PopulateLabourAdvanceTypeCol(argBillRegId, argTypeId, sFormatType,argIntrnal);
        }

        public DataTable PopulateLabourTypeCol(int argBillRegId, int argTypeId,bool argInternal,string argFormatType)
        {
            return oDL.PopulateLabourTypeCol(argBillRegId, argTypeId,argInternal,argFormatType);
        }
        public DataTable GetBillLSTypeTrans(int argTransId,int argLTypeId, int argAnalId, string argLSId)
        {
            return oDL.GetBillLSTypeTrans(argTransId, argLTypeId, argAnalId, argLSId);
        }

        public DataTable GetAdvanceLbrAmt(int argCCId, int argLbrId, int argContId)
        { 
            return oDL.GetAdvanceLbrAmt(argCCId,argLbrId,argContId);
        }

        public DataTable PopulateTurnKeyTypeCol(int argBillRegId, int argTypeId, string argBillType, string argDBName)
        {
            return oDL.PopulateTurnKeyTypeCol(argBillRegId, argTypeId,argBillType,argDBName);
        }
        public DataTable GetRateQ(int argBillRegId)
        {
            return oDL.GetRateQ(argBillRegId);
        }

        public DataTable PopulateLabourBillTrans(int argBillRegId)
        {
            return oDL.PopulateLabourBillTrans(argBillRegId);
        }

        public DataTable PopulateBillLabourTrans(int argBillRegId)
        {
            return oDL.PopulateBillLabourTrans(argBillRegId);
        }

        public int GetBillTranId(int argCompId, int argIOWId)
        {
            return oDL.GetBillTranId(argCompId, argIOWId);
        }

        public ArrayList GetBillType(int argBillRegId, int argTypeId)
        {
            return oDL.GetBillType(argBillRegId, argTypeId);
        }


        public DataTable GetPreviousPartRate(int argCCId, int argContId, string argBType, string argDBName,int argWORegId)
        {
            return oDL.GetPreviousPartRate(argCCId, argContId, argBType,argDBName,argWORegId);
        }

        public decimal GetPreviousPartRateWBS(int argCCId, int argContId, decimal argRate, int argIOWId, int argAnalysisId, int argTypeId, int argWORegId)
        {
            return oDL.GetPreviousPartRateWBS(argCCId, argContId, argRate, argIOWId, argAnalysisId,argTypeId,argWORegId);
        }
        public decimal GetPreviousPartRateActivityIOW(int argCCId, int argContId, decimal argRate, int argResId, string argResType, int argIOWId, int argAnalysisId)
        {
            return oDL.GetPreviousPartRateActivityIOW(argCCId, argContId, argRate, argResId,argResType, argIOWId, argAnalysisId);
        }

        public decimal GetPreviousPartRateLabourIOW(int argCCId, int argContId, decimal argRate, int argResId, int argLbrResId, string argResType, int argIOWId, int argAnalysisId)
        {
            return oDL.GetPreviousPartRateLabourIOW(argCCId, argContId, argRate, argResId, argLbrResId, argResType, argIOWId, argAnalysisId);
        }
        public decimal GetPreviousPartRateLabourRes(int argCCId, int argContId, decimal argRate, int argResId, int argLbrResId, string argResType)
        {
            return oDL.GetPreviousPartRateLabourRes(argCCId, argContId, argRate, argResId, argLbrResId, argResType);
        }
        public void UpdateBillFormat(BillFormatMaster arfTDSM,string argType)
        {
            oDL.UpdateBillFormat(arfTDSM, argType);
        }


        public void InsertBillReportDetails(DataTable argDt)
        {
            oDL.InsertBillReportDetails(argDt);
        }

        public DataTable GetQualifierType()
        {
            return oDL.GetQualifierType();
        }
        public DataTable GetQualifierWork(int argQTypeId)
        {
            return oDL.GetQualifierWork(argQTypeId);
        }

        public DataTable GetLabourIOWItem(int argBillTransId, int argAHeadId, int argIOWId)
        {
            return oDL.GetLabourIOWItem(argBillTransId, argAHeadId, argIOWId);
        }
        public DataTable GetLabourWBSItem(int argBillTransId, int argAHeadId)
        {
            return oDL.GetLabourWBSItem(argBillTransId, argAHeadId);
        }
        public DataTable GetLabourItem(int argBillTransId)
        {
            return oDL.GetLabourItem(argBillTransId);
        }

        internal static DataTable Get_RateHistory(int argCCId, DateTime argFrmDate, DateTime argToDate, int argRevId, string argBType, string argDBName)
        {
            return BillDL.Get_RateHistory(argCCId, argFrmDate, argToDate, argRevId, argBType, argDBName);
        }
        public DataTable GetRetentionRelease(int argBillRegId, int argCCId, int argContId, int argWOREgId)
        {
            return oDL.GetRetentionRelease(argBillRegId,argCCId,argContId,argWOREgId);
        }
        public void GetRetentionMobAdvance(ref decimal argRetention, ref decimal argMobAdvance, int argWORegId)
        {
            oDL.GetRetentionMobAdvance(ref argRetention, ref argMobAdvance, argWORegId);
        }
        public DataTable Advance(int argCCId, DateTime argDate)
        {
            return oDL.Advance(argCCId, argDate);
        }
        public DataTable Get_CMR(int argCCId, DateTime argDate, string argDBName, int argRevId)
        {
            return oDL.Get_CMR(argCCId, argDate, argDBName, argRevId);
        }
        public DataTable GetVATTrans(int argBillRegId, int argTypeId)
        {
            return oDL.GetVATTrans(argBillRegId, argTypeId);
        }

        #endregion


    }
}
