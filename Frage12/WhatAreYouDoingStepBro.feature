Feature: WhatAreYouDoingStepBro
	Stuff

@mytag
Scenario: Sinus
	Given the number is 90
	And the settings are set to degrees
	When the sinus is taken from this number
	Then the result should be 1

Scenario: Cosinus
	Given the number is 90
	And the settings are set to degrees
	When the cosinus is taken from this number
	Then the result should be 0

Scenario: Tangens
	Given the number is 180
	And the settings are set to degrees
	When the tangens is taken from this number
	Then the result should be 0