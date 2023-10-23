using ECSUtility.Runtime.Components.Hybrids;
using Unity.Entities;
using UnityEngine;

namespace ECSUtility.Runtime.Authorings.Hybrids
{
    public class HybridAuthoring : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;

        private class HybridAuthoringBaker : Baker<HybridAuthoring>
        {
            public override void Bake(HybridAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);

                AddComponentObject(entity, new Hybrid { Prefab = authoring.prefab });
            }
        }
    }
}