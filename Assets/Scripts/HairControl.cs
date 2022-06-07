using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairControl : MonoBehaviour
{
    private Color color1;
    private Color color2;
    private Color color3;
    private Color color4;
    private Color color5;
    private Material material;
    private SpriteRenderer render;
    private Material instanciedMaterial;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        material = render.material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            ChangeHairColor("#929292", "#777777", "#575757", "#373737");
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            ChangeHairColor("#fdffdc", "#f6c1a0", "#e0706a", "#a7465c");
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            ChangeHairColor("#fd7ba5", "#eb4e81", "#b83660", "#802d72");
        }
        //Default Hair Color:
        if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            material.SetColor("_NewHairColor1", material.GetColor("_DefaultHairColor1"));
            material.SetColor("_NewHairColor2", material.GetColor("_DefaultHairColor2"));
            material.SetColor("_NewHairColor3", material.GetColor("_DefaultHairColor3"));
            material.SetColor("_NewHairColor4", material.GetColor("_DefaultHairColor4"));
            Debug.Log("Changed hair colors to: default color.");
        }
    }

    void ChangeHairColor(string _color1, string _color2, string _color3, string _color4)
    {
        ColorUtility.TryParseHtmlString(_color1, out color1);
        ColorUtility.TryParseHtmlString(_color2, out color2);
        ColorUtility.TryParseHtmlString(_color3, out color3);
        ColorUtility.TryParseHtmlString(_color4, out color4);

        material.SetColor("_NewHairColor1", color1);
        material.SetColor("_NewHairColor2", color2);
        material.SetColor("_NewHairColor3", color3);
        material.SetColor("_NewHairColor4", color4);
        Debug.Log("Changed hair colors to: color1: " + _color1 + " | color2: "
            + _color2 + " | color3: " + _color3 + " | color4: " + _color4);
    }
}
