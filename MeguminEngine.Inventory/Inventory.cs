using System;
using System.Collections;
using System.Collections.Generic;
using MeguminEngine.Interface;
using System.Linq;

namespace MeguminEngine.Inventory
{
    public partial class Inventory<ItemDate>:List<ItemDate>
        where ItemDate:IItemInstanceID,ISplitable<ItemDate>
    {
        private readonly object innerLock = new object();
        public int MaxCount { get; protected set; }

        public Inventory(int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            MaxCount = count;
        }

        public new void Add(ItemDate item)
        {
            if (Count >= MaxCount)
            {
                throw new IndexOutOfRangeException();
            }

            base.Add(item);
        }

        readonly Dictionary<int, int> indexCache = new Dictionary<int, int>();
        public bool TryGet(int instanceID,out ItemDate item)
        {
            if (indexCache.TryGetValue(instanceID,out var index))
            {
                if (Count > index)
                {
                    if (this[index].ItemInstanceID == instanceID)
                    {
                        item = this[index];
                        return true;
                    }
                }
            }
            else
            {
                item = this.FirstOrDefault(i => i.ItemInstanceID == instanceID);
                return item != null;
            }

            item = default;
            return false;
        }
    }
}
