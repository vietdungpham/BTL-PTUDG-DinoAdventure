using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        //Application.LoadLevelAsync("MAP1");
        SceneManager.LoadSceneAsync("MAP1");
        //Application.LoadLevel("MAP1");
    }
    
}
