//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPC_SUPPORT_WIP.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class WORK_ORDER_ITEMS
    {
        public string BASE_NO { get; set; }
        public int BOARD_COUNT { get; set; }
        public string BOARD_NO { get; set; }
        public int BOARD_STATE { get; set; }
        public string CASE_NO { get; set; }
        public string CLIENT_NAME { get; set; }
        public int DEFECT_COUNT { get; set; }
        public int DISCARD_COUNT { get; set; }
        public System.DateTime FINISH_TIME { get; set; }
        public System.Guid ID { get; set; }
        public System.DateTime INITIATE_TIME { get; set; }
        public bool IS_CASED { get; set; }
        public bool IS_DERIVATIVE { get; set; }
        public bool IS_FINISHED { get; set; }
        public bool IS_MATERIAL_LOG_IMPORTED { get; set; }
        public bool IS_PACKED { get; set; }
        public string LINE_ID { get; set; }
        public System.Guid ORDER_ID { get; set; }
        public string ORDER_NO { get; set; }
        public string PACK_NO { get; set; }
        public string PLANT { get; set; }
        public int PROCEDURE_INDEX { get; set; }
        public int RETEST_COUNT { get; set; }
        public int SECTION { get; set; }
        public string STATION_NAME { get; set; }
        public string STATION_NO { get; set; }
        public int STATION_TYPE { get; set; }
    }
}
