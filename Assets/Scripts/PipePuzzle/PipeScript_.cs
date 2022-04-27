using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript_ : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 }; // 0 = 360, 90,180,270

    public float[] correct_rotation; // ALL POSSIBLE CORRECT ROTATIONS

    [SerializeField] bool is_placed = false; // IS IN PLACE OR NOT CHECK

    int possible_rotations = 1;

    PipeGameManager_ pipegameManager_;

    private void Awake()
    {
        pipegameManager_ = GameObject.Find("PipeGameManager").GetComponent<PipeGameManager_>();  
    }

    void Start()
    {
        possible_rotations = correct_rotation.Length;

        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
        if (possible_rotations > 1)
        {
            if (transform.eulerAngles.z == correct_rotation[0] || transform.eulerAngles.z == correct_rotation[1])
            {
                is_placed = true;
                pipegameManager_.RightMove();
            }
        }
        else
        {
            if (transform.eulerAngles.z == correct_rotation[0])
            {
                is_placed = true;
                pipegameManager_.RightMove();
            }
        }
        
    }


    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));
        transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z)); // Life Saver
        if (possible_rotations > 1)
        {
            if (transform.eulerAngles.z == correct_rotation[0] || transform.eulerAngles.z == correct_rotation[1] && is_placed == false)
            {
                is_placed = true;
                pipegameManager_.RightMove();
            }
            else if (is_placed == true)
            {
                is_placed = false;
                pipegameManager_.WrongMove();
            }
        }
        else
        {
            if (transform.eulerAngles.z == correct_rotation[0] && is_placed == false)
            {
                // Debug.Log("Correct Rotation : " + correct_rotation[0]);
                is_placed = true;
                pipegameManager_.RightMove();
            }
            else if (is_placed == true)
            {
                is_placed = false;
                pipegameManager_.WrongMove();
            }
        }
        
    }
}
