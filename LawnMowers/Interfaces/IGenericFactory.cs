namespace LawnMowers.Interfaces
{
    public interface IGenericFactory<out T>
    {
      T Create();
    }
}
