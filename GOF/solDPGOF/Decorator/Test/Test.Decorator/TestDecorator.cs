using Decorator_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Decorator
{
    [TestClass]
    public class TestDecorator
    {
        [TestMethod]
        public void TestMethod1()
        {
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            var res0 = book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            var res1 = video.Display();

            //Make video borrowable, then borrow and display

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            var res2 = borrowvideo.Display();
        }
    }
}
