using UnityEngine.Audio;
using System;

using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    void Awake(){

        if(instance == null) {
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
            s.source = gameObject.GetComponent<AudioSource>();
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume = 1f;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;               
        }
    }

    void Start () 
    {
        Play("MusicLevel_1");
        Play("Fx_Truck_1_Motor_StandBy");
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);
        if (s == null)
        {            
            Debug.LogWarning("Sound : "+ name + " not found Pa!");
            return;
        }
        s.source.Play();
    }

    
}
