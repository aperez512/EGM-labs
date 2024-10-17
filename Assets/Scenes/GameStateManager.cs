using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameStateManager : MonoBehaviour
{
    public GameObject prefab;
    public int howMany;
    private int score;

    // Use this for initialization
    void Start()
    {
        GameObject tmpAsteroid;
        AsteroidMove am;

        for (int i = 0; i < howMany; i++)
        {
            tmpAsteroid = Instantiate(
                prefab,
                new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0),
                Quaternion.identity
             );

            am = tmpAsteroid.GetComponent<AsteroidMove>();

            am.mx = Random.Range(-8, 8);
            am.my = Random.Range(-8, 8);
            am.rotz = Random.Range(-3, 3);
        }
    }
    // Update is called once per frame//
    void Update()
    {

    }

    public int getScore()
    {
        return score;
    }

    public void setScore(int s)
    {
        score = s;
    }

    public void adjustScore(int s)
    {
        score += s;
        Debug.Log("Score is " + score);
    }

}
