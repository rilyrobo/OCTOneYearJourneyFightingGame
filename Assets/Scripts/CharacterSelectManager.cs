using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectManager : MonoBehaviour
{
    private float[] vertical = new float[] {-117f, -196f, -275f, -353f};
    private float[] horizontal = new float[] {-237f,-158f,-79f,0f,79f,158f,237f};
    public GameObject parent;

    private void Start() {
        var h = 0;
        var v = 0;
        foreach (Transform child in parent.transform)
        {            
            child.position = parent.transform.position + new Vector3(horizontal[h],vertical[v],0);
            h++;
            if(v==4){
                v=0;
                
            }
            if(h==7){
                h=0;
                v++;
            }
        }
    }
}