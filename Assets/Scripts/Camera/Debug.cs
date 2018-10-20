using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug : MonoBehaviour {
    private float _yaw = 0.0f;
    private float _pitch = 0.0f;

    public float Speed = 2f;
    public float SpeedH = 2.0f;
    public float SpeedV = 2.0f;

    // Use this for initialization
    void Start () {
		
	}

#if UNITY_EDITOR
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += transform.forward * Speed * Time.deltaTime * -1f;
        if (Input.GetKey(KeyCode.A))
            transform.position += transform.right * Speed * Time.deltaTime * -1f;
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.E))
            transform.position += transform.up * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Q))
            transform.position += transform.up * Speed * Time.deltaTime * -1f;

        _yaw += SpeedH * Input.GetAxis("Mouse X");
        _pitch -= SpeedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(_pitch, _yaw, 0.0f);
    }
#endif
}
