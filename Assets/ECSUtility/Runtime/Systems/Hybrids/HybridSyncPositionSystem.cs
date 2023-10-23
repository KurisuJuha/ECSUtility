using Unity.Burst;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace ECSUtility.Runtime.Systems.Hybrids
{
    [BurstCompile]
    public partial struct HybridSyncPositionSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
        }

        public void OnUpdate(ref SystemState state)
        {
            foreach (var (localTransform, transform) in SystemAPI
                         .Query<LocalTransform, SystemAPI.ManagedAPI.UnityEngineComponent<Transform>>())
                transform.Value.position = localTransform.Position;
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
        }
    }
}