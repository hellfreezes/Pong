using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenuController : MonoBehaviour {

	public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum + 1);
    }
}
