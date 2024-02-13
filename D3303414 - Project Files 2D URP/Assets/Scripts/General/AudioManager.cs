using System;
using UnityEngine;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
    public ShootingSound[] sounds;

    public static AudioManager instance;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach (ShootingSound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            //This will find the source of all the sounds located in the file.
        }
    }

  
    public void Play (string name)
    {
       ShootingSound s =  Array.Find(sounds, sound  => sound.name == name);
        s.source.Play();
       
    }
}
