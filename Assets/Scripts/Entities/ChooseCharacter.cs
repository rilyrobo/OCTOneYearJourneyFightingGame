using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacter : ChooseCharacterManager
{
    public float chooseCharacterInputTimer;
    public float chooseCharacterInputDelay = 1f;

    public AudioClip selectCharacterButtonPress;

    public GameObject ModelForPlayer1;
    public GameObject ModelForPlayer2;

    private GameObject characterDemo;

    public int characterSelectState;

    private enum CharacterSelectModels
    {
        Ai = 00,
        Alaster = 01,
        Aminta = 02,
        Ben = 03,
        Daniel = 04,
        Francis = 05,
        FufBoon = 06,
        GodAborim = 07,
        GodEmruu = 08,
        GodEquinox = 09,
        GodMia = 10,
        Il = 11,
        Jackson = 12,
        Kali = 13,
        Leroy = 14,
        Mathew = 15,
        Matriarch = 16,
        Mirth = 17,
        Mollisol = 18,
        MrSunshine = 19,
        Nacim = 20,
        Pam = 21,
        Rossery = 22,
        Sam = 23,
        Stalker = 24,
        Taika = 25,
        Vadim = 26,
        Vic = 27
    }

    // Start is called before the first frame update
    void Start()
    {
        CharacterSelectManager();
    }

    // Update is called once per frame
    void Update()
    {
        if (chooseCharacterInputTimer > 0)
        {
            chooseCharacterInputTimer -= 1f * Time.deltaTime;
        }

        if (chooseCharacterInputTimer > 0)
        {
            return;
        }

        if (Input.GetAxis("Horizontal") < -0.5f)
        {
            if (characterSelectState == 0)
            {
                return;
            }
            GetComponent<AudioSource>().PlayOneShot(selectCharacterButtonPress);

            characterSelectState--;
            CharacterSelectManager();

            chooseCharacterInputTimer = chooseCharacterInputDelay;
        }

        if (Input.GetAxis("Horizontal") > 0.5f)
        {
            if (characterSelectState == 27)
            {
                return;
            }
            characterSelectState++;
            CharacterSelectManager();

            chooseCharacterInputTimer = chooseCharacterInputDelay;
        }
    }

    private void CharacterSelectManager()
    {
        switch (characterSelectState)
        {
            default:
            case 00:
                Ai();
                break;
            case 01:
                Alaster();
                break;
            case 02:
                Aminta();
                break;
            case 03:
                Ben();
                break;
            case 04:
                Daniel();
                break;
            case 05:
                Francis();
                break;
            case 06:
                FufBoon();
                break;
            case 07:
                GodAborim();
                break;
            case 08:
                GodEmruu();
                break;
            case 09:
                GodEquinox();
                break;
            case 10:
                GodMia();
                break;
            case 11:
                Il();
                break;
            case 12:
                Jackson();
                break;
            case 13:
                Kali();
                break;
            case 14:
                Leroy();
                break;
            case 15:
                Mathew();
                break;
            case 16:
                Matriarch();
                break;
            case 17:
                Mirth();
                break;
            case 18:
                Mollisol();
                break;
            case 19:
                MrSunshine();
                break;
            case 20:
                Nacim();
                break;
            case 21:
                Pam();
                break;
            case 22:
                Rossery();
                break;
            case 23:
                Sam();
                break;
            case 24:
                Stalker();
                break;
            case 25:
                Taika();
                break;
            case 26:
                Vadim();
                break;
            case 27:
                Vic();
                break;

        }
    }

    private void Ai()
    {
        Debug.Log("Ai");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Ai")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = true;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Alaster()
    {
        Debug.Log("Alaster");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Alaster")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = true;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Aminta()
    {
        Debug.Log("Aminta");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Aminta")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = true;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Ben()
    {
        Debug.Log("Ben");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Ben")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = true;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Daniel()
    {
        Debug.Log("Daniel");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Daniel")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = true;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Francis()
    {
        Debug.Log("Francis");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Francis")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = true;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void FufBoon()
    {
        Debug.Log("FufBoon");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("FufBoon")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = true;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void GodAborim()
    {
        Debug.Log("GodAborim");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("GodAborim")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = true;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void GodEmruu()
    {
        Debug.Log("GodEmruu");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("GodEmruu")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = true;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void GodEquinox()
    {
        Debug.Log("GodEquinox");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("GodEquinox")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = true;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void GodMia()
    {
        Debug.Log("GodMia");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("GodMia")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = true;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Il()
    {
        Debug.Log("Il");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Il")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = true;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Jackson()
    {
        Debug.Log("Jackson");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Jackson")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = true;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Kali()
    {
        Debug.Log("Kali");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Kali")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = true;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Leroy()
    {
        Debug.Log("Leroy");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Leroy")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = true;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Mathew()
    {
        Debug.Log("Mathew");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Mathew")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = true;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Matriarch()
    {
        Debug.Log("Matriarch");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Matriarch")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = true;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Mirth()
    {
        Debug.Log("Mirth");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Mirth")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = true;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Mollisol()
    {
        Debug.Log("Mollisol");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Mollisol")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = true;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void MrSunshine()
    {
        Debug.Log("MrSunshine");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("MrSunshine")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = true;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Nacim()
    {
        Debug.Log("Nacim");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Nacim")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = true;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Pam()
    {
        Debug.Log("Pam");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Pam")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = true;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Rossery()
    {
        Debug.Log("Rossery");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Rossery")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = true;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Sam()
    {
        Debug.Log("Sam");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Sam")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = true;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Stalker()
    {
        Debug.Log("Stalker");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Stalker")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = true;
        charTaika = false;
        charVadim = false;
        charVic = false;
    }

    private void Taika()
    {
        Debug.Log("Taika");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Taika")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = true;
        charVadim = false;
        charVic = false;
    }

    private void Vadim()
    {
        Debug.Log("Vadim");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Vadim")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = true;
        charVic = false;
    }

    private void Vic()
    {
        Debug.Log("Vic");

        DestroyObject(characterDemo); //destroy demo

        characterDemo = Instantiate(Resources.Load("Vic")) as GameObject; //replace demo with object in resource folder

        characterDemo.transform.position = new Vector3(-5, -1, 3.38f); //character demo position

        charAi = false;
        charAlaster = false;
        charAminta = false;
        charBen = false;
        charDaniel = false;
        charFrancis = false;
        charFufBoon = false;
        charGodAborim = false;
        charGodEmruu = false;
        charGodEquinox = false;
        charGodMia = false;
        charIl = false;
        charJackson = false;
        charKali = false;
        charLeroy = false;
        charMathew = false;
        charMatriarch = false;
        charMirth = false;
        charMollisol = false;
        charMrSunshine = false;
        charNacim = false;
        charPam = false;
        charRossery = false;
        charSam = false;
        charStalker = false;
        charTaika = false;
        charVadim = false;
        charVic = true;
    }

    void OnGUI()
    {

    }

}