using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishingGame : MonoBehaviour
{
    public RectTransform bar;
    float barMin;
    float barMax;
    float barSpeed;
    public Transform indicator;


    // Start is called before the first frame update
    void Start()
    {
        //get rectTransform
        //bar = GetComponent<RectTransform>();
        barMin = bar.rect.yMin;
        barMax = bar.rect.yMax;
        //barSpeed = Random.Range(0.0f, 0.001f);
        barSpeed = 0.001f;
        indicator.localPosition = new Vector3(0, 0, 0);
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

        if (Input.GetMouseButton(0)){
            barSpeed = 0;
        }
    }
}
