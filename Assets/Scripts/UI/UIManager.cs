using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject PauseScreen;
    [SerializeField] private AudioClip gameOverSound;
    public bool dead = false;

    private void Awake()
    {
        gameOverScreen.SetActive(false);
        PauseScreen.SetActive(false);
        Unpause();
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) { Pause();}
    }

    #region Game Over Functions
    //Game over function
    public void GameOver()
    {
        dead = true;
        gameOverScreen.SetActive(true);
        SoundManager.instance.PlaySound(gameOverSound);
    }

    //Restart level
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //Activate game over screen
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //Quit game/exit play mode if in Editor
    public void Quit()
    {
        Application.Quit(); //Quits the game (only works in build)

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //Exits play mode
        #endif
    }
    public void Pause()
    {
        if (!dead)
        {
            Time.timeScale = 0;
            PauseScreen.SetActive(true);
        }
    }
    public void Unpause() { Time.timeScale = 1; }
    #endregion
}