using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite
{
    public class DirectoryItem : FileSystemItem
    {
        private List<FileSystemItem> items = new List<FileSystemItem>();

        public DirectoryItem(string name) : base(name)
        {
        }

        public void Add(FileSystemItem item)
        {
            items.Add(item);
        }

        public void Remove(FileSystemItem item)
        {
            items.Remove(item);
        }

        public override decimal GetSizeInKb()
        {
            return items.Sum(item => item.GetSizeInKb());
        }
    }
}
