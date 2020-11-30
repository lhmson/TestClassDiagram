using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagramEx
{
    public class Food : GameObj, IEat
    {
        public int Point { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Effect()
        {
            throw new NotImplementedException();
        }
    }
}