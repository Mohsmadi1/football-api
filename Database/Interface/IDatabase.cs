namespace football_api.Database.Interface;

public interface IDatabase<T>
{

    public void Add<T>(T item , string path);

    public void Delete<T>(int id , string path);

    public void FilterPlayer(string item1 , int item2 , string path);

    public void GetAll<T>(string path);

    public void Get<T>(int id , string path);

    public void Update<T>(T item , int id , string path);
    
    
}