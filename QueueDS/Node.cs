﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDS
{
    class Node
    {
        /// <summary>
        /// it Creates the Node 
        /// </summary>
        public int data;
        public Node next;
        public Node(int New_Data)
        {
            data = New_Data;
            next = null;
        }

    }
}
