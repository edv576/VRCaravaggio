using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayerBehaviour : MonoBehaviour {

    public Sprite[] layers;
    public GameObject layer1;
    public GameObject layer2;
    Image image;
    Image imageLayer1;
    Image imageLayer2;
    Sprite currentLayer;
    int layer;



	// Use this for initialization
	void Start () {

        //image = GetComponent<Image>();
        imageLayer1 = layer1.GetComponent<Image>();
        imageLayer2 = layer2.GetComponent<Image>();
        //totalTime = 0.0f;
        layer = -1;
        imageLayer1.sprite = layers[0];
        imageLayer2.sprite = layers[1];

        Color tcolor = imageLayer1.color;
        tcolor.a = 0.0f;
        imageLayer1.color = tcolor;
        imageLayer2.color = tcolor;
        imageLayer1.preserveAspect = true;
        imageLayer2.preserveAspect = true;

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
        

        if(layer >= 0 && layer < layers.Length)
        {
            Color tcolor1;
            Color tcolor2;


            for (float f = 1.0f; f >= 0; f -= 0.005f)
            {
                tcolor1 = imageLayer1.color;
                tcolor2 = imageLayer2.color;
                tcolor1.a = f;
                tcolor2.a = 1 - f;
                //imageLayer1.color = tcolor1;
                imageLayer2.color = tcolor2;

                yield return new WaitForSeconds(0.005f);


            }


            layer++;

            if(layer < layers.Length - 1)
            {
                imageLayer1.sprite = layers[layer];
                imageLayer2.sprite = layers[layer + 1];
                tcolor1 = imageLayer1.color;
                tcolor2 = imageLayer2.color;
                tcolor1.a = 1.0f;
                tcolor2.a = 0.0f;
                imageLayer1.color = tcolor1;
                imageLayer2.color = tcolor2;
                imageLayer1.preserveAspect = true;
                imageLayer2.preserveAspect = true;

            }
            else
            {
                layer = layers.Length;
            }

           

            

        }

        if (layer < 0)
        {
            for (float f = 0.005f; f <= 1; f += 0.005f)
            {
                Color tcolor = imageLayer1.color;
                tcolor.a = f;
                imageLayer1.color = tcolor;

                yield return new WaitForSeconds(0.005f);

            }
            layer++;

        }
        //else if(layer == layers.Length)
        //{
        //    layer--;

        //}


        //if (layer < 0)
        //{
        //    layer++;




        //}

        //for (float f = 0.005f; f <= 1; f += 0.005f)
        //{
        //    Color tcolor = image.color;
        //    tcolor.a = f;
        //    image.color = tcolor;

        //    yield return new WaitForSeconds(0.005f);


        //}







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

        if (layer < layers.Length && layer > 0)
        {
            for (float f = 1.0f; f >= 0; f -= 0.005f)
            {
                Color tcolor = image.color;
                tcolor.a = f;
                image.color = tcolor;

                yield return new WaitForSeconds(0.005f);


            }

            layer--;

            image.sprite = layers[layer];


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
