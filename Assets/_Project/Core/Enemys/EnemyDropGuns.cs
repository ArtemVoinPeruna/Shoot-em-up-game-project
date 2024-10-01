using UnityEngine;

public class EnemyDropGun : MonoBehaviour
{
    // Список префабов оружия
    public GameObject[] weaponPrefabs;
    
    // Шанс дропа (например, 0.2 для 20% шанса)
    [Range(0f, 1f)] 
    public float dropChance = 0.2f;
    
    // Метод, который вызывается при смерти врага
    public void OnDeath()
    {
        // Генерация случайного числа от 0 до 1
        float randomValue = Random.Range(0f, 1f);
        
        // Проверка, выпадает ли оружие
        if (randomValue <= dropChance)
        {
            // Выбираем случайное оружие из списка
            int randomWeaponIndex = Random.Range(0, weaponPrefabs.Length);
            GameObject weaponToDrop = weaponPrefabs[randomWeaponIndex];
            
            // Спавн оружия в позиции смерти врага
            Instantiate(weaponToDrop, transform.position, Quaternion.identity);
        }
    }
}