using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    #region Self Veriables
  
    public GameObject levelButton1;
    public GameObject levelButton2;
    public GameObject levelButton3;
    public Transform backButton;
    public  GameObject MainMenu;
    public  GameObject LevelMenu;
    public  GameObject Canvas;
 
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    
    #endregion
    
    public void BackButton()
    {
        MainMenu.SetActive(true);
        LevelMenu.SetActive(false);
    }
    
    public void Level1()
    {
        MainMenu.SetActive(false);
        LevelMenu.SetActive(false);
        Canvas.SetActive(false);
        Instantiate(level1,Vector3.zero, Quaternion.identity);
    }
    public void Level2()
    {
        MainMenu.SetActive(false);
        LevelMenu.SetActive(false);
        Canvas.SetActive(false);
        Instantiate(level2, Vector3.zero, Quaternion.identity);
    }
    public void Level3()
    {
        MainMenu.SetActive(false);
        LevelMenu.SetActive(false);
        Canvas.SetActive(false);
        Instantiate(level3, Vector3.zero, Quaternion.identity);
    }

    
    
}