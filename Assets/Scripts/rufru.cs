using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class rufru : MonoBehaviour
{
    public Text score;
    public scoremanageer sm;
    void Start()
    {
        score.text = sm.score.ToString();
    }

    
}
