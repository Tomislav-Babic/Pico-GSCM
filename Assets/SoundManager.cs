using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource[] ambientlvl1;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        VolumeSource(ambientlvl1, 0.8f);
        PlaySource(ambientlvl1);

    }
    public void PlayDing(AudioSource dingSound)
    {
        dingSound.Play();
    }

    public void VolumeSource(AudioSource[] sources, float volume)
    {
        foreach (AudioSource source in sources)
        {
            source.volume = volume;
        }
    }
    public void PlaySource(AudioSource[] sources)
    {
        foreach (AudioSource source in sources)
        {
            source.Play();
        }
    }
    public void StopSource(AudioSource[] sources)
    {
        foreach (AudioSource source in sources)
        {
            source.Stop();
        }
    }
}
