using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadCurentScreen : MonoBehaviour
{
    // Nạp lại scene hiện tại
 public void ReloadScene()
    {
        if (Gamecontroler.instance.isGameOver)
        {
            Time.timeScale = 1;
            Gamecontroler.instance.isGameOver = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
