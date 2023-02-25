using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public GameObject prefab;

    public AudioClip coin;
    private AudioSource coinSource;

    public AudioClip goomba;
    private AudioSource goombaSource;

    public AudioClip breackBlock;
    private AudioSource breackBlockSource;

    public AudioClip pipe;
    private AudioSource pipeSource;

    public AudioClip jump;
    private AudioSource jumpSource;

    public AudioClip megaJump;
    private AudioSource megaJumpSource;

    public AudioClip death;
    private AudioSource deathSource;

    public AudioClip flag;
    private AudioSource flagSource;

    public AudioClip win;
    private AudioSource winSource;

    public AudioClip beep;
    private AudioSource beepSource;

    public AudioClip bump;
    private AudioSource bumpSource;

    public AudioClip theme;
    private AudioSource themeSource;

    private void Awake()
    {
        instance = this;
    }
    public void PlaySound(AudioClip clip, float volume, bool isLoopback)
    {
        if(clip== this.theme)
        {
            Play(clip, ref themeSource, volume, isLoopback);
        }
    }
    public void PlaySound(AudioClip clip, float volume)
    {
        if(clip== this.beep)
        {
            Play(clip, ref beepSource, volume);
            return;
        }

        if (clip == this.breackBlock)
        {
            Play(clip, ref breackBlockSource, volume);
            return;
        }

        if (clip == this.bump)
        {
            Play(clip, ref bumpSource, volume);
            return;
        }

        if (clip == this.coin)
        {
            Play(clip, ref coinSource, volume);
            return;
        }

        if (clip == this.death)
        {
            Play(clip, ref deathSource, volume);
            return;
        }

        if (clip == this.flag)
        {
            Play(clip, ref flagSource, volume);
            return;
        }

        if (clip == this.pipe)
        {
            Play(clip, ref pipeSource, volume);
            return;
        }

        if (clip == this.jump)
        {
            Play(clip, ref jumpSource, volume);
            return;
        }

        if (clip == this.megaJump)
        {
            Play(clip, ref megaJumpSource, volume);
            return;
        }

        if (clip == this.win)
        {
            Play(clip, ref winSource, volume);
            return;
        }

        if (clip == this.theme)
        {
            Play(clip, ref themeSource, volume);
            return;
        }
    }

    private void Play(AudioClip clip, 
        ref AudioSource audioSource, 
        float volume, bool isLoopback= false)
    {
        if(audioSource!= null && audioSource.isPlaying)
        {
            return;
        }
        audioSource = Instantiate(instance.prefab).GetComponent<AudioSource>();

        audioSource.volume = volume;
        audioSource.loop = isLoopback;
        audioSource.clip = clip;
        audioSource.Play();
        Destroy(audioSource.gameObject, audioSource.clip.length);
    }
    public void StopSound(AudioClip clip)
    {
        if(clip== this.beep)
        {
            beepSource?.Stop();return;
        }

        if (clip == this.breackBlock)
        {
            breackBlockSource?.Stop(); return;
        }

        if (clip == this.bump)
        {
            bumpSource?.Stop(); return;
        }

        if (clip == this.coin)
        {
            coinSource?.Stop(); return;
        }

        if (clip == this.beep)
        {
            beepSource?.Stop(); return;
        }

        if (clip == this.flag)
        {
            flagSource?.Stop(); return;
        }

        if (clip == this.death)
        {
            deathSource?.Stop(); return;
        }

        if (clip == this.pipe)
        {
            pipeSource?.Stop(); return;
        }

        if (clip == this.jump)
        {
            jumpSource?.Stop(); return;
        }

        if (clip == this.megaJump)
        {
            megaJumpSource?.Stop(); return;
        }

        if (clip == this.theme)
        {
            themeSource?.Stop(); return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
