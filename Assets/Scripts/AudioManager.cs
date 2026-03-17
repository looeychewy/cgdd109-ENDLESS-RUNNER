using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private AudioSource audioSource;
    public AudioClip bgMusic;

    [SerializeField] AudioSource sfxSource;

    // SFX types for game
    public AudioClip rockDeath;
    public AudioClip wallDeath;
    public AudioClip coneDeath;
    public AudioClip boxPickup;
    public AudioClip milestone;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            audioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if (bgMusic != null)
        {
            PlayBGMusic(false, bgMusic);
        }   

    }

    public static void SetVolume(float volume)
    {
        Instance.audioSource.volume = volume;
    }

    public void PlayBGMusic (bool resetSong, AudioClip audioClip = null)
    {
        if (audioClip != null)
        {
            audioSource.clip = audioClip;
        }
        if (audioSource.clip != null)
        {
            if(resetSong)
            {
                audioSource.Stop();
            }
            audioSource.Play();
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        if (clip != null)
        {
            sfxSource.PlayOneShot(clip);
        }
    }

    public void PauseBGMusic()
    {
        audioSource.Pause();
    }
}
