using UnityEngine;


namespace Core.Guns
{
                                                        
    [CreateAssetMenu(fileName = "NewGuns", menuName = "Guns/GunsArray")]
    public class Guns : ScriptableObject
    {
        public GunInformation[] gunList; // Массив всех созданных GunInformation

        // Метод для возврата случайного оружия
        public GunInformation GetRandomGun()
        {
            if (gunList.Length == 0)
            {
                Debug.LogWarning("Нет доступного оружия!");
                return null;
            }

            int randomIndex = Random.Range(0, gunList.Length);
            return gunList[randomIndex];
        }
    }
}
