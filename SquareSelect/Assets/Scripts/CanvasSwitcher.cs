using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CanvasSwitcher : MonoBehaviour
{
    [SerializeField]
    public Canvas inGameCanvas;
    [SerializeField]
    public Canvas infoCanvas;
    [SerializeField]
    Healthreduction healthreduction;


    private void Awake()
    {
        inGameCanvas.enabled = false;
        infoCanvas.enabled = true;
    }

    public void OnFirstClick()
    {
        inGameCanvas.enabled = true;
        infoCanvas.enabled = false;
        StartCoroutine(healthreduction.DeductionofPlayerHealth());
       
    }
}
