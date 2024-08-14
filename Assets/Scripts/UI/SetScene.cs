using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace levels
{
    public class SetScene : MonoBehaviour
    {
        [SerializeField]private int SceneIndex;
        int unlockedDef = 1;
        NextLevel nextLevel;
        public void LoadScene()
        {
            //if (unlockedDef >= 1) {
            //    SceneManager.LoadScene(unlockedDef);
            //}
            //int unlocked = nextLevel.GetUnlocked();
            //if (unlocked >= 2)
            //{
            //    SceneManager.LoadScene(unlocked);
            //}
            //if (unlocked >= 3)
            //{
            //    SceneManager.LoadScene(unlocked);
            //}
            SceneManager.LoadScene(SceneIndex);
        }
    }
}

