using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void player(int index)
    {
        for(int i=0;i<transform.childCount;i++)
        {

            if(i!=index)
            {
                Movement m = transform.GetChild(i).GetComponent<Movement>();
                m.enabled = false;
            }
            else
            {
                Movement m = transform.GetChild(i).GetComponent<Movement>();
                m.enabled = true;
            }
        }
      
    }
}
