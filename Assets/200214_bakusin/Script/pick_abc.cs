using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class pick_abc : MonoBehaviour
{

    public GameObject obj;
    GameObject bir;
    int p;
    List<char> rand;
    int n = 0;
    int i = 0;
    string key;
    public GameObject Root;
    public GameObject explosionPrefab;
    public GameObject smookPrefab;
    public GameObject mouth;
    Animator player;
    float timer;
    public int score;
    public float t = 2.8f;
    GameObject se;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("mouth").GetComponent<Animator>();
        bir = GameObject.Find("obj_bir");
        Root = transform.root.gameObject;
        se = GameObject.Find("SE");
    }

    // Update is called once per frame
    void Update()
    {

        Text ptext = obj.GetComponent<Text>();


        if (n < 1)
        {
            bir = GameObject.Find("obj_bir");
            rand = new List<char>(bir.GetComponent<rand_abc>().abc);
            n++;

        }


        if(i<1)
        {
            bir = GameObject.Find("obj_bir");
            p = bir.GetComponent<obj_bir>().birth;
            ptext.text = rand[p].ToString();
            i++;
        }

        if (Input.anyKeyDown)
        {
            player.Play("idle");
            Debug.Log("tr");
            var dict = new Dictionary<string, KeyCode>()
            {
            {"A", KeyCode.A},
            {"B", KeyCode.B},
            {"C", KeyCode.C},
            {"D", KeyCode.D},
            {"E", KeyCode.E},
            {"F", KeyCode.F},
            {"G", KeyCode.G},
            {"H", KeyCode.H},
            {"I", KeyCode.I},
            {"J", KeyCode.J},
            {"K", KeyCode.K},
            {"L", KeyCode.L},
            {"M", KeyCode.M},
            {"N", KeyCode.N},
            {"O", KeyCode.O},
            {"P", KeyCode.P},
            {"Q", KeyCode.Q},
            {"R", KeyCode.R},
            {"S", KeyCode.S},
            {"T", KeyCode.T},
            {"U", KeyCode.U},
            {"V", KeyCode.V},
            {"W", KeyCode.W},
            {"X", KeyCode.X},
            {"Y", KeyCode.Y},
            {"Z", KeyCode.Z}
            };
            foreach (var key in dict.Values)
            {
                if (Input.GetKeyDown(key))
                {
                    var code = dict.FirstOrDefault(c => c.Value == key).Key;
                    if(code == rand[p].ToString())
                    {
                        if (obj_bir.timer<obj_bir.s_time-0.3f)
                        {
                            obj_bir.timer = obj_bir.s_time - 0.3f;
                        }
                        player.SetTrigger("op");
                        //player.SetBool("open",true);
                        //player.SetBool("open", false);
                        rand_abc.num-=1;
                        Instantiate(explosionPrefab, Root.transform.position, Quaternion.identity);
                        Debug.Log("ggg");
                        GameManage.score_i += score * (t - timer);
                        //処理を書く
                        //player.ResetTrigger("op");
                        se.GetComponent<AudioSource>().PlayOneShot(se.GetComponent<AudioSource>().clip);
                        Destroy(Root);
                        break;
                    }
                }
            }
        }

        if (timer >= t)
        {
            Instantiate(smookPrefab, Root.transform.position, Quaternion.identity);
            Destroy(Root);

        }
        timer += Time.deltaTime;
    }
}
