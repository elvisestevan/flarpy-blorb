using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header("Audio Source")]
    public AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip score;

    public void playScoreSFX()
    {
        SFXSource.PlayOneShot(this.score);
    }

}
