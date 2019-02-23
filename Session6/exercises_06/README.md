# DNP Exercises 06 - Unit Testing and TDD


## Exercise 1 - Unit testing in .NET

In this exercise you are provided a project in [./exercise_01/](./exercise_1) to start out with. Take a look at the classes in `GameModel` and implement the empty tests in `GameModel.Tests`. Try to figure out what you should test from the names of the test methods.

Follow the principles from [Unit Testing Best Pracices](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#best-practices).


## Exercise 2 - Fact and Theory

Rewrite as many tests in `HeroTest` as possible using [`Theory` and `InlineData`](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test#adding-more-features)


## Exercise 3 - Project Setup

Create a new solution with a `classlib` project and a `xunit` project. Extract the code that are counting words and finding the longest word of a string from Exercise 1 in week 4, and create unit tests for them (recall the **Z**ero **O**ne **M**any **B**oundaries **I**nterfaces **E**xceptions **S**imple principles from SWE).


Use [Unit testing C# in .NET Core using dotnet test and xUnit](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test) as a reference for setting up the solution, and the [ASP.Net Engineering Guidelines](https://github.com/aspnet/Home/wiki/Engineering-guidelines#unit-tests-and-functional-tests) for naming guidelines.


## Exercise 4 - Dependency Injection

The `Combat` class simulates different combats between two Heroes (provided with the starter code in the exercise_4 folder). The class uses a random number generator making it hard to test. Refactor the class so that the methods `FlipCoin()` and `RollDice()` are moved to an other class. This class should implement an interface declaring these two methods. Finally provide the class to the `Combat` class when instantiated (dependency injection). 


## Exercise 5 - Fakes, Stubs and Mocks

Test the `Combat` class from previous exercise, creating stubs for `FlipCoin()` and `RollDice()`. Improve the class where your tests expose bugs or weaknesses.

[reference](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#lets-speak-the-same-language)


## Exercise 6 - Test Driven Development

Using TDD, write a program that generates a string of integers, starting at 1 and going up to 100 (separated by commas). Substitute any integer which is divisible by 3 with "Fizz", and any integer which is divisible by 5 with "Buzz", and any integer divisible by 3 and 5 with "FizzBuzz".

For example, the first 20 values would be:

    1
    2
    Fizz
    4
    Buzz
    Fizz
    7
    8
    Fizz
    Buzz
    11
    Fizz
    13
    14
    FizzBuzz
    16
    17
    Fizz
    19
    Buzz

Remember, all implementation logic should be driven by tests, using the below workflow:

1. Write a test
2. Run all tests and see the new one fail
3. Write the simplest code to pass the test
4. Run all tests and see them succeed
5. Refactor
6. Repeat from step 1