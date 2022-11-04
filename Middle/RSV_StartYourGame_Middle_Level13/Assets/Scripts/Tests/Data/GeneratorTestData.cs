using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Tests.Data
{
    [Serializable]
    public class GeneratorTestParam
    {
        public Vector2Int point;
        public float deltaX;
        public float deltaY; 
        public Vector3 startPoint;
    }
    [CreateAssetMenu(fileName = "GeneratorTestData", menuName = "TestsData/Generator", order = 0)]
    public class GeneratorTestData : TestsData<GeneratorTestParam>
    {
        // private void OnValidate()
        // {
        //     testingData = new List<GeneratorTestParam>();
        //     for (int i = 0; i < 100; i++)
        //     {
        //         var k = new GeneratorTestParam();
        //         var randomCircle = Random.insideUnitCircle * Random.Range(0f, 30f);
        //         k.point = new Vector2Int(Mathf.FloorToInt(randomCircle.x), Mathf.FloorToInt(randomCircle.y));
        //         k.deltaX = Random.Range(0, 30f) - 15f;
        //         k.deltaY = Random.Range(0, 30f) - 15f;
        //         k.startPoint = Random.insideUnitSphere * Random.Range(0f, 30f);
        //         testingData.Add(k);
        //     }
        // }
    }
}