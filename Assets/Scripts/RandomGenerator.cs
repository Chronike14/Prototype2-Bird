using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomGenerator : MonoBehaviour
{
    public int ranNum = 0;
    
    // Creates a random number between a determined number in scripts
    private void RandomNumber(int maxNum)
    {
        int ranNum = Random.Range(1, maxNum);
    }
}
