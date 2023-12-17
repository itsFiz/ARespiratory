using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class Tracker : MonoBehaviour
{

    public VideoPlayer videos;
    Slider tracking;
    bool slide = false;
    // Start is called before the first frame update
    void Start()
    {
        tracking = GetComponent<Slider>();
    }

    public void press()
    {
        slide = true;
    }

    public void release()
    {
        float frame = (float)tracking.value * (float)videos.frameCount;

        videos.frame = (long)frame;

        slide = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!slide)
        {
            tracking.value = (float)videos.frame / (float)videos.frameCount;
        }
        
    }
}
