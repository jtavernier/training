using System;

namespace _02_NumberIsland
{

  


    class Program
    {
          public static char[,] input1 =  new char[,] {
                {'1','1','1','1','0'},
                {'1','1','0','1','0'},
                {'1','1','0','0','0'},
                {'0','0','0','0','0'}
            };

            public static char[,] input2 =  new char[,] {
                {'1','1','0','0','0'},
                {'1','1','0','0','0'},
                {'0','0','1','0','0'},
                {'0','0','0','1','1'}
            };
        
        static void Main(string[] args)
        {

            var r = new Solution().NumIslands(input1);
            var r2 = new Solution().NumIslands(input2);
        }
    }
}
