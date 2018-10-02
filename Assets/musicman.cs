using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicman : MonoBehaviour {

    private AudioSource _audioSource;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);



        
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (!gameManager.isMusicPlaying)
        {
            gameManager.isMusicPlaying = true;
            _audioSource.Play();
        }
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
