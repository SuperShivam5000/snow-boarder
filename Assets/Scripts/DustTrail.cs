using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustEffect;
    void OnCollisionEnter2D(Collision2D other) {
        dustEffect.Play();
    }
    void OnCollisionExit2D(Collision2D other) {
        dustEffect.Stop();
    }
}
