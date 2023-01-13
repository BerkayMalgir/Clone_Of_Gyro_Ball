using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    // Reference to the button prefab
    public GameObject levelButtonPrefab;

    // Reference to the parent object where the level buttons will be instantiated
    public Transform levelButtonParent;

    void Start()
    {
        CreateLevelButtons();
    }

    // Create level buttons
    void CreateLevelButtons()
    {
        // Get the number of levels
        int levelCount = SceneManager.sceneCountInBuildSettings;

        // Loop through the number of levels
        for (int i = 0; i < levelCount; i++)
        {
            // Get the name of the level
            string levelName = SceneUtility.GetScenePathByBuildIndex(i).Split('/')[SceneUtility.GetScenePathByBuildIndex(i).Split('/').Length - 1].Replace(".unity", "");

            // Instantiate a button
            GameObject levelButton = Instantiate(levelButtonPrefab, levelButtonParent);
            levelButton.GetComponentInChildren<UnityEngine.UI.Text>().text = levelName;
            int levelIndex = i;
            levelButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(()=>LoadLevel(levelIndex));
        }
    }

    // load level
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}