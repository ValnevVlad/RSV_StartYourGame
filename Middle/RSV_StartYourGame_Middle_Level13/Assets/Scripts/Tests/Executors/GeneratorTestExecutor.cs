using Gameplay.Map;
using Tests.Data;
using UnityEngine;

namespace Tests.Executors
{
    public class GeneratorTestExecutor : SumTestExecutor<GeneratorTestParam, GeneratorTestData>
    {
        protected override long CalculateResult(GeneratorTestParam inputData)
        {
            var result = MapCoordinates.GetPointPosition(inputData.point, inputData.deltaX, inputData.deltaY,
                inputData.startPoint);
            return Mathf.FloorToInt(result.magnitude);
        }
    }
}