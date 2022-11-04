using System.Collections.Generic;
using UnityEngine;

namespace Tests.Data
{
    public abstract class TestsData<T>: ScriptableObject
    {
        public List<T> testingData;
        
    }
}