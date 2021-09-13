using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    public Text distance;
    public Text gabes;
    public Text quest1;
    public GameObject cyl;
    public Image im;
    public GameObject trig;
    public Text zebla;
    public Text prevt;
    public Text dis;
    int n = 0;
    public GameObject gar;
    public GameObject sm;
    public Text dis3;
    public Text qu3;
    public GameObject garbin;
    public Image qz;
    public Image tm;
    public Text td;
    public Text tq;
    public GameObject tmc;
    public GameObject world;
    public GameObject house;
    public GameObject mission;
    public Image ent;
    public GameObject q6;
    public GameObject q7;
    public Image rep3;
    public GameObject world1;
    public GameObject q8;
    public GameObject q8t;
    public GameObject perso;
    public GameObject boat;
    public GameObject b1;
    public GameObject ship;
    public GameObject liam;  
    public GameObject ret;
    public AudioSource sac;
    int box = 0;
    public Text q9g;
    public AudioSource jeton;
    public Image demo;
    public GameObject po;
    public GameObject cam1;
    public GameObject maincam;
    public Slider sld;
    int v = 1;
    public Text level;

    // Start is called before the first frame update
    void Start()
    {
        //sac = GetComponent<AudioSource>();
    }
    void Update()
    {
        po.transform.position = transform.position;
        if (sld.value == 200)
        {
            v++;
            level.text = v.ToString();
            sld.value = 0;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "st")
        {
            gabes.gameObject.SetActive(false);
            quest1.gameObject.SetActive(true);
            distance.gameObject.SetActive(true);
            sld.gameObject.SetActive(true);
        }
    }

void OnTriggerEnter(Collider col)
    {
       if (col.tag == "box")
        {
            sld.gameObject.SetActive(true);
            col.gameObject.SetActive(false);
            box += 1;
            q9g.text = "Jetons collecté(" + box + " / 11)";
            q9g.gameObject.SetActive(true);
            jeton.Play(0);
            sld.value += 50;
            if (box == 11)
            {
                sld.gameObject.SetActive(false);
                q9g.gameObject.SetActive(false);
                demo.gameObject.SetActive(true);
                GetComponent("ThirdPersonController").gameObject.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
        if (col.tag == "return")
      {
                q8t.SetActive(true);
                world.SetActive(true);
                world1.SetActive(false);
                perso.SetActive(true);
                boat.SetActive(false);
                b1.SetActive(true);
                ret.SetActive(false);
      }
            if (col.tag == "boat")
        {
            ret.SetActive(true);
            world.SetActive(false);
            world1.SetActive(true);
            perso.SetActive(false);
            boat.SetActive(true);
            b1.SetActive(false);
            q8t.SetActive(false);
            ship.SetActive(false);
            liam.SetActive(false);
            q8.SetActive(false);
}
        if (col.tag == "guy")
        {
            q7.gameObject.SetActive(false);
            ent.gameObject.SetActive(false);
            GetComponent("ThirdPersonController").gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            rep3.gameObject.SetActive(true);

        }
        if (col.tag == "exit")
        {
            world.SetActive(true);
            house.SetActive(false);
            mission.SetActive(true);
        }
        if (col.tag == "tp")
        {
            world.SetActive(false);
            house.SetActive(true);
            mission.SetActive(false);
            q6.gameObject.SetActive(false);
            q7.gameObject.SetActive(true);
            ent.gameObject.SetActive(true);           
        }
        if (col.tag == "tm")
        {
            tmc.SetActive(false);
            tq.gameObject.SetActive(false);
            td.gameObject.SetActive(false);
            GetComponent("ThirdPersonController").gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            tm.gameObject.SetActive(true);
        }
        if (col.tag == "fm")
        {
            cam1.SetActive(true);
            maincam.SetActive(false);
            quest1.gameObject.SetActive(false);
            distance.gameObject.SetActive(false);
            cyl.SetActive(false);
            GetComponent("ThirdPersonController").gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            im.gameObject.SetActive(true);
            gar.gameObject.SetActive(true);
        }
        if (col.tag == "sm")
        {
            garbin.SetActive(true);
            dis3.gameObject.SetActive(false);
            qu3.gameObject.SetActive(false);
            col.gameObject.SetActive(false);
            GetComponent("ThirdPersonController").gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            qz.gameObject.SetActive(true);
        }
        if (col.tag == "beach")
        {
            trig.gameObject.SetActive(false);
            prevt.gameObject.SetActive(false);
            dis.gameObject.SetActive(false);
            zebla.gameObject.SetActive(true);
        }
        if (col.tag == "trash")
        {
            n += 1;
            trig.gameObject.SetActive(false);
            prevt.gameObject.SetActive(false);
            dis.gameObject.SetActive(false);
            zebla.gameObject.SetActive(true);
            zebla.text = "Ordures collecté(" + n + " / 10)";
            col.gameObject.SetActive(false);
            sac.Play(0);
            sld.value += 50;
            if (n == 10)
            {
                sm.SetActive(true);
                zebla.gameObject.SetActive(false);
                dis3.gameObject.SetActive(true);
                qu3.gameObject.SetActive(true);
                sld.gameObject.SetActive(false);

            }
        }
        }
}
