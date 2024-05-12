using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLogic : MonoBehaviour
{
    public static bool key = false;
    private static bool axe = false;
    private static bool soup = false;
    private static bool bottle = false;
    private static bool money = false;

    private bool found = false;

    private AudioSource sounds;
    // Start is called before the first frame update
    void Start()
    {
        sounds = GameObject.Find("EventSystem").GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!found){
            if (axe && soup && bottle && money) {
                found = true;
                GameObject.Find("P_PROP_safe_door_interior").transform.Rotate(0,-90,0);
                sounds.Play();
            }
        }
    }

    public static void setAxe (bool axe1){
        axe = axe1;
        print(axe);
    }

    public static bool getAxe (){
        return axe;
    }

    public static void setSoup (bool soup1){
        soup = soup1;
        print(soup);
    }

    public static bool getSoup (){
        return soup;
    }

    public static void setBottle (bool bottle1){
        bottle = bottle1;
        print(bottle);
    }

    public static bool getBottle (){
        return bottle;
    }

    public static void setMoney (bool money1){
        money = money1;
        print(money);
    }

    public static bool getMoney (){
        return money;
    }
}
