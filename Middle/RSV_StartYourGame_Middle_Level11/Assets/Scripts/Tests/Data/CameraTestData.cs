using System;
using UnityEngine;

namespace Tests.Data
{
    [Serializable]
    public class CameraTestParam
    {
        public Vector3 cameraPosition;
        public Vector3 prevMousePosition;
        public Vector3 currentMousePosition;
    }


    [CreateAssetMenu(fileName = "CameraTestData", menuName = "TestsData/Camera", order = 0)]
    public class CameraTestData : TestsData<CameraTestParam>
    {
        private void OnValidate()
        {
            // testingData = new List<CameraTestParam>();
            // for (int i = 0; i < 100; i++)
            // {
            //     var k = new CameraTestParam();
            //     k.cameraPosition = Random.insideUnitCircle * Random.Range(0, 30f);
            //     k.prevMousePosition = Random.insideUnitCircle * Random.Range(0, 30f);
            //     k.currentMousePosition = Random.insideUnitCircle * Random.Range(0, 30f);
            //     testingData.Add(k);
            // }
        }
    }
}