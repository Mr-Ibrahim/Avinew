using UnityEngine;
using UnityEngine.SceneManagement;

public class EnhertuUIController : MonoBehaviour
{
    public static EnhertuUIController _instance;

    // Use this for initialization
    void Start()
    {
        _instance = this;
    }

    public void goToGame()
    {
        Debug.Log("Goto Game");
        SceneManager.LoadScene("Game");
    }
    public void goToHome()
    {
        SceneManager.LoadScene("Home");
    }
    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void goToNewlyIdentifiedPatients()
    {
        SceneManager.LoadScene("NewlyIdentifiedPatients");
    }

    public void goToStudyDesign()
    {
        SceneManager.LoadScene("StudyDesign");
    }

    public void goToPrimaryEndpoint()
    {
        SceneManager.LoadScene("PrimaryEndpoint");
    }
    public void goToOverallSurvival()
    {
        SceneManager.LoadScene("OverallSurvival");
    }

    public void OverallSurvival()
    {
        SceneManager.LoadScene("OverallSurvival");
    }
    public void goToExploratoryEndpoint()
    {
        SceneManager.LoadScene("ExploratoryEndpoint");
    }

    public void goToSummary()
    {
        SceneManager.LoadScene("Summary");
    }
}
