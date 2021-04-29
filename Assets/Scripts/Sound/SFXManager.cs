using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] AudioData[] soundEffects;

    private Dictionary<string, AudioData> sfxDict = new Dictionary<string, AudioData>();

    void Start()
    {
        foreach(AudioData audio in soundEffects)
        {
            sfxDict.Add(audio.GetAudioName(), audio);
        }
    }

    public void PlaySFX(string soundName)
    {
        GameObject proxy = new GameObject();
        AudioSource sfxSource = proxy.AddComponent<AudioSource>();
        Destroy(proxy, 5f);

        sfxSource.spatialBlend = 0;
        sfxSource.clip = sfxDict[soundName].GetAudioClip();
        sfxSource.Play();
    }
}