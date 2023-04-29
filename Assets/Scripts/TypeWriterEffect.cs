using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class TypeWriterEffect : MonoBehaviour
{
    public TMP_Text text;
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";
    [SerializeField]
    GameObject MoveTo;
    [SerializeField]
    bool IsRequiredToMove = false;

    // Use this for initialization
    void Start()
    {
        text.text = "";
        StartCoroutine(ShowText());
    }
    void Update()
    {
        if (MoveTo != null)
        {
            if (IsRequiredToMove && text.text==fullText)
            {
              MoveTo.SetActive(true); 
            }
        }
    }
    void OnEnable()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = currentText.Length; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            text.text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}
