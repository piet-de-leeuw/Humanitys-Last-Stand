using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAudio : MonoBehaviour
{

    Scene scene;
    [SerializeField] AudioManager audioManager;
    
    bool isPlaying = false;
    
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log(scene.buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        PlayClip(0,"miniB");
        
        PlayClip(1, "hyperB");

    }

    private void PlayClip(int scenenumber, string audioName)
    {
        if (scene.buildIndex == scenenumber)
        {
            
            if (!isPlaying)
            {
                Debug.Log(audioName);
                audioManager.Play(audioName);
                isPlaying = true;
            }
            
        }
    }
}
