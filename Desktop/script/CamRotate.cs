using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    [Header("TIMER")]
    [SerializeField] private float timeBeforeRotation;
    private float time;

    [Header("MOUSE")]
    [SerializeField] private float speedFreeRotation;

    private Quaternion rotation;
    private float mouseX;

    private void Start()
    {   
        time = 0;
        rotation = Quaternion.AngleAxis(speedFreeRotation, Vector3.up);

    }

    private void Update()
    {
        FreeRotate();
        MouseRotate();

    }

    private void FreeRotate()
    {
        time += Time.deltaTime;
        if (time >= timeBeforeRotation)
        {
            transform.localRotation *=  rotation;
        }

    }

    private void MouseRotate()
    {
        if (Input.GetKey(KeyCode.Mouse1))   
        {
            time = 0;
            mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(0, mouseX, 0);
           
        }

    }
}
