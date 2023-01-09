using TestASPSmarter.Models;

namespace TestASPSmarter.DBControllers
{
   
    public class GadgetController
    {
        public IEnumerable<Gadget> GetData() =>  new db_a91147_mydbContext().Gadgets;
    }
}
