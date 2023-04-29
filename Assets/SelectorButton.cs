using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorButton : MonoBehaviour
{
    [SerializeField]
    public GameObject Red;
    [SerializeField]
    public GameObject Green;
    [SerializeField]
    public SelectorButton myObject;

    [SerializeField]
    public enum options {none, Chicken,Earth,Safe,Thumb };
    public options Selectedoptions;
    public bool DisableClick;
    // Start is called before the first frame update
    void Start()
    {
        myObject = this;
        Red= this.transform.Find("red").GetComponent<Transform>().gameObject;
        Green= this.transform.Find("Green").GetComponent<Transform>().gameObject;
        Red.SetActive(false);
        Green.SetActive(false);
        //Green=new Get
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void isSelected()
    {
        if (!DisableClick)
        {
            bool result=false;
            DisableClick= true;
            result = GameController.instance.SelectedItem(myObject,Red,Green,Selectedoptions);
            Debug.Log(result);
            if (result)
            {
                Green.SetActive(true);
            }
            else
            {
                Red.SetActive(true);
                reset();
            }
        }


    }
    public void reset()
    {
        Invoke("resetAfterDelay",0.5f);
    }
    public void resetAfterDelay()
    {
        Green.SetActive(false);
        Red.SetActive(false);
        DisableClick = false;
    }

}
