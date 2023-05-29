using TodoList.CLI.Repositories;

namespace TodoList.CLI;

public abstract class BaseRepository<TModel> : IDataRepository<TModel>
{
    public string FileName { get; set; }
    protected BaseRepository(string fileName)
    {
        FileName = fileName;
    }
    public abstract void SaveData(TodoData<TModel> value);
    public abstract TodoData<TModel> LoadData();
}