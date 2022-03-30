using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UnityEvent onGameStart, OnGameEnd, OnGameWin;
    private void Awake()
    {
        if(instance == null)
        instance = this;
    }
    private void addListenerToUnityEvents()
    {
        onGameStart.AddListener(delegate {
        startGame();
        });
        OnGameEnd.AddListener(delegate {
            endGame();
        });
    }
    // Start is called before the first frame update
    void Start()
    {
        addListenerToUnityEvents();
    }
    private void startGame()
    {

    }
    public void endGame()
    {
        Debug.Log("Nice One");
        Invoke("LoadScene", 2f);

    }
    private void OnEnable()
    {
        UiManager.instance.ChangePanel(UiManager.uiPanel.InGameUI);
        onGameStart?.Invoke();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void win()
    {

    }
    void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
