using UnityEngine;

public class TanksChanger : MonoBehaviour
{
    [Header("ALL TANKS"), Space]
    [SerializeField] GameObject[] tankMass;
    private GameObject tankCurrent;


    [Header("SCENE CHANGER"), Space]
    [SerializeField] GameObject changer;
    private SceneChanger sceneChanger;


    private void Start()
    {
        sceneChanger = changer.GetComponent<SceneChanger>();
        LevelNameChanger("IS-1");
        AllOff();

        tankCurrent = tankMass[0];
        tankCurrent.SetActive(true);
        
    }

    private void AllOff()
    {
        foreach (GameObject tank in tankMass)
        {
            tank.SetActive(false);
        }
    }

    public void TankChanger(int number)
    {
        try
        {
            tankCurrent.SetActive(false);
            tankCurrent = tankMass[number];
            tankCurrent.SetActive(true);

        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void LevelNameChanger(string sceneName)
    {
        sceneChanger.levelName = sceneName;
    }
}