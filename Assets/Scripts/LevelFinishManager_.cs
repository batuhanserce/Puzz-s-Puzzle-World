using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFinishManager_ : MonoBehaviour
{
    public GameObject level_pass_canvas;
    public Button level_pass_button, back_to_menu_button;
    public Button lvl1_game1_btn, lvl1_game2_btn, lvl1_game3_btn;
    public bool lvl1_game1, lvl1_game2, lvl1_game3;


    public void Start()
    {
        lvl1_game1 = true;
        lvl1_game2 = false;
        lvl1_game3 = false;

        Button pass_level_btn = level_pass_button.GetComponent<Button>();
        Button menu_back_btn = back_to_menu_button.GetComponent<Button>();

        // Button level1_game1_button = lvl1_game1_btn.GetComponent<Button>();
        // Button level1_game2_button = lvl1_game2_btn.GetComponent<Button>();
        // Button level1_game3_button = lvl1_game3_btn.GetComponent<Button>();

        pass_level_btn.onClick.AddListener(go_to_next_level);
        menu_back_btn.onClick.AddListener(go_back_to_menu);
       
        
    }
    public void Update()
    {
        if (PieceScript_.completed_pieces == PieceScript_.total_pieces)
        {
            lvl1_game2 = true;
            lvl1_game3 = true;
            level_pass_canvas.SetActive(true);
            PieceScript_.completed_pieces = 1;
        }
        

    }

    public void go_to_next_level()
    {
        // lvl1_game2_btn.interactable = true;
        // Load Level 1 Menu
        lvl1_gamebtn2_gamebtn3_interactable();
        SceneManager.LoadScene(2);
    }

    public void lvl1_gamebtn2_gamebtn3_interactable()
    {
        if (lvl1_game1 == true & lvl1_game2 == true)
        {
            lvl1_game2_btn.interactable = true;
            lvl1_game3_btn.interactable = true;
        }
    }
    public void go_back_to_menu()
    {
        // Go to Level Menu
        SceneManager.LoadScene(1);
    }

}
