using UnityEngine;
using UnityEngine.Video;

public class WebARVideoTracker : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;

    private void Awake()
    {
        if (videoPlayer == null)
            videoPlayer = GetComponentInChildren<VideoPlayer>();
        
        // Mute by default to bypass mobile browser autoplay restrictions
        if (videoPlayer != null)
            videoPlayer.SetDirectAudioMute(0, true);
    }

    // Assign this to ImageTarget's On Target Found Event
    public void OnTargetFound()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }

    // Assign this to ImageTarget's On Target Lost Event
    public void OnTargetLost()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Pause();
        }
    }
}