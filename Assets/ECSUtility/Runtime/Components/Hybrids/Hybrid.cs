using Unity.Entities;
using UnityEngine;

namespace ECSUtility.Runtime.Components.Hybrids
{
    public class Hybrid : IComponentData
    {
        public GameObject Prefab;
    }
}