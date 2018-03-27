using LawnMowers.Core;

namespace LawnMowers.Interfaces
{
    public class LawnFactory<T> : IGenericFactory<T> where T : Shape, new()
    {
        public LawnFactory() { }
        private T lawn;

        public LawnFactory(T lawn )
        {
            this.lawn = lawn;
        }

        public  T Create()
        {
            return new T(); 
        }
    }
}
