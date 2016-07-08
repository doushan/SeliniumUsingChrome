# ex2Chrome
Finding elements in Selenium WebDriver Using Chrome Browser

Dowload chrome driver from HERE ---->>>>> https://sites.google.com/a/chromium.org/chromedriver/downloads   <<<<<<<---------



Selenium Overview
What is Selenium?
Selenium is the open source web application testing framework released under apache license. It supports programming in many languages as mentioned below:
C#.Net
Java
PHP
Ruby
Python
Perl
What is Web Driver?
The Selenium WebDriver is used to execute tests on particular browser. Some supported web drivers are:
Firefox, Chrome, IE, Opera, Safari.

Installing Selenium with C#.Net

List of Software needed:
Microsoft Visual Studio
Selenium C#.Net API (DLL file) download @ http://docs.seleniumhq.org/download

Follow steps below to get started:
Open Visual Studio
Create a new console application for C# and name it SampleTest
Go to project properties, right click and select add references. Browse the dll file you have downloaded from Seleniumhq.
Click OK.

You now have a project with Selenium API incorporated.

Finding elements in Selenium WebDriver

In Selenium terminology, all objects in the webpage are treated as webelements. These can be identify via the following:
Xpath, CSS, Id, Name, Class Name, Tag Name, Link Text

Below code will navigate to google, input ‘Pampers’ in the search box and click on search button:

IWebDriver driver = new FirefoxDriver();
driver.Manage().Window.Maximise();
driver.Navigate().GoToUrl("http://www.google.com");
driver.FindElement(By.Xpath(“.//*[@id='gs_htif0']”)).SendKeys(“Pampers”);
driver.FindElement(By.Xpath(“.//*[.//*[@name="btnK"]]”).Click();
Thread.Sleep(5000);
driver.Quit();

Note: We use Xpath as identification of webelements. You may use ID, Class or Tagname as well.

