using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
		 * Fox Weymouth
		 * Assignment9NavMesh
		 * Assignemnt 9
		 * This code runs the main menu.
		 */

public class MainMenuManager : MonoBehaviour
{
    public Button button1, button2, button3, button4, button5, button6;

    // Start is called before the first frame update
    void Start()
    {
        // Attach button click listeners
        button1.onClick.AddListener(() => LoadScene(0));  // Load Scene 1 (index 1)
        button2.onClick.AddListener(() => LoadScene(1));  // Load Scene 2 (index 2)
        button3.onClick.AddListener(() => LoadScene(2));  // Load Scene 3 (index 3)
        button4.onClick.AddListener(() => LoadScene(3));  // Load Scene 4 (index 4)
        button5.onClick.AddListener(() => LoadScene(4));  // Load Scene 5 (index 5)
        button6.onClick.AddListener(() => LoadScene(5));  // Load Scene 6 (index 6)
    }

    // Method to load the scene by index
    void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}