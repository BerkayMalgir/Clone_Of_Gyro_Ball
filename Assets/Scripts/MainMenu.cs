using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelSelectionMenu;

    private void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        levelSelectionMenu.SetActive(false);
    }

    public void ShowLevelSelectionMenu()
    {
        mainMenu.SetActive(false);
        levelSelectionMenu.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadLevelScene(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}