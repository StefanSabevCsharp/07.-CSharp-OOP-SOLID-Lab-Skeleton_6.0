﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Stream_Progress
{
    public abstract class Stream
    {
        public Stream(int length, int bytesSent)
        {
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public int Length { get; }

        public int BytesSent { get; }
    }
}
