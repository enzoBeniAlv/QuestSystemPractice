using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ItemManager : MonoBehaviour {

    

    void Start() {
        List<ItemSO> items = MyAssetFinder.FindAll<ItemSO>("Assets/Items");
        foreach (ItemSO item in items)
        {
            Debug.Log(item);
        }
    }

}