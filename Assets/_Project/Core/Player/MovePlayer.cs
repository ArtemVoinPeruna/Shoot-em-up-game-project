using UnityEngine;

namespace Core.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class MovePlayer : MonoBehaviour
    {
        public float speed = 5f;
        private Rigidbody2D rb;
        private Vector2 movement;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");

            movement = new Vector2(moveX, moveY);
        }

        void FixedUpdate()
        {
            MovePlayerCharacter();
        }

        private void MovePlayerCharacter()
        {
            rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        }
    }
}
