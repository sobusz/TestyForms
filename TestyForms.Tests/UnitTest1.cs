using MathModules;
using NUnit.Framework;
using System;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestyForms.Tests
{
    [TestFixture]

    public class Tests
    {
        private CalculatePithagoras _calc;

        [OneTimeSetUp]
        public void Init()
        {
            _calc = new CalculatePithagoras();
        }

        [Test]
        public void sideA_isNegative()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcSideC(-3, 4));

            Assert.That(ex.Message == "Bok A nie mo¿e byæ ujemny");
        }

        [Test]
        public void sideB_isNegative()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcSideC(3, -4));

            Assert.That(ex.Message == "Bok B nie mo¿e byæ ujemny");
        }

        [Test]
        public void sideA_EqualsZero()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcSideC(0, 4));

            Assert.That(ex.Message == "Bok A nie mo¿e byæ równy zero");
        }

        [Test]
        public void sideB_EqualsZero()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcSideC(3, 0));

            Assert.That(ex.Message == "Bok B nie mo¿e byæ równy zero");
        }

        [Test]
        public void sideA_inCirc_isNegative()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcCirc(-3, 4));

            Assert.That(ex.Message == "Bok A nie mo¿e byæ ujemny przy obwodzie");
        }

        [Test]
        public void sideB_inCirc_isNegative()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcCirc(3, -4));

            Assert.That(ex.Message == "Bok B nie mo¿e byæ ujemny przy obwodzie");
        }

        [Test]
        public void sideA_inCirc_EqualsZero()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcCirc(0, 4));

            Assert.That(ex.Message == "Bok A nie mo¿e byæ równy zero przy obwodzie");
        }

        [Test]
        public void sideB_inCirc_EqualsZero()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcArea(3, 0));

            Assert.That(ex.Message == "Bok B nie mo¿e byæ równy zero przy polu");
        }

        [Test]
        public void sideA_inArea_isNegative()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcArea(-3, 4));

            Assert.That(ex.Message == "Bok A nie mo¿e byæ ujemny przy polu");
        }

        [Test]
        public void sideB_inArea_isNegative()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcArea(3, -4));

            Assert.That(ex.Message == "Bok B nie mo¿e byæ ujemny przy polu");
        }

        [Test]
        public void sideA_inArea_EqualsZero()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcArea(0, 4));

            Assert.That(ex.Message == "Bok A nie mo¿e byæ równy zero przy polu");
        }

        [Test]
        public void sideB_inArea_EqualsZero()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.calcArea(3, 0));

            Assert.That(ex.Message == "Bok B nie mo¿e byæ równy zero przy polu");
        }



        //______________________________TESTY SELENIUM ____________________________________________

        [TestFixture()]
        public class SeleniumTests
        {
            private IWebDriver driver;
            private string URL;

            [OneTimeSetUp]
            public void Init()
            {
                driver = new ChromeDriver();
                URL = "https://www.google.pl";
            }
            [OneTimeTearDown]
            public void TearDownTests()
            {
                driver.Close();
            }

            [Test]
            public void IsCurrentWebsiteGoogle()
            {
                driver.Navigate().GoToUrl(URL);

                Assert.AreSame("https://www.google.pl", URL);
            }

            [Test]
            public void IsTemperatureAbove15DegreesCelsius()
            {
                driver.Navigate().GoToUrl(URL);
                driver.Manage().Window.Maximize();

                IWebElement searchElement = driver.FindElement(By.Name("q"));
                searchElement.SendKeys("pogoda");
                searchElement.Submit();
                String temperature = driver.FindElement(By.XPath("//span[starts-with(@id, 'wob_tm')]")).Text;

                Assert.GreaterOrEqual(temperature, "15");
            }

            [Test]
            public void IsChanceOfRainHigherThan20Percent()
            {
                driver.Navigate().GoToUrl(URL);
                driver.Manage().Window.Maximize();

                IWebElement searchElement = driver.FindElement(By.Name("q"));
                searchElement.SendKeys("pogoda");
                searchElement.Submit();
                String rain = driver.FindElement(By.XPath("//span[starts-with(@id, 'wob_pp')]")).Text.Trim('%');

                Assert.GreaterOrEqual(rain, "20");
            }

            [Test]
            public void IsFHot16Challenge2StillTrendingOnYoutube()
            {
                driver.Navigate().GoToUrl("https://www.youtube.com/feed/trending");
                driver.Manage().Window.Maximize();

     
                var foundHot16 = false;
                var titles = driver.FindElements(By.XPath("//*[@id='video-title']/yt-formatted-string"));

                foreach (var title in titles)
                {
                    if (title.Text.Contains("#hot16challenge2"))
                    {
                        foundHot16 = true;
                    }
                }

                Assert.IsTrue(foundHot16);
            }

            [Test]
            public void IsFHot16Challenge2StillTrendingOnYoutube_AndMoreThan10()
            {
                driver.Navigate().GoToUrl("https://www.youtube.com/feed/trending");
                driver.Manage().Window.Maximize();


                var foundHot16 = false;
                int counter = 0;
                var titles = driver.FindElements(By.XPath("//*[@id='video-title']/yt-formatted-string"));

                foreach (var title in titles)
                {
                    if (title.Text.Contains("#hot16challenge2"))
                    {
                        foundHot16 = true;
                        counter++;
                    }
                }

                Assert.Greater(counter, 10);
            }
        }
    }
}