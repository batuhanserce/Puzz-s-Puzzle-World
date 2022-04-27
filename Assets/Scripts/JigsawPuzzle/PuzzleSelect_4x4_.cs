using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuzzleSelect_4x4_ : MonoBehaviour
{
    public GameObject start_menu;

    public void SetPuzzlePhoto(Image photo)
    {
        for (int i = 0; i < 16; i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = photo.sprite;
        }
        if (photo.sprite == true)
        {
            Debug.Log("Puzzle is ON");
        }
        start_menu.SetActive(false);
        
    }

}
