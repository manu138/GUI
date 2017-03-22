using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mostrar : MonoBehaviour {
    public List<InventoryItemList> itemList;
    InventoryItem item;

    // Use this for initialization
    void Start () {
        itemList.Add( Resources.Load("InventoryItemList") as InventoryItemList);
        //  itemList.Add(Resources.Load("data") as InventoryItemList);

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(itemList);
    }
}
