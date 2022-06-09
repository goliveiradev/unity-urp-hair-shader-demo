using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairControl : MonoBehaviour
{
    private Color color1, color2, color3, color4, color5;
    private Material material;
    private SpriteRenderer render;
    private int _hairIndex = 0;
    private int _skinIndex = 0;
    List<string>[] hairColors = new List<string>[20];
    List<string>[] skinColors = new List<string>[9];

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        material = render.material;

        hairColors[0] = new List<string> { "#929292", "#777777", "#575757", "#373737" }; // male default
        hairColors[1] = new List<string> { "#fdf7cb", "#cbd1bc", "#8fa59a", "#5e6c73" };
        hairColors[2] = new List<string> { "#d8e7db", "#abbdc2", "#869a9f", "#5b6770" };
        hairColors[3] = new List<string> { "#e4c4ab", "#c3a38a", "#997577", "#4e495f" };
        hairColors[4] = new List<string> { "#fbe9c6", "#f7c9a8", "#ed9482", "#c94c68" };
        hairColors[5] = new List<string> { "#eee97b", "#e1bf54", "#e1bf54", "#a85445" };
        hairColors[6] = new List<string> { "#daac39", "#d57121", "#c73438", "#802d49" };
        hairColors[7] = new List<string> { "#ec6b3d", "#e33333", "#b3253d", "#802d49" };
        hairColors[8] = new List<string> { "#fd9191", "#ef5b92", "#b83679", "#802d72" };
        hairColors[9] = new List<string> { "#f1b988", "#e78daa", "#cd556f", "#8f3c8d" };
        hairColors[10] = new List<string> { "#af80e4", "#7770da", "#7f4ca6", "#552a76" };
        hairColors[11] = new List<string> { "#54a8dd", "#527ec5", "#5e509a", "#4b3259" };
        hairColors[12] = new List<string> { "#74f7cf", "#54ced0", "#4081a9", "#3a5b8c" };
        hairColors[13] = new List<string> { "#bad95a", "#64b645", "#398a7f", "#384e80" };
        hairColors[14] = new List<string> { "#dadc51", "#b2bf41", "#958d3c", "#615b2a" };
        hairColors[15] = new List<string> { "#509c8a", "#3b7e7e", "#504b71", "#3c3b5a" };
        hairColors[16] = new List<string> { "#644f4e", "#4a353a", "#3b2a30", "#271e24" };
        hairColors[17] = new List<string> { "#4e5864", "#353b4a", "#2a2d3b", "#221e27" };
        hairColors[18] = new List<string> { "#a68156", "#8b583c", "#6e3827", "#462623" };
        hairColors[19] = new List<string> { "#ff5e60", "#ce3c53", "#942d2d", "#5e1a26" }; // female default

        skinColors[0] = new List<string> { "#ffedd8", "#fdddb9", "#f6c3a0", "#e6a37f", "#8c4f3e" };
        skinColors[1] = new List<string> { "#fbdcc8", "#f9c2a6", "#e9a48d", "#d88573", "#633431" }; // default
        skinColors[2] = new List<string> { "#ffcc95", "#ffa771", "#f48e64", "#ea7557", "#8e4037" };
        skinColors[3] = new List<string> { "#d4997e", "#b47659", "#a66b51", "#965440", "#402d26" };
        skinColors[4] = new List<string> { "#b47659", "#965440", "#86493f", "#753d3d", "#402d26" };
        skinColors[5] = new List<string> { "#fcee92", "#dcd081", "#c2ae60", "#9c9f53", "#635131" };
        skinColors[6] = new List<string> { "#a9c348", "#87a43b", "#7e9236", "#6a732e", "#583c26" };
        skinColors[7] = new List<string> { "#b7efff", "#81c5f4", "#72a3d1", "#6485b7", "#3e3163" };
        skinColors[8] = new List<string> { "#5799b8", "#3c76a4", "#366192", "#314d81", "#412a57" };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyUp(KeyCode.E))
        {
            if (_skinIndex >= (skinColors.Length - 1)) return;

            _skinIndex++;

            ChangeSkinColor(skinColors[_skinIndex][0], skinColors[_skinIndex][1],
            skinColors[_skinIndex][2], skinColors[_skinIndex][3], skinColors[_skinIndex][4]);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyUp(KeyCode.Q))
        {
            if (_skinIndex <= 0) return;

            _skinIndex--;

            ChangeSkinColor(skinColors[_skinIndex][0], skinColors[_skinIndex][1],
            skinColors[_skinIndex][2], skinColors[_skinIndex][3], skinColors[_skinIndex][4]);
        }

        if (!Input.GetKey(KeyCode.LeftShift) && Input.GetKeyUp(KeyCode.E))
        {
            if (_hairIndex >= (hairColors.Length - 1)) return;

            _hairIndex++;

            ChangeHairColor(hairColors[_hairIndex][0], hairColors[_hairIndex][1],
            hairColors[_hairIndex][2], hairColors[_hairIndex][3]);
        }

        if (!Input.GetKey(KeyCode.LeftShift) && Input.GetKeyUp(KeyCode.Q))
        {
            if (_hairIndex <= 0) return;

            _hairIndex--;

            ChangeHairColor(hairColors[_hairIndex][0], hairColors[_hairIndex][1],
            hairColors[_hairIndex][2], hairColors[_hairIndex][3]);
        }
    }

    public void ChangeHairColor(string _color1, string _color2, string _color3,
        string _color4)
    {
        ColorUtility.TryParseHtmlString(_color1, out color1);
        ColorUtility.TryParseHtmlString(_color2, out color2);
        ColorUtility.TryParseHtmlString(_color3, out color3);
        ColorUtility.TryParseHtmlString(_color4, out color4);

        material.SetColor("_NewHairColor1", color1);
        material.SetColor("_NewHairColor2", color2);
        material.SetColor("_NewHairColor3", color3);
        material.SetColor("_NewHairColor4", color4);
    }

    public void ChangeSkinColor(string _color1, string _color2, string _color3,
        string _color4, string _color5)
    {
        ColorUtility.TryParseHtmlString(_color1, out color1);
        ColorUtility.TryParseHtmlString(_color2, out color2);
        ColorUtility.TryParseHtmlString(_color3, out color3);
        ColorUtility.TryParseHtmlString(_color4, out color4);
        ColorUtility.TryParseHtmlString(_color5, out color5);

        material.SetColor("_NewSkinColor1", color1);
        material.SetColor("_NewSkinColor2", color2);
        material.SetColor("_NewSkinColor3", color3);
        material.SetColor("_NewSkinColor4", color4);
        material.SetColor("_NewSkinColor5", color5);
    }
}
