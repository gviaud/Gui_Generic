/* 
Viaud Guillaume 21/10/2015

A faire :

- Check de la resolution et la changer de le canvas
- animation
- associé fonction aux bouttons

*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LeftCanvas_Script : MonoBehaviour
{

    List<GameObject> button_list;

    //Graph
    Sprite sprite_button;
    Font font_text;

    // Use this for initialization
    void Start ()
    {

        //Graph
        sprite_button = transform.FindChild("Button MODEL").GetComponent<Image>().sprite;
        font_text = transform.FindChild("Button MODEL").GetChild(0).GetComponent<Text>().font;

        //Init
        button_list = new List<GameObject>();

        //A SUPPRIMER
        CreateButton();
        CreateButton();
        CreateButton();
        CreateButton();
        CreateButton();
        //

    }
	
	// Update is called once per frame
	void Update ()
    {
 
    }

    void CreateButton()
    {

        // ------------  Button ------------ //
        GameObject newButton = new GameObject();

        //Add component
        newButton.AddComponent<RectTransform>();
        newButton.AddComponent<CanvasRenderer>();
        newButton.AddComponent<Image>();
        newButton.AddComponent<Button>();

        //Parent
        newButton.transform.parent = transform;
        //position
        newButton.GetComponent<RectTransform>().anchorMin = new Vector2(0, 1.0f - (button_list.Count * 0.05f) - 0.05f);
        newButton.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1.0f - (button_list.Count*0.05f) );
        newButton.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        newButton.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
        newButton.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0, 0, 0);

        //Settings
        newButton.name = "Button";
        newButton.GetComponent<Image>().sprite = sprite_button;
        newButton.GetComponent<Image>().type = Image.Type.Sliced;
        newButton.AddComponent<GUI_Button_Script>();
        
         //Add to list
         button_list.Add(newButton);



        // ------------ Text ------------ //
        GameObject newText = new GameObject();
        newText.name = "Text";

        //Add component
        newText.AddComponent<RectTransform>();
        newText.AddComponent<CanvasRenderer>();
        newText.AddComponent<Text>();
        

        //Parent
        newText.transform.parent = newButton.transform;
        //position
        newText.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0);
        newText.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
        newText.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        newText.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
        newText.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0, 0, 0);

        //Settings
        newText.GetComponent<Text>().text = "newtext";
        newText.GetComponent<Text>().color = new Color(50f/255f, 50f/255f, 50f/255f, 1);
        newText.GetComponent<Text>().font = font_text;
        newText.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

    }

}
