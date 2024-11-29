using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireBuilder.Shared
{
    public class StoreManager
    {
        public List<Store> Stores { get; private set; } = new List<Store>();

        public void AddStore(Store store)
        {
            Stores.Add(store);
        }

        public void RemoveStore(Store store)
        {
            Stores.Remove(store);
        }
    }
}
