namespace Awesome_Automated_Test.Fundamentals
{
    public class CustomerController
    {
        public Mocking.Models.ActionResult GetCustomer(int id)
        {
            if (id == 0)
                return new NotFound();
            
            return new Ok();
        }        
    }
    
    public partial class ActionResult { }
    
    public class NotFound : Mocking.Models.ActionResult { }
 
    public class Ok : Mocking.Models.ActionResult { }
}