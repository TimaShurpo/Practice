using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelChanger : MonoBehaviour
{
    [Header("INFO PANELS"), Space]
    [SerializeField, Tooltip("Panel with general info about the tank ")] private GameObject generalPanel;
    [SerializeField, Tooltip("Panel with information about the tank gun")] private GameObject gunPanel;
    [SerializeField, Tooltip("Panel with information about the tank turret")] private GameObject turretpanel;
    [SerializeField, Tooltip("Panel with information about the tank hull")] private GameObject hullPanel;


    [Header("PANEL BUTTON"), Space]
    [SerializeField, Tooltip("Button to turn on generalPanel")] private Button generalPanelButton;
    [SerializeField, Tooltip("Button to turn on gunPanel")] private Button gunPanelButton;
    [SerializeField, Tooltip("Button to turn on turretPanel")] private Button turretPanelButton;
    [SerializeField, Tooltip("Buton to turn on hullPanel")] private Button hullPanelButton;


    [Header("BUTTON ICONS"), Space]
    [SerializeField] private Image gunPanelButtonIcon;    
     [SerializeField] private Image turretPanelButtonIcon;
    [SerializeField] private Image hullPanelButtonIcon;


    [Header("COLORS"), Space]
    [SerializeField] private Color iconOnColor = new Color(255f / 255f, 132f / 255f, 0f / 255f);
    [SerializeField] private Color iconOffColor = new Color(55f / 255f, 55f / 255f, 55f / 255f );


    private void Start()
    {
        AllPanelOff(false, false, false, false);
        GeneralPanelOn();
        IconColorChanger(iconOffColor, iconOffColor, iconOffColor);

    }

    public void GeneralPanelOn()
    {
        AllPanelOff(true, false, false, false);
        IconColorChanger(iconOffColor,iconOffColor,iconOffColor);

    }

    public void GunPanelOn()
    {
        AllPanelOff(false, true, false, false);
        IconColorChanger(iconOnColor,iconOffColor,iconOffColor);

    }

    public void TurretPanelOn()
    {
        AllPanelOff(false, false, true, false);
        IconColorChanger(iconOffColor,iconOnColor,iconOffColor);

    }

    public void HullPanelOn()
    {
        AllPanelOff(false, false, false, true);
        IconColorChanger(iconOffColor,iconOffColor,iconOnColor);

    }

    private void AllPanelOff(bool b1, bool b2, bool b3, bool b4)
    {
        generalPanel.SetActive(b1);
        gunPanel.SetActive(b2);
        turretpanel.SetActive(b3);
        hullPanel.SetActive(b4);

    }

    private void  IconColorChanger(Color c1, Color c2, Color c3)
    {
        gunPanelButtonIcon.color = c1;
        turretPanelButtonIcon.color = c2;
        hullPanelButtonIcon.color = c3;

    }

}
