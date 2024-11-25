using Unity.Burst;
using Unity.Entities;

[BurstCompile]
public partial struct CreatePostSystem : ISystem
{
    [BurstCompile]
    public void OnCreate(ref SystemState state)
    {
        Entity entity = state.EntityManager.CreateSingleton<PostComponent>("Agriculture1");
        state.EntityManager.AddComponent<PostComponent>(entity);

        RefRW<PostComponent> postComponent = SystemAPI.GetSingletonRW<PostComponent>();

        postComponent.ValueRW.category = "Agriculture and Life Sciences";
        postComponent.ValueRW.topic = "Animal and Food Science";
        postComponent.ValueRW.postId = 1;
        postComponent.ValueRW.views = 234;
        postComponent.ValueRW.replies = 18;
        postComponent.ValueRW.likes = 45;
        postComponent.ValueRW.author = "Animlovr";
        postComponent.ValueRW.title = "Help Needed for a Lab in BIO 222";
        postComponent.ValueRW.content = "Looking for help from a senior who has taken BIO 222 for the (placeholder) lab...";
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        state.Enabled = false;
    }

    [BurstCompile]
    public void OnDestroy(ref SystemState state)
    {
        
    }
}
