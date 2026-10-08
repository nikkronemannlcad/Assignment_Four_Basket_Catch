using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToMenu : MonoBehaviour
{
    public void LoadMainMenu()
    {
        Debug.Log("Main Menu Button Clicked");
        SceneManager.LoadScene("Main Menu");
    }
}
