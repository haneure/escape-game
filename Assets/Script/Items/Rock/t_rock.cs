using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t_rock : MonoBehaviour
{
    Guard guard;

    public AudioSource rockAudio;
    private float openDelay = 0;

    public AudioClip rockThrow;
    private float volume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        

        if(other.gameObject.tag == "guard" || other.transform.root.CompareTag("guard")) {
            Debug.Log(other.gameObject.tag);
            if(other.gameObject.tag == "guard"){
                guard = GameObject.Find(other.gameObject.name).GetComponent<Guard>();
            } else if (other.transform.root.CompareTag("guard")) {
                Debug.Log(other.transform.parent.name);
                guard = GameObject.Find(other.transform.parent.name).GetComponent<Guard>();

            }

            rockAudio = Instantiate(gameObject.AddComponent<AudioSource>());
            // rockAudio.PlayDelayed(openDelay);
            rockAudio.PlayOneShot(rockThrow, volume);

            guard.stunTime = 150;
            guard.stunned = true;
        }
    }
}
