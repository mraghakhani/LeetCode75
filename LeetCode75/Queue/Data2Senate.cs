namespace LeetCode75.Queue;

public class Data2Senate
{
    private const char Radiant = 'R';
    private const char Dire = 'D';
    private const string DireName = "Dire";
    private const string RadiantName = "Radiant";

    private const char X = 'X';

    // beats 99% (chatgpt)
    public static string PredictPartyVictory(string senate)
    {
        int radiantBans = 0, direBans = 0;
        var senators = senate.ToCharArray();

        while (true)
        {
            int radiantCount = 0, direCount = 0;

            for (var i = 0; i < senators.Length; i++)
            {
                var currentSenator = senators[i];
                if (currentSenator == Radiant)
                {
                    if (radiantBans > 0)
                    {
                        senators[i] = X;
                        radiantBans--;
                    }
                    else
                    {
                        direBans++;
                        radiantCount++;
                    }
                }
                else if (currentSenator == Dire)
                {
                    if (direBans > 0)
                    {
                        senators[i] = X;
                        direBans--;
                    }
                    else
                    {
                        radiantBans++;
                        direCount++;
                    }
                }
            }

            if (radiantCount == 0) return "Dire";
            if (direCount == 0) return "Radiant";
        }
    }

    // beats 90%
    public static string PredictPartyVictoryFirstTry(string senate)
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