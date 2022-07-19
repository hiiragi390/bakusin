using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    public static float score_i;
    Text text;
    Text f_text;
    public GameObject score;
    public GameObject finish_s;
    public GameObject back;
    public GameObject sp;
    public GameObject over;
    public GameObject start;
    public GameObject t;
    GameObject mob;
    GameObject clear;
    GameObject bgm;
    float timer;
    int second;
    bool end = true;
    // Start is called before the first frame update
    void Start()
    {
        bgm = GameObject.Find("BGM");
        bgm.GetComponent<AudioSource>().Play();
        score_i = 0f;
        clear = GameObject.Find("Clear");
        over.SetActive(false);
    }

    // Update is called once per frame

    void Update()
    {
        if (end&&rand_abc.num == 0)
        {
            score_i += 1500 - obj_bir.total_time;
            mob = GameObject.Find("heisi");
            Destroy(mob);
            mob = GameObject.Find("o-ji");
            Destroy(mob);
            sp.SetActive(false);
            score.SetActive(false);
            bgm.GetComponent<AudioSource>().Stop();
            f_text = finish_s.GetComponent<Text>();
            f_text.text = ((int)score_i).ToString();
            over.SetActive(true);
            clear.GetComponent<AudioSource>().Play();
            end = false;
        }
    }
}
