using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerFail , PlayerPass,playerJump,GameOv,notif,playerHit,socky;
    static AudioSource audioSrc;

   
    // Start is called before the first frame update
    void Start()
    {
        playerFail = Resources.Load<AudioClip>("fail");
        PlayerPass = Resources.Load<AudioClip>("done");
        playerJump = Resources.Load<AudioClip>("jumpy");
        GameOv = Resources.Load<AudioClip>("gameOv");
        playerHit = Resources.Load<AudioClip>("hit");
        notif = Resources.Load<AudioClip>("notif");
        socky = Resources.Load<AudioClip>("eat");


        audioSrc = GetComponent <AudioSource> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //hello
    public static void playSound (string clip)
    {
        switch(clip)
        {
            case "fail":
                audioSrc.PlayOneShot(playerFail);
                break;
            case "done":
                 audioSrc.PlayOneShot(PlayerPass);
                break;
            case "jump":
                audioSrc.PlayOneShot(playerJump);
                break;
            case "over":
                audioSrc.PlayOneShot(GameOv);
                break;
            case "hit":
                audioSrc.PlayOneShot(playerHit);
                break;
            case "notif":
                audioSrc.PlayOneShot(notif);
                break;
            case "socks":
                audioSrc.PlayOneShot(socky);
                break;
        }
    }
}
