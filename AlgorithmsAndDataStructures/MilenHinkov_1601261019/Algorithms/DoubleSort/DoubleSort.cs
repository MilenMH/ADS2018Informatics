using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms.DoubleSort
{
    /// <summary>
    /// Since this task does not requre actual solution I will try to explain my answer here.
    /// 
    /// Task :
    /// Given an unsorted matrix. 
    /// The matrix has been sorted row-wise and then column-wise.
    /// The question :
    /// Will the rows be sorted after the column-wise sort.
    /// 
    /// Answer:
    /// Yes they will be.
    /// To understand why rows are still sorted after the column-wise sort 
    /// we will need to understand what is "invariant" (in math).
    /// 
    /// According to wikipedia : In mathematics, an invariant is a property, 
    /// held by a class of mathematical objects, which remains unchanged when 
    /// transformations of a certain type are applied to the objects.
    /// 
    /// Let m be the number of columns. For each k from 1 to m, 
    /// sort the rows of the subarray from column k to column m in increasing order of the element in column k. 
    /// (Each row of the subarray stays together.) 
    /// We maintain the invariant that the elements in each row stays sorted. 
    /// This invariant is trivially true when k = 1. When k > 1, 
    /// and we perform a swap involving rows p and (p+1), 
    /// consider the elements in those rows and in the columns (k−1) and k:
    /// 
    ///  - - - a  d - - - 1
    ///  - - - b  c - - - 2
    ///  
    ///  By the invariance we have a ≤ b ≤ c and the swap is only done because c≤d. 
    ///  After the swap we have:
    ///  
    ///  - - - a  c - - - 1
    ///  - - - b  d - - - 2
    ///  
    /// And the invariance is preserved since a ≤ c and b≤d. 
    /// 
    /// </summary>
    public class DoubleSort
    {
    }
}
