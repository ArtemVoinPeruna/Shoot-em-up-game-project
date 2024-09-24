using UnityEngine;

namespace Core.Player
{
    public class MovePlayer : MonoBehaviour
    {
        public float speed = 5f;
        private Vector2 movement;

        void Update()
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");

            movement = new Vector2(moveX, moveY);

            MovePlayerCharacter();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Gun"))
            {
                Destroy(other.gameObject);
                transform.position = movement;
            }
        }

        private void MovePlayerCharacter()
        {
            transform.position += (Vector3)movement * speed * Time.deltaTime;
        }
    }
}
