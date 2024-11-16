using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task3 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collison Occur");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("collision occured");
    }
}
