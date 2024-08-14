using levels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class NextLevel : MonoBehaviour
{
    [SerializeField] int nextLevel;
    [SerializeField] GameObject NextLevelUI;
    public int unlocked = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0;
            NextLevelUI.SetActive(true);
            //SceneManager.LoadScene(nextLevel);
            //unlocked = nextLevel;
        }
    }
    public int GetUnlocked() { return unlocked; }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
