using football_api.Services.Interfaces;

namespace football_api.Services;

public class IndexManager : IIndexManager
{
    public int Get(string path)
    {
        string id = File.ReadAllText(path);
        int dc = Convert.ToInt32(id);
        return dc;
    }

    public void Update(int newIndex, string path)
    {
        File.WriteAllText(path, newIndex.ToString());
    }
}