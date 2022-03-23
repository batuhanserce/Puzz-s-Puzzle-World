using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager_ : MonoBehaviour
{
    [SerializeField] public AudioSource music_source;
    [SerializeField] public AudioClip level_1_music;

    void Start()
    {
        if (music_source != null)
        {
            this.music_source.clip = level_1_music;
            music_source.Play();
            music_source.loop = true;
        }    
    }
}
