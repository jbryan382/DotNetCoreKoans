using System;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
  public class PathToEnlightenment : Path
  {
    public PathToEnlightenment()
    {
      Types = new Type[] {
                // START: Adventure Mode
                typeof(AboutAsserts),
                typeof(AboutNull),
                typeof(AboutArrayAssignment),
                typeof(AboutStrings),
                typeof(AboutFloats),
                typeof(AboutControlStatements),
                typeof(AboutArrays),
                typeof(AboutMethods),
                // END: Adventure Mode

                // START: Explorer mode
                typeof(AboutDelegates),
                typeof(AboutLambdas),
                typeof(AboutLinq),
                typeof(AboutInheritance),
                // END: Explorer Mode

                // START: Epic mode
                typeof(AboutGenericContainers),
                typeof(AboutBitwiseAndShiftOperator),
                };
    }
  }
}