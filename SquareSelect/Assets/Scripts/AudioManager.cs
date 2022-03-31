using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _buttonSound, _jumpSound, _backgroundSound;
    public static AudioManager Instance;
    public UnityEvent onButtonClicked, onPlayerJumped;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        DontDestroyOnLoad(this);
        onButtonClicked.AddListener(delegate
        {
            _buttonSound.Play();
        });
        onPlayerJumped.AddListener(delegate
        {
            _jumpSound.Play();
        });
    }

    // Start is called before the first frame update
    void Start()
    {
        _backgroundSound.playOnAwake = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
