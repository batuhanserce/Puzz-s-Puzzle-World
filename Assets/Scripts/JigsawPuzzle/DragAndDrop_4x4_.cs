using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop_4x4_ : MonoBehaviour
{
    public GameObject selected_piece;
    int order_in_layer;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Piece"))
            {
                if (!hit.transform.GetComponent<PieceScript_4x4_>().in_right_position)
                {
                    selected_piece = hit.transform.gameObject;
                    selected_piece.GetComponent<PieceScript_4x4_>().selected = true;
                    selected_piece.GetComponent<SortingGroup>().sortingOrder = order_in_layer;
                    order_in_layer++;
                }

            }

        }
        if (Input.GetMouseButtonUp(0))
        {
            if (selected_piece != null)
            {
                selected_piece.GetComponent<PieceScript_4x4_>().selected = false;
                selected_piece = null;
            }

        }
        if (selected_piece != null)
        {
            Vector3 mouse_point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selected_piece.transform.position = new Vector3(mouse_point.x, mouse_point.y, 0);
        }
    }
}
