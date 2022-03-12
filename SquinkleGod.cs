using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquinkleGod : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool HeadTimesEndOfGame;
    public static bool Time;

    public GameObject GOD;
    public AudioSource start;
    public GameObject FUCK;

    void Start()
    {
        StartCoroutine(Song(5.0f, 3.0f));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Song(float firetime, float waitTime)
    {
        while (true)
        {
            GOD.SetActive(true);
            HeadTimesEndOfGame = false;
            start.Play();
            yield return new WaitForSeconds(Random.Range(3, 6)); 
            GOD.SetActive(true);
            FUCK.SetActive(true);
            HeadTimesEndOfGame = false;
            start.Stop();
            yield return new WaitForSeconds(waitTime);
            FUCK.SetActive(false);
            StartCoroutine(Song(5.0f, 3.0f));
        }
    }
}

