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
            ChangeHairColor("#bad95a", "#64b645", "#398a7f", "#384e80", "#3b325c");
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            ChangeHairColor("#929292", "#777777", "#575757", "#373737", "#252525");
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            ChangeHairColor("#fd7ba5", "#eb4e81", "#b83660", "#802d72", "#46215e");
        }
    }

    void ChangeHairColor(string _color1, string _color2, string _color3, string _color4, string _color5)
    {
        ColorUtility.TryParseHtmlString(_color1, out color1);
        ColorUtility.TryParseHtmlString(_color2, out color2);
        ColorUtility.TryParseHtmlString(_color3, out color3);
        ColorUtility.TryParseHtmlString(_color4, out color4);
        ColorUtility.TryParseHtmlString(_color5, out color5);


        Debug.Log("Mudei de cor");
        material.SetColor("Color_1", color1);
        material.SetColor("Color_2", color2);
        material.SetColor("Color_3", color3);
        material.SetColor("Color_4", color4);
        material.SetColor("Color_5", color5);
    }
}
