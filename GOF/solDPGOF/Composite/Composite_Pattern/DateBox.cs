using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public class DateBox : Component

    {
        // Constructor
        public DateBox(string name)
          : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override List<string> Display(int depth)
        {
            return new List<string>()
            {
                (new String('-', depth) + name)
            };
        }
    }
}
