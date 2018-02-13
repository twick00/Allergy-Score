using System;
using System.Collections.Generic;
using Allergies;

namespace Allergies.Models
{
    public class Allergy
    {
        private Dictionary<int,String> _allergyDict = new Dictionary<int,String>
        {
            {128, "Cats"},
            {64, "Pollen"},
            {32, "Chocolate"},
            {16, "Tomatoes"},
            {8, "Strawberries"},
            {4, "Shellfish"},
            {2, "Peanuts"},
            {1, "Eggs"},
        };
        private int _allergyNumber;
        private List<String> _allergyList = new List<String>{};
        // public Allergy(int allergyNumber)
        // {
        //     _allergyNumber = allergyNumber;
        // }
        public List<String> GetAllergyList (int allergyNumber)
        {
            int tempAllergyNumber = allergyNumber;
            foreach(KeyValuePair<int,String> allergen in _allergyDict)
            {
                if (tempAllergyNumber >= allergen.Key)
                {
                    tempAllergyNumber -= allergen.Key;
                    _allergyList.Add(allergen.Value);
                }
                if (tempAllergyNumber == 0)
                {
                    //This should slightly improve runtime by immediately returning once it finds the last allergen.
                    return _allergyList;
                }
            }
            return _allergyList;
        }
    }
}