using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void ResetGame()
    {
        SceneManager.LoadScene("StartScene"); // loads the game scene again with start screen
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // loads the game scene again with start screen
    }
}
