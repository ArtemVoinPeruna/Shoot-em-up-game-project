using UnityEngine;

namespace Entitys
{
    public class EntityContainer : MonoBehaviour
    {
        public Entity Entity { get; private set; }

        public delegate void CreatedEntityDelegate(Entity entity);
        public event CreatedEntityDelegate CreatedEntity;

        public EntityContainer Init(Entity entity)
        {
            Entity = entity;
            CreatedEntity(entity);
            return this;
        }
    }
}
