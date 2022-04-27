using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzleTypeMenuScript_ : MonoBehaviour
{
    public Button jigsaw_puzzle_button;
    public Button pipe_puzzle_button;
    public Button unknown_puzzle_button;

    void Start()
    {
        Button jigsaw_button = jigsaw_puzzle_button.GetComponent<Button>();
        Button pipe_button = pipe_puzzle_button.GetComponent<Button>();
        Button unknown_button = unknown_puzzle_button.GetComponent<Button>();

        jigsaw_button.onClick.AddListener(JigsawPuzzleStart);
        pipe_button.onClick.AddListener(PipePuzzleStart);
    }

    public void JigsawPuzzleStart()
    {
        // SceneManager.LoadScene(1);
        Debug.Log("You have chosen the Jigsaw Puzzle To Play"); // JIGSAW PUZZLE HAS BENN STARTED BY PLAYER
    }

    public void PipePuzzleStart()
    {
        // SceneManager.LoadScene(1);
        Debug.Log("You have chosen the Pipe Puzzle To Play"); // PIPE PUZZLE HAS BENN STARTED BY PLAYER
    }

}
