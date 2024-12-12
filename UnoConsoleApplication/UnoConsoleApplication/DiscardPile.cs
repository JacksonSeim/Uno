using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoConsoleApplication
{
    public class DiscardPile : ICollection<Card>
    {
        public List<Card> _discardPile = new List<Card>();

        #region ICollectionMethods
        public int Count => ((ICollection<Card>)_discardPile).Count;

        public bool IsReadOnly => ((ICollection<Card>)_discardPile).IsReadOnly;

        public void Add(Card item)
        {
            ((ICollection<Card>)_discardPile).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Card>)_discardPile).Clear();
        }

        public bool Contains(Card item)
        {
            return ((ICollection<Card>)_discardPile).Contains(item);
        }

        public void CopyTo(Card[] array, int arrayIndex)
        {
            ((ICollection<Card>)_discardPile).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return ((IEnumerable<Card>)_discardPile).GetEnumerator();
        }

        public bool Remove(Card item)
        {
            return ((ICollection<Card>)_discardPile).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_discardPile).GetEnumerator();
        }
        #endregion
    }
}
