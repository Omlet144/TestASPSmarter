using Microsoft.AspNetCore.Mvc;
using TestASPSmarter.Models;

namespace TestASPSmarter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GadgetsController : ControllerBase
    {

        [HttpGet]
        [Route("[controller]/GetGadgets")]
        public IEnumerable<Gadget> GetGadgets() => new TestASPSmarter.DBControllers.GadgetController().GetData();


    }
}