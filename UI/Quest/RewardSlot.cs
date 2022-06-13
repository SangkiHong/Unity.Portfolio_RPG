using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SK.UI;

namespace SK
{
    public class RewardSlot : SlotBase
    {
        [SerializeField] private Text amountText;
        public void Assign(Sprite sptire, uint amount = 1)
        {
            base.Assign(sptire);

            if (amount == 1)
                amountText.gameObject.SetActive(false);
            else
            {
                amountText.gameObject.SetActive(true);
                amountText.text = amount.ToString();
            }
        }
    }
}