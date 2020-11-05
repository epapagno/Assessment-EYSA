namespace Common.Infr.Support.Filter
{
    public class RangeFilter<TValue>
    {
        public RangeFilter()
        {

        }
        public RangeFilter(TValue min, TValue max, bool excludeNulls)
        {
            MinValue = min;
            MaxValue = max;
            ExcludeNulls = excludeNulls;
        }

        public TValue MinValue { get; set; }
        public TValue MaxValue { get; set; }
        public bool ExcludeNulls { get; set; }
    }
}
