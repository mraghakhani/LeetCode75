namespace LeetCode75.BinaryTree;

public class LeafSimilarTrees
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var firstLeaves = LeafNodes(root1);
        var secondLeaves = LeafNodes(root2);

        if (firstLeaves.Count != secondLeaves.Count)
            return false;

        for (int i = 0; i < firstLeaves.Count; i++)
        {
            var first = firstLeaves[i];
            var second = secondLeaves[i];
            if (first != second)
                return false;
        }
        return true;
    }

    private List<int> LeafNodes(TreeNode root)
    {
        var leaves = new List<int>();

        if (root.left == null && root.right == null)
        {
            leaves.Add(root.val);
            return leaves;
        }

        if (root.left is not null)
            leaves.AddRange(LeafNodes(root.left));
        if (root.right is not null)
            leaves.AddRange(LeafNodes(root.right));

        return leaves;
    }
}
