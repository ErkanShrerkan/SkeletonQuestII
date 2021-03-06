﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton_Quest_II
{
    class Character
    {
        protected bool collision;
        protected int layer;
        protected string sprite;
        protected string name;
        protected int hp;
        protected bool up;
        protected bool down;
        protected bool left;
        protected bool right;
        protected bool[] directions;
        protected int[] position = new int[2];

        public int[] Pos  // property
        {
            get { return position; }   // get method
            set { position = value; }   // set method
        }

        public string Name
        {
            get { return name; }   // get method
            set { name = value; }   // set method
        }
    }
}
