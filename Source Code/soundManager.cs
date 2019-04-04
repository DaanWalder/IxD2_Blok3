using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public int counter, counterChanged;
    public float volume;
    public GameObject one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fiftheen, sixteen, beep;

    public AudioClip tickOne, tickTwo;
    AudioSource oneTick, twoTick;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    { 
        counter = EventScript.counter;
        counterChanged = EventScript.counterChanged;
        timeline();
    }

    public void timeline() //De counter staat in verbinding met de rotary encoder
    {
    if (counter <= 40 && counter > 0)
        {
            
            if (counterChanged != counter)
            {
                if (counter == 5)
                {
                    oneTick = GetComponent<AudioSource>();
                    oneTick.PlayOneShot(tickOne, 1f);
                }
                if (counter == 10)
                {
                    twoTick = GetComponent<AudioSource>();
                    twoTick.PlayOneShot(tickTwo, 1f);
                }

                if (counter == 15)
                {
                    oneTick = GetComponent<AudioSource>();
                    oneTick.PlayOneShot(tickOne, 1f);
                }
                if (counter == 20)
                {
                    twoTick = GetComponent<AudioSource>();
                    twoTick.PlayOneShot(tickTwo, 1f);
                }
                if (counter == 25)
                {
                    oneTick = GetComponent<AudioSource>();
                    oneTick.PlayOneShot(tickOne, 1f);
                }
                if (counter == 30)
                {
                    twoTick = GetComponent<AudioSource>();
                    twoTick.PlayOneShot(tickTwo, 1f);
                }

                if (counter == 35)
                {
                    oneTick = GetComponent<AudioSource>();
                    oneTick.PlayOneShot(tickOne, 1f);
                }
                if (counter == 40)
                {
                    twoTick = GetComponent<AudioSource>();
                    twoTick.PlayOneShot(tickTwo, 1f);
                }
                
            }
        }

        if (counter <= 120 && counter > 40) //jarig
        {
            
            AudioListener.volume = 1f;
            one.SetActive(true);
            
        }

        if (counter <= 180 && counter >  120) //ouder
        {
            if (counterChanged != counter)//60
            {
                AudioListener.volume -= (1f / 60f);
            }
        }

        if (counter <= 260 && counter > 180) //graduation
        {
            AudioListener.volume = 1f;
            one.SetActive(false);
            two.SetActive(true);
        }

        if (counter <= 280 && counter > 260) // ouder
        {
            AudioListener.volume -= (1f / 20f);
        }

        if (counter <= 360 && counter > 280) //studeren
        {
            AudioListener.volume = 1f;
            two.SetActive(false);
            three.SetActive(true);
        }

        if (counter <= 420 && counter > 360) //ouder
        {
            if (counterChanged != counter)//60
            {
                AudioListener.volume -= (1f / 60f);
            }
        }

        if (counter <= 500 && counter > 420)// verhuizen
        {
            AudioListener.volume = 1f;
            three.SetActive(false);
            four.SetActive(true);
        }

        if (counter <= 560 && counter > 500)//ouder
        {
            if (counterChanged != counter)//60
            {
                AudioListener.volume -= (1f / 60f);
            }
        }

        if (counter <= 640 && counter > 560)//graduation college
        {
            AudioListener.volume = 1f;
            four.SetActive(false);
            five.SetActive(true);

        }

        if (counter <= 680 && counter > 640)//ouder
        {
            if (counterChanged != counter)//40
            {
                AudioListener.volume -= (1f / 40f);
            }
        }

        if (counter <= 760 && counter > 680)//relatie
        {
            AudioListener.volume = 1f;
            five.SetActive(false);
            six.SetActive(true);
        }

        if (counter <= 800 && counter > 760) // ouder
        {
            if (counterChanged != counter)//40
            {
                AudioListener.volume -= (1f / 40f);
            }
        }

        if (counter <= 880 && counter > 800)
        {
            AudioListener.volume = 1f;
            six.SetActive(false);
            seven.SetActive(true);
        }

        if (counter <= 920 && counter > 880) // ouder
        {
            if (counterChanged != counter)//40
            {
                AudioListener.volume -= (1f / 40f);
            }
        }

        if (counter <= 1000 && counter > 920)
        {
            AudioListener.volume = 1f;
            seven.SetActive(false);
            eight.SetActive(true);
        }

        if (counter <= 1040 && counter > 1000)// ouder
        {
            if (counterChanged != counter)//40
            {
                AudioListener.volume -= (1f / 40f);
            }
        }

        if (counter <= 1120 && counter > 1040)
        {
            AudioListener.volume = 1f;
            eight.SetActive(false);
            nine.SetActive(true);
        }

        if (counter <= 1180 && counter > 1120) // ouder
        {
            if (counterChanged != counter)//40
            {
                AudioListener.volume -= (1f / 40f);
            }
        }

        if (counter <= 1260 && counter > 1180)
        {
            AudioListener.volume = 1f;
            nine.SetActive(false);
            ten.SetActive(true);
        }

        if (counter <= 1340 && counter > 1260)  // ouder
        {
            if (counterChanged != counter)//40
            {
                AudioListener.volume -= (1f / 40f);
            }
        }

        if (counter <= 1420 && counter > 1340)
        {
            AudioListener.volume = 1f;
            ten.SetActive(false);
            eleven.SetActive(true);
        }

        if (counter <= 1460 && counter > 1420) // ouder
        {
            if (counterChanged != counter)//40
            {
                AudioListener.volume -= (1f / 40f);
            }
        }

        if (counter <= 1540 && counter > 1460) //Verhuist
        {
            AudioListener.volume = 1f;
            eleven.SetActive(false);
            twelve.SetActive(true);
        }

        if (counter <= 1580 && counter > 1540) // ouder
        {
            if (counterChanged != counter)//40
            {
                AudioListener.volume -= (1f / 40f);
            }
        }

        if (counter <= 1640 && counter > 1580)//50jr
        {
            AudioListener.volume = 1f;
            twelve.SetActive(false);
            thirteen.SetActive(true);
        }

        if (counter <= 1780 && counter > 1700)//kleinkind
        {
            AudioListener.volume = 1f;
            //thirteen.SetActive(false);
            fourteen.SetActive(true);
        }

        if (counter <= 1860 && counter > 1780)//ouder
        {
            if (counterChanged != counter)//40
            {
                AudioListener.volume -= (1f / 80f);
            }
        }

        if (counter <= 2040 && counter > 1860)//pensioen
        {
            fourteen.SetActive(false);
            fiftheen.SetActive(true);
            thirteen.SetActive(false);
            if (counter <= 1990 && counter > 1940)// ouder
            {
                if (counterChanged != counter)//50
                {
                    AudioListener.volume += (1f / 100f);
                }
            }
        }

        if (counter <= 2140 && counter > 1990)// ouder
        {
            beep.SetActive(true);
        }

        if (counter <= 2360 && counter > 2140)// overleden
        {
            //volume = 0.4f;
            beep.SetActive(false);
            AudioListener.volume = 1f;
            fiftheen.SetActive(false);
            if (counter <= 2200 && counter > 2140)
            {
                sixteen.SetActive(true);
            }
            if (counter <= 2360 && counter > 2200)
            {
                sixteen.SetActive(false);
            }
        }

    }
}
