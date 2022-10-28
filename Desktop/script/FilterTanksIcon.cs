using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FilterTanksIcon : MonoBehaviour
{
    [Header("TANKS ICONS"), Space]
    [SerializeField] GameObject[] Icons;


    [Header("POINTER IN BUTTON"), Space]
    [SerializeField] Image imageInButton;


    [Header("COLOR"), Space]
    [SerializeField, Tooltip("Pointer if button filter ON")] private Color colorOn = new Color(255f/ 255f, 135f/255f, 0f/255);
    [SerializeField, Tooltip("Pointer if button filter OFF")] private Color colorOff = new Color(55f/ 255f, 55f/255f, 55f/255);


    private bool isOn;


    private void Start()
    {
        isOn = true;

    }   

    public void СheckerOnOff()
    { 
        if(isOn)
        {
            ChangeColor(colorOff);
        }
        else
        {
            ChangeColor(colorOn);
        }
        IconOnOff();
    }

    private void IconOnOff()
    {
        foreach(var icon in Icons)
        {
            icon.SetActive(!isOn);
        }
        IsOnChanger(!isOn);
    }

    private void ChangeColor(Color color)
    {
        imageInButton.color = color;

    }

    private void IsOnChanger(bool b)
    {
        isOn = b;
    }


}
