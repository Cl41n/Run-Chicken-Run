using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public GameObject GO;
    private int rescuedChickens;
    public Image chicken1;
    public Image chicken2;
    public Image chicken3;
    public Image chicken4;
    public Button nextLevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
            rescuedChickens = GameObject.Find("Chicken Manager").GetComponent<ChickenManager>().chickenCount;
            GameObject.Find("UI").SetActive(false);
            GameObject.Find("Player").SetActive(false);
            GO.SetActive(true);
            
            

            if (rescuedChickens == 3)
            {
                Destroy(chicken4);
            }
            
            if (rescuedChickens == 2)
            {
                Destroy(chicken4);
                Destroy(chicken3);
            }
            
            if (rescuedChickens == 1)
            {
                Destroy(chicken4);
                Destroy(chicken3);
                Destroy(chicken2);
            }
            
            if (rescuedChickens == 0)
            {
                Destroy(chicken4);
                Destroy(chicken3);
                Destroy(chicken2);
                Destroy(chicken1);
                GameObject.Find("NextLevel").SetActive(false);
            }
        }
        
    }

    
}
