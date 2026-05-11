using System.Collections.Generic;
using System;

namespace SubstringSearch
{
  class Program
  {
    static void Main(string[] args)
    {
      NaiveSubstringSearch ns = new NaiveSubstringSearch();
      Console.WriteLine(ns.Solve("hello world", "world")); //  6
      Console.WriteLine(ns.Solve("hello world", "xyz"));   // -1
      Console.WriteLine(ns.Solve("abcabc",      "abc"));   //  0
      
      int index = SundaySearch.Search("world", "hello world");
      Console.WriteLine(index); // 6
      
      int bm = BoyerMooreAlgorithm.Search("world", "hello world");
      Console.WriteLine(bm); // 6

      int notFound = BoyerMooreAlgorithm.Search("xyz", "hello world");
      Console.WriteLine(notFound); // -1
    }
  }
}