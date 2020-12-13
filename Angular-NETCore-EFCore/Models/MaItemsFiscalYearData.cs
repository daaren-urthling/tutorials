using System;
using System.Collections.Generic;

#nullable disable

namespace Angular_NETCore_EFCore.Models
{
    public partial class MaItemsFiscalYearData
    {
        public short FiscalYear { get; set; }
        public string Item { get; set; }
        public int? InventoryValuationCriteria { get; set; }
        public string NoAbcvaluation { get; set; }
        public double? StandardCost { get; set; }
        public int? ValuationType { get; set; }
        public string EvaluateByLot { get; set; }
        public int? LastLotNo { get; set; }
        public DateTime Tbcreated { get; set; }
        public DateTime Tbmodified { get; set; }
        public int TbcreatedId { get; set; }
        public int TbmodifiedId { get; set; }
    }
}
