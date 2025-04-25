using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject mainMenuScene;
    public GameObject settingsMenuScene;
    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void goToSettingsMenu()
    {

        if (!settingsMenuScene.activeSelf)
            settingsMenuScene.SetActive(true);
    }

    public void goToMainMenu()
    {

        if (!mainMenuScene.activeSelf)
            mainMenuScene.SetActive(true);
    }

}
