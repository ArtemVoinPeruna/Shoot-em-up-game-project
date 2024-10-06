using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed;
    private float lifetime = 5;
    private float distance = 20;
    private int damage;
    public LayerMask whatIsSolid;
    private Rigidbody2D rb;
    private Transform FirePoint;

    // Метод для установки направления полета пули
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log(damage.ToString() + "        " + speed.ToString() + "       " + FirePoint.ToString());

        rb.AddForce(FirePoint.right * speed, ForceMode2D.Impulse);
        // Уничтожаем пулю через lifetime секунд
        Destroy(gameObject, lifetime);
    }

    public Bullet Init(float rotZ, int Damage, float Speed, Transform ParentBullet)
    {
        FirePoint = ParentBullet;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
        damage=Damage;
        speed=Speed;
        return this;
    }

    // private void Update()
    // {
    //     // Проверяем столкновение с объектами через Raycast
    //     RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, direction, distance, whatIsSolid);

    //     if (hitInfo.collider != null)
    //     {
    //         // Если пуля попала во врага, наносим урон
    //         // if (hitInfo.collider.CompareTag("Enemy"))
    //         // {
    //         //     hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
    //         // }

    //         // // Уничтожаем пулю при столкновении
    //         // Destroy(gameObject);
    //     }
    // }
}
