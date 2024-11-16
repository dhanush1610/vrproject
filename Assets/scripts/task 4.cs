using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task4 : MonoBehaviour
{
    public GameObject y;
    private void OnCollisionEnter(Collision collision)
    {
        y.SetActive(true);
        
    }
    private void OnCollisionExit(Collision collision)
    {
        y.SetActive(false);
    }
}


