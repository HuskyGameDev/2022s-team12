using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishingGame : MonoBehaviour
{
    public RectTransform bar;
    float barMin;
    float barMax;
    float goalMin;
    float goalMax;
    public float barSpeed;
    public RectTransform indicator;
    public RectTransform goalBar;

    // Start is called before the first frame update
    public void Start()
    {
        //define bar bounds and bar speed
        barMin = bar.rect.yMin;
        barMax = bar.rect.yMax;
        barSpeed = barSpeed * Random.Range(0.0001f, 0.0005f);

        //define indicator and goal position/size
        indicator.localPosition = new Vector3(0, 0, 0);
        indicator.localScale = new Vector3(1, 0.03f, 0);
        goalBar.localPosition = new Vector3(0, Random.Range(-0.5f, 0.5f), 0);
        goalBar.localScale = new Vector3(1, 0.1f, 0);

        //set up goal bounds
        goalMax = getYmax(goalBar);
        goalMin = getYmin(goalBar);
    }

    // Update is called once per frame
    void Update()
    {
        //switches direction when border is hit
        if (indicator.localPosition.y >= barMax) {
            barSpeed = barSpeed * -1;
        }
        if(indicator.localPosition.y <= barMin){
            barSpeed = barSpeed * -1;
        }

        //updates bar position
        indicator.localPosition += Vector3.up * barSpeed;

        //check if space is pressed
        if (Input.GetKeyDown("space")){
            float indicatorY = indicator.localPosition.y;

            if(indicatorY <= goalMax && indicatorY >= goalMin)
            {
                print("Fish caught");
                print("goalMin: " + goalMin.ToString() + "goalMax: " + goalMax.ToString());
                print("position of indicator: " + indicatorY.ToString());
                barSpeed = 0;
            }
            else
            {
                print("Fish not caught try again");
                print("goalMin: " + goalMin.ToString() + " goalMax: " + goalMax.ToString());
                print("position of indicator: " + indicatorY.ToString());
            }
        }
    }

    float getYmax(RectTransform gameObject)
    {
         return gameObject.localPosition.y + gameObject.localScale.y;
    }
    float getYmin(RectTransform gameObject)
    {
        return gameObject.localPosition.y - gameObject.localScale.y;
    }

}
