using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// make method for run 
//make method for walk 
// transform 
// loop the clip

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }
    private AudioSource source;
    [SerializeField] protected AudioClip[] runClips;
    [SerializeField] protected AudioClip[] snowBallClips;
    [SerializeField] protected AudioClip[] walkClips;
    [SerializeField] protected AudioClip audioClip;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        Instance = this;
    }
    public void PlaySound(AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    }
    public void RunSoundEffect()
    {
        source.PlayOneShot(SelectClip(runClips));
    }
    public void SnowBalLSoundEffect()
    {
        source.PlayOneShot(SelectClip(snowBallClips));
    }
    public void WalkSoundEffect()
    {
        source.PlayOneShot(SelectClip(walkClips));
    }
    // takes in parameter that is not an array
    // method to play array 
    public AudioClip SelectClip(AudioClip[] aClips)
    {
        // make a variable to use as refence
        int randIdex = 0;
        // clarifying we are using the UnityEngine for random range 
        // aClips is used for the ranges in between clips
        randIdex = UnityEngine.Random.Range(0, aClips.Length - 1);
        AudioClip randClip = aClips[randIdex];
        return randClip;
    }


}
