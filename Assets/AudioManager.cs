using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----------------- Audio Source -----------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("----------------- Audio Clip -----------------")]
    public AudioClip background;
    public AudioClip rockDeath;
    public AudioClip wallDeath;
    public AudioClip coneDeath;
    public AudioClip milestone;
}
