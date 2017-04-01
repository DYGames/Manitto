using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    float speed;
    //left top, right top, left bottom, right bottom
    Vector3[] directions;

    int currentDirection;

    float walktime;
    float stoptime;

    float moveddistance;

    GameObject QuestionMark;
    [HideInInspector]
   public Quest currentQuest;

    SpriteRenderer spriterenderer;
    Sprite front;
    Sprite back;
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();

        directions = new Vector3[4];
        directions[0] = new Vector3(-0.66666666f, 0.33333333f, 0);
        directions[1] = new Vector3(0.66666666f, 0.33333333f, 0);
        directions[2] = new Vector3(-0.66666666f, -0.33333333f, 0);
        directions[3] = new Vector3(0.66666666f, -0.33333333f, 0);

        currentDirection = Random.Range(0, 4);

        speed = Random.Range(80, 100) * 0.01f;

        walktime = Random.Range(5.0f, 15.0f);
        stoptime = Random.Range(0.0f, 15.0f);

        QuestionMark = transform.Find("QuestionMark").gameObject;
        StartCoroutine(QuestionRoutin());

        int id = Random.Range(1, 10);
        front = Resources.Load<Sprite>("People/" + id.ToString() + "/front");
        back = Resources.Load<Sprite>("People/" + id.ToString() + "/back");

        setRightSprite();

        currentQuest = QuestMng.Instance.QuestList[0];
    }

    void Update()
    {
        if (walktime > 0)
            walktime -= Time.deltaTime;
        else if (walktime <= 0)
        {
            walktime = 0;
            if (stoptime > 0)
                stoptime -= Time.deltaTime;
            if (stoptime <= 0)
            {
                walktime = Random.Range(5.0f, 15.0f);
                stoptime = Random.Range(0.0f, 15.0f);
            }
        }

        Vector3 movevec = directions[currentDirection] * speed * Time.deltaTime * System.Math.Sign(walktime);

        transform.position += movevec;
        moveddistance += movevec.magnitude;

        if (moveddistance > 3.95f)
        {
            currentDirection = Random.Range(0, 4);
            setRightSprite();

            walktime = 0;
            stoptime = 0.95f;
            moveddistance = 0;
        }
    }

    void setRightSprite()
    {
        if (currentDirection == 0)
        {
            spriterenderer.sprite = back;
            spriterenderer.flipX = false;
        }
        if (currentDirection == 1)
        {
            spriterenderer.sprite = back;
            spriterenderer.flipX = true;
        }
        if (currentDirection == 2)
        {
            spriterenderer.sprite = front;
            spriterenderer.flipX = false;
        }
        if (currentDirection == 3)
        {
            spriterenderer.sprite = front;
            spriterenderer.flipX = true;
        }
    }

    IEnumerator QuestionRoutin()
    {
        yield return new WaitForSeconds(Random.Range(10, 30));
        QuestionMark.SetActive(true);

        int questn = 0;
        if (PeriodMng.Instance.currentPeriod == PeriodMng.Period.PRIMITIVE)
            questn = Random.Range(0, 1);
        if (PeriodMng.Instance.currentPeriod == PeriodMng.Period.MEDIAVAL)
            questn = Random.Range(1, 4);
        if (PeriodMng.Instance.currentPeriod == PeriodMng.Period.MODERN)
            questn = Random.Range(4, 7);
        if (PeriodMng.Instance.currentPeriod == PeriodMng.Period.FUTURE)
            questn = Random.Range(7, 9);

        currentQuest = QuestMng.Instance.QuestList[questn];
        yield return new WaitForSeconds(5);
        QuestionMark.SetActive(false);

        StartCoroutine(QuestionRoutin());
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
