using Microsoft.VisualStudio.TestTools.UnitTesting;
using Composite_Pattern;

//https://www.dofactory.com/net/composite-design-pattern

namespace Composite_Test
{
    [TestClass]
    public class TestComposite
    {
        [TestMethod]
        public void TestMethod1()
        {
            //For Jan
            Calendar janMonth = new Calendar("Jan2020_Controls");
                janMonth.Add(new DateBox("1-Jan"));
                janMonth.Add(new DateBox("2-Jan"));
                janMonth.Add(new DateBox("31-Jan"));

                janMonth.Add(new Scroller("Vertical Scroll Bar"));
                janMonth.Add(new Scroller("Horizontal Scroll Bar"));

            //For Feb
            Calendar febMonth = new Calendar("Feb2020_Controls");
                febMonth.Add(new DateBox("1-Feb"));
                febMonth.Add(new DateBox("2-Feb"));
                febMonth.Add(new DateBox("28-Feb"));

                febMonth.Add(new Scroller("Vertical Scroll Bar"));
                febMonth.Add(new Scroller("Horizontal Scroll Bar"));


            Calendar calendar2020 = new Calendar("Calendar-2020");
            calendar2020.Add(janMonth);
            calendar2020.Add(febMonth);


            var displayTree = calendar2020.Display(1);

        }
    }
}
