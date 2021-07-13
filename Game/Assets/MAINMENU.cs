using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour
{
    public GameObject loadingScreen;

  public void nextlvl(int _sceneNumber )
    {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene(_sceneNumber);
    }
 

}
