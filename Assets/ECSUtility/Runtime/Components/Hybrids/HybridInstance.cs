using System;
using Unity.Entities;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ECSUtility.Runtime.Components.Hybrids
{
    public class HybridInstance : IComponentData, IDisposable
    {
        public GameObject Instance;

        public void Dispose()
        {
            Object.DestroyImmediate(Instance);
        }
    }
}