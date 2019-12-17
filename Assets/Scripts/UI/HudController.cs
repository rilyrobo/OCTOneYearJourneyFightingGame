using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    public Fighter player1;
    public Fighter player2;

    public Text leftText;
    public Text rightText;

    public Scrollbar leftBar;
    public Scrollbar rightBar;

    public Scrollbar leftGauge;
    public Scrollbar rightGauge;

    public Text timerText;

    public BattleController battle;

    // Start is called before the first frame update
    void Start()
    {
        leftText.text = player1.fighterName;
        rightText.text = player2.fighterName;
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = battle.roundTime.ToString();

        if (leftBar.size > player1.healtPercent)
        {
            leftBar.size -= 0.01f;
        }
        if (rightBar.size > player2.healtPercent)
        {
            rightBar.size -= 0.01f;
        }

        if (leftGauge.size > player1.gaugePercent)
        {
            leftGauge.size -= 0.01f;
        }
        else if (leftGauge.size < player1.gaugePercent)
        {
            leftGauge.size += 0.01f;
        }

        if (rightGauge.size > player2.gaugePercent)
        {
            rightGauge.size -= 0.01f;
        }
        else if(rightGauge.size < player2.gaugePercent)
        {
            rightGauge.size += 0.01f;
        }
    }
}
