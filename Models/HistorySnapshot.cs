using System.Collections.Generic;
using System.Linq;

namespace YarnInventoryWeb.Models
{
    public class HistorySnapshot
    {
        public List<YarnItem> Items { get; set; } = new();

        public HistorySnapshot() { }

        public HistorySnapshot(List<YarnItem> items)
        {
            // Clone every single item to prevent reference mutations in the stack
            Items = items.Select(i => i.Clone()).ToList();
        }
    }
}