namespace Malus;

public static class RomLoader
{
    private static string GetRomDirectory()
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        var romsDirectory = Path.Join(currentDirectory, "/roms/");

        return romsDirectory;
    }
    
    public static byte[] LoadRom(string romName)
    {
        var romDir = GetRomDirectory();
        var romPath = Path.Join(romDir, romName);

        if (!File.Exists(romPath))
        {
            Console.WriteLine("Error: Failed to load rom. Exiting...");
            Environment.Exit(1);
        }
        
        var romStream = File.ReadAllBytes(romPath);
        
        return romStream;
    }
}