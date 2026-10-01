using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueToLevel2 : MonoBehaviour
{
    public void LoadSecondLevel()
    {
        Debug.Log("Continue Button Clicked");
        SceneManager.LoadScene("LevelTwo");
    }
}
