namespace matreshki_tg_bot.Bot.Router;

public class DataStorage
{
    private Dictionary<string, object> _data;

    public DataStorage()
    {
        _data = new Dictionary<string, object>();
    }

    public void AddOrUpdate(string key, object value)
    {
        _data[key] = value;
    }

    public void Delete(string key)
    {
        _data.Remove(key);
    }

    public void Clear()
    {
        _data.Clear();
    }

    public object Get(string key)
    {
        return _data[key];
    }
}
