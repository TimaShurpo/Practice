using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamZoom : MonoBehaviour
{

    [Header("CAMERA"), Space]
    [SerializeField, Tooltip("camera")] Camera cam;


    [Header("FOV"), Space]
    [SerializeField, Tooltip("max angle FOV camera")] private float MaxFOV = 80;
    [SerializeField, Tooltip("min angle FOV camera")] private float MinFOV = 40;
    [SerializeField, Tooltip("start FOV camera")] private float startFOV = 60;
    [SerializeField, Tooltip("ster for change FOV camera")] private float FOVCamStep = 10; // 1


    private void Start()
    {
        cam.fieldOfView = startFOV;

    }    

    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if(cam.fieldOfView > MinFOV)
            {    
               cam.fieldOfView -= FOVCamStep;

            }
        }
        else if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if(cam.fieldOfView < MaxFOV)
            {    
                cam.fieldOfView += FOVCamStep;
            }

        }
    }


}


   




