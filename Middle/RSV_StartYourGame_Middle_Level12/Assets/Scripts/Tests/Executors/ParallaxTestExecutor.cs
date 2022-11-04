using Parallax;
using Tests.Data;
using UnityEngine;

namespace Tests.Executors
{
    public class ParallaxTestExecutor : SumTestExecutor<ParallaxTestParam,ParallaxTestData>
    {
        protected override long CalculateResult(ParallaxTestParam inputData)
        {
            var result = ParallaxView.CalculatePositionParallax(
                inputData.objectPosition,
                inputData.cameraDelta, 
                inputData.alpha);
            return Mathf.FloorToInt(result.magnitude);
        }
        
    }
}