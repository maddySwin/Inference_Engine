﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceEngine
{
    abstract class Node: NodeOrStringInterface
    {
        public Node GetNode()
        {
            return this;
        }

        public bool Equals(string checkValue)
        {
            return false;
        }
    }
}
