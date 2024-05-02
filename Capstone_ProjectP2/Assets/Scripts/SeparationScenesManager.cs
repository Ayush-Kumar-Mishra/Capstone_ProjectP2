using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeparationScenesManager : MonoBehaviour
{
    public GameObject questionImage;
    public GameObject videoImage;
    public GameObject videoSource;
    public AudioSource questionAudio;

    void Start()
    {
        questionAudio.Play();
        StartCoroutine(VideoPlayer());
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator VideoPlayer() 
    {
        yield return new WaitForSeconds(4.5f);
        questionImage.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        videoSource.gameObject.SetActive(true);
        videoImage.gameObject.SetActive(true);
    }
}
