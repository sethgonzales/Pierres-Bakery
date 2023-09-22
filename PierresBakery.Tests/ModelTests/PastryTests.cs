// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using ScrabbleScorer.Models;
// using System;

// namespace ScrabbleScorer.Tests
// {
//   [TestClass]
//   public class ScrabbleWordTests
//   {
//     [TestMethod]
//     public void ScrabbleWordConstructor_CreateInstanceOfPalindrome_ScrabbleWord()
//     {
//       ScrabbleWord checkWord = new ScrabbleWord("panino");
//       // assert
//       Assert.AreEqual(typeof(ScrabbleWord), checkWord.GetType());
//     }
//     [TestMethod]
//     public void WordArray_TransformUserInputIntoArray_Array()
//     {
//       //arrange
//       string userInput = "panino";
//       ScrabbleWord newWord = new ScrabbleWord("panino");
//       // act
//       char[] expectArray = userInput.ToUpper().ToCharArray();
//       char[] theorArray = newWord.WordArray();
//       //assert
//       CollectionAssert.AreEqual(expectArray, theorArray);
//     }
//     [TestMethod]
//     public void GetPoints_ReturnsScoreForSpecifiedCharacter_Int()
//     {
//       // arrange
//       ScrabbleWord newWord = new ScrabbleWord("p");
//       // act
//       int points = newWord.GetPoints();
//       // assert
//       Assert.AreEqual(3, points);
//     }
//   [TestMethod]
//     public void GetPoints_ReturnsScoreForSpecifiedWord_Int()
//     {
//       // arrange
//       ScrabbleWord newWord = new ScrabbleWord("panino");
//       // act
//       int points = newWord.GetPoints();
//       // assert
//       Assert.AreEqual(8, points);
//     }
//   }
// }