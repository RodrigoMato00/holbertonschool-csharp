﻿using System;

enum Rating { Good, Great, Excellent }

struct Dog
{
    public Dog(string n, float a, string o, Rating r)
    {
        name = n;
        age = a;
        owner = o;
        rating = r;
    }

    public override string ToString()
    {
        return "Dog Name: " + name + "\nAge: " + age + "\nOwner: " + owner + "\nRating: " + rating;
    }


    public string name;
    public float age;
    public string owner;
    public Rating rating;


}