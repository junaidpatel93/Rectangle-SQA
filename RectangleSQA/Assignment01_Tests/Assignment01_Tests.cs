using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleSQA;
using NUnit.Framework;

namespace Assignment01_Tests
{
    [TestFixture]
    class Assignment01_Tests
    {
        [Test]
        public void GetLength_input3_expectLengthEquals3()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle rect = new Rectangle(l, w);

            //Act
            int length = rect.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }

        [Test]
        public void SetLength_userInput_ExpectChangedValue()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle rect = new Rectangle(l, w);

            //Act
            int length = rect.SetLength(5);

            //Assert
            Assert.AreNotEqual(length, l);

        }

        [Test]
        public void GetWidth_input3_expectWidthEquals3()
        {
            //Arrange
            int l = 4;
            int w = 3;
            Rectangle rect = new Rectangle(l, w);

            //Act
            int width = rect.GetWidth();

            //Assert
            Assert.AreEqual(width, w);
        }

        [Test]
        public void SetWidth_userInput_ExpectChangedValue()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle rect = new Rectangle(l, w);

            //Act
            int width = rect.SetWidth(5);

            //Assert
            Assert.AreNotEqual(width, w);

        }

        [Test]
        public void GetPerimeter_calculatedValue_expectedValue14()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle rect = new Rectangle(l, w);

            //Act
            int perimeter = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(perimeter, 2 * (l + w));
        }

        [Test]
        public void GetArea_calculatedValue_expectedValue12()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle rect = new Rectangle(l, w);

            //Act
            int area = rect.GetArea();

            //Assert
            Assert.AreEqual(area, l * w);
        }
    }
}
