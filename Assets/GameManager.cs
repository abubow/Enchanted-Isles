using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Change To GameScene
    public void ChangeToGameScene()
    {
        // log button click
        Debug.Log("Button Clicked");

        // load scene
        SceneManager.LoadScene("GameScene");
    }

    // QuitGame
    public void ChangeToQuitGame()
    {
        Application.Quit();
    }
}
