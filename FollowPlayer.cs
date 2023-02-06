using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class FollowPlayer : MonoBehaviour
{
    public GameObject player; 
    public int followDistance;
    private List<Vector3> storedPositions;
    private List<Quaternion> storedRotation;

    void Awake()
    {
        storedPositions = new List<Vector3>(); 
        storedRotation = new List<Quaternion>();
    }
 
 
    void Update()
    {
        if(storedPositions.Count == 0)
        {
            storedRotation.Add(player.transform.rotation);
            storedPositions.Add(player.transform.position); 
            return;
        }else if (storedPositions[storedPositions.Count -1] != player.transform.position)
        {
            //Debug.Log("Add to list");
            storedPositions.Add(player.transform.position); 
            storedRotation.Add(player.transform.rotation);
        }
 
        if (storedPositions.Count > followDistance)
        {
            transform.position = storedPositions[0];
            transform.rotation = storedRotation[0];
            storedPositions.RemoveAt(0); 
            storedRotation.RemoveAt(0);
            
            
        }
    }
}