using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshPro を使う時は忘れないように注意!!

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    float time = 60.0f;
    int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        this.pointText.GetComponent<TextMeshProUGUI>().text = this.point.ToString() + " point";
    }

    public void GetApple() {
        this.point += 100;
    }
    public void GetBomb() {
        this.point /= 2;
    }
}
