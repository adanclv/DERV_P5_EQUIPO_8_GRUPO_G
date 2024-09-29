using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replace : MonoBehaviour
{
    Transform replacePosition;

    private void Awake()
    {
        replacePosition = GameObject.Find("Spawn").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.name == "ReplacePosition")
            {
                other.gameObject.transform.position = replacePosition.position;
            }
        }
    }
}
