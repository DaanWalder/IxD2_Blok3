using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;

public class EventScript : MonoBehaviour
{

    string name;

    public GameObject one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fiftheen;

    public GameObject eventText, FbScript, displayName;

    public InputField fullName;

    public GameObject numLikes, numComments, numFriends, numAge;

    int likes = 80, comments = 30, age = 15, friends = 437;

    public static int counter = 0, counterChanged = 0;

    float lerp = 0f, duration = 1f;

    private float lerpLikes = 100f, lerpComments = 40f, lerpAge = 16f, lerpFriends = 437;

    private float volSoundEffect = 0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeline();
    }

    void OnMessageArrived(string msg)
    {
        counter = int.Parse(msg);
    }

    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }

    public void timeline()
    {
        name = fullName.text;
        Text Username = displayName.GetComponent<Text>();
        Username.text = "" + name;
        Text txtEvent = eventText.GetComponent<Text>();
        lerp += Time.deltaTime / duration;

        if (counter <= 40 && counter > 0)
        {
            

            if (counterChanged != counter)
            {
                
                counterChanged = counter;
            }
        }

        if (counter <= 120 && counter > 40)
        {
            lerpAge = 18f;
            one.SetActive(true);
            
            txtEvent.text = name + " is jarig!";
            if (counterChanged != counter)
            {
                lerpFriends += (10f / 80f);
                lerpLikes += (20f / 80f); //100
                lerpComments += (10f / 80f); //40
                counterChanged = counter;
            }
        }

        if (counter <= 180 && counter >  120)
        {
            one.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (2f / 60f); //18
                counterChanged = counter;
                
            }
        }

        if (counter <= 260 && counter > 180)
        {
            two.SetActive(true);
            txtEvent.text = name + " is afgestudeerd!";
            if (counterChanged != counter)
            {
                lerpFriends += (4f / 80f);
                lerpLikes += (5f / 80f); //105
                lerpComments += (6f / 80f); //46
                counterChanged = counter;
            }
        }

        if (counter <= 280 && counter > 260)
        {
            two.SetActive(false);
            txtEvent.text = " ";
        }

        if (counter <= 360 && counter > 280)
        {
            three.SetActive(true);
            txtEvent.text = name + " is begonnen met studeren!";
            if (counterChanged != counter)
            {
                lerpFriends += (6f / 80f);
                lerpLikes += (15f / 80f); //120
                lerpComments += (6f / 80f); //52
                counterChanged = counter;
            }
        }

        if (counter <= 420 && counter > 360)
        {
            three.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (5f / 60f); //23
                counterChanged = counter;
            }
        }

        if (counter <= 500 && counter > 420)
        {
            four.SetActive(true);
            txtEvent.text = name + " is verhuist.";
            if (counterChanged != counter)
            {
                lerpFriends += (2f / 80f);
                lerpLikes += (20f / 80f);//140
                lerpComments += (-16f / 80f); //36
                counterChanged = counter;
            }
        }

        if (counter <= 560 && counter > 500)
        {
            four.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (2f / 60f); //25
                counterChanged = counter;
            }
        }

        if (counter <= 640 && counter > 560)
        {
            six.SetActive(true);
            txtEvent.text = name + " is afgestudeerd!";
            if (counterChanged != counter)
            {
                lerpLikes += (5f / 80f); //145
                lerpComments += (4f / 80f);//40
                lerpFriends += (13f / 80f);
                counterChanged = counter;
            }
        }

        if (counter <= 680 && counter > 640)
        {
            six.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (1f / 40f); //26
                counterChanged = counter;
            }
        }

        if (counter <= 760 && counter > 680)
        {
            five.SetActive(true);
            txtEvent.text = name + " heeft een relatie.";
            if (counterChanged != counter)
            {
                lerpLikes += (17f / 80f); //162
                lerpComments += (24f / 80f);//64
                lerpFriends += (2f / 80f);
                counterChanged = counter;
            }
        }

        if (counter <= 800 && counter > 760)
        {
            five.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (1f / 40f); //27
                counterChanged = counter;
            }
        }

        if (counter <= 880 && counter > 800)
        {
            seven.SetActive(true);
            txtEvent.text = name + " is begonnen met werken.";
            if (counterChanged != counter)
            {
                lerpFriends += (3f / 80f);
                lerpLikes += (-9f / 80f); //153
                lerpComments += (-35f / 80f);//29
                counterChanged = counter;
            }
        }

        if (counter <= 920 && counter > 880)
        {
            seven.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (2f / 40f); //29
                counterChanged = counter;
            }
        }

        if (counter <= 1000 && counter > 920)
        {
            eight.SetActive(true);
            txtEvent.text = name + " heeft een kind gekregen.";
            if (counterChanged != counter)
            {
                lerpFriends += (6f / 80f);
                lerpLikes += (40f / 80f); //202
                lerpComments += (54f / 80f);//92
                counterChanged = counter;
            }
        }

        if (counter <= 1040 && counter > 1000)
        {
            eight.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (3f / 40f); //32
                counterChanged = counter;
            }
        }

        if (counter <= 1120 && counter > 1040)
        {
            nine.SetActive(true);
            txtEvent.text = name + " heeft een huis gekocht.";
            if (counterChanged != counter)
            {
                lerpFriends += (1f / 80f);
                lerpLikes += (-22f / 80f); //179
                lerpComments += (-69f / 80f);//58
                counterChanged = counter;
            }
        }

        if (counter <= 1180 && counter > 1120)
        {
            nine.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (2f / 40f); //34
                counterChanged = counter;
            }
        }

        if (counter <= 1260 && counter > 1180)
        {
            eleven.SetActive(true);
            txtEvent.text = name + " is getrouwd.";
            if (counterChanged != counter)
            {
                lerpFriends += (16f / 80f);
                lerpLikes += (39f / 80f); //218
                lerpComments += (54f / 80f);//112
                counterChanged = counter;
            }
        }

        if (counter <= 1340 && counter > 1260)
        {
            eleven.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (6f / 80f); //40
                counterChanged = counter;
            }
        }

        if (counter <= 1420 && counter > 1340)
        {
            ten.SetActive(true);
            txtEvent.text = name + " heeft promotie op werk gekregen.";
            if (counterChanged != counter)
            {
                lerpLikes += (-73f / 80f); //145
                lerpComments += (-40f / 80f);//43
                counterChanged = counter;
            }
        }

        if (counter <= 1460 && counter > 1420)
        {
            ten.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (5f / 40f); //45
                counterChanged = counter;
            }
        }

        if (counter <= 1540 && counter > 1460)
        {
            nine.SetActive(true);
            txtEvent.text = name + " is verhuist.";
            if (counterChanged != counter)
            {
                lerpLikes += (-21f / 80f); //124
                lerpComments += (-6f / 80f);//37
                counterChanged = counter;
            }
        }

        if (counter <= 1580 && counter > 1540)
        {
            nine.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpAge += (5f / 40f); //50
                counterChanged = counter;
            }
        }

        if (counter <= 1640 && counter > 1580)
        {
            one.SetActive(true);
            txtEvent.text = name + " is 50 geworden.";
            if (counterChanged != counter)
            {
                lerpFriends -= (10f / 80f);
                lerpLikes += (26f / 80f); //150
                lerpComments += (15f / 80f);//52
                counterChanged = counter;
            }
        }

        if (counter <= 1700 && counter > 1640)
        {
            one.SetActive(false);
            if (counterChanged != counter)
            {
                txtEvent.text = " ";
                lerpFriends -= (70f / 80f);
                lerpAge += (8f / 60f); //58
                counterChanged = counter;
            }
        }

        if (counter <= 1780 && counter > 1700)
        {
            eight.SetActive(true);
            txtEvent.text = name + " heeft een kleinkind gekregen.";
            if (counterChanged != counter)
            {
                lerpFriends -= (26f / 80f);
                lerpLikes += (-50f / 80f); //100
                lerpComments += (-5f / 80f);//36
                counterChanged = counter;
            }
        }

        if (counter <= 1860 && counter > 1780)
        {
            eight.SetActive(false);
            if (counterChanged != counter)
            {
                lerpFriends -= (38f / 80f);
                txtEvent.text = " ";
                lerpAge += (10f / 80f); //68
                counterChanged = counter;
            }
        }

        if (counter <= 1940 && counter > 1860)
        {
            twelve.SetActive(true);
            txtEvent.text = name + " is met pensioen.";
            if (counterChanged != counter)
            {
                lerpFriends -= (20f / 80f);
                lerpLikes += (-45f / 80f); //55
                lerpComments += (-4f / 80f);//23
                counterChanged = counter;
            }
        }

        if (counter <= 2140 && counter > 1940)
        {
            twelve.SetActive(false);
            if (counterChanged != counter)
            {
                lerpFriends -= (140f / 80f);
                txtEvent.text = " ";
                lerpAge += (17f / 100f); //85
                counterChanged = counter;
            }
        }
        if (lerpFriends < 15)
        {
            friends = 15;
        }
        if (counter <= 2240 && counter > 2140)
        {
            thirteen.SetActive(true);
            txtEvent.text = name + " is overleden.";
            if (counterChanged != counter)
            {
                lerpLikes += (-31f / 80f); //24
                lerpComments += (-2f / 80f);//15
                counterChanged = counter;
            }
        }

        if (counter <= 2260 && counter > 2240)
        {
            thirteen.SetActive(false);
            txtEvent.text = "Misschien merk je er zelf niks van,";
        }

        if (counter <= 2320 && counter > 2260)
        {
            thirteen.SetActive(false);
            txtEvent.text = "Maar meer dan helft van de mensen ouder dan 75 jaar zegt zich eenzaam te voelen.";
        }

        if (counter <= 2360 && counter > 2320)
        {
            thirteen.SetActive(false);
            txtEvent.text = "Kijk hoe jij een eenzame ouder kan helpen op zorgvoorbeter.nl";
        }

        
        likes = (int)Mathf.Lerp(likes, lerpLikes, lerp);
        comments = (int)Mathf.Lerp(comments, lerpComments, lerp);
        age = (int)Mathf.Lerp(age, lerpAge, lerp);
        Text txtLikes = numLikes.GetComponent<Text>();
        Text txtComments = numComments.GetComponent<Text>();
        Text txtAge = numAge.GetComponent<Text>();
        txtLikes.text = likes.ToString();
        txtComments.text = comments.ToString() + " Comments";
        txtAge.text = "Age: " + age.ToString();

        friends = (int)Mathf.Lerp(friends, lerpFriends, lerp);
        Text txtFriends = numFriends.GetComponent<Text>();
        txtFriends.text = "Friends: " + friends.ToString();
    }
}
