using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
