namespace LeetCode75.Stack;

public class AsteroidCollisionProblem
{
    public static int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();

        foreach (var asteroid in asteroids)
        {
            var destroyed = false;

            while (stack.Count > 0 && stack.Peek() > 0 && asteroid < 0)
            {
                var top = stack.Peek();

                if (top < Math.Abs(asteroid))
                {
                    stack.Pop();
                    continue;
                }

                if (top == Math.Abs(asteroid)) stack.Pop();

                destroyed = true;
                break;
            }

            if (!destroyed)
            {
                stack.Push(asteroid);
            }
        }

        return stack.Reverse().ToArray();
    }
}