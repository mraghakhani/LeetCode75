// See https://aka.ms/new-console-template for more information

using LeetCode75.ArraysAndStrings;
using LeetCode75.SlidingWindow;
using LeetCode75.TwoPointers;

#region ArraysAndStrings

#region Merge Strings Alternately

/*Console.WriteLine(MergeStringsAlternately.MergeAlternately("abc", "pqr"));
Console.WriteLine(MergeStringsAlternately.MergeAlternately("ab", "pqrs"));
Console.WriteLine(MergeStringsAlternately.MergeAlternately("abcd", "pq"));*/

#endregion

#region Greatest Common Divisor of Strings

/*
Console.WriteLine(GreatestCommonDivisorOfStrings.GcdOfStringsSecondTry("ABCABC", "ABC")); // out: "ABC"
Console.WriteLine(GreatestCommonDivisorOfStrings.GcdOfStringsSecondTry("ABABAB", "ABAB")); // out: "AB"
Console.WriteLine(GreatestCommonDivisorOfStrings.GcdOfStringsSecondTry("LEET", "CODE")); // out: ""
Console.WriteLine(GreatestCommonDivisorOfStrings.GcdOfStringsSecondTry("AAAAAB", "AAA")); //out: ""
*/

#endregion

#region Kids With the Greatest Number of Candies

/*
Console.WriteLine(string.Join(',',KidsWithTheGreatestNumberOfCandies.KidsWithCandies([2,3,5,1,3], 3))); // out:[true,true,true,false,true]
Console.WriteLine(string.Join(',',KidsWithTheGreatestNumberOfCandies.KidsWithCandies([4, 2, 1, 1, 2], 1))); // out: [true,false,false,false,false]
Console.WriteLine(string.Join(',',KidsWithTheGreatestNumberOfCandies.KidsWithCandies([12,1,12], 10))); // out:  [true,false,true]
*/

#endregion

#region Can Place Flowers

// Console.WriteLine(CanPlaceFlowers.CanPlaceFlowersNonAdjacent([1,0,0,0,1],1)); // out: true
// Console.WriteLine(CanPlaceFlowers.CanPlaceFlowersNonAdjacent([1,0,0,0,1],2)); // out: false

#endregion

#region Reverse Vowels Of A String

// Console.WriteLine(ReverseVowelsOfAString.ReverseVowels("IceCreAm")); // AceCreIm
// Console.WriteLine(ReverseVowelsOfAString.ReverseVowels("leetcode")); // out: leotcede
// Console.WriteLine(ReverseVowelsOfAString.ReverseVowels("Marge, let's \"went.\" I await news telegram.")); // out: Marge, let's \"went.\" i awaIt news telegram.

#endregion

#region Reverse Words in a String

// Console.WriteLine(ReverseWordsInAString.ReverseWords("the sky is blue")); // blue is sky the
// Console.WriteLine(ReverseWordsInAString.ReverseWords("  hello world  ")); // out: world hello
// Console.WriteLine(ReverseWordsInAString.ReverseWords("a good   example")); // out: example good a

#endregion

#region Product of Array Except Self

// Console.WriteLine(string.Join(',',ProductOfArrayExceptSelf.ProductExceptSelf([1, 2, 3, 4]))); // [24,12,8,6]
// Console.WriteLine(string.Join(',',ProductOfArrayExceptSelf.ProductExceptSelf([-1, 1, 0, -3, 3]))); // [0,0,9,0,0]

#endregion

#region Increasing Triplet Subsequence

/*Console.WriteLine(IncreasingSubsequence.IncreasingTriplet([1, 2, 3, 4, 5])); // true
Console.WriteLine(IncreasingSubsequence.IncreasingTriplet([5, 4, 3, 2, 1])); // false
Console.WriteLine(IncreasingSubsequence.IncreasingTriplet([2, 1, 5, 0, 4, 6])); // true
Console.WriteLine(IncreasingSubsequence.IncreasingTriplet([20, 100, 10, 12, 5, 13])); // true
Console.WriteLine(IncreasingSubsequence.IncreasingTriplet([0, 4, 2, 1, 0, -1, -3])); // false
Console.WriteLine(IncreasingSubsequence.IncreasingTriplet([1, 1, -2, 6])); // false*/

