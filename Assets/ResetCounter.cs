using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("WrongAnswer", 0);
        Destroy(this);
    }
}
