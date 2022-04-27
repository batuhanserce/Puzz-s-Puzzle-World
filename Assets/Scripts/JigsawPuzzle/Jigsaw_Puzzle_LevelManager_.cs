using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jigsaw_Puzzle_LevelManager_ : MonoBehaviour
{
    public static bool level1, level2, level3;
    public Button level1_button, level2_button, level3_button;
    void Start()
    {
        level1 = true;
        DontDestroyOnLoad(level2_button);
        DontDestroyOnLoad(level3_button);
    }

    void Update()
    {
        if (level2 == true)
        {
            // Buton etksilesim
            // DontDestroyOnLoad(level2_button);
            level2_button.interactable = true;
        }
        if (level3 == true)
        {
            // DontDestroyOnLoad(level3_button);
            level3_button.interactable = true;
        }

    }
}
