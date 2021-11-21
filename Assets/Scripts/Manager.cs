using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int agency, accountNumber, accountDigit;
    public string accountName, accountType;
    private int accountPassword;
    private float money;
    private bool status;

    public GameObject homeScreen, registrationScreen, loginScreen;

    public Text accountNameText, accountTypeText, accountNumberText, accountDigitText, moneyText;

    public void SetAccountNumber(int value) {

    }

    public void Begin() {
        homeScreen.SetActive(false);
    }

    /*public GetAccountNumber() {
        return accountNumber;
    }*/

    public void OpenAccount()
    {
        agency = 0001;
        accountNumber = Random.Range(0, 9999999);
        accountDigit = Random.Range(0, 8);
        money = 0;
        status = true;
        registrationScreen.SetActive(false);
        SceneManager.LoadScene("BankAccount");
    }
    
    /*
public CloseAccount() {


}

public Deposit() {


}

public Withdraw() {


}

public Pay() {

}

*/

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}