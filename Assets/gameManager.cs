using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

    public Scene Lose;
    public Button play;
    public Button exit;
    public bool bricklevel = true;
    public int CurrentScene;
    public static bool isMusicPlaying;

    public void nextScene() {
        SceneManager.LoadScene(CurrentScene+1);
    }

    public void changeScenetoMenu() {
        SceneManager.LoadScene(0);
        CurrentScene = 0;
        brick.numberOfBricks = 0;
    }

    public void Quit()
    {
        Application.Quit();
    }


    // Use this for initialization
    void Start () {
        GameObject.FindGameObjectWithTag("music").GetComponent<musicman>().PlayMusic();
    }
	
	// Update is called once per frame
	void Update () {


        if (bricklevel && brick.numberOfBricks == 0) { nextScene(); }
	}



}
