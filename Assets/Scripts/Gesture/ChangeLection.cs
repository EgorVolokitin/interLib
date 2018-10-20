using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLection : MonoBehaviour
{
    public GameObject settedLection;
    public GameObject settedElement;
    public GameObject settedElement2;

    public GameObject removedLection;
    public GameObject removedLection2;
    public GameObject removed1;
    public GameObject removed2;

    void OnSelect()
    {
        removedLection.SetActive(false);
        removedLection2.SetActive(false);
        removed1.SetActive(false);
        removed2.SetActive(false);

        settedLection.SetActive(true);
        settedElement.SetActive(true);

        if(settedElement2 != null)
        {
            settedElement2.SetActive(true);
        }
    }
}
