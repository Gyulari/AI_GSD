using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    RayGenerator rayGenerator;

    void Start()
    {
        rayGenerator = GameObject.Find("Gun").GetComponent<RayGenerator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Shoot");
            rayGenerator.RayGenerate();
        }
    }
}
