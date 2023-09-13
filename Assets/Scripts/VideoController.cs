using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button playButton;
    public Button pauseButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayVideo);
        pauseButton.onClick.AddListener(PauseVideo);

        // Initially, show only the play button
        playButton.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }

    private void PlayVideo()
    {
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
            playButton.gameObject.SetActive(false);
            pauseButton.gameObject.SetActive(true);
        }
    }

    private void PauseVideo()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            playButton.gameObject.SetActive(true);
            pauseButton.gameObject.SetActive(false);
        }
    }
}
