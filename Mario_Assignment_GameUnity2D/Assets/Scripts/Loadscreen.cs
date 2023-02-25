using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscreen : MonoBehaviour
{
    // cho phép nạp screen
    public void Loads(int index)
    {
        SceneManager.LoadScene(index);
    }
}
