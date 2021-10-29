using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic1 : MonoBehaviour
{
    [SerializeField] private AudioClip[] music;
    
    private AudioSource m_Audio;
        
    private void Awake()
    {
        m_Audio = GetComponent<AudioSource>();
    }

    public void PlaySong1(int songNr)
    {
        m_Audio.clip = music[songNr];
        m_Audio.Play();
    }
}
