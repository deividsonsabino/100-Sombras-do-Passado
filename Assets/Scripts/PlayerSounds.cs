using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;
    private void Steps() {
        audioSource.PlayOneShot(audioClips[Random.Range(0, audioClips.Length)]);
    }
}
