using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoHome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("gotoHome",3f);
    }

    public void gotoHome()
    {

        SceneManager.LoadScene("Home");
    }
}
