using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoConsoleApplication
{
    public class Deck : ICollection<Card>
    {
        public List<Card> _deck = new List<Card>();

        #region ICollectionMethods
        public int Count => ((ICollection<Card>)_deck).Count;

        public bool IsReadOnly => ((ICollection<Card>)_deck).IsReadOnly;

        public void Add(Card item)
        {
            ((ICollection<Card>)_deck).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Card>)_deck).Clear();
        }

        public bool Contains(Card item)
        {
            return ((ICollection<Card>)_deck).Contains(item);
        }

        public void CopyTo(Card[] array, int arrayIndex)
        {
            ((ICollection<Card>)_deck).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return ((IEnumerable<Card>)_deck).GetEnumerator();
        }

        public bool Remove(Card item)
        {
            return ((ICollection<Card>)_deck).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_deck).GetEnumerator();
        }
        #endregion


    }
}
