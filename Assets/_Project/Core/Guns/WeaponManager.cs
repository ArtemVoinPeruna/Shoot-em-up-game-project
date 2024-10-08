using System;
using UnityEngine;
using Core.Guns;

public class WeaponManager : MonoBehaviour
{
    public SpriteRenderer weaponSpriteRenderer; // Ссылка на компонент SpriteRenderer для отображения спрайта оружия
    [field: SerializeField] private GunBox _gunBox; // Массив доступных оружий (ScriptableObject)
    private int currentWeaponIndex;
    private Gun currentGun;
    public float offset;
    public delegate void ShootAction(float rotZ, int Damage, float Speed);
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
        currentGun = _gunBox.GunsList[currentWeaponIndex];
        weaponSpriteRenderer.sprite = currentGun.GunSprite;
        timeBtwShots = currentGun.AttackSpeed;
        ApplyWeaponStats();
    }
    private void ApplyWeaponStats()
    {
        
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
                OnShoot?.Invoke(rotZ, currentGun.Damage, currentGun.Speed);
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        } 
    }
}
