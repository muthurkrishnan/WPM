using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using WPM.DataLayer;
using WPM.BusinessObjects;


namespace WPM.BusinessLayer
{
    class MeasurementBL
    {
        #region Object
        MeasurementDL oMeasurementDL;
        #endregion      

        #region Constructor
        public MeasurementBL()
        {
            oMeasurementDL = new MeasurementDL();
        }
        #endregion

        #region Methods     
        
        public int GetIOW_Trans_Id(int argRevId,int argProjIOWId,string argDBName)
        { 
            return  oMeasurementDL.GetIOW_Trans_Id(argRevId, argProjIOWId,argDBName);
        }
        public void InsertMeasurement(List<MeasurementMasterBO> argMeasurementMasterBO,int argDPETransId,int argDPEIOWTransId)
        {
            oMeasurementDL.InsertMeasurement(argMeasurementMasterBO,argDPETransId,argDPEIOWTransId);            
        }
        public DataTable GetSteel() { return oMeasurementDL.GetSteel(); }

        public DataTable getUnit(string g_MType)
        {
            return oMeasurementDL.getUnit(g_MType);
        }
        public DataTable GetDPEMeasureDetails(int argDPETransId, int argDPEIOWTransId, string frmWhere)
        {
            return oMeasurementDL.GetDPEMeasureDetails(argDPETransId, argDPEIOWTransId, frmWhere);
        }
        public void UpdateBillMeasurement(List<BillMeasurementBO> argBillMeasurementBO, int argBillTransId, int argBillIOWTransId)
        {
            oMeasurementDL.UpdateBillMeasurement(argBillMeasurementBO, argBillTransId, argBillIOWTransId);
        }
        #endregion
    }
}
