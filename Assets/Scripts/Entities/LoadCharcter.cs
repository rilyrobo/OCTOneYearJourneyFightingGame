using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharcter : MonoBehaviour
{
    private GameObject player1Character;

    //character list
    private bool returnAi;
    private bool returnAlaster;
    private bool returnAminta;
    private bool returnBen;
    private bool returnDaniel;
    private bool returnFrancis;
    private bool returnFufBoon;
    private bool returnGodAborim;
    private bool returnGodEmruu;
    private bool returnGodEquinox;
    private bool returnGodMia;
    private bool returnIl;
    private bool returnJackson;
    private bool returnKali;
    private bool returnLeroy;
    private bool returnMathew;
    private bool returnMatriarch;
    private bool returnMirth;
    private bool returnMollisol;
    private bool returnMrSunshine;
    private bool returnNacim;
    private bool returnPam;
    private bool returnRossery;
    private bool returnSam;
    private bool returnStalker;
    private bool returnTaika;
    private bool returnVadim;
    private bool returnVic;

    // Start is called before the first frame update
    void Start()
    {
        returnAi = ChooseCharacterManager.charAi;
        returnAlaster = ChooseCharacterManager.charAlaster;
        returnAminta = ChooseCharacterManager.charAminta;
        returnBen = ChooseCharacterManager.charBen;
        returnDaniel = ChooseCharacterManager.charDaniel;
        returnFrancis = ChooseCharacterManager.charFrancis;
        returnFufBoon = ChooseCharacterManager.charFufBoon;
        returnGodAborim = ChooseCharacterManager.charGodAborim;
        returnGodEmruu = ChooseCharacterManager.charGodEmruu;
        returnGodEquinox = ChooseCharacterManager.charGodEquinox;
        returnGodMia = ChooseCharacterManager.charGodMia;
        returnIl = ChooseCharacterManager.charIl;
        returnJackson = ChooseCharacterManager.charJackson;
        returnKali = ChooseCharacterManager.charKali;
        returnLeroy = ChooseCharacterManager.charLeroy;
        returnMathew = ChooseCharacterManager.charMathew;
        returnMatriarch = ChooseCharacterManager.charMatriarch;
        returnMirth = ChooseCharacterManager.charMirth;
        returnMollisol = ChooseCharacterManager.charMollisol;
        returnMrSunshine = ChooseCharacterManager.charMrSunshine;
        returnNacim = ChooseCharacterManager.charNacim;
        returnPam = ChooseCharacterManager.charPam;
        returnRossery = ChooseCharacterManager.charRossery;
        returnSam = ChooseCharacterManager.charSam;
        returnStalker = ChooseCharacterManager.charStalker;
        returnTaika = ChooseCharacterManager.charTaika;
        returnVadim = ChooseCharacterManager.charVadim;
        returnVic = ChooseCharacterManager.charVic;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadPlayer1Character()
    {
        Debug.Log("LoadPlayer1Character");
    }
}
