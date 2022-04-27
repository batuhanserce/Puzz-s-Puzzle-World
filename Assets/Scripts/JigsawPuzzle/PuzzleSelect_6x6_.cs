using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuzzleSelect_6x6_ : MonoBehaviour
{
    // public GameObject[] start_menus;
    public GameObject start_menu;
    // public GameObject[] all_pieces;
    // public int[] menu_numbers;

    public void SetPuzzlePhoto(Image photo)
    {
        for (int i = 0; i < 36; i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = photo.sprite;
        }
        if (photo.sprite == true)
        {
            Debug.Log("Puzzle is ON");
        }
        start_menu.SetActive(false);
        
    }
    /* private void Update()
    {
        IsPuzzleComplete();
    }

    public void IsPuzzleComplete()
    {
        Vector3 all;
        all_pieces = new GameObject[36];
        for (int i = 0; i < 36; i++)
        {
            all = GameObject.Find("Piece (" + i + ")").transform.position;
            Debug.Log("Pieces : " + all);
        }
    } */

}
