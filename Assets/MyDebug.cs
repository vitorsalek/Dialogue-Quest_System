using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDebug : MonoBehaviour
{
    public MyInventoryItem item;
    private void Start()
    {
        Shoot();
    }
    private void Shoot()
    {
        Debug.Log($"I have {item.name} that {item.description}.");
    }
}
