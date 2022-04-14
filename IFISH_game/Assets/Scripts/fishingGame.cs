using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishingGame : MonoBehaviour
{
    public RectTransform bar;
    public GameObject frame;
    public Image img;
    public Sprite squid;
    public Sprite salmon;
    public Sprite catfish;
    public Sprite shield;
    public Sprite sword;

    float barMin;
    float barMax;
    float goalMin;
    float goalMax;
    public float speedScale;
    private float barSpeed;
    public RectTransform indicator;
    public RectTransform goalBar;

    // Start is called before the first frame update
    void Start()
    {
        //define bar bounds and bar speed
        barMin = bar.rect.yMin;
        barMax = bar.rect.yMax;
        barSpeed = speedScale * Random.Range(0.0001f, 0.0005f);

        //define indicator and goal position/size
        indicator.localPosition = new Vector3(0, 0, 0);
        indicator.localScale = new Vector3(1, 0.03f, 0);
        goalBar.localPosition = new Vector3(0, Random.Range(-0.5f, 0.5f), 0);
        goalBar.localScale = new Vector3(1, 0.1f, 0);

        //set up goal bounds
        goalMax = getYmax(goalBar);
        goalMin = getYmin(goalBar);
    }

    void OnEnable()
    {
        //define bar bounds and bar speed
        barMin = bar.rect.yMin;
        barMax = bar.rect.yMax;
        barSpeed = speedScale * Random.Range(0.0001f, 0.0005f);

        //define indicator and goal position/size
        indicator.localPosition = new Vector3(0, 0, 0);
        indicator.localScale = new Vector3(1, 0.03f, 0);
        goalBar.localPosition = new Vector3(0, Random.Range(-0.5f, 0.5f), 0);
        goalBar.localScale = new Vector3(1, 0.1f, 0);

        //set up goal bounds
        goalMax = getYmax(goalBar);
        goalMin = getYmin(goalBar);

        frame.SetActive(false);
    }

    void OnDisable()
    {
        frame.SetActive(false);
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
                print("goalMin: " + goalMin.ToString() + " goalMax: " + goalMax.ToString());
                print("position of indicator: " + indicatorY.ToString());
                barSpeed = 0;
                showFish();
                frame.SetActive(true);
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

    void showFish()
    {
        int rarity = Random.Range(0, 100);

        if( rarity > 85 )
        {
            img.sprite = catfish;
        }
        else if( rarity > 70 )
        {
            img.sprite = squid;
        }
        else if( rarity > 55 )
        {
            img.sprite = sword;
        }
        else if( rarity > 40 )
        {
            img.sprite = shield;
        }
        else
        {
            img.sprite = salmon;
        }
    }
}
