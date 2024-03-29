// <copyright file="ILeetCodeProblem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Collections;

namespace ICPC2024.LeetCode;

// ReSharper disable once UnusedType.Global
// ReSharper disable once InconsistentNaming
#pragma warning disable SA1600
public interface ILeetCodeProblem
{
    public string ProblemLink { get; }

    public static void PintArray(IList arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element);
            Console.Write(" ");
        }
    }
}