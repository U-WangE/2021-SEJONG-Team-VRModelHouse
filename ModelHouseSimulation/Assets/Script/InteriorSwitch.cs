using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorSwitch : MonoBehaviour
{
    public GameObject interiorName;
    public GameObject[] interiorButton;
    public GameObject[] interior;
    public Sprite sprite_off;
    public Sprite sprite_on;
    public Sprite[] interiorNameSprite;

    void Start()
    {
        interiorButton[0].GetComponent<SpriteRenderer>().sprite = sprite_on;
        interiorButton[1].GetComponent<SpriteRenderer>().sprite = sprite_off;
        interiorButton[2].GetComponent<SpriteRenderer>().sprite = sprite_off;
        interior[0].SetActive(true);
        interior[1].SetActive(false);
        interior[2].SetActive(false);
        interiorName.GetComponent<SpriteRenderer>().sprite = interiorNameSprite[0];
    }

    void Update()
    {
        if (MouseClick.objectName == interiorButton[0].name)
        {
            interiorButton[0].GetComponent<SpriteRenderer>().sprite = sprite_on;
            interiorButton[1].GetComponent<SpriteRenderer>().sprite = sprite_off;
            interiorButton[2].GetComponent<SpriteRenderer>().sprite = sprite_off;
            interior[0].SetActive(true);
            interior[1].SetActive(false);
            interior[2].SetActive(false);
            interiorName.GetComponent<SpriteRenderer>().sprite = interiorNameSprite[0];
        }
        else if (MouseClick.objectName == interiorButton[1].name)
        {
            interiorButton[0].GetComponent<SpriteRenderer>().sprite = sprite_off;
            interiorButton[1].GetComponent<SpriteRenderer>().sprite = sprite_on;
            interiorButton[2].GetComponent<SpriteRenderer>().sprite = sprite_off;
            interior[0].SetActive(false);
            interior[1].SetActive(true);
            interior[2].SetActive(false);
            interiorName.GetComponent<SpriteRenderer>().sprite = interiorNameSprite[1];
        }
        else if (MouseClick.objectName == interiorButton[2].name)
        {
            interiorButton[0].GetComponent<SpriteRenderer>().sprite = sprite_off;
            interiorButton[1].GetComponent<SpriteRenderer>().sprite = sprite_off;
            interiorButton[2].GetComponent<SpriteRenderer>().sprite = sprite_on;
            interior[0].SetActive(false);
            interior[1].SetActive(false);
            interior[2].SetActive(true);
            interiorName.GetComponent<SpriteRenderer>().sprite = interiorNameSprite[2];
        }
    }
}
