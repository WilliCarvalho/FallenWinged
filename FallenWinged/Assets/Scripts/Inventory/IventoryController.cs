using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IventoryController : MonoBehaviour
{
    public List<ItemBase> inventoryItems;
    public static IventoryController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //add item in the iventor
    public void AddItemToIventory (ItemBase item)
    {
        inventoryItems.Add(item);
        item.gameObject.SetActive(false);
    }
}
