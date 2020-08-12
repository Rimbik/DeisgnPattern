using Microsoft.VisualStudio.TestTools.UnitTesting;
using State_Pattern;

namespace Test.State
{
    [TestClass]
    public class TestAccountState
    {
        [TestMethod]
        public void TestAccountType()
        {
            Account account = new Account("James");
            
            var status = account.Deposit(500.0);
            status = account.Deposit(300.0);
            status = account.Deposit(550.0);

            status = account.PayInterest();

            status = account.Withdraw(2000.00);
            status = account.Withdraw(1100.00);

        }
    }
}
