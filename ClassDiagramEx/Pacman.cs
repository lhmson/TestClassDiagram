using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagramEx
{
    public class Pacman : GameObj
    {
        public int isDead;

        public DIRECTION dir;

        public event EventHandler KeyDown;

        override public void Update()
        {
            
        }

        override public void Render()
        {

        }
    }
}