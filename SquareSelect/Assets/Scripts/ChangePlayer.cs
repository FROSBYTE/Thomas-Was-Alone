using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cinemachine;

public class ChangePlayer : MonoBehaviour
{
    private CinemachineVirtualCamera cam;
    // Start is called before the first frame update
    
    void Start()
    {
        cam=GameObject.FindGameObjectWithTag("camera").GetComponent<CinemachineVirtualCamera>();
        changePlayer(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changePlayer(int index)
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
                cam.Follow=m.transform;
            }
        }
      
    }
}
