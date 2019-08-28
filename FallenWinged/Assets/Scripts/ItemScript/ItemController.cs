using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeItem
{
    Mouse = 0,
    Keyboard = 1,
    Headset = 2,
    Glasses = 3
}

[System.Serializable]
public class ItemStats
{
    public BasicStats basicStats;
    public TypeItem item;
}

public class ItemController : MonoBehaviour
{
    public static ItemController itemController;

    public List<ItemStats> itemStats;

    // Start is called before the first frame update
    void Start()
    {
        itemController = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static TypeItem GetItemType()
    {
        int typeId = PlayerPrefs.GetInt("TypeCharacter");

        if (typeId == 0)
        {
            return TypeItem.Mouse;
        }
        else if (typeId == 1)
        {
            return TypeItem.Keyboard;
        }
        else if (typeId == 2)
        {
            return TypeItem.Headset;
        }
        else if (typeId == 3)
        {
            return TypeItem.Glasses;
        }

        return TypeItem.Mouse;
    }

    public BasicStats GetBasicItemStats(TypeItem itemType)
    {
        foreach (ItemStats info in itemStats)
        {
            if (info.item == itemType)
            {
                return info.basicStats;
            }
        }

        return itemStats[0].basicStats;
    }

    public static void SetItemType(TypeItem newType)
    {
        PlayerPrefs.SetInt("TypeItem", (int)newType);
    }
}
