using UnityEngine;
using Entitys;

namespace Core.Player
{
    public class MovePlayer : MonoBehaviour
    {
        public Entity Player;
        private Vector2 movement;
        private float attractionSpeed = 5f; 

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
                StartCoroutine(AttractItem(other.gameObject));
            }
        }

        private void MovePlayerCharacter()
        {
            transform.position += (Vector3)movement * Player.Speed * Time.deltaTime;
        }

        private System.Collections.IEnumerator AttractItem(GameObject item)
        {
            while (Vector3.Distance(item.transform.position, transform.position) > 0.1f)
            {
                item.transform.position = Vector3.Lerp(item.transform.position, transform.position, attractionSpeed * Time.deltaTime);

                yield return null;
            }

            Destroy(item);
        }
    }
}
