namespace LeetCode75.BinaryTree;

public class CountGoodNodesInBinaryTree
{
    private const int Min = int.MinValue;

    public int GoodNodes(TreeNode root)
    {
        return GoodsOfNode(root, Min);
    }

    // beats 96%
    private int GoodsOfNode(TreeNode root, int max)
    {
        int count = 0;

        if (root.val >= max)
        {
            count = 1;
            max = root.val;
        }

        if (root.left != null)
            count += GoodsOfNode(root.left, max);

        if (root.right != null)
            count += GoodsOfNode(root.right, max);

        return count;
    }

    //beats 48%
    private int GoodsOfNodeFirstTry(TreeNode root, int max)
    {
        var goods = 0;
        goods += max <= root.val ? 1 : 0;

        max = Math.Max(max, root.val);

        if (root.left is not null)
            goods += GoodsOfNode(root.left, max);
        if (root.right is not null)
            goods += GoodsOfNode(root.right, max);
        return goods;
    }
}
