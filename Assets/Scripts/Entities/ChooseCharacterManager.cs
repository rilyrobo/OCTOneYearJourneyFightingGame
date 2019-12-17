using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacterManager : MonoBehaviour
{
    //if charcter is selected
    public static bool charAi;
    public static bool charAlaster;
    public static bool charAminta;
    public static bool charBen;
    public static bool charDaniel;
    public static bool charFrancis;
    public static bool charFufBoon;
    public static bool charGodAborim;
    public static bool charGodEmruu;
    public static bool charGodEquinox;
    public static bool charGodMia;
    public static bool charIl;
    public static bool charJackson;
    public static bool charKali;
    public static bool charLeroy;
    public static bool charMathew;
    public static bool charMatriarch;
    public static bool charMirth;
    public static bool charMollisol;
    public static bool charMrSunshine;
    public static bool charNacim;
    public static bool charPam;
    public static bool charRossery;
    public static bool charSam;
    public static bool charStalker;
    public static bool charTaika;
    public static bool charVadim;
    public static bool charVic;

    void Awake()
    {
        //character is false at start
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
        charVic = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
