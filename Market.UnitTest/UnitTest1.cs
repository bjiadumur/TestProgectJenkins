using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Market.UnitTest
{

	[TestFixture]
	[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
	public class Untitled2
	{
		private IWebDriver driver;
		private StringBuilder verificationErrors;
		private string baseURL;
		private bool acceptNextAlert = false;


		[SetUp]

		public void SetupTest()
		{
			driver = new FirefoxDriver();
			baseURL = "http://localhost:888/market";
			verificationErrors = new StringBuilder();
		}

		[Test]
		[Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
		public void TheCase1Test()
		{
			SetupTest();
			driver.Navigate().GoToUrl(baseURL + "/");
			Thread.Sleep(1000);
			driver.FindElement(By.LinkText("Главная")).Click();
			Thread.Sleep(1000);
			driver.FindElement(By.CssSelector("input.btn.btn-success")).Click();
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("1", driver.FindElement(By.CssSelector("td.text-center")).Text);
		}
		private bool IsElementPresent(By by)
		{
			try
			{
				driver.FindElement(by);
				return true;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}


	}
}

