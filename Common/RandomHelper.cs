﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class RandomHelper
    {
        /// <summary>
        /// 获取随机数
        /// </summary>
        /// <param name="min">能出现的最小值</param>
        /// <param name="max">不会出线</param>
        /// <returns></returns>
        public static int GetRandomNumber(int max, int min = 0)
        {
            Guid guid = Guid.NewGuid();
            string sGuid = guid.ToString();
            int seed = DateTime.Now.Millisecond;
            for (int i = 0; i < sGuid.Length; i++)
            {
                switch (sGuid[i])
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                        seed = seed + 1;
                        break;
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                        seed = seed + 2;
                        break;
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                        seed = seed + 3;
                        break;
                    case 'u':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        seed = seed + 3;
                        break;
                    default:
                        seed = seed + 4;
                        break;
                }
            }
            Random random = new Random(seed);
            return random.Next(min, max);
        }
    }
}
