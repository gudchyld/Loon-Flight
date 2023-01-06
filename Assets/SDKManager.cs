using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;

public class SDKManager : MonoBehaviour
{
    public ThirdwebSDK SDK;
    public static SDKManager instance;

   private void Awake() {
    if (instance != null)
    {
        Destroy(gameObject);
    }
    else
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
   }
        
    
    // Start is called before the first frame update
    void Start()
    {
        SDK = new ThirdwebSDK("goerli");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
