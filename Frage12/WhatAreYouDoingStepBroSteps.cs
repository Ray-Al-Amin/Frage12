using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Frage12
{
    [Binding]
    public class WhatAreYouDoingStepBroSteps
    {
        double number, number2;
        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(double p0)
        {
            number = p0;
        }

        [Given(@"the settings are set to degrees")]
        public void GivenTheSettingsAreSetToDegrees()
        {
            // die funktionen rechnen nur in radian deswegen wird hier die degree zahl zu radian umgewandelt
            number = number * Math.PI / 180;
        }


        [When(@"the sinus is taken from this number")]
        public void WhenTheSinusIsTakenFrom()
        {
            number2 = Math.Sin(number);
        }

        [When(@"the cosinus is taken from this number")]
        public void WhenTheCosinusIsTakenFrom()
        {
            number2 = Math.Cos(number);
        }

        [When(@"the tangens is taken from this number")]
        public void WhenTheTangensIsTakenFrom()
        {
            number2 = Math.Tan(number);
        }


        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            Assert.Equal(p0, number2, 5);
        }
    }
}
