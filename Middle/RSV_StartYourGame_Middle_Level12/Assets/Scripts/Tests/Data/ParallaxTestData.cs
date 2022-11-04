using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Tests.Data
{
    [Serializable]
    public class ParallaxTestParam
    {
        public Vector3 objectPosition;
        public Vector3 cameraDelta;
        public float alpha;
    }

    [CreateAssetMenu(fileName = "ParallaxTestData", menuName = "TestsData/Parallax", order = 0)]
    public class ParallaxTestData : TestsData<ParallaxTestParam>
    {
        // private void OnValidate()
        // {
        //     testingData = new List<ParallaxTestParam>();
        //     for (int i = 0; i < 100; i++)
        //     {
        //         var k = new ParallaxTestParam();
        //         k.objectPosition = Random.insideUnitCircle * Random.Range(0, 30f);
        //         k.cameraDelta = Random.insideUnitCircle * Random.Range(0, 30f);
        //         k.alpha = Random.Range(0, 30f);
        //         testingData.Add(k);
        //     }
        // }
    }
}