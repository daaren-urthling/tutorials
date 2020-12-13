using System;
using System.Collections.Generic;

#nullable disable

namespace Angular_NETCore_EFCore.Models
{
    public partial class MaBillOfMaterials
    {
        public MaBillOfMaterials()
        {
            MaBillOfMaterialsComps = new HashSet<MaBillOfMaterialsComp>();
            MaBillOfMaterialsRoutings = new HashSet<MaBillOfMaterialsRouting>();
        }

        public string Bom { get; set; }
        public int? CodeType { get; set; }
        public string Description { get; set; }
        public string UoM { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public string UsePercQty { get; set; }
        public string Sf { get; set; }
        public string Notes { get; set; }
        public string InProduction { get; set; }
        public int? LastSubId { get; set; }
        public string Configurable { get; set; }
        public string Disabled { get; set; }
        public string SalesDocOnly { get; set; }
        public DateTime Tbcreated { get; set; }
        public DateTime Tbmodified { get; set; }
        public int TbcreatedId { get; set; }
        public int TbmodifiedId { get; set; }
        public Guid Tbguid { get; set; }

        public virtual ICollection<MaBillOfMaterialsComp> MaBillOfMaterialsComps { get; set; }
        public virtual ICollection<MaBillOfMaterialsRouting> MaBillOfMaterialsRoutings { get; set; }
    }
}
