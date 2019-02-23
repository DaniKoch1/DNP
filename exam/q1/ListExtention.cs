using System;
using System.Collections.Generic;

namespace q1
{
    public static class ListExtetion
    {
        public static T RandomElement<T>(this List<T> list)
        {
            Random random=new Random();
            return list[random.Next(0,list.Count)];
        }
    }
}