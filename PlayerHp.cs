using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    public int hp;
    public float imunTime;
    public Image hp2;
    public Image hp3;

    private bool hited;

    private float lastTime;
    // Start is called before the first frame update
    void Start()
    {
        hited = false;
        hp = 3;
    }

    private void Update()
    {
        if (Time.time > lastTime + imunTime)
        {
            hited = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trap") && !hited)
        {
            hited = true;
            lastTime = Time.time;
            hp--;
            Debug.Log(lastTime);

            if (hp == 2)
            {
                Destroy(hp3);
            }

            if (hp == 1)
            {
                Destroy(hp2);
            }

            if (hp <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        
    }
}
