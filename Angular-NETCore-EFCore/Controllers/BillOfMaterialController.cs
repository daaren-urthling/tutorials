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
    }
}
