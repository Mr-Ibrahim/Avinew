using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Correct_Answer_Script : MonoBehaviour
{
    public GameObject NextLevel;
    public GameObject PuzzlePieace_Green;
    public GameObject PuzzlePieace;
    public GameObject ThisLevel;
    public GameObject GameOverScren;
    public AudioSource WinSoundEffect;
    public AudioSource LoseSoundEffect;
    public bool isThisWrongButton;


    public void Start()
    {
        ActivateonCorrectAnswer();
    }
    public void ActivateonCorrectAnswer()
    {
        if (isThisWrongButton)
        {
            LoseSoundEffect.Play();
            Invoke("DelayActivateonWrongAnswer", 2f);

        }
        else
        {
            WinSoundEffect.Play();
            Invoke("DelayActivateonCorrectAnswer", 2f);

        }

    }

    public void DelayActivateonCorrectAnswer()
    {
        NextLevel.SetActive(true);
        ThisLevel.SetActive(false);
        PuzzlePieace.SetActive(false);
        PuzzlePieace_Green.SetActive(false);

    }



    public void DelayActivateonWrongAnswer()
    {
        int WrongAnswerVount = PlayerPrefs.GetInt("WrongAnswer") + 1;
        PlayerPrefs.SetInt("WrongAnswer", WrongAnswerVount);
        if (WrongAnswerVount >3)
        {
            GameOverScren.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);

        }
       

    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("Home");
    }
}
