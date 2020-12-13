using System;
using System.Collections.Generic;

#nullable disable

namespace Angular_NETCore_EFCore.Models
{
    public partial class MaBillOfMaterialsRouting
    {
        public short RtgStep { get; set; }
        public string Alternate { get; set; }
        public short AltRtgStep { get; set; }
        public string Bom { get; set; }
        public string Operation { get; set; }
        public double? ProcessingAttendancePerc { get; set; }
        public double? SetupAttendancePerc { get; set; }
        public string Notes { get; set; }
        public string Wc { get; set; }
        public int? ProcessingTime { get; set; }
        public int? ProcessingWorkingTime { get; set; }
        public int? SetupTime { get; set; }
        public int? SetupWorkingTime { get; set; }
        public int? LineTypeInDn { get; set; }
        public short? NoOfProcessingWorkers { get; set; }
        public short? NoOfSetupWorkers { get; set; }
        public int? QueueTime { get; set; }
        public int? SubId { get; set; }
        public string Supplier { get; set; }
        public double? Qty { get; set; }
        public string TotalTime { get; set; }
        public string IsWc { get; set; }
        public DateTime Tbcreated { get; set; }
        public DateTime Tbmodified { get; set; }
        public int TbcreatedId { get; set; }
        public int TbmodifiedId { get; set; }

        public virtual MaBillOfMaterials BomNavigation { get; set; }
    }
}
