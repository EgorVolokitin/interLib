using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNaOH : MonoBehaviour {
    public GameObject removedObject;
    public GameObject settedObject;

    // Use this for initialization
    void Start () {
        //gm2.SetActive(false);
    }

    

    void OnSelect()
    {
        removedObject.SetActive(false);
        settedObject.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
