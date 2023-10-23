using ECSUtility.Runtime.Components.Hybrids;
using Unity.Entities;
using UnityEngine;

namespace ECSUtility.Runtime.Authorings.Hybrids
{
    [RequireComponent(typeof(HybridAuthoring))]
    public class HybridSyncPositionAuthoring : MonoBehaviour
    {
        private class HybridSyncPositionAuthoringBaker : Baker<HybridSyncPositionAuthoring>
        {
            public override void Bake(HybridSyncPositionAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);
                AddComponent<HybridSyncPosition>(entity);
            }
        }
    }
}