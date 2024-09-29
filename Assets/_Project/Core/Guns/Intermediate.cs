using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intermediate : MonoBehaviour
{
    [field: SerializeField] private Bullet Bullet_PREFAB;
    [field: SerializeField] private WeaponManager _gun; // Ссылка на WeaponManager
    [field: SerializeField] private Transform ParentBullet;

    private void Start()
    {
        if (_gun == null)
        {
            // Если _gun не назначен в инспекторе, находим его вручную
            _gun = FindObjectOfType<WeaponManager>(); 
        }
    }

    private void OnEnable()
    {
        if (_gun != null)
        {
            _gun.OnShoot += OnBulletAdded;
        }
    }

    private void OnDisable()
    {
        if (_gun != null)
        {
            _gun.OnShoot -= OnBulletAdded;
        }
    }

    private void OnBulletAdded(Vector3 difference, float rotZ, int Damage, int Speed)
    {
        // Создаём пулю и инициируем её направление и параметры
        Instantiate(Bullet_PREFAB, ParentBullet.position, Quaternion.identity).Init(difference, rotZ, ParentBullet);
    }
}
