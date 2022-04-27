using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PieceScript_12x12_ : MonoBehaviour
{
    private Vector3 right_position;
    public bool in_right_position;
    public bool selected;
    public static int completed_pieces = 0;
    public static int total_pieces = 144;

    void Start()
    {   // WHERE PIECES WILL BE LOCATED (RIGHT OF THE PUZZLE TABLE)
        right_position = transform.position;
        transform.position = new Vector3(Random.Range(6.5f, 18.5f), Random.Range(7f, -9f));
    }

    void Update()
    {
        // Put puzzle pieces to left of the puzzle piece area
        if (Vector3.Distance(transform.position, right_position) < 0.5f)
        {
            if (!selected)
            {
                if (in_right_position == false)
                {
                    transform.position = right_position;
                    in_right_position = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Debug.Log("In Right Position : " + in_right_position);
                    Debug.Log("Right Position Is : " + right_position);


                    if (in_right_position == true)
                    {
                        if (completed_pieces == total_pieces)
                        {
                            Debug.Log("Puzzle Complete");
                        }
                        completed_pieces = completed_pieces + 1;
                        Debug.Log(completed_pieces + " out of 144(" + completed_pieces + "/144)");
                    }

                }

            }

        }

    }

}

