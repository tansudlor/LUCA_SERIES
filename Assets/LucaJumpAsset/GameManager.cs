using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject platform;
    public int platformCount ;
    public GameObject finishLine;
    private void Awake()
    {
        instance = this; 
    }
    void Start()
    {
        if (starScene.level == "easy")
        {
            platformCount = 100;
        }
        else if (starScene.level == "normal")
        {
            platformCount = 200;
        }
        else
        {
            platformCount = 300;
        }

        var platformSize = platform.transform.GetComponent<SpriteRenderer>().size.x;
        print(platformSize / 2);

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i <= platformCount; i++)
        {
            spawnPosition.y += Random.Range(0.5f, 3f);
            spawnPosition.x = Random.Range(-6f, 6f);
            var platformIn = Instantiate(platform, spawnPosition, Quaternion.identity);
            platformIn.name = i.ToString();
        }

        Instantiate(finishLine,new Vector3(0, spawnPosition.y+ 3f,0 ), Quaternion.identity);   
    }


}
