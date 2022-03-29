using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexPlayers : MonoBehaviour
{
    private int totalChild;
    private void Awake()
    {
        totalChild = transform.childCount;
        for (int i = 0; i < totalChild; i++)
        {
            SelectPlayer s = transform.GetChild(i).GetComponent<SelectPlayer>();
            s.changeIndex(value:i);
        }
    }
  
}
