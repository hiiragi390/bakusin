using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obj_bir : MonoBehaviour
{
    public static float total_time = 0f;
    public static float s_time = 2f;
    public static float timer = 0f;
    public GameObject obj;
    public GameObject obj2;
    int ran = 0;
    public int birth = -1;
    float start = 3f;
    bool start_f;
    // Start is called before the first frame update
    void Start()
    {
        start_f = false;
        total_time = 0f;
        s_time = 2f;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (start_f)
        {
            total_time += Time.deltaTime;
            timer += Time.deltaTime;
            if (timer >= s_time)
            {
                s_time = 2f + (Random.Range(3, 7) / 10);
                ran = Random.Range(-1, 2);
                var i = Random.Range(0, 7);
                Vector3 sp = new Vector3(5, ran * 2.3f, 0);
                if (i >= 6)
                {
                    Instantiate(obj2).transform.localPosition = sp;

                }
                else
                {
                    Instantiate(obj).transform.localPosition = sp;
                }

                timer = 0;
                birth++;
            }
        }
        else if(start<=0)
        {
            start_f = true;
        }
        else
        {
            start -= Time.deltaTime;
        }
    }
}
