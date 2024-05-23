using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManager : MonoBehaviour
{
    private GameObject Spikes;
    
    void Start()
    {
        Spikes = GameObject.FindGameObjectWithTag("Spikes Trap");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
