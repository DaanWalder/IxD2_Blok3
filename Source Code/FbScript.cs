using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using Facebook.MiniJSON;
using UnityEngine.UI;

public class FbScript : MonoBehaviour
{
    public GameObject DialogLoggedIn;
    public GameObject DialogLoggedOut;
    public GameObject FullName;
    public GameObject ProfilePicture;
    public GameObject NumFriends;
    public GameObject Age;
    public string Name;

    void Awake()
    {
        FB.Init(SetInit, OnHideUnity);
    }

    // Update is called once per frame
    void SetInit()
    {
        if (FB.IsLoggedIn)
        {
            Debug.Log("Facebook is logged in");
        }
        else
        {
            Debug.Log("Facebook is not logged in");
        }
        DealWithFBMenus(FB.IsLoggedIn);
    }
    void OnHideUnity(bool isGameShown)
    {
        if (!isGameShown)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void FBlogin()
    {
        List<string> permissions = new List<string>();
        permissions.Add("public_profile");

        FB.LogInWithReadPermissions(permissions, AuthCallBack);
    }

    void AuthCallBack(IResult result)
    {
        if(result.Error != null)
        {
            Debug.Log(result.Error);
        } else
        {
            if (FB.IsLoggedIn)
            {
                Debug.Log("Facebook is logged in");
            }
            else
            {
                Debug.Log("Facebook not logged in");
            }
            DealWithFBMenus(FB.IsLoggedIn);
        }
        
    }
    void DealWithFBMenus(bool isLoggedIn)
    {
        if (isLoggedIn)
        {

            DialogLoggedIn.SetActive(true);
            DialogLoggedOut.SetActive(false);

            FB.API("/me/picture?type=square&height=128&width=128", HttpMethod.GET, DisplayProfilePic);
            FB.API("/me?fields=name", HttpMethod.GET, DisplayUsername);
            FB.API("/me?fields=first_name", HttpMethod.GET, DisplayFirstUsername);
            FB.API("/me/friends?summary=total_count", HttpMethod.GET, DisplayFriends);

            foreach (string perm in AccessToken.CurrentAccessToken.Permissions)
            {
                // log each granted permission
                Debug.Log(perm);
            }
        }
        else
        {
            DialogLoggedIn.SetActive(false);
            DialogLoggedOut.SetActive(true);
        }
    }

    void DisplayUsername(IResult result)
    {
        Text Username = FullName.GetComponent<Text>();
        if (result.Error == null)
        {
            Username.text = "" + result.ResultDictionary["name"];
        }
        else
        {
            Debug.Log(result.Error);
        }
    }

    void DisplayFirstUsername(IResult result)
    {
        if (result.Error == null)
        {
            Name = result.ResultDictionary["first_name"].ToString();
        }
        else
        {
            Debug.Log(result.Error);
        }
    }

        void DisplayProfilePic(IGraphResult result)
    {
        if (result.Texture != null)
        {
            Image ProfilePic = ProfilePicture.GetComponent<Image>();
            ProfilePic.sprite = Sprite.Create(result.Texture, new Rect(0, 0, 128, 128), new Vector2());
        }
    }

    void DisplayFriends(IGraphResult result)
    {
        Debug.Log(result);
        var dictionary = (Dictionary<string, object>)Facebook.MiniJSON.Json.Deserialize(result.RawResult);
        var friends = (List<object>)dictionary["summary"];

        if (result.ResultDictionary != null)
        {
            foreach (string key in result.ResultDictionary.Keys)
            {
                Debug.Log(key + " : " + result.ResultDictionary[key].ToString());
                Text Friends = NumFriends.GetComponent<Text>();
                Friends.text = "Friends:, " + result.ResultDictionary["key"];
            }
        }
        
        else
        {
            Debug.Log(result.Error);
        }
    }
}
