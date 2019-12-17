using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerController : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioPlayer;

    private bool animating;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioPlayer = GetComponent<AudioSource>();
    }

    public void showRoundFight()
    {
        animating = true;
        animator.SetTrigger("ShowRoundFight");
    }

    public void showYouWin()
    {
        animating = true;
        animator.SetTrigger("ShowYouWin");
    }

    public void showYouLose()
    {
        animating = true;
        animator.SetTrigger("ShowYouLose");
    }

    public void playVoice(AudioClip voice)
    {
        GameUtils.playSound(voice, audioPlayer);
    }

    public void animationEnded()
    {
        animating = false;
    }

    public bool isAnimating
    {
        get
        {
            return animating;
        }
    }
}
