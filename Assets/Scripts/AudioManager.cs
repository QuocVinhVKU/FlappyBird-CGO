using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance = null;
    public AudioSource backGroundMusicAudioSource;
    public AudioSource birdAudio;

    public AudioClip backGroundMusic;
    public AudioClip deadAudio;
    public AudioClip jumpAudio;
    public AudioClip collectCoin;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        birdAudio = GameManager.instance.bird.GetComponentInParent<AudioSource>();

    }

    public void BGM_Audio()
    {
        backGroundMusicAudioSource.PlayOneShot(backGroundMusic);
    }
    public void PlayEndGameAudio()
    {
        birdAudio.PlayOneShot(deadAudio);
    }
    public void JumpAudio()
    {
        birdAudio.PlayOneShot(jumpAudio);
    }
    public void CollectCoinAudio()
    {
        birdAudio.PlayOneShot(collectCoin);
    }
}