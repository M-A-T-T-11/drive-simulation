using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public void OnPlaySubmit()
    {
        SceneManager.LoadScene(1);
    }
    public void OnSettingsSubmit()
    {
        SceneManager.LoadScene(2);
    }

    public void OnExitPressed()
    {
        Application.Quit();
    }

    public void OnGithubClick()
    {
        Application.OpenURL("https://github.com/team1389/drive-simulation");
    }

    public void OnTeamLinkClick()
    {
        Application.OpenURL("https://team1389.org");
    }
}
