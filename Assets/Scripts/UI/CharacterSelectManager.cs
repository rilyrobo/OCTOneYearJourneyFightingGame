using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectManager : MonoBehaviour
{
    private int[] vertical = new int[] {-117, -39, 39, 117};
    private float[] horizontal = new float[] {-237f,-158f,-79f,0f,79f,158f,237f};
    public GameObject parent;

    private void Start() {
        var h = 0;
        var v = 0;
        foreach (RectTransform child in parent.transform)
        {            
            child.anchoredPosition = new Vector3(horizontal[h],vertical[v],0);
            v++;
            if(v==4){
                v=0;
                h++;
            }
            if(h==7){
                h=0; 
            }

            // Debug.Log(child.anchoredPosition);
        }
    }
}