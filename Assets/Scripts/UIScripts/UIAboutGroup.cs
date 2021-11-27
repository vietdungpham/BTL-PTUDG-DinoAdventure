using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAboutGroup : UIBase
{
    public void OnClickClose()
    {
        UIManager.HideAllUI();
        UIManager.UIMenu.Show();
    }
}
