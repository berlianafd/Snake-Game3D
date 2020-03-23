using UnityEngine;
using System.Collections;

public class Score2 : MonoBehaviour
{

    private LevelManager levelManager;
    public static int score = 0;

    // Use this for initialization
    void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);

        //get level manager
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //get the score
        score = FruitRotator.count;
        NextLevel();
    }

    void NextLevel()
    {
        //Debug.Log("Triggredd");
        //collide with wall or rock
        if (score == 10)
        {
            Debug.Log("Next Level");
            //goto lose screen
            levelManager.LoadLevel("Win");
        }

    }

}
