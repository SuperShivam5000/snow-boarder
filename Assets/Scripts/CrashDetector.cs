using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float reloadTime = 1f;
    [SerializeField] AudioClip crashSFX;
    bool canFX=true;
    void OnCollisionEnter2D(Collision2D other) {
        FindObjectOfType<PlayerController>().DisableControls();
        if(canFX){
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            canFX=false;
        }
        Invoke("ReloadScene", reloadTime);
    }
    
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
