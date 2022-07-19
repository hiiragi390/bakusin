using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTime : MonoBehaviour
{
    public GameObject start;
    public GameObject timer;
    Text text;
    float start_t = 3f;
    float t;
    int second;
    // Start is called before the first frame update
    void Start()
    {
        text = timer.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        start_t -= Time.deltaTime;
        second = (int)start_t + 1;
        Debug.Log(timer);
        text.text = second.ToString();
        Debug.Log(timer);
        if (start_t <= 0)
        {
            start.SetActive(false);
        }
    }
}
