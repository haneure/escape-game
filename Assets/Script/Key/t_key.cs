using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t_key : MonoBehaviour
{
    public Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pickUp(GameObject item) {
        inventory.insertToInventory(item);
    }
}
