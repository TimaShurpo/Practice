using UnityEngine;
using UnityEngine.UI;

public class PointerPanel : MonoBehaviour
{
    [Header("MODULE"), Tooltip("The module name")] 
    [SerializeField] private GameObject module; 


    [Header("PANEL"), Space, Tooltip("The panel with module name")]
    [SerializeField] private GameObject panelInfo;
    

    [Header("POINT"), Space, Tooltip("The pointer icon that is attached to a specific tank module")]
    [SerializeField] private Image point;


    [Header("COLOR"), Space]
    [SerializeField] private Color colorOn = new Color(255f / 255f, 135f / 255f, 0f / 255f);
    [Space]
    [SerializeField] private Color colorOff= new Color(255f / 255f, 255f / 255f, 255f / 255f);   


    private Vector2 sizeOn = new Vector2(50f, 50f);
    private Vector2 sizeOff = new Vector2(40f, 40f);

    private Outline moduleOutLine;
    private Animator anim;

    private void Start()
    {
        anim = panelInfo.GetComponent<Animator>();
        moduleOutLine = module.GetComponent<Outline>();
        OutLineOnOff(false); 
    }

    public void PanelOn()
    {
        PanelAnim("PanelOn");   
        ColorChanger(colorOn);     
        SizeChanger(sizeOn);    
        OutLineOnOff(true);     
    }

    public void PanelOff()
    {
        PanelAnim("PanelOff");    
        ColorChanger(colorOff);   
        SizeChanger(sizeOff);     
        OutLineOnOff(false);      
    }

    private void PanelAnim(string animName)
    {
        anim.Play(animName);
    }

    private void ColorChanger(Color color)
    {
        point.color = color;
    }

    private void SizeChanger(Vector2 vector)
    {
        point.rectTransform.sizeDelta = vector;
    }

    private void OutLineOnOff(bool b)
    {
        moduleOutLine.enabled = b;
    }

}
