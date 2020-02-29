using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class d6 : MonoBehaviour
{
    public int rolld6()
    {
        System.Random rnd = new System.Random();
        int die = rnd.Next(1,6);
        return die;
    }

    public int largest3(int[] d6s)
    {
        int first, second, third, sum;
        first = second = third = 0;
        for(int i = 0; i < 5; i++)
        {
            if(d6s[i] > first)
            {
                third = second;
                second = first;
                first = d6s[i];
            }
            else if(d6s[i] > second)
            {
                third = second;
                second = d6s[i];
            }
            else if(d6s[i] > third)
            {
                third = d6s[i];
            }
        }
        sum = first + second + third;
        return sum;
    }

    public int[] roll5d6()
    {
        int[] d6s = new int[5];
        for (int i = 0; i < 5; i++)
        {
            d6s[i] = rolld6();
        }
        return d6s;
    }

    public int result()
    {
        int modifier = 2;
        int sum = largest3(roll5d6());
        return sum + modifier;
    }
}
