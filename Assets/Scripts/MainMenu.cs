using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;
    public Button play;
    public Button quit;
    public void PlayMaze(){
        SceneManager.LoadScene("maze");
        if (colorblindMode.isOn == true)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
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
