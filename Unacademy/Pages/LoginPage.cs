using OpenQA.Selenium;


namespace Unacademy
{
    public class LoginPage : UtilityClass
    {

        private IWebDriver driver;

        
        private By Login_Button = By.XPath("//*[@id='__next']/header/div/div/button");
        private By create_your_account_Link = By.LinkText("create your account");
        private By Enter_your_mobile_number_Text_Box = By.XPath("//*[@id='DrawerPaper']/div[2]/div[2]/div/input");
        private By Continue_Button = By.XPath("//*[@id='DrawerPaper']/div[2]/div[3]/button");
       // private By One_time_password_TextBox = By.CssSelector("#DrawerPaper > div.css-xp9rdl-Wrapper.ez6l2f00 > form > div.MuiInputBase-root.MuiOutlinedInput-root.e8butdu1.css-1c3du3e-StyledTextField-StyledTextField.ena7kom1.MuiInputBase-fullWidth > input");
        private By Name_TextBox = By.XPath("//*[@id='DrawerPaper']/div[2]/form/div[2]/input");
        private By Email_address_TextBox = By.XPath("//*[@id='DrawerPaper']/div[2]/form/div[3]/input");
        private By Select_State_of_residence_Dropdown = By.XPath("//*[@id='DrawerPaper']/div[2]/form/div[4]/button");
        private By check_Box = By.XPath("//*[@id='DrawerPaper']/div[2]/form/div[5]/span[1]/span/input");
        private By Submit_Button = By.XPath("//*[@id='DrawerPaper']/div[2]/div[2]/button");
        
        private By Click_On_Login_Button = By.XPath("//*[@id='DrawerPaper']/div[2]/div[3]/button");
        private By Verify_OTP = By.XPath("//*[@id='DrawerPaper']/div[2]/div[2]/button");
        public LoginPage(IWebDriver driver)
        {
            

            this.driver = driver;
        }

        public void LoginButton()
        {
            driver.FindElement(Login_Button).Click();
        }

        public void createyouraccountLink()
        {
            driver.FindElement(create_your_account_Link).Click();
        }

        public void EnteryourmobilenumberTextBox(String MobileNumber)
        {
            driver.FindElement(Enter_your_mobile_number_Text_Box).SendKeys(MobileNumber);
        }

        public void ContinueButton()
        {
            driver.FindElement(Continue_Button).Click();
        }
        /*
        public void onetimepassword(string OTP)
        {
            driver.FindElement(One_time_password_TextBox).SendKeys(OTP);
        }*/

        public void NameTextBox(string Name)
        {
            driver.FindElement(Name_TextBox).SendKeys("Ramya");
        }

        public void EmailaddressTextBox(string Emailaddress)
        {
            driver.FindElement(Email_address_TextBox).SendKeys("ramyaganga12@gmail.com");
        }

        public void SelectStateofresidenceDropdown()
        {
            driver.FindElement(Select_State_of_residence_Dropdown).SendKeys("Karnataka");
        }

        public void checkBox()
        {
            driver.FindElement(check_Box).Click();
        }
        public void SubmitButton()
        {
            driver.FindElement(Submit_Button).Click();
        }


        public void LoginButton1()
        {
            driver.FindElement(Click_On_Login_Button).Click();
        }

       
       
        public void Verify_OTP_Button()
        {
            driver.FindElement(Verify_OTP).Click();
        }

       
    }
}

