using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo3 : MonoBehaviour {

    public VideoPlayer video ;

    public void Clicked()
    {
        Debug.Log("Am apasat!");
        //video = gameObject.AddComponent<VideoPlayer>();
        video.Play();

    }
}