#endregion

#region Increasing N Subsequence

/*Console.WriteLine(IncreasingSubsequence.IncreasingN([1, 2, 3, 4, 5],3)); // true
Console.WriteLine(IncreasingSubsequence.IncreasingN([5, 4, 3, 2, 1],3)); // false
Console.WriteLine(IncreasingSubsequence.IncreasingN([2, 1, 5, 0, 4, 6],3)); // true
Console.WriteLine(IncreasingSubsequence.IncreasingN([20, 100, 10, 12, 5, 13],3)); // true
Console.WriteLine(IncreasingSubsequence.IncreasingN([0, 4, 2, 1, 0, -1, -3],3)); // false
Console.WriteLine(IncreasingSubsequence.IncreasingN([1, 1, -2, 6],3)); // false*/

#endregion

#region String Compression

/*
Console.WriteLine(StringCompression.Compress(['a', 'a', 'b', 'b', 'c', 'c', 'c'])); // 6
Console.WriteLine(StringCompression.Compress(['a'])); // 1
Console.WriteLine(StringCompression.Compress(['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'])); // 4
*/

#endregion

#endregion

#region Two Pointers

#region MoveZeroes

// int[] array = [0, 1, 0, 3, 12];
// MoveZeroes.MoveArrayZeroes(array);
// Console.WriteLine(string.Join(",", array)); // [1,3,12,0,0]
// int[] array3 = [1, 0, 1];
// MoveZeroes.MoveArrayZeroes(array3);
// Console.WriteLine(string.Join(",", array3)); // [1,3,12,0,0,0]
// int[] array2 = [0];
// MoveZeroes.MoveArrayZeroes(array2);
// Console.WriteLine(string.Join(",", array2)); // [0]
//

#endregion

#region Is Subsequence

// Console.WriteLine(Subsequence.IsSubsequence("abc", "ahbgdc")); // true
// Console.WriteLine(Subsequence.IsSubsequence("axc", "ahbgdc")); // false

#endregion

#region Container with most water

/*
Console.WriteLine(ContainerWithMostWater.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7])); // 49
Console.WriteLine(ContainerWithMostWater.MaxArea([1, 1])); // 1
Console.WriteLine(ContainerWithMostWater.MaxArea([8,7,2,1])); // 7
*/

#endregion

#region Max Number of K-Sum Pairs

/*Console.WriteLine(MaxNumberOfKSumPairs.MaxOperations([1, 2, 3, 4], 5)); // 2
Console.WriteLine(MaxNumberOfKSumPairs.MaxOperations([3, 1, 3, 4, 3], 6)); // 1*/
// Console.WriteLine(MaxNumberOfKSumPairs.MaxOperations([4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4], 2)); // 2
// Console.WriteLine(MaxNumberOfKSumPairs.MaxOperations([2, 2, 2, 3, 1, 1, 4, 1], 4)); // 2

#endregion


#endregion

#region Sliding Window

#region Maximum Average Subarray I

/*
Console.WriteLine(MaximumAverageSubarrayI.FindMaxAverage([1, 12, -5, -6, 50, 3], 4)); // 12.75000
Console.WriteLine(MaximumAverageSubarrayI.FindMaxAverage([5], 1)); // 5.00000
Console.WriteLine(MaximumAverageSubarrayI.FindMaxAverage([1,0,1,4,2], 4)); // 1.75
*/

#endregion

#region Maximum Number of Vowels in a Substring of Given Length

Console.WriteLine(MaximumNumberOfVowelsInASubstringOfGivenLength.MaxVowels("abciiidef", 3)); // 3
Console.WriteLine(MaximumNumberOfVowelsInASubstringOfGivenLength.MaxVowels("aeiou", 2)); // 2
Console.WriteLine(MaximumNumberOfVowelsInASubstringOfGivenLength.MaxVowels("leetcode", 3)); // 2

#endregion

#endregion