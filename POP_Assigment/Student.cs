using POP_Assigment.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Assigment
{
    public class Student : Person
    {
        
        public string StudentNumber { get; set; }
        public int Age { get; set; }
        public Adress Adress { get; set; }
        private string City
        {
            get
            {
                return Adress.City;
            }
        }
        public string FullName
        {
            get
            {
                string Full = FirstName + " " + LastName;
                return Full;
            }
        }
        public int[] Scores { get; set; }
        public float AverageScore
        {
            get
            {
                float sum = 0;
                for (int i = 0; i < Scores.Length; i++)
                {
                    sum += Scores[i];
                }
                return sum / Scores.Length;
            }
        }
        public string FullAddress
        {
            
            get
            {
                string Fullad;
                Fullad = Adress.Country + " " + Adress.City + " " + Adress.Street + " " + Adress.Address;
                return Fullad;
            }
        }
        public override string ToString()
        {
            return $"-	Student {FullName} address is {FullAddress}\n " +
                $"-	Student {FullName} is living in {City}\n " +
                $"-	Student {FullName} score is {AverageScore}\n ";
        }
        
    }
}
