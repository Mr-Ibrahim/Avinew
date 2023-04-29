using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayAndOpen : MonoBehaviour
{
    [SerializeField]
    string LoadScene;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Navigate",0.5f);
    }
    public void Navigate()
    {
        SceneManager.LoadScene(LoadScene);
    }

}
