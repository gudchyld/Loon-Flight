using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Thirdweb;
using System.Threading.Tasks;

public class ClaimManager : MonoBehaviour
{
    public LogicScript logic;
    public Text claimText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public async Task ClaimToken(){
        Contract contract = SDKManager.instance.SDK.GetContract("0xa6d226b81D29db300E7D4B1a00BEd36b0cef2Feb");
        await contract.ERC20.Claim("2");
    }

    public async void Claim(){

        if(logic.playerScore >= 1000){
            await ClaimToken();

        }
        else
        {
            claimText.text = "score 1000 points or more to claim loons";
        }
        

    }
}
