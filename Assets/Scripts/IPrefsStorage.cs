namespace GDSerializer
{
    public interface IPrefsStorage
    {
        T Deserealize<T> (string key) where T : class;
        void Serialize<T> (string key, T obj);  
    }
}