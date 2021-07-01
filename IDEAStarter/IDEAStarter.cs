namespace IDEA
{
    static class IDEAStarter
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process process = new()
            {
                StartInfo =
                {
                    FileName = "C:\\Users\\Nicholas\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\JetBrains Toolbox\\IntelliJ IDEA Ultimate.lnk",
                    Arguments = $"-e \"{args[0]}\"",
                    CreateNoWindow = true,
                    UseShellExecute = true
                }
            };
            process.Start();
        }
    }
}