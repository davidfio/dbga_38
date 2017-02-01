using UnityEngine;
using System.Collections;

public class SoundPlayer : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioSource audioSource;

    [Range(0,1)]
    public float a;

    void OnMouseUp()
    {
        audioSource.clip = clip2;
        audioSource.loop = false;
        audioSource.pitch = 1f;
        audioSource.volume = 1f;
        audioSource.mute = false;
        audioSource.Play();
        //audioSource.PlayDelayed(1f);
        //audioSource.PlayOneShot(,);
        if (audioSource.isPlaying)
        {
            Debug.Log("AAA");
        }

        audioSource.Stop();
    }
}