using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class StartManager : MonoBehaviour
{
    public GameObject connected;
    public GameObject disconnected;
    public GameObject enterBtn;
    public TMPro.TextMeshProUGUI addressTxt; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void ConnectWallet(){
        string address = await SDKManager.instance.SDK.wallet.Connect(new Thirdweb.WalletConnection()
        {
                provider = Thirdweb.WalletProvider.MetaMask,
                chainId = 5
                
        }
        );
        addressTxt.text = address;

        connected.SetActive(true);
        disconnected.SetActive(false);
    }

    public void EnterGame(){
        SceneManager.LoadScene("BirdScene");
    }

    public void showGameplay(){
        SceneManager.LoadScene("Gameplay");
    }
}
