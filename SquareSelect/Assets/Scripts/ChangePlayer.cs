using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cinemachine;

public class ChangePlayer : MonoBehaviour
{
    private CinemachineVirtualCamera cam;
    private Transform totalChild;
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
        detachAllConnectedPlayers();
        for(int i=0;i<transform.childCount;i++)
        {

            if(i!=index)
            {
                Movement m = transform.GetChild(i).GetComponent<Movement>();
                m.enabled = false;
                m.gameObject.tag = "Untagged";
            }
            else
            {
                Movement m = transform.GetChild(i).GetComponent<Movement>();
                m.enabled = true;
                cam.Follow=m.transform;
                m.tag = "Player";

            }
        }
      
    }
    private void detachAllConnectedPlayers()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child=transform.GetChild(i);
            if(child.childCount-1==2)
            {
                child.GetChild(2).transform.parent = transform;
                
            }
        }
    }
    public GameObject getActivePlayer()
    {
        for (int i = 0; i < transform.childCount; i++)
        {

            
                Movement m = transform.GetChild(i).GetComponent<Movement>();
                if(m.enabled==true)
            {
                return m.gameObject;
            }
            
        }
        return null;
    }
}
