namespace LeetCode75.ArraysAndStrings;

public class CanPlaceFlowers
{
    public static bool CanPlaceFlowersNonAdjacent(int[] flowerbed, int n) {
        var possibleCount = 0;
        var lastPossibleIndex = 0;
        for (int i = 0; i < flowerbed.Length; i++){
            if(flowerbed[i] == 1)
                continue;

            if(flowerbed[i] == 0 && i + 1 < flowerbed.Length && flowerbed[i+1] == 1)
                continue;
            if(flowerbed[i] == 0 && i - 1 >= 0 && flowerbed[i-1] == 1)
                continue;
            if(i != 0 && i - lastPossibleIndex <= 1)
                continue;
            
            lastPossibleIndex = i;
            possibleCount++;

        }
        return possibleCount >= n;
    }
}