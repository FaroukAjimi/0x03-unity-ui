using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public Button play;
    public Button quit;
    public void PlayMaze(){
        SceneManager.LoadScene("maze");
    }
    public void QuitMaze(){
        Debug.Log("Quit Game");
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(PlayMaze);
        quit.onClick.AddListener(QuitMaze);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
