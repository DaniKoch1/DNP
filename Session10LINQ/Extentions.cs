using System;
using System.Linq;
using System.Collections.Generic;

namespace Session10LINQ
{
    public static class Extentions
    {
        public static IEnumerable<T> InterleaveSequenceWith<T>(this IEnumerable<T> first, IEnumerable<T> second){
            var firstStack=first.GetEnumerator();
            var secondStack=second.GetEnumerator();
            while(firstStack.MoveNext()&&secondStack.MoveNext())
            {
                yield return firstStack.Current;
                yield return secondStack.Current;
            }
        }
        public static bool SequencesEqua<T>(this IEnumerable<T> first, IEnumerable<T> second){
            var firstStack=first.GetEnumerator();
            var secondStack=second.GetEnumerator();
            while(firstStack.MoveNext()&&secondStack.MoveNext())
            {
                if(!(firstStack.Current.Equals(secondStack.Current)))
                    return false;
            }
            return true;
        }
    }
}