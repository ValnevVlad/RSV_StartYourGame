using Tests.Data;

namespace Tests.Executors
{
    public abstract class SumTestExecutor <TInputType, TTestData> : TestExecutor<TInputType,long,TTestData>
    where TTestData: TestsData<TInputType>
    {
        protected override long InitResult()
        {
            return 0;
        }
        

        protected override long Aggregate(long element, long accumulated)
        {
            return element + accumulated;
        }
    }
}