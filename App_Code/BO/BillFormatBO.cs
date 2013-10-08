using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPM.BusinessObjects
{
    class BillFormatBO
    {


    }

    public class BillFormatMasterBO
    {
        public int TypeId { set; get; }
        public string TypeName { set; get; }
        public int FormatTypeId { set; get; }
        public int AddType { set; get; }
        public string HeadingName { set; get; }
        public int Header { set; get; }
        public int QTypeId { set; get; }
        public int QualifierId { set; get; }
        public int AccountTypeId { set; get; }
        public int AccountHeadId { set; get; }
        public int SubLedgerTypeId { set; get; }
    }



}
