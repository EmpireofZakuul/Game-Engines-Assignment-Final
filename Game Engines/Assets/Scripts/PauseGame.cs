using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    //InputManager inputManager;

    
   // public GameObject Keys;
   // public GameObject SettingsGame;
    public bool Paused = false;
    public GameObject PauseMenuUI;
   // public GameObject health;
   // public GameObject keymenu;
   // public GameObject menu;
    //public GameObject settings;

    public void Awake()
    {
        Pause();
    }
    public void Start()
    {
        //inputManager = GameObject.FindObjectOfType<InputManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {//make sure to turn off if paused so the escape key wont work to go back into the game
            if (Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        AudioListener.pause = false;
        Cursor.lockState = CursorLockMode.Locked;
        //  health.SetActive(true);
        // keymenu.SetActive(false);
        // menu.SetActive(false);
        // settings.SetActive(false);

    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        //health.SetActive(false);
        AudioListener.pause = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void QuitGameMenu()
    {

#if UNITY_STANDALONE
        Application.Quit();
#endif

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

}
