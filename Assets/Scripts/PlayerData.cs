using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : Manager<PlayerData>
{
    public int Money { get; private set; }

    public System.Action OnUpdate;
    public Text text;

    private void Start()
    {
        Money = 250;
        text.text = Money.ToString();
    }

    public bool CanAfford(int amount)
    {
        return amount <= Money;
    }

    public void SpendMoney(int amount)
    {
        Money -= amount;
        OnUpdate?.Invoke();
    }

    public void Update()
    {
        text.text = Money.ToString();
    }
}
