﻿using System;

namespace CSharpExtensions
{
    public static class ArrayUtils
    {
        public static void Copy<T>(ref T[] array, int length, Func<int, T> selector)
        {
            for (var i = 0; i < length; i++)
            {
                array[i] = selector(i);
            }
        }
        
        public static void Copy<T>(T[] array, int length, Func<int, T> selector)
        {
            for (var i = 0; i < length; i++)
            {
                array[i] = selector(i);
            }
        }
    }
}