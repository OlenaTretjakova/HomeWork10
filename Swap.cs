namespace HomeWork10
{
    internal class Swap<T>
    {
        public T Value1 { get; set; }
        public T Value2 { get; set; }

        public Swap(T value1, T value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public static void MetodSwap(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;

        }

    }
}
