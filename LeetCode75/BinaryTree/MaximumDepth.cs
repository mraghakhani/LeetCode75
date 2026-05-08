namespace LeetCode75.BinaryTree;

public class MaximumDepth
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        return MaxDepthOfNode(root);
    }

    private int MaxDepthOfNode(TreeNode root)
    {
        var max = 1;
        if (root.left == null && root.right == null)
            return 1;
        var leftMaxDepth = 0;
        var rightMaxDepth = 0;
        if (root.left is not null)
            leftMaxDepth = MaxDepthOfNode(root.left);
        if (root.right is not null)
            rightMaxDepth = MaxDepthOfNode(root.right);
        var maxDepthOfThisNode = Math.Max(leftMaxDepth, rightMaxDepth);
        return max + maxDepthOfThisNode;
    }
}
