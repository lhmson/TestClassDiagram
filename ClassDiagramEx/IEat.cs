using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagramEx
{
    public interface IEat
    {
        int Point { get; set; }

        void Effect();
    }
}