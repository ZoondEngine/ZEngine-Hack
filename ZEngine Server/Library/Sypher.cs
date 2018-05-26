﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Server.Library
{
    class Sypher
    {
        public class RC4
        {
            byte[] S = new byte[256];

            int x = 0;
            int y = 0;

            public RC4(byte[] key)
            {
                Init(key);
            }

            // Key-Scheduling Algorithm 
            // Алгоритм ключевого расписания 
            private void Init(byte[] key)
            {
                int keyLength = key.Length;

                for (int i = 0; i < 256; i++)
                {
                    S[i] = (byte)i;
                }

                int j = 0;
                for (int i = 0; i < 256; i++)
                {
                    j = (j + S[i] + key[i % keyLength]) % 256;
                    S.Swap(i, j);
                }
            }

            public byte[] Encode(byte[] dataB, int size)
            {
                byte[] data = dataB.Take(size).ToArray();

                byte[] cipher = new byte[data.Length];

                for (int m = 0; m < data.Length; m++)
                {
                    cipher[m] = (byte)(data[m] ^ keyItem());
                }

                return cipher;
            }

            public byte[] Decode(byte[] dataB, int size)
            {
                return Encode(dataB, size);
            }

            // Pseudo-Random Generation Algorithm 
            // Генератор псевдослучайной последовательности 
            private byte keyItem()
            {
                x = (x + 1) % 256;
                y = (y + S[x]) % 256;

                S.Swap(x, y);

                return S[(S[x] + S[y]) % 256];
            }
        }
    }
}
