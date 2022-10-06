using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private SoAudioClips walkAudioClips;
    [SerializeField] private SoAudioClips jumpAudioClips;
    [SerializeField] private SoAudioClips jumppadAudioClips;
    [SerializeField] private SoAudioClips winAudioClips;
    [SerializeField] private SoAudioClips collectAudioClips;
    [SerializeField] private SoAudioClips deadAudioClips;

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpAudioClips.GetAudioClip());
    }
    public void PlayWalkSound()
    {
        audioSource.PlayOneShot(walkAudioClips.GetAudioClip());
    }
    public void PlayJumppadSound()
    {
        audioSource.PlayOneShot(jumppadAudioClips.GetAudioClip());
    }
    public void PlayWinningSound()
    {
        audioSource.PlayOneShot(winAudioClips.GetAudioClip());
    }
    public void PlayCollectSound()
    {
        audioSource.PlayOneShot(collectAudioClips.GetAudioClip());
    }
    public void PlayDeadSound()
    {
        audioSource.PlayOneShot(deadAudioClips.GetAudioClip());
    }
}
