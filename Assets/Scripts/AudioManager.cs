using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.Audio;
using UnityEngine;
//Welcome to some leak of my GPS1 Codes, Not full but part of it. Hopefully Mr.Boon can give some idea about my codes
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds; //Store Every Sounds, Refer Inspector

    public static AudioManager instance;
    void Awake()
    {
        if (instance == null) //For Multiple Scene Purpose avoid audiomanger missing
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Play("BGM"); //Play BGM
    }

    public void Play(string name) //Play Sound source
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) //Warning Debug
        {
            Debug.LogWarning("Sounds: " + name + " not found!");
            return;
        }
        s.source.Play();
    }

    public void Pause(string name) //Pause Sound source
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) //Warning Debug
        {
            Debug.LogWarning("Sounds: " + name + " not found!");
            return;
        }
        s.source.Pause();
    }
}
