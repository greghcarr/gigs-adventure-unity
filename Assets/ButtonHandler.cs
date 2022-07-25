using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public void SetText(string text)
    {
        //Text txt = transform.Find("Button_Test_Text").GetComponent<Text>();

        if (transform.Find("Button_Test_Text"))
        {
            Debug.Log("Made it");
            Debug.Log("Found: " + transform.Find("Button_Test_Text"));
        }
        else
        {
            Debug.Log("Didn't make it");
        }

        //txt.text = "Poop";
        //Debug.Log(txt.text);
    }
}
