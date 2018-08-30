
using System.Collections.Generic;
using System.Text;

namespace blazorTodo
{
    class SimpleViewBag 
    {
        private HashSet<string> _items = new HashSet<string>();

        public string GetItemsHtml()
        {
            var res = new StringBuilder();
            foreach(var item in _items)
            {
                res.Append($"<li>{item}</li>");
            }

            return res.ToString();
        }

        public IEnumerable<string> GetItems()
        {
            IEnumerable<int> x = new List<int>();
            return _items;
        }

        public void AddItem(string item)
        {
            _items.Add(item);
        }

        public void RemoveItem(string item)
        {
            _items.Remove(item);
        }
    }
}