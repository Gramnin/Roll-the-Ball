using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
    public void NewScene(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
