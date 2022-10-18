using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    private AudioSource m_AudioSource;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip sound)
    {
        m_AudioSource.PlayOneShot(sound); 
}
}