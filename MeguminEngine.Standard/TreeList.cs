namespace System.Collections.Generic.Tree
{
    //设计失误，树形结构本质是图，应使用Josn或其他序列化文件表示Graph,然后直接在Graph进行查询。
    //这里作为泛型参考和提醒使用。
    /// <summary>
    /// 树形容器
    /// </summary>
    [Obsolete("Use Josn or others instead.",true)]
    public interface ITreeList<T>:ITreeListPart1<T,ITreeNode<T>>,ITreeListPart2<T,ITreeNode<T>>,
        ICollection<T>, IEnumerable<T>, ICollection, IEnumerable
    {

    }

    [Obsolete("Use Josn or others instead.", true)]
    public interface ITreeListPart1<T,out OutNode> 
        where OutNode : ITreeNode<T>
    {
        OutNode Find(T value);
        IEnumerable<OutNode> GetLayer(int layer);
    }

    [Obsolete("Use Josn or others instead.", true)]
    public interface ITreeListPart2<T,in Node>
        where Node : ITreeNode<T>
    {
        ITreeNode<T> AddAfter(Node node,T value);
        ITreeNode<T> AddBefore(Node node,T value);
        void AddAfter(Node node, Node newNode);
        void AddBefore(Node node, Node newNode);
    }

    [Obsolete("Use Josn or others instead.", true)]
    public interface ITreeNode<T> : ICollection<T>, IEnumerable<T>, ICollection, IEnumerable
    {
        ITreeList<T> List { get; }
        ITreeNode<T> Parent { get; }
        ITreeNode<T> this[int index] { get; }
        int Layer { get; }
        T Value { get; set; }
        ITreeNode<T> AddFirstChild(T value);
        void AddFirstChild(ITreeNode<T> node);
        ITreeNode<T> AddLastChild(T value);
        void AddLastChild(ITreeNode<T> node);

        ITreeNode<T> InsertChild(int index, T value);
    }

}
