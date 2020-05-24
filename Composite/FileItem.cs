namespace DesignPatterns.Composite
{
    public class FileItem : FileSystemItem
    {
        private int byteSizes;

        public FileItem(string name, int byteSizes) : base(name)
        {
            this.byteSizes = byteSizes;
        }

        public override decimal GetSizeInKb()
        {
            return decimal.Divide(byteSizes, 1000);
        }
    }
}
