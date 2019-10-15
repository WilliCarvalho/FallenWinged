using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBase : MonoBehaviour
{
    public string nameItem;
    public Sprite icon;
    public bool isStackable;
    protected int amount = 1;

    
    public void AddItem(int amountToAdd = 1)
    {
        amount += amountToAdd;
    }

    public int GetAmount()
    {
        return amount;
    }
}
