namespace Tupple
{
    public class Tuppple<T,K>
    {
        private T item1;
        private K item2;

        public Tuppple(T item1,K item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public override string ToString()
        {
            return $"{this.item1} -> {this.item2}";
        }
    }
}
