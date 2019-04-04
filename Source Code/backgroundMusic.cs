using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class backgroundMusic : MonoBehaviour
{
    AudioSource audioSrc;
    public static float volume;
    public int counter, counterChanged;
    void Awake()
    {
        AudioSource audioSrc = GetComponent<AudioSource>();
        audioSrc.ignoreListenerVolume = true;
    }

    void Start()
    {

        audioSrc = GetComponent<AudioSource>();
        volume = 0.12f;
    }

    void Update()
    {
        counter = EventScript.counter;
        counterChanged = EventScript.counterChanged;

        if (counter <= 1780 && counter > 40)
        {
            audioSrc.volume = 0.06f;
        }

        if (counter <= 1860 && counter > 1780)//ouder
        {
            if (counterChanged != counter)//40
            {
                audioSrc.volume -= (0.06f / 80f);
            }
        }

        if (counter <= 2080 && counter > 2040)
        {
            audioSrc.volume = 0.2f;
        }
    }
}
 