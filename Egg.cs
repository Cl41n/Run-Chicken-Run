using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public GameObject chickenController;
    public GameObject myPrefab;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(myPrefab, transform.position, Quaternion.identity);
            chickenController.GetComponent<ChickenManager>().ChickenController();
            Destroy(this.gameObject);
        }

    }
}
