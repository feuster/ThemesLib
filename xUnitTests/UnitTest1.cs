namespace xUnitTests
{
    //[Collection("Sequential")]
    public class ThemesUnitTest
    {
        [Fact]
        public void GetThemeById()
        {
            Assert.Equal("Granite 1", Themes.GetThemeById(1).Name);
            Assert.Equal("Blue Red Gradient 100", Themes.GetThemeById(100).Name);
            Assert.Equal(1, Themes.GetThemeById(1).Id);
            Assert.Equal(100, Themes.GetThemeById(100).Id);
        }

        [Fact]
        public void GetThemeByName()
        {
            Assert.Equal("Granite 1", Themes.GetThemeByName("Granite 1").Name);
            Assert.Equal("Blue Red Gradient 100", Themes.GetThemeByName("Blue Red Gradient 100").Name);
            Assert.Equal(1, Themes.GetThemeByName("Granite 1").Id);
            Assert.Equal(100, Themes.GetThemeByName("Blue Red Gradient 100").Id);
        }

        [Fact]
        public void GetThemeByGradient()
        {
            Assert.Equal(Color.White, Themes.GetThemeByGradient(Color.White, Color.Black, 8).GetColor(0));
            Assert.NotEqual(Color.Black, Themes.GetThemeByGradient(Color.White, Color.Black, 8).GetColor(0));
            Assert.Equal(Color.White, Themes.GetThemeByGradient(Color.White, Color.Red, Color.Black).GetColor(0));
            Assert.Equal(Color.FromArgb(0xFF, 0xFF, 0x00, 0x00), Themes.GetThemeByGradient(Color.White, Color.Red, Color.Black).GetColor(3));
            Assert.Equal(Color.Black, Themes.GetThemeByGradient(Color.White, Color.Red, Color.Black).GetColor(7));
        }

        [Fact]
        public void GetThemeColor()
        {
            Assert.Equal(Color.FromArgb(0xFF, 0xFF, 0xFF), Themes.GetThemeColor(1,0));
            Assert.Equal(Color.FromArgb(0xFF, 0xFF, 0xFF), Themes.GetThemeColor("Granite 1", 0));
            Assert.Equal(Color.FromArgb(0x3A, 0x7B, 0x99), Themes.GetThemeColor(1, 0, true));
            Assert.Equal(Color.FromArgb(0xCF, 0x00, 0x1C), Themes.GetThemeColor(100, 7));
            Assert.Equal(Color.FromArgb(0xCF, 0x00, 0x1C), Themes.GetThemeColor("Blue Red Gradient 100", 7));
            Assert.Equal(Color.FromArgb(0x1C, 0x00, 0xCF), Themes.GetThemeColor(100, 7, true));
#if DEBUG
            var ex = Assert.Throws<Exception>(() => Themes.GetThemeColor("", 0));
            Assert.Equal("Exception: Theme is null", ex.Message);
#else
            Assert.Equal(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF), Themes.GetThemeColor("", 1));
#endif
        }

        [Fact]
        public void GetThemeColorCount()
        {
            Assert.Equal(8, Themes.GetThemeColorCount(98));
            Assert.Equal(8, Themes.GetThemeColorCount("Green Blue Gradient 98"));
            Assert.InRange(Themes.GetThemeColorCount(1000), 2, 8);
            Assert.InRange(Themes.GetThemeColorCount(-1000), 2, 8);
#if DEBUG
            var ex = Assert.Throws<Exception>(() => Themes.GetThemeColorCount(""));
            Assert.Equal("Exception: Theme is null", ex.Message);
#else
            Assert.InRange(Themes.GetThemeColorCount(""), 2, 8);
#endif
        }

        [Fact]
        public void GetColor()
        {
            Themes.Theme theme = new Themes.Theme();
            theme = Themes.GetThemeById(22);
            theme.DarkMode = false;
            Assert.Equal(Color.FromArgb(0xFF, 0xFF, 0xFF), theme.GetColor(0));
            theme.DarkMode = true;
            Assert.Equal(Color.FromArgb(0x1E, 0x20, 0x29), theme.GetColor(-10));
        }

        [Fact]
        public void ColorCount()
        {
            Assert.Equal(4, Themes.GetThemeById(1).ColorCount);
            Assert.Equal(8, Themes.GetThemeById(100).ColorCount);
        }

        [Fact]
        public void DarkMode()
        {
            Assert.False(Themes.GetThemeById(5).DarkMode);
            Assert.True(Themes.GetThemeById(97).DarkMode);
        }

        [Fact]
        public void GetThemeNames()
        {
            Assert.Equal("Granite 1", Themes.GetThemeNames(false, false)[0]);
            Assert.NotEqual("Granite 1", Themes.GetThemeNames(true, true)[0]);
        }

        [Fact]
        public void GetThemeNamesByColorCount()
        {
            Assert.Equal("Blue Gradient 88", Themes.GetThemeNamesByColorCount(8, false, false, false)[0]);
            Assert.Equal("Blue Gradient 88 [8]", Themes.GetThemeNamesByColorCount(8, true, true, true)[0]);
        }


        [Fact]
        public void ThemeList()
        {
            Assert.Equal("Granite 1", Themes.ThemeList[0].Name);
            Assert.Equal("Tangerine 77", Themes.ThemeList[76].Name);
        }

        [Fact]
        public void ColorList()
        {
            Assert.Equal(Color.FromArgb(0xFF, 0xFF, 0xFF), Themes.GetThemeById(75).ColorList[0]);
        }

    }
}