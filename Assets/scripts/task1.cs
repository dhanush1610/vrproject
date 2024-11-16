using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject x, y, z;
    bool a;
    int index;
    // Start is called before the first frame update
    void Start()
    {


        InvokeRepeating("light_control", 0, 1);
    }
       
    // Update is called once per frame
    void light_control()
    {
            switch (index)
            {
                case 0:
                    x.SetActive(true);
                    y.SetActive(false);
                    z.SetActive(false);
                    break;
                case 1:
                    x.SetActive(false);
                    y.SetActive(true);
                    z.SetActive(false);

                    break;
                case 2:
                    x.SetActive(false);
                    y.SetActive(false);
                    z.SetActive(true);

                    break;
            

            }
            index = (index + 1) % 3;
            
    }
}
