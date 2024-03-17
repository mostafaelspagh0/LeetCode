// See https://aka.ms/new-console-template for more information

using LeetCode.Problems;

var problem = new Minimum_Operations_to_Form_Subsequence_With_Target_Sum();

// Console.WriteLine(problem.MinOperations(new []{1, 2, 8}, 7));


// Console.WriteLine(problem.MinOperations(new []{1, 32, 1}, 35));

Console.WriteLine(problem.MinOperations(new []{128,1024,1073741824,4194304,268435456,1024,16,1073741824,131072,4,16777216,67108864,16777216,268435456,1073741824,256,16,67108864,1048576,16,4,4194304,1024,16,262144,1048576,1024,128,1073741824,67108864,65536,128,32768,128,32768,8192,256,1024}, 38));