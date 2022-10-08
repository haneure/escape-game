using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t_text : MonoBehaviour
{
    public bool useTimer;
    public int time;
    GameObject text;

    public GameObject c_showCTRL;
    t_collider getCTRLInput;

    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject;

        //Check if gameobject c_showCTRL diattach di inspector ato tidak
        if(c_showCTRL != null){
            getCTRLInput = c_showCTRL.GetComponent<t_collider>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(c_showCTRL != null){
            if(getCTRLInput.h_showCTRL == true) {
                text.SetActive(false);
            }
        }
        

        if(useTimer == true) {
            time--;
            if(time == 0) {
                text.SetActive(false);
            }
        }
    }
}
