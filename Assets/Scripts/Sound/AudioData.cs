using UnityEngine;

[System.Serializable]
public class AudioData
{
    [SerializeField] string name;
    [SerializeField] AudioClip audioClip;

    public AudioData() { }
    public AudioData(string name, AudioClip audioClip)
    {
        this.name = name;
        this.audioClip = audioClip;
    }

    public void SetAudioName(string name)
    {
        this.name = name;
    }

    public void SetAudioClip(AudioClip audioClip)
    {
        this.audioClip = audioClip;
    }

    public string GetAudioName()
    {
        return name;
    }

    public AudioClip GetAudioClip()
    {
        return audioClip;
    }
}
