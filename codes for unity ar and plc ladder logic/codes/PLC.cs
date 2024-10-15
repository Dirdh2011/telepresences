using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Vuforia;
using System.Collections.Generic;


public class PLC :  DefaultObserverEventHandler
{
    InputField field1;
    InputField field2;
    InputField field3;
    InputField field4;
    InputField field5;
    InputField field6;
    InputField field7;
    InputField field8;
    InputField field9;
    InputField field10;
    InputField field11;
    InputField field12;
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
        field1 = GameObject.Find("InputField").GetComponent<InputField>();
        field2 = GameObject.Find("InputField1").GetComponent<InputField>();
        field3 = GameObject.Find("InputField2").GetComponent<InputField>();
        field4 = GameObject.Find("InputField3").GetComponent<InputField>();
        field5 = GameObject.Find("InputField4").GetComponent<InputField>();
        field6 = GameObject.Find("InputField5").GetComponent<InputField>();
        field7 = GameObject.Find("InputField6").GetComponent<InputField>();
        field8 = GameObject.Find("InputField7").GetComponent<InputField>();
        field9 = GameObject.Find("InputField8").GetComponent<InputField>();
        field10 = GameObject.Find("InputField9").GetComponent<InputField>();
        field11 = GameObject.Find("InputField10").GetComponent<InputField>();
        field12 = GameObject.Find("InputField11").GetComponent<InputField>();
        StartCoroutine(GetData_Coroutine1());
        StartCoroutine(GetData_Coroutine2());
        StartCoroutine(GetData_Coroutine3());
        StartCoroutine(GetData_Coroutine4()); 
        StartCoroutine(GetData_Coroutine5());
        StartCoroutine(GetData_Coroutine6());
        StartCoroutine(GetData_Coroutine7());
        StartCoroutine(GetData_Coroutine8());
        StartCoroutine(GetData_Coroutine9());
        StartCoroutine(GetData_Coroutine10());
        StartCoroutine(GetData_Coroutine11());
        StartCoroutine(GetData_Coroutine12());
    }

    IEnumerator GetData_Coroutine1() 
        {

            string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v16";

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
    
        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v19";
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

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v18";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field3.text = request.error;
            else
            {

                field3.text = request.downloadHandler.text;
            }
        }
    }

    IEnumerator GetData_Coroutine4()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v17";
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
                    field4.text="OFF";
                }
                else{
                    field4.text="ON";
                }
                
            }
        }
    }

    IEnumerator GetData_Coroutine5()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v20";
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

    IEnumerator GetData_Coroutine6()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v21";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field6.text = request.error;
            else
            {
                tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    field6.text="OFF";
                }
                else{
                    field6.text="ON";
                }
                
            }
        }
    }
    IEnumerator GetData_Coroutine7()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v23";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field7.text = request.error;
            else
            {

                tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    field7.text="OFF";
                }
                else{
                    field7.text="ON";
                }
                
            }
        }
    }

    IEnumerator GetData_Coroutine8()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v22";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field8.text = request.error;
            else
            {

                tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    field8.text="OFF";
                }
                else{
                    field8.text="ON";
                }
                
            }
        }

    }
    IEnumerator GetData_Coroutine9()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v25";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field9.text = request.error;
            else
            {

                tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    field9.text="OFF";
                }
                else{
                    field9.text="ON";
                }
                
            }
        }
    }
    IEnumerator GetData_Coroutine10()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v24";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field10.text = request.error;
            else
            {

                tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    field10.text="OFF";
                }
                else{
                    field10.text="ON";
                }
                
            }
        }
    }
    IEnumerator GetData_Coroutine11()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v27";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field11.text = request.error;
            else
            {

                tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    field11.text="LOW";
                }
                else{
                    field11.text="HIGH";
                }
                
            }
        }
    }
    IEnumerator GetData_Coroutine12()
    {

        string uri = "https://blynk.cloud/external/api/get?token=Y7YA5XJ5Cmt9YtNdYj0ycQyY1Di76LSr&v29";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                field12.text = request.error;
            else
            {
                tempstring = request.downloadHandler.text;
                int.TryParse(tempstring , out tempint);
                if(tempint==0){
                    field12.text="LOW";
                }
                else{
                    field12.text="HIGH";
                }
                
            }   
        }
    }

}