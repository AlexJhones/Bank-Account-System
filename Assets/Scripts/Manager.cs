using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int accountNumber;
    public string name, type;
    private float money;
    private bool status;

    public void SetAccountNumber(int value) {
        accountNumber = value;
    }

    /*public GetAccountNumber() {
        return accountNumber;
    }*/

    /*
    public OpenAccount() {


    }

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
        money = 0;
        print(money);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}