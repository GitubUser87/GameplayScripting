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
            s.source.loop = s.loop;
            //the loop will allow an audio source to play repeatedly once it ends.
            //This will find the source of all the sounds located in the file.
        }
    }

  
    public void Play (string name)
    {
       ShootingSound s =  Array.Find(sounds, sound  => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found.");
            return;
            //This will detect if the auido isn't available and will send a message through the console.
        }
            
        s.source.Play();
       
    }
}
