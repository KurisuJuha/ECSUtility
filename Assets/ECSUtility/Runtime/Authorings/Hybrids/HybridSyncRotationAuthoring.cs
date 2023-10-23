using ECSUtility.Runtime.Components.Hybrids;
using Unity.Entities;
using UnityEngine;

namespace ECSUtility.Runtime.Authorings.Hybrids
{
    [RequireComponent(typeof(HybridAuthoring))]
    public class HybridSyncRotationAuthoring : MonoBehaviour
    {
        private class HybridSyncRotationAuthoringBaker : Baker<HybridSyncRotationAuthoring>
        {
            public override void Bake(HybridSyncRotationAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);
                AddComponent<HybridSyncRotation>(entity);
                AddComponent(entity, new HybridSyncRotation());
            }
        }
    }
}