using System;
using UnityEngine;
using Core.Guns;

public class WeaponManager : MonoBehaviour
{
    public SpriteRenderer weaponSpriteRenderer; // Ссылка на компонент SpriteRenderer для отображения спрайта оружия
    [field: SerializeField] private GunBox _gunBox; // Массив доступных оружий (ScriptableObject)
    private int currentWeaponIndex = 0;
    private Gun currentGun;
    public float offset;
    public delegate void ShootAction(Vector3 difference, float rotZ, int Damage, int Speed);
    public event ShootAction OnShoot;
    private float timeBtwShots;

    void Start()
    {
        EquipWeapon(0); // Изначально выдаём первое оружие
    }

    // Метод для смены оружия
    public void EquipWeapon(int weaponIndex)
    {
        currentWeaponIndex = weaponIndex;
        currentGun = _gunBox.GunsList[weaponIndex];
        weaponSpriteRenderer.sprite = currentGun.GunSprite;
        ApplyWeaponStats();
    }
    private void ApplyWeaponStats()
    {
        // Здесь вы можете изменить параметры игрока на основе текущего оружия
        Debug.Log($"Current weapon damage: {currentGun.Damage}, attack speed: {currentGun.AttackSpeed}");
    }
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                timeBtwShots = currentGun.AttackSpeed;
                OnShoot?.Invoke(difference, rotZ, currentGun.Damage, currentGun.Speed);
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        } 
    }
}
