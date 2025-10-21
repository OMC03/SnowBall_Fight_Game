using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepMusic : MonoBehaviour
{
    public static KeepMusic instance;

    public AudioSource musicSource;
    public AudioClip MenuMusic;
    public AudioClip GameMusic;

    private AudioClip currentMusicClip;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        
        SceneManager.activeSceneChanged += SceneChanged;    
    }


        private void SceneChanged(Scene current, Scene next)
    {
        if (next.name == "MenuScreen")
        {
            PlayMusic(MenuMusic);
        }
        else if (next.name == "Level 1")
        {
            PlayMusic(GameMusic);
        }
        else if (next.name == "Level 2")
        {
            PlayMusic(GameMusic);
        }

    }
        public void PlayMusic(AudioClip musicClip)
        {
          if (currentMusicClip != musicClip)
          {
              currentMusicClip = musicClip;
              musicSource.Stop();
              musicSource.clip = musicClip;
              musicSource.Play();
        }
}
    
}
