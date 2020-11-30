﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagramEx
{
    public class GameObj
    {
        public int posX;

        public int posY;

        public int vX;

        public int vY;

        DIRECTION dir;

        public event EventHandler KeyDown;

        virtual public void Update()
        {

        }

        virtual public void Render()
        {

        }

    }
}