﻿using System;
using System.Windows.Forms;

namespace El_Raton_Quesero
{
    internal class Thickness
    {
        private int v1;
        private int v2;
        private int v3;
        private int v4;

        public Thickness(int v1, int v2, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public static implicit operator Padding(Thickness v)
        {
            throw new NotImplementedException();
        }
    }
}