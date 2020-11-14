namespace Lesson2
{
    public struct NormalWeight
    {
        public int Min { get; }
        public int Max { get; }

        public NormalWeight(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }
}