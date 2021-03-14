using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public interface SelectModifier
    {
        bool Complite { get; }

        event EventHandler StateChanged;
    }
}
