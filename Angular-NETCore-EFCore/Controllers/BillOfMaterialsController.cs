using System.Collections.Generic;
using Angular_NETCore_EFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Angular_NETCore_EFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillOfMaterialsController : ControllerBase
    {
        private readonly ILogger<BillOfMaterialsController> _logger;
        private readonly DatiMagoContext _context;

        public BillOfMaterialsController(DatiMagoContext context, ILogger<BillOfMaterialsController> logger)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<MaBillOfMaterials>> Get()
        {
            return _context.MaBillOfMaterials.ToList();
        }

        [HttpGet("boms")]
        public ActionResult<object> GetBoms()
        {
            return _context.MaBillOfMaterials.Select(s => new { s.Bom, s.Description }).ToList();
        }

        [HttpGet("bom")]
        public ActionResult<object> GetBom(string bom)
        {
            var bomData = _context.MaBillOfMaterials
                .Select(s => new { 
                    s.Bom, s.Description 
                })
                .Where(s => s.Bom == bom)
                .ToList();
            if (bomData == null)
            {
                return NotFound();
            }
            return bomData;
        }

        [HttpGet("bomComps")]
        public ActionResult<object> GetComponents(string bom)
        {
            var comps = _context.MaBillOfMaterialsComps
                .Select(s => new { 
                    s.Bom, s.Component, s.Qty 
                })
                .Where(s => s.Bom == bom)
                .ToList();

            if (comps == null)
            {
                return NotFound();
            }
            return comps;
        }

        [HttpGet("bomRouting")]
        public ActionResult<object> GetRouting(string bom)
        {
            var routing = _context.MaBillOfMaterialsRoutings
                .Select(s => new { 
                    s.Bom, s.RtgStep, s.SetupTime, s.ProcessingTime 
                })
                .Where(s => s.Bom == bom)
                .ToList();

            if (routing == null)
            {
                return NotFound();
            }
            return routing;
        }
    }
}
