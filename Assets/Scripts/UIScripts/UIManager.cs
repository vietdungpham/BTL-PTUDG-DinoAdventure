using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] UIMenu uiMenu;
    [SerializeField] UISettings uiSettings;
    [SerializeField] UIAboutGroup uiAboutGroup;
    [SerializeField] UIGamePlay uIGamePlay;
    private GameState gameState;

    public static UIManager Instance;

    public static UIMenu UIMenu => Instance.uiMenu;
    public static UISettings UISettings => Instance.uiSettings;
    public static UIAboutGroup UIAboutGroup => Instance.uiAboutGroup;
    public static UIGamePlay UIGamePlay => Instance.uIGamePlay;
    public static GameState GAMESTATE { get; set; }

    public void Awake()
    {
        Instance = this;
    }

    public static void HideAllUI()
    {
        UIMenu.Hide();
        UISettings.Hide();
        UIAboutGroup.Hide();
    }
}
public enum GameState
{
    MenuShowing,
    GamePause,
    Playing
}
