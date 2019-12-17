using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    public enum PlayerType
    {
        human, ai
    };

    public static float maxHealth = 100f;
    public static float maxGauge = 100f;

    public float healt = maxHealth;
    public float gauge = maxGauge;
    public string fighterName;
    public Fighter opponent;

    public CharacterSelect character;

    public bool enable;

    public PlayerType player;
    public FighterStates currentState = FighterStates.Idle;

    protected Animator animator;
    public Rigidbody myBody;
    public AudioSource audioPlayer;

    //for AI only
    private float random;
    private float randomSetTime;

    // Start is called before the first frame update
    void Start()
    {
        gauge = 0;
        myBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        audioPlayer = GetComponent<AudioSource>();
    }

    public void updateHumanInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("MovementB", true);
        }
        else
        {
            animator.SetBool("MovementB", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("MovementF", true);
        }
        else
        {
            animator.SetBool("MovementF", false);
        }


        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Crouch", true);
        }
        else
        {
            animator.SetBool("Crouch", false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Jump");
        }

        //attack & use controls
        if (Input.GetKeyDown(KeyCode.U))
        {
            animator.SetTrigger("Punch1");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            animator.SetTrigger("Kick1");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            animator.SetTrigger("Ranged1");
        }

        if (Input.GetKey(KeyCode.J))
        {
            animator.SetBool("Defend", true);
        }
        else
        {
            animator.SetBool("Defend", false);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("Grab");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetTrigger("Special1");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetTrigger("Finisher1");
            gauge = 0;
        }
        
    }

    public void updateAiInput()
    {
        animator.SetBool("Defend", defending);
        animator.SetBool("Invulnerable", invulnerable);
        animator.SetBool("Enable", enable);

        animator.SetBool("OpponentAttacking", opponent.attacking);
        animator.SetFloat("DistanceToOpponent", getDistanceToOpponent());

        if (Time.time - randomSetTime > 1)
        {
            random = Random.value;
            randomSetTime = Time.time;
        }
        animator.SetFloat("Random", random);
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Health", healtPercent);
        animator.SetFloat("Gauge", gaugePercent);


        if (opponent != null)
        {
            animator.SetFloat("Opponent_Health", opponent.healtPercent);
        }
        else
        {
            animator.SetFloat("Opponent_Health", 1);
        }

        if (enable)
        {
            if (player == PlayerType.human)
            {
                updateHumanInput();
            }
            else
            {
                updateAiInput();
            }
        }

        if (healt <= 0 && currentState != FighterStates.Death)
        {
            animator.SetTrigger("Death");
        }
    }

    private float getDistanceToOpponent()
    {
        return Mathf.Abs(transform.position.x - opponent.transform.position.x);
    }

    public virtual void hurt(float damage)
    {
        if (!invulnerable)
        {
            if (defending)
            {
                damage *= 0.2f;
            }
            if (healt >= damage)
            {
                healt -= damage;
                gauge += (damage*2);
                opponent.gauge += (damage * 3);
            }
            else
            {
                healt = 0;
            }

            if (healt > 0)
            {
                animator.SetTrigger("Hit1");
            }
        }
    }

    public void playSound(AudioClip sound)
    {
        GameUtils.playSound(sound, audioPlayer);
    }

    public bool invulnerable
    {
        get
        {
            return currentState == FighterStates.Hit || currentState == FighterStates.DefendHit || currentState == FighterStates.Death;
        }
    }

    public bool defending
    {
        get
        {
            return currentState == FighterStates.Defend || currentState == FighterStates.DefendHit;
        }
    }

    public bool attacking
    {
        get
        {
            return currentState == FighterStates.Attack;
        }
    }

    public float healtPercent
    {
        get
        {
            return healt / maxHealth;
        }
    }

    public float gaugePercent
    {
        get
        {
            return gauge / maxGauge;
        }
    }

    public Rigidbody body
    {
        get
        {
            return this.myBody;
        }
    }
}
