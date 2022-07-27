﻿using System;

namespace ClientServer
{
    public static class DataPartOperation
    {
        public static byte[][] BufferSplit(byte[] buffer, int blockSize)
        {
            byte[][] blocks = new byte[(buffer.Length + blockSize - 1) / blockSize][];
            for (int i = 0, j = 0; i < blocks.Length; i++, j += blockSize)
            {
                blocks[i] = new byte[Math.Min(blockSize, buffer.Length - j)];
                Array.Copy(buffer, j, blocks[i], 0, blocks[i].Length);
            }
            return blocks;
        }

        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
