using UnityEngine;

namespace Core.Money
{
    [CreateAssetMenu(fileName = "MoneyBoxSave", menuName = "ScriptableObjects/MoneyBoxSave", order = 50)]
    public class MoneyBoxSave : ScriptableObject
    {
        private const string CurrencyKey = "CurrencyAmount";

        public void SaveCurrency(int amount)
        {
            PlayerPrefs.SetInt(CurrencyKey, amount);
            PlayerPrefs.Save();
            Debug.Log($"Currency amount {amount} saved.");
        }

        public int LoadCurrency()
        {
            int amount = PlayerPrefs.GetInt(CurrencyKey, 0);
            Debug.Log($"Currency amount loaded: {amount}");
            return amount;
        }
    }

}
