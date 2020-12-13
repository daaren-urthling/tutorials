using System;
using System.Collections.Generic;

#nullable disable

namespace Angular_NETCore_EFCore.Models
{
    public partial class MaOperation
    {
        public string Operation { get; set; }
        public string Description { get; set; }
        public string Wc { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public string OperationDescriptionFile { get; set; }
        public string Notes { get; set; }
        public string Item { get; set; }
        public string ProcessingTeam { get; set; }
        public int? ProcessingTime { get; set; }
        public double? ProcessingAttendancePerc { get; set; }
        public int? ProcessingWorkingTime { get; set; }
        public short? NoOfProcessingWorkers { get; set; }
        public string SetupTeam { get; set; }
        public int? SetupTime { get; set; }
        public double? SetupAttendancePerc { get; set; }
        public int? SetupWorkingTime { get; set; }
        public short? NoOfSetupWorkers { get; set; }
        public int? QueueTime { get; set; }
        public double? HourlyCost { get; set; }
        public double? UnitCost { get; set; }
        public double? AdditionalCost { get; set; }
        public string CostsOnQty { get; set; }
        public string TotalTime { get; set; }
        public string IsWc { get; set; }
        public DateTime Tbcreated { get; set; }
        public DateTime Tbmodified { get; set; }
        public int TbcreatedId { get; set; }
        public int TbmodifiedId { get; set; }
        public Guid Tbguid { get; set; }
    }
}
