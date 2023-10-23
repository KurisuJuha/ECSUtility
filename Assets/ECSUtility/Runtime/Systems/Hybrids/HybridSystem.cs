using ECSUtility.Runtime.Components.Hybrids;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace ECSUtility.Runtime.Systems.Hybrids
{
    public partial struct HybridSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
        }

        public void OnUpdate(ref SystemState state)
        {
            foreach (var entity in SystemAPI.QueryBuilder().WithAll<Hybrid>().Build().ToEntityArray(Allocator.Temp))
            {
                var hybrid = state.EntityManager.GetComponentData<Hybrid>(entity);

                if (hybrid.Prefab != null)
                {
                    var instance = Object.Instantiate(hybrid.Prefab);
                    instance.hideFlags = HideFlags.HideInHierarchy;

                    foreach (var component in instance.GetComponents<Component>())
                        state.EntityManager.AddComponentObject(entity, component);
                    state.EntityManager.AddComponentData(entity, new HybridInstance { Instance = instance });
                }

                state.EntityManager.RemoveComponent<Hybrid>(entity);
            }
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
        }
    }
}