namespace LeetCode75.Queue;

public class NumberOfRecentCalls
{
    private readonly Queue<int> _queue;

    public NumberOfRecentCalls()
    {
        _queue = new Queue<int>();
    }

    // beats 97%
    public int Ping(int t)
    {
        var timeRangeStart = t - 3000;
        _queue.Enqueue(t);

        while (_queue.Count > 0)
        {
            var lastTime = _queue.Peek();
            if (lastTime < timeRangeStart)
                _queue.Dequeue();
            else
                return _queue.Count;
        }

        return 1;
    }

    // beats 11%
    public int PingFirstTry(int t)
    {
        var count = 1;
        var timeRangeStart = t - 3000;
        var array = _queue.ToArray();
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] >= timeRangeStart) count++;
            else break;
        }

        _queue.Enqueue(t);
        return count;
    }
}