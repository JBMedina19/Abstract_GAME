using System.Collections.Generic;
using System.Collections;
using UnityEngine;

[System.Serializable]
public struct Item
{
    public string Name;
    public int itemID;
    public int Quantity;

    public Item(string name, int id, int quantity = 1)
    {
        Name = name;
        itemID = id;
        Quantity = quantity;
    }
}
