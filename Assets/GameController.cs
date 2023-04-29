using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static SelectorButton;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public SelectorButton[] selectedItems;
    public int selectedItemIndex=0;
    public int WinnedItemIndex = 0;
    public options currentOptions;
    public options LastWinnedOPtions;

    public GameObject ChickenWin;
    public GameObject EarthWin;

    public GameObject SafeWin;

    public GameObject ThumbWin;
    public GameObject EndPanel;


    // music 


    public AudioSource Audio_Source;
    public AudioClip wrongAnswer;
    public AudioClip RightAnswer;
    public AudioClip EndGameSound;
    public void Awake()
    {
        selectedItems = new SelectorButton[4];
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedItemIndex > 3)
        {
            DisplayWin(currentOptions);
            selectedItemIndex = 0;
            currentOptions = options.none;
            WinnedItemIndex++;
            WinSoundeffect();
            Invoke("AfterWin", 1f);

        }
    }

    public bool SelectedItem(SelectorButton Object,GameObject Red, GameObject Green, options selectedOptions)
    {
        if(selectedOptions != currentOptions && selectedItemIndex > 0)
        {
            for (int i=0;i<selectedItemIndex;i++)
            {
                selectedItems[i].reset();
            }
            selectedItemIndex = 0;
            currentOptions = options.none;
            LoseSoundeffect();
            return false;
        }
        else if (selectedItemIndex == 0)
        {
            currentOptions= selectedOptions;
            selectedItems[selectedItemIndex] = Object;
            selectedItemIndex++;
            return true;

        }
        else if(selectedOptions == currentOptions)
        {
            selectedItems[selectedItemIndex] = Object;
            selectedItemIndex++;
            return true;
        }
        return false;

    }
    public void DisplayWin(options WinnedOption)
    {
        LastWinnedOPtions = WinnedOption;
        if (WinnedOption== options.Chicken)
        {
            ChickenWin.SetActive(true);

        }
        if (WinnedOption == options.Earth)
        {
            EarthWin.SetActive(true);

        }
        if (WinnedOption == options.Safe)
        {
            SafeWin.SetActive(true);

        }
        if (WinnedOption == options.Thumb)
        {
            ThumbWin.SetActive(true);

        }
    }

    public void AfterWin()
    {
        if (LastWinnedOPtions == options.Chicken)
        {
            ChickenWin.SetActive(false);

        }
        if (LastWinnedOPtions == options.Earth)
        {
            EarthWin.SetActive(false);

        }
        if (LastWinnedOPtions == options.Safe)
        {
            SafeWin.SetActive(false);

        }
        if (LastWinnedOPtions == options.Thumb)
        {
            ThumbWin.SetActive(false);

        }
        LastWinnedOPtions = options.none;

        if (WinnedItemIndex > 3)
        {
            //End Game
            EndGame();  
        }
    }

    public void EndGame()
    {
        EndPanel.SetActive(true);
        EndGameSoundeffect();
        Invoke("GotoMenu", 5f);

    }
    public void GotoMenu()
    {
        SceneManager.LoadScene("Home");
    }


    public void WinSoundeffect()
    {
        Audio_Source.PlayOneShot(EndGameSound);
    }


    public void LoseSoundeffect()
    {

        Audio_Source.PlayOneShot(wrongAnswer);
    }
    public void EndGameSoundeffect()
    {

        Audio_Source.PlayOneShot(RightAnswer);
    }
}
