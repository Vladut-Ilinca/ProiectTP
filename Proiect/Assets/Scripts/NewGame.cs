using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
	public void NewGameBtn()
    {
        SceneManager.LoadScene("Terrian");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LoadGame()
    {
        SaveLoad.Load();
    }
}
