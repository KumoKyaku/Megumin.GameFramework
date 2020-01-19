namespace MeguminEngine.Interface
{
    /// <summary>
    /// 道具
    /// </summary>
    public interface IItem
    {

    }

    /// <summary>
    /// 道具
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IItem<out T> : IItem
    {

    }

    /// <summary>
    /// 物品主键
    /// </summary>
    public interface IItemID
    {
        int ItemID { get; set; }
    }

    public interface IItemInstanceID
    {
        long ItemInstanceID { get; set; }
    }
}
