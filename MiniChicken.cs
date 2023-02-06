using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniChicken : MonoBehaviour
{
    public GameObject chickenManager;
    // Start is called before the first frame update

    private void Start()
    {
        var a = GameObject.FindGameObjectsWithTag("ChickenManager");
        chickenManager = a[0];
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trap"))
        {
            
            Destroy(this);
            Destroy(this.gameObject);
           
            
        }
    }
}
