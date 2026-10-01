using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameScript : MonoBehaviour
{
    public void LoadFirstLevel()
    {
        Debug.Log("Start Game Button Clicked");
        SceneManager.LoadScene("LevelOne");
    }
}