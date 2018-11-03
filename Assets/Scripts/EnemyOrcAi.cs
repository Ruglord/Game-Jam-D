using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrcAi : MonoBehaviour
{
    int i = 0;

    public static float damage = 50f;

    float xtnoe = 0.0f;
    float ytnoe = 0.0f;
    float sqrtmeplz = 9.0f;

    float xt = 0.0f;    //the x position of the target
    float yt = 0.0f;    //the y position of the target
    float xe = 0.0f;    //the x position of the enemy
    float ye = 0.0f;    //the y position of the enemy

    float dadis = 0.0f; //to do math of distance from target
    float trudis = 10.0f; //distance from target

    protected float angle = 0.0f; //angle of where to move

    float xm = 1.0f;    //how much he moves in x direction
    float ym = 1.0f;    //how much he moves in y direction
    float speed = 0.025f; //his speed
    GameObject cube = null;
    GameObject jab = null;
    protected GameObject target = null; //the orc's current target.
    // Use this for initialization
   protected void Start()
    {
        damage = 7f;
        cube  = GameObject.Find("Cube");
        jab = GameObject.Find("jab");
        target = cube;
        name = "orc";
        jab.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        target = cube;
        trudis = findDistanceToTarget();
        angle = findAngleToTarget();

        if (trudis < 2)
        {
            if (i >= 45)
            {
                jab.gameObject.SetActive(true);
            }
            if (i >= 55)
            {
                i = 0;
                jab.gameObject.SetActive(false);
            }
            i++;
        }
        else
        {
            xm = Mathf.Cos(angle) * speed;
            ym = Mathf.Sin(angle) * speed;
            transform.eulerAngles = new Vector3(0, 0, angle * 180 / Mathf.PI - 90);
            transform.position = new Vector2(transform.position.x + xm, transform.position.y + ym);
        }
    }
    protected float findAngleToTarget() //finds the angle between the orc and the target
    {
        xt = target.transform.position.x;
        yt = target.transform.position.y;

        xtnoe = xt - transform.position.x;
        ytnoe = yt - transform.position.y;
        return Mathf.Atan2(ytnoe, xtnoe);
    }
    protected float findDistanceToTarget()
    {
        xt = target.transform.position.x;
        yt = target.transform.position.y;
        xe = transform.position.x;
        ye = transform.position.y;

        sqrtmeplz = (xe - xt) * (xe - xt) + (ye - yt) * (ye - yt);

        dadis = Mathf.Sqrt(sqrtmeplz);
        return dadis;
    }
    private void OnDestroy()
    {
        GameObject.Find("ScoreCounter").GetComponent<score>().scoreCounter += 1;
    }
}