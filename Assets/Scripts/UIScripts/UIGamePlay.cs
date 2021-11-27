using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGamePlay : UIBase
{
    public void OnEnable()
    {
        UIManager.GAMESTATE = GameState.Playing;
    }

    public void OnClickSettings()
    {

    }
}
