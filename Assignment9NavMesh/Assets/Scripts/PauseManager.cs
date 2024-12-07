using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
		 * Fox Weymouth
		 * Assignment9NavMesh
		 * Assignemnt 9
		 * This code runs the pause menu.
		 */
public class PauseManager : MonoBehaviour
{
    // Reference to the pause menu Canvas and buttons
    public GameObject pauseMenuUI;
    public Button unpauseButton;
    public Button menuButton;

    private bool isPaused = false;

    void Start()
    {
        // Make sure the pause menu is hidden initially
        pauseMenuUI.SetActive(false);

        // Add button listeners
        unpauseButton.onClick.AddListener(Unpause);
        menuButton.onClick.AddListener(GoToMenu);
    }

    void Update()
    {
        // Toggle pause menu when Escape is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Unpause();
            }
            else
            {
                Pause();
            }
        }
    }

    // Pauses the game and shows the pause menu
    void Pause()
    {
        isPaused = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Freeze the game time
    }

    // Unpauses the game and hides the pause menu
    void Unpause()
    {
        isPaused = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Resume game time
    }

    // Goes to the menu scene (Scene 6 in your case)
    void GoToMenu()
    {
        Time.timeScale = 1f; // Ensure the time scale is normal when switching scenes
        SceneManager.LoadScene(6); // Assuming Scene 6 is your menu scene
    }
}
