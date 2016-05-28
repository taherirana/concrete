using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class ConcreteSellOrder : ICollection<SellItem>
    {
        public User user;

        public Customer customer;

        List<SellItem> _sellItms;

        public List<SellItem> Items
        {
            get
            {
                return _sellItms;
            }
        }

        public ConcreteSellOrder()
        {
            _sellItms = new List<SellItem>();

            user = Util.user;

        }


        public void Add(SellItem item)
        {
            _sellItms.Add(item);
        }

        public void Clear()
        {
            _sellItms.Clear();
        }

        public bool Contains(SellItem item)
        {
            return _sellItms.Contains(item);
        }

        public void CopyTo(SellItem[] array, int arrayIndex)
        {
            //Not Implemened
        }

        public int Count
        {
            get
            {
                return _sellItms.Count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(SellItem item)
        {
            return _sellItms.Remove(item);
        }

        public IEnumerator<SellItem> GetEnumerator()
        {
            return _sellItms.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _sellItms.GetEnumerator();
        }
    }
}
