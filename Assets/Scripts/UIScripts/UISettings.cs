using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISettings : UIBase
{
    public void OnClickClose()
    {
        UIManager.HideAllUI();
        if (UIManager.GAMESTATE == GameState.MenuShowing)
            UIManager.UIMenu.Show();
        else if (UIManager.GAMESTATE == GameState.GamePause)
            UIManager.UIGamePlay.Show();
    }
}
