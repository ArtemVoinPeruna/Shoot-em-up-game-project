using System;
using UnityEngine;
using Core.Guns;

public class WeaponManager : MonoBehaviour
{
    public SpriteRenderer weaponSpriteRenderer; // Ссылка на компонент SpriteRenderer для отображения спрайта оружия
    public Gun[] availableGuns; // Массив доступных оружий (ScriptableObject)
    private int currentWeaponIndex = 0;
    private Gun currentGun;

    void Start()
    {
        EquipWeapon(0); // Изначально выдаём первое оружие
    }

    // Метод для смены оружия
    public void EquipWeapon(int weaponIndex)
    {
        currentWeaponIndex = weaponIndex;
        currentGun = availableGuns[weaponIndex];
        
        // Обновляем спрайт через SpriteRenderer
        if (weaponSpriteRenderer != null && currentGun.GunSprite != null)
        {
            weaponSpriteRenderer.sprite = currentGun.GunSprite;
        }

        // Применяем параметры оружия к игроку, например, скорость атаки или урон
        ApplyWeaponStats();
    }

    // Метод для подбора нового оружия
    public void PickUpWeapon(Gun newGun)
    {
        Array.Resize(ref availableGuns, availableGuns.Length + 1);
        availableGuns[availableGuns.Length - 1] = newGun;
        
        // Автоматически экипируем новое оружие
        EquipWeapon(availableGuns.Length - 1);
    }

    private void ApplyWeaponStats()
    {
        // Здесь вы можете изменить параметры игрока на основе текущего оружия
        Debug.Log($"Current weapon damage: {currentGun.Damage}, attack speed: {currentGun.AttackSpeed}");
    }
}
