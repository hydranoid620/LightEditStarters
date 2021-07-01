namespace WebStorm
{
    class WebStormStarter
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process process = new()
            {
                StartInfo =
                {
                    FileName = "C:\\Users\\Nicholas\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\JetBrains Toolbox\\WebStorm.lnk",
                    Arguments = $"-e \"{args[0]}\"",
                    CreateNoWindow = true,
                    UseShellExecute = true
                }
            };
            process.Start();
        }
    }
}