using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPointer : MonoBehaviour
{
    [Header("CAMERA"), Space, Tooltip("Camera")]
    [SerializeField] private Camera cam;


    [Header("POINTER ICON"), Space, Tooltip("Array of tank modules for attaching pointer icons ")]
    [SerializeField] private Transform[] enemyMass;


    [Header("POINTER ICON"), Space, Tooltip("Array of pointer icons attached to a specific tank module ")]
    [SerializeField] private Transform[] pointerIconTransform;


    [Header("RAY COLOR"), Space]
    [SerializeField] private Color rayColor = new Color(255f / 255f, 140f / 255f, 0f / 255f);


    private Vector3 fromCamToEnemy;
    private Vector3 worldPosition;
    private Ray ray;
    private float minDistance = Mathf.Infinity;


    private void Start()
    {
        PointerMove();

    }

    private void PointerMove()
    {
        if (pointerIconTransform.Length == enemyMass.Length)
        {
            for (int i = 0; i < pointerIconTransform.Length; i++)
            {
                FromCamToEnemy(i);
                Ray();
                DrawRay();
                CalculeteMinDistance();
                PointerTransform(i);

            }
            return;
        }
        throw new Exception("Different number of modules and info points!");

    }

    private void FromCamToEnemy(int i)
    {
        fromCamToEnemy = enemyMass[i].position - cam.transform.position;
    }

    private void Ray()
    {
        ray = new Ray(cam.transform.position, fromCamToEnemy);
    }

    private void DrawRay()
    {
        Debug.DrawRay(cam.transform.position, fromCamToEnemy, rayColor);
    }

    private void CalculeteMinDistance()
    {
        minDistance = Mathf.Clamp(minDistance, 0, fromCamToEnemy.magnitude);
    }

    private void PointerTransform(int i)
    {
        worldPosition = ray.GetPoint(minDistance);
        pointerIconTransform[i].transform.position = cam.WorldToScreenPoint(worldPosition);
    }
}
