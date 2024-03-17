// <copyright file="ILeetCodeProblem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Collections;

namespace LeetCode;

// ReSharper disable once UnusedType.Global
// ReSharper disable once InconsistentNaming
#pragma warning disable SA1600
public interface ILeetCodeProblem
{
    public string ProblemLink { get; set; }

    public static void PintArray(IList arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element);
            Console.Write(" ");
        }
    }
}