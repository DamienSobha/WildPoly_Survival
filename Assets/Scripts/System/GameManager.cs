using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InventoryManager inventoryManager;
    public static GameObject Game_Manager;

    public InventoryManager GetInventoryManager {  get { return inventoryManager; } }   

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Game_Manager = gameObject;

        inventoryManager = GetComponent<InventoryManager>();
    }


    
}
