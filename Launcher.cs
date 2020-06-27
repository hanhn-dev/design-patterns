namespace DesignPatterns
{
    public abstract class Launcher : ILauncher
    {
        private readonly string _name;
        public Launcher(string launcherName)
        {
            _name = launcherName;
        }

        public string Name => _name;

        public abstract void Run();
    }
}
