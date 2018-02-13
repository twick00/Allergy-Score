using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Allergies.Models;

namespace Allergies.Tests
{
    [TestClass]
    public class AllergyTest
    {
        [TestMethod]
        public void GetAllergy_ReturnsAllergyList_StringList()
        {
            int allergyNumber = 176; //This translates to Cats, Chocolate and Tomatoes
            Allergy allergyObj = new Allergy();
            List<String> calcAllergyList = allergyObj.GetAllergyList(allergyNumber);
            List<String> outputString = new List<String>{"Cats", "Chocolate", "Tomatoes"};

            CollectionAssert.AreEqual(outputString, calcAllergyList);
        }
        [TestMethod]
        public void GetFalseAllergy_ReturnsAllergyList_StringList()
        {
            int allergyNumber = 175; //This translates to Cats, Chocolate and Tomatoes
            Allergy allergyObj = new Allergy();
            List<String> calcAllergyList = allergyObj.GetAllergyList(allergyNumber);
            List<String> outputString = new List<String> { "Cats", "Chocolate", "Tomatoes" };

            CollectionAssert.AreNotEqual(outputString, calcAllergyList);
        }
    }
}


