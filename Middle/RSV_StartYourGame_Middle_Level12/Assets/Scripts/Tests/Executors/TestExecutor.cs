using System.Collections.Generic;
using Tests.Data;
using UnityEngine;

namespace Tests.Executors
{
    public abstract class TestExecutor <TInputType, TResultType, TTestData>: MonoBehaviour where TTestData: TestsData<TInputType>
    {
        private void Awake()
        {
            Debug.LogError($"[TEST] Test result : {AggregateResults(data.testingData)}");
        }
        [SerializeField] protected TTestData data;
        public TResultType AggregateResults(List<TInputType> inputData)
        {
            TResultType result = InitResult();
            foreach (var inputElement in inputData)
            {
                var currentResult = CalculateResult(inputElement);
                result = Aggregate(currentResult, result);
            }
            return result;
        }

        protected abstract TResultType InitResult();
        protected abstract TResultType CalculateResult(TInputType inputData);
        protected abstract TResultType Aggregate(TResultType element, TResultType accumulated);
    }
}