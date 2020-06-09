using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound //Custom Sound Class
{
    public string name; //Name for the audio

    public AudioClip clip; //Audio file


    [Range(0f, 1f)]
    public float volume; //control volume
    [Range(.1f, 3f)]
    public float pitch; //pitch of your audio file

    public bool loop; //loop music only

    [HideInInspector]
    public AudioSource source;
}
