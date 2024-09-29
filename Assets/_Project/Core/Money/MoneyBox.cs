using UnityEngine;

namespace Core.Money
{
    [CreateAssetMenu(fileName = "MoneyBox", menuName = "ScriptableObjects/MoneyBox", order = 50)]
    public class MoneyBox : ScriptableObject
    {
        private int _currencyAmount;

        public delegate void CurrencyAmountChanged();
        public event CurrencyAmountChanged CurrencyChanged;

        public int CurrencyAmount
        {
            get
            {
                return _currencyAmount;
            }
            set
            {
                _currencyAmount = Mathf.Max(0, value);

                CurrencyChanged?.Invoke();
            }
        }

        public void AddCurrency(int amount)
        {
            CurrencyAmount = _currencyAmount + amount;
        }
    }

}
