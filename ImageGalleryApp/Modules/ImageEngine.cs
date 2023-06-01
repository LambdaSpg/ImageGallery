using System;

namespace ImageGalleryApp.Modules;

public class ImageEngine
{
    private static Database Database => new Database();
    
    public static void Init()
    {
        var state = Database.CheckConnection() ? "Successful" : "not established";
        Console.WriteLine($"Connection to the Database was: {state}");
    }
}