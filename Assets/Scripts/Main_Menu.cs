using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    #region Self Veriables
    public GameObject MainMenu;
    public GameObject LevelMenu;
    public  GameObject Canvas;

    #endregion
    private void Start()
    {
        ShowMainMenu();
        
    }

    private void ShowMainMenu()
    {
        MainMenu.SetActive(true);
        Canvas.SetActive(true);
        
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LoadLevelScene()
    {
        MainMenu.SetActive(false);
        LevelMenu.SetActive(true);
    }
}