using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void ChangeScenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
        // SceneTransition.SwitchToScene(numberScenes);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
