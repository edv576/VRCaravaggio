using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayerBehaviour2 : MonoBehaviour {

    public Material[] layers;
    public GameObject layer1;
    public GameObject layer2;
    public GameObject[] stages;
    Image image;
    Material matLayer1;
    Material matLayer2;
    Material currentMatLayer;
    Material[] matEnvironment1;
    Material[] matEnvironment2;
    Material[] matEnvironment3;
    int layer;



	// Use this for initialization
	void Start () {

        //image = GetComponent<Image>();
        matLayer1 = layer1.GetComponent<Material>();
        matLayer2 = layer2.GetComponent<Material>();
        //totalTime = 0.0f;
        layer = -1;
        matLayer1 = layers[0];
        matLayer2 = layers[1];

        Color tcolor = matLayer1.color;
        tcolor.a = 0.0f;
        matLayer1.color = tcolor;
        matLayer2.color = tcolor;
        //imageLayer1.preserveAspect = true;
        //imageLayer2.preserveAspect = true;


        //matEnvironment1 = stages[0].GetComponent<SkinnedMeshRenderer>().materials;
        //for(int i = 0; i< matEnvironment1.Length; i++)
        //{
        //    tcolor = matEnvironment1[i].color;
        //    tcolor.a = 0.0f;

        //    matEnvironment1[i].color = tcolor;
        //}

        //matEnvironment2 = stages[1].GetComponent<SkinnedMeshRenderer>().materials;
        //for (int i = 0; i < matEnvironment2.Length; i++)
        //{
        //    tcolor = matEnvironment2[i].color;
        //    tcolor.a = 0.0f;

        //    matEnvironment2[i].color = tcolor;
        //}

        //matEnvironment3 = stages[2].GetComponent<SkinnedMeshRenderer>().materials;
        //for (int i = 0; i < matEnvironment3.Length; i++)
        //{
        //    tcolor = matEnvironment3[i].color;
        //    tcolor.a = 0.0f;

        //    matEnvironment3[i].color = tcolor;
        //}

        //tcolor = stages[1].GetComponent<SkinnedMeshRenderer>().material.color;
        //tcolor.a = 0.0f;

        //stages[1].GetComponent<SkinnedMeshRenderer>().material.color = tcolor;

    }

    ////tFade: Integer that defines if the object is fading or appearing
    //void Fading(int tFade)
    //{
    //    if(tFade == 1)
    //    {
    //        var tColor = image.color;
    //        var tColor2 = tColor;
    //        if(tColor.a < 1.0F)
    //        {
    //            //tColor.a = tColor.a + 0.25f;
    //            float t = 0.0f;
    //            float t2 = 0.0f;
    //            while(t < 1)
    //            {
    //                t += Time.deltaTime * (1.0f / 10);
    //                t2 += Time.deltaTime;
    //                //print(t);
    //                //print(Time.deltaTime);
    //                print(t2);
    //                //tColor.a = tColor2.a + t * 0.25f;
    //                tColor.a = tColor2.a + t * 1.00f;
    //                image.color = tColor;


    //            }

    //            int i = 0;



    //        }

    //        //image.color = tColor;

    //    }

    //    if (tFade == 0)
    //    {

    //        var tColor = image.color;
    //        if (tColor.a > 0.0F)
    //        {
    //            tColor.a = tColor.a - 0.25f;

    //        }
    //        image.color = tColor;

    //    }



    //}

    IEnumerator FadeIn()
    {


        if (layer >= 0 && layer < layers.Length)
        {
            Color tcolor1;
            Color tcolor2;
            Color tColorEnvironment;


            for (float f = 1.0f; f >= 0; f -= 0.005f)
            {
                tcolor1 = layer1.GetComponent<Renderer>().material.color;
                tcolor2 = layer2.GetComponent<Renderer>().material.color;
                tcolor1.a = f;
                tcolor2.a = 1 - f;
                //imageLayer1.color = tcolor1;
                layer2.GetComponent<Renderer>().material.color = tcolor2;

                //matEnvironment1 = stages[layer].GetComponent<SkinnedMeshRenderer>().materials;
                //for (int i = 0; i < matEnvironment1.Length; i++)
                //{
                //    tColorEnvironment = matEnvironment1[i].color;
                //    tColorEnvironment.a = f;

                //    matEnvironment1[i].color = tColorEnvironment;
                //}

                //matEnvironment2 = stages[layer + 1].GetComponent<SkinnedMeshRenderer>().materials;
                //for (int i = 0; i < matEnvironment2.Length; i++)
                //{
                //    tColorEnvironment = matEnvironment2[i].color;
                //    tColorEnvironment.a = 1.0f - f;

                //    matEnvironment2[i].color = tColorEnvironment;
                //}



                yield return new WaitForSeconds(0.005f);


            }


            layer++;

            if (layer < layers.Length - 1)
            {
                layer1.GetComponent<Renderer>().material = layers[layer];
                layer2.GetComponent<Renderer>().material = layers[layer + 1];
                tcolor1 = layer1.GetComponent<Renderer>().material.color;
                tcolor2 = layer2.GetComponent<Renderer>().material.color;
                tcolor1.a = 1.0f;
                tcolor2.a = 0.0f;
                layer1.GetComponent<Renderer>().material.color = tcolor1;
                layer2.GetComponent<Renderer>().material.color = tcolor2;
                //imageLayer1.preserveAspect = true;
                //imageLayer2.preserveAspect = true;

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
                Color tcolor = matLayer1.color;
                tcolor.a = f;
                matLayer1.color = tcolor;

                //matEnvironment1 = stages[0].GetComponent<SkinnedMeshRenderer>().materials;
                //for (int i = 0; i < matEnvironment1.Length; i++)
                //{
                //    tcolor = matEnvironment1[i].color;
                //    tcolor.a = f;

                //    matEnvironment1[i].color = tcolor;
                //}

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

    //IEnumerator FadeOut()
    //{



    //    for (float f = 1.0f; f >= 0; f -= 0.005f)
    //    {
    //        Color tcolor = image.color;
    //        tcolor.a = f;
    //        image.color = tcolor;

    //        yield return new WaitForSeconds(0.005f);


    //    }

    //    if (layer < layers.Length && layer > 0)
    //    {
    //        for (float f = 1.0f; f >= 0; f -= 0.005f)
    //        {
    //            Color tcolor = image.color;
    //            tcolor.a = f;
    //            image.color = tcolor;

    //            yield return new WaitForSeconds(0.005f);


    //        }

    //        layer--;

    //        image.sprite = layers[layer];


    //    }

    //}


    void StartFadingIn()
    {
        StartCoroutine("FadeIn");

    }

    //void StartFadingOut()
    //{
    //    StartCoroutine("FadeOut");

    //}


    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    //Fading(0);
        //    StartFadingOut();



        //}

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Fading(1);
            StartFadingIn();



            //}



        }
    }
}
