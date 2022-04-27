using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGameManager_ : MonoBehaviour
{
    public GameObject pipe_holder; // FOLDER THAT CONTAINS ALL PIPES EXCEPT START PIPE AND END PIPE
    public GameObject[] pipes; // PIPE OBJECTS

    [SerializeField]
    int total_pipe_number = 0; // TOTAL NUMBER OF PIPES

    [SerializeField]
    int correct_pipe_count; // COUNT HOW MANY PIPES ARE IN CORRECT POSITION

    void Start()
    {
        total_pipe_number = pipe_holder.transform.childCount;

        pipes = new GameObject[total_pipe_number];

        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i] = pipe_holder.transform.GetChild(i).gameObject;
        }
    }

    public void RightMove()
    {
        correct_pipe_count += 1;
        Debug.Log("Right Move! Your correct pipe count increased by 1, new correct pipe count is : " + correct_pipe_count);

        if (correct_pipe_count == total_pipe_number)
        {
            Debug.Log("Veni! Vidi! Vici!");
        }
    }

    public void WrongMove()
    {
        correct_pipe_count -= 1;
        Debug.Log("Wrong Move! Your correct pipe count decreased by 1, new correct pipe count is : " + correct_pipe_count);
    }
}
