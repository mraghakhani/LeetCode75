namespace LeetCode75.Queue;

public class Data2Senate
{
    private const char Radiant = 'R';
    private const string DireName = "Dire";
    private const string RadiantName = "Radiant";

    public static string PredictPartyVictory(string senate)
    {
        var radiants = new Queue<int>();
        var dires = new Queue<int>();
        var count = senate.Length;
        for (var i = 0; i < senate.Length; ++i)
        {
            if (senate[i] == Radiant)
                radiants.Enqueue(i);
            else
                dires.Enqueue(i);
        }

        while (radiants.Count > 0 && dires.Count > 0)
        {
            var currentRadiant = radiants.Dequeue();
            var currentDire = dires.Dequeue();
            if (currentRadiant < currentDire)
                radiants.Enqueue(currentRadiant + count);
            else
                dires.Enqueue(currentDire + count);
        }

        return radiants.Count > 0 ? RadiantName : DireName;
    }
}