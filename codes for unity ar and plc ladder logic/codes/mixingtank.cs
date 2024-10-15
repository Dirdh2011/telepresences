using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Vuforia;
using System.Collections.Generic;


public class mixingtank :  DefaultObserverEventHandler
{
    InputField field1;
    InputField field2;
    InputField field3;
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
        field1 = GameObject.Find("InputFieldm").GetComponent<InputField>();
        field2 = GameObject.Find("InputFieldm1").GetComponent<InputField>();
        field3 = GameObject.Find("InputFieldm2").GetComponent<InputField>();
        StartCoroutine(GetData_Coroutine1());
        StartCoroutine(GetData_Coroutine2());
        StartCoroutine(GetData_Coroutine3());
        
    }

    IEnumerator GetData_Coroutine1() 
        {
           
            string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v23";

        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
            {
                field1.text = request.error;
            
            }

            else
            {
        
                tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    field1.text="OFF";
                }
                else{
                    field1.text="ON";
                }
                
            }
        }
        }
     IEnumerator GetData_Coroutine2()
    {
         
        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v24";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field2.text = request.error;
            else
            {
                   
               tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    field2.text="OFF";
                }
                else{
                    field2.text="ON";
                }
            }            
        }
    }

    IEnumerator GetData_Coroutine3() 
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v27";
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
                    
                    field3.text="LOW";
                }
                else{

                    field3.text="HIGH";
                }
            }
        }
    }

    

}










 