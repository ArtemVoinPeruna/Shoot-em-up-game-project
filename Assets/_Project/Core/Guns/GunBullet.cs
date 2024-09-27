using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Enemys;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;
    private Vector2 direction;
    private Rigidbody2D rb;
    public Transform ParentBullet;

    // Метод для установки направления полета пули
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Устанавливаем скорость пули
        rb.AddForce(ParentBullet.right * speed, ForceMode2D.Impulse);
        // Уничтожаем пулю через lifetime секунд
        Destroy(gameObject, lifetime);
    }

    public Bullet Init(Vector3 difference, float rotZ, Transform ParentBullet)
    {
        // Нормализуем направление
        direction = difference.normalized;
        this.ParentBullet = ParentBullet;
        // Устанавливаем начальное вращение пули
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
        // Возвращаем сам объект для возможного дальнейшего использования
        return this;
    }

    
    private void Update()
    {
        // Проверяем столкновение с объектами через Raycast
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, direction, distance, whatIsSolid);

        if (hitInfo.collider != null)
        {
            // Если пуля попала во врага, наносим урон
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }

            // Уничтожаем пулю при столкновении
            Destroy(gameObject);
        }
    }
}
