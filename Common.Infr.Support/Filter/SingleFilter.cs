namespace Common.Infr.Support.Filter
{
    public class SingleFilter<TValue>
    {
        public SingleFilter()
        {

        }
        public SingleFilter(TValue value, bool excludeNulls)
        {
            Value = value;
            ExcludeNulls = excludeNulls;
        }

        public TValue Value { get; set; }
        public bool ExcludeNulls { get; set; }
    }
}
