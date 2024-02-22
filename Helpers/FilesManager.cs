namespace football_api.Helpers;

public static class FilesManager
{
    public static void Check()
    {
        string path = "./Data/Players";
        var files = Directory.GetFiles(path);
    }

}