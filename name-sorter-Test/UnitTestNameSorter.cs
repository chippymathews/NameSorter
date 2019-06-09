using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using name_sorter;

namespace name_sorter_Test
{
    [TestClass]
    public class UnitTestNameSorter
    {
        [TestMethod]
        public void TestMethod_CheckForNamesWithPositiveCase_AtmostThreeNames()
        {
            string[] expectedResult = new string[] { "Marin Alvarez", "Adonis Julius Archer", "Beau Tristan Bentley", "Hunter Uriah Mathew Clarke", "Leo Gardner", "Vaughn Lewis", "London Lindsey", "Mikayla Lopez", "Janet Parsons", "Frankie Conner Ritter", "Shelby Nathan Yoder" };
            string[] actualStringArray = new string[] { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer", "Shelby Nathan Yoder", "Marin Alvarez", "London Lindsey", "Beau Tristan Bentley", "Leo Gardner", "Hunter Uriah Mathew Clarke", "Mikayla Lopez", "Frankie Conner Ritter" };
            NameSorterClass sortObject = new NameSorterClass();
            string[] actualResult = sortObject.sortArrayString(actualStringArray);
            CollectionAssert.Equals(actualResult,expectedResult);
        }
        [TestMethod]
        public void TestMethod_CheckforNamesWithPositiveCase_FirstAndLastNamesOnly()
        {
            string[] expectedResult = new string[] { "Marin  Alvarez", "Leo  Gardner", "Vaughn  Lewis", "London  Lindsey", "Mikayla  Lopez", "Janet  Parsons" };
            string[] actualStringArray = new string[] { "Janet Parsons", "Vaughn Lewis", "Marin Alvarez", "London Lindsey", "Leo Gardner", "Mikayla Lopez" };
            NameSorterClass sortObject = new NameSorterClass();
            string[] actualResult = sortObject.sortArrayString(actualStringArray);
            CollectionAssert.Equals(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_CheckforNamesWithPositiveCase_NamesWithFirstNameOnly()
        {
            string[] expectedResult = new string[] { "Janet", "Leo", "London", "Marin", "Mikayla", "Vaughn" };
            string[] actualStringArray = new string[] { "Janet", "Vaughn", "Marin", "London", "Leo", "Mikayla" };
            NameSorterClass sortObject = new NameSorterClass();
            string[] actualResult = sortObject.sortArrayString(actualStringArray);
            CollectionAssert.Equals(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod_CheckforNamesWithPositiveCase_NamesWithNullAndWhiteSpaceValues()
        {
            string[] expectedResult = new string[] { "Marin  Alvarez", "Adonis Julius Archer", "Beau Tristan Bentley", "Hunter Uriah Mathew Clarke", "Leo  Gardner", "Vaughn  Lewis", "London  Lindsey", "Mikayla  Lopez", "Janet  Parsons", "Frankie Conner Ritter", "Shelby Nathan Yoder" };
            string[] actualStringArray = new string[] { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer", "Shelby Nathan Yoder", "Marin Alvarez", "London Lindsey", "Beau Tristan Bentley", "Leo Gardner", "Hunter Uriah Mathew Clarke", "Mikayla Lopez", "Frankie Conner Ritter", " ", "",null };
            NameSorterClass sortObject = new NameSorterClass();
            string[] actualResult = sortObject.sortArrayString(actualStringArray);
            CollectionAssert.Equals(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod_CheckforNamesWithPositiveCase_NamesWithNumericValues()
        {
            string[] expectedResult = new string[] { "Marin  Alvarez", "Adonis Julius Archer", "Beau Tristan Bentley", "Hunter Uriah Mathew Clarke", "Leo  Gardner", "Vaughn  Lewis", "London  Lindsey", "Mikayla  Lopez", "Janet  Parsons", "Frankie Conner Ritter", "Shelby Nathan Yoder" };
            string[] actualStringArray = new string[] { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer", "Shelby Nathan Yoder", "Marin Alvarez", "London Lindsey", "Beau Tristan Bentley", "Leo Gardner", "Hunter Uriah Mathew Clarke", "Mikayla Lopez", "Frankie Conner Ritter", "1", "2", "3" };
            NameSorterClass sortObject = new NameSorterClass();
            string[] actualResult = sortObject.sortArrayString(actualStringArray);
            CollectionAssert.Equals(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod_CheckforNamesWithPositiveCase_NamesWithSpecialCharacters()
        {
            string[] expectedResult = new string[] { "Marin  Alvarez", "Adonis Julius Archer", "Beau Tristan Bentley", "Hunter Uriah Mathew Clarke", "Leo  Gardner", "Vaughn  Lewis", "London  Lindsey", "Mikayla  Lopez", "Janet  Parsons", "Frankie Conner Ritter", "Shelby Nathan Yoder" };
            string[] actualStringArray = new string[] { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer", "Shelby Nathan Yoder", "Marin Alvarez", "London Lindsey", "Beau Tristan Bentley", "Leo Gardner", "Hunter Uriah Mathew Clarke", "Mikayla Lopez", "Frankie Conner Ritter", "#", "$", "&" };
            NameSorterClass sortObject = new NameSorterClass();
            string[] actualResult = sortObject.sortArrayString(actualStringArray);
            CollectionAssert.Equals(expectedResult, actualResult);
        }
    }
}