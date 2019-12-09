using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireflyDisband : MonoBehaviour
{
    private GameObject flies;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        flies = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //Ray eller collision
    }
}
