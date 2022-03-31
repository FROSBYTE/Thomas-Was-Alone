using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonClick : MonoBehaviour
{
    private Button btn;
    private void OnEnable()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate
        {
            AudioManager.Instance.onButtonClicked?.Invoke();
        });
    }
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate
        {
            AudioManager.Instance.onButtonClicked?.Invoke();
        });
    }

}