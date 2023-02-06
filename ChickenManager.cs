using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class ChickenManager : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> chickensGO;
    public List<FollowPlayer> chickens;
    public int followDistance;

    private int count;
    public int chickenCount;
    void Start()
    {
        
        ChickenController();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var chick in chickens)
        {
            if (chick == null)
            {
                ChickenController();
            }
        }
       
        
    }

    public void ChickenController()
    {
        
        chickensGO.Clear();
        chickens.Clear();
        count = 0;
        var chicken = GameObject.FindGameObjectsWithTag("FollowChicken");
       
        for (int i = 0; i < chicken.Length; i++)
        {
            
            var chickenScript = chicken[i].GetComponent<FollowPlayer>();

            chickensGO.Add(chicken[i]);
            chickens.Add(chickenScript);
           
            
        }
        
        foreach (var chick in chickens)
        {
            
            if (count == 0)
            {
                chick.player = player;
            }
            else
            {
                chick.player = chickensGO[count-1];
            }
            chick.followDistance = followDistance;
           
            count++;
        }
        
        chickenCount = chickens.Count;
        
        
    }

    
}
