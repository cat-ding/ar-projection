using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VideoManager : MonoBehaviour
{
    public GameObject gumObject;
    public GameObject ballObject;
    bool gumState;
    bool ballState;

    void Start()
    {
        gumState = false;
        ballState = false;
    }

    public void showGum()
    {
        if (gumObject.activeSelf && !ballObject.activeSelf) //gum already on
            return;
        else if (!gumObject.activeSelf && !ballObject.activeSelf) { //both off
            gumState = true;
            gumObject.SetActive(gumState);
            return;
        } else if(!gumObject.activeSelf && ballObject.activeSelf) { //gum off, ball on
            gumState = true;
            ballState = false;
            ballObject.SetActive(ballState);
            gumObject.SetActive(gumState);

        }
    }

    public void showBall()
    {
        if (ballObject.activeSelf && !gumObject.activeSelf) //ball already on
            return;
        else if (!gumObject.activeSelf && !ballObject.activeSelf) { //both off
            ballState = true;
            ballObject.SetActive(ballState);
            return;
        }
        else if (!ballObject.activeSelf && gumObject.activeSelf) { //ball off, gum on
            ballState = true;
            gumState = false;
            gumObject.SetActive(gumState);
            ballObject.SetActive(ballState);

        }
    }
}