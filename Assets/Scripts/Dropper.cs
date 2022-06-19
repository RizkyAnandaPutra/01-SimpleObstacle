using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    
    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            Debug.Log("3 seconds has elapsed");
        }
        
    }
}
