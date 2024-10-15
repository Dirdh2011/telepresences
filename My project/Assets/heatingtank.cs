using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Vuforia;
using System.Collections.Generic;


public class heatingtank :  DefaultObserverEventHandler
{
    InputField field1;
    InputField field2;
    InputField field3;
    InputField field4;
    InputField field5;
    string tempstring;
    int tempint;


        

    protected override void OnTrackingFound()
    {
        SetAugmentationRendering(true); 
        
      
        InvokeRepeating("Getdata", 0.2f, 1f);

    }

    protected override void OnTrackingLost()
    {
        SetAugmentationRendering(false);
        CancelInvoke("Getdata");
    }

    void SetAugmentationRendering(bool value)
    {
        for (var i = 0; i < transform.childCount; i++)
            SetEnabledOnChildComponents(transform.GetChild(i), value);
        SetVuforiaRenderingComponents(value);
    }

    void SetEnabledOnChildComponents(Transform augmentationTransform, bool value)
    {
        var augmentationRenderer = augmentationTransform.GetComponent<VuforiaAugmentationRenderer>();
        if (augmentationRenderer != null)
        {
            augmentationRenderer.SetActive(value);
            return;
        }

        if (mObserverBehaviour)
        {
            var rendererComponent = augmentationTransform.GetComponent<Renderer>();
            if (rendererComponent != null)
                rendererComponent.enabled = value;
            var canvasComponent = augmentationTransform.GetComponent<Canvas>();
            if (canvasComponent != null)
                canvasComponent.enabled = value;
            var colliderComponent = augmentationTransform.GetComponent<Collider>();
            if (colliderComponent != null)
                colliderComponent.enabled = value;
        }

        for (var i = 0; i < augmentationTransform.childCount; i++)
            SetEnabledOnChildComponents(augmentationTransform.GetChild(i), value);
    }

    void SetVuforiaRenderingComponents(bool value)
    {
        var augmentationRendererComponents = mObserverBehaviour.GetComponentsInChildren<VuforiaAugmentationRenderer>(false);
        foreach (var component in augmentationRendererComponents)
            component.SetActive(value);
    }

    void Getdata() 

    {
        field1 = GameObject.Find("InputFieldh").GetComponent<InputField>();
        field2 = GameObject.Find("InputFieldh1").GetComponent<InputField>();
        field3 = GameObject.Find("InputFieldh2").GetComponent<InputField>();
        field4 = GameObject.Find("InputFieldh3").GetComponent<InputField>();
        field5 = GameObject.Find("InputFieldh4").GetComponent<InputField>();
        
        StartCoroutine(GetData_Coroutine1());
        StartCoroutine(GetData_Coroutine2());
        StartCoroutine(GetData_Coroutine3());
        StartCoroutine(GetData_Coroutine4()); 
        StartCoroutine(GetData_Coroutine5());
        
    }

    IEnumerator GetData_Coroutine1() 
        {

            string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v19";

        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
            {
                field1.text = request.error;
    
            }

            else
            {
    
                field1.text = request.downloadHandler.text;
                
            }
        }
        }
     IEnumerator GetData_Coroutine2()
    {
    
        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v18";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field2.text = request.error;
            else
            {

                field2.text = request.downloadHandler.text;
            }            
        }
    }

    IEnumerator GetData_Coroutine3() 
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v22";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field3.text = request.error;
            else
            {

                tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    
                    field3.text="OFF";
                }
                else{

                    field3.text="ON";
                }
            }
        }
    }

    IEnumerator GetData_Coroutine4()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v29";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field4.text = request.error;
            else
            {

                tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    
                    field4.text="LOW";
                }
                else{

                    field4.text="HIGH";
                }
            }
        }
    }

    IEnumerator GetData_Coroutine5()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v25";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field5.text = request.error;
            else
            {

               tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    
                    field5.text="OFF";
                }
                else{

                    field5.text="ON";
                }
            }
        }
    }

    

}
