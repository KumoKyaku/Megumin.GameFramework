using System;

namespace MeguminEngine.Interface
{
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
