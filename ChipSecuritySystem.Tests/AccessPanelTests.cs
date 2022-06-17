using System.Collections.Generic;
using Xunit;

namespace ChipSecuritySystem.Tests
{
    public class AccessPanelTests
    {
        [Fact]
        public void Test_BY_RG_YR_OP_ReturnsSuccess()
        {
            //  Arrange
            List<ColorChip> chips = new List<ColorChip>();
            ColorChip blueYellow = new ColorChip(Color.Blue, Color.Yellow);
            ColorChip redGreen = new ColorChip(Color.Red, Color.Green);
            ColorChip yellowRed = new ColorChip(Color.Yellow, Color.Red);
            ColorChip orangePurple = new ColorChip(Color.Orange, Color.Purple);
            chips.Add(redGreen);
            chips.Add(blueYellow);
            chips.Add(yellowRed);
            chips.Add(orangePurple);

            string expected = "[Blue, Yellow][Yellow, Red][Red, Green]";

            // Act
            string actual = AccessPanel.OpenSesame(chips);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_BY_RG_OP_YR_ReturnsSuccess()
        {
            //  Arrange
            List<ColorChip> chips = new List<ColorChip>();
            ColorChip blueYellow = new ColorChip(Color.Blue, Color.Yellow);
            ColorChip redGreen = new ColorChip(Color.Red, Color.Green);
            ColorChip yellowRed = new ColorChip(Color.Yellow, Color.Red);
            ColorChip orangePurple = new ColorChip(Color.Orange, Color.Purple);

            chips.Add(blueYellow);
            chips.Add(redGreen);
            chips.Add(orangePurple);
            chips.Add(yellowRed);

            string expected = "[Blue, Yellow][Yellow, Red][Red, Green]";

            // Act
            string actual = AccessPanel.OpenSesame(chips);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_OP_YB_PG_RO_BR_ReturnsSuccess()
        {
            //  Arrange
            List<ColorChip> chips = new List<ColorChip>();
            ColorChip orangePurple = new ColorChip(Color.Orange, Color.Purple);
            ColorChip yellowBlue = new ColorChip(Color.Yellow, Color.Blue);
            ColorChip purpleGreen = new ColorChip(Color.Purple, Color.Green);
            ColorChip redOrange = new ColorChip(Color.Red, Color.Orange);
            ColorChip blueRed = new ColorChip(Color.Blue, Color.Red);

            chips.Add(orangePurple);
            chips.Add(yellowBlue);
            chips.Add(purpleGreen);
            chips.Add(redOrange);
            chips.Add(blueRed);

            string expected = "[Blue, Red][Red, Orange][Orange, Purple][Purple, Green]";

            // Act
            string actual = AccessPanel.OpenSesame(chips);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_YR_BY_OP_ReturnsError()
        {
            //  Arrange
            List<ColorChip> chips = new List<ColorChip>();
            ColorChip blueYellow = new ColorChip(Color.Blue, Color.Yellow);
            ColorChip yellowRed = new ColorChip(Color.Yellow, Color.Red);
            ColorChip orangePurple = new ColorChip(Color.Orange, Color.Purple);

            chips.Add(yellowRed);
            chips.Add(blueYellow);
            chips.Add(orangePurple);

            string expected = "Cannot unlock master panel";

            // Act
            string actual = AccessPanel.OpenSesame(chips);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_BO_RG_OP_RO_ReturnsError()
        {
            //  Arrange
            List<ColorChip> chips = new List<ColorChip>();
            ColorChip blueOrange = new ColorChip(Color.Blue, Color.Orange);
            ColorChip redGreen = new ColorChip(Color.Red, Color.Green);
            ColorChip orangePurple = new ColorChip(Color.Orange, Color.Purple);
            ColorChip redOrange = new ColorChip(Color.Red, Color.Orange);

            chips.Add(blueOrange);
            chips.Add(redGreen);
            chips.Add(orangePurple);
            chips.Add(redOrange);

            string expected = "Cannot unlock master panel";

            // Act
            string actual = AccessPanel.OpenSesame(chips);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
