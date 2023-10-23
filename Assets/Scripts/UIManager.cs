using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject startScreen;

    public void ResetGame()
    {
        SceneManager.LoadScene("GameScene"); // loads the game scene again with start screen
    }

    public void StartGame()
    {
        startScreen.SetActive(false); // turns off start screen
        Time.timeScale = 1; // starts the game again
    }
}
