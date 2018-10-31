using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoverBehaviour : MonoBehaviour {


    RawImage image;

    float totalTime;

	// Use this for initialization
	void Start () {

        image = GetComponent<RawImage>();
        totalTime = 0.0f;

       
		
	}

    //tFade: Integer that defines if the object is fading or appearing
    void Fading(int tFade)
    {
        if(tFade == 1)
        {
            var tColor = image.color;
            var tColor2 = tColor;
            if(tColor.a < 1.0F)
            {
                //tColor.a = tColor.a + 0.25f;
                float t = 0.0f;
                float t2 = 0.0f;
                while(t < 1)
                {
                    t += Time.deltaTime * (1.0f / 10);
                    t2 += Time.deltaTime;
                    //print(t);
                    //print(Time.deltaTime);
                    print(t2);
                    //tColor.a = tColor2.a + t * 0.25f;
                    tColor.a = tColor2.a + t * 1.00f;
                    image.color = tColor;
                 
                    
                }

                int i = 0;
               
                  

            }
            
            //image.color = tColor;

        }

        if (tFade == 0)
        {

            var tColor = image.color;
            if (tColor.a > 0.0F)
            {
                tColor.a = tColor.a - 0.25f;

            }
            image.color = tColor;

        }

        

    }

    IEnumerator FadeIn()
    {
        for (float f = 0.005f; f <= 1; f += 0.005f)
        {
            Color tcolor = image.color;
            tcolor.a = f;
            image.color = tcolor;

            yield return new WaitForSeconds(0.005f);


        }
  

    }

    IEnumerator FadeOut()
    {
        for (float f = 1.0f; f >= 0; f -= 0.005f)
        {
            Color tcolor = image.color;
            tcolor.a = f;
            image.color = tcolor;

            yield return new WaitForSeconds(0.005f);


        }

    }


    void StartFadingIn()
    {
        StartCoroutine("FadeIn");

    }

    void StartFadingOut()
    {
        StartCoroutine("FadeOut");

    }

	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Fading(0);
            StartFadingOut();
            


        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Fading(1);
            StartFadingIn();



        }

        

    }
}
