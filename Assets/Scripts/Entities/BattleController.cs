using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    public int roundTime = 100;
    private float lastTimeUpdate = 0;
    private bool battleStarted;
    private bool battleEnded;

    public Fighter player1;
    public Fighter player2;
    public BannerController banner;
    public AudioSource musicPlayer;
    public AudioClip backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        banner.showRoundFight();
    }
    private void expireTime()
    {
        if (player1.healtPercent > player2.healtPercent)
        {
            player2.healt = 0;
        }
        else if (player1.healtPercent < player2.healtPercent)
        {
            player1.healt = 0;
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!battleStarted && !banner.isAnimating)
        {
            battleStarted = true;

            player1.enable = true;
            player2.enable = true;

            GameUtils.playSound(backgroundMusic, musicPlayer);
        }

        if (battleStarted && !battleEnded)
        {
            if (roundTime > 0 && Time.time - lastTimeUpdate > 1)
            {
                roundTime--;
                lastTimeUpdate = Time.time;
                if (roundTime == 0)
                {
                    expireTime();
                }
            }

            if (player1.healtPercent <= 0)
            {
                banner.showYouLose();
                battleEnded = true;
            }
            else if (player2.healtPercent <= 0)
            {
                banner.showYouWin();
                battleEnded = true;
            }
        }

        if (battleEnded)
        {
            player1.enable = false;
            player2.enable = false;
        }
    }
}
