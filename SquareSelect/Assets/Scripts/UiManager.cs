using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    public enum uiPanel
    {
       // MenuUI,
        InGameUI,
        pauseUI,
       // GameOverUI
    }
    
 /*   [SerializeField]
    private Button playButton;
    [SerializeField]
    GameObject mainMenu;*/
    [SerializeField]
    GameObject inGameUI;
    [SerializeField]
    GameObject pauseUI;
    uiPanel currentPanel = uiPanel.InGameUI;
    // Start is called before the first frame update
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
       
        ChangePanel(uiPanel.InGameUI);
    }
    void Start()
    {
       /* playButton.onClick.AddListener(delegate
        {
            GameManager.instance.onGameStart?.Invoke();
        });
        GameManager.instance.onGameStart.AddListener(delegate
        {
            ChangePanel(paneltoActivate: uiPanel.InGameUI);
        });*/

    }

    // Update is called once per frame
    void Update()
    {
        PausePanel();
    }

    void PausePanel()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && currentPanel == uiPanel.InGameUI)
        {
            ChangePanel(uiPanel.pauseUI);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && currentPanel == uiPanel.pauseUI)
        {
            ChangePanel(uiPanel.InGameUI);
        }

    }
    public void ChangePanel(uiPanel paneltoActivate)
    {
      /*  if(paneltoActivate == uiPanel.MenuUI)
        {
            currentPanel = uiPanel.MenuUI;
            mainMenu.SetActive(true);
            inGameUI.SetActive(false);
            pauseUI.SetActive(false);
        }*/
        if(paneltoActivate == uiPanel.InGameUI)
        {
            currentPanel=uiPanel.InGameUI;
            //mainMenu.SetActive(false);
            inGameUI.SetActive(true);
            pauseUI.SetActive(false);

        }
        else if(paneltoActivate == uiPanel.pauseUI)
        {
            currentPanel = uiPanel.pauseUI;
           // mainMenu.SetActive(false);
            inGameUI.SetActive(false);
            pauseUI.SetActive(true);


        }
        
    }
    public void LevelUp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
