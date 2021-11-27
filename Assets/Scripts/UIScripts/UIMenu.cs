using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : UIBase
{
    public void OnEnable()
    {
        UIManager.GAMESTATE = GameState.MenuShowing;
    }

    public void OnClickStart()
    {
        SceneManager.LoadSceneAsync("MAP1");
    }

    public void OnClickSettings()
    {
        UIManager.HideAllUI();
        UIManager.UISettings.Show();
    }

    public void OnClickAbout()
    {
        UIManager.HideAllUI();
        UIManager.UIAboutGroup.Show();
    }
}
