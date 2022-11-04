using Gameplay;
using Tests.Data;
using UnityEngine;

namespace Tests.Executors
{
    public class CameraTestExecutor : SumTestExecutor<CameraTestParam, CameraTestData>
    {
        protected override long CalculateResult(CameraTestParam inputData)
        {
            var result = CameraMovement.ProcessCameraMovement(
                inputData.currentMousePosition,
                inputData.prevMousePosition,
                inputData.cameraPosition);
            return Mathf.FloorToInt(result.magnitude);
        }
    }
}